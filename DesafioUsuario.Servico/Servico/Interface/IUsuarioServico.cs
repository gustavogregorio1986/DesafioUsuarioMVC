using DesafioUsuario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUsuario.Servico.Servico.Interface
{
    public interface IUsuarioServico
    {
        void Adicionar(Usuario usuario);

        List<Usuario> ListarUsuarios();

        void Atualizar(Usuario usuario);

        Usuario ListarPorId(int id);

        void Deletar(int id);
    }
}
