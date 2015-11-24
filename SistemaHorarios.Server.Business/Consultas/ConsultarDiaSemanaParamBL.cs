using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiaSemanaParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarDiaSemanaParamBL : BaseBL<ConsultarDiaSemanaParamRequest, ConsultarDiaSemanaParamResponse>
    {
        public override ConsultarDiaSemanaParamResponse Execute(ConsultarDiaSemanaParamRequest request)
        {
            return new ConsultarDiaSemanaParamDAO().Execute(request);
        }
    }
}