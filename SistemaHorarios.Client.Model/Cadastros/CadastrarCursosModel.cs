using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarCursos;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarCursosModel : BaseModel<CadastrarCursosRequest, CadastrarCursosResponse>
    {
        protected override Func<CadastrarCursosRequest, CadastrarCursosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarCursosRequest, CadastrarCursosResponse>(service.CadastrarCursos);
        }
    }
}