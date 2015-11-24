using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarDiasSemanaBL : BaseBL<ConsultarDiasSemanaRequest, ConsultarDiasSemanaResponse>
    {
        public override ConsultarDiasSemanaResponse Execute(ConsultarDiasSemanaRequest request)
        {
            return new ConsultarDiasSemanaDAO().Execute(request);
        }
    }
}
