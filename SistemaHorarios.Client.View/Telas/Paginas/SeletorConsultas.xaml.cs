using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;
using SistemaHorarios.Client.View.Telas;
using System.Collections.Generic;

namespace SistemaHorarios.Client.View
{
    /// <summary>
    /// Interaction logic for SeletorConsultas.xaml
    /// </summary>
    public partial class SeletorConsultas : UserControl
    {
        public SeletorConsultas()
        {
            this.DataContext = new SeletorConsultasViewModel();
            InitializeComponent();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var choice = (KeyValuePair<string,Consultar>)Combo.SelectedItem;
            Lista.Children.Clear();

            switch (choice.Value)
            {
                case Consultar.Cursos:
                    Lista.Children.Add(new ConsultarCursos());
                    break;
                case Consultar.Grades:
                    Lista.Children.Add(new ConsultarGrade());
                    break;
                case Consultar.Horarios:
                    Lista.Children.Add(new ConsultarHorarios());
                    break;
                case Consultar.Materias:
                    Lista.Children.Add(new ConsultarMaterias());
                    break;
                case Consultar.Periodos:
                    Lista.Children.Add(new ConsultarPeriodos());
                    break;
                case Consultar.Professores:
                    Lista.Children.Add(new ConsultarProfessores());
                    break;
                case Consultar.NiveisAcesso:
                    Lista.Children.Add(new ConsultarNiveisAcesso());
                    break;
                case Consultar.Usuarios:
                    Lista.Children.Add(new ConsultarUsuarios());
                    break;
                default:
                    break;
            }
        }
    }
}
