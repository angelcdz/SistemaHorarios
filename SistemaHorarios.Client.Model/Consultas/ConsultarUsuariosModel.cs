using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarUsuariosModel : BaseModel<ConsultarUsuariosRequest, ConsultarUsuariosResponse>
    {
        protected override Func<ConsultarUsuariosRequest, ConsultarUsuariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarUsuariosRequest, ConsultarUsuariosResponse>(service.ConsultarUsuarios);
        }
    }
}