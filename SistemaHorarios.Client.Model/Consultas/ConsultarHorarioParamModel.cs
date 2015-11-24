using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarHorarioParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarHorarioParamModel : BaseModel<ConsultarHorarioParamRequest, ConsultarHorarioParamResponse>
    {
        protected override Func<ConsultarHorarioParamRequest, ConsultarHorarioParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarHorarioParamRequest, ConsultarHorarioParamResponse>(service.ConsultarHorarioParam);
        }
    }
}