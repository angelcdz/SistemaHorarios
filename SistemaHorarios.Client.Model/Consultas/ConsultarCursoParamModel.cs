using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarCursoParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarCursoParamModel : BaseModel<ConsultarCursoParamRequest, ConsultarCursoParamResponse>
    {
        protected override Func<ConsultarCursoParamRequest, ConsultarCursoParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarCursoParamRequest, ConsultarCursoParamResponse>(service.ConsultarCursoParam);
        }
    }
}