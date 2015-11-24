using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarUsuarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarUsuariosBL : BaseBL<AtualizarUsuariosRequest, AtualizarUsuariosResponse>
    {
        public override AtualizarUsuariosResponse Execute(AtualizarUsuariosRequest request)
        {
            return new AtualizarUsuariosDAO().Execute(request);
        }
    }
}