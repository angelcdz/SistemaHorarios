using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarNiveisAcesso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarNiveisAcessoModel : BaseModel<DeletarNiveisAcessoRequest, DeletarNiveisAcessoResponse>
    {
        protected override Func<DeletarNiveisAcessoRequest, DeletarNiveisAcessoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarNiveisAcessoRequest, DeletarNiveisAcessoResponse>(service.DeletarNiveisAcesso);
        }
    }
}