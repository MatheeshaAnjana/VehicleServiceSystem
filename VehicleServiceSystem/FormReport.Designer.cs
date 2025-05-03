namespace VehicleServiceSystem
{
    partial class FormReport
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
            this.DataGridViewrReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicle_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewrReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewrReport
            // 
            this.DataGridViewrReport.AllowUserToAddRows = false;
            this.DataGridViewrReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewrReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewrReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewrReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewrReport.ColumnHeadersHeight = 4;
            this.DataGridViewrReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewrReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bill_id,
            this.customer_id,
            this.vehicle_model,
            this.service_name,
            this.service_price,
            this.date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewrReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewrReport.GridColor = System.Drawing.Color.Navy;
            this.DataGridViewrReport.Location = new System.Drawing.Point(26, 79);
            this.DataGridViewrReport.Name = "DataGridViewrReport";
            this.DataGridViewrReport.ReadOnly = true;
            this.DataGridViewrReport.RowHeadersVisible = false;
            this.DataGridViewrReport.RowHeadersWidth = 51;
            this.DataGridViewrReport.RowTemplate.Height = 24;
            this.DataGridViewrReport.Size = new System.Drawing.Size(912, 536);
            this.DataGridViewrReport.TabIndex = 0;
            this.DataGridViewrReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewrReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewrReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewrReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewrReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewrReport.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridViewrReport.ThemeStyle.GridColor = System.Drawing.Color.Navy;
            this.DataGridViewrReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewrReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewrReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewrReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewrReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewrReport.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewrReport.ThemeStyle.ReadOnly = true;
            this.DataGridViewrReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewrReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewrReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewrReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewrReport.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewrReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewrReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewrReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerID.BorderRadius = 10;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Location = new System.Drawing.Point(573, 27);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PlaceholderText = "Enter customer ID";
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(374, 28);
            this.txtCustomerID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Report";
            // 
            // bill_id
            // 
            this.bill_id.HeaderText = "Bill Id";
            this.bill_id.MinimumWidth = 6;
            this.bill_id.Name = "bill_id";
            this.bill_id.ReadOnly = true;
            // 
            // customer_id
            // 
            this.customer_id.HeaderText = "Customer Id";
            this.customer_id.MinimumWidth = 6;
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            // 
            // vehicle_model
            // 
            this.vehicle_model.HeaderText = "Vehicle Model";
            this.vehicle_model.MinimumWidth = 6;
            this.vehicle_model.Name = "vehicle_model";
            this.vehicle_model.ReadOnly = true;
            // 
            // service_name
            // 
            this.service_name.HeaderText = "Service Name";
            this.service_name.MinimumWidth = 6;
            this.service_name.Name = "service_name";
            this.service_name.ReadOnly = true;
            // 
            // service_price
            // 
            this.service_price.HeaderText = "Service Price";
            this.service_price.MinimumWidth = 6;
            this.service_price.Name = "service_price";
            this.service_price.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(968, 641);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewrReport);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewrReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewrReport;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicle_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}