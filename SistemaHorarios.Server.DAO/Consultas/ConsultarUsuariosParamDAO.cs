using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using SistemaHorarios.Contracts.ConsultarUsuariosParam;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarUsuariosParamDAO : BaseDAO<ConsultarUsuariosParamRequest, ConsultarUsuariosParamResponse>
    {
        protected override ConsultarUsuariosParamResponse GetData(ConsultarUsuariosParamRequest request)
        {
            var response = new ConsultarUsuariosParamResponse() { Status = ExecutionStatus.Success };
            var lista = new List<ConsultarUsuariosUsuarioDTO>();

            using (var context = new SistemaHorariosEntities())
            {
                foreach (var item in context.Usuarios)
                    lista.Add(new ConsultarUsuariosUsuarioDTO()
                    {
                        Codigo = item.CodigoUsuario,
                        Login = item.Login,
                        NivelAcesso = new ConsultarUsuariosNivelAcessoDTO()
                        {
                            Administrador = item.NivelAcesso.Administrador,
                            Cadastro = item.NivelAcesso.Cadastro,
                            Codigo = item.NivelAcesso.CodigoNivel,
                            Consulta = item.NivelAcesso.Consulta,
                            Descricao = UppercaseWords(item.NivelAcesso.Descricao)
                        },
                        UltimoLogin = item.UltimoLogin
                    });
            }

            if (request.Codigo != 0)
                lista = lista.Where(usu => usu.Codigo == request.Codigo).ToList();
            else
            {
                if (!string.IsNullOrEmpty(request.Login))
                    lista = lista.Where(usu => usu.Login.Contains(request.Login)).ToList();

                if (request.CodigoNivel != 0)
                    lista = lista.Where(usu => usu.NivelAcesso.Codigo == request.CodigoNivel).ToList();
            }

            response.Usuarios = lista;
            return response;
        }
    }
}