class program
{
    public static void Main()
    {
        double numero1, numero2;

        //WriteLine Escreve a infomação e depois pula 1 linha 

        //White Escreve a informação na tela sem pular linha
        Console.WriteLine("Entre com o número 1: ");

        //console.readline() - lê o que o usúario digitou 


        //captura a informação do usúario e guarda dentro da variavel informacao
        string informacao = Console.ReadLine();

        //converte o valor da variável informação para double

        //e depois salva o valor dentro da variável numero1
        numero1 = Convert.ToDouble(informacao);

        Console.WriteLine("Entre o numero 2");


        //converte imediataente o valor digitado pelo usúario para double
        //e depois salva na variável numero2
        numero2 = Convert.ToDouble(Console.ReadLine());

        double subtracao = numero1 - numero2;
        double mult = numero1 * numero2;
        double div = numero1 / numero2;
        double soma = numero1 + numero2;

        Console.WriteLine($"soma: {soma}");

        Console.WriteLine("subtração: {0}", subtracao);

        Console.WriteLine($"divisao: {div}");

        Console.Write($"multiplicacao: {mult}");

    }
}


