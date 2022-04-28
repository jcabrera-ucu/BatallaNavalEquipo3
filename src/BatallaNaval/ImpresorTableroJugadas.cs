namespace BatallaNaval
{
    public class ImpresorTableroJugadas
    {
        public static string Imprimir(TableroJugadas tablero)
        {
            string resultado = "";

            for (int y = 0; y < tablero.Tablero.GetLength(1); y++)
            {
                for (int x = 0; x < tablero.Tablero.GetLength(0); x++)
                {
                    if (tablero.Tablero[x, y] == Jugada.Vacio)
                    {
                        resultado += " ";
                    }
                    else if (tablero.Tablero[x, y] == Jugada.Agua)
                    {
                        resultado += "O";
                    }
                    else
                    {
                        resultado += "X";
                    }
                }
            }
            return resultado;
        }
    }
}