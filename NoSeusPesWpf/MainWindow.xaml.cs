using NosSeusPesModel;
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

namespace NoSeusPesWpf
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender == GerenciarPedidos)
            {
                WindowGerenciarPedidos window =
                new WindowGerenciarPedidos();
                window.ShowDialog();
            }

            else if (sender == GerenciarSapatos)
            {
                WindowGerenciarSapatos window =
              new WindowGerenciarSapatos();
                window.ModoCriacaoSapato = false;
                window.ShowDialog();
            }

            else if (sender == GerenciarPessoasJuridicas)
            {
                WindowGerenciarPessoasJuridicas window =
              new WindowGerenciarPessoasJuridicas();
                window.ModoCriacaoPessoasJuridicas = false;
                window.ShowDialog();
            }

            else if (sender == GerenciarPessoasFisicas)
            {
                WindowGerenciarPessoasFisicas window =
              new WindowGerenciarPessoasFisicas();
                window.ModoCriacaoPessoaFisica = false;
                window.ShowDialog();

            }

            else if (sender == NovoPedido)
            {
                WindowGerenciarPedidos window =
               new WindowGerenciarPedidos();
                window.ModoCriacaoPedido = true;
                window.ShowDialog();

            }

            else if (sender == NovoSapato)
            {
                WindowGerenciarSapatos window =
              new WindowGerenciarSapatos();
                window.ModoCriacaoSapato = true;
                window.ShowDialog();
            }

            else if (sender == NovaPessoaJuridica)
            {
                WindowGerenciarPessoasJuridicas window =
              new WindowGerenciarPessoasJuridicas();
                window.ModoCriacaoPessoasJuridicas = true;
                window.ShowDialog();
            }

            else if (sender == NovaPessoaFisica)
            {
                WindowGerenciarPessoasFisicas window =
              new WindowGerenciarPessoasFisicas();
                window.ModoCriacaoPessoaFisica = true;
                window.ShowDialog();
            }
            
            else if(sender == Relatorio_SapatosPedidos)
            {
                ModelPedido ctx = new ModelPedido();
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Relatorio"; // Nome padrão
                dlg.DefaultExt = ".xlsx"; // Extensão do arquivo
                dlg.Filter = "Excel (.xlsx)|*.xlsx"; // Filtros
                Nullable<bool> result = dlg.ShowDialog();

                // Somente irá salvar se o usuário selecionar um arquivo.
                if (result == true)
                {
                    // Salvar Documento
                    ServiceClosedXML.CriarPlanilhaSapatosPedidos(ctx.Pedidos.ToList(), dlg.FileName);
                }
                
            }
           
        }
    }
}