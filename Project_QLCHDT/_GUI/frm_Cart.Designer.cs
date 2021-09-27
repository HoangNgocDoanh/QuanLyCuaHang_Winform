namespace _GUI
{
    partial class frm_Cart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnDELETE = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnPAY = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.dgvCART = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCART)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(5, 1, 5, 5);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(762, 496);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaPanel1.Controls.Add(this.gunaVScrollBar1);
            this.gunaPanel1.Controls.Add(this.btnDELETE);
            this.gunaPanel1.Controls.Add(this.gunaAdvenceTileButton1);
            this.gunaPanel1.Controls.Add(this.btnPAY);
            this.gunaPanel1.Controls.Add(this.dgvCART);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(762, 496);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnDELETE
            // 
            this.btnDELETE.AnimationHoverSpeed = 0.07F;
            this.btnDELETE.AnimationSpeed = 0.03F;
            this.btnDELETE.BackColor = System.Drawing.Color.Transparent;
            this.btnDELETE.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnDELETE.BorderColor = System.Drawing.Color.Black;
            this.btnDELETE.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDELETE.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDELETE.CheckedForeColor = System.Drawing.Color.White;
            this.btnDELETE.CheckedImage = null;
            this.btnDELETE.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDELETE.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDELETE.FocusedColor = System.Drawing.Color.Empty;
            this.btnDELETE.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Bold);
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = null;
            this.btnDELETE.ImageSize = new System.Drawing.Size(52, 52);
            this.btnDELETE.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDELETE.Location = new System.Drawing.Point(486, 431);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnDELETE.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDELETE.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDELETE.OnHoverImage = null;
            this.btnDELETE.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDELETE.OnPressedColor = System.Drawing.Color.Black;
            this.btnDELETE.Radius = 18;
            this.btnDELETE.Size = new System.Drawing.Size(58, 44);
            this.btnDELETE.TabIndex = 11;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = null;
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = null;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(631, 431);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 18;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(107, 44);
            this.gunaAdvenceTileButton1.TabIndex = 10;
            this.gunaAdvenceTileButton1.Text = "Cancel";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // btnPAY
            // 
            this.btnPAY.AnimationHoverSpeed = 0.07F;
            this.btnPAY.AnimationSpeed = 0.03F;
            this.btnPAY.BackColor = System.Drawing.Color.Transparent;
            this.btnPAY.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnPAY.BorderColor = System.Drawing.Color.Black;
            this.btnPAY.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPAY.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPAY.CheckedForeColor = System.Drawing.Color.White;
            this.btnPAY.CheckedImage = null;
            this.btnPAY.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPAY.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPAY.FocusedColor = System.Drawing.Color.Empty;
            this.btnPAY.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Bold);
            this.btnPAY.ForeColor = System.Drawing.Color.White;
            this.btnPAY.Image = null;
            this.btnPAY.ImageSize = new System.Drawing.Size(52, 52);
            this.btnPAY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPAY.Location = new System.Drawing.Point(373, 431);
            this.btnPAY.Name = "btnPAY";
            this.btnPAY.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnPAY.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPAY.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPAY.OnHoverImage = null;
            this.btnPAY.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPAY.OnPressedColor = System.Drawing.Color.Black;
            this.btnPAY.Radius = 18;
            this.btnPAY.Size = new System.Drawing.Size(107, 44);
            this.btnPAY.TabIndex = 9;
            this.btnPAY.Text = "Pay";
            this.btnPAY.Click += new System.EventHandler(this.btnPAY_Click);
            // 
            // dgvCART
            // 
            this.dgvCART.AllowUserToAddRows = false;
            this.dgvCART.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvCART.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCART.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCART.BackgroundColor = System.Drawing.Color.White;
            this.dgvCART.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCART.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCART.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCART.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCART.ColumnHeadersHeight = 27;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCART.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCART.EnableHeadersVisualStyles = false;
            this.dgvCART.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvCART.Location = new System.Drawing.Point(-1, 0);
            this.dgvCART.Name = "dgvCART";
            this.dgvCART.ReadOnly = true;
            this.dgvCART.RowHeadersVisible = false;
            this.dgvCART.RowTemplate.Height = 24;
            this.dgvCART.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCART.Size = new System.Drawing.Size(763, 416);
            this.dgvCART.TabIndex = 8;
            this.dgvCART.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Cyan;
            this.dgvCART.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvCART.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCART.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCART.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCART.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCART.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCART.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvCART.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dgvCART.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCART.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCART.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCART.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCART.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvCART.ThemeStyle.ReadOnly = true;
            this.dgvCART.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dgvCART.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCART.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCART.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCART.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCART.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dgvCART.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(752, 0);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 416);
            this.gunaVScrollBar1.TabIndex = 12;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // frm_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 496);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cart";
            this.Load += new System.EventHandler(this.frm_Cart_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCART)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnDELETE;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnPAY;
        private Guna.UI.WinForms.GunaDataGridView dgvCART;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
    }
}