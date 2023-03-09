using ActivityTrackingApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTrackingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public IActionResult GetMostFrequentlyActivityForWomen()
        {
            var (activityName, totalDuration) = _reportService.GetMostFrequentActivityForWomen();
            return Ok($"Kadınların en çok zaman ayırdığı aktivite: {activityName}, Toplam süre: {totalDuration}");
        }
        [HttpGet]
        public IActionResult GetBestActivityandTotalTime()
        {
            var (activityName, totalDuration) = _reportService.GetBestActivity();

            return Ok($"En çok sevilen aktivite: {activityName}, Toplam süre: {totalDuration}");
        }    
        [HttpGet]
        public IActionResult GetWorstActivityandTotalTime()
        {
            var (activityName, totalDuration) = _reportService.GetWorstActivity();

            return Ok($"En sevilmeyen aktivite: {activityName}, Toplam süre: {totalDuration}");
        }   
    }
}
