using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopUpMessageBox
{
    public partial class Window : Form
    {
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public enum AlertType { Sucess, Warning, Error, Message};
        public int Duration { get; set; }
        private int ScreenTop;
        private int ScreenLeft;

        public Window()
        {
            InitializeComponent();
        }
        public Window(string Titulo, string Mensaje, AlertType type)//Inicializar las variables.
        {
            InitializeComponent();
            this.Titulo = Titulo;
            this.Mensaje = Mensaje;
            this.ScreenTop= Screen.PrimaryScreen.Bounds.Height - this.Height - 50;
            this.ScreenLeft= this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 10;
            this.Duration = 5;
            this.Opacity = 0;
            

            //Comprobar El Tipo de Mensaje
            switch (type)
            {
                case AlertType.Sucess:
                    this.BackColor = Color.FromArgb(44, 139, 89);
                    txtBody.BackColor= Color.FromArgb(44, 139, 89);
                    PictureLogo.Image = Properties.Resources.Sucesswhite;
                    break;
                case AlertType.Error:
                    this.BackColor = Color.FromArgb(181, 41, 42);
                    txtBody.BackColor= Color.FromArgb(181, 41, 42);
                    PictureLogo.Image = Properties.Resources.cancelWhite;
                    break;
                case AlertType.Warning:
                    this.BackColor = Color.FromArgb(255, 131, 5);
                    txtBody.BackColor= Color.FromArgb(255, 131, 5);
                    PictureLogo.Image = Properties.Resources.WarnigWhite;
                    break;
                case AlertType.Message:
                    this.BackColor = Color.FromArgb(132, 132, 132);
                    txtBody.BackColor= Color.FromArgb(132, 132, 132);
                    PictureLogo.Image = Properties.Resources.WarnigWhite;
                    break;
                default:
                    this.BackColor = Color.FromArgb(44, 139, 89);
                    txtBody.BackColor = Color.FromArgb(44, 139, 89);
                    PictureLogo.Image = Properties.Resources.Sucesswhite;
                    break;

            }
            lbntitulo.Text = this.Titulo;
            txtBody.Text = this.Mensaje;
            
        }
        private void CloseAnimation()
        {
            if (this.Opacity >0.0)
            {
                this.Opacity = this.Opacity - 0.05;
            }
            else
            {
                this.Close();
            }
        }
        private void ShowAnimation()
        {
            if (this.Opacity <=0.90)
            {
                this.Opacity = this.Opacity + 0.05;

            }
            else
            {
                this.Showing.Stop();
            }
        }
        private void button1_Click(object sender, EventArgs e)// Cerrar el window con la animacion.
        {
            this.Closing.Enabled = true;
        }

        private void Window_Load(object sender, EventArgs e)
        {
            //Modificar el lugar en donde aparecera el form.
            this.Top = ScreenTop;
            this.Left = ScreenLeft;
            Showing.Enabled = true;

        }


        private void Temporizador_Tick(object sender, EventArgs e)// Cerrar La Ventana con el efecto de opaciadad.
        {
            if (Duration > 0)
            {
                Duration -= 1;
            }
            else
            {
                Temporizador.Interval = 100;
                CloseAnimation();
            }
        }

        private void Showing_Tick(object sender, EventArgs e)
        {
            ShowAnimation();
          
        }

        private void Closing_Tick(object sender, EventArgs e)
        {

            CloseAnimation();

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)//Reactivar el form si el usuario pasa el mouse por el window.
        {
            if (this.Opacity < 0.90)
            {
                this.Opacity = 0.90;
                Temporizador.Enabled = false;
            }
            else
            {
                Temporizador.Enabled = false;
            }
        }

        private void Window_MouseLeave(object sender, EventArgs e)//Reactivar el el temporizador que controla la animacion de cierre.
        {
            if (Temporizador.Enabled== false)
            {
                Temporizador.Enabled = true;
                this.Duration += 3;
            }
        }

        
    }
}
