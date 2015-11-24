using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarHorarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarHorariosModel : BaseModel<DeletarHorariosRequest, DeletarHorariosResponse>
    {
        protected override Func<DeletarHorariosRequest, DeletarHorariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarHorariosRequest, DeletarHorariosResponse>(service.DeletarHorarios);
        }
    }
}