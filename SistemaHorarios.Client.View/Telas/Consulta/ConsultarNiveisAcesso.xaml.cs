using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultarNiveisAcesso.xaml
    /// </summary>
    public partial class ConsultarNiveisAcesso : UserControl
    {
        public ConsultarNiveisAcesso()
        {
            this.DataContext = new ConsultarNiveisAcessoViewModel();
            InitializeComponent();
        }
    }
}
