using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarCursosDAO : BaseDAO<ConsultarCursosRequest, ConsultarCursosResponse>
    {
        protected override ConsultarCursosResponse GetData(ConsultarCursosRequest request)
        {
            var response = new ConsultarCursosResponse()
            {
                Cursos = new System.Collections.Generic.List<ConsultarCursosCursoDTO>(),
                Status = ExecutionStatus.Success
            };

            new SistemaHorariosEntities().Cursos.ToList().ForEach(curso =>
                response.Cursos.Add(new ConsultarCursosCursoDTO()
                {
                    Codigo = curso.CodigoCurso,
                    Nome = UppercaseWords(curso.NomeCurso),
                    Periodo = new ConsultarCursosPeriodoDTO()
                    {
                        Codigo = curso.Periodo.CodigoPeriodo,
                        NomePeriodo = UppercaseWords(curso.Periodo.NomePeriodo)
                    }
                }));

            return response;
        }
    }
}
