using FluentValidation;
using MasiveApp.Application.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Validators
{
    public class CreatedUsuarioValidator : AbstractValidator<CreateUsuarioRequest>
    {
        public CreatedUsuarioValidator()
        {
            //Validaciones para Contraseña 
            RuleFor(x => x.Contraseña)
                .NotEmpty()
                .WithMessage("La contraseña es requeridad, por favor vuelva a intentarlo");

            //Validaciones para Email
            RuleFor(x => x.Email)
              .NotEmpty()
              .WithMessage("Debe ingresar un correo, por favor vuelva a intentarlo");



        }
    }
}
