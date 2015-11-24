using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarUsuariosBL : BaseBL<ConsultarUsuariosRequest, ConsultarUsuariosResponse>
    {
        public override ConsultarUsuariosResponse Execute(ConsultarUsuariosRequest request)
        {
            return new ConsultarUsuariosDAO().Execute(request);
        }
    }
}
