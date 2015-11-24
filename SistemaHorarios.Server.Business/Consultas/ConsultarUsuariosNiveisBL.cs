using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarUsuariosNiveis;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarUsuariosNiveisBL : BaseBL<ConsultarUsuariosNiveisRequest, ConsultarUsuariosNiveisResponse>
    {
        public override ConsultarUsuariosNiveisResponse Execute(ConsultarUsuariosNiveisRequest request)
        {
            return new ConsultarUsuariosNiveisDAO().Execute(request);
        }
    }
}