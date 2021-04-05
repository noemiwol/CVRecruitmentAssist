using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;

namespace PdfViewer
{
    public partial class PdfApp : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public PdfApp()
        {
            InitializeComponent();
            pdf = new PdfiumViewer.PdfViewer();
            this.Controls.Add(pdf);
        }

        private void loadCvs_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                LoadCvs(dialog.SelectedPath);
            }
        }

        public void LoadCvs(string directoryPath)
        {
            var cvRepository = new CvRepository();
            var cvs = cvRepository.GetCvDtos(directoryPath);
            dataGridView1.DataSource = cvs;
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("FileName", typeof(string));
            dataTable.Columns.Add("FilePath", typeof(string));
            dataTable.Columns.Add("Status", typeof(Status));

            foreach (CvDto cvDto in cvs)
            {
                dataTable.Rows.Add(cvDto.Id, cvDto.FileName,cvDto.FilePath,cvDto.Status);
            }
            dataGridView1.DataSource = dataTable;

            DataGridViewComboBoxColumn dcomboStatus = new DataGridViewComboBoxColumn();
            dcomboStatus.HeaderText = "Status";
            foreach(Status status in Enum.GetValues(typeof(Status)))
            {
                dcomboStatus.Items.Add(status);
            }
            dataGridView1.Columns.Add(dcomboStatus);



        }

        /*        public void showPdf(string filePath)
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(filepath);
                    var stream = new MemoryStream(bytes);
                    PdfDocument pdfDocumnet = PdfDocument.Load(stream);
                    pdf.Document = pdfDocumnet;
                }*/

        private void PdfApp_Load(object sender, EventArgs e)
        {
        }

       
    }
}
