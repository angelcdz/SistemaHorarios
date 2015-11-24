using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasHorarios;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarHorarios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarDiasHorariosDAO : BaseDAO<ConsultarDiasHorariosRequest, ConsultarDiasHorariosResponse>
    {
        protected override ConsultarDiasHorariosResponse GetData(ConsultarDiasHorariosRequest request)
        {
            var response = new ConsultarDiasHorariosResponse()
            {
                Dias = new List<ConsultarDiasSemanaDiaDTO>(),
                Horarios = new List<ConsultarHorariosHorarioDTO>(),
                Status = ExecutionStatus.Success
            };

            using (var context = new SistemaHorariosEntities())
            {
                context
                    .DiasSemana
                    .ToList()
                    .ForEach(
                    dia =>
                        response.Dias.Add(new ConsultarDiasSemanaDiaDTO()
                        {
                            CodigoDia = dia.CodigoDia,
                            Nome = UppercaseWords(dia.NomeDia)
                        }));

                context.Horarios
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
            }

            return response;
        }
    }
}