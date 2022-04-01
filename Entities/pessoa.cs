namespace projeto_mentoria.Entities
{
    public abstract class pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string sexo { get; set; } 

        public pessoa (string nome, int idade, string email, string sexo) {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.sexo = sexo;
        }

        public override string ToString() {        
            return ("Aluno(a): " + nome + "\n"
             + "Idade: " + idade + "\n"
             + "Email: " + email + "\n"
             + "Sexo: " + sexo);
        }
    }
}