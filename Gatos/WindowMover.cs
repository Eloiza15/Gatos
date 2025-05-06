using System.Runtime.InteropServices;

namespace Gatos
{
    // Classe utilitária para permitir o movimento da janela através do mouse
    public static class WindowMover
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Método que realiza a movimentação da janela recebendo um formulário
        public static void Move(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
