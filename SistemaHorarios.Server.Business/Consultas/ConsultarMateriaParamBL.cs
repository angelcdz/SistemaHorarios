using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarMateriaParam;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarMateriaParamBL : BaseBL<ConsultarMateriaParamRequest, ConsultarMateriaParamResponse>
    {
        public override ConsultarMateriaParamResponse Execute(ConsultarMateriaParamRequest request)
        {
            return new ConsultarMateriaParamDAO().Execute(request);
        }
    }
}