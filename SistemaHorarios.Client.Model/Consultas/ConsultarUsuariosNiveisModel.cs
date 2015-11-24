using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarUsuariosNiveis;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarUsuariosNiveisModel : BaseModel<ConsultarUsuariosNiveisRequest, ConsultarUsuariosNiveisResponse>
    {
        protected override Func<ConsultarUsuariosNiveisRequest, ConsultarUsuariosNiveisResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarUsuariosNiveisRequest, ConsultarUsuariosNiveisResponse>(service.ConsultarUsuariosNiveis);
        }
    }
}