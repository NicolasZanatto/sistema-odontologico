using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Radiografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaOdontologico.Web.Controllers
{
    public class RadiografiasController : Controller
    {
        private readonly IPacienteAppService pacienteAppService;
        private readonly IClinicaAppService clinicaAppService;
        private readonly IRadiografiaAppService radiografiaAppService;

        public RadiografiasController(IPacienteAppService pacienteAppService, IClinicaAppService clinicaAppService, IRadiografiaAppService radiografiaAppService)
        {
            this.clinicaAppService = clinicaAppService;
            this.pacienteAppService = pacienteAppService;
            this.radiografiaAppService = radiografiaAppService;
        }
        // GET: Radiografias
        public ActionResult Index(long id)
        {
            var radiografias = radiografiaAppService.BuscarPorIdPaciente(id);
            ViewBag.Paciente = radiografias.Any() ? radiografias.Select(x => x.Paciente).FirstOrDefault() : string.Empty;
            return View(radiografias);
        }

        public ActionResult Create()
        {
            CarregarCombos();
            return View();
        }

        // POST: Radiografias/Create
        [HttpPost]
        public ActionResult Create(CadastroViewModel cadastroViewModel, HttpPostedFileBase file)
        {
            if (Upload(file))
            {
                cadastroViewModel.LinkImg = file.FileName;
                radiografiaAppService.Add(cadastroViewModel);
                return RedirectToAction("Index", "Pacientes");
            }
            else
            {
                ViewBag.Msg = "Houve um erro ao salvar a radiografia, contate seu Administrador.";
                CarregarCombos();
                return View();
            }

        }

        // GET: Radiografias/Details/5
        public ActionResult Details(long id)
        {
            var radiografia = radiografiaAppService.GetById(id);
            ViewBag.Paciente = radiografia != null? radiografia.Paciente : string.Empty;
            ViewBag.Url = radiografia.LinkImg;
            return View(radiografia);
        }

        public ActionResult Delete(int id)
        {
            return View(radiografiaAppService.GetById(id));
        }

        // POST: Radiografias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long Id)
        {
            radiografiaAppService.Remove(Id);
            return RedirectToAction("Index", "Pacientes");
        }


        public bool Upload(HttpPostedFileBase file)
        {
            var model = Server.MapPath("~/Upload/Radiografias/") + file.FileName;
            if(file.ContentLength > 0)
            {
                file.SaveAs(model);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CarregarCombos()
        {
            ViewBag.Pacientes = pacienteAppService.GetAll();
            ViewBag.Clinicas = clinicaAppService.GetAll();
        }
    }
}