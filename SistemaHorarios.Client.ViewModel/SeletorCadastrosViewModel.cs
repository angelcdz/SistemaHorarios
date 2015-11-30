using System.Collections.Generic;
using System.ComponentModel;

namespace SistemaHorarios.Client.ViewModel
{
    public class SeletorCadastrosViewModel
    {
        private List<KeyValuePair<string, Cadastrar>> _lista;
        public List<KeyValuePair<string, Cadastrar>> Lista
        {
            get { return this._lista; }
            set
            {
                this._lista = value;
            }
        }

        public SeletorCadastrosViewModel()
        {
            this.Lista = new List<KeyValuePair<string, Cadastrar>>()
                {
                    new KeyValuePair<string, Cadastrar>("",Cadastrar.Usuarios),
                    new KeyValuePair<string, Cadastrar>("Cursos",Cadastrar.Cursos),
                    new KeyValuePair<string, Cadastrar>("Grade",Cadastrar.Grades),
                    new KeyValuePair<string, Cadastrar>("Horarios",Cadastrar.Horarios),
                    new KeyValuePair<string, Cadastrar>("Materias",Cadastrar.Materias),
                    new KeyValuePair<string, Cadastrar>("Periodos",Cadastrar.Periodos),
                    new KeyValuePair<string, Cadastrar>("Professores",Cadastrar.Professores)
                };
        }      
    }
}
