using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarSemestres;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarSemestresBL : BaseBL<AtualizarSemestresRequest, AtualizarSemestresResponse>
    {
        public override AtualizarSemestresResponse Execute(AtualizarSemestresRequest request)
        {
            return new AtualizarSemestresDAO().Execute(request);
        }
    }
}