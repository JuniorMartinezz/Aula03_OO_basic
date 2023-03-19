using Aula03_OO_basic;

int op;
int i = 0;

System.Console.WriteLine("\nPrograma iniciado...");

do{
    System.Console.WriteLine
    (
        "\nDigite o número do que deseja executar: \n\n1- Criar usuário \n2- Consultar lista de usuários \n3- Alterar usuário \n4- Deletar usuário \n0- Sair do programa\n"
    );
    op = Convert.ToInt32(Console.ReadLine());

    switch(op){
        case 1:
            int id = i;
            System.Console.WriteLine("\nDigite seu nome:");
            string inputName = Console.ReadLine()!; 
            System.Console.WriteLine("\nDigite seu telefone:");
            long inputPhone = Convert.ToInt64(Console.ReadLine()); 
            Person person = new Person(name: inputName, phone: inputPhone, id: id);
            PersonRepository repository = new PersonRepository();
            repository.Add(person);
            i++;
        break;
        case 2:
            PersonRepository repository1 = new PersonRepository();
            System.Console.WriteLine("\nLista de usuários\n");
            repository1.Show();
        break;
        case 3:
            PersonRepository repository2 = new PersonRepository();
            System.Console.WriteLine("\nLista de usuários\n");
            repository2.Show();

            System.Console.WriteLine("\nDigite o nome do usuário que deseja alterar:\n");
            string userName = Console.ReadLine()!;
            repository2.Edit(userName);
        break;
        case 4:
            PersonRepository repository3 = new PersonRepository();
            System.Console.WriteLine("\nLista de usuários\n");
            repository3.Show();

            System.Console.WriteLine("\nDigite o nome do usuário que deseja remover:");
            userName = Console.ReadLine()!;
            repository3.Remove(userName);
        break;
    }
}while(op != 0);
    System.Console.WriteLine("\nSistema Encerrado!");

