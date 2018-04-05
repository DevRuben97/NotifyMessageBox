using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PopUpMessageBox;

namespace TestWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupDuration.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)// Testiar el Mensaje
        {

            string titulo = txttitulo.Text;
            string cuerpo = txtcuerpo.Text;
            Window window = null;

            switch (cbotipo.Text)
            {
                case "Confirmacion":
                    window = new Window(titulo, cuerpo, Window.AlertType.Sucess);
                    break;
                case "Alerta":
                    window = new Window(titulo, cuerpo, Window.AlertType.Warning);
                    break;
                case "Error":
                    window = new Window(titulo, cuerpo, Window.AlertType.Error);
                    break;
                case "Mensaje":
                    window = new Window(titulo, cuerpo, Window.AlertType.Message);
                    break;
                default:
                    window = new Window(titulo, cuerpo, Window.AlertType.Sucess);
                    break;

            }

            if (CheckTime.CheckState== CheckState.Checked)// Verificar Si Se Desea Cambiar la duracion del form.
            {
                int value = Convert.ToInt32(Numsegundos.Value);
                window.Duration = value;
            }

            
            window.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTime.CheckState== CheckState.Checked)
            {
                groupDuration.Visible = true;
            }
            else
            {
                groupDuration.Visible = false;
            }
        }
    }
}
