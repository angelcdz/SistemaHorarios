using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarNiveisAcessoDAO : BaseDAO<ConsultarNiveisAcessoRequest, ConsultarNiveisAcessoResponse>
    {
        protected override ConsultarNiveisAcessoResponse GetData(ConsultarNiveisAcessoRequest request)
        {
            var response = new ConsultarNiveisAcessoResponse()
            {
                Niveis = new System.Collections.Generic.List<ConsultarNiveisAcessoDTO>(),
                Status = ExecutionStatus.Success
            };

            new SistemaHorariosEntities().NiveisAcesso.ToList().ForEach(nivel =>
                response.Niveis.Add(new ConsultarNiveisAcessoDTO()
                {
                    Codigo = nivel.CodigoNivel,
                    Nome = UppercaseWords(nivel.Descricao),
                    Administrador = nivel.Administrador,
                    Consultas = nivel.Consulta,
                    Operacoes = nivel.Cadastro
                }));

            return response;
        }
    }
}