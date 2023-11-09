using DesafioUsuario.Data.Repositorio.Interface;
using DesafioUsuario.Dominio.Dominio;
using DesafioUsuario.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUsuario.Servico.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Adicionar(Usuario usuario)
        {
            _usuarioRepositorio.AdicionarUsuairo(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            _usuarioRepositorio.Atualizar(usuario);
        }

        public void Deletar(int id)
        {
            _usuarioRepositorio.Deletar(id);
        }

        public Usuario ListarPorId(int id)
        {
            return _usuarioRepositorio.ListarPorId(id);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _usuarioRepositorio.ListarUsuarios();
        }
    }
}
