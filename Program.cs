using System;
using System.IO;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                throw new ArgumentNullException("Nie podano parametrów.");
            }
            
            try {
                var reader = new CsvReader(args[0]);
                var list = reader.Read();
                var students = new StudentsList(list).Validate();
                var fileName = "result.xml";
                var format = "xml";

                if (args.Length >= 2) {
                    fileName = args[1];
                }

                if (args.Length == 3) {
                    format = args[2];
                }

                if (format == "xml") {
                    var xmlSaver = new XmlSaver<Student>(students);
                    xmlSaver.Save(fileName);
                } else {
                    throw new ArgumentOutOfRangeException("Nieznany format: " + format);
                }
            } catch (FileNotFoundException) {
                throw new FileNotFoundException("Nie znaleziono pliku: " + args[0]);   
            }
        }
    }
}
