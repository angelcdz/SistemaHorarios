using SistemaHorarios.Base;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarHorarios;
using SistemaHorarios.Contracts.ConsultarMaterias;
using SistemaHorarios.Contracts.ConsultarParametrosCadastroGrade;
using SistemaHorarios.Contracts.ConsultarProfessores;
using SistemaHorarios.Contracts.ConsultarSemestres;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;
using SistemaHorarios.Client.ViewModel.Resources;
using SistemaHorarios.Contracts.ConsultarHorarioParam;
using SistemaHorarios.Contracts.CadastrarGrade;

namespace SistemaHorarios.Client.ViewModel
{
    public class CadastrarGradeViewModel : INotifyPropertyChanged
    {
        public CadastrarGradeViewModel()
        {
            ActionCommand = new RelayCommand();
            ActionCommandHorarios = new RelayCommand();
            ActionCommandCursos = new RelayCommand();

            ListaHorarios = new List<DisplayHorario>();

            new Task(() =>
            {
                Status = "Consultando dados...";
                var model = new ConsultarParametrosCadastroGradeModel();
                model.Execute(new ConsultarParametrosCadastroGradeRequest());

                if (model.Response.Status == ExecutionStatus.Success)
                {
                    ListaCursos = from c in model.Response.Cursos
                                  select new DisplayCurso()
                                  {
                                      DisplayName = string.Concat(c.Nome, " (", c.Periodo.NomePeriodo, ")"),
                                      CodCurso = c.Codigo,
                                      CodPeriodo = c.Periodo.Codigo
                                  };
                    ListaDias = model.Response.Dias;
                    ListaMaterias = model.Response.Materias;
                    ListaProfessores = model.Response.Professores;
                    ListaSemestres = model.Response.Semestres;
                }
                else
                    MessageBox.Show(string.Concat("Erro ao consultar dados:\n", model.Response.ErrorMessage));

                Status = string.Empty;
            }).Start();
        }

        private IEnumerable<DisplayCurso> _listaCursos;
        public IEnumerable<DisplayCurso> ListaCursos
        {
            get { return this._listaCursos; }
            set { this._listaCursos = value; OnPropertyChanged("ListaCursos"); }
        }

        private IEnumerable<ConsultarMateriasMateriaDTO> _listaMaterias;
        public IEnumerable<ConsultarMateriasMateriaDTO> ListaMaterias
        {
            get { return this._listaMaterias; }
            set { this._listaMaterias = value; OnPropertyChanged("ListaMaterias"); }
        }

        private IEnumerable<ConsultarProfessoresProfessorDTO> _listaProfessores;
        public IEnumerable<ConsultarProfessoresProfessorDTO> ListaProfessores
        {
            get { return this._listaProfessores; }
            set { this._listaProfessores = value; OnPropertyChanged("ListaProfessores"); }
        }

        private IEnumerable<ConsultarSemestresSemestreDTO> _listaSemestres;
        public IEnumerable<ConsultarSemestresSemestreDTO> ListaSemestres
        {
            get { return this._listaSemestres; }
            set { this._listaSemestres = value; OnPropertyChanged("ListaSemestres"); }
        }

        private IEnumerable<ConsultarDiasSemanaDiaDTO> _listaDias;
        public IEnumerable<ConsultarDiasSemanaDiaDTO> ListaDias
        {
            get { return this._listaDias; }
            set { this._listaDias = value; OnPropertyChanged("ListaDias"); }
        }

        private List<DisplayHorario> _listaHorarios;
        public List<DisplayHorario> ListaHorarios
        {
            get { return this._listaHorarios; }
            set { this._listaHorarios = value; OnPropertyChanged("ListaHorarios"); }
        }

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private RelayCommand _actionCommandHorarios;
        public RelayCommand ActionCommandHorarios
        {
            get { return _actionCommandHorarios; }
            set
            {
                this._actionCommandHorarios = new RelayCommand(obj => true, ExecutarHorarios);
            }

        }
        public void ExecutarHorarios(object obj)
        {
            var param = (object[])obj;

            var curso = param[1] as DisplayCurso;
            if (curso == null)
            {
                MessageBox.Show("Selecione um curso");
                return;
            }

            var dia = param[0] as ConsultarDiasSemanaDiaDTO;
            if (dia == null)
            {
                MessageBox.Show("Selecione um dia");
                return;
            }

            new Task(() =>
            {
                Status = "Consultando horários...";

                var model = new ConsultarHorarioParamModel();
                model.Execute(new ConsultarHorarioParamRequest()
                {
                    CodigoDia = dia.CodigoDia,
                    CodigoPeriodo = curso.CodPeriodo
                });

                if (model.Response.Status == ExecutionStatus.Success)
                    ListaHorarios = (from c in model.Response.Horarios
                                    select new DisplayHorario()
                                    {
                                        DisplayName = string.Concat(c.HoraInicial, " - ", c.HoraFinal),
                                        CodHorario = c.Codigo
                                    }).ToList();
                else
                    MessageBox.Show(string.Concat("Erro ao consultar dados:\n", model.Response.ErrorMessage));

                Status = string.Empty;
            }).Start();
        }

        private RelayCommand _actionCommand;
        public RelayCommand ActionCommand
        {
            get { return _actionCommand; }
            set
            {
                this._actionCommand = new RelayCommand(obj => true, Executar);
            }

        }
        public void Executar(object obj)
        {
            var param = (object[])obj;

            var curso = param[0] as DisplayCurso;
            if (curso == null)
            {
                MessageBox.Show("Selecione um curso");
                return;
            }

            var materia = param[1] as ConsultarMateriasMateriaDTO;
            if (materia == null)
            {
                MessageBox.Show("Selecione uma matéria");
                return;
            }

            var professor = param[2] as ConsultarProfessoresProfessorDTO;
            if (professor == null)
            {
                MessageBox.Show("Selecione um professor");
                return;
            }
            
            var semestre = param[3] as ConsultarSemestresSemestreDTO;
            if (semestre == null)
            {
                MessageBox.Show("Selecione um semestre");
                return;
            }
            
            var dia = param[4] as ConsultarDiasSemanaDiaDTO;
            if (dia == null)
            {
                MessageBox.Show("Selecione um dia");
                return;
            }
            
            var horarios = param[5] as DisplayHorario;
            if (horarios == null)
            {
                MessageBox.Show("Selecione um horário");
                return;
            }
            
            new Task(() =>
            {
                Status = "Cadastrando...";

                var model = new CadastrarGradeModel();
                model.Execute(new CadastrarGradeRequest()
                {
                    CodigoCurso = curso.CodCurso,
                    CodigoDia = dia.CodigoDia,
                    CodigoHorario = horarios.CodHorario,
                    CodigoMateria = materia.Codigo,
                    CodigoProfessor = professor.Codigo,
                    CodigoSemestre = semestre.Codigo
                });

                if (model.Response.Status == ExecutionStatus.Success)
                    MessageBox.Show("Elemento de grade cadastrado com sucesso.");
                else
                    MessageBox.Show(string.Concat("Erro ao consultar dados:\n", model.Response.ErrorMessage));

                Status = string.Empty;
            }).Start();
        }

        private RelayCommand _actionCommandCursos;
        public RelayCommand ActionCommandCursos
        {
            get { return _actionCommandCursos; }
            set
            {
                this._actionCommandCursos = new RelayCommand(obj => true, ExecutarCursos);
            }

        }
        public void ExecutarCursos(object obj)
        {
            ListaHorarios = new List<DisplayHorario>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
