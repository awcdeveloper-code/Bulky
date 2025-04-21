using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "AdminOnly")]
    public class CustomersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomersController> _logger;
        private string _message = string.Empty;
        public CustomersController(IUnitOfWork unitOfWork, ILogger<CustomersController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Bulky.Models.Customer> objCustomers = _unitOfWork.Customer.GetAll().ToList();
            return View(objCustomers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bulky.Models.Customer obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Customer.Add(obj);
                _unitOfWork.Save();

                _message = $"Cliente {obj.Name} creado correctamente.";
                TempData["success"] = _message;
                _logger.LogInformation(_message);
                
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Bulky.Models.Customer? customerFromDb = _unitOfWork.Customer.Get(x => x.Id == id);

            if (customerFromDb == null)
            {
                return NotFound();
            }

            return View(customerFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Bulky.Models.Customer obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Customer.Update(obj);
                _unitOfWork.Save();

                _message = $"Cliente {obj.Name} actualizado correctamente.";
                TempData["success"] = _message;
                _logger.LogInformation(_message);

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Bulky.Models.Customer? customerFromDb = _unitOfWork.Customer.Get(x => x.Id == id);

            if (customerFromDb == null)
            {
                return NotFound();
            }

            return View(customerFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Bulky.Models.Customer obj = _unitOfWork.Customer.Get(x => x.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Customer.Remove(obj);
            _unitOfWork.Save();

            _message = $"Cliente {obj.Name} eliminado correctamente.";
            TempData["success"] = _message;
            _logger.LogInformation(_message);

            return RedirectToAction("Index");
        }
    }
}
