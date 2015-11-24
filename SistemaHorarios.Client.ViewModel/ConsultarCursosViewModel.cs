using System.Collections.Generic;
using System.ComponentModel;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using SistemaHorarios.Contracts.ConsultarCursoParam;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaHorarios.Client.ViewModel
{
    public class ConsultarCursosViewModel : INotifyPropertyChanged
    {
        public ConsultarCursosViewModel()
        {
            this.Periodos = new List<ConsultarPeriodosPeriodoDTO>();
            var task = new Task(() =>
            {
                Status = "Consultando Períodos...";
                var modelPeriodos = new ConsultarPeriodosModel();
                var requestPeriodos = new ConsultarPeriodosRequest();
                modelPeriodos.Execute(requestPeriodos);

                if (modelPeriodos.Response.Status == ExecutionStatus.Success) this.Periodos = modelPeriodos.Response.Periodos;
                else System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar professores:\n",modelPeriodos.ErrorMessage));
                Periodos.Add(new ConsultarPeriodosPeriodoDTO() { Codigo = 0, Nome = "<Nenhum>" });


                Status = "Consultando Cursos...";
                var modelCursos = new ConsultarCursosModel();
                var requestCursos = new ConsultarCursosRequest();
                modelCursos.Execute(requestCursos);

                if (modelCursos.Response.Status == ExecutionStatus.Success) this.Lista = modelCursos.Response.Cursos;
                else System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar professores:\n",modelCursos.ErrorMessage));
            });
            task.ContinueWith(x =>
            {
                Status = "";
            });

            task.Start();
            this.ActionCommand = new RelayCommand();
        }

        private List<ConsultarCursosCursoDTO> _lista;
        public List<ConsultarCursosCursoDTO> Lista
        {
            get { return this._lista; }
            set { this._lista = value; OnPropertyChanged("Lista"); }
        }

        private List<ConsultarPeriodosPeriodoDTO> _periodos;
        public List<ConsultarPeriodosPeriodoDTO> Periodos
        {
            get { return this._periodos; }
            set { this._periodos = value; OnPropertyChanged("Periodos"); }
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
            var cod = 0;
            var nome = (string)param[1];
            var codPeriodo = ((ConsultarPeriodosPeriodoDTO)param[2]) == null ? 0 : ((ConsultarPeriodosPeriodoDTO)param[2]).Codigo;

            if (!string.IsNullOrEmpty((string)param[0]) && !int.TryParse((string)param[0], out cod))
            {
                System.Windows.Forms.MessageBox.Show("Insira um número no campo de código.");
                return;
            }

            var task = new Task(() =>
            {
                Status = "Consultando...";
                var model = new ConsultarCursoParamModel();
                var request = new ConsultarCursoParamRequest() { Codigo = cod == 0 ? 0 : cod, Nome = nome, CodigoPeriodo = codPeriodo };
                model.Execute(request);

                if (model.Response.Status == ExecutionStatus.Success) this.Lista = model.Response.Cursos;
                else System.Windows.Forms.MessageBox.Show("Erro ao consultar professores:\n" + model.Response.ErrorMessage);
            });
            task.ContinueWith(x =>
            {
                Status = "";
            });

            task.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
