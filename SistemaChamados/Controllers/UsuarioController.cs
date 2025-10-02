using Microsoft.AspNetCore.Mvc;
using SistemaChamados.DAO;
using SistemaChamados.Models;
using System.Linq;

namespace SistemaChamados.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDao = new UsuarioDAO();

        [HttpGet]
        public IActionResult Usuario()
        {
            var usuarios = usuarioDao.Listar();
            return View(usuarios);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                usuarioDao.Inserir(usuario); 
                return RedirectToAction("Usuario");  
            }
            return View(usuario);  
        }

        [HttpPost]
        public IActionResult Editar(int id)
        {
            var usuario = usuarioDao.Listar().FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            var usuario = usuarioDao.Listar()
                                    .Where(u => u.Id == id)
                                    .FirstOrDefault();
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmaDelete(int id)
        {
            usuarioDao.Excluir(id);
            return RedirectToAction("Usuario");
        }
    }
}

