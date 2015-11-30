using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarGrade;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarGradeModel : BaseModel<CadastrarGradeRequest, CadastrarGradeResponse>
    {
        protected override Func<CadastrarGradeRequest, CadastrarGradeResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarGradeRequest, CadastrarGradeResponse>(service.CadastrarGrade);
        }
    }
}