using AutoMapper;
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
        private readonly ClinicaRepository clinicaRepository = new ClinicaRepository();
        private readonly UsuarioRepository usuarioRepository = new UsuarioRepository();
        // GET: Clinicas
        public ActionResult Index()
        {
            var clinicaViewModel = Mapper.Map<IEnumerable<Clinica>, IEnumerable<ListagemViewModel>>(clinicaRepository.GetAll());
            return View(clinicaViewModel);
        }

        // GET: Clinicas/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                UsuarioViewModel usuarioViewModel = new UsuarioViewModel
                {
                    Nome = clinicaViewModel.Nome,
                    Login = clinicaViewModel.Login,
                    Senha = clinicaViewModel.Senha,
                    Ativo = clinicaViewModel.Ativo,
                    TipoUsuario = eTipoUsuario.Clinica
                };
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
                clinicaViewModel.Usuario = usuarioRepository.AddReturnEntity(usuarioDomain);
                var clinicaDomain = Mapper.Map<CadastroViewModel, Clinica>(clinicaViewModel);

                clinicaRepository.Add(clinicaDomain);

                return RedirectToAction("Index");
            }

            return View(clinicaViewModel);
        }

        // GET: Clinicas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clinicas/Edit/5
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

        // GET: Clinicas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clinicas/Delete/5
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
