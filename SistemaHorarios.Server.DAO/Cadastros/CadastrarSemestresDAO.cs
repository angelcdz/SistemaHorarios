using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarSemestres;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarSemestresDAO : BaseDAO<CadastrarSemestresRequest, CadastrarSemestresResponse>
    {
        protected override CadastrarSemestresResponse GetData(CadastrarSemestresRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Semestres.Add(new Semestre() { NumeroSemestre = request.Numero });

                context.SaveChanges();

                return new CadastrarSemestresResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}