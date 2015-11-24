using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarNiveisAcesso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarNiveisAcessoBL : BaseBL<DeletarNiveisAcessoRequest, DeletarNiveisAcessoResponse>
    {
        public override DeletarNiveisAcessoResponse Execute(DeletarNiveisAcessoRequest request)
        {
            return new DeletarNiveisAcessoDAO().Execute(request);
        }
    }
}