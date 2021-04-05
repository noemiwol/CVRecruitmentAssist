using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfViewer
{
    internal class CvRepository
    {
        public List<CvDto> GetCvDtos(string directoryPath)
        {
            int id = 0;
            List<CvDto> results = new List<CvDto>();
            string[] extensions = { ".pdf" };

            foreach (string filePath in Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
                .Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
            {
                id++;
                string name = Path.GetFileNameWithoutExtension(filePath);
                var cv = CreateCvDto(id, name, filePath, GetStatus(name));
                results.Add(cv);
            }
            return results;
        }
        private Status GetStatus(string name)
        {
            switch (true)
            {
                case true when name.EndsWith(Status.Odrzucone.ToString()):
                    return Status.Odrzucone;
                case true when name.EndsWith(Status.Otwarte.ToString()):
                    return Status.Otwarte;
                case true when name.EndsWith(Status.Rozpatrzone.ToString()):
                    return Status.Rozpatrzone;
                case true when name.EndsWith(Status.ZaakaceptowanaKandatura.ToString()):
                    return Status.ZaakaceptowanaKandatura;
                default:
                    return Status.Nowe;
            }
        }
        private CvDto CreateCvDto(int id, string name, string filePath, Status status)
        {
            return new CvDto(id, name, filePath, status);
        }

    }

}





