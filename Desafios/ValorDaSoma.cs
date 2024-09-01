using System;

class ValorDaSoma
{
    static void Main()
    {
        // Declaração das variáveis
        int INDICE = 12;
        int SOMA = 0;
        int K = 1;

        // Enquanto K for menor que INDICE, o loop continua
        while (K < INDICE)
        {
            K = K + 1;    // Incrementa o valor de K
            SOMA = SOMA + K;  // Soma o valor de K à variável SOMA
        }

        // Exibe o valor final de SOMA
        Console.WriteLine($"O valor final da variável SOMA é: {SOMA}");
    }
}


 // O valor da SOMA é 77.