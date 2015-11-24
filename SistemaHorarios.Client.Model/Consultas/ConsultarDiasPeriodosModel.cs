using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarDiasPeriodos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarDiasPeriodosModel : BaseModel<ConsultarDiasPeriodosRequest, ConsultarDiasPeriodosResponse>
    {
        protected override Func<ConsultarDiasPeriodosRequest, ConsultarDiasPeriodosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarDiasPeriodosRequest, ConsultarDiasPeriodosResponse>(service.ConsultarDiasPeriodos);
        }
    }
}