using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarSemestres;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarSemestresModel : BaseModel<AtualizarSemestresRequest, AtualizarSemestresResponse>
    {
        protected override Func<AtualizarSemestresRequest, AtualizarSemestresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarSemestresRequest, AtualizarSemestresResponse>(service.AtualizarSemestres);
        }
    }
}