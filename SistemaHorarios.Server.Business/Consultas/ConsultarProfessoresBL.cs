using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarProfessores;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarProfessoresBL : BaseBL<ConsultarProfessoresRequest, ConsultarProfessoresResponse>
    {
        public override ConsultarProfessoresResponse Execute(ConsultarProfessoresRequest request)
        {
            return new ConsultarProfessoresDAO().Execute(request);
        }
    }
}
