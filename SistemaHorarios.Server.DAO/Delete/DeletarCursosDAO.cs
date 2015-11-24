using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarCursos;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarCursosDAO : BaseDAO<DeletarCursosRequest, DeletarCursosResponse>
    {
        protected override DeletarCursosResponse GetData(DeletarCursosRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Remove(context.Professores.Where(x => x.CodigoProfessor == request.Codigo).FirstOrDefault());
                context.SaveChanges();
            }
            return new DeletarCursosResponse() { Status = ExecutionStatus.Success };
        }
    }
}