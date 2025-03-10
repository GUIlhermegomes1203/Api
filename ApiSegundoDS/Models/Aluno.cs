namespace ApiSegundoDS.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? nome { get; set; }
        public string? rma { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public Escola Esola { get; set; }
        public Professor Professor { get; set; }

    }
}
