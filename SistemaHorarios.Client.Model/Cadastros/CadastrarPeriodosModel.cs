using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarPeriodos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarPeriodosModel : BaseModel<CadastrarPeriodosRequest, CadastrarPeriodosResponse>
    {
        protected override Func<CadastrarPeriodosRequest, CadastrarPeriodosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarPeriodosRequest, CadastrarPeriodosResponse>(service.CadastrarPeriodos);
        }
    }
}