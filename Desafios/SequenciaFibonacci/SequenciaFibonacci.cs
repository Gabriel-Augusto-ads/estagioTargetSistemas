using System;
using System.Linq;
using System.Collections.Generic;

class SequenciaFibonacci
{
    static void Main()
    {
        // Solicita número ao usuário
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        
        // converte a entrada do usuário para um número inteiro
        if (int.TryParse(Console.ReadLine(), out int numeroDigitado))
        {
            // Verifica e exibe se o número pertence à sequência de Fibonacci
            if (PertenceFibonacci(numeroDigitado))
            {
                Console.WriteLine($"O número {numeroDigitado} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numeroDigitado} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            // Informa ao usuário se a entrada não for um número inteiro válido
            Console.WriteLine("Por favor, informe um número inteiro válido.");
        }
    }

    // Função para verificar se um número pertence à sequência de Fibonacci
    static bool PertenceFibonacci(int numero)
    {
        // Retorna false para números negativos, pois a sequência de Fibonacci não inclui números negativos
        if (numero < 0) return false;

        // Inicializa os dois primeiros números da sequência de Fibonacci
        int valorAnterior = 0;
        int valorAtual = 1;

        // Gera números da sequência até que `valorAtual` seja maior ou igual ao número informado
        while (valorAnterior < numero)
        {
            // Atualiza os valores para o próximo número da sequência
            int novoValor = valorAnterior + valorAtual;
            valorAnterior = valorAtual;
            valorAtual = novoValor;
        }

        // Retorna true se `valorAnterior` for igual ao número informado
        return valorAnterior == numero;
    }
}
