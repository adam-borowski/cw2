using System;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new CsvReader("dane.csv");
            var list = reader.Read();
            var students = new StudentsList(list).Validate();
            var xmlSaver = new XmlSaver<Student>(students);
            xmlSaver.Save("data.xml");
        }
    }
}
