using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_OO_basic.CityRepository
{
    public class CityRepository
    {
        public static List<City> CitiesList = new List<City>();
        public static void Add(City city){
            CitiesList.Add(city);
        }
        public static void Show(){
            if(CitiesList == null){
                System.Console.WriteLine("\nNenhuma cidade cadastrada!");
            }
            foreach(var c in CitiesList){
                Console.WriteLine($"\n Id: {c.Id} | Nome: {c.Name} | Estado: {c.State}");
            }
        }
        public static void Edit(string city){
            string citysName = city;
            var cityFound = CitiesList.Where(c => c.Name.Equals(citysName)).FirstOrDefault();
            
            if(cityFound != null){
                System.Console.WriteLine($"\nNome: {cityFound.Name} \nEstado: {cityFound.State}");

                System.Console.WriteLine("\nDigite o nome da cidade:");
                string newCity = Console.ReadLine()!;

                if(newCity == null || newCity == ""){
                    System.Console.WriteLine("\nNome não alterado!");
                }else{
                    cityFound.Name = newCity;
                }

                System.Console.WriteLine("\nDigite o novo estado:");
                string newState = Console.ReadLine();
                if(newState == "" || newState == null){
                    System.Console.WriteLine("\nEstado não alterado!");
                }else{
                    cityFound.State = newCity;
                    System.Console.WriteLine("\nCidade alterada!");
                }             
            }else{
                System.Console.WriteLine("\nCidade não cadastrada!");
            }
        }

        public static void Remove(string citysName){
            string city = citysName;
            var cityFound = CitiesList.Where(c => c.Name.Equals(city)).FirstOrDefault();

            if(cityFound != null){
                CitiesList.Remove(cityFound);
                System.Console.WriteLine("\nCidade removido!");
            }else{
                System.Console.WriteLine("\nNenhuma cidade encontrada!");
            }
        }

/*         public static List<City> getCityByName(string name){
            var cityFound = CitiesList.FindAll(p => p.Name.Contains(name));

            return cityFound;
        }

        public static int getCityByIndex(int id){
            int i = 0;
            
            foreach(Person p in CitiesList){
                if(p.Id == id){
                    return i;
                }

                throw new ArgumentException("Nenhum usuário foi encontrado!");
                i++;
            }

            return -1;
        } */
    }
}