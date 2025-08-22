using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRnUniversidad
{
    public class clsRnUniversidad
    {
        #region Atributos

        private int intTipoEst, intNroCredit;
        private float fltPromNot, fltVrCredit, fltPorcDesc;
        private string strError;

        #endregion
        //Propiedades
        //In
        public int tipoEstudiante
        {
            set { intTipoEst = value; }
        }
        public float promNota
        {
            set { fltPromNot = value; }
        }

        //Out
        public float vrCredito
        {
            get { return fltVrCredit; }
        }
        public int nroCreditos
        {
            get { return intNroCredit; }
        }
        public float porcDscto
        {
            get { return fltPorcDesc; }
        }
        public string Error
        {
            get { return strError; }
        }
        #region Constructor
        public clsRnUniversidad()
        {
            intTipoEst = 0;
            intNroCredit = 0;
            fltPromNot = 0;
            fltVrCredit = 0;
            fltPorcDesc = 0;
            strError = string.Empty;
        }
        #endregion
        #region Metodos Privados
        private bool Validar()
        {
            if (intTipoEst != 1 && intTipoEst != 2)
            {
                strError = "Tipo de estudiante no valido";
                return false;
            }
            if (fltPromNot < 0 || fltPromNot > 5)
            {
                strError = "Promedio de nota no valido";
                return false;
            }
            return true;
        }
        private bool leerArchivo()
        {
            if (!Validar())
                return false;

            try
            {
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "Descuentos.txt");
                string carpeta = Path.GetDirectoryName(ruta); // Verificamos si la carpeta existe, o si no, se crea

                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                if (!File.Exists(ruta))
                {
                    strError = "El archivo no existe.";
                    return false;
                }

                string[] lineas = File.ReadAllLines(ruta);
                // Este método se encarga de abrir, leer todas las líneas del archivo y luego cerrar el archivo automáticamente.
                foreach (string rgtro in lineas)
                {
                    string[] datos = rgtro.Split(';');
                    if (int.Parse(datos[0]) == intTipoEst && fltPromNot >= float.Parse(datos[1]))
                    {
                        fltVrCredit = float.Parse(datos[2]);  // Valor Crédito
                        intNroCredit = int.Parse(datos[3]);   // Cantidad Créditos
                        fltPorcDesc = float.Parse(datos[4]);  // Porcentaje de Dscto
                        break;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
        #region Metodos Publicos 
        public bool hallarDatos()
        {
            return leerArchivo();
        }
        #endregion
    }
}
