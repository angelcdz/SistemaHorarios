using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastrarNiveisAcesso.xaml
    /// </summary>
    public partial class CadastrarNiveisAcesso : UserControl
    {
        public CadastrarNiveisAcesso()
        {
            this.DataContext = new CadastrarNiveisAcessoViewModel();
            InitializeComponent();
        }
    }
}
