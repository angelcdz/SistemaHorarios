using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarHorarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarHorariosModel : BaseModel<AtualizarHorariosRequest, AtualizarHorariosResponse>
    {
        protected override Func<AtualizarHorariosRequest, AtualizarHorariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarHorariosRequest, AtualizarHorariosResponse>(service.AtualizarHorarios);
        }
    }
}