using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarPeriodosPorCurso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarPeriodosPorCursoModel : BaseModel<ConsultarPeriodosPorCursoRequest, ConsultarPeriodosPorCursoResponse>
    {
        protected override Func<ConsultarPeriodosPorCursoRequest, ConsultarPeriodosPorCursoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarPeriodosPorCursoRequest, ConsultarPeriodosPorCursoResponse>(service.ConsultarPeriodosPorCurso);
        }
    }
}