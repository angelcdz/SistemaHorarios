using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarMaterias;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarMateriasModel : BaseModel<DeletarMateriasRequest, DeletarMateriasResponse>
    {
        protected override Func<DeletarMateriasRequest, DeletarMateriasResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarMateriasRequest, DeletarMateriasResponse>(service.DeletarMaterias);
        }
    }
}