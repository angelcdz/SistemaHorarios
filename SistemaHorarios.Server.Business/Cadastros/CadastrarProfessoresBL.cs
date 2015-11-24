using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarProfessores;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarProfessoresBL : BaseBL<CadastrarProfessoresRequest, CadastrarProfessoresResponse>
    {
        public override CadastrarProfessoresResponse Execute(CadastrarProfessoresRequest request)
        {
            return new CadastrarProfessoresDAO().Execute(request);
        }
    }
}