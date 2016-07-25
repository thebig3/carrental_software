namespace CarRentalSystem
{
    partial class CarRentalSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInv = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.tabRent = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabReturnLog = new System.Windows.Forms.TabPage();
            this.tbAddPlate = new System.Windows.Forms.TextBox();
            this.tbAddBrand = new System.Windows.Forms.TextBox();
            this.tbAddModel = new System.Windows.Forms.TextBox();
            this.tbAddPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEditPrice = new System.Windows.Forms.TextBox();
            this.tbEditModel = new System.Windows.Forms.TextBox();
            this.tbEditBrand = new System.Windows.Forms.TextBox();
            this.tbEditPlate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfirmRent = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvReturnLog = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabInv.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.tabRent.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabReturnLog.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInv);
            this.tabControl.Controls.Add(this.tabRent);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabReturnLog);
            this.tabControl.Location = new System.Drawing.Point(-1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(625, 364);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabInv
            // 
            this.tabInv.Controls.Add(this.btnDeleteCar);
            this.tabInv.Controls.Add(this.panel2);
            this.tabInv.Controls.Add(this.panel1);
            this.tabInv.Controls.Add(this.dgvInv);
            this.tabInv.Location = new System.Drawing.Point(4, 22);
            this.tabInv.Name = "tabInv";
            this.tabInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabInv.Size = new System.Drawing.Size(617, 338);
            this.tabInv.TabIndex = 0;
            this.tabInv.Text = "Inventory";
            this.tabInv.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConfirmAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbAddPrice);
            this.panel1.Controls.Add(this.tbAddModel);
            this.panel1.Controls.Add(this.tbAddBrand);
            this.panel1.Controls.Add(this.tbAddPlate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 179);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Car";
            // 
            // dgvInv
            // 
            this.dgvInv.AllowUserToAddRows = false;
            this.dgvInv.AllowUserToDeleteRows = false;
            this.dgvInv.AllowUserToResizeColumns = false;
            this.dgvInv.AllowUserToResizeRows = false;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Location = new System.Drawing.Point(0, 0);
            this.dgvInv.MultiSelect = false;
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.RowHeadersVisible = false;
            this.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInv.Size = new System.Drawing.Size(617, 150);
            this.dgvInv.TabIndex = 0;
            this.dgvInv.SelectionChanged += new System.EventHandler(this.dgvInv_SelectionChanged);
            // 
            // tabRent
            // 
            this.tabRent.Controls.Add(this.dgvRent);
            this.tabRent.Controls.Add(this.panel3);
            this.tabRent.Location = new System.Drawing.Point(4, 22);
            this.tabRent.Name = "tabRent";
            this.tabRent.Padding = new System.Windows.Forms.Padding(3);
            this.tabRent.Size = new System.Drawing.Size(617, 338);
            this.tabRent.TabIndex = 1;
            this.tabRent.Text = "Rent Cars";
            this.tabRent.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReturn);
            this.tabPage3.Controls.Add(this.dgvReturn);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(617, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Return Cars";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.UseWaitCursor = true;
            // 
            // tabReturnLog
            // 
            this.tabReturnLog.Controls.Add(this.dgvReturnLog);
            this.tabReturnLog.Location = new System.Drawing.Point(4, 22);
            this.tabReturnLog.Name = "tabReturnLog";
            this.tabReturnLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabReturnLog.Size = new System.Drawing.Size(617, 338);
            this.tabReturnLog.TabIndex = 3;
            this.tabReturnLog.Text = "Return Log";
            this.tabReturnLog.UseVisualStyleBackColor = true;
            // 
            // tbAddPlate
            // 
            this.tbAddPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddPlate.Location = new System.Drawing.Point(102, 37);
            this.tbAddPlate.Name = "tbAddPlate";
            this.tbAddPlate.Size = new System.Drawing.Size(100, 22);
            this.tbAddPlate.TabIndex = 1;
            // 
            // tbAddBrand
            // 
            this.tbAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddBrand.Location = new System.Drawing.Point(102, 65);
            this.tbAddBrand.Name = "tbAddBrand";
            this.tbAddBrand.Size = new System.Drawing.Size(100, 22);
            this.tbAddBrand.TabIndex = 1;
            // 
            // tbAddModel
            // 
            this.tbAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddModel.Location = new System.Drawing.Point(102, 93);
            this.tbAddModel.Name = "tbAddModel";
            this.tbAddModel.Size = new System.Drawing.Size(100, 22);
            this.tbAddModel.TabIndex = 1;
            // 
            // tbAddPrice
            // 
            this.tbAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddPrice.Location = new System.Drawing.Point(102, 121);
            this.tbAddPrice.Name = "tbAddPrice";
            this.tbAddPrice.Size = new System.Drawing.Size(100, 22);
            this.tbAddPrice.TabIndex = 1;
            this.tbAddPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceConstraints);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plate Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price Per Day:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnConfirmEdit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbEditPrice);
            this.panel2.Controls.Add(this.tbEditModel);
            this.panel2.Controls.Add(this.tbEditBrand);
            this.panel2.Controls.Add(this.tbEditPlate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(258, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 179);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price Per Day:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Brand:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Plate Number:";
            // 
            // tbEditPrice
            // 
            this.tbEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditPrice.Location = new System.Drawing.Point(102, 121);
            this.tbEditPrice.Name = "tbEditPrice";
            this.tbEditPrice.Size = new System.Drawing.Size(100, 22);
            this.tbEditPrice.TabIndex = 1;
            this.tbEditPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceConstraints);
            // 
            // tbEditModel
            // 
            this.tbEditModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditModel.Location = new System.Drawing.Point(102, 93);
            this.tbEditModel.Name = "tbEditModel";
            this.tbEditModel.Size = new System.Drawing.Size(100, 22);
            this.tbEditModel.TabIndex = 1;
            // 
            // tbEditBrand
            // 
            this.tbEditBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditBrand.Location = new System.Drawing.Point(102, 65);
            this.tbEditBrand.Name = "tbEditBrand";
            this.tbEditBrand.Size = new System.Drawing.Size(100, 22);
            this.tbEditBrand.TabIndex = 1;
            // 
            // tbEditPlate
            // 
            this.tbEditPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditPlate.Location = new System.Drawing.Point(102, 37);
            this.tbEditPlate.Name = "tbEditPlate";
            this.tbEditPlate.Size = new System.Drawing.Size(100, 22);
            this.tbEditPlate.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Edit Car";
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAdd.Location = new System.Drawing.Point(102, 149);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAdd.TabIndex = 3;
            this.btnConfirmAdd.Text = "Confirm";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEdit.Location = new System.Drawing.Point(102, 149);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmEdit.TabIndex = 3;
            this.btnConfirmEdit.Text = "Confirm";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Click += new System.EventHandler(this.btnConfirmEdit_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(518, 156);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteCar.TabIndex = 3;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnConfirmRent);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.tbAddress);
            this.panel3.Controls.Add(this.tbName);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(3, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 130);
            this.panel3.TabIndex = 2;
            // 
            // btnConfirmRent
            // 
            this.btnConfirmRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmRent.Location = new System.Drawing.Point(102, 100);
            this.btnConfirmRent.Name = "btnConfirmRent";
            this.btnConfirmRent.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmRent.TabIndex = 3;
            this.btnConfirmRent.Text = "Confirm";
            this.btnConfirmRent.UseVisualStyleBackColor = true;
            this.btnConfirmRent.Click += new System.EventHandler(this.btnConfirmRent_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Address:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Name:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(102, 72);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 22);
            this.tbAddress.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(102, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Rent Car";
            // 
            // dgvRent
            // 
            this.dgvRent.AllowUserToAddRows = false;
            this.dgvRent.AllowUserToDeleteRows = false;
            this.dgvRent.AllowUserToResizeColumns = false;
            this.dgvRent.AllowUserToResizeRows = false;
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(0, 0);
            this.dgvRent.MultiSelect = false;
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.ReadOnly = true;
            this.dgvRent.RowHeadersVisible = false;
            this.dgvRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRent.Size = new System.Drawing.Size(617, 199);
            this.dgvRent.TabIndex = 3;
            this.dgvRent.SelectionChanged += new System.EventHandler(this.dgvRent_SelectionChanged);
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.AllowUserToResizeColumns = false;
            this.dgvReturn.AllowUserToResizeRows = false;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(0, 0);
            this.dgvReturn.MultiSelect = false;
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowHeadersVisible = false;
            this.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturn.Size = new System.Drawing.Size(617, 199);
            this.dgvReturn.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(3, 205);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return Car";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvReturnLog
            // 
            this.dgvReturnLog.AllowUserToAddRows = false;
            this.dgvReturnLog.AllowUserToDeleteRows = false;
            this.dgvReturnLog.AllowUserToResizeColumns = false;
            this.dgvReturnLog.AllowUserToResizeRows = false;
            this.dgvReturnLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnLog.Location = new System.Drawing.Point(0, 0);
            this.dgvReturnLog.MultiSelect = false;
            this.dgvReturnLog.Name = "dgvReturnLog";
            this.dgvReturnLog.ReadOnly = true;
            this.dgvReturnLog.RowHeadersVisible = false;
            this.dgvReturnLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnLog.Size = new System.Drawing.Size(617, 338);
            this.dgvReturnLog.TabIndex = 5;
            // 
            // CarRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 362);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CarRentalSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.CarRentalSystem_Load);
            this.tabControl.ResumeLayout(false);
            this.tabInv.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.tabRent.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabReturnLog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInv;
        private System.Windows.Forms.TabPage tabRent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabReturnLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEditPrice;
        private System.Windows.Forms.TextBox tbEditModel;
        private System.Windows.Forms.TextBox tbEditBrand;
        private System.Windows.Forms.TextBox tbEditPlate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddPrice;
        private System.Windows.Forms.TextBox tbAddModel;
        private System.Windows.Forms.TextBox tbAddBrand;
        private System.Windows.Forms.TextBox tbAddPlate;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConfirmRent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.DataGridView dgvReturnLog;
    }
}

