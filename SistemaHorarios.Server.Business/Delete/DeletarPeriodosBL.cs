using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarPeriodos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarPeriodosBL : BaseBL<DeletarPeriodosRequest, DeletarPeriodosResponse>
    {
        public override DeletarPeriodosResponse Execute(DeletarPeriodosRequest request)
        {
            return new DeletarPeriodosDAO().Execute(request);
        }
    }
}