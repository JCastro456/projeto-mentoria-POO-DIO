using System;
using projeto_mentoria.Entities;

namespace projeto_mentoria
{
    class Program
    {
        static void Main(string[] args){
           // String Aluno = "Ana";
            //int Idade = 14;
            //String Ano = "3º Colegial";
            //double Nota1 = 9.5;
            //double Nota2 = 8.5;

            //System.Console.WriteLine("Aluno(a): " + Aluno + "\n"
            //+ "Idade: " + Idade + "\n"
            //+ "Ano: " + Ano);

            //System.Console.WriteLine("Aluno(a): " + Aluno.nome + "\n"
             //+ "Idade: " + Aluno.idade + "/n"
             //+ "Email:" + Aluno.email + "/n"
             //+ "Sexo: " + Aluno.sexo);

            // pessoa Aluno = new pessoa("Ana", 17, "ana@dio.me", "Feminino");
             //pessoa Professor = new pessoa("José", 53, "jose@dio.me", "Masculino");

            // Console.WriteLine("Aluno(a): " + Aluno.nome + "\n"
             //+ "Idade: " + Aluno.idade + "\n"
             //+ "Email: " + Aluno.email + "\n"
             //+ "Sexo: " + Aluno.sexo);

             //Console.WriteLine("Professor(a): " + Professor.nome + "\n"
             //+ "Idade: " + Professor.idade + "\n"
             //+ "Email: " + Professor.email + "\n"
             //+ "Sexo: " + Professor.sexo);


             Aluno Aluno = new Aluno("Ana", 17, "ana@dio.me", "Feminino", "3º ano", 9.5, 4.5);
             Aluno Aluno2 = new Aluno("Caio", 17, "caio@dio.me", "Masculino", "3º ano", 5.5, 4.5);

             Professor Professor = new Professor("José", 54, "jose@carrefour.com", "Masculino", "Física", 5000);

            Console.WriteLine(Aluno);
            Aluno.mensagem();
            
            Console.WriteLine("----------------------------------------");

            Console.WriteLine(Aluno2);
            Aluno2.mensagem();

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(Professor);
        }
    }
}
