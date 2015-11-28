using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursosSemestres;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarCursosSemestresDAO : BaseDAO<ConsultarCursosSemestresRequest, ConsultarCursosSemestresResponse>
    {
        protected override ConsultarCursosSemestresResponse GetData(ConsultarCursosSemestresRequest request)
        {
            throw new NotImplementedException();
        }
    }
}