using SistemaHorarios.Base;
using SistemaHorarios.Client.Model.SistemaHorariosService;
using SistemaHorarios.Contracts.CadastrarUsuarios;
using System;

namespace SistemaHorarios.Client.Model
{
    public class CadastrarUsuariosModel : BaseModel<CadastrarUsuariosRequest, CadastrarUsuariosResponse>
    {
        protected override Func<CadastrarUsuariosRequest, CadastrarUsuariosResponse> GetServiceMethod()
        {
            var service = new SistemaHorariosServiceClient();
            return new Func<CadastrarUsuariosRequest, CadastrarUsuariosResponse>(service.CadastrarUsuarios);
        }
    }
}