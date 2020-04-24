using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParcialesWeb.Data;
using ParcialesWeb.Models;

namespace ParcialesWeb.Controllers
{
    public class ConsultasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ApplicationDbContext _ctx;
        public ConsultasController(ApplicationDbContext context)
        {
            _ctx = context;
        }

        public ActionResult PromAcumulado()
        {
            var proms = _ctx.EstudianteK.Select(e => new EstPromAcumulado
            {
                Nombre = e.Nombre,
                Promedio = e.ParcialK.GroupBy(p => p.CursoK).Average(g => g.Average(n => n.Nota))
            });
            return View(proms);
        }
        public ActionResult ListasClase()
        {
            var listas = _ctx.CursoK.Select(c => new Lista
            {
                Materia = c.MateriaK.Nombre,
                Semestre = c.AñoSem,
                Grupo = c.Grupo,
                Estudiantes = c.ParcialK.Select(p => p.EstudianteK.Nombre).Distinct()
            });
            return View(listas);
        }
    }
}