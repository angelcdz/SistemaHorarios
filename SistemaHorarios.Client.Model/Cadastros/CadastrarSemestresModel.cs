using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarSemestres;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarSemestresModel : BaseModel<CadastrarSemestresRequest, CadastrarSemestresResponse>
    {
        protected override Func<CadastrarSemestresRequest, CadastrarSemestresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarSemestresRequest, CadastrarSemestresResponse>(service.CadastrarSemestres);
        }
    }
}