using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarNiveisAcesso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarNiveisAcessoModel : BaseModel<AtualizarNiveisAcessoRequest, AtualizarNiveisAcessoResponse>
    {
        protected override Func<AtualizarNiveisAcessoRequest, AtualizarNiveisAcessoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarNiveisAcessoRequest, AtualizarNiveisAcessoResponse>(service.AtualizarNiveisAcesso);
        }
    }
}