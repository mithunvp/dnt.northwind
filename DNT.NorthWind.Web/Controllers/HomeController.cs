using DNT.NorthWind.DataAccess.Interface;
using DNT.NorthWind.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNT.NorthWind.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeesRepository _employeeRepository;

        public HomeController(IEmployeesRepository employeesRepository)
        {
            _employeeRepository = employeesRepository;
        }
        // GET: Home
        public ActionResult Index()
        {
            var AllEmployees = _employeeRepository.GetEmployeesByQuery();
            return View(AllEmployees);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var Employee = _employeeRepository.GetEmployeesById(id);
            return View(Employee);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employees data)
        {
            var employeeId = _employeeRepository.AddEmployee(data);
                if (employeeId > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }             
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var Employee = _employeeRepository.GetEmployeesById(id);
            return View(Employee);
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employees data)
        {
            var employeeUpdated = _employeeRepository.UpdateEmployee(id, data);
            if (employeeUpdated)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var deleted = _employeeRepository.DeleteEmployee(id);
            if (deleted)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }        
    }
}