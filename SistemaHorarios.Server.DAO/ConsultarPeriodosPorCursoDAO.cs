using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodosPorCurso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarPeriodosPorCursoDAO : BaseDAO<ConsultarPeriodosPorCursoRequest, ConsultarPeriodosPorCursoResponse>
    {
        protected override ConsultarPeriodosPorCursoResponse GetData(ConsultarPeriodosPorCursoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}