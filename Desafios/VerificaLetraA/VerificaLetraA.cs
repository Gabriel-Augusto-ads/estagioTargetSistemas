using System;
using System.Linq;
using System.Collections.Generic;

class VerificaLetraA
{
    static void Main()
    {
        // String definida no código
        string textoDefinido = "Meu nome é Gabriel Augusto, sou estudante de Analise e Desenvolvimento de Sistemas.";

        // Converte toda a string para maiúsculas para simplificar a contagem
        string textoMaiusculo = textoDefinido.ToUpper();

        // Variável para contar a ocorrência da letra 'a'
        int contadorLetra = 0;

        // Percorre cada caractere da string
        foreach (char caractere in textoMaiusculo)
        {
            // Verifica se o caractere é a letra 'a'
            if (caractere == 'A')
            {
                contadorLetra++;
            }
        }

        // Exibe o resultado
        Console.WriteLine($"Sua String definida é: {textoMaiusculo}");
        
        Console.WriteLine($"A letra 'A' ocorre {contadorLetra} vezes na string definida.");
    }
}
