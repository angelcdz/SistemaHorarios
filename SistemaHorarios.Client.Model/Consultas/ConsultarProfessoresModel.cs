using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarProfessores;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarProfessoresModel : BaseModel<ConsultarProfessoresRequest, ConsultarProfessoresResponse>
    {
        protected override Func<ConsultarProfessoresRequest, ConsultarProfessoresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarProfessoresRequest, ConsultarProfessoresResponse>(service.ConsultarProfessores);
        }
    }
}