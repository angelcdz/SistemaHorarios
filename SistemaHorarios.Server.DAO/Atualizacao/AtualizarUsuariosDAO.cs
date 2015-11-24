using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarUsuarios;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarUsuariosDAO : BaseDAO<AtualizarUsuariosRequest, AtualizarUsuariosResponse>
    {
        protected override AtualizarUsuariosResponse GetData(AtualizarUsuariosRequest request)
        {
            throw new NotImplementedException();
        }
    }
}