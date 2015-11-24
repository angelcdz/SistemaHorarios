using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarPeriodos;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarPeriodosDAO : BaseDAO<DeletarPeriodosRequest, DeletarPeriodosResponse>
    {
        protected override DeletarPeriodosResponse GetData(DeletarPeriodosRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Remove(context.Professores.Where(x => x.CodigoProfessor == request.Codigo).FirstOrDefault());
                context.SaveChanges();
            }
            return new DeletarPeriodosResponse() { Status = ExecutionStatus.Success };
        }
    }
}