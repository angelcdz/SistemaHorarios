using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarNiveisAcessoModel : BaseModel<ConsultarNiveisAcessoRequest, ConsultarNiveisAcessoResponse>
    {
        protected override Func<ConsultarNiveisAcessoRequest, ConsultarNiveisAcessoResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarNiveisAcessoRequest, ConsultarNiveisAcessoResponse>(service.ConsultarNiveisAcesso);
        }
    }
}