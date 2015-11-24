using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarUsuariosDAO : BaseDAO<ConsultarUsuariosRequest, ConsultarUsuariosResponse>
    {
        protected override ConsultarUsuariosResponse GetData(ConsultarUsuariosRequest request)
        {
            var response = new ConsultarUsuariosResponse(){ Usuarios = new List<ConsultarUsuariosUsuarioDTO>(), Status = ExecutionStatus.Success };

            new SistemaHorariosEntities()
                .Usuarios
                .ToList()
                .ForEach(usuario =>
                    response.Usuarios.Add(new ConsultarUsuariosUsuarioDTO()
                                          {
                                              Codigo = usuario.CodigoUsuario,
                                              Login = usuario.Login.ToLower(),
                                              NivelAcesso = usuario.NivelAcesso == null ?
                                                            null :
                                                            new ConsultarUsuariosNivelAcessoDTO()
                                                            {
                                                                Administrador = usuario.NivelAcesso.Administrador,
                                                                Cadastro = usuario.NivelAcesso.Cadastro,
                                                                Codigo = usuario.NivelAcesso.CodigoNivel,
                                                                Consulta = usuario.NivelAcesso.Consulta,
                                                                Descricao = UppercaseWords(usuario.NivelAcesso.Descricao)
                                                            },
                                              UltimoLogin = usuario.UltimoLogin
                                          })
                );

            return response;
        }
    }
}
