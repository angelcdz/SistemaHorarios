using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarComposicaoCurso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarComposicaoCursoDAO : BaseDAO<AtualizarComposicaoCursoRequest, AtualizarComposicaoCursoResponse>
    {
        protected override AtualizarComposicaoCursoResponse GetData(AtualizarComposicaoCursoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}