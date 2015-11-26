using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarGrade;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarGradeModel : BaseModel<ConsultarGradeRequest, ConsultarGradeResponse>
    {
        protected override Func<ConsultarGradeRequest, ConsultarGradeResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarGradeRequest, ConsultarGradeResponse>(service.ConsultarGrade);
        }
    }
}