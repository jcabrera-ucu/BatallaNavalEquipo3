namespace BatallaNaval
{
    public enum Jugada {
        Vacio,
        Agua,
        Tocado,
        Hundido,
    }

    public class TableroJugadas {
        public Jugada[,] Tablero { get; }

        TableroJugadas(int ancho, int alto)
        {
            Tablero = new Jugada[ancho, alto];
        }
    }
}