using SistemaHorarios.Client.ViewModel;
using System.Collections.Generic;
using System.Windows.Controls;
using SistemaHorarios.Client.View.Telas;

namespace SistemaHorarios.Client.View
{
    /// <summary>
    /// Interaction logic for SeletorCadastros.xaml
    /// </summary>
    public partial class SeletorCadastros : UserControl
    {
        public SeletorCadastros()
        {
            this.DataContext = new SeletorCadastrosViewModel();
            InitializeComponent();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var choice = (KeyValuePair<string, Cadastrar>)Combo.SelectedItem;
            Lista.Children.Clear();

            switch (choice.Value)
            {
                case Cadastrar.Cursos:
                    Lista.Children.Add(new CadastrarCurso());
                    break;
                case Cadastrar.Grades:
                    Lista.Children.Add(new CadastrarGrade());
                    break;
                case Cadastrar.Horarios:
                    Lista.Children.Add(new CadastrarHorario());
                    break;
                case Cadastrar.Materias:
                    Lista.Children.Add(new CadastroMateria());
                    break;
                case Cadastrar.Periodos:
                    Lista.Children.Add(new CadastrarPeriodo());
                    break;
                case Cadastrar.Professores:
                    Lista.Children.Add(new CadastrarProfessor());
                    break;
                case Cadastrar.NiveisAcesso:
                    Lista.Children.Add(new CadastrarNiveisAcesso());
                    break;
                case Cadastrar.Usuarios:
                    Lista.Children.Add(new CadastrarUsuario());
                    break;
                default:
                    break;
            }
        }
    }
}
