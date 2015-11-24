using System.Collections.Generic;
using System.ComponentModel;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNivelAcessoParam;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms;
using System;

namespace SistemaHorarios.Client.ViewModel
{
    public class ConsultarNiveisAcessoViewModel : INotifyPropertyChanged
    {
        public ConsultarNiveisAcessoViewModel()
        {
            var task = new Task(() =>
            {
                Status = "Consultando...";
                var modelCursos = new ConsultarNiveisAcessoModel();
                var requestCursos = new ConsultarNiveisAcessoRequest();
                modelCursos.Execute(requestCursos);

                if (modelCursos.Response.Status == ExecutionStatus.Success) this.Lista = modelCursos.Response.Niveis;
                else System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar professores:\n",modelCursos.ErrorMessage));
            });
            task.ContinueWith(x =>
            {
                Status = "";
            });

            task.Start();
            this.ActionCommand = new RelayCommand();
        }

        private List<ConsultarNiveisAcessoDTO> _lista;
        public List<ConsultarNiveisAcessoDTO> Lista
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
            var param = (object[])obj;
            var cod = 0;

            if (!string.IsNullOrEmpty((string)param[0]) && !int.TryParse((string)param[0], out cod))
            {
                System.Windows.Forms.MessageBox.Show("Insira um número no campo de código.");
                return;
            }

            var nome = (string)param[1];

            var admin = (bool)param[2];
            var consultas = (bool)param[3];
            var operacoes = (bool)param[4];


            var task = new Task(() =>
            {
                Status = "Consultando...";
                var model = new ConsultarNivelAcessoParamModel();
                var request = new ConsultarNivelAcessoParamRequest()
                {
                    Codigo = cod,
                    Nome = nome,
                    Administrador = admin,
                    Consultas = consultas,
                    Operacoes = operacoes
                };
                model.Execute(request);

                if (model.Response.Status == ExecutionStatus.Success) this.Lista = model.Response.Niveis;
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
