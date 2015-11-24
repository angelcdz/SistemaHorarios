using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarPeriodos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarPeriodosBL : BaseBL<AtualizarPeriodosRequest, AtualizarPeriodosResponse>
    {
        public override AtualizarPeriodosResponse Execute(AtualizarPeriodosRequest request)
        {
            return new AtualizarPeriodosDAO().Execute(request);
        }
    }
}