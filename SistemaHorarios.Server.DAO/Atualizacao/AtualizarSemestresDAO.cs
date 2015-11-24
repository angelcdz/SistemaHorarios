using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarSemestres;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarSemestresDAO : BaseDAO<AtualizarSemestresRequest, AtualizarSemestresResponse>
    {
        protected override AtualizarSemestresResponse GetData(AtualizarSemestresRequest request)
        {
            throw new NotImplementedException();
        }
    }
}