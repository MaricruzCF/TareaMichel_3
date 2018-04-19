using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaMichel_3
{
    class Producto
    {
        private string[] _v;


        public Producto()
        {
            _v = new string[15];

        }
        public void agregar()
        {

        }
        public string buscar(int valor)
        {
            for (int i = 0; i < 15; i++)
                if (valor.ToString() == _v[i])
                    return _v[i];
                return "No econtrado";
        }
        public void eliminar(int pos)
        {
            
            for (int i = pos; i < _v.Length -1; i++)
                _v[i] = _v[i + 1];
            
        }
        public void insertar(int pos, string id, string nomb, string descr, string cant, string costo)
        {
            for (int i = _v.Length; i < pos-1; i++)
                _v[i] = _v[i-1];
            _v[i] = id +"  "+nomb+" "+descr+"  "+cant+" "+costo;

        }
        public string lista()
        {
            string l="";
            for (int i = 0; i < _v.Length; i++)
                l += _v[i].ToString() + Environment.NewLine;
            return l;
        }
    }
}
