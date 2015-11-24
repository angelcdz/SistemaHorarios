using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarNiveisAcesso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarNiveisAcessoBL : BaseBL<AtualizarNiveisAcessoRequest, AtualizarNiveisAcessoResponse>
    {
        public override AtualizarNiveisAcessoResponse Execute(AtualizarNiveisAcessoRequest request)
        {
            return new AtualizarNiveisAcessoDAO().Execute(request);
        }
    }
}