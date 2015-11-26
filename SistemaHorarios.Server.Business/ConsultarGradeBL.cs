using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarGrade;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarGradeBL : BaseBL<ConsultarGradeRequest, ConsultarGradeResponse>
    {
        public override ConsultarGradeResponse Execute(ConsultarGradeRequest request)
        {
            return new ConsultarGradeDAO().Execute(request);
        }
    }
}