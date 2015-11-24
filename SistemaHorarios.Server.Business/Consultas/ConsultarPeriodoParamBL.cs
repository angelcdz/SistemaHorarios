using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodoParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarPeriodoParamBL : BaseBL<ConsultarPeriodoParamRequest, ConsultarPeriodoParamResponse>
    {
        public override ConsultarPeriodoParamResponse Execute(ConsultarPeriodoParamRequest request)
        {
            return new ConsultarPeriodoParamDAO().Execute(request);
        }
    }
}