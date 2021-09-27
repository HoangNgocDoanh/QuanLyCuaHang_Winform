namespace _GUI
{
    partial class frm_MainMenuCashier
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
            this.components = new System.ComponentModel.Container();
            this.abtnABOUT = new Guna.UI.WinForms.GunaAdvenceButton();
            this.abtnPAYMENT = new Guna.UI.WinForms.GunaAdvenceButton();
            this.abtnDATABASE = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.cbbOPTION = new Guna.UI.WinForms.GunaComboBox();
            this.picava = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gpnMAIN = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picava)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abtnABOUT
            // 
            this.abtnABOUT.AnimationHoverSpeed = 0.07F;
            this.abtnABOUT.AnimationSpeed = 0.03F;
            this.abtnABOUT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.abtnABOUT.BorderColor = System.Drawing.Color.Black;
            this.abtnABOUT.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.abtnABOUT.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.abtnABOUT.CheckedBorderColor = System.Drawing.Color.Black;
            this.abtnABOUT.CheckedForeColor = System.Drawing.Color.White;
            this.abtnABOUT.CheckedImage = global::_GUI.Properties.Resources.info;
            this.abtnABOUT.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.abtnABOUT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.abtnABOUT.FocusedColor = System.Drawing.Color.Empty;
            this.abtnABOUT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.abtnABOUT.ForeColor = System.Drawing.Color.White;
            this.abtnABOUT.Image = global::_GUI.Properties.Resources.info;
            this.abtnABOUT.ImageOffsetX = 15;
            this.abtnABOUT.ImageSize = new System.Drawing.Size(20, 20);
            this.abtnABOUT.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.abtnABOUT.LineLeft = 5;
            this.abtnABOUT.Location = new System.Drawing.Point(0, 138);
            this.abtnABOUT.Name = "abtnABOUT";
            this.abtnABOUT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.abtnABOUT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.abtnABOUT.OnHoverForeColor = System.Drawing.Color.White;
            this.abtnABOUT.OnHoverImage = null;
            this.abtnABOUT.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.abtnABOUT.OnPressedColor = System.Drawing.Color.Black;
            this.abtnABOUT.Size = new System.Drawing.Size(209, 42);
            this.abtnABOUT.TabIndex = 2;
            this.abtnABOUT.Text = "ABOUT";
            this.abtnABOUT.Click += new System.EventHandler(this.abtnABOUT_Click);
            // 
            // abtnPAYMENT
            // 
            this.abtnPAYMENT.AnimationHoverSpeed = 0.07F;
            this.abtnPAYMENT.AnimationSpeed = 0.03F;
            this.abtnPAYMENT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.abtnPAYMENT.BorderColor = System.Drawing.Color.Black;
            this.abtnPAYMENT.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.abtnPAYMENT.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.abtnPAYMENT.CheckedBorderColor = System.Drawing.Color.Black;
            this.abtnPAYMENT.CheckedForeColor = System.Drawing.Color.White;
            this.abtnPAYMENT.CheckedImage = global::_GUI.Properties.Resources.pay;
            this.abtnPAYMENT.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.abtnPAYMENT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.abtnPAYMENT.FocusedColor = System.Drawing.Color.Empty;
            this.abtnPAYMENT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.abtnPAYMENT.ForeColor = System.Drawing.Color.White;
            this.abtnPAYMENT.Image = global::_GUI.Properties.Resources.pay;
            this.abtnPAYMENT.ImageOffsetX = 15;
            this.abtnPAYMENT.ImageSize = new System.Drawing.Size(20, 20);
            this.abtnPAYMENT.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.abtnPAYMENT.LineLeft = 5;
            this.abtnPAYMENT.Location = new System.Drawing.Point(0, 90);
            this.abtnPAYMENT.Name = "abtnPAYMENT";
            this.abtnPAYMENT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.abtnPAYMENT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.abtnPAYMENT.OnHoverForeColor = System.Drawing.Color.White;
            this.abtnPAYMENT.OnHoverImage = null;
            this.abtnPAYMENT.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.abtnPAYMENT.OnPressedColor = System.Drawing.Color.Black;
            this.abtnPAYMENT.Size = new System.Drawing.Size(209, 42);
            this.abtnPAYMENT.TabIndex = 2;
            this.abtnPAYMENT.Text = "PAYMENT";
            this.abtnPAYMENT.Click += new System.EventHandler(this.abtnPAYMENT_Click);
            // 
            // abtnDATABASE
            // 
            this.abtnDATABASE.AnimationHoverSpeed = 0.07F;
            this.abtnDATABASE.AnimationSpeed = 0.03F;
            this.abtnDATABASE.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.abtnDATABASE.BorderColor = System.Drawing.Color.Empty;
            this.abtnDATABASE.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.abtnDATABASE.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.abtnDATABASE.CheckedBorderColor = System.Drawing.Color.Black;
            this.abtnDATABASE.CheckedForeColor = System.Drawing.Color.White;
            this.abtnDATABASE.CheckedImage = global::_GUI.Properties.Resources.loupe;
            this.abtnDATABASE.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.abtnDATABASE.DialogResult = System.Windows.Forms.DialogResult.None;
            this.abtnDATABASE.FocusedColor = System.Drawing.Color.Empty;
            this.abtnDATABASE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.abtnDATABASE.ForeColor = System.Drawing.Color.White;
            this.abtnDATABASE.Image = global::_GUI.Properties.Resources.loupe;
            this.abtnDATABASE.ImageOffsetX = 15;
            this.abtnDATABASE.ImageSize = new System.Drawing.Size(20, 20);
            this.abtnDATABASE.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.abtnDATABASE.LineLeft = 5;
            this.abtnDATABASE.Location = new System.Drawing.Point(0, 42);
            this.abtnDATABASE.Name = "abtnDATABASE";
            this.abtnDATABASE.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.abtnDATABASE.OnHoverBorderColor = System.Drawing.Color.Black;
            this.abtnDATABASE.OnHoverForeColor = System.Drawing.Color.White;
            this.abtnDATABASE.OnHoverImage = null;
            this.abtnDATABASE.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.abtnDATABASE.OnPressedColor = System.Drawing.Color.Black;
            this.abtnDATABASE.Size = new System.Drawing.Size(209, 42);
            this.abtnDATABASE.TabIndex = 0;
            this.abtnDATABASE.Text = "PRODUCT";
            this.abtnDATABASE.Click += new System.EventHandler(this.abtnDATABASE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_GUI.Properties.Resources.cross;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(133, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.cbbOPTION);
            this.gunaPanel4.Controls.Add(this.pictureBox1);
            this.gunaPanel4.Controls.Add(this.picava);
            this.gunaPanel4.Location = new System.Drawing.Point(771, -1);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(183, 54);
            this.gunaPanel4.TabIndex = 8;
            // 
            // cbbOPTION
            // 
            this.cbbOPTION.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbOPTION.BackColor = System.Drawing.Color.Transparent;
            this.cbbOPTION.BaseColor = System.Drawing.Color.White;
            this.cbbOPTION.BorderColor = System.Drawing.Color.Silver;
            this.cbbOPTION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbOPTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOPTION.DropDownWidth = 150;
            this.cbbOPTION.FocusedColor = System.Drawing.Color.Empty;
            this.cbbOPTION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbOPTION.ForeColor = System.Drawing.Color.Black;
            this.cbbOPTION.FormattingEnabled = true;
            this.cbbOPTION.Items.AddRange(new object[] {
            "Log Out"});
            this.cbbOPTION.Location = new System.Drawing.Point(89, 3);
            this.cbbOPTION.Name = "cbbOPTION";
            this.cbbOPTION.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.cbbOPTION.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cbbOPTION.Radius = 10;
            this.cbbOPTION.Size = new System.Drawing.Size(22, 31);
            this.cbbOPTION.TabIndex = 5;
            // 
            // picava
            // 
            this.picava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picava.BaseColor = System.Drawing.Color.White;
            this.picava.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picava.Location = new System.Drawing.Point(23, 3);
            this.picava.Name = "picava";
            this.picava.Size = new System.Drawing.Size(60, 45);
            this.picava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picava.TabIndex = 4;
            this.picava.TabStop = false;
            this.picava.UseTransfarantBackground = false;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Location = new System.Drawing.Point(208, 2);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(565, 50);
            this.gunaPanel3.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaLabel1.Location = new System.Drawing.Point(35, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(130, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "CASHIER";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Location = new System.Drawing.Point(-1, -1);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(209, 53);
            this.gunaPanel2.TabIndex = 6;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoSize = true;
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.gunaPanel1.Controls.Add(this.abtnABOUT);
            this.gunaPanel1.Controls.Add(this.abtnPAYMENT);
            this.gunaPanel1.Controls.Add(this.abtnDATABASE);
            this.gunaPanel1.Location = new System.Drawing.Point(-1, 50);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(212, 562);
            this.gunaPanel1.TabIndex = 5;
            // 
            // gpnMAIN
            // 
            this.gpnMAIN.AutoSize = true;
            this.gpnMAIN.Location = new System.Drawing.Point(214, 58);
            this.gpnMAIN.Name = "gpnMAIN";
            this.gpnMAIN.Size = new System.Drawing.Size(737, 554);
            this.gpnMAIN.TabIndex = 9;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_MainMenuCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 610);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gpnMAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MainMenuCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MainMenuCashier";
            this.Load += new System.EventHandler(this.frm_MainMenuCashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picava)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton abtnABOUT;
        private Guna.UI.WinForms.GunaAdvenceButton abtnPAYMENT;
        public Guna.UI.WinForms.GunaAdvenceButton abtnDATABASE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaCirclePictureBox picava;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaPanel gpnMAIN;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaComboBox cbbOPTION;
        private System.Windows.Forms.Timer timer1;
    }
}