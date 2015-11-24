using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarHorarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarHorariosBL : BaseBL<AtualizarHorariosRequest, AtualizarHorariosResponse>
    {
        public override AtualizarHorariosResponse Execute(AtualizarHorariosRequest request)
        {
            return new AtualizarHorariosDAO().Execute(request);
        }
    }
}