namespace _GUI
{
    partial class frm_Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reports));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSAVE = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSAVETEXT = new Guna.UI.WinForms.GunaAdvenceButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.chart1);
            this.gunaPanel1.Controls.Add(this.btnSAVE);
            this.gunaPanel1.Controls.Add(this.btnSAVETEXT);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(740, 567);
            this.gunaPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(3, 91);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.BorderWidth = 6;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series5.Legend = "Legend1";
            series5.Name = "Revenue";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(725, 464);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title5.BackColor = System.Drawing.Color.White;
            title5.BorderColor = System.Drawing.Color.White;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            title5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            title5.Name = "Revenue Of The Store Over Years";
            title5.Text = "Revenue Of The Store Over Months";
            this.chart1.Titles.Add(title5);
            // 
            // btnSAVE
            // 
            this.btnSAVE.AnimationHoverSpeed = 0.07F;
            this.btnSAVE.AnimationSpeed = 0.03F;
            this.btnSAVE.BackColor = System.Drawing.Color.Transparent;
            this.btnSAVE.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSAVE.BorderColor = System.Drawing.Color.Black;
            this.btnSAVE.CheckedBaseColor = System.Drawing.SystemColors.Highlight;
            this.btnSAVE.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSAVE.CheckedForeColor = System.Drawing.Color.White;
            this.btnSAVE.CheckedImage = null;
            this.btnSAVE.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSAVE.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSAVE.FocusedColor = System.Drawing.Color.Empty;
            this.btnSAVE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = null;
            this.btnSAVE.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSAVE.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSAVE.Location = new System.Drawing.Point(446, 24);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSAVE.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSAVE.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSAVE.OnHoverImage = null;
            this.btnSAVE.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSAVE.OnPressedColor = System.Drawing.Color.Black;
            this.btnSAVE.Radius = 10;
            this.btnSAVE.Size = new System.Drawing.Size(178, 48);
            this.btnSAVE.TabIndex = 8;
            this.btnSAVE.Text = "Save Chart";
            this.btnSAVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnSAVETEXT
            // 
            this.btnSAVETEXT.AnimationHoverSpeed = 0.07F;
            this.btnSAVETEXT.AnimationSpeed = 0.03F;
            this.btnSAVETEXT.BackColor = System.Drawing.Color.Transparent;
            this.btnSAVETEXT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSAVETEXT.BorderColor = System.Drawing.Color.Black;
            this.btnSAVETEXT.CheckedBaseColor = System.Drawing.SystemColors.Highlight;
            this.btnSAVETEXT.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSAVETEXT.CheckedForeColor = System.Drawing.Color.White;
            this.btnSAVETEXT.CheckedImage = null;
            this.btnSAVETEXT.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSAVETEXT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSAVETEXT.FocusedColor = System.Drawing.Color.Empty;
            this.btnSAVETEXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSAVETEXT.ForeColor = System.Drawing.Color.White;
            this.btnSAVETEXT.Image = null;
            this.btnSAVETEXT.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSAVETEXT.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSAVETEXT.Location = new System.Drawing.Point(141, 24);
            this.btnSAVETEXT.Name = "btnSAVETEXT";
            this.btnSAVETEXT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSAVETEXT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSAVETEXT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSAVETEXT.OnHoverImage = null;
            this.btnSAVETEXT.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSAVETEXT.OnPressedColor = System.Drawing.Color.Black;
            this.btnSAVETEXT.Radius = 10;
            this.btnSAVETEXT.Size = new System.Drawing.Size(175, 48);
            this.btnSAVETEXT.TabIndex = 7;
            this.btnSAVETEXT.Text = "Save to PDF";
            this.btnSAVETEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSAVETEXT.Click += new System.EventHandler(this.btnSAVETEXT_Click);
            // 
            // printDocument1
            // 
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 567);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Reports";
            this.Text = "frm_Reports";
            this.Load += new System.EventHandler(this.frm_Reports_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnSAVE;
        private Guna.UI.WinForms.GunaAdvenceButton btnSAVETEXT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}