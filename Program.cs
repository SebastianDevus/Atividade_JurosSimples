double juros, capital, taxa, tempo, montante;

Console.WriteLine("\n---------Cálculo de juros simples---------\nPor favor insira os valores pedidos\n");

Console.Write("Capital (R$).....: ");
capital = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Taxa de Juros (%): ");
taxa = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Tempo (meses)....: ");
tempo = Convert.ToDouble(Console.ReadLine()!);

juros = capital * (taxa / 100) * tempo;
montante = capital + juros;

Console.WriteLine($"\nJuros...: {juros:C}\nMontante: {montante:C}");