using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarMaterias;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarMateriasModel : BaseModel<CadastrarMateriasRequest, CadastrarMateriasResponse>
    {
        protected override Func<CadastrarMateriasRequest, CadastrarMateriasResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarMateriasRequest, CadastrarMateriasResponse>(service.CadastrarMaterias);
        }
    }
}