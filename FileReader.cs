using System.Collections.Generic;
using System.IO;
using System.Linq;

interface DocumentReader<T> {
    List<T> Read();
}

public class CsvReader : DocumentReader<string[]> {
    private string fileName;

    public CsvReader(string fileName) {
        this.fileName = fileName;
    }

    public List<string[]> Read() {
        var data = File.ReadAllLines(this.fileName);
        return data
            .Select(m => m.Split(","))
            .ToList();
    }
}