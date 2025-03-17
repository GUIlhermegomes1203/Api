namespace ApiSegundoDS.Models
{
    public class Professor
    {

        public int Id { get; set; }
        public string? nome { get; set; }
        public string? rma { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public string? ComponenteCurricular { get; set; }
        public int EsolaID { get; set; }
        public int AlunoID { get; set; }
    }
}