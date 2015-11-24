using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarComposicoesHorario;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarComposicoesHorarioDAO : BaseDAO<CadastrarComposicoesHorarioRequest, CadastrarComposicoesHorarioResponse>
    {
        protected override CadastrarComposicoesHorarioResponse GetData(CadastrarComposicoesHorarioRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                var composicao = context.ComposicoesCurso.Where(x => x.CodigoComposicaoCurso == request.CodigoComposicaoCurso).FirstOrDefault();
                var horario = context.Horarios.Where(x => x.CodigoHorario == request.CodigoHorario).FirstOrDefault();

                if (composicao == null || horario == null)
                    return new CadastrarComposicoesHorarioResponse() { Status = ExecutionStatus.BusinessError };

                context.ComposicoesHorario.Add(new ComposicaoHorario()
                {
                    ComposicaoCurso = composicao,
                    Horario = horario
                });

                context.SaveChanges();

                return new CadastrarComposicoesHorarioResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}