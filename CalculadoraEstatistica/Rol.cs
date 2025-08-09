using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraEstatistica
{
    public class Rol
    {
        public List<long> Dados { get; set; }

        public decimal Media
        {
            get
            {
                return Formatador.Truncar((decimal)Dados.Sum(x => x) / Dados.Count);
            }
        }

        public decimal Mediana
        {
            get
            {
                var posicao = ((decimal)Dados.Count + 1) / 2;

                if (posicao != Math.Truncate(posicao))
                {
                    return (Dados[(int)posicao] + Dados[(int)posicao + 1]) / 2;
                }

                return Dados[(int)posicao];
            }
        }

        public string Moda
        {
            get
            {
                var numerosOrdenadosPorMaiorOcorrencia = Dados.GroupBy(x => x).OrderByDescending(x => x.Count());
                var qtdeDeOcorrenciasDoNumeroMaisOcorrente = numerosOrdenadosPorMaiorOcorrencia.First().Count();
                var modas = numerosOrdenadosPorMaiorOcorrencia.Where(x => x.Count() == qtdeDeOcorrenciasDoNumeroMaisOcorrente);
                
                return string.Join(", ", modas.Select(x => x.Key));
            }
        }

        public decimal Variancia
        {
            get
            {
                decimal soma = 0;
                var rolSemRepeticoes = Dados.GroupBy(x => x).Select(x => x.Key);

                foreach (var numero in rolSemRepeticoes)
                {
                    var qtdeVezesQueNumeroSeRepete = Dados.Count(x => x == numero);
                    var calculo = qtdeVezesQueNumeroSeRepete * ((numero - Media) * (numero - Media));
                    soma += calculo;
                }

                return Formatador.Truncar(soma / Dados.Count);
            }
        }

        public decimal DesvioPadrao
        {
            get
            {
                return Formatador.Truncar((decimal)Math.Sqrt((double)Variancia));
            }
        }

        public decimal CoeficienteDaVariacao
        {
            get
            {
                return Formatador.Truncar((DesvioPadrao / Media) * 100);
            }
        }
    }
}
