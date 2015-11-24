using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarComposicoesHorario;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarComposicoesHorarioBL : BaseBL<AtualizarComposicoesHorarioRequest, AtualizarComposicoesHorarioResponse>
    {
        public override AtualizarComposicoesHorarioResponse Execute(AtualizarComposicoesHorarioRequest request)
        {
            return new AtualizarComposicoesHorarioDAO().Execute(request);
        }
    }
}