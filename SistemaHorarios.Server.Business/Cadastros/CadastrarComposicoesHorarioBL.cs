using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarComposicoesHorario;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarComposicoesHorarioBL : BaseBL<CadastrarComposicoesHorarioRequest, CadastrarComposicoesHorarioResponse>
    {
        public override CadastrarComposicoesHorarioResponse Execute(CadastrarComposicoesHorarioRequest request)
        {
            return new CadastrarComposicoesHorarioDAO().Execute(request);
        }
    }
}