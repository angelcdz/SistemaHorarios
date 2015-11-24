using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarUsuariosParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarUsuariosParamBL : BaseBL<ConsultarUsuariosParamRequest, ConsultarUsuariosParamResponse>
    {
        public override ConsultarUsuariosParamResponse Execute(ConsultarUsuariosParamRequest request)
        {
            return new ConsultarUsuariosParamDAO().Execute(request);
        }
    }
}