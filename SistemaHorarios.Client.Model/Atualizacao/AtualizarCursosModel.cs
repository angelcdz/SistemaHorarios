using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.AtualizarCursos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class AtualizarCursosModel : BaseModel<AtualizarCursosRequest, AtualizarCursosResponse>
    {
        protected override Func<AtualizarCursosRequest, AtualizarCursosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<AtualizarCursosRequest, AtualizarCursosResponse>(service.AtualizarCursos);
        }
    }
}