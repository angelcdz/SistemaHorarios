using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarComposicaoCurso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarComposicaoCursoDAO : BaseDAO<DeletarComposicaoCursoRequest, DeletarComposicaoCursoResponse>
    {
        protected override DeletarComposicaoCursoResponse GetData(DeletarComposicaoCursoRequest request)
        {
            new SistemaHorariosEntities().Cursos.Remove(new Curso() { CodigoCurso = request.Codigo });
            return new DeletarComposicaoCursoResponse() { Status = ExecutionStatus.Success };
        }
    }
}