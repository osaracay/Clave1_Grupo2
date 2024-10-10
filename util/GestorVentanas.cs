using Clave1_Grupo2.gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1_Grupo2.util
{
    class GestorVentanas
    {
        private static VtnIniciarSesion vtnIniciarSesion;
        private static VtnRegistrarUsuario vtnRegistrar;
        private static VtnAgregarMascota vtnAgregarMascota;
        private static VtnAgendarCita vtnAgendar;
        private static VtnInsumo vtnInsumo;
        private static VtnCompra vntCompra;
        private static VtnVenta vntVenta;

        public static void SolicitarRegistroUsuario()
        {
            if (vtnRegistrar == null || vtnRegistrar.IsDisposed)
            {
                vtnRegistrar = null;
                vtnRegistrar = new VtnRegistrarUsuario();
            }
            vtnRegistrar.Show();
            vtnRegistrar.Focus();
        }
        /// <summary>
        /// Metodo que muestra una sola ventana de Iniciar Sesion cuando lo solicite el usuario 
        /// o cuando se desea utilizar una funcion disponible solo para usuarios registrados
        /// </summary>
        public static void SolicitarInicioSesion()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnIniciarSesion == null || vtnIniciarSesion.IsDisposed)
            {
                vtnIniciarSesion = null;
                vtnIniciarSesion = new VtnIniciarSesion();
            }
            vtnIniciarSesion.Show();
            vtnIniciarSesion.Focus();
        }

        public static void AbrirAgregarMascota()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnAgregarMascota == null || vtnAgregarMascota.IsDisposed)
            {
                vtnAgregarMascota = null;
                vtnAgregarMascota = new VtnAgregarMascota();
            }
            vtnAgregarMascota.Show();
            vtnAgregarMascota.Focus();
        }

        public static void AbrirAgendarCita()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnAgendar == null || vtnAgendar.IsDisposed)
            {
                vtnAgendar = null;
                vtnAgendar = new VtnAgendarCita();
            }
            vtnAgendar.Show();
            vtnAgendar.Focus();
        }
        public static void AbrirInsumo()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnInsumo == null || vtnInsumo.IsDisposed)
            {
                vtnInsumo = null;
                vtnInsumo = new VtnInsumo();
            }
            vtnInsumo.Show();
            vtnInsumo.Focus();
        }
        public static void AbrirCompra()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vntCompra == null || vntCompra.IsDisposed)
            {
                vntCompra = null;
                vntCompra = new VtnCompra();
            }
            vntCompra.Show();
            vntCompra.Focus();
        }
        public static void AbrirVenta()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vntVenta == null || vntVenta.IsDisposed)
            {
                vntVenta = null;
                vntVenta = new VtnVenta();
            }
            vntVenta.Show();
            vntVenta.Focus();
        }
    }
}
