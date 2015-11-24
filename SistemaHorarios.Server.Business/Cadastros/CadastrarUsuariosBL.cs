using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarUsuarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarUsuariosBL : BaseBL<CadastrarUsuariosRequest, CadastrarUsuariosResponse>
    {
        public override CadastrarUsuariosResponse Execute(CadastrarUsuariosRequest request)
        {
            return new CadastrarUsuariosDAO().Execute(request);
        }
    }
}