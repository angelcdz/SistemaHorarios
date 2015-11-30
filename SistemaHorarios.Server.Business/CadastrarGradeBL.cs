using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarGrade;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarGradeBL : BaseBL<CadastrarGradeRequest, CadastrarGradeResponse>
    {
        public override CadastrarGradeResponse Execute(CadastrarGradeRequest request)
        {
            return new CadastrarGradeDAO().Execute(request);
        }
    }
}