namespace ex03;
class Program
{
    static void Main(string[] args)
    {
        int codigo, combustivel1 = 0, combustivel2 = 0, combustivel3 = 0;

        Console.WriteLine("Digite o código do combústivel: ");
        codigo = int.Parse(Console.ReadLine());

        while(codigo != 4){

            if(codigo == 1){
                combustivel1 += 1;
            }
            else if(codigo == 2){
                combustivel2 += 1;
            }
            else if(codigo == 3){
                combustivel3 += 1;
            }
            else{
                Console.WriteLine("Digite um código válido!");
            }

            Console.WriteLine("Digite o código do combústivel: ");
            codigo = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Muito obrigado!");
        Console.WriteLine($"Alcool: {combustivel1}");
        Console.WriteLine($"Gasoline: {combustivel2}");
        Console.WriteLine($"Combustivel: {combustivel3}");
    }
}
