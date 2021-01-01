
namespace GamePinger
{
    partial class Settings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridSettings = new MetroFramework.Controls.MetroGrid();
            this.LocationTextCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpTextCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanelAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRow = new MetroFramework.Controls.MetroButton();
            this.txtIp = new MetroFramework.Controls.MetroTextBox();
            this.lblIp = new MetroFramework.Controls.MetroLabel();
            this.txtLocation = new MetroFramework.Controls.MetroTextBox();
            this.lblLocation = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSettings)).BeginInit();
            this.flowLayoutPanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridSettings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelAdd, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 467);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridSettings
            // 
            this.dataGridSettings.AllowUserToResizeRows = false;
            this.dataGridSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSettings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSettings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSettings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocationTextCol,
            this.IpTextCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSettings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSettings.EnableHeadersVisualStyles = false;
            this.dataGridSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridSettings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridSettings.Location = new System.Drawing.Point(3, 3);
            this.dataGridSettings.Name = "dataGridSettings";
            this.dataGridSettings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSettings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSettings.RowHeadersVisible = false;
            this.dataGridSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSettings.Size = new System.Drawing.Size(447, 414);
            this.dataGridSettings.Style = MetroFramework.MetroColorStyle.Lime;
            this.dataGridSettings.TabIndex = 2;
            // 
            // LocationTextCol
            // 
            this.LocationTextCol.DataPropertyName = "LocationText";
            this.LocationTextCol.HeaderText = "Location";
            this.LocationTextCol.Name = "LocationTextCol";
            // 
            // IpTextCol
            // 
            this.IpTextCol.DataPropertyName = "IpText";
            this.IpTextCol.HeaderText = "Ip";
            this.IpTextCol.Name = "IpTextCol";
            // 
            // flowLayoutPanelAdd
            // 
            this.flowLayoutPanelAdd.Controls.Add(this.btnAddRow);
            this.flowLayoutPanelAdd.Controls.Add(this.txtIp);
            this.flowLayoutPanelAdd.Controls.Add(this.lblIp);
            this.flowLayoutPanelAdd.Controls.Add(this.txtLocation);
            this.flowLayoutPanelAdd.Controls.Add(this.lblLocation);
            this.flowLayoutPanelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAdd.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelAdd.Location = new System.Drawing.Point(0, 420);
            this.flowLayoutPanelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelAdd.Name = "flowLayoutPanelAdd";
            this.flowLayoutPanelAdd.Size = new System.Drawing.Size(453, 47);
            this.flowLayoutPanelAdd.TabIndex = 3;
            // 
            // btnAddRow
            // 
            this.btnAddRow.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddRow.Location = new System.Drawing.Point(375, 3);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.Text = "Add";
            this.btnAddRow.UseSelectable = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // txtIp
            // 
            // 
            // 
            // 
            this.txtIp.CustomButton.Image = null;
            this.txtIp.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtIp.CustomButton.Name = "";
            this.txtIp.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIp.CustomButton.TabIndex = 1;
            this.txtIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIp.CustomButton.UseSelectable = true;
            this.txtIp.CustomButton.Visible = false;
            this.txtIp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIp.Lines = new string[0];
            this.txtIp.Location = new System.Drawing.Point(244, 3);
            this.txtIp.MaxLength = 32767;
            this.txtIp.Name = "txtIp";
            this.txtIp.PasswordChar = '\0';
            this.txtIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIp.SelectedText = "";
            this.txtIp.SelectionLength = 0;
            this.txtIp.SelectionStart = 0;
            this.txtIp.ShortcutsEnabled = true;
            this.txtIp.Size = new System.Drawing.Size(125, 25);
            this.txtIp.TabIndex = 1;
            this.txtIp.UseSelectable = true;
            this.txtIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(218, 5);
            this.lblIp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 19);
            this.lblIp.TabIndex = 3;
            this.lblIp.Text = "Ip:";
            // 
            // txtLocation
            // 
            // 
            // 
            // 
            this.txtLocation.CustomButton.Image = null;
            this.txtLocation.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtLocation.CustomButton.Name = "";
            this.txtLocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocation.CustomButton.TabIndex = 1;
            this.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocation.CustomButton.UseSelectable = true;
            this.txtLocation.CustomButton.Visible = false;
            this.txtLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLocation.Lines = new string[0];
            this.txtLocation.Location = new System.Drawing.Point(65, 3);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.Size = new System.Drawing.Size(150, 25);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.UseSelectable = true;
            this.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(1, 5);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 19);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSettings)).EndInit();
            this.flowLayoutPanelAdd.ResumeLayout(false);
            this.flowLayoutPanelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroGrid dataGridSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationTextCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpTextCol;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAdd;
        private MetroFramework.Controls.MetroButton btnAddRow;
        private MetroFramework.Controls.MetroTextBox txtIp;
        private MetroFramework.Controls.MetroLabel lblIp;
        private MetroFramework.Controls.MetroTextBox txtLocation;
        private MetroFramework.Controls.MetroLabel lblLocation;
    }
}