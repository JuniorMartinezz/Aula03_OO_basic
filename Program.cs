using Aula03_OO_basic;

public class Program
{
    public static void Main(string[] args)
    {
        int op;
        int i = 0;

        System.Console.WriteLine("\nPrograma iniciado...");

        do
        {
            System.Console.WriteLine
            (
                "\nDigite o número do que deseja executar: \n\n1- Criar usuário \n2- Consultar lista de usuários \n3- Alterar usuário \n4- Deletar usuário \n0- Sair do programa\n"
            );
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    int id = i;

                    System.Console.WriteLine("\nDigite seu nome:");
                    string inputName = Console.ReadLine()!;

                    System.Console.WriteLine("\nDigite seu telefone:");
                    long inputPhone = Convert.ToInt64(Console.ReadLine());

                    System.Console.WriteLine("\nDigite sua cidade:");
                    string inputCity = Console.ReadLine();

                    System.Console.WriteLine("\nDigite o estado:");
                    string inputState = Console.ReadLine();

                    City city = new City(inputCity, inputState, id);

                    Person person = new Person(inputName, inputPhone, id, city);

                    PersonRepository.Add(person);
                    System.Console.WriteLine("\nUsuário cadastrado!");

                    i++;
                    break;
                case 2:
                    System.Console.WriteLine("\nConsultar lista de usuários:");
                    System.Console.WriteLine("\nDigite o nome do usuário que deseja buscar:\n");
                    string getUser = Console.ReadLine()!;

                    PersonRepository.getPersonByName(getUser);
                    break;
                case 3:
                    System.Console.WriteLine("\nLista de usuários");
                    PersonRepository.Show();

                    System.Console.WriteLine("\nDigite o nome do usuário que deseja alterar:\n");
                    string userName = Console.ReadLine()!;

                    PersonRepository.Edit(userName);
                    break;
                case 4:
                    System.Console.WriteLine("\nLista de usuários\n");
                    PersonRepository.Show();

                    System.Console.WriteLine("\nDigite o nome do usuário que deseja remover:");
                    userName = Console.ReadLine()!;

                    PersonRepository.Remove(userName);
                    break;
                default:
                    System.Console.WriteLine("Digite um código válido!");
                    break;
            }
        } while (op != 0);
        System.Console.WriteLine("\nSistema Encerrado!\n");

    }
}

