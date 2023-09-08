namespace GeoJson_Restful_API.Entities;

public class Adm1
{
    public int id { get; set; }
    public double shape_leng { get; set; }
    public double shape_area { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string adm0 { get; set; }
    public string adm0_code { get; set; }
    public string coordinates { get; set; }
    public double x { get; set; }
    public double y { get; set; }
}

public class Adm1List
{
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
}