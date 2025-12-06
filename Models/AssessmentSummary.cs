namespace SchoolManagementWeb.Models;

public class AssessmentSummary
{
    public int Id { get; set; }
    public string StudentName { get; set; } = string.Empty;
    public string StudentId { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public int TotalMarks { get; set; }
    public int ObtainedMarks { get; set; }
    public decimal Percentage { get; set; }
    public string Grade { get; set; } = string.Empty;
    public DateTime ExaminationDate { get; set; }
    public string ExaminationName { get; set; } = string.Empty;
}

