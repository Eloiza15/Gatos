using System;
using System.Windows.Forms;

namespace Gatos
{
    public partial class Gatos : Form
    {
        // Instância da classe responsável por buscar imagens de gatos
        private readonly CatService _catService = new CatService();

        public Gatos()
        {
            InitializeComponent();
        }

        // Ao clicar no X fecha a aplicação
        private void pbxFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ao clicar no Minimizar - minimiza a aplicação
        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Faz o movimento da janela através do Panel Superior
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // Chama método utilitário que movimenta o formulário
            WindowMover.Move(this);
        }

        // Ao clicar no botão, chama o método assíncrono para buscar a imagem do gato
        private async void btnGetCat_Click(object sender, EventArgs e)
        {
            await LoadRandomCatImageAsync();
        }

        // Método assíncrono que usa o CatService para obter e exibir a imagem do gato
        private async Task LoadRandomCatImageAsync()
        {
            try
            {
                // Obtém a URL da imagem do gato
                string imageUrl = await _catService.GetRandomCatImageUrlAsync();

                // Carrega a imagem diretamente no PictureBox
                pictureBoxCat.Load(imageUrl);
            }
            catch (Exception ex)
            {
                // Em caso de erro (ex: conexão falhou), exibe uma mensagem para o usuário
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }
        }
    }
}
