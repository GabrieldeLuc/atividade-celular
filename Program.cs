using Atividade_Celular;


{
   
            Celular cel = new Celular();

            Console.WriteLine($"Bem vindo ao Sistema, informe o Modelo do seu Celular: ");
            cel.modelo = Console.ReadLine()!;

            Console.WriteLine($"Agora, informe a Cor do Aparelho: ");
            cel.cor = Console.ReadLine()!;

            Console.WriteLine($"informe o tamanho do Aparelho: ");
            cel.tamanho = float.Parse(Console.ReadLine()!);

            string escolha;

            do
            {
                Console.WriteLine($"****Menu****");
                Console.WriteLine(@$"
[1] - Ligar Aparelho 
[2] - Desligar Aparelho 
[3] - Fazer Ligação 
[4] - Enviar Mensagem 
[0] - Sair 
*************************
");
                escolha = Console.ReadLine()!;

                switch (escolha)
                {
                    case "1":
                        if (cel.ligado)
                        {
                            Console.WriteLine($"Celular já está Ligado !");
                        }
                        else
                        {
                            cel.Ligar();
                            Console.WriteLine($"Celular ligado !");
                        }
                        break;

                    case "2":
                        if (cel.ligado)
                        {
                            cel.Desligar();
                            Console.WriteLine($"Celular desligado !");
                        }
                        else
                        {
                            Console.WriteLine($"o Celular já está desligado !");
                        }
                        break;

                    case "3":
                        if (cel.ligado)
                        {
                            Console.WriteLine($"informe o número ao qual você deseja fazer a ligação: ");
                            cel.Chamar(int.Parse(Console.ReadLine()!));
                            Console.WriteLine($"Chamada realizada !");
                        }
                        else
                        {
                            Console.WriteLine($"Ligue o seu Celular Primeiro !");
                        }
                        break;

                    case "4":
                        if (cel.ligado)
                        {
                            Console.WriteLine($"Escreva para quem você quer enviar a mensagem: ");
                            var pessoa = Console.ReadLine()!;
                            Console.WriteLine($"Agora, Escreva a mensagem que você quer enviar: ");
                            var mensagem = Console.ReadLine()!;
                            cel.EMensagem(pessoa, mensagem);
                            Console.WriteLine($"Mensagem Enviada !");
                        }
                        else
                        {
                            Console.WriteLine($"Ligue seu Celular Primeiro ! ");
                        }
                        break;

                    case "0":
                        Console.WriteLine($"Obrigado por usar o Sistema, Até Mais !");
                        break;

                    default:
                        Console.WriteLine($"Opção Inválida !");
                        break;
                }
            } while (escolha != "0");
        }
    

  

      



