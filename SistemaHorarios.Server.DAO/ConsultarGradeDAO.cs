using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarGrade;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarGradeDAO : BaseDAO<ConsultarGradeRequest, ConsultarGradeResponse>
    {
        protected override ConsultarGradeResponse GetData(ConsultarGradeRequest request)
        {
            var response = new ConsultarGradeResponse()
            {
                Status = ExecutionStatus.Success,
                Horarios = new System.Collections.Generic.List<ConsultarGradeHorarioDTO>(),
                NomeCurso = request.NomeCurso,
                NomeDia = request.NomeDia,
                NumeroSemestre = request.NumeroSemestre
            };

            using (var context = new SistemaHorariosEntities())
            {
                var query = 
                    context.Database.SqlQuery<ConsultarGradeHorarioDTO>(@"SELECT HO.COD_HORARIO CodHorario,
		                                                                          HO.HORA_INICIAL HorarioInicial,
		                                                                          HO.HORA_FINAL HorarioFinal
                                                                          FROM HORARIO HO
                                                                          JOIN PERIODO PE
                                                                          ON HO.COD_PERIODO = PE.COD_PERIODO
                                                                          JOIN DIA_SEMANA DS
                                                                          ON HO.COD_DIA = DS.COD_DIA
                                                                          WHERE DS.COD_DIA = @p0
                                                                          AND PE.COD_PERIODO = @p1", request.CodDia, request.CodPeriodo).ToList();

                ConsultarGradeHorarioDTO horario = null;

                foreach (var item in query)
                {
                    horario = new ConsultarGradeHorarioDTO()
                    {
                        CodHorario = item.CodHorario,
                        HorarioFinal = item.HorarioFinal,
                        HorarioInicial = item.HorarioInicial
                    };

                    var queryMateira =
                    context.Database.SqlQuery<ConsultarGradeHorarioMateriaDTO>(@"SELECT	MA.NOME_MATERIA Materia,
	                                                                                    PR.NOME_PROFESSOR Professor
                                                                                    FROM COMPOSICAO_HORARIO CH
                                                                                    JOIN COMPOSICAO_CURSO CC
                                                                                    ON CH.COD_COMP_CURSO = CC.COD_COMP_CURSO
                                                                                    JOIN MATERIA MA
                                                                                    ON CC.COD_MATERIA = MA.COD_MATERIA
                                                                                    JOIN PROFESSOR PR
                                                                                    ON CC.COD_PROFESSOR = PR.COD_PROFESSOR
                                                                                    WHERE CH.COD_HORARIO = @p0", horario.CodHorario).ToList();

                    foreach (var materia in queryMateira)
                        horario.Materia = new ConsultarGradeHorarioMateriaDTO()
                        {
                            Materia = UppercaseWords(materia.Materia),
                            Professor = UppercaseWords(materia.Professor)
                        };

                    response.Horarios.Add(horario);
                }

                return response;
            }
        }
    }
}