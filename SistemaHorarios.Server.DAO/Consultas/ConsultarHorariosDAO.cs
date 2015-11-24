using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarHorarios;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarHorariosDAO : BaseDAO<ConsultarHorariosRequest, ConsultarHorariosResponse>
    {
        protected override ConsultarHorariosResponse GetData(ConsultarHorariosRequest request)
        {
            var response = new ConsultarHorariosResponse()
            {
                Horarios = new System.Collections.Generic.List<ConsultarHorariosHorarioDTO>(),
                Status = ExecutionStatus.Success
            };
            new SistemaHorariosEntities()
                .Horarios
                .ToList()
                .ForEach(
                horario =>
                    response.Horarios.Add(new ConsultarHorariosHorarioDTO()
                    {
                        Codigo = horario.CodigoHorario,
                        HoraFinal = horario.HoraFinal,
                        HoraInicial = horario.HoraInicial,
                        DiaSemana = horario.DiaSemana == null ? null :
                                    new ConsultarHorariosDiaDTO()
                                    {
                                        Codigo = horario.DiaSemana.CodigoDia,
                                        Nome = UppercaseWords(horario.DiaSemana.NomeDia)
                                    }
                    }));
            return response;
        }
    }
}
