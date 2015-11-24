using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarHorarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarHorariosBL : BaseBL<DeletarHorariosRequest, DeletarHorariosResponse>
    {
        public override DeletarHorariosResponse Execute(DeletarHorariosRequest request)
        {
            return new DeletarHorariosDAO().Execute(request);
        }
    }
}