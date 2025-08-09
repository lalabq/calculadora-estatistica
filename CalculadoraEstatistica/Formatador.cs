namespace CalculadoraEstatistica
{
    public static class Formatador
    {
        /// <summary>
        /// Formata o número informado deixando apenas 6 casas decimais, sem arredondar pra cima ou para baixo.
        /// </summary>
        public static decimal Truncar(decimal valor)
        {
            decimal fator = 1000000m;
            return Math.Truncate(valor * fator) / fator;
        }
    }
}
