namespace _GUI
{
    partial class frm_Login
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
            this.txtUSERNAME = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNEWUSER = new System.Windows.Forms.Label();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.rbtnMANAGER = new System.Windows.Forms.RadioButton();
            this.rbtnCASHIER = new System.Windows.Forms.RadioButton();
            this.ptbCLOSE = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUSERNAME
            // 
            this.txtUSERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUSERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUSERNAME.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUSERNAME.Location = new System.Drawing.Point(123, 154);
            this.txtUSERNAME.Name = "txtUSERNAME";
            this.txtUSERNAME.Size = new System.Drawing.Size(177, 15);
            this.txtUSERNAME.TabIndex = 3;
            this.txtUSERNAME.Text = "Username";
            this.txtUSERNAME.Enter += new System.EventHandler(this.txtUSERNAME_Enter);
            this.txtUSERNAME.Leave += new System.EventHandler(this.txtUSERNAME_Leave);
            this.txtUSERNAME.Validated += new System.EventHandler(this.txtUSERNAME_Validated);
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPASSWORD.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPASSWORD.Location = new System.Drawing.Point(123, 215);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(177, 15);
            this.txtPASSWORD.TabIndex = 4;
            this.txtPASSWORD.Text = "Password";
            this.txtPASSWORD.Enter += new System.EventHandler(this.txtPASSWORD_Enter);
            this.txtPASSWORD.Leave += new System.EventHandler(this.txtPASSWORD_Leave);
            this.txtPASSWORD.Validated += new System.EventHandler(this.txtPASSWORD_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(121, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(121, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 1);
            this.panel2.TabIndex = 6;
            // 
            // lblNEWUSER
            // 
            this.lblNEWUSER.AutoSize = true;
            this.lblNEWUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNEWUSER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblNEWUSER.Location = new System.Drawing.Point(12, 389);
            this.lblNEWUSER.Name = "lblNEWUSER";
            this.lblNEWUSER.Size = new System.Drawing.Size(149, 20);
            this.lblNEWUSER.TabIndex = 7;
            this.lblNEWUSER.Text = "New cashier user?";
            this.lblNEWUSER.Click += new System.EventHandler(this.lblNEWUSER_Click);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLOGIN.Location = new System.Drawing.Point(57, 318);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(242, 36);
            this.btnLOGIN.TabIndex = 8;
            this.btnLOGIN.Text = "Login";
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // rbtnMANAGER
            // 
            this.rbtnMANAGER.AutoSize = true;
            this.rbtnMANAGER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.rbtnMANAGER.Location = new System.Drawing.Point(80, 265);
            this.rbtnMANAGER.Name = "rbtnMANAGER";
            this.rbtnMANAGER.Size = new System.Drawing.Size(85, 21);
            this.rbtnMANAGER.TabIndex = 10;
            this.rbtnMANAGER.TabStop = true;
            this.rbtnMANAGER.Text = "Manager";
            this.rbtnMANAGER.UseVisualStyleBackColor = true;
            // 
            // rbtnCASHIER
            // 
            this.rbtnCASHIER.AutoSize = true;
            this.rbtnCASHIER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.rbtnCASHIER.Location = new System.Drawing.Point(203, 265);
            this.rbtnCASHIER.Name = "rbtnCASHIER";
            this.rbtnCASHIER.Size = new System.Drawing.Size(77, 21);
            this.rbtnCASHIER.TabIndex = 11;
            this.rbtnCASHIER.TabStop = true;
            this.rbtnCASHIER.Text = "Cashier";
            this.rbtnCASHIER.UseVisualStyleBackColor = true;
            // 
            // ptbCLOSE
            // 
            this.ptbCLOSE.Image = global::_GUI.Properties.Resources.cross;
            this.ptbCLOSE.Location = new System.Drawing.Point(340, 12);
            this.ptbCLOSE.Name = "ptbCLOSE";
            this.ptbCLOSE.Size = new System.Drawing.Size(34, 29);
            this.ptbCLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbCLOSE.TabIndex = 12;
            this.ptbCLOSE.TabStop = false;
            this.ptbCLOSE.Click += new System.EventHandler(this.ptbCLOSE_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_GUI.Properties.Resources.icons8_password_48;
            this.pictureBox3.Location = new System.Drawing.Point(57, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_GUI.Properties.Resources.icons8_user_48;
            this.pictureBox2.Location = new System.Drawing.Point(57, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_GUI.Properties.Resources._2274367;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(386, 431);
            this.Controls.Add(this.ptbCLOSE);
            this.Controls.Add(this.rbtnCASHIER);
            this.Controls.Add(this.rbtnMANAGER);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.lblNEWUSER);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtUSERNAME);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUSERNAME;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNEWUSER;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.RadioButton rbtnMANAGER;
        private System.Windows.Forms.RadioButton rbtnCASHIER;
        private System.Windows.Forms.PictureBox ptbCLOSE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

