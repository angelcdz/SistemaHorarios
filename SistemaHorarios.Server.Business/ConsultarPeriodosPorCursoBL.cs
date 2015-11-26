using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodosPorCurso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarPeriodosPorCursoBL : BaseBL<ConsultarPeriodosPorCursoRequest, ConsultarPeriodosPorCursoResponse>
    {
        public override ConsultarPeriodosPorCursoResponse Execute(ConsultarPeriodosPorCursoRequest request)
        {
            return new ConsultarPeriodosPorCursoDAO().Execute(request);
        }
    }
}