using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarMaterias;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarMateriasBL : BaseBL<DeletarMateriasRequest, DeletarMateriasResponse>
    {
        public override DeletarMateriasResponse Execute(DeletarMateriasRequest request)
        {
            return new DeletarMateriasDAO().Execute(request);
        }
    }
}