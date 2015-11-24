using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarComposicaoCurso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarComposicaoCursoModel : BaseModel<AtualizarComposicaoCursoRequest, AtualizarComposicaoCursoResponse>
    {
        protected override Func<AtualizarComposicaoCursoRequest, AtualizarComposicaoCursoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarComposicaoCursoRequest, AtualizarComposicaoCursoResponse>(service.AtualizarComposicaoCurso);
        }
    }
}