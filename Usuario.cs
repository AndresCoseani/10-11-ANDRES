using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_ANDRES
{
    class Usuario
    {
        private int _UserID;
        private string _UserName;
        private int _Edad;

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public string UserName
        {
            get { return _UserName; }//devuelve nombre
            set { _UserName = value; }//asigna nombre
        }
        public int Edad
        {
            get { return _Edad; }//devuelve edad
            set { _Edad = value; }//asigna edad
        }

    }
}
