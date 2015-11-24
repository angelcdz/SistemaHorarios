using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarProfessores;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarProfessoresModel : BaseModel<CadastrarProfessoresRequest, CadastrarProfessoresResponse>
    {
        protected override Func<CadastrarProfessoresRequest, CadastrarProfessoresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarProfessoresRequest, CadastrarProfessoresResponse>(service.CadastrarProfessores);
        }
    }
}