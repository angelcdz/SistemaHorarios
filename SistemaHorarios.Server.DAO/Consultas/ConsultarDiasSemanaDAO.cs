using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarDiasSemanaDAO : BaseDAO<ConsultarDiasSemanaRequest, ConsultarDiasSemanaResponse>
    {
        protected override ConsultarDiasSemanaResponse GetData(ConsultarDiasSemanaRequest request)
        {
            var response = new ConsultarDiasSemanaResponse()
            {
                Dias = new System.Collections.Generic.List<ConsultarDiasSemanaDiaDTO>(),
                Status = ExecutionStatus.Success
            };
            new SistemaHorariosEntities()
                .DiasSemana
                .ToList()
                .ForEach(
                dia => 
                    response.Dias.Add(new ConsultarDiasSemanaDiaDTO()
                    {
                        CodigoDia = dia.CodigoDia,
                        Nome = UppercaseWords(dia.NomeDia)
                    }));
            return response;
        }
    }
}
