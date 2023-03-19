using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_OO_basic
{
    public class PersonRepository
    {
        public static List<Person> PersonsList = new List<Person>();
        public void Add(Person person){
            PersonsList.Add(person);
        }

        public void Show(){
            if(PersonsList == null){
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }
            foreach(var p in PersonsList){
                Console.WriteLine($"\nNome: {p.Name} | Telefone: {p.Phone}\n");
            }
        }

        public void Edit(string userName){
            string user = userName;
            var userFound = PersonsList.Where(p => p.Name.Equals(user)).FirstOrDefault();
            
            if(userFound != null){
                System.Console.WriteLine($"\nNome: {userFound.Name} \nTelefone: {userFound.Phone}");

                System.Console.WriteLine("\nDigite o novo nome:");
                string name = Console.ReadLine()!;
                if(name == null){
                    System.Console.WriteLine("\nNome não alterado!");
                }else{
                    userFound.Name = name;
                }
                System.Console.WriteLine("\nDigite o novo telefone:");
                Nullable<long> phone = Convert.ToInt64(Console.ReadLine());
                if(phone.HasValue){
                    System.Console.WriteLine("\nTelefone não alterado!");
                }else{
                    userFound.Phone = phone;
                }                
            }else{
                System.Console.WriteLine("\nCliente não cadastrado!");
            }
        }

        public void Remove(string userName){
            string user = userName;
            var userFound = PersonsList.Where(p => p.Name.Equals(user)).FirstOrDefault();

            if(userFound != null){
                PersonsList.Remove(userFound);
                System.Console.WriteLine("\nUsuário removido!");
            }else{
                System.Console.WriteLine("\nNenhum usuário encontrado!");
            }
        }
    }
}