using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarMateriaParam;
using SistemaHorarios.Contracts.ConsultarMaterias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarMateriaParamDAO : BaseDAO<ConsultarMateriaParamRequest, ConsultarMateriaParamResponse>
    {
        protected override ConsultarMateriaParamResponse GetData(ConsultarMateriaParamRequest request)
        {
            var response = new ConsultarMateriaParamResponse() { Status = ExecutionStatus.Success };
            response.Materias = new List<ConsultarMateriasMateriaDTO>();

            using (var context = new SistemaHorariosEntities())
            {
                if (request.Codigo != 0)
                    foreach (var item in context.Materias.Where(mat => mat.CodigoMateria == request.Codigo))
                        response.Materias.Add(new ConsultarMateriasMateriaDTO()
                        {
                            Codigo = item.CodigoMateria,
                            Nome = UppercaseWords(item.NomeMateria)
                        });
                else
                    foreach (var item in context.Materias.Where(mat => mat.NomeMateria.Contains(request.Nome)))
                        response.Materias.Add(new ConsultarMateriasMateriaDTO()
                        {
                            Codigo = item.CodigoMateria,
                            Nome = UppercaseWords(item.NomeMateria)
                        });
            }

            return response;
        }
    }
}