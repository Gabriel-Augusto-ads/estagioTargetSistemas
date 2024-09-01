using System;
using System.Linq;
using System.Collections.Generic;

class VerificaLetraA
{
    static void Main()
    {
        // String definida no código
        string textoDefinido = "Estudante de Analise e Desenvolvimento de Sistemas";

        // Converte toda a string para minúsculas para simplificar a contagem
        string textoMinusculo = textoDefinido.ToLower();

        // Variável para contar a ocorrência da letra 'a'
        int contadorLetraA = 0;

        // Percorre cada caractere da string
        foreach (char caractere in textoMinusculo)
        {
            // Verifica se o caractere é a letra 'a'
            if (caractere == 'a')
            {
                contadorLetraA++;
            }
        }

        // Exibe o resultado
        Console.WriteLine($"A letra 'a' ocorre {contadorLetraA} vezes na string definida.");
    }
}
