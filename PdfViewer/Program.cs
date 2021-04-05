using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using PdfSharp.Pdf;

namespace PdfViewer
{
    static class Program


    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Witamy w programie do odczytywania i zarzadania plikami pdf");
            Console.WriteLine("Wybierz z menu odpowiednia opcję");

            do
            {
                Console.WriteLine("1. Przegladraka plików pdf");
               // Console.WriteLine("2. Plik pobrane");
                var choose = Console.ReadKey();
                switch (choose.KeyChar)
                {
                    case '1':
                        runPdfViewer();
                        break;
                    case '2':
                       // plikPobrane();
                        break;

                    default:
                        Console.WriteLine("Nie rozpoznano komendy.");
                        break;
                }

                Console.WriteLine("Wcisnij <Escape> aby zakonczyc...");

            } while (!Console.ReadKey().Key.Equals(ConsoleKey.Escape));


        }

        private static void runPdfViewer()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PdfApp());
        }
    }
}


    

    




