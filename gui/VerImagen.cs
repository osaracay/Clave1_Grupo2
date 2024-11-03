using Clave1_Grupo2.dao;
using Clave1_Grupo2.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.gui
{
    public partial class VerImagen : Form
    {
        public VerImagen()
        {
            InitializeComponent();
        }

        private void VerImagen_Load(object sender, EventArgs e)
        {
            UsuarioDAO.CargarImagenAPictureBox(pbPic, UsuarioDAO.GetSesion().IdUsuario);
        }
    }
}
