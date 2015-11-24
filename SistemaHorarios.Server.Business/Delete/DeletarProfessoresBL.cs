using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarProfessores;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarProfessoresBL : BaseBL<DeletarProfessoresRequest, DeletarProfessoresResponse>
    {
        public override DeletarProfessoresResponse Execute(DeletarProfessoresRequest request)
        {
            return new DeletarProfessoresDAO().Execute(request);
        }
    }
}