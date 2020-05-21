using AutoMapper;
using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.Infra.Data.Repositories;
using HelpdeskNeoh.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpdeskNeoh.MVC.Controllers
{
    public class DesenvolvedoresController : Controller
    {

        private readonly DesenvolvedorRepository _desenvolvedorRepository = new DesenvolvedorRepository();


        // GET: Desenvolvedores
        public ActionResult Index()
        {
            var desenvolvedorViewModel = Mapper.Map<IEnumerable<Desenvolvedor >, IEnumerable<DesenvolvedorViewModel>>(_desenvolvedorRepository.GetAll());
            return View(desenvolvedorViewModel);


          
        }

        // GET: Desenvolvedores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Desenvolvedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Desenvolvedores/Create
        [HttpPost]
        public ActionResult Create(DesenvolvedorViewModel desenvolvedor)
        {
            if (ModelState.IsValid)
            {
                var desenvolvedorDomain = Mapper.Map<DesenvolvedorViewModel, Desenvolvedor>(desenvolvedor);
                desenvolvedorDomain.DataCadastro = DateTime.Now;
                _desenvolvedorRepository.Add(desenvolvedorDomain);
                return RedirectToAction("Index");
            }
            return View(desenvolvedor);
        }

        // GET: Desenvolvedores/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Desenvolvedores/Edit/5
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

        // GET: Desenvolvedores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Desenvolvedores/Delete/5
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
