using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AutenticarUsuario;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AutenticarUsuarioDAO : BaseDAO<AutenticarUsuarioRequest, AutenticarUsuarioResponse>
    {
        protected override AutenticarUsuarioResponse GetData(AutenticarUsuarioRequest request)
        {
            var response = new AutenticarUsuarioResponse()
            {
                Status = ExecutionStatus.Success,
                Autenticado = true,
                Existe = true
            };

            using (var context = new SistemaHorariosEntities())
            {
                var usuario = context.Usuarios.FirstOrDefault(usu=>usu.Login == request.Login);

                if (usuario == null)
                    response.Existe = false;
                else if (!string.Equals(usuario.Senha, request.Senha))
                    response.Autenticado = false;
                else
                {
                    response.NivelAcesso = new AutenticarUsuarioNivelAcessoDTO()
                    {
                        Administrador = usuario.NivelAcesso.Administrador.HasValue ? usuario.NivelAcesso.Administrador.Value : false,
                        Cadastro = usuario.NivelAcesso.Cadastro.HasValue ? usuario.NivelAcesso.Cadastro.Value : false,
                        Consulta = usuario.NivelAcesso.Consulta.HasValue ? usuario.NivelAcesso.Consulta.Value : false,
                        Nome = usuario.NivelAcesso.Descricao
                    };

                    usuario.UltimoLogin = DateTime.Now;
                    context.SaveChanges();
                }
            }

            return response;
        }
    }
}