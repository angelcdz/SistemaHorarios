using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarComposicoesHorario;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarComposicoesHorarioModel : BaseModel<CadastrarComposicoesHorarioRequest, CadastrarComposicoesHorarioResponse>
    {
        protected override Func<CadastrarComposicoesHorarioRequest, CadastrarComposicoesHorarioResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarComposicoesHorarioRequest, CadastrarComposicoesHorarioResponse>(service.CadastrarComposicoesHorario);
        }
    }
}