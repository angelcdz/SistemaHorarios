using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarProfessores;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarProfessoresDAO : BaseDAO<ConsultarProfessoresRequest, ConsultarProfessoresResponse>
    {
        protected override ConsultarProfessoresResponse GetData(ConsultarProfessoresRequest request)
        {
            var response = new ConsultarProfessoresResponse()
            {
                Professores = new System.Collections.Generic.List<ConsultarProfessoresProfessorDTO>(),
                Status = ExecutionStatus.Success
            };

            new SistemaHorariosEntities().Professores.ToList().ForEach(professor =>
                response.Professores.Add(new ConsultarProfessoresProfessorDTO()
                {
                    Codigo = professor.CodigoProfessor,
                    Nome = UppercaseWords(professor.NomeProfessor)
                }));

            return response;
        }
    }
}
