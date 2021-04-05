using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfViewer
{
    public class CvDto
    {
        private static int lastId = 0;

        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public Status Status { get; set; }

        public CvDto(string fileName, string filePath, Status status)
        {
            Id = ++lastId;
            FileName = fileName;
            FilePath = filePath;
            Status = status;
        }

        ~CvDto()
        {
            lastId -= 1;
        }
    }
}
