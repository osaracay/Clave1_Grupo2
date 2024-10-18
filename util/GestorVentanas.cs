using Clave1_Grupo2.gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo2.util
{
    class GestorVentanas
    {
        private static VtnIniciarSesion vtnIniciarSesion;
        private static VtnRegistrarUsuario vtnRegistrar;
        private static VtnPerfilUsuario vtnPerfil;
        private static VtnAgregarMascota vtnAgregarMascota;
        private static VtnMascotas vtnMascotas;
        private static VtnAgendarCita vtnAgendar;
        private static VtnCitas vtnCitas;
        private static VtnInsumo vtnInsumo;
        private static VtnCompra vntCompra;
        private static VtnVenta vntVenta;
        private static VntTipoInsumo vntTpInsumo;
        private static VtnConsultaVenta vntConsVenta;

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
            vtnIniciarSesion.ShowDialog();
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

        public static void AbrirVtnMascotas()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnMascotas == null || vtnMascotas.IsDisposed)
            {
                vtnMascotas = null;
                vtnMascotas = new VtnMascotas();
            }
            vtnMascotas.Show();
            vtnMascotas.Focus();
        }
        public static void AbrirVtnCitas()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnCitas == null || vtnCitas.IsDisposed)
            {
                vtnCitas = null;
                vtnCitas = new VtnCitas();
            }
            vtnCitas.Show();
            vtnCitas.Focus();
        }

        public static void AbrirMiPerfil()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vtnPerfil == null || vtnPerfil.IsDisposed)
            {
                vtnPerfil = null;
                vtnPerfil = new VtnPerfilUsuario();
            }
            //No quiero que el usuario pueda cerrar sesion mientras se encuentre abierta esta ventana a no ser que agregue un boton desde aqui y cierre la ventana en su evento click
            vtnPerfil.ShowDialog(); 
            vtnPerfil.Focus();
        }
        public static void AbrirTipoInsumo()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vntTpInsumo == null || vntTpInsumo.IsDisposed)
            {
                vntTpInsumo = null;
                vntTpInsumo = new VntTipoInsumo();
            }
            vntTpInsumo.Show();
            vntTpInsumo.Focus();
        }
        public static void AbrirConsVenta()
        {
            //SI NO EXISTE EL OBJETO SESION GLOBAL
            if (vntConsVenta == null || vntConsVenta.IsDisposed)
            {
                vntConsVenta = null;
                vntConsVenta = new VtnConsultaVenta();
            }
            vntConsVenta.Show();
            vntConsVenta.Focus();
        }
    }
}
