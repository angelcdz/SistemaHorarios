using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasPeriodos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarDiasPeriodosBL : BaseBL<ConsultarDiasPeriodosRequest, ConsultarDiasPeriodosResponse>
    {
        public override ConsultarDiasPeriodosResponse Execute(ConsultarDiasPeriodosRequest request)
        {
            return new ConsultarDiasPeriodosDAO().Execute(request);
        }
    }
}