using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarPeriodosModel : BaseModel<ConsultarPeriodosRequest, ConsultarPeriodosResponse>
    {
        protected override Func<ConsultarPeriodosRequest, ConsultarPeriodosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarPeriodosRequest, ConsultarPeriodosResponse>(service.ConsultarPeriodos);
        }
    }
}