using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o peso da pessoa em quilogramas: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura da pessoa em metros utilizando vírula '(0,00)': ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a idade da pessoa: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Cálculo do IMC
        double imc = peso / (altura * altura);

        // Determinação da classificação de IMC
        string classificacaoIMC;
        if (imc < 18.5)
            classificacaoIMC = "Abaixo do peso";
        else if (imc < 25)
            classificacaoIMC = "Peso normal";
        else if (imc < 30)
            classificacaoIMC = "Sobrepeso (acima do peso desejado)";
        else
            classificacaoIMC = "Obesidade";

        // Determinação da faixa etária
        string faixaEtaria;
        if (idade < 10)
            faixaEtaria = "Criança";
        else if (idade < 20)
            faixaEtaria = "Adolescente";
        else if (idade < 60)
            faixaEtaria = "Adulto";
        else
            faixaEtaria = "Idoso";

        // Imprime o resultado do IMC, a classificação, a faixa etária e o nome da pessoa
        Console.WriteLine($"\nRelatório:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"IMC: {imc:F2}");
        Console.WriteLine($"Classificação de IMC: {classificacaoIMC}");
        Console.WriteLine($"Faixa etária: {faixaEtaria}");
    }
}