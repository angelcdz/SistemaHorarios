using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursoParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarCursoParamBL : BaseBL<ConsultarCursoParamRequest, ConsultarCursoParamResponse>
    {
        public override ConsultarCursoParamResponse Execute(ConsultarCursoParamRequest request)
        {
            return new ConsultarCursoParamDAO().Execute(request);
        }
    }
}