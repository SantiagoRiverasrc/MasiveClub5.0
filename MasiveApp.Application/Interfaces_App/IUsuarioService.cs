using MasiveApp.Application.Request;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Interfaces_App
{
    public  interface IUsuarioService
    {

        UsuarioResponse GetUsuarioById(int idUsuario);
        IEnumerable<UsuarioResponse> GetUsuario();

        void InsertUsuario(CreateUsuarioRequest usuario);

        void UpdateUsuario(UpdateUsuarioRequest usuario);

        void DeleteUsuario(int idUsuario);
    }
}
