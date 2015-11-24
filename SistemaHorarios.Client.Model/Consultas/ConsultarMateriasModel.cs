using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarMaterias;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarMateriasModel : BaseModel<ConsultarMateriasRequest, ConsultarMateriasResponse>
    {
        protected override Func<ConsultarMateriasRequest, ConsultarMateriasResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarMateriasRequest, ConsultarMateriasResponse>(service.ConsultarMaterias);
        }
    }
}