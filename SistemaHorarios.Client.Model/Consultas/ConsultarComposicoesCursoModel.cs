using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarComposicoesCurso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarComposicoesCursoModel : BaseModel<ConsultarComposicoesCursoRequest, ConsultarComposicoesCursoResponse>
    {
        protected override Func<ConsultarComposicoesCursoRequest, ConsultarComposicoesCursoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarComposicoesCursoRequest, ConsultarComposicoesCursoResponse>(service.ConsultarComposicoesCurso);
        }
    }
}