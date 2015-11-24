using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasHorarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarDiasHorariosBL : BaseBL<ConsultarDiasHorariosRequest, ConsultarDiasHorariosResponse>
    {
        public override ConsultarDiasHorariosResponse Execute(ConsultarDiasHorariosRequest request)
        {
            return new ConsultarDiasHorariosDAO().Execute(request);
        }
    }
}