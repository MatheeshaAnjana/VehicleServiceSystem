namespace VehicleServiceSystem
{
    partial class FormBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCallculateBill = new Guna.UI2.WinForms.Guna2Button();
            this.txtCid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbVehicleType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtServiceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServicePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridViewService = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPrintBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.billId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCallculateBill
            // 
            this.btnCallculateBill.BackColor = System.Drawing.Color.Transparent;
            this.btnCallculateBill.BorderColor = System.Drawing.Color.White;
            this.btnCallculateBill.BorderRadius = 10;
            this.btnCallculateBill.BorderThickness = 2;
            this.btnCallculateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCallculateBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCallculateBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCallculateBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCallculateBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCallculateBill.FillColor = System.Drawing.Color.Transparent;
            this.btnCallculateBill.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallculateBill.ForeColor = System.Drawing.Color.White;
            this.btnCallculateBill.Location = new System.Drawing.Point(337, 71);
            this.btnCallculateBill.Name = "btnCallculateBill";
            this.btnCallculateBill.Size = new System.Drawing.Size(103, 31);
            this.btnCallculateBill.TabIndex = 34;
            this.btnCallculateBill.Text = "Find Detail";
            this.btnCallculateBill.Click += new System.EventHandler(this.btnCallculateBill_Click);
            // 
            // txtCid
            // 
            this.txtCid.BackColor = System.Drawing.Color.Transparent;
            this.txtCid.BorderColor = System.Drawing.Color.White;
            this.txtCid.BorderRadius = 10;
            this.txtCid.BorderThickness = 0;
            this.txtCid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCid.DefaultText = "";
            this.txtCid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCid.Location = new System.Drawing.Point(26, 71);
            this.txtCid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCid.Name = "txtCid";
            this.txtCid.PlaceholderText = "Enter customer ID";
            this.txtCid.SelectedText = "";
            this.txtCid.Size = new System.Drawing.Size(305, 31);
            this.txtCid.TabIndex = 30;
            this.txtCid.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(393, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 35);
            this.label2.TabIndex = 31;
            this.label2.Text = "Generate Bill";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(37, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Vehicle Model";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Vehicle Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.BackColor = System.Drawing.Color.Transparent;
            this.txtVehicleModel.BorderColor = System.Drawing.Color.Brown;
            this.txtVehicleModel.BorderRadius = 10;
            this.txtVehicleModel.BorderThickness = 0;
            this.txtVehicleModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleModel.DefaultText = "";
            this.txtVehicleModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVehicleModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVehicleModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleModel.Location = new System.Drawing.Point(183, 168);
            this.txtVehicleModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.PlaceholderText = "";
            this.txtVehicleModel.ReadOnly = true;
            this.txtVehicleModel.SelectedText = "";
            this.txtVehicleModel.Size = new System.Drawing.Size(257, 31);
            this.txtVehicleModel.TabIndex = 35;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalBill.BorderColor = System.Drawing.Color.Brown;
            this.txtTotalBill.BorderRadius = 10;
            this.txtTotalBill.BorderThickness = 0;
            this.txtTotalBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalBill.DefaultText = "";
            this.txtTotalBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBill.Location = new System.Drawing.Point(145, 569);
            this.txtTotalBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.PlaceholderText = "Your grand total display hear";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.SelectedText = "";
            this.txtTotalBill.Size = new System.Drawing.Size(257, 31);
            this.txtTotalBill.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total Bill";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(582, 167);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(155, 69);
            this.guna2DataGridView1.TabIndex = 39;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.cmbVehicleType.BorderRadius = 10;
            this.cmbVehicleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVehicleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVehicleType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbVehicleType.ItemHeight = 18;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Sedan",
            "SUV",
            "Minivan",
            "Motorcycle",
            "Hatchback"});
            this.cmbVehicleType.Location = new System.Drawing.Point(183, 129);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(257, 24);
            this.cmbVehicleType.TabIndex = 40;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceName.BorderColor = System.Drawing.Color.Brown;
            this.txtServiceName.BorderRadius = 10;
            this.txtServiceName.BorderThickness = 0;
            this.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceName.DefaultText = "";
            this.txtServiceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServiceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServiceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceName.Location = new System.Drawing.Point(183, 207);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PlaceholderText = "";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(257, 31);
            this.txtServiceName.TabIndex = 36;
            this.txtServiceName.TextChanged += new System.EventHandler(this.txtServiceName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Service name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.BackColor = System.Drawing.Color.Transparent;
            this.txtServicePrice.BorderColor = System.Drawing.Color.Brown;
            this.txtServicePrice.BorderRadius = 10;
            this.txtServicePrice.BorderThickness = 0;
            this.txtServicePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicePrice.DefaultText = "";
            this.txtServicePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServicePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServicePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServicePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServicePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServicePrice.Location = new System.Drawing.Point(183, 246);
            this.txtServicePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.PlaceholderText = "";
            this.txtServicePrice.ReadOnly = true;
            this.txtServicePrice.SelectedText = "";
            this.txtServicePrice.Size = new System.Drawing.Size(257, 31);
            this.txtServicePrice.TabIndex = 36;
            this.txtServicePrice.TextChanged += new System.EventHandler(this.txtServicePrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(37, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Service Price";
            // 
            // DataGridViewService
            // 
            this.DataGridViewService.AllowUserToAddRows = false;
            this.DataGridViewService.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewService.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewService.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewService.GridColor = System.Drawing.Color.Navy;
            this.DataGridViewService.Location = new System.Drawing.Point(487, 121);
            this.DataGridViewService.Name = "DataGridViewService";
            this.DataGridViewService.ReadOnly = true;
            this.DataGridViewService.RowHeadersVisible = false;
            this.DataGridViewService.RowHeadersWidth = 51;
            this.DataGridViewService.RowTemplate.Height = 24;
            this.DataGridViewService.Size = new System.Drawing.Size(461, 203);
            this.DataGridViewService.TabIndex = 41;
            this.DataGridViewService.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewService.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewService.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewService.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewService.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewService.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridViewService.ThemeStyle.GridColor = System.Drawing.Color.Navy;
            this.DataGridViewService.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewService.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewService.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewService.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewService.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewService.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridViewService.ThemeStyle.ReadOnly = true;
            this.DataGridViewService.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewService.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewService.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewService.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewService.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewService.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewService.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellContentClick);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BorderColor = System.Drawing.Color.White;
            this.btnPrintBill.BorderRadius = 10;
            this.btnPrintBill.BorderThickness = 2;
            this.btnPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintBill.FillColor = System.Drawing.Color.Transparent;
            this.btnPrintBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Location = new System.Drawing.Point(743, 545);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(205, 71);
            this.btnPrintBill.TabIndex = 42;
            this.btnPrintBill.Text = "Print bill";
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(41, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(399, 31);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DataGridViewBill
            // 
            this.DataGridViewBill.AllowUserToAddRows = false;
            this.DataGridViewBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridViewBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewBill.ColumnHeadersHeight = 18;
            this.DataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billId,
            this.cusId,
            this.vehicleModel,
            this.selectServices,
            this.grandTotal});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewBill.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewBill.GridColor = System.Drawing.Color.Navy;
            this.DataGridViewBill.Location = new System.Drawing.Point(21, 345);
            this.DataGridViewBill.Name = "DataGridViewBill";
            this.DataGridViewBill.ReadOnly = true;
            this.DataGridViewBill.RowHeadersVisible = false;
            this.DataGridViewBill.RowHeadersWidth = 51;
            this.DataGridViewBill.RowTemplate.Height = 24;
            this.DataGridViewBill.Size = new System.Drawing.Size(927, 194);
            this.DataGridViewBill.TabIndex = 44;
            this.DataGridViewBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBill.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridViewBill.ThemeStyle.GridColor = System.Drawing.Color.Navy;
            this.DataGridViewBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewBill.ThemeStyle.HeaderStyle.Height = 18;
            this.DataGridViewBill.ThemeStyle.ReadOnly = true;
            this.DataGridViewBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewBill.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBill_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.Brown;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(597, 71);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Services";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(351, 31);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // billId
            // 
            this.billId.HeaderText = "Bill Id";
            this.billId.MinimumWidth = 6;
            this.billId.Name = "billId";
            this.billId.ReadOnly = true;
            // 
            // cusId
            // 
            this.cusId.HeaderText = "Custormer Id";
            this.cusId.MinimumWidth = 6;
            this.cusId.Name = "cusId";
            this.cusId.ReadOnly = true;
            // 
            // vehicleModel
            // 
            this.vehicleModel.HeaderText = "Vehical Model";
            this.vehicleModel.MinimumWidth = 6;
            this.vehicleModel.Name = "vehicleModel";
            this.vehicleModel.ReadOnly = true;
            // 
            // selectServices
            // 
            this.selectServices.HeaderText = "Service Name";
            this.selectServices.MinimumWidth = 6;
            this.selectServices.Name = "selectServices";
            this.selectServices.ReadOnly = true;
            // 
            // grandTotal
            // 
            this.grandTotal.HeaderText = "Service Price";
            this.grandTotal.MinimumWidth = 6;
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.ReadOnly = true;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 641);
            this.Controls.Add(this.DataGridViewBill);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.DataGridViewService);
            this.Controls.Add(this.cmbVehicleType);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.btnCallculateBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCallculateBill;
        private Guna.UI2.WinForms.Guna2TextBox txtCid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleModel;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalBill;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVehicleType;
        private Guna.UI2.WinForms.Guna2TextBox txtServiceName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtServicePrice;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewService;
        private Guna.UI2.WinForms.Guna2Button btnPrintBill;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewBill;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn billId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotal;
    }
}