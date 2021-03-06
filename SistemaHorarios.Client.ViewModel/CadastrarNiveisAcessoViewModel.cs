﻿using System.ComponentModel;
using System.Windows.Forms;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Contracts.CadastrarNiveisAcesso;
using SistemaHorarios.Base;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SistemaHorarios.Client.ViewModel
{
    public class CadastrarNiveisAcessoViewModel : INotifyPropertyChanged
    {
        public CadastrarNiveisAcessoViewModel()
        {
            CriarEnabled = true;
            CancelarEnabled = true;
            ActionCommandCriar = new RelayCommand();
            ActionCommandCancelar = new RelayCommand();
        }

        private bool _criarEnabled;
        public bool CriarEnabled
        {
            get { return this._criarEnabled; }
            set { this._criarEnabled = value; OnPropertyChanged("CriarEnabled"); }
        }

        private bool _cancelarEnabled;
        public bool CancelarEnabled
        {
            get { return this._cancelarEnabled; }
            set { this._cancelarEnabled = value; OnPropertyChanged("CancelarEnabled"); }
        }

        private string _text;
        public string Text
        {
            get { return this._text; }
            set { this._text = value; OnPropertyChanged("Text"); }
        }

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private RelayCommand _actionCommandCriar;
        public RelayCommand ActionCommandCriar
        {
            get { return _actionCommandCriar; }
            set
            {
                this._actionCommandCriar = new RelayCommand(obj => true, ExecutarCriar);
            }

        }
        public void ExecutarCriar(object obj)
        {
            var text = (string)((object[])obj)[0];
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Insira um nome para o novo nível.");
                return;
            }

            var admin = (bool)((object[])obj)[1];
            var cons = (bool)((object[])obj)[2];
            var ops = (bool)((object[])obj)[3];

            new Task(() =>
            {
                CriarEnabled = false;
                CancelarEnabled = false;
                Status = "Criando...";

                var model = new CadastrarNiveisAcessoModel();
                model.Execute(new CadastrarNiveisAcessoRequest()
                {
                    Descricao = text,
                    Administrador = admin,
                    Cadastro = ops,
                    Consultas = cons
                });

                if (model.Response.Status == ExecutionStatus.Success) MessageBox.Show("Nível criado com sucesso!");
                else MessageBox.Show(string.Concat("Erro ao criar o nível:\n", model.Response.ErrorMessage));

                CriarEnabled = true;
                CancelarEnabled = true;
                Status = "";
            }).Start();
        }

        private RelayCommand _actionCommandCancelar;
        public RelayCommand ActionCommandCancelar
        {
            get { return _actionCommandCancelar; }
            set
            {
                this._actionCommandCancelar = new RelayCommand(obj => true, ExecutarCancelar);
            }

        }
        public void ExecutarCancelar(object obj)
        {
            Text = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
