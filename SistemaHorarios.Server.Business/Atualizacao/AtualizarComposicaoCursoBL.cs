using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarComposicaoCurso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarComposicaoCursoBL : BaseBL<AtualizarComposicaoCursoRequest, AtualizarComposicaoCursoResponse>
    {
        public override AtualizarComposicaoCursoResponse Execute(AtualizarComposicaoCursoRequest request)
        {
            return new AtualizarComposicaoCursoDAO().Execute(request);
        }
    }
}