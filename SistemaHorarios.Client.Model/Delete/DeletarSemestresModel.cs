using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarSemestres;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarSemestresModel : BaseModel<DeletarSemestresRequest, DeletarSemestresResponse>
    {
        protected override Func<DeletarSemestresRequest, DeletarSemestresResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarSemestresRequest, DeletarSemestresResponse>(service.DeletarSemestres);
        }
    }
}