namespace FirstApp.Models
{
    public class FilmCostumer
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }

        public FilmCostumer( Movie m , List<Customer> c) 
        {
            this.Movie = m;
            this.Customer = c;
        }
    }
}
