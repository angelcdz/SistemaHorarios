using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarNiveisAcesso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarNiveisAcessoDAO : BaseDAO<DeletarNiveisAcessoRequest, DeletarNiveisAcessoResponse>
    {
        protected override DeletarNiveisAcessoResponse GetData(DeletarNiveisAcessoRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Remove(context.Professores.Where(x => x.CodigoProfessor == request.Codigo).FirstOrDefault());
                context.SaveChanges();
            }
            return new DeletarNiveisAcessoResponse() { Status = ExecutionStatus.Success };
        }
    }
}