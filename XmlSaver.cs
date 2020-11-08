using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class XmlSaver<T> {
    public List<T> data;

    public XmlSaver(List<T> data) {
        this.data = data;
    }

    public void Save(string path) {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
        StreamWriter writer = new StreamWriter(path);

        serializer.Serialize(writer, this.data);
        writer.Close();
    }
}