﻿using System.Collections.Generic;
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
    public class ConsultarGradeViewModel : INotifyPropertyChanged
    {
        public ConsultarGradeViewModel()
        {
            ActionConsultarCursos = new RelayCommand();
            ActionConsultarSemestres = new RelayCommand();
            ActionConsultarPeriodos = new RelayCommand();
            ActionConsultarGrade = new RelayCommand();
        }

        private bool _enabledPeriodo;
        public bool EnabledPeriodo
        {
            get { return this._enabledPeriodo; }
            set { this._enabledPeriodo = value; OnPropertyChanged("EnabledPeriodo"); }
        }

        private bool _enabledSemestre;
        public bool EnabledSemestre
        {
            get { return this._enabledSemestre; }
            set { this._enabledSemestre = value; OnPropertyChanged("EnabledSemestre"); }
        }

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private RelayCommand _actionConsultarCursos;
        public RelayCommand ActionConsultarCursos
        {
            get { return _actionConsultarCursos; }
            set
            {
                this._actionConsultarCursos = new RelayCommand(obj => true, ExecutarConsultarCursos);
            }

        }
        public void ExecutarConsultarCursos(object obj)
        {

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