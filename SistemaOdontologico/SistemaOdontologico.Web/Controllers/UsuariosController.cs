using AutoMapper;
using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Usuario;
using SistemaOdontologico.Domain.Models;
using SistemaOdontologico.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaOdontologico.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UsuarioRepository usuarioRepository = new UsuarioRepository();
        private readonly IUsuarioAppService usuarioAppService;
        // GET: Usuarios
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(usuarioRepository.GetAll());
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
                usuarioRepository.Add(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuarioViewModel);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
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

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
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
