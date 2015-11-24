using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarComposicoesHorario;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarComposicoesHorarioModel : BaseModel<DeletarComposicoesHorarioRequest, DeletarComposicoesHorarioResponse>
    {
        protected override Func<DeletarComposicoesHorarioRequest, DeletarComposicoesHorarioResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarComposicoesHorarioRequest, DeletarComposicoesHorarioResponse>(service.DeletarComposicoesHorario);
        }
    }
}