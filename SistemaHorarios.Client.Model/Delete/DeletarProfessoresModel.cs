using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarProfessores;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarProfessoresModel : BaseModel<DeletarProfessoresRequest, DeletarProfessoresResponse>
    {
        protected override Func<DeletarProfessoresRequest, DeletarProfessoresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarProfessoresRequest, DeletarProfessoresResponse>(service.DeletarProfessores);
        }
    }
}