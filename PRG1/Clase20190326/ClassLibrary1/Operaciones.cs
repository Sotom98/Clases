using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class Operaciones {
        public double v1, v2, resul;

        public double Suma() {
            resul = v1 + v2;
            return resul;
        }

        public double Resta() {
            resul = v1 - v2;
            return resul;
        }

        public double Multi() {
            resul = v1 * v2;
            return resul;
        }

        public double Divi() {
            resul = v1 / v2;
            return resul;
        }

    }
}
