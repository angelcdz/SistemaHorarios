using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarComposicoesCurso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarComposicoesCursoDAO : BaseDAO<ConsultarComposicoesCursoRequest, ConsultarComposicoesCursoResponse>
    {
        protected override ConsultarComposicoesCursoResponse GetData(ConsultarComposicoesCursoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}