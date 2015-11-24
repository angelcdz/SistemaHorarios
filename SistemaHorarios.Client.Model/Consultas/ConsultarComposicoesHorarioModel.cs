using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarComposicoesHorario;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarComposicoesHorarioModel : BaseModel<ConsultarComposicoesHorarioRequest, ConsultarComposicoesHorarioResponse>
    {
        protected override Func<ConsultarComposicoesHorarioRequest, ConsultarComposicoesHorarioResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarComposicoesHorarioRequest, ConsultarComposicoesHorarioResponse>(service.ConsultarComposicoesHorario);
        }
    }
}