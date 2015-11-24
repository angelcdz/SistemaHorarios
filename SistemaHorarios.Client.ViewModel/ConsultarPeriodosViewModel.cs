using System.Collections.Generic;
using System.ComponentModel;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodos;
//using SistemaHorarios.Contracts.ConsultarProfessorParam;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaHorarios.Client.ViewModel
{
    public class ConsultarPeriodosViewModel : INotifyPropertyChanged
    {
        public ConsultarPeriodosViewModel()
        {
            var task = new Task(() =>
            {
                Status = "Consultando...";
                var model = new ConsultarPeriodosModel();
                var request = new ConsultarPeriodosRequest();
                model.Execute(request);

                if (model.Response.Status == ExecutionStatus.Success) this.Lista = model.Response.Periodos;
                else System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar professores:\n",model.Response.ErrorMessage));
            });
            task.ContinueWith(x =>
            {
                Status = "";
            });

            task.Start();
            this.ActionCommand = new RelayCommand();
        }

        private List<ConsultarPeriodosPeriodoDTO> _lista;
        public List<ConsultarPeriodosPeriodoDTO> Lista
        {
            get { return this._lista; }
            set { this._lista = value; OnPropertyChanged("Lista"); }
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
            //var param = (object[]) obj;
            //int cod = 0;

            //if (!string.IsNullOrEmpty((string)param[0]) && !int.TryParse((string)param[0], out cod))
            //{
            //    System.Windows.Forms.MessageBox.Show("Insira um número no campo de código.");
            //    return;
            //}
            
            //var nome = (string) param[1];

            //var task = new Task(() =>
            //{
            //    Status = "Consultando...";
            //    var model = new ConsultarProfessorParamModel();
            //    var request = new ConsultarProfessorParamRequest() { Codigo = cod == 0 ? 0 : cod, Nome = nome };
            //    model.Execute(request);

            //    if (model.Response.Status == ExecutionStatus.Success) this.Lista = model.Response.Professores;
            //    else System.Windows.Forms.MessageBox.Show("Erro ao consultar professores:\n" + model.Response.ErrorMessage);
            //});
            //task.ContinueWith(x =>
            //{
            //    Status = "";
            //});

            //task.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
