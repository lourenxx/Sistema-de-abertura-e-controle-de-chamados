using Microsoft.AspNetCore.Mvc;
using SistemaChamados.DAO;
using SistemaChamados.Models;
using System.Linq;

namespace SistemaChamados.Controllers
{
    public class ChamadosController : Controller
    {
        private ChamadoDAO chamadoDao = new ChamadoDAO();

        [HttpGet]
        public IActionResult Index()
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

        [HttpPost]
        public IActionResult Editar(int id)
        {
            var usuario = chamadoDao.Listar().FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            var usuario = chamadoDao.Listar()
                                    .Where(u => u.Id == id)
                                    .FirstOrDefault();
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmaDelete(int id)
        {
            chamadoDao.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
