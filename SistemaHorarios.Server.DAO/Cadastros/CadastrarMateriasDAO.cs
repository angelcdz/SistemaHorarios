using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarMaterias;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarMateriasDAO : BaseDAO<CadastrarMateriasRequest, CadastrarMateriasResponse>
    {
        protected override CadastrarMateriasResponse GetData(CadastrarMateriasRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.Materias.Add(new Materia()
                {
                    NomeMateria = request.Nome.ToUpper()
                });

                context.SaveChanges();

                return new CadastrarMateriasResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}