using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using BulkyWeb.Areas.Customer.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "AdminOnly")]
    public class UsersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UsersController> _logger;
        private string _message = string.Empty;
        public UsersController(IUnitOfWork unitOfWork, ILogger<UsersController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<User> objUsers = _unitOfWork.User.GetAll().ToList();
            return View(objUsers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.User.Add(obj);
                _unitOfWork.Save();

                _message = $"Usuarop {obj.Name} creado correctamente.";
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

            User? userFromDb = _unitOfWork.User.Get(x => x.Id == id);

            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }

        [HttpPost]
        public IActionResult Edit(User obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.User.Update(obj);
                _unitOfWork.Save();

                _message = $"Usuario {obj.Name} actualizado correctamente.";
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

            User? userFromDb = _unitOfWork.User.Get(x => x.Id == id);

            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            User obj = _unitOfWork.User.Get(x => x.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.User.Remove(obj);
            _unitOfWork.Save();

            _message = $"Usuario {obj.Name} eliminado correctamente.";
            TempData["success"] = _message;
            _logger.LogInformation(_message);

            return RedirectToAction("Index");
        }
    }
}
