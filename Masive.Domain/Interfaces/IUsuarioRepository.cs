using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masive.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
            Usuario GetUsuarioById(int idUsuario);
            
            IEnumerable<Usuario> GetUsuario();

            void InsertUsuario(Usuario usuario);

            void UpdateUsuario(Usuario usuario);

            void DeleteUsuario(int idUsuario);
        
    }
}
