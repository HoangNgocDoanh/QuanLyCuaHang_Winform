using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _GUI
{
    public partial class frm_Reports : Form
    {
        public frm_Reports()
        {
            InitializeComponent();
        }
        List<string> AxisX = new List<string>();
        List<int> AxisY = new List<int>();
        DataGridView gridview_toprint = new DataGridView();
        private void frm_Reports_Load(object sender, EventArgs e)
        {
            DataTable data = _BUS.BUS_Reports.Instance.getReports();
            SetValue(data);
            AddPoints(chart1);
            gridview_toprint.DataSource = print_source();
        }
        public void SetValue(DataTable data)
        {
            for (int position = 0; position < data.Rows.Count; position++)
            {
                DateTime month = (DateTime)data.Rows[position]["Ngayban"];
                int index = 0;
                int total_revenue = 0;
                while (index < data.Rows.Count)
                {
                    DateTime month_data = (DateTime)data.Rows[index]["Ngayban"];
                    if (month.Month == month_data.Month && month.Year == month_data.Year)
                    {
                        total_revenue += Convert.ToInt32(data.Rows[index]["Tongtien"]) * Convert.ToInt32(data.Rows[index]["Soluong"]);
                    }
                    index++;
                }
                string monthyear = month.Month.ToString() + "/" + month.Year.ToString();
                AxisX.Add(monthyear);
                AxisY.Add(total_revenue);
                int row_count = position;
                while (row_count < data.Rows.Count)
                {
                    DateTime month_skip = (DateTime)data.Rows[row_count]["Ngayban"];
                    if (month_skip.Month == month.Month && month_skip.Year == month.Year) row_count++;
                    else break;
                }
                position = row_count - 1;
            }

        }
        public void AddPoints(Chart chartf)
        {
            for (int index = 0; index < AxisX.Count; index++)
            {
                chartf.Series["Revenue"].Points.AddXY(AxisX[index], AxisY[index]);
            }
            //show value of the point
            chartf.Series["Revenue"].IsValueShownAsLabel = true;
            //remove grid
            chartf.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chartf.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            //axislabel
            chartf.ChartAreas["ChartArea1"].AxisX.Title = "Month";
            chartf.ChartAreas["ChartArea1"].AxisY.Title = "VND";
        }

        private void btnSAVETEXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF|*.pdf";
            sfd.FileName = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //create a pdf document  
                PdfDocument pdf = new PdfDocument();
                //add a page  
                PdfPageBase page = pdf.Pages.Add();

                //create a table  
                PdfTable table = new PdfTable();

                //export datagridview to table  
                table.DataSource = gridview_toprint.DataSource;

                //show header  
                table.Style.ShowHeader = true;

                //set cell padding  
                table.Style.CellPadding = 2;

                //set table layout  
                PdfTableLayoutFormat tableLayout = new PdfTableLayoutFormat();
                tableLayout.Break = PdfLayoutBreakType.FitElement;
                tableLayout.Layout = PdfLayoutType.Paginate;

                //draw table to pdf page  
                table.Draw(page, new RectangleF(10, 50, 300, 300), tableLayout);

                pdf.SaveToFile(sfd.FileName);
            }

        }
        private DataTable print_source()
        {
            //create datatable to save text
            DataTable data = new DataTable();
            data.Columns.Add("Revenue");
            data.Columns.Add("Month");
            for (int index = 0; index < AxisX.Count; index++)
            {
                data.Rows.Add(new object[] { AxisY[index], AxisX[index] });
            }
            return data;
        }
        private void print_chart()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image|*.jpeg";
            sfd.FileName = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".jpeg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            print_chart();
        }
    }
}
