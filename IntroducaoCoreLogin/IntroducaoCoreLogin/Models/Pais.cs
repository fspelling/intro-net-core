namespace IntroducaoCoreLogin.Models
{
    public class Pais
    {
        public Pais(string nome)
        {
            Nome = nome;
        }

        public Pais()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
