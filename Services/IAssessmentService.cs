using SchoolManagementWeb.Models;

namespace SchoolManagementWeb.Services;

public interface IAssessmentService
{
    List<AssessmentSummary> GetRecentAssessmentSummary();
    Examination? GetRecentExamination();
}

