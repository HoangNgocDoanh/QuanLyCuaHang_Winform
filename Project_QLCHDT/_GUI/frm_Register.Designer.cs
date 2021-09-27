namespace _GUI
{
    partial class frm_Register
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
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.txtCONFIRM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbEXIT = new System.Windows.Forms.PictureBox();
            this.btnUPLOAD = new System.Windows.Forms.Button();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUSER
            // 
            this.txtUSER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUSER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUSER.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUSER.Location = new System.Drawing.Point(121, 144);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(177, 15);
            this.txtUSER.TabIndex = 5;
            this.txtUSER.Text = "Username";
            this.txtUSER.Enter += new System.EventHandler(this.txtUSER_Enter);
            this.txtUSER.Leave += new System.EventHandler(this.txtUSER_Leave);
            this.txtUSER.Validated += new System.EventHandler(this.txtUSER_Validated);
            // 
            // txtPASS
            // 
            this.txtPASS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPASS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPASS.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPASS.Location = new System.Drawing.Point(121, 209);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(177, 15);
            this.txtPASS.TabIndex = 6;
            this.txtPASS.Text = "Password";
            this.txtPASS.Enter += new System.EventHandler(this.txtPASS_Enter);
            this.txtPASS.Leave += new System.EventHandler(this.txtPASS_Leave);
            this.txtPASS.Validated += new System.EventHandler(this.txtPASS_Validated);
            // 
            // txtCONFIRM
            // 
            this.txtCONFIRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtCONFIRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCONFIRM.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCONFIRM.Location = new System.Drawing.Point(121, 278);
            this.txtCONFIRM.Name = "txtCONFIRM";
            this.txtCONFIRM.Size = new System.Drawing.Size(177, 15);
            this.txtCONFIRM.TabIndex = 7;
            this.txtCONFIRM.Text = "Confirm";
            this.txtCONFIRM.Enter += new System.EventHandler(this.txtCONFIRM_Enter);
            this.txtCONFIRM.Leave += new System.EventHandler(this.txtCONFIRM_Leave);
            this.txtCONFIRM.Validated += new System.EventHandler(this.txtCONFIRM_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(123, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(121, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(121, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 1);
            this.panel3.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnOK.Location = new System.Drawing.Point(47, 515);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(249, 36);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_GUI.Properties.Resources.icons8_password_48;
            this.pictureBox4.Location = new System.Drawing.Point(49, 252);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_GUI.Properties.Resources.icons8_password_48;
            this.pictureBox3.Location = new System.Drawing.Point(49, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_GUI.Properties.Resources.icons8_user_48;
            this.pictureBox2.Location = new System.Drawing.Point(49, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_GUI.Properties.Resources.id__1_;
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptbEXIT
            // 
            this.ptbEXIT.Image = global::_GUI.Properties.Resources.cross;
            this.ptbEXIT.Location = new System.Drawing.Point(340, 12);
            this.ptbEXIT.Name = "ptbEXIT";
            this.ptbEXIT.Size = new System.Drawing.Size(34, 29);
            this.ptbEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbEXIT.TabIndex = 12;
            this.ptbEXIT.TabStop = false;
            this.ptbEXIT.Click += new System.EventHandler(this.ptbEXIT_Click);
            // 
            // btnUPLOAD
            // 
            this.btnUPLOAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUPLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUPLOAD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnUPLOAD.Location = new System.Drawing.Point(49, 419);
            this.btnUPLOAD.Name = "btnUPLOAD";
            this.btnUPLOAD.Size = new System.Drawing.Size(249, 29);
            this.btnUPLOAD.TabIndex = 16;
            this.btnUPLOAD.Text = "Choose an image";
            this.btnUPLOAD.UseVisualStyleBackColor = false;
            this.btnUPLOAD.Click += new System.EventHandler(this.btnUPLOAD_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Location = new System.Drawing.Point(49, 317);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 16;
            this.gunaPictureBox1.Size = new System.Drawing.Size(247, 96);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 17;
            this.gunaPictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(386, 596);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnUPLOAD);
            this.Controls.Add(this.ptbEXIT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCONFIRM);
            this.Controls.Add(this.txtPASS);
            this.Controls.Add(this.txtUSER);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Register";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.TextBox txtCONFIRM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox ptbEXIT;
        private System.Windows.Forms.Button btnUPLOAD;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}