using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarMaterias;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarMateriasBL : BaseBL<ConsultarMateriasRequest, ConsultarMateriasResponse>
    {
        public override ConsultarMateriasResponse Execute(ConsultarMateriasRequest request)
        {
            return new ConsultarMateriasDAO().Execute(request);
        }
    }
}
