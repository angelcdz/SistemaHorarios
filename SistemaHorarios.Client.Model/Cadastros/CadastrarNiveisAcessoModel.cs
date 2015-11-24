using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarNiveisAcesso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarNiveisAcessoModel : BaseModel<CadastrarNiveisAcessoRequest, CadastrarNiveisAcessoResponse>
    {
        protected override Func<CadastrarNiveisAcessoRequest, CadastrarNiveisAcessoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarNiveisAcessoRequest, CadastrarNiveisAcessoResponse>(service.CadastrarNiveisAcesso);
        }
    }
}