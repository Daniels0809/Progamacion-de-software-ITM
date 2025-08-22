using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referenciar y usar
using libRnUniversidad;
namespace libOpeUniversidad
{
    public class clsOpeUniversidad
    {
        #region Atributos
        private int intTipoEst;
        private float fltPromNota;
        private float fltVrCred;
        private int intNroCred;
        private float fltPorcDscto;
        private float fltVrDscto;
        private float fltVrPagar;
        private string strError;
        #endregion

        #region Propiedades
        //In 
        public int IntTipoEst { set => intTipoEst = value; }
        public float FltPromNota { set => fltPromNota = value; }

        //Out
        public float FltVrCred { get => fltVrCred; }
        public int IntNroCred { get => intNroCred; }
        public float FltPorcDscto { get => fltPorcDscto; }
        public float FltVrDscto { get => fltVrDscto; }
        public float FltVrPagar { get => fltVrPagar; }
        public string StrError { get => strError; }
        #endregion

        #region Constructor
        public clsOpeUniversidad() { }
        public clsOpeUniversidad(int intTipoEst, float fltPromNota, float fltVrCred, int intNroCred, float fltPorcDscto,
            float fltVrDscto, float fltVrPagar, string strError
 )
        {
            this.intTipoEst = intTipoEst;
            this.fltPromNota = fltPromNota;
            this.fltVrCred = fltVrCred;
            this.intNroCred = intNroCred;
            this.fltPorcDscto = fltPorcDscto;
            this.fltVrDscto = fltVrDscto;
            this.fltVrPagar = fltVrPagar;
            this.strError = strError;
        }
        #endregion
        #region Metodos Publico
        public bool hallarPago()
        {
            float subtot = 0;
            try
            {
                //Crear el objeto
                clsRnUniversidad oRn = new clsRnUniversidad();

                //Enviar info
                oRn.tipoEstudiante = intTipoEst; //Mensaje
                oRn.promNota = fltPromNota;
                //Invocar metodo y tto del error
                if (!oRn.hallarDatos())
                {
                    strError = oRn.Error;
                    oRn = null;
                    return false;
                }
                //Recuperar info y realizar proceso 
                fltVrCred = oRn.vrCredito;
                intNroCred = oRn.nroCreditos;
                fltPorcDscto = oRn.porcDscto;
                subtot = intNroCred * fltVrCred;
                fltVrDscto = subtot * fltPorcDscto / 100;
                fltVrPagar = subtot - fltVrDscto;
                oRn = null;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
