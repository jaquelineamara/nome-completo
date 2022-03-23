string nome, sobrenome, SOBRENOME;

Console.WriteLine("Digite seu primeniro nome:");
nome = Console.ReadLine()!;

Console.WriteLine("Digite seu sobrenome:");
sobrenome = Console.ReadLine()!;

SOBRENOME=sobrenome.ToUpper();

Console.WriteLine ($"Nome Completo: {nome} {sobrenome}"! );
Console.WriteLine($"Nome de catalogo: {SOBRENOME} {nome}"! );
