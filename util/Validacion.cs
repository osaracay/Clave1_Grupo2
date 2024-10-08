using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.util
{
    class Validacion
    {
        public static bool CampoLleno(TextBox tb)
        {
            if (tb.Text == "")
            {
                return false;
            }
            return true;
        }

        public static bool CampoDouble(TextBox tb, Label valid)
        {
            double valor;
            try
            {
                valor = double.Parse(tb.Text = tb.Text.Trim());
                valid.Text = "valido";
                valid.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            catch (Exception ex)
            {
                tb.Text = "";
                valid.Text = "invalido";
                valid.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        public static bool CampoNumEntero(TextBox tb, Label valid)
        {
            int valor;
            try
            {
                valor = int.Parse(tb.Text = tb.Text.Trim());
                valid.Text = "valido";
                valid.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            catch (Exception ex)
            {
                tb.Text = "";
                valid.Text = "invalido";
                valid.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        public static bool CampoNumEntero(TextBox tb, Label valid, int min, int max)
        {
            int valor;
            try
            {

                valor = int.Parse(tb.Text = tb.Text.Trim());
                if (valor < min || valor > max)
                {
                    tb.Text = "";
                    valid.Text = "invalido";
                    valid.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                valid.Text = "valido";
                valid.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            catch (Exception ex)
            {
                tb.Text = "";
                valid.Text = "invalido";
                valid.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }
    }
}
