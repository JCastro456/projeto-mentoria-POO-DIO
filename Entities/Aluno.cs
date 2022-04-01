namespace projeto_mentoria.Entities
{
    public class Aluno : pessoa
    {

        public string anoEscolar { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public Aluno(string nome, int idade, string email, string sexo, string anoEscolar, double nota1, double nota2) : base(nome, idade, email, sexo)
        {
            this.anoEscolar = anoEscolar;
            this.nota1 = nota1;
            this.nota2 = nota2;
        } 
        
        public double mediaFinal() {
            return (nota1+nota2)/2;
        }

        public string situacao(double mediaFinal){
            return mediaFinal >=6 ? "Parabéns, você foi aprovado!" : " O Aluno foi reprovado!";
        }
                    public void mensagem() {
            double obterMedia = mediaFinal();
            string obterSituaçao = situacao(obterMedia);

            System.Console.WriteLine("O Aluno(a) obteve a Média: " + obterMedia + "\n"
            + obterSituaçao);
        }

        public override string ToString() {        
            return ("Aluno(a): " + nome + "\n"
             + "Idade: " + idade + "\n"
             + "Ano Escolar: " + anoEscolar + "\n"
             + "Nota 1: " + nota1 + "\n"
             + "Nota 2: " + nota2 + "\n"
             + "Média final: " + mediaFinal());
        }
    
    }     
}