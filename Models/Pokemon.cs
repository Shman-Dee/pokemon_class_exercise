namespace pokemon_exercise.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Pokemon(int id, string name, int height, int weight)
        {
            Id = id;
            Name = name;
            Height = height;
            Weight = weight;
        }
    }
}