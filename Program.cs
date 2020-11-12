using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aqui vai o código do nosso programa
            //C# é uma linguagem case sensitive
            // Exibe no cosole uma mensage
           

            //Declara as variabeos
            float nota1, nota2, nota3, media;
            string nomeCompleto;


            //Entarda de dados
            nomeCompleto = Console.ReadLine();


            Console.Write("Digite a primeira nota: ");
            //int "Numero Inteiro"
            nota1 = float.Parse(Console.ReadLine());



            Console.WriteLine("Digite o segundo valor: ");
            nota2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo valor: ");
            nota3 = float.Parse(Console.ReadLine());



            //Processamento
            media =(nota1+nota2+nota3)/3;
            //Exbir o resultado
            if(media>5){
                //Valor verdadeira
                Console.WriteLine("O Aluno Renato"+nomeCompleto+" está aprovado com a média de : "+media);
            }else{
                //Valor Falso
                Console.WriteLine("O Aluno"+nomeCompleto+" está REPROVADO com a média de:"+media);
            }

        }
    }
}
