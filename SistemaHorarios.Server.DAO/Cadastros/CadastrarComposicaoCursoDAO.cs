using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarComposicaoCurso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarComposicaoCursoDAO : BaseDAO<CadastrarComposicaoCursoRequest, CadastrarComposicaoCursoResponse>
    {
        protected override CadastrarComposicaoCursoResponse GetData(CadastrarComposicaoCursoRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                var curso = context.Cursos.Where(x => x.CodigoCurso == request.CodigoCurso).FirstOrDefault();
                var materia = context.Materias.Where(x => x.CodigoMateria == request.CodigoMateria).FirstOrDefault();
                var professor = context.Professores.Where(x => x.CodigoProfessor == request.CodigoProfessor).FirstOrDefault();
                var semestre = context.Semestres.Where(x => x.CodigoSemestre == request.CodigoSemestre).FirstOrDefault();

                if (curso == null || materia == null || professor == null || semestre == null)
                    return new CadastrarComposicaoCursoResponse() { Status = ExecutionStatus.BusinessError };

                context.ComposicoesCurso.Add(new ComposicaoCurso()
                {
                    Curso = curso,
                    Materia = materia,
                    Professor = professor,
                    Semestre = semestre
                });

                context.SaveChanges();

                return new CadastrarComposicaoCursoResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}