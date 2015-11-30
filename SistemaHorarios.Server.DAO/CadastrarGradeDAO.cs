using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarGrade;
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