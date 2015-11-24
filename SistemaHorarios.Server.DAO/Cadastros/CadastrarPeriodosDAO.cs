using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarPeriodos;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarPeriodosDAO : BaseDAO<CadastrarPeriodosRequest, CadastrarPeriodosResponse>
    {
        protected override CadastrarPeriodosResponse GetData(CadastrarPeriodosRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Periodos.Add(new Periodo() { NomePeriodo = request.Nome });

                context.SaveChanges();

                return new CadastrarPeriodosResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}