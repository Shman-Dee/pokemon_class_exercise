using pokemon_exercise.Models;

Pokemon mario = new Pokemon
(
    1,
    "Mario",
    10,
    5
);
Pokemon luigi = new Pokemon
(
    2,
    "Luigi",
    10,
    5
);
Pokemon yoshi = new Pokemon
(
    3,
    "Yoshi",
    5,
    10
);
Pokemon shyGuy = new Pokemon
(
    4,
    "Shy Guy",
    3,
    10
);

Pokemon pikachu = new Pokemon
(
    5,
    "Pikachu",
    2,
    5
);

Pokemon charmander = new Pokemon
(
    6,
    "Charmander",
    3,
    5
);

Pokemon bulbasaur = new Pokemon
(
    7,
    "Bulbasaur",
    3,
    5
);

string id = "";

Dictionary<string, Pokemon> pokemonIndex = new Dictionary<string, Pokemon>();

pokemonIndex.Add(mario.Id.ToString(), mario);
pokemonIndex.Add(luigi.Id.ToString(), luigi);
pokemonIndex.Add(yoshi.Id.ToString(), yoshi);
pokemonIndex.Add(shyGuy.Id.ToString(), shyGuy);
pokemonIndex.Add(pikachu.Id.ToString(), pikachu);
pokemonIndex.Add(charmander.Id.ToString(), charmander);
pokemonIndex.Add(bulbasaur.Id.ToString(), bulbasaur);



Console.WriteLine("Enter the id of the pokemon you want to see. Type '0' to quit.");
while (id != "exit")
{
    id = Console.ReadLine();
    Console.WriteLine(pokemonIndex[id].Name);
    Console.WriteLine(pokemonIndex[id].Height);
    Console.WriteLine(pokemonIndex[id].Weight);
}


