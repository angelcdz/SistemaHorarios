using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using SistemaHorarios.Contracts.ConsultarUsuariosNiveis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarUsuariosNiveisDAO : BaseDAO<ConsultarUsuariosNiveisRequest, ConsultarUsuariosNiveisResponse>
    {
        protected override ConsultarUsuariosNiveisResponse GetData(ConsultarUsuariosNiveisRequest request)
        {
            var response = new ConsultarUsuariosNiveisResponse()
            {
                Niveis = new List<Contracts.ConsultarNiveisAcesso.ConsultarNiveisAcessoDTO>(),
                Usuarios = new List<Contracts.ConsultarUsuarios.ConsultarUsuariosUsuarioDTO>(),
                Status = ExecutionStatus.Success
            };

            using (var context = new SistemaHorariosEntities())
            {
                context
                    .NiveisAcesso
                    .ToList()
                    .ForEach(nivel =>
                    response.Niveis.Add(new ConsultarNiveisAcessoDTO()
                    {
                        Codigo = nivel.CodigoNivel,
                        Nome = UppercaseWords(nivel.Descricao),
                        Administrador = nivel.Administrador,
                        Consultas = nivel.Consulta,
                        Operacoes = nivel.Cadastro
                    }));

                context
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
            }

            return response;
        }
    }
}