using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarGrade;
using SistemaHorarios.Contracts.ConsultarGrade;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarGradeDAO : BaseDAO<CadastrarGradeRequest, CadastrarGradeResponse>
    {
        protected override CadastrarGradeResponse GetData(CadastrarGradeRequest request)
        {
            var response = new CadastrarGradeResponse() { Status = ExecutionStatus.Success };

            using (var context = new SistemaHorariosEntities())
            {
                var query =
                context.Database.SqlQuery<ConsultarGradeHorarioMateriaDTO>(@"SELECT	MA.NOME_MATERIA Materia,
	                                                                            PR.COD_PROFESSOR Professor
                                                                            FROM COMPOSICAO_HORARIO CH
                                                                            JOIN COMPOSICAO_CURSO CC
                                                                            ON CH.COD_COMP_CURSO = CC.COD_COMP_CURSO
                                                                            JOIN MATERIA MA
                                                                            ON CC.COD_MATERIA = MA.COD_MATERIA
                                                                            JOIN PROFESSOR PR
                                                                            ON CC.COD_PROFESSOR = PR.COD_PROFESSOR
                                                                            WHERE CH.COD_HORARIO = @p0
	                                                                        AND PR.COD_PROFESSOR = @p1",
                                                                                request.CodigoHorario,
                                                                                request.CodigoProfessor).ToList();

                if (query.Count > 0)
                    throw new Exception("Professor já tem uma matéria cadastrada neste horário");


                context.ComposicoesHorario.Add(new ComposicaoHorario()
                {
                    ComposicaoCurso = context.ComposicoesCurso.Add(
                                        new ComposicaoCurso()
                                        {
                                            Curso = context.Cursos.First(x => x.CodigoCurso == request.CodigoCurso),
                                            Materia = context.Materias.First(x => x.CodigoMateria == request.CodigoMateria),
                                            Professor = context.Professores.First(x => x.CodigoProfessor == request.CodigoProfessor),
                                            Semestre = context.Semestres.First(x => x.CodigoSemestre == request.CodigoSemestre)
                                        }),
                    Horario = context.Horarios.First(x => x.CodigoHorario == request.CodigoHorario)
                });

                context.SaveChanges();
            }

            return response;
        }
    }
}