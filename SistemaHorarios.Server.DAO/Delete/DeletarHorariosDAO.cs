using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarHorarios;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarHorariosDAO : BaseDAO<DeletarHorariosRequest, DeletarHorariosResponse>
    {
        protected override DeletarHorariosResponse GetData(DeletarHorariosRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Remove(context.Professores.Where(x => x.CodigoProfessor == request.Codigo).FirstOrDefault());
                context.SaveChanges();
            }
            return new DeletarHorariosResponse() { Status = ExecutionStatus.Success };
        }
    }
}