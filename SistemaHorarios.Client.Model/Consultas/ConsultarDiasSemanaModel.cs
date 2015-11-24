using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarDiasSemanaModel : BaseModel<ConsultarDiasSemanaRequest, ConsultarDiasSemanaResponse>
    {
        protected override Func<ConsultarDiasSemanaRequest, ConsultarDiasSemanaResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarDiasSemanaRequest, ConsultarDiasSemanaResponse>(service.ConsultarDiasSemana);
        }
    }
}