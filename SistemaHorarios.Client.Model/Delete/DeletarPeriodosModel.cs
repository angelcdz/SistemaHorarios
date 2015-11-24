using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarPeriodos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarPeriodosModel : BaseModel<DeletarPeriodosRequest, DeletarPeriodosResponse>
    {
        protected override Func<DeletarPeriodosRequest, DeletarPeriodosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarPeriodosRequest, DeletarPeriodosResponse>(service.DeletarPeriodos);
        }
    }
}