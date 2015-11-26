using System.Collections.Generic;
using System.ComponentModel;

namespace SistemaHorarios.Client.ViewModel
{
    public class SeletorUsuariosViewModel
    {
        private List<KeyValuePair<string, OperacoesUsuario>> _lista;
        public List<KeyValuePair<string, OperacoesUsuario>> Lista
        {
            get { return this._lista; }
            set
            {
                this._lista = value;
            }
        }

        public SeletorUsuariosViewModel()
        {
            this.Lista = new List<KeyValuePair<string, OperacoesUsuario>>()
                {
                    new KeyValuePair<string, OperacoesUsuario>("Alterar",OperacoesUsuario.Alterar),
                    new KeyValuePair<string, OperacoesUsuario>("Consultar",OperacoesUsuario.Consultar),
                    new KeyValuePair<string, OperacoesUsuario>("Cadastrar",OperacoesUsuario.Cadastrar)
                };
        }      
    }
}
