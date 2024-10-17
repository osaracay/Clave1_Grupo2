using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                tb.Focus();
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
                valid.Text = "✓ válido";
                valid.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            catch (Exception)
            {
                tb.Clear();
                valid.Text = "x inválido";
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
                valid.Text = "✓ válido";
                valid.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            catch (Exception)
            {
                tb.Clear();
                valid.Text = "x inválido";
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
                    tb.Clear();
                    valid.Text = "x inválido";
                    valid.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                valid.Text = "✓ válido";
                valid.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            catch (Exception)
            {
                tb.Clear();
                valid.Text = "x inválido";
                valid.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }
        public static bool CampoEmail(TextBox tb)
        {
            //VALIDACION RECUPERADA DE: https://learn.microsoft.com/es-es/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            string email = tb.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Formato de correo inválido");
                return false;
            }
                
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato de correo inválido");
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        //VALIDAR FECHAS PARA EVITAR FECHAS DE NACIMIENTO MENORES A 18 Años,
        //fechas de cita no disponibles o ya pasadas
        //Si una fecha 1 es mayor que una fecha 2, la fecha 1 es despues de la fecha 2.
        public static bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            if (CalcularEdad(fechaNacimiento) >= 18)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debes ser mayor de edad para registrarte");
                return false;
            }
        }
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            //Metodo recuperado de: https://gist.github.com/Fhernd/26d27f321ef0da4619a7

            // Obtiene la fecha actual:
            DateTime fechaActual = DateTime.Today;

            // Comprueba que la se haya introducido una fecha válida; 

            if (fechaNacimiento <= fechaActual)
            {
                int edad = fechaActual.Year - fechaNacimiento.Year;

                // Comprueba que el mes de la fecha de nacimiento es mayor 
                // que el mes de la fecha actual:
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }

            //si la fecha de nacimiento es mayor a la fecha actual se muestra mensaje 
            // de advertencia:

            MessageBox.Show("Has ingresado una fecha futura.");
            return -1;

        }


    }
}
