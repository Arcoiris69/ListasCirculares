using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Estructura
    {
        ClaseBase inicio = null, ultimo = null;

        public void Agregar(ClaseBase nuevo)
        {
            ClaseBase t = inicio;

            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
                inicio.Anterior = ultimo;
                ultimo.Siguente = inicio;
            }

            else
            {
                nuevo.Anterior = ultimo;
                ultimo.Siguente = nuevo;
                ultimo = nuevo;
                inicio.Anterior = ultimo;
                ultimo.Siguente = inicio;
            }
        }

        public ClaseBase Buscar(string nombre)
        {
            ClaseBase t = inicio;

            while (t.Siguente != inicio)
            {
                if (t.NombreBase == nombre)
                {
                    return t;
                }
                t = t.Siguente;
            }
            if (t.NombreBase == nombre)
            {
                return t;
            }
            return null;
        }

        public ClaseBase EliminarUltimo()
        {
            ClaseBase t = inicio, p = null, r = null;
            if (inicio == ultimo)
            {
                r = ultimo;
                r.Anterior = r.Siguente = null;
                inicio = null;
                ultimo = null;
            }
            else
            {
                p = ultimo.Anterior;
                p.Siguente = null;
                ultimo.Anterior = null;
                r = ultimo;
                r.Anterior = r.Siguente = null;
                ultimo = p;
                ultimo.Siguente = inicio;
            }
            return r;
        }

        public ClaseBase EliminarInicio()
        {
            ClaseBase t = inicio, r = null;
            if (ultimo == inicio)
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio = null;
                ultimo = null;
            }
            else
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio = inicio.Siguente;
                ultimo.Siguente = inicio;
                inicio.Anterior = ultimo;
            }
            return r;
        }

        public string listar()
        {
            string output = "";
            ClaseBase t = inicio;
            if (inicio == null)
            {
                output = "error 404 Base not found";
            }
            else
            {
                while (t.Siguente != inicio)
                {
                    output += t.ToString() + "\r\n";
                    t = t.Siguente;
                }
                output += t.ToString() + "\r\n";
            }
            return output;
        }

        public void Insertar(ClaseBase nuevo, int pos)
        {
            ClaseBase t = inicio;
            int c = 1;


            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            }

            else
            {
                while (c != pos)
                {
                    t = t.Siguente;
                    c++;
                    if (t == inicio)
                    {
                        break;
                    }
                }
                if (c == pos)
                {
                    t.Anterior.Siguente = nuevo;
                    nuevo.Anterior = t.Anterior;
                    t.Anterior = nuevo;
                    nuevo.Siguente = t;
                    if (c == 1)
                    {
                        inicio = nuevo;
                    }
                }
            }
        }

        public ClaseBase Eliminar(string nombre)
        {
            ClaseBase t = inicio, r = null;
            if (inicio.NombreBase == ultimo.NombreBase)
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio = null;
                ultimo = null;
            }

            else if (inicio.NombreBase == nombre)
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio.Anterior.Siguente = inicio.Siguente;
                inicio.Siguente.Anterior = ultimo;
                inicio = inicio.Siguente;
            }
            else if (ultimo.NombreBase == nombre)
            {
                r = ultimo;
                r.Anterior = r.Siguente = null;
                ultimo.Anterior.Siguente = inicio;
                ultimo.Siguente.Anterior = ultimo.Anterior;
                ultimo = ultimo.Anterior;
            }
            else
            {
                while (t.Siguente != inicio)
                {
                    if (t.NombreBase == nombre)
                    {
                        r = t;
                        r.Anterior = r.Siguente = null;
                        t.Anterior.Siguente = t.Siguente;
                        t.Siguente.Anterior = t.Anterior;
                    }
                    t = t.Siguente;
                }
            }
            return r;
        }

        public string Ruta(string nombreBase, DateTime hinicio, DateTime hfin)
        {
            ClaseBase t = inicio;
            DateTime _base;
            string res = "";

            while (t.NombreBase != nombreBase)
            {
                t = t.Siguente;
                if (t == inicio)
                {
                    break;
                }
            }
            if (t.NombreBase == nombreBase)
            {
                _base = hinicio;
                res = "Info " + t.NombreBase + ", " + _base.ToShortTimeString() + "\r\n";
                while (_base < hfin)
                {
                    t = t.Siguente;
                    _base = _base.AddMinutes(t.Tiempo);
                    res += "Info " + t.NombreBase + ", " + _base.ToShortTimeString() + "\r\n";
                }
            }

            return res;
        }
    }
    }
