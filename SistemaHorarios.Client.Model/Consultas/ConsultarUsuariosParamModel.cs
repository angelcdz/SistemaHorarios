using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarUsuariosParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarUsuariosParamModel : BaseModel<ConsultarUsuariosParamRequest, ConsultarUsuariosParamResponse>
    {
        protected override Func<ConsultarUsuariosParamRequest, ConsultarUsuariosParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarUsuariosParamRequest, ConsultarUsuariosParamResponse>(service.ConsultarUsuariosParam);
        }
    }
}