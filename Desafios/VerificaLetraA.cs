using System;

class VerificaLetraA
{
    static void Main()
    {
        // String definida no código
        string textoDefinido = "Estudante de Análise e Desenvolvimento de Sistemas, focado em tecnologia e inovação";

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
