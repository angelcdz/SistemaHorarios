using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarSemestres;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarSemestresBL : BaseBL<ConsultarSemestresRequest, ConsultarSemestresResponse>
    {
        public override ConsultarSemestresResponse Execute(ConsultarSemestresRequest request)
        {
            return new ConsultarSemestresDAO().Execute(request);
        }
    }
}
