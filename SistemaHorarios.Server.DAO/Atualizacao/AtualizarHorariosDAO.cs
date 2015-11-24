using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarHorarios;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarHorariosDAO : BaseDAO<AtualizarHorariosRequest, AtualizarHorariosResponse>
    {
        protected override AtualizarHorariosResponse GetData(AtualizarHorariosRequest request)
        {
            throw new NotImplementedException();
        }
    }
}