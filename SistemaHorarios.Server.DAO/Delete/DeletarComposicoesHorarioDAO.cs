using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarComposicoesHorario;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class DeletarComposicoesHorarioDAO : BaseDAO<DeletarComposicoesHorarioRequest, DeletarComposicoesHorarioResponse>
    {
        protected override DeletarComposicoesHorarioResponse GetData(DeletarComposicoesHorarioRequest request)
        {
            new SistemaHorariosEntities().ComposicoesHorario.Remove(new ComposicaoHorario() { CodigoComposicaoHorario = request.Codigo });
            return new DeletarComposicoesHorarioResponse() { Status = ExecutionStatus.Success };
        }
    }
}