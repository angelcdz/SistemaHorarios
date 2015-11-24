using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarUsuarios;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarUsuariosDAO : BaseDAO<CadastrarUsuariosRequest, CadastrarUsuariosResponse>
    {
        protected override CadastrarUsuariosResponse GetData(CadastrarUsuariosRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                var nivel = context.NiveisAcesso.Where(x => x.CodigoNivel == request.CodigoNivelAcesso).First();

                if (nivel == null)
                    return new CadastrarUsuariosResponse() { Status = ExecutionStatus.BusinessError };

                context.Usuarios.Add(new Usuario()
                {
                    Login = request.Login, Senha = request.Senha, NivelAcesso = nivel
                });

                context.SaveChanges();

                return new CadastrarUsuariosResponse() { Status = ExecutionStatus.Success };
            }
            
        }
    }
}