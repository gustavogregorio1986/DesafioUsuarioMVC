using DesafioUsuario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUsuario.Data.Repositorio.Interface
{
    public interface IUsuarioRepositorio
    {
        void AdicionarUsuairo(Usuario usuario);

        List<Usuario> ListarUsuarios();

        Usuario ListarPorId(int id);

        void Atualizar(Usuario usuario);

        void Deletar(int id);


    }
}
