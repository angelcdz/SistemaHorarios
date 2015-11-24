using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarProfessores;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarProfessoresDAO : BaseDAO<CadastrarProfessoresRequest, CadastrarProfessoresResponse>
    {
        protected override CadastrarProfessoresResponse GetData(CadastrarProfessoresRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Professores.Add(new Professor() { NomeProfessor = request.Nome.ToUpper() });

                context.SaveChanges();

                return new CadastrarProfessoresResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}