using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_Position
{
    public partial class FrmMousePosition : Form
    {
        public FrmMousePosition()
        {
            InitializeComponent();
        }

        int positionX;
        int positionY;
        private void timerMousePosition_Tick(object sender, EventArgs e)
        {
            positionX = MousePosition.X;
            positionY = MousePosition.Y;

            LblMousePosition.Text = $"Mouse Position: {positionX} x {positionY}";

            if(BackColor == Color.DarkGreen)
                BackColor = Color.FromArgb(20, 20, 20);
        }
        private void FrmMousePosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if(e.KeyCode == Keys.Tab)
            {
                Clipboard.SetText(LblMousePosition.Text);
                BackColor = Color.DarkGreen;
            }
            else if(e.KeyCode == Keys.H)
            {
                MessageBox.Show("Welcome to Mouse Position\n\n" +
                                "[+] ESC - Close app\n" +
                                "[+] TAB - Copy Position\n" +
                                "[+] Version: 1.0\n\n" +
                                "Naldo Santos",
                                "Mouse Position - HELP", // Title MessageBox
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
    }
}
