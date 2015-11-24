using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarSemestres;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarSemestresBL : BaseBL<DeletarSemestresRequest, DeletarSemestresResponse>
    {
        public override DeletarSemestresResponse Execute(DeletarSemestresRequest request)
        {
            return new DeletarSemestresDAO().Execute(request);
        }
    }
}