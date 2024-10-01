using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class docentes : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public docentes()
        {
            InitializeComponent();
        }
        private void docentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["docentes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idDocente"] };
            //MUESTRA LOS DATOS EN LA TABLA
            grdDatosDocentes.DataSource = miTabla;
            mostrarDatosDocentes();
        }

        //Muestra los datos en el grudbox
        private void mostrarDatosDocentes()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoDocentes.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreDocentes.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtMateria1Docentes.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtMateria2Docentes.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtNivelAcademicoDocentes.Text = miTabla.Rows[posicion].ItemArray[5].ToString();
                cmbEspecialidadDocente.Text = miTabla.Rows[posicion].ItemArray[6].ToString();

                lblRegistrosDocentes.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        //-----------------

        private void btnPrimeroDocentes_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosDocentes();
        }

        private void btnSiguienteDocentes_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosDocentes();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocentes_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosDocentes();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocentes_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosDocentes();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosDocentes.Enabled = estado;
            grbNavegacionDocentes.Enabled = !estado;
            btnEliminarDocentes.Enabled = !estado;
        }
        private void btnNuevoDocentes_Click(object sender, EventArgs e)
        {
            if (btnNuevoDocentes.Text == "Nuevo")
            {
                btnNuevoDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] docentes = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtCodigoDocentes.Text, txtNombreDocentes.Text, txtMateria1Docentes.Text, txtMateria2Docentes.Text, txtNivelAcademicoDocentes.Text, cmbEspecialidadDocente.Text
                };
                //Conexión entre la base de datos y los cambios que hagamos
                String respuesta = objConexion.administrarDocentes(docentes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoDocentes.Text = "Nuevo";
                    btnModificarDocentes.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }

            void limpiarCajas()
            {
                txtCodigoDocentes.Text = "";
                txtNombreDocentes.Text = "";
                txtMateria1Docentes.Text = "";
                txtMateria2Docentes.Text = "";
                txtNivelAcademicoDocentes.Text = "";
            }
        }

        private void btnModificarDocentes_Click(object sender, EventArgs e)
        {
            if (btnModificarDocentes.Text == "Modificar")
            {
                btnNuevoDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);

            }
            else
            {//Cancelar
                mostrarDatosDocentes();
                btnNuevoDocentes.Text = "Nuevo";
                btnModificarDocentes.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarDocentes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocentes.Text.Trim() + "?", "Eliminar Docentes", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] docentes = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarDocentes(docentes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosDocentes();
                }
            }
        }
        //Para buscar
        private void filtrarDatosDocentes(String filtroDocente)
        {
            //Se crea una vista de los datos donde al mismo tiempo se van filtrando
            DataView dv = miTabla.DefaultView;
            //Like busca una coincidencia
            //las comillas simples y el signo de porcentaje quiere decir que sin importar la ubicación de la busqueda que muestre el dato solicitado '%" "%'
            dv.RowFilter = "codigo like '%" + filtroDocente + "%' OR nombre like '%" + filtroDocente + "%'";
            grdDatosDocentes.DataSource = dv;

        }
        //Si no agarra tienes que usar el evento keyUp en el txtBuscar
        private void txtBuscarDocentes_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatosDocentes(txtBuscarDocentes.Text);
            //if (e.KeyValue == 13) {//tecla enter
            seleccionarDocentes();
            //}
        }
        private void seleccionarDocentes()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosDocentes.CurrentRow.Cells["idDocente"].Value.ToString()));
            mostrarDatosDocentes();
        }
        private void grdDatosDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocentes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------
    }
}
