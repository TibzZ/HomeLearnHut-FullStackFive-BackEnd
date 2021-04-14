using System.Collections.Generic;

public class Homework
{
    public long? Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Dateset { get; set; }
    public string Datedue { get; set; }
    public string Comment { get; set; }
    public List<Child> children { get; set; }

}