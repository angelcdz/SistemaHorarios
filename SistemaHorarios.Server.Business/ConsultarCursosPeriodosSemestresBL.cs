using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursosPeriodosSemestres;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarCursosPeriodosSemestresBL : BaseBL<ConsultarCursosPeriodosSemestresRequest, ConsultarCursosPeriodosSemestresResponse>
    {
        public override ConsultarCursosPeriodosSemestresResponse Execute(ConsultarCursosPeriodosSemestresRequest request)
        {
            return new ConsultarCursosPeriodosSemestresDAO().Execute(request);
        }
    }
}