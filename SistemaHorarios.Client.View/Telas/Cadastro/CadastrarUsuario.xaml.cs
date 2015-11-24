using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastrarUsuario.xaml
    /// </summary>
    public partial class CadastrarUsuario : UserControl
    {
        public CadastrarUsuario()
        {
            this.DataContext = new CadastrarUsuarioViewModel();
            InitializeComponent();
        }
    }
}
