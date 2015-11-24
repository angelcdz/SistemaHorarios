using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarPeriodosDAO : BaseDAO<ConsultarPeriodosRequest, ConsultarPeriodosResponse>
    {
        protected override ConsultarPeriodosResponse GetData(ConsultarPeriodosRequest request)
        {
            var response = new ConsultarPeriodosResponse()
            {
                Periodos = new System.Collections.Generic.List<ConsultarPeriodosPeriodoDTO>(),
                Status = ExecutionStatus.Success
            };

            new SistemaHorariosEntities().Periodos.ToList().ForEach(periodo =>
                response.Periodos.Add(new ConsultarPeriodosPeriodoDTO()
                {
                    Codigo = periodo.CodigoPeriodo,
                    Nome = UppercaseWords(periodo.NomePeriodo)
                }));

            return response;
        }
    }
}
