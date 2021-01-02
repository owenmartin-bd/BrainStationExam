using BrainStationExam.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainStationExam.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository _reportRepository;

        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetReports()
        {
            return Ok(await _reportRepository.GetPosts());
        }
    }
}
