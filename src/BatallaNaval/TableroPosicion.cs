namespace BatallaNaval
{
    public enum Posicion
    {
        Vacio,
        BarcoA,
        BarcoB,
        BarcoC,
        BarcoD,
    }

    public enum Intento
    {
        Agua,
        Tocado,
        Hundido,
    }

    public class TableroPosicion
    {
        public Posicion[,] Tablero { get; }

        TableroPosicion(int ancho, int alto)
        {
            Tablero = new Posicion[ancho, alto];
        }

        public Intento Atacar(int x, int y)
        {
            var celda = Tablero[x, y];
            if (celda == Posicion.Vacio)
            {
                return Intento.Agua;
            }
            else
            {
                Tablero[x, y] = Posicion.Vacio;
                return EstaHundidoBarco(celda);
            }
        }

        private Intento EstaHundidoBarco(Posicion barco)
        {
            foreach (var celda in Tablero)
            {
                if (celda == barco)
                {
                    return Intento.Tocado;
                }
            }
            return Intento.Hundido;
        }
    }
}