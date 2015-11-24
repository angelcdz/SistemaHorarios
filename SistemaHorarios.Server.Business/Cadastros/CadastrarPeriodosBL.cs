using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarPeriodos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarPeriodosBL : BaseBL<CadastrarPeriodosRequest, CadastrarPeriodosResponse>
    {
        public override CadastrarPeriodosResponse Execute(CadastrarPeriodosRequest request)
        {
            return new CadastrarPeriodosDAO().Execute(request);
        }
    }
}