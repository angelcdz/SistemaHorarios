using System.Collections.Generic;
using System.ComponentModel;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms;
using SistemaHorarios.Contracts.ConsultarCursosPeriodosSemestres;
using SistemaHorarios.Contracts.ConsultarSemestres;
using SistemaHorarios.Contracts.ConsultarCursos;
using System.Linq;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarGrade;

namespace SistemaHorarios.Client.ViewModel
{
    public class ConsultarGradeViewModel : INotifyPropertyChanged
    {
        public ConsultarGradeViewModel()
        {
            ActionCommand = new RelayCommand();

            new Task(() =>
            {
                Status = "Consultando Cursos...";
                var model = new ConsultarCursosPeriodosSemestresModel();
                model.Execute(new ConsultarCursosPeriodosSemestresRequest());

                if (model.Response.Status == ExecutionStatus.Success)
                {
                    ListaCursos = from c in model.Response.Cursos
                                  select new DisplayCurso()
                                          {
                                              DisplayName = string.Concat(c.Nome, " (", c.Periodo.NomePeriodo, ")"),
                                              CodCurso = c.Codigo,
                                              CodPeriodo = c.Periodo.Codigo
                                          };
                    ListaSemestres = model.Response.Semestres;
                    ListaDias = model.Response.DiasSemana;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar dados:\n", model.ErrorMessage));
                    return;
                }

                Status = string.Empty;
            }).Start();
        }

        private IEnumerable<DisplayCurso> _listaCursos;
        public IEnumerable<DisplayCurso> ListaCursos
        {
            get { return this._listaCursos; }
            set { this._listaCursos = value; OnPropertyChanged("ListaCursos"); }
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

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
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
            var codCurso = (param[0]) as DisplayCurso;
            if (codCurso == null)
            {
                MessageBox.Show("Selecione um curso.");
            }

            var codSemestres = (param[1]) as ConsultarSemestresSemestreDTO;
            if (codSemestres == null)
            {
                MessageBox.Show("Selecione um semestre.");
            }

            var codDia = (param[2]) as ConsultarDiasSemanaDiaDTO;
            if (codDia == null)
            {
                MessageBox.Show("Selecione um dia da semana.");
            }


            new Task(() =>
            {
                Status = "Consultando Cursos...";
                var model = new ConsultarGradeModel();
                model.Execute(new ConsultarGradeRequest()
                {
                    CodCurso = codCurso.CodCurso,
                    CodDia = codDia.CodigoDia,
                    CodPeriodo = codCurso.CodPeriodo,
                    CodSemestre = codSemestres.Codigo
                });

                if (model.Response.Status == ExecutionStatus.Success)
                {
                    //ListaCursos = from c in model.Response.Cursos
                    //              select new DisplayCurso()
                    //              {
                    //                  DisplayName = string.Concat(c.Nome, " (", c.Periodo.NomePeriodo, ")"),
                    //                  CodCurso = c.Codigo,
                    //                  CodPeriodo = c.Periodo.Codigo
                    //              };
                    //ListaSemestres = model.Response.Semestres;
                    //ListaDias = model.Response.DiasSemana;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar dados:\n", model.ErrorMessage));
                    return;
                }

                Status = string.Empty;
            }).Start();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DisplayCurso
    {
        public string DisplayName { get; set; }
        public int CodCurso { get; set; }
        public int CodPeriodo { get; set; }
    }
}
