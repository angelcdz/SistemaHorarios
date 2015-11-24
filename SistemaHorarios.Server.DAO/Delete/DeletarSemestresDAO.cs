using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarSemestres;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarSemestresDAO : BaseDAO<DeletarSemestresRequest, DeletarSemestresResponse>
    {
        protected override DeletarSemestresResponse GetData(DeletarSemestresRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Remove(context.Professores.Where(x => x.CodigoProfessor == request.Codigo).FirstOrDefault());
                context.SaveChanges();
            }
            return new DeletarSemestresResponse() { Status = ExecutionStatus.Success };
        }
    }
}