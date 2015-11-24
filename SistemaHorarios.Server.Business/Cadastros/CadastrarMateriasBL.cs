using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarMaterias;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarMateriasBL : BaseBL<CadastrarMateriasRequest, CadastrarMateriasResponse>
    {
        public override CadastrarMateriasResponse Execute(CadastrarMateriasRequest request)
        {
            return new CadastrarMateriasDAO().Execute(request);
        }
    }
}