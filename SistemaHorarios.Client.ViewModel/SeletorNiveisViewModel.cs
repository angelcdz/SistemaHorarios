using System.Collections.Generic;
using System.ComponentModel;

namespace SistemaHorarios.Client.ViewModel
{
    public class SeletorNiveisViewModel
    {
        private List<KeyValuePair<string, OperacoesNivel>> _lista;
        public List<KeyValuePair<string, OperacoesNivel>> Lista
        {
            get { return this._lista; }
            set
            {
                this._lista = value;
            }
        }

        public SeletorNiveisViewModel()
        {
            this.Lista = new List<KeyValuePair<string, OperacoesNivel>>()
                {
                    new KeyValuePair<string, OperacoesNivel>("Alterar",OperacoesNivel.Alterar),
                    new KeyValuePair<string, OperacoesNivel>("Consultar",OperacoesNivel.Consultar),
                    new KeyValuePair<string, OperacoesNivel>("Cadastrar",OperacoesNivel.Cadastrar)
                };
        }      
    }
}
