using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNivelAcessoParam;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarNivelAcessoParamDAO : BaseDAO<ConsultarNivelAcessoParamRequest, ConsultarNivelAcessoParamResponse>
    {
        protected override ConsultarNivelAcessoParamResponse GetData(ConsultarNivelAcessoParamRequest request)
        {
            var response = new ConsultarNivelAcessoParamResponse() { Status = ExecutionStatus.Success };
            var lista = new List<ConsultarNiveisAcessoDTO>();

            using (var context = new SistemaHorariosEntities())
            {
                foreach (var item in context.NiveisAcesso)
                    lista.Add(new ConsultarNiveisAcessoDTO()
                    {
                        Codigo = item.CodigoNivel,
                        Nome = UppercaseWords(item.Descricao),
                        Administrador = item.Administrador,
                        Consultas = item.Consulta,
                        Operacoes = item.Cadastro
                    });
            }

            if (request.Codigo != 0)
                lista = lista.Where(niv => niv.Codigo == request.Codigo).ToList();
            else
            {
                if (!string.IsNullOrEmpty(request.Nome))
                    lista = lista.Where(niv => niv.Nome == request.Nome).ToList();

                lista = lista.Where(niv => niv.Administrador == request.Administrador.Value
                                        && niv.Consultas == request.Consultas.Value
                                        && niv.Operacoes == request.Operacoes.Value).ToList();
            }

            response.Niveis = lista;
            return response;
        }
    }
}