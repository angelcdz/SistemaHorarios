using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarCursos;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarCursosDAO : BaseDAO<CadastrarCursosRequest, CadastrarCursosResponse>
    {
        protected override CadastrarCursosResponse GetData(CadastrarCursosRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                var periodo = context.Periodos.Where(x => x.CodigoPeriodo == request.CodigoPerido).FirstOrDefault();

                if (periodo == null)
                    return new CadastrarCursosResponse() { Status = ExecutionStatus.BusinessError };

                context.Cursos.Add(new Curso()
                {
                    NomeCurso = request.Nome,
                    Periodo = periodo
                });

                context.SaveChanges();

                return new CadastrarCursosResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}