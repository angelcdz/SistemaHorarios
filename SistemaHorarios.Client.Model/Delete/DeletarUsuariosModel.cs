using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.DeletarUsuarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class DeletarUsuariosModel : BaseModel<DeletarUsuariosRequest, DeletarUsuariosResponse>
    {
        protected override Func<DeletarUsuariosRequest, DeletarUsuariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<DeletarUsuariosRequest, DeletarUsuariosResponse>(service.DeletarUsuarios);
        }
    }
}