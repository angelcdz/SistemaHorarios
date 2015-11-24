using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiaSemanaParam;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarDiaSemanaParamDAO : BaseDAO<ConsultarDiaSemanaParamRequest, ConsultarDiaSemanaParamResponse>
    {
        protected override ConsultarDiaSemanaParamResponse GetData(ConsultarDiaSemanaParamRequest request)
        {
            throw new NotImplementedException();
        }
    }
}