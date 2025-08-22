using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencia 
using libOpeUniversidad;
using libRnUniversidad;
namespace appPractica1
{
    public partial class frmUniversidad : Form
    {
        public frmUniversidad()
        {
            InitializeComponent();
        }

        #region Metodos Propios
        private void llenarCombo()
        {
            this.cmbTipoEst.Items.Add("Seleccione tipo Est."); //index = 0
            this.cmbTipoEst.Items.Add("Pregrado"); //index = 1
            this.cmbTipoEst.Items.Add("PostGrado"); //index = 2
            this.cmbTipoEst.SelectedIndex = 0;
        }
        private void Limpiar()
        {
            this.cmbTipoEst.SelectedIndex = 0;
            this.txtCarne.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtPromedio.Text = string.Empty;
            this.gpbRpta.Visible = false;
        }
        private void mensaje(string txt)
        {
            this.txtMsj.Text = txt;
            // MessageBox.Show(txt,"", MessageBoxButtons.OK,MessageBoxIcon.Information ); //Para alertas
        }
        #endregion
        private void frmUniversidad_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int tE, cod;
            string name;
            float pNot;
            try//IMPORTANTE
            {
                cod = Convert.ToInt32(this.txtCarne.Text);
                name = this.txtNombre.Text.Trim();
                tE = this.cmbTipoEst.SelectedIndex;
                pNot = Convert.ToSingle(this.txtPromedio.Text);

                if (cod <= 0)
                {
                    mensaje("Carné no valido");
                    this.txtCarne.Focus();
                    return;
                }
                if (name.Equals(""))
                {
                    mensaje("Falta ingresar el nombre");
                    this.txtNombre.Focus();
                    return;
                }
                if (tE <= 0)
                {
                    mensaje("Debe seleccionar un tipo de estudiante ");
                    this.cmbTipoEst.Focus();
                    return;
                }
                pNot = Convert.ToSingle(this.txtPromedio.Text);
                //Crear el objeto
                clsOpeUniversidad oO = new clsOpeUniversidad();
                oO.IntTipoEst = tE;
                oO.FltPromNota = pNot;
                //Invocar el metodo y tratamiento del error
                if (! oO.hallarPago() )
                    {
                    mensaje(oO.StrError);
                    oO = null;
                    return;
                }
                //Recuperar info
                this.txtNroCred.Text = Convert.ToString(oO.IntNroCred);
                this.txtPorcDscto.Text = oO.FltPorcDscto.ToString();
                this.txtVrCred.Text = oO.FltVrCred.ToString();
                this.txtVrDscto.Text = oO.FltVrDscto.ToString();
                this.txtVrPagar.Text = oO.FltVrPagar.ToString();
                oO = null;
                this.gpbRpta.Visible = true;
                //Mostrar Info
            }
            catch (Exception ex)
            {
                mensaje(ex.Message);
            }
        }

        
    }
}
