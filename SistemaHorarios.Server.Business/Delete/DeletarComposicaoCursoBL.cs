using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarComposicaoCurso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarComposicaoCursoBL : BaseBL<DeletarComposicaoCursoRequest, DeletarComposicaoCursoResponse>
    {
        public override DeletarComposicaoCursoResponse Execute(DeletarComposicaoCursoRequest request)
        {
            return new DeletarComposicaoCursoDAO().Execute(request);
        }
    }
}