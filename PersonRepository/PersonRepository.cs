using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_OO_basic
{
    public class PersonRepository
    {
        public static List<Person> PersonsList = new List<Person>();
        public static void Add(Person person){
            PersonsList.Add(person);
        }
        public static void Show(){
            if(PersonsList == null){
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }
            foreach(var p in PersonsList){
                Console.WriteLine($"\n Id: {p.Id} | Nome: {p.Name} | Telefone: {p.Phone} | Cidade: {p.City.Name}");
            }
        }
        public static void Edit(string userName){
            string user = userName;
            var userFound = PersonsList.Where(p => p.Name.Equals(user)).FirstOrDefault();
            
            if(userFound != null){
                System.Console.WriteLine($"\nNome: {userFound.Name} \nTelefone: {userFound.Phone}");

                System.Console.WriteLine("\nDigite o novo nome:");
                string newName = Console.ReadLine()!;

                if(newName == null || newName == ""){
                    System.Console.WriteLine("\nNome não alterado!");
                }else{
                    userFound.Name = newName;
                }

                System.Console.WriteLine("\nDigite o novo telefone:");
                string newPhone = Console.ReadLine();
                if(newPhone == "" || newPhone == null){
                    System.Console.WriteLine("\nTelefone não alterado!");
                }else{
                    userFound.Phone = Convert.ToInt64(newPhone);
                    System.Console.WriteLine("\nUsuário alterado!");
                }

                System.Console.WriteLine("\nDigite a nova cidade:");
                string newCity = Console.ReadLine();
                if(newCity == null || newCity == ""){
                    System.Console.WriteLine("\nCidade não alterada!");
                }else{
                    userFound.Name = newCity;
                }
            }else{
                System.Console.WriteLine("\nCliente não cadastrado!");
            }
        }

        public static void Remove(string userName){
            string user = userName;
            var userFound = PersonsList.Where(p => p.Name.Equals(user)).FirstOrDefault();

            if(userFound != null){
                PersonsList.Remove(userFound);
                System.Console.WriteLine("\nUsuário removido!");
            }else{
                System.Console.WriteLine("\nNenhum usuário encontrado!");
            }
        }

        public static List<Person> getPersonByName(string name){
            var userFound = PersonsList.FindAll(p => p.Name.Contains(name));

            return userFound;
        }

        public static int getPersonByIndex(int id){
            int i = 0;
            
            foreach(Person p in PersonsList){
                if(p.Id == id){
                    return i;
                }

                throw new ArgumentException("Nenhum usuário foi encontrado!");
                i++;
            }

            return -1;
        }
    }
}