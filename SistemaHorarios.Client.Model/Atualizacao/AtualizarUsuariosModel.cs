using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarUsuarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarUsuariosModel : BaseModel<AtualizarUsuariosRequest, AtualizarUsuariosResponse>
    {
        protected override Func<AtualizarUsuariosRequest, AtualizarUsuariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarUsuariosRequest, AtualizarUsuariosResponse>(service.AtualizarUsuarios);
        }
    }
}