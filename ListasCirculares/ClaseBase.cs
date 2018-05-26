using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class ClaseBase
    {
        private string _nBase;
        public string NombreBase
        {
            get { return _nBase; }
            set { _nBase = value; }
        }
        private int _time;
        public int Tiempo
        {
            get { return _time; }
            set { _time = value; }
        }

        private ClaseBase _siquiente;
        public ClaseBase Siguente
        {
            get { return _siquiente; }
            set { _siquiente = value; }
        }

        private ClaseBase _anterior;
        public ClaseBase Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public ClaseBase(string nombreBase, int tiempo)
        {
            _nBase = nombreBase;
            _time = tiempo;
        }

        public override string ToString()
        {
            return "Ruta: " + _nBase + " | Tiempo: " + _time;
        }
    }
}
