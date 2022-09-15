String nome;
int idade;

nome = "Cauê";
idade = 16;

Console.WriteLine(nome + " " + idade);

if(idade < 18){
    Console.WriteLine("Você, " + nome + " é menor de idade (" + idade + ")");
} else {
    Console.WriteLine("Você, " + nome + " é maior de idade (" + idade + ")");
}