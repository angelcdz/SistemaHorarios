using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarCursosPeriodosSemestres;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarCursosPeriodosSemestresModel : BaseModel<ConsultarCursosPeriodosSemestresRequest, ConsultarCursosPeriodosSemestresResponse>
    {
        protected override Func<ConsultarCursosPeriodosSemestresRequest, ConsultarCursosPeriodosSemestresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarCursosPeriodosSemestresRequest, ConsultarCursosPeriodosSemestresResponse>(service.ConsultarCursosPeriodosSemestres);
        }
    }
}