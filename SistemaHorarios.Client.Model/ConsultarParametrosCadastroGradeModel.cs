using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarParametrosCadastroGrade;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarParametrosCadastroGradeModel : BaseModel<ConsultarParametrosCadastroGradeRequest, ConsultarParametrosCadastroGradeResponse>
    {
        protected override Func<ConsultarParametrosCadastroGradeRequest, ConsultarParametrosCadastroGradeResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarParametrosCadastroGradeRequest, ConsultarParametrosCadastroGradeResponse>(service.ConsultarParametrosCadastroGrade);
        }
    }
}