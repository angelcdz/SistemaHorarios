using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarUsuarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarUsuariosBL : BaseBL<DeletarUsuariosRequest, DeletarUsuariosResponse>
    {
        public override DeletarUsuariosResponse Execute(DeletarUsuariosRequest request)
        {
            return new DeletarUsuariosDAO().Execute(request);
        }
    }
}