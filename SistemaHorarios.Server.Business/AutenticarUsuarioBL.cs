using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AutenticarUsuario;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AutenticarUsuarioBL : BaseBL<AutenticarUsuarioRequest, AutenticarUsuarioResponse>
    {
        public override AutenticarUsuarioResponse Execute(AutenticarUsuarioRequest request)
        {
            return new AutenticarUsuarioDAO().Execute(request);
        }
    }
}