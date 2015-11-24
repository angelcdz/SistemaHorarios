using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarMaterias;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarMateriasDAO : BaseDAO<DeletarMateriasRequest, DeletarMateriasResponse>
    {
        protected override DeletarMateriasResponse GetData(DeletarMateriasRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Remove(context.Professores.Where(x => x.CodigoProfessor == request.Codigo).FirstOrDefault());
                context.SaveChanges();
            }
            return new DeletarMateriasResponse() { Status = ExecutionStatus.Success };
        }
    }
}