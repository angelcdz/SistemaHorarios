using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarHorarioParam;
using SistemaHorarios.Contracts.ConsultarHorarios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarHorarioParamDAO : BaseDAO<ConsultarHorarioParamRequest, ConsultarHorarioParamResponse>
    {
        protected override ConsultarHorarioParamResponse GetData(ConsultarHorarioParamRequest request)
        {
            var response = new ConsultarHorarioParamResponse() { Status = ExecutionStatus.Success };
            var lista = new List<ConsultarHorariosHorarioDTO>();

            using (var context = new SistemaHorariosEntities())
            {
                foreach (var item in context.Horarios)
                    lista.Add(new ConsultarHorariosHorarioDTO()
                    {
                        Codigo = item.CodigoHorario,
                        HoraFinal = item.HoraFinal,
                        HoraInicial = item.HoraInicial,
                        DiaSemana = new ConsultarHorariosDiaDTO()
                        {
                            Codigo = item.DiaSemana.CodigoDia,
                            Nome = UppercaseWords(item.DiaSemana.NomeDia)
                        }
                    });

                if (request.Codigo != 0)
                    lista = lista.Where(hor => hor.Codigo == request.Codigo).ToList();
                else
                {
                    if (request.Final != TimeSpan.Zero)
                        lista = lista.Where(hor => hor.HoraFinal == request.Final).ToList();
                    if (request.Inicial != TimeSpan.Zero)
                        lista = lista.Where(hor => hor.HoraInicial == request.Inicial).ToList();
                    if (request.CodigoDia != 0)
                        lista = lista.Where(hor => hor.DiaSemana.Codigo == request.CodigoDia).ToList();
                }    
            }

            response.Horarios = lista;
            return response;
        }
    }
}