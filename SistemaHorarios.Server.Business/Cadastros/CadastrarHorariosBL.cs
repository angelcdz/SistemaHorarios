using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarHorarios;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarHorariosBL : BaseBL<CadastrarHorariosRequest, CadastrarHorariosResponse>
    {
        public override CadastrarHorariosResponse Execute(CadastrarHorariosRequest request)
        {
            return new CadastrarHorariosDAO().Execute(request);
        }
    }
}