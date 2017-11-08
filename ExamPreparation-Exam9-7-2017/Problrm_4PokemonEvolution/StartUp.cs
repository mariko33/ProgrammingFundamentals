using System;
using System.Collections.Generic;
using System.Linq;

namespace Problrm_4PokemonEvolution
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string,List<Evolution>>pokemonEvolutions=new Dictionary<string, List<Evolution>>();

            string input;
            while ((input=Console.ReadLine())!= "wubbalubbadubdub")
            {
                var inputArr = input
                    .Split(new[] {" ", "-", ">"}, StringSplitOptions.RemoveEmptyEntries);
                if (inputArr.Length==1)
                {
                    if (!pokemonEvolutions.ContainsKey(inputArr[0]))
                    {
                        continue;
                    }
                    var currPokemon = pokemonEvolutions.FirstOrDefault(p => p.Key == inputArr[0]);
                    Console.WriteLine($"# {currPokemon.Key}");
                    foreach (var currObj in currPokemon.Value)
                    {
                        Console.WriteLine($"{currObj.EvolutionType} <-> {currObj.EvolutionIndex}");
                    }
                    continue;
                }
                string pokemonName = inputArr[0];
                string evolutionType = inputArr[1];
                long evolutionIndex = long.Parse(inputArr[2]);
                
                Evolution evolution=new Evolution(evolutionType,evolutionIndex);
                
                if (pokemonEvolutions.ContainsKey(pokemonName))
                {
                    pokemonEvolutions[pokemonName].Add(evolution);
                    continue;
                }
                
                pokemonEvolutions.Add(pokemonName,new List<Evolution>{evolution});
                
            }

            foreach (var evolution in pokemonEvolutions)
            {
                Console.WriteLine($"# {evolution.Key}");
                foreach (var evolObj in evolution.Value.OrderByDescending(p=>p.EvolutionIndex))
                {
                    Console.WriteLine($"{evolObj.EvolutionType} <-> {evolObj.EvolutionIndex}");
                }
            }
        }
    }   

    public class Evolution
    {
        public Evolution(string evolutionType, long evolutionIndex)
        {
            this.EvolutionType = evolutionType;
            this.EvolutionIndex = evolutionIndex;
        }
        public string EvolutionType { get; set; }
        public long EvolutionIndex { get; set; }
    }
}
