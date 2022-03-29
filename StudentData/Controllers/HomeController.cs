using Microsoft.AspNetCore.Mvc;
using StudentData.Data;
using StudentData.Models;
using System.Diagnostics;

namespace StudentData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentContext _context;

        public HomeController(ILogger<HomeController> logger, StudentContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AjaxTest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save([Bind("Name,Age")]TestAjax test)
        {
            test.Status = true;
            _context.Add(test);
            await _context.SaveChangesAsync();

            return this.Ok("Success");
        }

        public  async Task<IActionResult> List()
        {
            var data = _context.testAjaxes.ToList();

            return this.Ok(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}