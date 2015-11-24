using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarComposicoesCurso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarComposicoesCursoBL : BaseBL<ConsultarComposicoesCursoRequest, ConsultarComposicoesCursoResponse>
    {
        public override ConsultarComposicoesCursoResponse Execute(ConsultarComposicoesCursoRequest request)
        {
            return new ConsultarComposicoesCursoDAO().Execute(request);
        }
    }
}