using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class otro : Form
    {
        private string usuario = "";
        public otro()
        {
            InitializeComponent();
            CenterToScreen();
            //Parametrización navegador
            /*arreglo de textboxs*/
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            //definicion de textboxs, tabla y BD
            navegador1.funAsignarAliasVista(alias, "trasladoproducto", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //definicion del campo de estado / para dar de bajars
            navegador1.campoEstado = "estado";

            //el id de aplicacion para ayudas y reportes, quedara obsoleto en la nueva version
            navegador1.idAplicacion = "1001";//en la nueva se usara el nombre

            //-- Estos atributos no cambian
            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda

            // Inicio datos para ejecurar reportes
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes
            //-- fin de atributos no cambiantes

            //enviar el data grid view para la navegación
            navegador1.pideGrid(this.txtId);
            //llena el data grid
            navegador1.llenaTabla();
            //pide la referencia a la form para poder cerrarla
            navegador1.pedirRef(this);
            //FALTA USUARIO Y ACTUALIZAR PERSMISOS

            //Para las combo boxes
            //Parametros: La combo box, la tabla, el id de la tabla, el valor a mostrar, y el campo de estado
            navegador1.funLlenarComboControl(cmbEmpleado, "bodega", "pkid", "nombre", "estado");
            navegador1.funLlenarComboControl(cmbDestino, "bodega", "pkid", "nombre", "estado");
            navegador1.funLlenarComboControl(cmbidproducto, "producto", "pkid", "Nombre", "estado");

        }
        //Actualización de permisos que se debe realizar después de tener la variable usuario ingresada
        public void funActualizarUsuario(string user)
        {
            //colocamos el nombre del usuario
            usuario = user;
            //y ya con el nombre del usuario podemos actualizar los permisos
            navegador1.usuario = user;
            navegador1.aplicacion = "Traslado";//nombre de la app en seguridad
            navegador1.funActualizarPermisos();//actualizamos los permisos
            navegador1.idmodulo = "5";//7 es contabilidad
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

        }

        private void dvgCuentas_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(txtId);
        }


        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cmbEmpleado, txtEmpleado);
        }

        private void txtTipoCuenta_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cmbEmpleado, txtEmpleado);
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cmbDestino, txtDestino);
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cmbDestino, txtDestino);
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cmbidproducto, txtidproducto);
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cmbidproducto, txtidproducto);
        }

        private void btnGuardarFechaSalida(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtsalida.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtsalida.Text = dt;
            // MessageBox.Show(txtFecha.Text);
        }
        private void dtFechaEmision_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtsalida, txtsalida);
        }

        private void txtFechaEm_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtsalida, txtsalida);
            navegador1.funDPTextBoxVista(dtsalida, txtsalida);
        }

        private void btnGuardarFechaentrada(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtentrada.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtentrada.Text = dt;
            // MessageBox.Show(txtFecha.Text);
        }
        private void dtFechaentrada_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtentrada, txtentrada);
        }

        private void txtFechaentrada_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtentrada, txtentrada);
            navegador1.funDPTextBoxVista(dtentrada, txtentrada);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbActivo, "A");
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbInactivo, "I");
        }


    }
}
