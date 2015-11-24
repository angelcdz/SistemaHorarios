using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarMateriaParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarMateriaParamModel : BaseModel<ConsultarMateriaParamRequest, ConsultarMateriaParamResponse>
    {
        protected override Func<ConsultarMateriaParamRequest, ConsultarMateriaParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarMateriaParamRequest, ConsultarMateriaParamResponse>(service.ConsultarMateriaParam);
        }
    }
}