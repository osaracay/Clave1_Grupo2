using Clave1_Grupo2.dao;
using Clave1_Grupo2.entity;
using Clave1_Grupo2.util;
using System;
using System.Windows.Forms;

namespace Clave1_Grupo2.gui
{    
    public partial class VtnRegistrarUsuario : Form
    {
        private Usuario nuevoUsuario;
        public VtnRegistrarUsuario()
        {
            InitializeComponent();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar formulario lleno
            //Validar campo fecha de nacimiento, debe ser mayor de edad
            //Validar campo email

            //Validar que el username e email sean unicos De por si la BD no va permitir que estos campos sean duplicados porque llevan UNIQUE constraint.
            string pw = CyberSec.HolaCosmos(txtUsrPw.Text);
            MessageBox.Show($"Cantidad de caracteres encrypted: { pw.Length}"); //Necesito saber la cantidad de caracteres antes de hacer el insert
            if (ValidarFormularioLleno() && Validacion.EsMayorDeEdad((DateTime)campoFechaNac.Value) && Validacion.CampoEmail(txtEmail) && pw.Length<=60){
                char genero;
                if (chkFem.Checked)
                {
                    genero = 'F';
                } else if (chkMsc.Checked)
                {
                    genero = 'M';
                }else
                {
                    genero = 'X';
                }                                
                nuevoUsuario = new Usuario(txtNombres.Text, txtApellidos.Text, (DateTime)campoFechaNac.Value, txtEmail.Text, genero, txtUserName.Text, pw);
                /*MessageBox.Show($"Se creo el usuario: \n{nuevoUsuario.Nombre} {nuevoUsuario.Apellido} \nFecha Nacimiento {nuevoUsuario.FechaNac.ToString()}\n" +
                    $"Email: \n {nuevoUsuario.Email} \nGenero {genero} User: {nuevoUsuario.Username} \nPw:{nuevoUsuario.Pw}");*/
                UsuarioDAO.RegistrarCliente(nuevoUsuario);
                MessageBox.Show("Se ha registrado el usuario exitosamente");
                //Limpiar campos
                LimpiarCampos();

                //EN EL MOMENTO QUE SE CREA UN USUARIO EXITOSAMENTE QUIERO ACTUALIZAR LA TABLA RUNTIME DE CLIENTES
                UsuarioDAO.UpdateTblClientes();
                //en lugar de limpiar campos cerrar la ventana.
                this.Close();
            }
            else
            {
                MessageBox.Show("Revise que los campos esten correctos");
            }           
        }

        private bool ValidarFormularioLleno()
        {
            bool valid = Validacion.CampoLleno(txtNombres) && Validacion.CampoLleno(txtApellidos) && Validacion.CampoLleno(txtEmail) 
                && Validacion.CampoLleno(txtUserName) && Validacion.CampoLleno(txtUsrPw);            
            return valid;
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            chkFem.Checked = false;
            chkMsc.Checked = false;
            chkMsc.Checked = false;
            txtUserName.Clear();
            txtUsrPw.Clear();
        }
    }
}
