using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarHorarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarHorariosModel : BaseModel<ConsultarHorariosRequest, ConsultarHorariosResponse>
    {
        protected override Func<ConsultarHorariosRequest, ConsultarHorariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarHorariosRequest, ConsultarHorariosResponse>(service.ConsultarHorarios);
        }
    }
}