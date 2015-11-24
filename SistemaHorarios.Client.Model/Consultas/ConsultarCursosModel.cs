using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.ConsultarCursos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class ConsultarCursosModel : BaseModel<ConsultarCursosRequest, ConsultarCursosResponse>
    {
        protected override Func<ConsultarCursosRequest, ConsultarCursosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<ConsultarCursosRequest, ConsultarCursosResponse>(service.ConsultarCursos);
        }
    }
}