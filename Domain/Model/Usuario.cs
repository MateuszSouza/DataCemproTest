namespace Domain.Model
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Nivel { get; set; }
        public bool ativo {  get; set; }   
    }
}