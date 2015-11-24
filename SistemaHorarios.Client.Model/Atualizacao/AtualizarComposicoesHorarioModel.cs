using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarComposicoesHorario;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarComposicoesHorarioModel : BaseModel<AtualizarComposicoesHorarioRequest, AtualizarComposicoesHorarioResponse>
    {
        protected override Func<AtualizarComposicoesHorarioRequest, AtualizarComposicoesHorarioResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarComposicoesHorarioRequest, AtualizarComposicoesHorarioResponse>(service.AtualizarComposicoesHorario);
        }
    }
}