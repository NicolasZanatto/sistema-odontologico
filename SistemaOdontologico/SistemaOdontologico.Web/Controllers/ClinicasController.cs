using AutoMapper;
using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Clinica;
using SistemaOdontologico.Application.ViewModels.Usuario;
using SistemaOdontologico.Domain.Core.Models;
using SistemaOdontologico.Domain.Models;
using SistemaOdontologico.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaOdontologico.Web.Controllers
{
    public class ClinicasController : Controller
    {
        private readonly IClinicaAppService clinicaAppService;

        public ClinicasController(IClinicaAppService clinicaAppService)
        {
            this.clinicaAppService = clinicaAppService;
        }

        // GET: Clinicas
        public ActionResult Index()
        {
            var clinicaViewModel = clinicaAppService.GetAll();
            return View(clinicaViewModel);
        }

        // GET: Clinicas/Details/5
        public ActionResult Details(long id)
        {
            var clinicaViewModel = clinicaAppService.GetById(id);
            return View(clinicaViewModel);
        }

        // GET: Clinicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clinicas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CadastroViewModel clinicaViewModel)
        {
            if (ModelState.IsValid)
            {
                clinicaAppService.Add(clinicaViewModel);
                return RedirectToAction("Index");
            }

            return View(clinicaViewModel);
        }

        // GET: Clinicas/Edit/5
        public ActionResult Edit(long id)
        {
            var clinicaViewModel = clinicaAppService.GetById(id);
            return View(clinicaViewModel);
        }

        // POST: Clinicas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CadastroViewModel clinicaViewModel)
        {
            if (ModelState.IsValid)
            {
                clinicaAppService.Update(clinicaViewModel);
                return RedirectToAction("Index");
            }

            return View(clinicaViewModel);
        }

        // GET: Clinicas/Delete/5
        public ActionResult Delete(long id)
        {
            var clinicaViewModel = clinicaAppService.GetById(id);
            return View(clinicaViewModel);
        }

        // POST: Clinicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            clinicaAppService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
