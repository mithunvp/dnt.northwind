using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNT.NorthWind.DataAccess.Interface;
using DNT.NorthWind.Models;
using Microsoft.AspNetCore.Http;
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
            try
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
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}