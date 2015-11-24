using SistemaHorarios.WPF.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaHorarios.WPF.Telas.Cadastro
{
    public partial class CadastrarDiasDaSemana : UserControl
    {
        ModoDeTela modo = ModoDeTela.Cancelar;

        //Muda modo da tela
        private void mudarModo(ModoDeTela modo)
        {
            switch (modo)
            {
                case ModoDeTela.Novo:
                    TextBoxCodigo.Text = "";
                    TextBoxNome.Text = "";
                    TextBoxNome.IsEnabled = true;

                    BotaoConfirmar.IsEnabled = true;
                    BotaoCancelar.IsEnabled = true;

                    BotaoNovo.IsEnabled = false;
                    BotaoEditar.IsEnabled = false;
                    BotaoExcluir.IsEnabled = false;
                    break;

                case ModoDeTela.Editar:
                    TextBoxNome.IsEnabled = true;
                    TextBoxNome.IsEnabled = true;

                    BotaoConfirmar.IsEnabled = true;
                    BotaoCancelar.IsEnabled = true;

                    BotaoNovo.IsEnabled = false;
                    BotaoEditar.IsEnabled = false;
                    BotaoExcluir.IsEnabled = false;
                    break;

                case ModoDeTela.Cancelar:
                    TextBoxCodigo.Text = "";
                    TextBoxNome.Text = "";
                    TextBoxNome.IsEnabled = false;

                    BotaoConfirmar.IsEnabled = false;
                    BotaoCancelar.IsEnabled = false;

                    BotaoNovo.IsEnabled = true;
                    BotaoEditar.IsEnabled = false;
                    BotaoExcluir.IsEnabled = false;
                    break;

                case ModoDeTela.Selecionado:
                    //verifica se há algum item selecionado na lista
                    if (Lista.SelectedItems.Count > 1)
                    {
                        MessageBox.Show("Selecione apenas um elemento da lista!");
                        return;
                    }

                    //Aloca o objeto selecionado
                    var item = Lista.Items.GetItemAt(Lista.SelectedIndex) as DiaDaSemana;

                    TextBoxCodigo.Text = item.Codigo.ToString();
                    TextBoxNome.Text = item.Descricao.ToString();
                    TextBoxCodigo.IsEnabled = false;
                    TextBoxNome.IsEnabled = false;

                    BotaoConfirmar.IsEnabled = false;
                    BotaoCancelar.IsEnabled = true;


                    BotaoNovo.IsEnabled = false;
                    BotaoEditar.IsEnabled = true;
                    BotaoExcluir.IsEnabled = true;
                    break;

                default:
                    break;
            }
            //Atribui o modo recebido à variável da tela
            this.modo = modo;
        }

        private async void Lista_Loaded(object sender, RoutedEventArgs e)
        {
            AtualizarLista();
        }

        private void Lista_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mudarModo(ModoDeTela.Selecionado);
        }

        private void BotaoConfirmar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Verifica o modo atual da tela
                switch (modo)
                {
                    case ModoDeTela.Novo:
                        using (var context = new Proxy.SistemaHorariosServiceClient())
                        {
                            var item = new DiaDaSemana() { Descricao = TextBoxNome.Text };
                            context.AddDiaDaSemana(item);
                        }
                        break;

                    case ModoDeTela.Editar:
                        using (var context = new Proxy.SistemaHorariosServiceClient())
                        {
                            var item = new DiaDaSemana()
                            {
                                Codigo = Convert.ToInt16(TextBoxCodigo.Text),
                                Descricao = TextBoxNome.Text
                            };
                            context.UpdateDiaDaSemana(item);
                        }
                        break;

                    default:
                        MessageBox.Show("Modo de tela inválido!");
                        break;
                }

                MessageBox.Show("Registro atualizado/cadastrado com sucesso! =)");

                AtualizarLista();

                //Seta o modo da tela para o modo standard
                mudarModo(ModoDeTela.Cancelar);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao criar/atualizar registro");
            }
        }

        private void BotaoCancelar_Click(object sender, RoutedEventArgs e)
        {
            mudarModo(ModoDeTela.Cancelar);
        }

        private void BotaoNovo_Click(object sender, RoutedEventArgs e)
        {
            mudarModo(ModoDeTela.Novo);
            TextBoxNome.Focus();
        }

        private void BotaoEditar_Click(object sender, RoutedEventArgs e)
        {
            mudarModo(ModoDeTela.Editar);
        }

        private void BotaoExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Aviso", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                try
                {
                    //Tenta deletar o registro
                    using (var context = new Proxy.SistemaHorariosServiceClient())
                    {
                        var item = new DiaDaSemana()
                        {
                            Codigo = Convert.ToInt16(TextBoxCodigo.Text),
                            Descricao = TextBoxNome.Text
                        };
                        context.DeleteDiaDaSemana(item);
                    }

                    MessageBox.Show("Registro deletado com sucesso! =)");

                    AtualizarLista();

                    //Seta o modo da tela para o modo standard
                    mudarModo(ModoDeTela.Cancelar);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao deletar o registro");
                }
            }
        }

        private async void BotaoAtualizar_Click(object sender, RoutedEventArgs e)
        {
            AtualizarLista();
        }

        public async void AtualizarLista()
        {
            //Atualiza a lista da tela
            Lista.ItemsSource = null;

            await Task.Delay(1);

            using (var context = new Proxy.SistemaHorariosServiceClient())
            {
                Lista.ItemsSource = context.GetDiasDaSemana();
            }
        }

        public CadastrarDiasDaSemana()
        {
            InitializeComponent();
        }
    }
}
