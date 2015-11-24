using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarUsuarios;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarUsuariosDAO : BaseDAO<DeletarUsuariosRequest, DeletarUsuariosResponse>
    {
        protected override DeletarUsuariosResponse GetData(DeletarUsuariosRequest request)
        {
            new SistemaHorariosEntities().Usuarios.Remove(new Usuario() { CodigoUsuario = request.Codigo });
            return new DeletarUsuariosResponse() { Status = ExecutionStatus.Success };
        }
    }
}