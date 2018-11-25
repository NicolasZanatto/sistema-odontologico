using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaOdontologico.Web.Controllers
{
    public class PacientesController : Controller
    {
        private readonly IPacienteAppService pacienteAppService;

        public PacientesController(IPacienteAppService pacienteAppService)
        {
            this.pacienteAppService = pacienteAppService;
        }

        // GET: Pacientes
        public ActionResult Index()
        {
            return View(pacienteAppService.GetAll());
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(int id)
        {
            return View(pacienteAppService.GetById(id));
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        [HttpPost]
        public ActionResult Create(CadastroViewModel cadastroViewModel)
        {
            if (ModelState.IsValid)
            {
                pacienteAppService.Add(cadastroViewModel);
                return RedirectToAction("Index");
            }

            return View(cadastroViewModel);
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(int id)
        {
            var paciente = pacienteAppService.GetById(id);
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CadastroViewModel cadastroViewModel)
        {
            if (ModelState.IsValid)
            {
                pacienteAppService.Update(cadastroViewModel);
                return RedirectToAction("Index");
            }

            return View(cadastroViewModel);
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View(pacienteAppService.GetById(id));
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            pacienteAppService.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult Radiografias(long id)
        {
            return RedirectToAction("Index", "Radiografias", new { Id = id });
        }
    }
}
