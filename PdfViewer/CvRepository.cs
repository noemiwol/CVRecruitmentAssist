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
            List<CvDto> results = new List<CvDto>();
            string[] extensions = { ".pdf" };
            foreach (string filePath in Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
                .Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
            {
                string name = Path.GetFileNameWithoutExtension(filePath);
                var cv = CreateCvDto(name, filePath, GetStatus(name));
                results.Add(cv);
            }
            return results;
        }

        public void UpdateStatus(CvDto cvDto, Status newStatus)
        {
            if (cvDto.Status.Equals(newStatus))
            {
                return;
            }

            var lengthOfSubString = cvDto.Status.Equals(Status.Nowe)
                ? cvDto.FileName.Length
                : cvDto.FileName.IndexOf(cvDto.Status.ToString()) - 1;

            var nameWithoutStatus
                = cvDto.FileName.Substring(
                    0,
                    lengthOfSubString);

            var newName = $"{nameWithoutStatus}{newStatus}";
            var fileDirectory = Path.GetDirectoryName(cvDto.FilePath);
            var newFilePath = Path.Combine(fileDirectory, newName);

            File.Move(cvDto.FilePath, newFilePath);
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
        private CvDto CreateCvDto(string name, string filePath, Status status)
        {
            return new CvDto(name, filePath, status);
        }




    }

}





