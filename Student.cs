using System;
using System.Xml.Serialization;

[Serializable]
[XmlRoot("student")]
public class Student {
    [XmlElement(ElementName = "fname")]
    public string firstName {get; set;}
    [XmlElement(ElementName = "lname")]
    public string lastName {get; set;}
    [XmlElement(ElementName = "name")]
    public string studiesName {get; set;}
    [XmlElement(ElementName = "mode")]
    public string studiesMode {get; set;}
    [XmlAttribute(AttributeName = "indexNumber")]
    public string indexNumber {get; set;}
    [XmlElement(ElementName = "birthdate")]
    public string date {get; set;}
    public string email {get; set;}
    public string mothersName {get; set;}
    public string fathersName {get; set;}
}