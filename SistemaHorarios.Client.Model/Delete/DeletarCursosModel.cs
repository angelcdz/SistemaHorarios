using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarCursos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarCursosModel : BaseModel<DeletarCursosRequest, DeletarCursosResponse>
    {
        protected override Func<DeletarCursosRequest, DeletarCursosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarCursosRequest, DeletarCursosResponse>(service.DeletarCursos);
        }
    }
}