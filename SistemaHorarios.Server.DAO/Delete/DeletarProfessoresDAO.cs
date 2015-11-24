using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarProfessores;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarProfessoresDAO : BaseDAO<DeletarProfessoresRequest, DeletarProfessoresResponse>
    {
        protected override DeletarProfessoresResponse GetData(DeletarProfessoresRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Remove(context.Professores.Where(x => x.CodigoProfessor == request.Codigo).FirstOrDefault());
                context.SaveChanges();
            }
            return new DeletarProfessoresResponse() { Status = ExecutionStatus.Success };
        }
    }
}