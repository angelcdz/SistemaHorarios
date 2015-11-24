using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNivelAcessoParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarNivelAcessoParamBL : BaseBL<ConsultarNivelAcessoParamRequest, ConsultarNivelAcessoParamResponse>
    {
        public override ConsultarNivelAcessoParamResponse Execute(ConsultarNivelAcessoParamRequest request)
        {
            return new ConsultarNivelAcessoParamDAO().Execute(request);
        }
    }
}