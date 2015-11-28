using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarCursosSemestres;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarCursosSemestresModel : BaseModel<ConsultarCursosSemestresRequest, ConsultarCursosSemestresResponse>
    {
        protected override Func<ConsultarCursosSemestresRequest, ConsultarCursosSemestresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarCursosSemestresRequest, ConsultarCursosSemestresResponse>(service.ConsultarCursosSemestres);
        }
    }
}