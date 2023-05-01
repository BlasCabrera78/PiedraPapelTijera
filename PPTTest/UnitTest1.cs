using PPT;

namespace PPTTest
{
    public class UnitTest1
    {

        [Fact]
        public void EmpateTijera()
        {
            Tijera a = new Tijera();
            Tijera b = new Tijera();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Ah sido Empate", resultado);
        }

        [Fact]
        public void EmpatePiedra()
        {
            Piedra a = new Piedra();
            Piedra b = new Piedra();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Ah sido Empate", resultado);
        }

        [Fact]
        public void EmpatePapel()
        {
            Papel a = new Papel();
            Papel b = new Papel();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Ah sido Empate", resultado);
        }

        [Fact]
        public void GanaTijera()
        {
            Tijera a = new Tijera();
            Papel b = new Papel();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Has ganado", resultado);
        }

        [Fact]
        public void GanaPapel()
        {
            Papel a = new Papel();
            Piedra b = new Piedra();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Has ganado", resultado);
        }

        [Fact]
        public void GanaPiedra()
        {
            Piedra a = new Piedra();
            Tijera b = new Tijera();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Has ganado", resultado);
        }

        [Fact]
        public void PierdePiedra()
        {
            Piedra a = new Piedra();
            Papel b = new Papel();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Has perdido", resultado);
        }


        [Fact]
        public void PierdePapel()
        {
            Papel a = new Papel();
            Tijera b = new Tijera();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Has perdido", resultado);
        }


        [Fact]
        public void PierdeTijera()
        {
            Tijera a = new Tijera();
            Piedra b = new Piedra();
            var resultado = a.JuegaCon(b);
            Assert.Equal("Has perdido", resultado);
        }
    }
}
