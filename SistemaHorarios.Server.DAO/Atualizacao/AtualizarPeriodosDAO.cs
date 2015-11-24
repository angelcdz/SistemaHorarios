using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarPeriodos;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarPeriodosDAO : BaseDAO<AtualizarPeriodosRequest, AtualizarPeriodosResponse>
    {
        protected override AtualizarPeriodosResponse GetData(AtualizarPeriodosRequest request)
        {
            throw new NotImplementedException();
        }
    }
}