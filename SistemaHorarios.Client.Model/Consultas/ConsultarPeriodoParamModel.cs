using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarPeriodoParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarPeriodoParamModel : BaseModel<ConsultarPeriodoParamRequest, ConsultarPeriodoParamResponse>
    {
        protected override Func<ConsultarPeriodoParamRequest, ConsultarPeriodoParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarPeriodoParamRequest, ConsultarPeriodoParamResponse>(service.ConsultarPeriodoParam);
        }
    }
}