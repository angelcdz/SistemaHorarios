using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarProfessorParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarProfessorParamBL : BaseBL<ConsultarProfessorParamRequest, ConsultarProfessorParamResponse>
    {
        public override ConsultarProfessorParamResponse Execute(ConsultarProfessorParamRequest request)
        {
            return new ConsultarProfessorParamDAO().Execute(request);
        }
    }
}