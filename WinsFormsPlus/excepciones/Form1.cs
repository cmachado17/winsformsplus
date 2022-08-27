using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtNumero1.Text);
                b = int.Parse(txtNumero2.Text);

                r = a / b;

                lblResultado.Text = "= " + r;
            }
            //catch (FormatException ex) // como se q va a ser un format excepcion ya pude armar una excepcion pensando en eso
            //{
            //    MessageBox.Show("Por favor cargar solo numero");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    MessageBox.Show("No se puede dividir por 0");
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido..");
            }
            finally // se ejecutan las instrucciones que contengan... por ejemplo si tengo una apertura de BD y tengo una excepcion posteriormente, necesito cerrarla, por eso es buena llevarla aca.
            {
                //instrucciones que necesito que se ejecuten si o si.
                //operacion sensible.

            }
        }

        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtNumero1.Text);
                b = int.Parse(txtNumero2.Text);

                r = a / b;

                return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
