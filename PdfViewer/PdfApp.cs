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
        }

/*        public void showPdf(string filePath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocumnet = PdfDocument.Load(stream);
            pdf.Document = pdfDocumnet;
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PdfApp_Load(object sender, EventArgs e)
        {
        }
    }
}
