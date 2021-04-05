
namespace PdfViewer
{
    partial class PdfApp
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
            this.loadCvs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadCvs
            // 
            this.loadCvs.Location = new System.Drawing.Point(601, 268);
            this.loadCvs.Name = "loadCvs";
            this.loadCvs.Size = new System.Drawing.Size(108, 37);
            this.loadCvs.TabIndex = 0;
            this.loadCvs.Text = "Load CVs";
            this.loadCvs.UseMnemonic = false;
            this.loadCvs.UseVisualStyleBackColor = true;
            this.loadCvs.Click += new System.EventHandler(this.loadCvs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // PdfApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadCvs);
            this.Name = "PdfApp";
            this.Text = "PdfViewer";
            this.Load += new System.EventHandler(this.PdfApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadCvs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

