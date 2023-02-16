namespace aula3
{
    internal class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine("Aula 03 - Continuação das estruturas de decisão");

            string usuario, senha;
            Console.WriteLine("Usuário: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Senha: ");
            senha = Console.ReadLine();

            if(usuario == "administrador" && senha == "123")
            {
                Console.WriteLine("Acesso liberado");
            } else
            {
                //Console.WriteLine("Usuário ou senha inválida!\nAcesso negado.");
                if(usuario != "administrador")
                {
                    Console.WriteLine("Usuário inválido!");
                }
                if(senha != "123")
                {
                    Console.WriteLine("Senha inválida!");
                }
            }
            */


            /*
            Console.WriteLine("Aula 03 - Compra com cupom");

            double totalCompra, valorFinal;
            string cupom;

            Console.WriteLine("Total da compra: ");
            totalCompra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cupom de desconto: ");
            cupom = Console.ReadLine();

            if(totalCompra >= 1000 || cupom == "DESCONTO20")
            {
                valorFinal = totalCompra - totalCompra * 0.2;
            } else
            {
                valorFinal = totalCompra;
            }

            Console.WriteLine("O valor a ser pago é de R$ " + valorFinal);
            */

            /*
            string tipoUsuario;
            Console.WriteLine("Informe o tipo de usuário: ");
            tipoUsuario = Console.ReadLine();
            
            //if(!(tipoUsuario == "administrador"))
            if (tipoUsuario != "administrador")
                {
                Console.WriteLine("Usuário sem permissão!");
            } else
            {
                Console.WriteLine("Usuário autorizado!");
            }
            */

            /*
            int codigo;
            string mensagem;
            Console.WriteLine("Digite o código: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    mensagem = "Você escolheu a opção ELOGIO PROFISSIONAL";
                    break;
                case 2:
                    mensagem = "Você escolheu a opção ELOGIO FÍSICO";
                    break;
                case 3:
                    mensagem = "Você escolheu a opção ELOGIO PESSOAL";
                    break;
                default:
                    mensagem = "Opção inválida!";
                    break;
            }
            Console.WriteLine(mensagem);
            */

            /*
            int l1, l2, l3;
            Console.WriteLine("Digite o tamanho de L1");
            l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o tamanho de L2");
            l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o tamanho de L3");
            l3 = Convert.ToInt32(Console.ReadLine());

            if (l1 < l2 + l3 && l2 < l3 + l1 && l3 < l2 + l1)
            {
                Console.WriteLine("É um triangulo.");
                if(l1 == l2 && l2 == l3 && l3 == l1)
                {
                    Console.WriteLine("equilátero.");
                } else if(l1 != l2 && l1 != l3 && l3 != l2)
                {
                    Console.WriteLine("escaleno.");
                } else
                {
                    Console.WriteLine("isocéles");
                }
            }
            else
            {
                Console.WriteLine("Não é um triangulo.");
            }
            */

            /*
            int mes;
            Console.WriteLine("Digite mês: ");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }
            */



            double nota1, nota2, media;
            int aulasAssistidas, aulasDadas, frequencia;

            Console.WriteLine("Digite a nota 1: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de aulas: ");
            aulasDadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de aulas assistidas: ");
            aulasAssistidas = Convert.ToInt32(Console.ReadLine());

            media = Convert.ToDouble(nota1 / nota2);
            frequencia = Convert.ToInt32((aulasDadas / aulasAssistidas) * 100);

            if(media >= 7 && frequencia >= 75)
            {
                Console.WriteLine("Aluno aprovado com média = " + media + " e frequência = " + frequencia + "%");
            } else
            {
                Console.WriteLine("Aluno reprovado.");
            }



        }
    }
}