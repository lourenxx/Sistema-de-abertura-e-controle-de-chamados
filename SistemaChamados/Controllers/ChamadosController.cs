using Microsoft.AspNetCore.Mvc;
using SistemaChamados.DAO;
using SistemaChamados.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaChamados.Controllers
{
    public class ChamadosController : Controller
    {
        private ChamadoDAO chamadoDao = new ChamadoDAO();

        [HttpGet]
        public IActionResult Index()
        {
            List<ChamadosViewModel> chamadosViewModel = chamadoDao.Listar();

            if(chamadosViewModel == null)
            {
                chamadosViewModel = new List<ChamadosViewModel>();
            }

            return View(chamadosViewModel);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ChamadosViewModel chamado)
        {
            if (ModelState.IsValid)
            {
                chamadoDao.Inserir(chamado);
                return RedirectToAction("Index");
            }

            return View(chamado);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var chamado = chamadoDao.Listar().FirstOrDefault(u => u.Id == id);
            if (chamado == null)
            {
                return NotFound();
            }
            return View(chamado);
        }

        [HttpPost]
        public IActionResult Editar(ChamadosViewModel chamado)
        {
            if (ModelState.IsValid)
            {
                chamadoDao.Alterar(chamado);
                return RedirectToAction("Index");
            }
            return View(chamado);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            var chamado = chamadoDao.Listar()
                                    .Where(u => u.Id == id)
                                    .FirstOrDefault();
            if (chamado == null)
                return NotFound();

            return View(chamado);
        }

        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmaDelete(int id)
        {
            chamadoDao.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
