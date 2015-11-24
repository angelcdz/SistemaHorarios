using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarMaterias;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarMateriasBL : BaseBL<AtualizarMateriasRequest, AtualizarMateriasResponse>
    {
        public override AtualizarMateriasResponse Execute(AtualizarMateriasRequest request)
        {
            return new AtualizarMateriasDAO().Execute(request);
        }
    }
}