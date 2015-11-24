using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarHorarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarHorariosModel : BaseModel<CadastrarHorariosRequest, CadastrarHorariosResponse>
    {
        protected override Func<CadastrarHorariosRequest, CadastrarHorariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarHorariosRequest, CadastrarHorariosResponse>(service.CadastrarHorarios);
        }
    }
}