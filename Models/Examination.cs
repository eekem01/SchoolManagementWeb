namespace SchoolManagementWeb.Models;

public class Examination
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsConcluded { get; set; }
    public string AcademicYear { get; set; } = string.Empty;
}

