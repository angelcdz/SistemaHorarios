using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarNiveisAcesso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarNiveisAcessoDAO : BaseDAO<AtualizarNiveisAcessoRequest, AtualizarNiveisAcessoResponse>
    {
        protected override AtualizarNiveisAcessoResponse GetData(AtualizarNiveisAcessoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}