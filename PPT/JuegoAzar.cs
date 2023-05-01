using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
     public class JuegoAzar
    {
        public String tipo { get; set; }

        public String JuegaCon(JuegoAzar a)
        {
            if (this.tipo == a.tipo)
            {
                return "Ah sido Empate";
            }

            else if ((this.tipo == "Piedra" && a.tipo == "Tijera") ||
                    (this.tipo == "Papel" && a.tipo == "Piedra") ||
                    (this.tipo == "Tijera" && a.tipo == "Papel"))
            {
                return "Has ganado";
            }

            else { return "Has perdido"; }

        }



    }
}

