using DesafioUsuario.Data.Repositorio;
using DesafioUsuario.Data.Repositorio.Interface;
using DesafioUsuario.Dominio.Dominio;
using DesafioUsuario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpPost]
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
            List<Usuario> lista = _usuarioRepositorio.ListarUsuarios();
            return View(lista);
        }

        public Usuario ListarPorId(int id)
        {
            var listaProId = _usuarioRepositorio.ListarPorId(id);
            return listaProId;
        }

        [HttpPost]
        public IActionResult Atualizar(ClienteModel clienteModel)
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

                _usuarioRepositorio.Atualizar(usuario);

                return RedirectToAction("Consultar");
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public void Deletar(int id)
        {
            _usuarioRepositorio.Deletar(id);
        }

    }
}
