using System.Collections.Generic;
using System.ComponentModel;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarHorarios;
using SistemaHorarios.Contracts.ConsultarHorarioParam;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms;
using System;
using SistemaHorarios.Contracts.ConsultarDiasHorarios;

namespace SistemaHorarios.Client.ViewModel
{
    public class ConsultarHorariosViewModel : INotifyPropertyChanged
    {
        public ConsultarHorariosViewModel()
        {
            this.Dias = new List<ConsultarDiasSemanaDiaDTO>();
            var task = new Task(() =>
            {
                Status = "Consultando...";
                var model = new ConsultarDiasHorariosModel();
                var request = new ConsultarDiasHorariosRequest();
                model.Execute(request);

                if (model.Response.Status == ExecutionStatus.Success)
                {
                    this.Dias = model.Response.Dias;
                    this.Lista = model.Response.Horarios;
                }
            });
            task.ContinueWith(x =>
            {
                Status = "";
            });

            task.Start();
            this.ActionCommand = new RelayCommand();
        }

        private List<ConsultarHorariosHorarioDTO> _lista;
        public List<ConsultarHorariosHorarioDTO> Lista
        {
            get { return this._lista; }
            set { this._lista = value; OnPropertyChanged("Lista"); }
        }

        private List<ConsultarDiasSemanaDiaDTO> _dias;
        public List<ConsultarDiasSemanaDiaDTO> Dias
        {
            get { return this._dias; }
            set { this._dias = value; OnPropertyChanged("Dias"); }
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
            TimeSpan inicial = TimeSpan.Zero, final = TimeSpan.Zero;
            var codDia = ((ConsultarDiasSemanaDiaDTO)param[3]) == null ? 0 : ((ConsultarDiasSemanaDiaDTO)param[3]).CodigoDia;

            if ((!string.IsNullOrEmpty((string)param[1]) && !TimeSpan.TryParse((string)param[1], out inicial))
                || (!string.IsNullOrEmpty((string)param[2]) && !TimeSpan.TryParse((string)param[2], out final)))
            {
                System.Windows.Forms.MessageBox.Show("Insira valores válidos nos campos de hora.");
                return;
            }
            if (!string.IsNullOrEmpty((string)param[0]) && !int.TryParse((string)param[0], out cod))
            {
                System.Windows.Forms.MessageBox.Show("Insira um número no campo de código.");
                return;
            }

            var task = new Task(() =>
            {
                Status = "Consultando...";
                var model = new ConsultarHorarioParamModel();
                var request = new ConsultarHorarioParamRequest()
                {
                    Codigo = cod,
                    Inicial = inicial,
                    Final = final,
                    CodigoDia = codDia
                };
                model.Execute(request);

                if (model.Response.Status == ExecutionStatus.Success) this.Lista = model.Response.Horarios;
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
