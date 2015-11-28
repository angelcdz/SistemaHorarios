using SistemaHorarios.Contracts.ConsultarCursosPeriodosSemestres;
using SistemaHorarios.Contracts.ConsultarCursosSemestres;
using SistemaHorarios.Contracts.ConsultarPeriodosPorCurso;
using SistemaHorarios.Contracts.ConsultarGrade;
using SistemaHorarios.Contracts.AutenticarUsuario;
using SistemaHorarios.Contracts.ConsultarUsuariosNiveis;
using SistemaHorarios.Contracts.ConsultarUsuariosParam;
using SistemaHorarios.Contracts.ConsultarDiasHorarios;
using SistemaHorarios.Contracts.ConsultarDiasPeriodos;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using SistemaHorarios.Contracts.ConsultarNivelAcessoParam;
using SistemaHorarios.Contracts.ConsultarDiaSemanaParam;
using SistemaHorarios.Contracts.ConsultarMateriaParam;
using SistemaHorarios.Contracts.ConsultarHorarioParam;
using SistemaHorarios.Contracts.ConsultarPeriodoParam;
using SistemaHorarios.Contracts.ConsultarCursoParam;
using SistemaHorarios.Contracts.ConsultarProfessorParam;
using SistemaHorarios.Contracts.DeletarUsuarios;
using SistemaHorarios.Contracts.DeletarSemestres;
using SistemaHorarios.Contracts.DeletarProfessores;
using SistemaHorarios.Contracts.DeletarPeriodos;
using SistemaHorarios.Contracts.DeletarNiveisAcesso;
using SistemaHorarios.Contracts.DeletarMaterias;
using SistemaHorarios.Contracts.DeletarHorarios;
using SistemaHorarios.Contracts.DeletarCursos;
using SistemaHorarios.Contracts.DeletarComposicoesHorario;
using SistemaHorarios.Contracts.DeletarComposicaoCurso;
using SistemaHorarios.Contracts.AtualizarUsuarios;
using SistemaHorarios.Contracts.AtualizarSemestres;
using SistemaHorarios.Contracts.AtualizarProfessores;
using SistemaHorarios.Contracts.AtualizarPeriodos;
using SistemaHorarios.Contracts.AtualizarNiveisAcesso;
using SistemaHorarios.Contracts.AtualizarMaterias;
using SistemaHorarios.Contracts.AtualizarHorarios;
using SistemaHorarios.Contracts.AtualizarCursos;
using SistemaHorarios.Contracts.AtualizarComposicoesHorario;
using SistemaHorarios.Contracts.AtualizarComposicaoCurso;
using SistemaHorarios.Contracts.ConsultarComposicoesHorario;
using SistemaHorarios.Contracts.ConsultarComposicoesCurso;
using SistemaHorarios.Contracts.CadastrarComposicaoCurso;
using SistemaHorarios.Contracts.CadastrarComposicoesHorario;
using SistemaHorarios.Contracts.CadastrarCursos;
using SistemaHorarios.Contracts.CadastrarHorarios;
using SistemaHorarios.Contracts.CadastrarMaterias;
using SistemaHorarios.Contracts.CadastrarNiveisAcesso;
using SistemaHorarios.Contracts.CadastrarPeriodos;
using SistemaHorarios.Contracts.CadastrarProfessores;
using SistemaHorarios.Contracts.CadastrarSemestres;
using SistemaHorarios.Contracts.CadastrarUsuarios;
using SistemaHorarios.Contracts.ConsultarCursos;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarHorarios;
using SistemaHorarios.Contracts.ConsultarMaterias;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using SistemaHorarios.Contracts.ConsultarProfessores;
using SistemaHorarios.Contracts.ConsultarSemestres;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using System.ServiceModel;

