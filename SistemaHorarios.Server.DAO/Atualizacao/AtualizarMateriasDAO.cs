using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarMaterias;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarMateriasDAO : BaseDAO<AtualizarMateriasRequest, AtualizarMateriasResponse>
    {
        protected override AtualizarMateriasResponse GetData(AtualizarMateriasRequest request)
        {
            throw new NotImplementedException();
        }
    }
}