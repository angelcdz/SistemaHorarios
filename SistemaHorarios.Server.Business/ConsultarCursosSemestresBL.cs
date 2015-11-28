using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursosSemestres;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarCursosSemestresBL : BaseBL<ConsultarCursosSemestresRequest, ConsultarCursosSemestresResponse>
    {
        public override ConsultarCursosSemestresResponse Execute(ConsultarCursosSemestresRequest request)
        {
            return new ConsultarCursosSemestresDAO().Execute(request);
        }
    }
}