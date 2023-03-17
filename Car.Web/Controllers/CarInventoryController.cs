using Car.Service.DTO;
using Car.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Car.Web.Controllers
{
    public class CarInventoryController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ILogger<CarInventoryController> _logger;
        private readonly CarInventoryService _service;
        public CarInventoryController(CarInventoryService service, ILogger<CarInventoryController> logger)
        {
            _service = service;
            _logger = logger;
        }
        public async Task<ActionResult> Index()
        {
            _logger.LogError("An error occurred");
            var projects = await _service.GetProjectAsync();
            return View(projects);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(CarInventoryDTO project)
        {
            try
            {
                await _service.InsertAsync(project);
                await _service.CompletedAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
