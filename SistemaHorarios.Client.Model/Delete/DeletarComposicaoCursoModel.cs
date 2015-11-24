using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarComposicaoCurso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarComposicaoCursoModel : BaseModel<DeletarComposicaoCursoRequest, DeletarComposicaoCursoResponse>
    {
        protected override Func<DeletarComposicaoCursoRequest, DeletarComposicaoCursoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarComposicaoCursoRequest, DeletarComposicaoCursoResponse>(service.DeletarComposicaoCurso);
        }
    }
}