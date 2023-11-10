using DesafioUsuario.Data.Repositorio;
using DesafioUsuario.Data.Repositorio.Interface;
using DesafioUsuario.Dominio.Dominio;
using DesafioUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioUsuario.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ClienteController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Cadastro(ClienteModel clienteModel)
        {
            try
            {
                Usuario usuario = new Usuario();
                clienteModel = new ClienteModel()
                {
                    IdUsuario = usuario.IdUsuario,
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Senha = usuario.Senha,
                    Upload = usuario.Upload
                };

                _usuarioRepositorio.AdicionarUsuairo(usuario);

                return RedirectToAction("Cadastrar");
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public IActionResult Consulta()
        {
            return View();
        }
    }
}
