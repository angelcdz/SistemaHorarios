using System.Collections.Generic;
using System.ComponentModel;

namespace SistemaHorarios.Client.ViewModel
{
    public class SeletorConsultasViewModel
    {
        public SeletorConsultasViewModel()
        {
            this.Lista = new List<KeyValuePair<string, Consultar>>()
                {
                    new KeyValuePair<string, Consultar>("Cursos",Consultar.Cursos),
                    new KeyValuePair<string, Consultar>("Grade",Consultar.Grades),
                    new KeyValuePair<string, Consultar>("Horarios",Consultar.Horarios),
                    new KeyValuePair<string, Consultar>("Materias",Consultar.Materias),
                    new KeyValuePair<string, Consultar>("Níveis de Acesso",Consultar.NiveisAcesso),
                    new KeyValuePair<string, Consultar>("Periodos",Consultar.Periodos),
                    new KeyValuePair<string, Consultar>("Professores",Consultar.Professores),
                    new KeyValuePair<string, Consultar>("Usuários",Consultar.Usuarios),
                };
        }  

        private List<KeyValuePair<string, Consultar>> _lista;
        public List<KeyValuePair<string, Consultar>> Lista
        {
            get { return this._lista; }
            set
            {
                this._lista = value;
            }
        }
    }
}
