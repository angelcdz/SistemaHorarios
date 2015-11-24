using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodoParam;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarPeriodoParamDAO : BaseDAO<ConsultarPeriodoParamRequest, ConsultarPeriodoParamResponse>
    {
        protected override ConsultarPeriodoParamResponse GetData(ConsultarPeriodoParamRequest request)
        {
            throw new NotImplementedException();
        }
    }
}