using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AutenticarUsuario;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AutenticarUsuarioModel : BaseModel<AutenticarUsuarioRequest, AutenticarUsuarioResponse>
    {
        protected override Func<AutenticarUsuarioRequest, AutenticarUsuarioResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AutenticarUsuarioRequest, AutenticarUsuarioResponse>(service.AutenticarUsuario);
        }
    }
}