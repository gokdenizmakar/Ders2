namespace Ders2.Models
{
    public class Category
    {
        public Category(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}
