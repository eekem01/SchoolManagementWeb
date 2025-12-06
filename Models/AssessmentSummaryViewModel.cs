namespace SchoolManagementWeb.Models;

public class AssessmentSummaryViewModel
{
    public Examination? Examination { get; set; }
    public List<AssessmentSummary> Assessments { get; set; } = new();
}

