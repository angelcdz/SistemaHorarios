using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastrarCurso.xaml
    /// </summary>
    public partial class CadastrarCurso : UserControl
    {
        public CadastrarCurso()
        {
            this.DataContext = new CadastrarCursoViewModel();
            InitializeComponent();
        }
    }
}
