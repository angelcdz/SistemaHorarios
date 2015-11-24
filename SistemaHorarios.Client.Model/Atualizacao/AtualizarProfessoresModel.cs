using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarProfessores;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarProfessoresModel : BaseModel<AtualizarProfessoresRequest, AtualizarProfessoresResponse>
    {
        protected override Func<AtualizarProfessoresRequest, AtualizarProfessoresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarProfessoresRequest, AtualizarProfessoresResponse>(service.AtualizarProfessores);
        }
    }
}