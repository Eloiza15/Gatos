using System;
using System.Windows.Forms;

namespace Gatos
{
    public partial class Gatos : Form
    {
        // Inst�ncia da classe respons�vel por buscar imagens de gatos
        private readonly CatService _catService = new CatService();

        public Gatos()
        {
            InitializeComponent();
        }

        // Ao clicar no X fecha a aplica��o
        private void pbxFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ao clicar no Minimizar - minimiza a aplica��o
        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Faz o movimento da janela atrav�s do Panel Superior
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // Chama m�todo utilit�rio que movimenta o formul�rio
            WindowMover.Move(this);
        }

        // Ao clicar no bot�o, chama o m�todo ass�ncrono para buscar a imagem do gato
        private async void btnGetCat_Click(object sender, EventArgs e)
        {
            await LoadRandomCatImageAsync();
        }

        // M�todo ass�ncrono que usa o CatService para obter e exibir a imagem do gato
        private async Task LoadRandomCatImageAsync()
        {
            try
            {
                // Obt�m a URL da imagem do gato
                string imageUrl = await _catService.GetRandomCatImageUrlAsync();

                // Carrega a imagem diretamente no PictureBox
                pictureBoxCat.Load(imageUrl);
            }
            catch (Exception ex)
            {
                // Em caso de erro (ex: conex�o falhou), exibe uma mensagem para o usu�rio
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }
        }
    }
}
