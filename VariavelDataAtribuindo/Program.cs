Console.WriteLine("## Criando Data e Atribuindo valor ##\n");

string firstName = "Paulo";
string lastName = "Cesar";
DateTime data = new DateTime(1999,04,09);

Console.WriteLine($"Nome: {firstName} {lastName} Data: {data.ToString("dd/MM/yyyy")}");

