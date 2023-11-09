using DesafioUsuario.Data.Contexto;
using DesafioUsuario.Data.Repositorio.Interface;
using DesafioUsuario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUsuario.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private BancoContexto _db;

        public UsuarioRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void AdicionarUsuairo(Usuario usuario)
        {
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            _db.Update(usuario);
        }

        public void Deletar(int id)
        {

            _db.Remove(id);
        }

        public Usuario ListarPorId(int id)
        {
            return _db.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _db.Usuarios.ToList();
        }
    }
}
