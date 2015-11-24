using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarDiasHorarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarDiasHorariosModel : BaseModel<ConsultarDiasHorariosRequest, ConsultarDiasHorariosResponse>
    {
        protected override Func<ConsultarDiasHorariosRequest, ConsultarDiasHorariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarDiasHorariosRequest, ConsultarDiasHorariosResponse>(service.ConsultarDiasHorarios);
        }
    }
}