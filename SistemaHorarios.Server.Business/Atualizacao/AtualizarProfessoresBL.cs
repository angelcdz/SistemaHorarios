using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarProfessores;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarProfessoresBL : BaseBL<AtualizarProfessoresRequest, AtualizarProfessoresResponse>
    {
        public override AtualizarProfessoresResponse Execute(AtualizarProfessoresRequest request)
        {
            return new AtualizarProfessoresDAO().Execute(request);
        }
    }
}