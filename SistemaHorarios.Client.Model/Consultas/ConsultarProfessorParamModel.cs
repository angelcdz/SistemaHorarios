using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarProfessorParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarProfessorParamModel : BaseModel<ConsultarProfessorParamRequest, ConsultarProfessorParamResponse>
    {
        protected override Func<ConsultarProfessorParamRequest, ConsultarProfessorParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarProfessorParamRequest, ConsultarProfessorParamResponse>(service.ConsultarProfessorParam);
        }
    }
}