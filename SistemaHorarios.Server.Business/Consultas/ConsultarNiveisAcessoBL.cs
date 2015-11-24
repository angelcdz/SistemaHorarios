using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarNiveisAcessoBL : BaseBL<ConsultarNiveisAcessoRequest, ConsultarNiveisAcessoResponse>
    {
        public override ConsultarNiveisAcessoResponse Execute(ConsultarNiveisAcessoRequest request)
        {
            return new ConsultarNiveisAcessoDAO().Execute(request);
        }
    }
}