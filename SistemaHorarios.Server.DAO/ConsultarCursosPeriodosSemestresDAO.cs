using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using SistemaHorarios.Contracts.ConsultarCursosPeriodosSemestres;
using SistemaHorarios.Contracts.ConsultarSemestres;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarCursosPeriodosSemestresDAO : BaseDAO<ConsultarCursosPeriodosSemestresRequest, ConsultarCursosPeriodosSemestresResponse>
    {
        protected override ConsultarCursosPeriodosSemestresResponse GetData(ConsultarCursosPeriodosSemestresRequest request)
        {
            var response = new ConsultarCursosPeriodosSemestresResponse()
            {
                Cursos = new List<ConsultarCursosCursoDTO>(),
                Semestres= new List<ConsultarSemestresSemestreDTO>(),
                Status = ExecutionStatus.Success
            };

            using (var context = new SistemaHorariosEntities())
            {
                context.Cursos.ToList().ForEach(curso =>
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

                context
                    .Semestres
                    .ToList()
                    .ForEach(
                    semestre =>
                        response.Semestres.Add(new ConsultarSemestresSemestreDTO()
                        {
                            Codigo = semestre.CodigoSemestre,
                            Numero = semestre.NumeroSemestre
                        }));
            }

            return response;
        }
    }
}