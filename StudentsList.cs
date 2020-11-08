using System.Collections.Generic;
using System.Linq;

public class StudentsList {
    private List<string[]> rawList;

    public StudentsList(List<string[]> list) {
        this.rawList = list;
    }

    public List<Student> Validate() {
        return this.rawList
            .Select(m => new Student() {
                firstName = m[0],
                lastName = m[1],
                studiesName = m[2],
                studiesMode = m[3],
                indexNumber = m[4],
                date = m[5],
                email = m[6],
                mothersName = m[7],
                fathersName = m[8]
            })
            .GroupBy(m => new {
                m.firstName,
                m.lastName,
                m.indexNumber
            })
            .Select(group => group.First())
            .ToList();
    }
}