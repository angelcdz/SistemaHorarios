using System.Collections.Generic;
using System.ComponentModel;

namespace SistemaHorarios.Client.ViewModel
{
    public class SeletorAlteracoesViewModel
    {
        private List<KeyValuePair<string, Alterar>> _lista;
        public List<KeyValuePair<string, Alterar>> Lista
        {
            get { return this._lista; }
            set
            {
                this._lista = value;
            }
        }

        public SeletorAlteracoesViewModel()
        {
            this.Lista = new List<KeyValuePair<string, Alterar>>()
                {
                    new KeyValuePair<string, Alterar>("Cursos",Alterar.Cursos),
                    new KeyValuePair<string, Alterar>("Grade",Alterar.Grades),
                    new KeyValuePair<string, Alterar>("Horarios",Alterar.Horarios),
                    new KeyValuePair<string, Alterar>("Materias",Alterar.Materias),
                    new KeyValuePair<string, Alterar>("Níveis de Acesso",Alterar.NiveisAcesso),
                    new KeyValuePair<string, Alterar>("Periodos",Alterar.Periodos),
                    new KeyValuePair<string, Alterar>("Professores",Alterar.Professores),
                };
        }      
    }
}
