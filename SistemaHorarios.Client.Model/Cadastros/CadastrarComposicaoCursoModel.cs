using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarComposicaoCurso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarComposicaoCursoModel : BaseModel<CadastrarComposicaoCursoRequest, CadastrarComposicaoCursoResponse>
    {
        protected override Func<CadastrarComposicaoCursoRequest, CadastrarComposicaoCursoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarComposicaoCursoRequest, CadastrarComposicaoCursoResponse>(service.CadastrarComposicaoCurso);
        }
    }
}