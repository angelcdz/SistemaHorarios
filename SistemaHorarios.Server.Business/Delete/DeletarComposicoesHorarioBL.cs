using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarComposicoesHorario;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarComposicoesHorarioBL : BaseBL<DeletarComposicoesHorarioRequest, DeletarComposicoesHorarioResponse>
    {
        public override DeletarComposicoesHorarioResponse Execute(DeletarComposicoesHorarioRequest request)
        {
            return new DeletarComposicoesHorarioDAO().Execute(request);
        }
    }
}