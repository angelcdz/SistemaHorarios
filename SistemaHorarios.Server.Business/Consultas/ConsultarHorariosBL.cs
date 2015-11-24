using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarHorarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarHorariosBL : BaseBL<ConsultarHorariosRequest, ConsultarHorariosResponse>
    {
        public override ConsultarHorariosResponse Execute(ConsultarHorariosRequest request)
        {
            return new ConsultarHorariosDAO().Execute(request);
        }
    }
}
