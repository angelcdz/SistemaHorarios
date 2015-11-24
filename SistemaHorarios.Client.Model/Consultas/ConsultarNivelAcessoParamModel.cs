using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarNivelAcessoParam;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarNivelAcessoParamModel : BaseModel<ConsultarNivelAcessoParamRequest, ConsultarNivelAcessoParamResponse>
    {
        protected override Func<ConsultarNivelAcessoParamRequest, ConsultarNivelAcessoParamResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarNivelAcessoParamRequest, ConsultarNivelAcessoParamResponse>(service.ConsultarNivelAcessoParam);
        }
    }
}