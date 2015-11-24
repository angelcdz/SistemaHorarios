using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarComposicoesHorario;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarComposicoesHorarioBL : BaseBL<ConsultarComposicoesHorarioRequest, ConsultarComposicoesHorarioResponse>
    {
        public override ConsultarComposicoesHorarioResponse Execute(ConsultarComposicoesHorarioRequest request)
        {
            return new ConsultarComposicoesHorarioDAO().Execute(request);
        }
    }
}