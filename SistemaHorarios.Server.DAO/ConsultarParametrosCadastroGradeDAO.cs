using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarMaterias;
using SistemaHorarios.Contracts.ConsultarParametrosCadastroGrade;
using SistemaHorarios.Contracts.ConsultarProfessores;
using SistemaHorarios.Contracts.ConsultarSemestres;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarParametrosCadastroGradeDAO : BaseDAO<ConsultarParametrosCadastroGradeRequest, ConsultarParametrosCadastroGradeResponse>
    {
        protected override ConsultarParametrosCadastroGradeResponse GetData(ConsultarParametrosCadastroGradeRequest request)
        {
            var response = new ConsultarParametrosCadastroGradeResponse()
            {
                Status = ExecutionStatus.Success,
                Cursos = new List<ConsultarCursosCursoDTO>(),
                Dias = new List<ConsultarDiasSemanaDiaDTO>(),
                Materias = new List<ConsultarMateriasMateriaDTO>(),
                Professores = new List<ConsultarProfessoresProfessorDTO>(),
                Semestres = new List<ConsultarSemestresSemestreDTO>()
            };

            using (var context = new SistemaHorariosEntities())
            {
                context
                    .Materias
                    .ToList()
                    .ForEach(
                    materia =>
                        response.Materias.Add(new ConsultarMateriasMateriaDTO()
                        {
                            Codigo = materia.CodigoMateria,
                            Nome = UppercaseWords(materia.NomeMateria)
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
                context
                    .Professores
                    .ToList()
                    .ForEach(
                    professor =>
                        response.Professores.Add(new ConsultarProfessoresProfessorDTO()
                        {
                            Codigo = professor.CodigoProfessor,
                            Nome = UppercaseWords(professor.NomeProfessor)
                        }));
                context
                    .Cursos
                    .ToList()
                    .ForEach(
                    curso =>
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
                    .DiasSemana
                    .ToList()
                    .ForEach(
                    dia =>
                        response.Dias.Add(new ConsultarDiasSemanaDiaDTO()
                        {
                            CodigoDia = dia.CodigoDia,
                            Nome = UppercaseWords(dia.NomeDia)
                        }));
            }

            return response;
        }
    }
}