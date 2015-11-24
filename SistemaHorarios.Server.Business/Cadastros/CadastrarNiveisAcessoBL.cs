using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarNiveisAcesso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarNiveisAcessoBL : BaseBL<CadastrarNiveisAcessoRequest, CadastrarNiveisAcessoResponse>
    {
        public override CadastrarNiveisAcessoResponse Execute(CadastrarNiveisAcessoRequest request)
        {
            return new CadastrarNiveisAcessoDAO().Execute(request);
        }
    }
}