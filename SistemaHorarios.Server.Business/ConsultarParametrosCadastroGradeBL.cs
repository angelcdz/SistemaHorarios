using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarParametrosCadastroGrade;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarParametrosCadastroGradeBL : BaseBL<ConsultarParametrosCadastroGradeRequest, ConsultarParametrosCadastroGradeResponse>
    {
        public override ConsultarParametrosCadastroGradeResponse Execute(ConsultarParametrosCadastroGradeRequest request)
        {
            return new ConsultarParametrosCadastroGradeDAO().Execute(request);
        }
    }
}