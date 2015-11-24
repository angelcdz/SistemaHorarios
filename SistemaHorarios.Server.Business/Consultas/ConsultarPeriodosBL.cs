using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarPeriodosBL : BaseBL<ConsultarPeriodosRequest, ConsultarPeriodosResponse>
    {
        public override ConsultarPeriodosResponse Execute(ConsultarPeriodosRequest request)
        {
            return new ConsultarPeriodosDAO().Execute(request);
        }
    }
}
