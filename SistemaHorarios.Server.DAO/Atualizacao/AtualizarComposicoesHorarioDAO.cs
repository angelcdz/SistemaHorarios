using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarComposicoesHorario;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarComposicoesHorarioDAO : BaseDAO<AtualizarComposicoesHorarioRequest, AtualizarComposicoesHorarioResponse>
    {
        protected override AtualizarComposicoesHorarioResponse GetData(AtualizarComposicoesHorarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}