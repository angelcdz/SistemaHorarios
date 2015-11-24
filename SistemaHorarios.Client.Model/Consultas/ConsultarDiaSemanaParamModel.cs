using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarDiaSemanaParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarDiaSemanaParamModel : BaseModel<ConsultarDiaSemanaParamRequest, ConsultarDiaSemanaParamResponse>
    {
        protected override Func<ConsultarDiaSemanaParamRequest, ConsultarDiaSemanaParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarDiaSemanaParamRequest, ConsultarDiaSemanaParamResponse>(service.ConsultarDiaSemanaParam);
        }
    }
}