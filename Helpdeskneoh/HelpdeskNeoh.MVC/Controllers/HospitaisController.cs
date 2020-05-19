using AutoMapper;
using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.Infra.Data.Repositories;
using HelpdeskNeoh.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HelpdeskNeoh.MVC.Controllers
{
    public class HospitaisController : Controller
    {

        private readonly HospitalRepository _hospitalRepository = new HospitalRepository();


        // GET: Hospitais
        public ActionResult Index()
        {

            var hospitalViewModel = Mapper.Map<IEnumerable<Hospital>, IEnumerable<HospitalViewModel>>(_hospitalRepository.GetAll());
            return View(hospitalViewModel);
        }

        // GET: Hospitais/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hospitais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospitais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HospitalViewModel hospital)
        {
            if (ModelState.IsValid)
            {
                var hospitalDomain = Mapper.Map<HospitalViewModel, Hospital>(hospital);
                _hospitalRepository.Add(hospitalDomain);
                return RedirectToAction("Index");
            }
            return View(hospital);
        }

        // GET: Hospitais/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hospitais/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hospitais/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hospitais/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
