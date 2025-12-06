using SchoolManagementWeb.Models;

namespace SchoolManagementWeb.Services;

public class AssessmentService : IAssessmentService
{
    private readonly List<AssessmentSummary> _assessments;
    private readonly List<Examination> _examinations;

    public AssessmentService()
    {
        // Sample examination data
        _examinations = new List<Examination>
        {
            new Examination
            {
                Id = 1,
                Name = "Mid-Term Examination 2024",
                StartDate = new DateTime(2024, 3, 1),
                EndDate = new DateTime(2024, 3, 15),
                IsConcluded = true,
                AcademicYear = "2023-2024"
            },
            new Examination
            {
                Id = 2,
                Name = "Final Examination 2024",
                StartDate = new DateTime(2024, 5, 1),
                EndDate = new DateTime(2024, 5, 20),
                IsConcluded = true,
                AcademicYear = "2023-2024"
            }
        };

        // Sample assessment data
        _assessments = new List<AssessmentSummary>
        {
            new AssessmentSummary
            {
                Id = 1,
                StudentName = "John Smith",
                StudentId = "STU001",
                Subject = "Mathematics",
                TotalMarks = 100,
                ObtainedMarks = 85,
                Percentage = 85.0m,
                Grade = "A",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 2,
                StudentName = "John Smith",
                StudentId = "STU001",
                Subject = "English",
                TotalMarks = 100,
                ObtainedMarks = 92,
                Percentage = 92.0m,
                Grade = "A+",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 3,
                StudentName = "John Smith",
                StudentId = "STU001",
                Subject = "Science",
                TotalMarks = 100,
                ObtainedMarks = 78,
                Percentage = 78.0m,
                Grade = "B+",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 4,
                StudentName = "Emily Johnson",
                StudentId = "STU002",
                Subject = "Mathematics",
                TotalMarks = 100,
                ObtainedMarks = 95,
                Percentage = 95.0m,
                Grade = "A+",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 5,
                StudentName = "Emily Johnson",
                StudentId = "STU002",
                Subject = "English",
                TotalMarks = 100,
                ObtainedMarks = 88,
                Percentage = 88.0m,
                Grade = "A",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 6,
                StudentName = "Emily Johnson",
                StudentId = "STU002",
                Subject = "Science",
                TotalMarks = 100,
                ObtainedMarks = 90,
                Percentage = 90.0m,
                Grade = "A",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 7,
                StudentName = "Michael Brown",
                StudentId = "STU003",
                Subject = "Mathematics",
                TotalMarks = 100,
                ObtainedMarks = 72,
                Percentage = 72.0m,
                Grade = "B",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 8,
                StudentName = "Michael Brown",
                StudentId = "STU003",
                Subject = "English",
                TotalMarks = 100,
                ObtainedMarks = 75,
                Percentage = 75.0m,
                Grade = "B",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 9,
                StudentName = "Michael Brown",
                StudentId = "STU003",
                Subject = "Science",
                TotalMarks = 100,
                ObtainedMarks = 80,
                Percentage = 80.0m,
                Grade = "A-",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 10,
                StudentName = "Sarah Davis",
                StudentId = "STU004",
                Subject = "Mathematics",
                TotalMarks = 100,
                ObtainedMarks = 88,
                Percentage = 88.0m,
                Grade = "A",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 11,
                StudentName = "Sarah Davis",
                StudentId = "STU004",
                Subject = "English",
                TotalMarks = 100,
                ObtainedMarks = 85,
                Percentage = 85.0m,
                Grade = "A",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            },
            new AssessmentSummary
            {
                Id = 12,
                StudentName = "Sarah Davis",
                StudentId = "STU004",
                Subject = "Science",
                TotalMarks = 100,
                ObtainedMarks = 82,
                Percentage = 82.0m,
                Grade = "A-",
                ExaminationDate = new DateTime(2024, 5, 20),
                ExaminationName = "Final Examination 2024"
            }
        };
    }

    public List<AssessmentSummary> GetRecentAssessmentSummary()
    {
        var recentExam = GetRecentExamination();
        if (recentExam == null)
            return new List<AssessmentSummary>();

        return _assessments
            .Where(a => a.ExaminationName == recentExam.Name)
            .OrderBy(a => a.StudentName)
            .ThenBy(a => a.Subject)
            .ToList();
    }

    public Examination? GetRecentExamination()
    {
        return _examinations
            .Where(e => e.IsConcluded)
            .OrderByDescending(e => e.EndDate)
            .FirstOrDefault();
    }
}

