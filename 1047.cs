using System;
// Tempo de Jogo com Minutos - Exercicio 1047
// Leia a hora de início e fim de um jogo, em horas e minutos (hora inicial, minuto inicial, hora final, minuto final).
// Em seguida, imprima a duração do jogo, sabendo que o jogo pode começar em um dia e terminar em outro dia,
// Obs.: Com tempo máximo de jogo de 24 horas e tempo mínimo de jogo de 1 minuto. 

class Program
{
    static void Main(string[] args)
    {
        string[] tempo = Console.ReadLine().Split(' ');
        int h1 = int.Parse(tempo[0]);
        int m1 = int.Parse(tempo[1]);
        int h2 = int.Parse(tempo[2]);
        int m2 = int.Parse(tempo[3]);
        int diferenca = 0, hora, min, aux;

        if (h1 > h2 || (h1 == h2 && m1 >= m2)) // o jogo ocorreu em dois dias
        {
            aux = h1 + h2 + (24 - h1);
            h2 = aux;
        }
        diferenca = (h2 * 60 + m2) - (h1 * 60 + m1);

        hora = diferenca / 60;
        min = diferenca % 60;

        Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {min} MINUTO(S)");

    }
}
