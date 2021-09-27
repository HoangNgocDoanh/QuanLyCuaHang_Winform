namespace _GUI
{
    partial class frm_Payment
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gbtnCART = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaShadowPanel6 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaGroupBox6 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaHScrollBar1 = new Guna.UI.WinForms.GunaHScrollBar();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtSEARCH = new Guna.UI.WinForms.GunaTextBox();
            this.btnSEARCH = new Guna.UI.WinForms.GunaCircleButton();
            this.gbtnADDTOCART = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnHISTORY = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaShadowPanel6.SuspendLayout();
            this.gunaGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btnHISTORY);
            this.gunaPanel1.Controls.Add(this.gbtnCART);
            this.gunaPanel1.Controls.Add(this.gunaShadowPanel6);
            this.gunaPanel1.Controls.Add(this.gunaShadowPanel2);
            this.gunaPanel1.Controls.Add(this.gbtnADDTOCART);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(717, 567);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gbtnCART
            // 
            this.gbtnCART.AnimationHoverSpeed = 0.07F;
            this.gbtnCART.AnimationSpeed = 0.03F;
            this.gbtnCART.BackColor = System.Drawing.Color.Transparent;
            this.gbtnCART.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gbtnCART.BorderColor = System.Drawing.Color.Black;
            this.gbtnCART.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gbtnCART.CheckedBorderColor = System.Drawing.Color.Black;
            this.gbtnCART.CheckedForeColor = System.Drawing.Color.White;
            this.gbtnCART.CheckedImage = null;
            this.gbtnCART.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gbtnCART.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnCART.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnCART.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Bold);
            this.gbtnCART.ForeColor = System.Drawing.Color.White;
            this.gbtnCART.Image = null;
            this.gbtnCART.ImageSize = new System.Drawing.Size(52, 52);
            this.gbtnCART.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnCART.Location = new System.Drawing.Point(586, 497);
            this.gbtnCART.Name = "gbtnCART";
            this.gbtnCART.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gbtnCART.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnCART.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnCART.OnHoverImage = null;
            this.gbtnCART.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnCART.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnCART.Radius = 18;
            this.gbtnCART.Size = new System.Drawing.Size(107, 44);
            this.gbtnCART.TabIndex = 10;
            this.gbtnCART.Text = "Cart: 0";
            this.gbtnCART.Click += new System.EventHandler(this.gbtnCART_Click);
            // 
            // gunaShadowPanel6
            // 
            this.gunaShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel6.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel6.Controls.Add(this.gunaGroupBox6);
            this.gunaShadowPanel6.Location = new System.Drawing.Point(15, 119);
            this.gunaShadowPanel6.Name = "gunaShadowPanel6";
            this.gunaShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel6.Size = new System.Drawing.Size(700, 318);
            this.gunaShadowPanel6.TabIndex = 9;
            // 
            // gunaGroupBox6
            // 
            this.gunaGroupBox6.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox6.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox6.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox6.Controls.Add(this.gunaHScrollBar1);
            this.gunaGroupBox6.Controls.Add(this.gunaVScrollBar1);
            this.gunaGroupBox6.Controls.Add(this.dgv);
            this.gunaGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox6.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox6.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox6.Name = "gunaGroupBox6";
            this.gunaGroupBox6.Size = new System.Drawing.Size(700, 318);
            this.gunaGroupBox6.TabIndex = 0;
            this.gunaGroupBox6.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaHScrollBar1
            // 
            this.gunaHScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaHScrollBar1.LargeChange = 10;
            this.gunaHScrollBar1.Location = new System.Drawing.Point(3, 305);
            this.gunaHScrollBar1.Maximum = 100;
            this.gunaHScrollBar1.Name = "gunaHScrollBar1";
            this.gunaHScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaHScrollBar1.Size = new System.Drawing.Size(687, 10);
            this.gunaHScrollBar1.TabIndex = 2;
            this.gunaHScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaHScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaHScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(687, 0);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 315);
            this.gunaVScrollBar1.TabIndex = 1;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(700, 318);
            this.dgv.TabIndex = 0;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Cyan;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 27;
            this.dgv.ThemeStyle.ReadOnly = true;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.RowsStyle.Height = 24;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.Controls.Add(this.gunaGroupBox2);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(12, 28);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.gunaShadowPanel2.Radius = 16;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowDepth = 40;
            this.gunaShadowPanel2.ShadowShift = 2;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(696, 52);
            this.gunaShadowPanel2.TabIndex = 2;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.txtSEARCH);
            this.gunaGroupBox2.Controls.Add(this.btnSEARCH);
            this.gunaGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.LineTop = 0;
            this.gunaGroupBox2.Location = new System.Drawing.Point(3, 1);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 20;
            this.gunaGroupBox2.Size = new System.Drawing.Size(690, 49);
            this.gunaGroupBox2.TabIndex = 4;
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.BaseColor = System.Drawing.Color.White;
            this.txtSEARCH.BorderColor = System.Drawing.Color.Silver;
            this.txtSEARCH.BorderSize = 0;
            this.txtSEARCH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSEARCH.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSEARCH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSEARCH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSEARCH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSEARCH.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSEARCH.Location = new System.Drawing.Point(67, 14);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.PasswordChar = '\0';
            this.txtSEARCH.SelectedText = "";
            this.txtSEARCH.Size = new System.Drawing.Size(592, 32);
            this.txtSEARCH.TabIndex = 2;
            this.txtSEARCH.Text = "SEARCH ASSETS";
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.AnimationHoverSpeed = 0.07F;
            this.btnSEARCH.AnimationSpeed = 0.03F;
            this.btnSEARCH.BaseColor = System.Drawing.Color.White;
            this.btnSEARCH.BorderColor = System.Drawing.Color.Black;
            this.btnSEARCH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSEARCH.FocusedColor = System.Drawing.Color.Empty;
            this.btnSEARCH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSEARCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSEARCH.Image = null;
            this.btnSEARCH.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSEARCH.Location = new System.Drawing.Point(3, 0);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSEARCH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSEARCH.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSEARCH.OnHoverImage = null;
            this.btnSEARCH.OnPressedColor = System.Drawing.Color.Black;
            this.btnSEARCH.Size = new System.Drawing.Size(58, 49);
            this.btnSEARCH.TabIndex = 3;
            this.btnSEARCH.Text = "Search";
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // gbtnADDTOCART
            // 
            this.gbtnADDTOCART.AnimationHoverSpeed = 0.07F;
            this.gbtnADDTOCART.AnimationSpeed = 0.03F;
            this.gbtnADDTOCART.BackColor = System.Drawing.Color.Transparent;
            this.gbtnADDTOCART.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gbtnADDTOCART.BorderColor = System.Drawing.Color.Black;
            this.gbtnADDTOCART.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gbtnADDTOCART.CheckedBorderColor = System.Drawing.Color.Black;
            this.gbtnADDTOCART.CheckedForeColor = System.Drawing.Color.White;
            this.gbtnADDTOCART.CheckedImage = null;
            this.gbtnADDTOCART.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gbtnADDTOCART.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnADDTOCART.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnADDTOCART.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Bold);
            this.gbtnADDTOCART.ForeColor = System.Drawing.Color.White;
            this.gbtnADDTOCART.Image = null;
            this.gbtnADDTOCART.ImageSize = new System.Drawing.Size(52, 52);
            this.gbtnADDTOCART.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnADDTOCART.Location = new System.Drawing.Point(18, 452);
            this.gbtnADDTOCART.Name = "gbtnADDTOCART";
            this.gbtnADDTOCART.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gbtnADDTOCART.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnADDTOCART.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnADDTOCART.OnHoverImage = null;
            this.gbtnADDTOCART.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gbtnADDTOCART.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnADDTOCART.Radius = 18;
            this.gbtnADDTOCART.Size = new System.Drawing.Size(107, 44);
            this.gbtnADDTOCART.TabIndex = 1;
            this.gbtnADDTOCART.Text = "Add to Cart";
            this.gbtnADDTOCART.Click += new System.EventHandler(this.gbtnADDTOCART_Click);
            // 
            // btnHISTORY
            // 
            this.btnHISTORY.AnimationHoverSpeed = 0.07F;
            this.btnHISTORY.AnimationSpeed = 0.03F;
            this.btnHISTORY.BackColor = System.Drawing.Color.Transparent;
            this.btnHISTORY.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnHISTORY.BorderColor = System.Drawing.Color.Black;
            this.btnHISTORY.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnHISTORY.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHISTORY.CheckedForeColor = System.Drawing.Color.White;
            this.btnHISTORY.CheckedImage = null;
            this.btnHISTORY.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnHISTORY.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHISTORY.FocusedColor = System.Drawing.Color.Empty;
            this.btnHISTORY.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Bold);
            this.btnHISTORY.ForeColor = System.Drawing.Color.White;
            this.btnHISTORY.Image = null;
            this.btnHISTORY.ImageSize = new System.Drawing.Size(52, 52);
            this.btnHISTORY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHISTORY.Location = new System.Drawing.Point(131, 452);
            this.btnHISTORY.Name = "btnHISTORY";
            this.btnHISTORY.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnHISTORY.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHISTORY.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHISTORY.OnHoverImage = null;
            this.btnHISTORY.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHISTORY.OnPressedColor = System.Drawing.Color.Black;
            this.btnHISTORY.Radius = 18;
            this.btnHISTORY.Size = new System.Drawing.Size(88, 44);
            this.btnHISTORY.TabIndex = 11;
            this.btnHISTORY.Text = "History";
            this.btnHISTORY.Click += new System.EventHandler(this.btnHISTORY_Click);
            // 
            // frm_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 567);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Payment";
            this.Text = "frm_Payment";
            this.Load += new System.EventHandler(this.frm_Payment_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaShadowPanel6.ResumeLayout(false);
            this.gunaGroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gbtnADDTOCART;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel6;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox6;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaTextBox txtSEARCH;
        private Guna.UI.WinForms.GunaCircleButton btnSEARCH;
        private Guna.UI.WinForms.GunaAdvenceTileButton gbtnCART;
        private Guna.UI.WinForms.GunaHScrollBar gunaHScrollBar1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnHISTORY;
    }
}