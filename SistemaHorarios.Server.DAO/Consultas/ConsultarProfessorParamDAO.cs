using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarProfessores;
using SistemaHorarios.Contracts.ConsultarProfessorParam;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarProfessorParamDAO : BaseDAO<ConsultarProfessorParamRequest, ConsultarProfessorParamResponse>
    {
        protected override ConsultarProfessorParamResponse GetData(ConsultarProfessorParamRequest request)
        {
            var response = new ConsultarProfessorParamResponse() { Status = ExecutionStatus.Success };
            response.Professores = new List<ConsultarProfessoresProfessorDTO>();

            using (var context = new SistemaHorariosEntities())
            {
                if (request.Codigo != 0)
                    foreach (var item in context.Professores.Where(prof => prof.CodigoProfessor == request.Codigo))
                        response.Professores.Add(new ConsultarProfessoresProfessorDTO()
                        {
                            Codigo = item.CodigoProfessor,
                            Nome = UppercaseWords(item.NomeProfessor)
                        });
                else
                    foreach (var item in context.Professores.Where(prof => prof.NomeProfessor.Contains(request.Nome)))
                        response.Professores.Add(new ConsultarProfessoresProfessorDTO()
                        {
                            Codigo = item.CodigoProfessor,
                            Nome = UppercaseWords(item.NomeProfessor)
                        });
            }

            return response;
        }
    }
}