namespace SistemaHorarios.Server.WCF
{
    [ServiceContract]
    public interface ISistemaHorariosService
    {
        [OperationContract]
        ConsultarCursosResponse ConsultarCursos(ConsultarCursosRequest request);
        [OperationContract]
        ConsultarDiasSemanaResponse ConsultarDiasSemana(ConsultarDiasSemanaRequest request);
        [OperationContract]
        ConsultarHorariosResponse ConsultarHorarios(ConsultarHorariosRequest request);
        [OperationContract]
        ConsultarMateriasResponse ConsultarMaterias(ConsultarMateriasRequest request);
        [OperationContract]
        ConsultarPeriodosResponse ConsultarPeriodos(ConsultarPeriodosRequest request);
        [OperationContract]
        ConsultarProfessoresResponse ConsultarProfessores(ConsultarProfessoresRequest request);
        [OperationContract]
        ConsultarSemestresResponse ConsultarSemestres(ConsultarSemestresRequest request);
        [OperationContract]
        ConsultarUsuariosResponse ConsultarUsuarios(ConsultarUsuariosRequest request);
        [OperationContract]
        CadastrarComposicaoCursoResponse CadastrarComposicaoCurso(CadastrarComposicaoCursoRequest request);
        [OperationContract]
        CadastrarComposicoesHorarioResponse CadastrarComposicoesHorario(CadastrarComposicoesHorarioRequest request);
        [OperationContract]
        CadastrarCursosResponse CadastrarCursos(CadastrarCursosRequest request);
        [OperationContract]
        CadastrarHorariosResponse CadastrarHorarios(CadastrarHorariosRequest request);
        [OperationContract]
        CadastrarMateriasResponse CadastrarMaterias(CadastrarMateriasRequest request);
        [OperationContract]
        CadastrarNiveisAcessoResponse CadastrarNiveisAcesso(CadastrarNiveisAcessoRequest request);
        [OperationContract]
        CadastrarPeriodosResponse CadastrarPeriodos(CadastrarPeriodosRequest request);
        [OperationContract]
        CadastrarProfessoresResponse CadastrarProfessores(CadastrarProfessoresRequest request);
        [OperationContract]
        CadastrarSemestresResponse CadastrarSemestres(CadastrarSemestresRequest request);
        [OperationContract]
        CadastrarUsuariosResponse CadastrarUsuarios(CadastrarUsuariosRequest request);
        [OperationContract]
        ConsultarComposicoesCursoResponse ConsultarComposicoesCurso(ConsultarComposicoesCursoRequest request);
        [OperationContract]
        ConsultarComposicoesHorarioResponse ConsultarComposicoesHorario(ConsultarComposicoesHorarioRequest request);
        [OperationContract]
        AtualizarComposicaoCursoResponse AtualizarComposicaoCurso(AtualizarComposicaoCursoRequest request);
        [OperationContract]
        AtualizarComposicoesHorarioResponse AtualizarComposicoesHorario(AtualizarComposicoesHorarioRequest request);
        [OperationContract]
        AtualizarCursosResponse AtualizarCursos(AtualizarCursosRequest request);
        [OperationContract]
        AtualizarHorariosResponse AtualizarHorarios(AtualizarHorariosRequest request);
        [OperationContract]
        AtualizarMateriasResponse AtualizarMaterias(AtualizarMateriasRequest request);
        [OperationContract]
        AtualizarNiveisAcessoResponse AtualizarNiveisAcesso(AtualizarNiveisAcessoRequest request);
        [OperationContract]
        AtualizarPeriodosResponse AtualizarPeriodos(AtualizarPeriodosRequest request);
        [OperationContract]
        AtualizarProfessoresResponse AtualizarProfessores(AtualizarProfessoresRequest request);
        [OperationContract]
        AtualizarSemestresResponse AtualizarSemestres(AtualizarSemestresRequest request);
        [OperationContract]
        AtualizarUsuariosResponse AtualizarUsuarios(AtualizarUsuariosRequest request);
        [OperationContract]
        DeletarComposicaoCursoResponse DeletarComposicaoCurso(DeletarComposicaoCursoRequest request);
        [OperationContract]
        DeletarComposicoesHorarioResponse DeletarComposicoesHorario(DeletarComposicoesHorarioRequest request);
        [OperationContract]
        DeletarCursosResponse DeletarCursos(DeletarCursosRequest request);
        [OperationContract]
        DeletarHorariosResponse DeletarHorarios(DeletarHorariosRequest request);
        [OperationContract]
        DeletarMateriasResponse DeletarMaterias(DeletarMateriasRequest request);
        [OperationContract]
        DeletarNiveisAcessoResponse DeletarNiveisAcesso(DeletarNiveisAcessoRequest request);
        [OperationContract]
        DeletarPeriodosResponse DeletarPeriodos(DeletarPeriodosRequest request);
        [OperationContract]
        DeletarProfessoresResponse DeletarProfessores(DeletarProfessoresRequest request);
        [OperationContract]
        DeletarSemestresResponse DeletarSemestres(DeletarSemestresRequest request);
        [OperationContract]
        DeletarUsuariosResponse DeletarUsuarios(DeletarUsuariosRequest request);
        [OperationContract]
        ConsultarProfessorParamResponse ConsultarProfessorParam(ConsultarProfessorParamRequest request);
        [OperationContract]
        ConsultarCursoParamResponse ConsultarCursoParam(ConsultarCursoParamRequest request);
        [OperationContract]
        ConsultarPeriodoParamResponse ConsultarPeriodoParam(ConsultarPeriodoParamRequest request);
        [OperationContract]
        ConsultarHorarioParamResponse ConsultarHorarioParam(ConsultarHorarioParamRequest request);
        [OperationContract]
        ConsultarMateriaParamResponse ConsultarMateriaParam(ConsultarMateriaParamRequest request);
        [OperationContract]
        ConsultarDiaSemanaParamResponse ConsultarDiaSemanaParam(ConsultarDiaSemanaParamRequest request);
        [OperationContract]
        ConsultarNivelAcessoParamResponse ConsultarNivelAcessoParam(ConsultarNivelAcessoParamRequest request);
        [OperationContract]
        ConsultarNiveisAcessoResponse ConsultarNiveisAcesso(ConsultarNiveisAcessoRequest request);
        [OperationContract]
        ConsultarDiasPeriodosResponse ConsultarDiasPeriodos(ConsultarDiasPeriodosRequest request);
        [OperationContract]
        ConsultarDiasHorariosResponse ConsultarDiasHorarios(ConsultarDiasHorariosRequest request);
        [OperationContract]
        ConsultarUsuariosParamResponse ConsultarUsuariosParam(ConsultarUsuariosParamRequest request);
        [OperationContract]
        ConsultarUsuariosNiveisResponse ConsultarUsuariosNiveis(ConsultarUsuariosNiveisRequest request);
        [OperationContract]
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
        [OperationContract]
        ConsultarGradeResponse ConsultarGrade(ConsultarGradeRequest request);
        [OperationContract]
        ConsultarPeriodosPorCursoResponse ConsultarPeriodosPorCurso(ConsultarPeriodosPorCursoRequest request);
        [OperationContract]
        ConsultarCursosSemestresResponse ConsultarCursosSemestres(ConsultarCursosSemestresRequest request);
        [OperationContract]
        ConsultarCursosPeriodosSemestresResponse ConsultarCursosPeriodosSemestres(ConsultarCursosPeriodosSemestresRequest request);
    }
}
