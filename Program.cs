// See https://aka.ms/new-console-template for more information
/* Tipos mais comuns do C#
bool - true ou false
char - Um único caractere
byte - Inteiro de 8 bits unsigned
int - Inteiro de 32 bits
long - Inteiro de 64 bits
float - Número de ponto flutuante de 32 bits
double - Número de ponto flutuante de 64 bits
decimal - Número de ponto flutuante de 128 bits preciso (moeda)
string - Sequência de caracteres

- 8 bits unsigned (0 a 255) sem negativo
- 32 bits (-2.147.483.648 a 2.147.483.647)
- 64 bits (-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807)
- 128 bits (-79.228.162.514.264.337.593.543.950.335 a 7.922.8162.514.264.337.593.543.950.335)
*/
/* Mostrando uso de tipos e variáveis.
int i; // Informando o tipo
int i2 = i = 20; // Informando o valor
i++; // Adicionando incremento

i2 = i2 == 42 ? 30 : 10; // Operador ternário

// Adicionado um incremento ao "i" mas não teve efeito no "i2".
Console.WriteLine(i); // 21
Console.WriteLine(i2); // 20
*/
/* ¿input? interpolação, IF ELSE e logic operators.
// Write não quebra linha, WriteLine quebra linha.
Console.Write("Digite o seu nome: ");
string name = Console.ReadLine();

// Concatenação
// Console.WriteLine("Olá " + name + "!");

// Interpolação
Console.Write($"Olá {name}, Digite o seu ano de nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = DateTime.Now.Year - year;
Console.WriteLine($"Você tem {age} anos.");

if (age > 18) {
    Console.WriteLine("Você é maior de idade.");
} else if (age == 18 && name == "Wellinsson") {
    Console.WriteLine("Congratulations!");
} else {
    Console.WriteLine("Você é menor de idade.");
}
*/

/* Usando arrays, for e classes.
class Person
{
    // void = sem retorno
    static void Main() //Primeiro método executado
    {
        string[] name = { "Pedro", "Wellinsson", "Romilda", "Eduardo", "Jadilsson", "Alberto", "Natasha" };

        Console.WriteLine("Os nomes registados são: ");

        for (int c = 0; c < name.Length; c++)
        {
            Console.Write(name[c]);
            if (c < name.Length - 2)
            {
                Console.Write(", ");
            }
            else if (c == name.Length - 2)
            {
                Console.Write(" e ");
            }
            else
            {
                Console.WriteLine(".");
            }
        }
    }
}
*/
