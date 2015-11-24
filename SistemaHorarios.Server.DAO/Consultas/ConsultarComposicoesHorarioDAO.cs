using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarComposicoesHorario;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarComposicoesHorarioDAO : BaseDAO<ConsultarComposicoesHorarioRequest, ConsultarComposicoesHorarioResponse>
    {
        protected override ConsultarComposicoesHorarioResponse GetData(ConsultarComposicoesHorarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}