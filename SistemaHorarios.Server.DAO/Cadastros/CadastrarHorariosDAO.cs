using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarHorarios;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarHorariosDAO : BaseDAO<CadastrarHorariosRequest, CadastrarHorariosResponse>
    {
        protected override CadastrarHorariosResponse GetData(CadastrarHorariosRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                var dia = context.DiasSemana.Where(x => x.CodigoDia == request.CodigoDiaSemana).FirstOrDefault();
                var periodo = context.Periodos.Where(x => x.CodigoPeriodo == request.CodigoPeriodo).FirstOrDefault();

                if (dia == null || periodo == null)
                    return new CadastrarHorariosResponse() { Status = ExecutionStatus.BusinessError };

                context.Horarios.Add(new Horario()
                {
                    DiaSemana = dia,
                    HoraFinal = request.HoraFinal,
                    HoraInicial = request.HoraInicial,
                    Periodo = periodo
                });

                context.SaveChanges();

                return new CadastrarHorariosResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}