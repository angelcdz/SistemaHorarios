using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarProfessores;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarProfessoresDAO : BaseDAO<AtualizarProfessoresRequest, AtualizarProfessoresResponse>
    {
        protected override AtualizarProfessoresResponse GetData(AtualizarProfessoresRequest request)
        {
            throw new NotImplementedException();
        }
    }
}