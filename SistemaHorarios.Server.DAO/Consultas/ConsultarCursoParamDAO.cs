using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursoParam;
using SistemaHorarios.Contracts.ConsultarCursos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarCursoParamDAO : BaseDAO<ConsultarCursoParamRequest, ConsultarCursoParamResponse>
    {
        protected override ConsultarCursoParamResponse GetData(ConsultarCursoParamRequest request)
        {
            var response = new ConsultarCursoParamResponse() { Status = ExecutionStatus.Success };
            response.Cursos = new List<ConsultarCursosCursoDTO>();

            using (var context = new SistemaHorariosEntities())
            {
                if (request.Codigo != 0)
                    foreach (var item in context.Cursos.Where(curso => curso.CodigoCurso == request.Codigo))
                        response.Cursos.Add(new ConsultarCursosCursoDTO()
                        {
                            Codigo = item.CodigoCurso,
                            Nome = UppercaseWords(item.NomeCurso),
                            Periodo = new ConsultarCursosPeriodoDTO()
                            {
                                Codigo = item.Periodo.CodigoPeriodo,
                                NomePeriodo = UppercaseWords(item.Periodo.NomePeriodo)
                            }
                        });
                else if (request.CodigoPeriodo != 0)
                    foreach (var item in context.Cursos.Where(curso => curso.NomeCurso.Contains(request.Nome)
                                                           && curso.Periodo.CodigoPeriodo == request.CodigoPeriodo))
                        response.Cursos.Add(new ConsultarCursosCursoDTO()
                        {
                            Codigo = item.CodigoCurso,
                            Nome = UppercaseWords(item.NomeCurso),
                            Periodo = new ConsultarCursosPeriodoDTO()
                            {
                                Codigo = item.Periodo.CodigoPeriodo,
                                NomePeriodo = UppercaseWords(item.Periodo.NomePeriodo)
                            }
                        });
                else
                    foreach (var item in context.Cursos.Where(curso => curso.NomeCurso.Contains(request.Nome)))
                        response.Cursos.Add(new ConsultarCursosCursoDTO()
                        {
                            Codigo = item.CodigoCurso,
                            Nome = UppercaseWords(item.NomeCurso),
                            Periodo = new ConsultarCursosPeriodoDTO()
                            {
                                Codigo = item.Periodo.CodigoPeriodo,
                                NomePeriodo = UppercaseWords(item.Periodo.NomePeriodo)
                            }
                        });
            }

            return response;
        }
    }
}