namespace ApiSegundoDS.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public int EsolaID { get; set; }
        public int ProfessorID { get; set; }

    }
}
