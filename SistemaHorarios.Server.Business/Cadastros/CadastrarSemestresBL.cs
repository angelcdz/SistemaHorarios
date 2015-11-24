using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarSemestres;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarSemestresBL : BaseBL<CadastrarSemestresRequest, CadastrarSemestresResponse>
    {
        public override CadastrarSemestresResponse Execute(CadastrarSemestresRequest request)
        {
            return new CadastrarSemestresDAO().Execute(request);
        }
    }
}