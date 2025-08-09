using CalculadoraEstatistica;

var rol = new Rol()
{
    Dados =
    [
        60, 65, 67, 68, 69, 70, 72, 76, 77, 77,
        79, 79, 80, 80, 80, 80, 80, 81, 82, 82,
        82, 82, 83, 83, 84, 85, 86, 88, 88, 88, 
        89, 89, 89, 90, 90, 90, 90, 91, 92, 93,
        93, 94, 94, 94, 95, 95, 96, 96, 97, 97,
        97, 98, 98, 98, 99, 99, 99, 99, 100, 100,
        100, 100, 101, 101, 101, 102, 102, 104, 105, 105,
        106, 107, 107, 107, 108, 109, 109, 109, 110, 110,
        112, 113, 115, 115, 118, 119, 119, 120, 120, 120
    ]
};

Console.WriteLine($"[Média]                   x¯  = {rol.Media}");
Console.WriteLine($"[Mediana]                 x   = {rol.Mediana}");
Console.WriteLine($"[Moda]                    x^  = {rol.Moda}");
Console.WriteLine($"[Variância]               S²  = {rol.Variancia}");
Console.WriteLine($"[Desvio padrão]           S   = {rol.DesvioPadrao}");
Console.WriteLine($"[Coeficiente da variação] CV  = {rol.CoeficienteDaVariacao}");