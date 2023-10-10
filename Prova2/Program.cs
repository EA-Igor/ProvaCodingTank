using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Numerics;
class program
{
    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        try
        {

            while (true)
            {
                Console.WriteLine("Bem-vindo aos Desafios Finais!");
                Console.WriteLine("Digite 1 para o Exercicio final 1");
                Console.WriteLine("Digite 2 para o Exercicio final 2");
                Console.WriteLine("Digite 3 para o Exercicio final 3");
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        ExercicioFinal1();
                        break;
                    case "2":
                        ExercicioFinal2();
                        break;
                    case "3":
                        ExercicioFinal3();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Escolha uma das opções válidas.");
                        continue;

                }
                Console.Write("Deseja reiniciar o programa? (Digite sim para reiniciar): ");
                string reiniciarResposta = Console.ReadLine().ToLower();
                if (reiniciarResposta != "sim")
                {
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Mensagem de erro: {ex.Message}");
        }
    }

    static void ExercicioFinal1()
    {
        int inicioIntervalo, fimIntervalo, soma = 0, auxiliar;
        try
        {
            do
            {
                Console.Write("Digite o primeiro valor do intervalo: ");
                if (!int.TryParse(Console.ReadLine(), out inicioIntervalo))
                {
                    Console.WriteLine("Valor inválido! Por favor responda somente com números inteiros.");
                    continue;
                }
                break;
            } while (true);
            do
            {
                Console.Write("Digite o segundo valor do intervalo: ");
                if (!int.TryParse(Console.ReadLine(), out fimIntervalo))
                {
                    Console.WriteLine("Valor inválido! Por favor responda somente com números inteiros.");
                    continue;
                }
                break;
            } while (true);
            if (inicioIntervalo > fimIntervalo)
            {
                auxiliar = inicioIntervalo;
                inicioIntervalo = fimIntervalo;
                fimIntervalo = auxiliar;
            }
            for (int i = inicioIntervalo; i <= fimIntervalo; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine($"A soma dos números pares de {inicioIntervalo} até {fimIntervalo} é {soma} ");
        }
        catch (Exception ex)
        {
            throw new Exception($"Mensagem de erro: {ex.Message}");
        }
    }

    static void ExercicioFinal2()
    {
        Console.WriteLine("Bem-vindo ao Exercicio Final 2!");
        int quantidadeTermos;
        BigInteger numeroAtual = 0, proximoNumero = 1, auxiliar;
        try
        {
            do
            {
                Console.Write("Digite o número de termos da sequencia de Fibonacci que deseja ver:");
                if (!int.TryParse(Console.ReadLine(), out quantidadeTermos) || quantidadeTermos < 0)
                {
                    Console.WriteLine("Valor inválido! Por favor responda somente com números inteiros.");
                    continue;
                }
                break;
            } while (true);//loop para receber o valor do usuário e repetir até receber um valor válido
            for (int i = 0; i < quantidadeTermos; i++)
            {
                auxiliar = numeroAtual + proximoNumero;
                Console.Write($"{numeroAtual} ");
                numeroAtual = proximoNumero;
                proximoNumero = auxiliar;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Mensagem de erro: {ex.Message}");
        }

    }

    static void ExercicioFinal3()
    {
        Console.WriteLine("Bem-vindo ao Exercicio Final 3!");
        int guess;
        Random rand = new Random();
        int randomNumber = rand.Next(1, 101);
        try
        {
            do
            {
                Console.Write("Faça um palpite de qual é o número secreto dessa vez (números entre 1 e 100):  ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Valor inválido! Por favor responda somente com números inteiros entre 1 e 100.");
                    continue;
                }
                else if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Valor inválido! Por favor responda somente com números inteiros entre 1 e 100.");
                    continue;
                }
                if (guess == randomNumber)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número secreto {randomNumber}.");
                    break;
                }
                Console.WriteLine(guess < randomNumber ? $"O número {guess} é menor que o número secreto." : $"O número {guess} é maior que o número secreto.");
            } while (true);

        }
        catch (Exception ex)
        {
            throw new Exception($"Mensagem de erro: {ex.Message}");
        }
    }
}





