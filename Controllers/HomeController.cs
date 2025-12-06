using Microsoft.AspNetCore.Mvc;
using SchoolManagementWeb.Models;
using SchoolManagementWeb.Services;

namespace SchoolManagementWeb.Controllers;

public class HomeController : Controller
{
    private readonly IAssessmentService _assessmentService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(IAssessmentService assessmentService, ILogger<HomeController> logger)
    {
        _assessmentService = assessmentService;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var recentExam = _assessmentService.GetRecentExamination();
        var assessments = _assessmentService.GetRecentAssessmentSummary();

        var viewModel = new AssessmentSummaryViewModel
        {
            Examination = recentExam,
            Assessments = assessments
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}

