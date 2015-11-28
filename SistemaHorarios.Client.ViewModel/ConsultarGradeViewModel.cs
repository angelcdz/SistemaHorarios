using System.Collections.Generic;
using System.ComponentModel;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms;
using SistemaHorarios.Contracts.ConsultarCursosPeriodosSemestres;
using SistemaHorarios.Contracts.ConsultarSemestres;

namespace SistemaHorarios.Client.ViewModel
{
    public class ConsultarGradeViewModel : INotifyPropertyChanged
    {
        public ConsultarGradeViewModel()
        {
            ActionConsultarSemestres = new RelayCommand();
            ActionConsultarPeriodos = new RelayCommand();
            ActionConsultarGrade = new RelayCommand();
            ListaPeriodos = new List<ConsultarCursosPeriodoDTO>();

            new Task(() =>
            {
                Status = "Consultando Cursos...";
                var model = new ConsultarCursosPeriodosSemestresModel();
                model.Execute(new ConsultarCursosPeriodosSemestresRequest());

                if (model.Response.Status == ExecutionStatus.Success)
                {
                    ListaCursos = model.Response.Cursos;
                    ListaSemestres = model.Response.Semestres;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar dados:\n", model.ErrorMessage));
                    return;
                }

                foreach (var item in ListaCursos)
                    ListaPeriodos.Add(item.Periodo);

                Status = string.Empty;
            }).Start();
        }

        private List<ConsultarCursosCursoDTO> _listaCursos;
        public List<ConsultarCursosCursoDTO> ListaCursos
        {
            get { return this._listaCursos; }
            set { this._listaCursos = value; OnPropertyChanged("ListaCursos"); }
        }

        private List<ConsultarCursosPeriodoDTO> _listaPeriodos;
        public List<ConsultarCursosPeriodoDTO> ListaPeriodos
        {
            get { return this._listaPeriodos; }
            set { this._listaPeriodos = value; OnPropertyChanged("ListaPeriodos"); }
        }

        private List<ConsultarSemestresSemestreDTO> _listaSemestres;
        public List<ConsultarSemestresSemestreDTO> ListaSemestres
        {
            get { return this._listaSemestres; }
            set { this._listaSemestres = value; OnPropertyChanged("ListaSemestres"); }
        }

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private RelayCommand _actionConsultarSemestres;
        public RelayCommand ActionConsultarSemestres
        {
            get { return _actionConsultarSemestres; }
            set
            {
                this._actionConsultarSemestres = new RelayCommand(obj => true, ExecutarConsultarSemestres);
            }

        }
        public void ExecutarConsultarSemestres(object obj)
        {

        }

        private RelayCommand _actionConsultarPeriodos;
        public RelayCommand ActionConsultarPeriodos
        {
            get { return _actionConsultarPeriodos; }
            set
            {
                this._actionConsultarPeriodos = new RelayCommand(obj => true, ExecutarConsultarPeriodos);
            }

        }
        public void ExecutarConsultarPeriodos(object obj)
        {

        }

        private RelayCommand _actionConsultarGrade;
        public RelayCommand ActionConsultarGrade
        {
            get { return _actionConsultarGrade; }
            set
            {
                this._actionConsultarGrade = new RelayCommand(obj => true, ExecutarConsultarGrade);
            }

        }
        public void ExecutarConsultarGrade(object obj)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
