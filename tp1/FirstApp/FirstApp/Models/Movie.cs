namespace FirstApp.Models
{
    public class Movie
    {
        public int id { set; get; }
        public string Name { set; get; }

        public Movie( int id , string name) {
            this.id = id;   
            this.Name = name;
        }

    }
}
