using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarMaterias;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarMateriasModel : BaseModel<AtualizarMateriasRequest, AtualizarMateriasResponse>
    {
        protected override Func<AtualizarMateriasRequest, AtualizarMateriasResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarMateriasRequest, AtualizarMateriasResponse>(service.AtualizarMaterias);
        }
    }
}