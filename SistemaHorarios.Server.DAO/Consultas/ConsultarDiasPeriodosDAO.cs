using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasPeriodos;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarDiasPeriodosDAO : BaseDAO<ConsultarDiasPeriodosRequest, ConsultarDiasPeriodosResponse>
    {
        protected override ConsultarDiasPeriodosResponse GetData(ConsultarDiasPeriodosRequest request)
        {
            var response = new ConsultarDiasPeriodosResponse()
            {
                Dias = new List<ConsultarDiasSemanaDiaDTO>(),
                Periodos = new List<ConsultarPeriodosPeriodoDTO>(),
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

                context.Periodos.ToList().ForEach(periodo =>
                    response.Periodos.Add(new ConsultarPeriodosPeriodoDTO()
                    {
                        Codigo = periodo.CodigoPeriodo,
                        Nome = UppercaseWords(periodo.NomePeriodo)
                    }));
            }
            
            return response;
        }
    }
}