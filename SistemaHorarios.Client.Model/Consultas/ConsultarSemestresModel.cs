using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarSemestres;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarSemestresModel : BaseModel<ConsultarSemestresRequest, ConsultarSemestresResponse>
    {
        protected override Func<ConsultarSemestresRequest, ConsultarSemestresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarSemestresRequest, ConsultarSemestresResponse>(service.ConsultarSemestres);
        }
    }
}