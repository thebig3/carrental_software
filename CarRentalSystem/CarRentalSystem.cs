using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarRentalSystem
{
    public partial class CarRentalSystem : Form
    {
        private String connectionString = "server=127.0.0.1;uid=root;pwd='';database=car_rental_system;";
        private String selectedPlateNumber;

        public CarRentalSystem()
        {
            InitializeComponent();
        }

        private void CarRentalSystem_Load(object sender, EventArgs e)
        {
            UpdateDgvInv();
        }

        private void UpdateDgvInv()
        {
            using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                using (MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter())
                {
                    mySqlAdapter.SelectCommand = new MySqlCommand("SELECT * FROM car ORDER BY PricePerDay ASC, Brand ASC", mySqlConnection);
                    mySqlAdapter.SelectCommand.Parameters.AddWithValue("@isAvailable", "Yes");

                    DataTable dt = new DataTable();
                    mySqlAdapter.Fill(dt);

                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;

                    dgvInv.DataSource = bs;

                    dgvInv.Columns[0].HeaderText = "Plate Number";
                    dgvInv.Columns[3].HeaderText = "Price Per Day";
                    dgvInv.Columns[4].HeaderText = "Available?";

                    dgvInv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                mySqlConnection.Close();
            }
        }

        private void UpdateDgvRent()
        {
            using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                using (MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter())
                {
                    mySqlAdapter.SelectCommand = new MySqlCommand("SELECT * FROM car WHERE IsAvailable = @isAvailable ORDER BY PricePerDay ASC, Brand ASC", mySqlConnection);
                    mySqlAdapter.SelectCommand.Parameters.AddWithValue("@isAvailable", "Yes");
                    DataTable dt = new DataTable();
                    mySqlAdapter.Fill(dt);

                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;

                    dgvRent.DataSource = bs;
                    dgvRent.Columns[0].HeaderText = "Plate Number";
                    dgvRent.Columns[3].HeaderText = "Price Per Day";
                    dgvRent.Columns[4].HeaderText = "Available?";

                    dgvRent.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                mySqlConnection.Close();
            }
        }

        private void UpdateDgvReturn()
        {
            using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                using (MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter())
                {
                    mySqlAdapter.SelectCommand = new MySqlCommand("SELECT * FROM rentedcar ORDER BY RentDate ASC", mySqlConnection);
                    DataTable dt = new DataTable();
                    mySqlAdapter.Fill(dt);

                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;

                    dgvReturn.DataSource = bs;
                    dgvReturn.Columns[0].HeaderText = "Plate Number";
                    dgvReturn.Columns[1].HeaderText = "Renter Name";
                    dgvReturn.Columns[2].HeaderText = "Renter Address";
                    dgvReturn.Columns[3].HeaderText = "Rent Date";

                    dgvReturn.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                mySqlConnection.Close();
            }
        }

        private void UpdateDgvReturnLog()
        {
            using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                using (MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter())
                {
                    mySqlAdapter.SelectCommand = new MySqlCommand("SELECT * FROM returnlog ORDER BY ReturnDate ASC", mySqlConnection);
                    DataTable dt = new DataTable();
                    mySqlAdapter.Fill(dt);

                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;

                    dgvReturnLog.DataSource = bs;
                    dgvReturnLog.Columns[0].HeaderText = "Plate Number";
                    dgvReturnLog.Columns[1].HeaderText = "Renter Name";
                    dgvReturnLog.Columns[2].HeaderText = "Rent Date";
                    dgvReturnLog.Columns[3].HeaderText = "Return Date";
                    dgvReturnLog.Columns[4].HeaderText = "Price Per Day";
                    dgvReturnLog.Columns[5].HeaderText = "Total";
                    dgvReturnLog.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                mySqlConnection.Close();
            }
        }

        private void priceConstraints(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) 
                || ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
                    e.Handled = true;

        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            if (tbAddPlate.Text != String.Empty && tbAddBrand.Text != String.Empty && tbAddModel.Text != String.Empty && tbAddPrice.Text != String.Empty)
            {
                using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO car(PlateNumber, Brand, Model, PricePerDay) VALUES(@plateNumber, @brand, @model, @price)", mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@plateNumber", tbAddPlate.Text);
                        cmd.Parameters.AddWithValue("@brand", tbAddBrand.Text);
                        cmd.Parameters.AddWithValue("@model", tbAddModel.Text);
                        cmd.Parameters.AddWithValue("@price", tbAddPrice.Text);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }

                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Plate number already exists.");
                        }
                    }
                    mySqlConnection.Close();
                }

                tbAddPlate.Text = String.Empty;
                tbAddBrand.Text = String.Empty;
                tbAddModel.Text = String.Empty;
                tbAddPrice.Text = String.Empty;
                UpdateDgvInv();
            }
        }

        private void dgvInv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInv.SelectedRows)
            {
                selectedPlateNumber = tbEditPlate.Text = row.Cells[0].Value.ToString();
                tbEditBrand.Text = row.Cells[1].Value.ToString();
                tbEditModel.Text = row.Cells[2].Value.ToString();
                tbEditPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (tbEditPlate.Text != String.Empty && tbEditBrand.Text != String.Empty && tbEditModel.Text != String.Empty && tbEditPrice.Text != String.Empty)
            {
                foreach (DataGridViewRow row in dgvInv.SelectedRows)
                {
                    using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                    {
                        mySqlConnection.Open();
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE car SET PlateNumber = @plateNumber, Brand = @brand, Model = @model, PricePerDay = @price WHERE PlateNumber = @selectedPlateNumber", mySqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@plateNumber", tbEditPlate.Text);
                            cmd.Parameters.AddWithValue("@brand", tbEditBrand.Text);
                            cmd.Parameters.AddWithValue("@model", tbEditModel.Text);
                            cmd.Parameters.AddWithValue("@price", tbEditPrice.Text);
                            cmd.Parameters.AddWithValue("@selectedPlateNumber", selectedPlateNumber);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }

                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Plate number already exists.");
                            }
                        }
                        mySqlConnection.Close();
                    }
                }
            }
            UpdateDgvInv();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInv.SelectedRows)
            {
                selectedPlateNumber = row.Cells[0].Value.ToString();

                using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM car where PlateNumber = @plateNumber", mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@plateNumber", selectedPlateNumber);
                        cmd.ExecuteNonQuery();
                    }
                    mySqlConnection.Close();
                }
            }

            UpdateDgvInv();
        }

        private void dgvRent_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRent.SelectedRows)
                selectedPlateNumber = row.Cells[0].Value.ToString();
        }

        private void btnConfirmRent_Click(object sender, EventArgs e)
        {
            if (tbName.Text != String.Empty && tbAddress.Text != String.Empty)
            {
                foreach (DataGridViewRow row in dgvInv.SelectedRows)
                {
                    using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                    {
                        mySqlConnection.Open();
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE car SET IsAvailable = @isAvailable WHERE PlateNumber = @selectedPlateNumber", mySqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@isAvailable", "No");
                            cmd.Parameters.AddWithValue("@selectedPlateNumber", selectedPlateNumber);
                            cmd.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO rentedcar(PlateNumber, RenterName, RenterAddress, RentDate) VALUES(@plateNumber, @name, @address, @date)", mySqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@plateNumber", selectedPlateNumber);
                            cmd.Parameters.AddWithValue("@name", tbName.Text);
                            cmd.Parameters.AddWithValue("@address", tbAddress.Text);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.ExecuteNonQuery();
                        }
                        mySqlConnection.Close();
                    }
                }
                tbName.Text = String.Empty;
                tbAddress.Text = String.Empty;
            }


            UpdateDgvRent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReturn.SelectedRows)
                selectedPlateNumber = row.Cells[0].Value.ToString();

            foreach (DataGridViewRow row in dgvReturn.SelectedRows)
            {
                selectedPlateNumber = row.Cells[0].Value.ToString();

                using (MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM rentedcar where PlateNumber = @plateNumber", mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@plateNumber", selectedPlateNumber);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE car SET IsAvailable = @isAvailable WHERE PlateNumber = @plateNumber", mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@isAvailable", "Yes");
                        cmd.Parameters.AddWithValue("@plateNumber", selectedPlateNumber);
                        cmd.ExecuteNonQuery();
                    }

                    double pricePerDay = 0;
                    using (MySqlCommand cmd = new MySqlCommand("SELECT PricePerDay FROM car WHERE PlateNumber = @plateNumber", mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@plateNumber", selectedPlateNumber);
                        MySqlDataReader mySqlReader = cmd.ExecuteReader();
                        while (mySqlReader.Read())
                        {
                            pricePerDay = Double.Parse(mySqlReader[0].ToString());
                        }
                    }
                    mySqlConnection.Close();
                    mySqlConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO returnlog (PlateNumber, RenterName, RentDate, ReturnDate, PricePerDay, Total) VALUES(@plateNumber, @renterName, @rentDate, @returnDate, @price, @total)", mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@plateNumber", selectedPlateNumber);
                        cmd.Parameters.AddWithValue("@renterName", row.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@rentDate", DateTime.Parse(row.Cells[3].Value.ToString()));
                        cmd.Parameters.AddWithValue("@returnDate", DateTime.Now.ToString("yyyy-MM-dd HH-MM-ss"));
                        DateTime dt1 = DateTime.Parse(row.Cells[3].Value.ToString());
                        DateTime dt2 = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                        int days = Int32.Parse((dt2 - dt1).TotalDays.ToString());
                        cmd.Parameters.AddWithValue("@price", pricePerDay.ToString());
                        cmd.Parameters.AddWithValue("@total", (days == 0) ? (pricePerDay.ToString()) : (pricePerDay * days).ToString());
                        cmd.ExecuteNonQuery();
                    }

                    mySqlConnection.Close();
                }
            }

            UpdateDgvReturn();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                UpdateDgvInv();

            else if (tabControl.SelectedIndex == 1)
                UpdateDgvRent();

            else if (tabControl.SelectedIndex == 2)
                UpdateDgvReturn();

            else if (tabControl.SelectedIndex == 3)
                UpdateDgvReturnLog();
        }
    }
}
