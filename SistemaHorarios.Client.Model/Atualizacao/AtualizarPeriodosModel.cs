using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarPeriodos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarPeriodosModel : BaseModel<AtualizarPeriodosRequest, AtualizarPeriodosResponse>
    {
        protected override Func<AtualizarPeriodosRequest, AtualizarPeriodosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarPeriodosRequest, AtualizarPeriodosResponse>(service.AtualizarPeriodos);
        }
    }
}