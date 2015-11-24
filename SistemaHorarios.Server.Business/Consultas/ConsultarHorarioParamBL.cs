using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarHorarioParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarHorarioParamBL : BaseBL<ConsultarHorarioParamRequest, ConsultarHorarioParamResponse>
    {
        public override ConsultarHorarioParamResponse Execute(ConsultarHorarioParamRequest request)
        {
            return new ConsultarHorarioParamDAO().Execute(request);
        }
    }
}