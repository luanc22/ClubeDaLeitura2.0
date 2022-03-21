using System;

/*
 
  Requisitos
  
[OK]  Para cada Revista, deverá ser cadastrado:  
• o tipo de coleção [OK]
• o número da edição [OK]
• o ano da revista [OK]
• a caixa onde está guardada [OK]
• Cada caixa tem uma cor, uma etiqueta e um número. [OK]

=========================

[OK] Para cada Empréstimo cadastram-se: 
• o amigo que pegou a revista [OK]
• qual foi a revista emprestada [OK]
• a data do empréstimo [OK]
• a data de devolução [OK]
• Cada criança só pode pegar uma revista por empréstimo. [OK]

=========================

[OK] O cadastro do Amigo consiste de: 
• nome [OK]
• nome do responsável [OK]
• telefone [OK]
• endereço [OK]

=========================

[OK] Mensalmente Gustavo verifica os empréstimos realizados no mês e diariamente 

*/

namespace ClubeDaLeitura.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            Revista[] listaDeRevista = new Revista[100];
            Caixa[] listaDeCaixa = new Caixa[100];
            Amigo[] listaDeAmigo = new Amigo[100];
            Emprestimo[] listaDeEmprestimo = new Emprestimo[100];
            Emprestimo[] emprestimosFeitos = new Emprestimo[100];
            Reserva[] listaDeReserva = new Reserva[100];
            Categoria[] listaDeCategoria = new Categoria[100];
            Notificacao notificacao = new Notificacao();
            Menu menu = new Menu();

            int quantidadeDeCategorias = 0;
            int quantidadeDeReserva = 0;
            int quantidadeDeCaixas = 0;
            int quantidadeDeRevistas = 0;
            int quantidadeDeAmigos = 0;
            int quantidadeDeEmprestimos = 0;
            int opcaoEscolhida = 0;

            bool fecharApp = false;
            while (fecharApp == false)
            {
                Console.Clear();
                Cabecalho();
                opcaoEscolhida = menu.ChamarMenu();

                switch (opcaoEscolhida)
                {
                    case 1:
                        #region Menu Caixas. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuCaixas();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarCaixa(listaDeCaixa, ref quantidadeDeCaixas);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarCaixas(listaDeCaixa);
                        }
                        else
                        {
                            notificacao.ApresentarMensagem(ConsoleColor.Red, "Opcao invalida, digite uma opcao valida!");
                        }
                        #endregion
                        break;
                    case 2:
                        #region Menu Revistas. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuRevistas();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarRevista(listaDeRevista, listaDeCaixa, listaDeCategoria, ref quantidadeDeRevistas);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarRevistas(listaDeRevista);
                        }
                        else
                        {
                            notificacao.ApresentarMensagem(ConsoleColor.Red, "Opcao invalida, digite uma opcao valida!");
                        }
                        #endregion
                        break;
                    case 3:
                        #region Menu Amigos. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuAmigos();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarAmigo(listaDeAmigo, listaDeRevista, ref quantidadeDeAmigos);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarAmigos(listaDeAmigo);
                        }
                        else
                        {
                            notificacao.ApresentarMensagem(ConsoleColor.Red, "Opcao invalida, digite uma opcao valida!");
                        }

                        #endregion
                        break;
                    case 4:
                        #region Menu Emprestimo. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuEmprestimo();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarEmprestimo(listaDeAmigo, listaDeRevista, listaDeEmprestimo, listaDeReserva, ref quantidadeDeEmprestimos);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarDevolucao(listaDeEmprestimo, emprestimosFeitos);
                        }
                        else if (opcaoEscolhida == 3)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarEmprestimosAberto(listaDeEmprestimo);
                        }
                        else if (opcaoEscolhida == 4)
                        {
                            Console.Clear();
                            Cabecalho();
                            ListarEmprestimosDoMes(listaDeEmprestimo);
                        }
                        #endregion
                        break;
                    case 5:
                        #region Menu Reserva. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuReservas();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarReserva(listaDeReserva, listaDeAmigo, listaDeRevista, listaDeEmprestimo, ref quantidadeDeReserva, ref quantidadeDeEmprestimos);
                        }
                        #endregion
                        break;
                    case 6:
                        #region Menu Categoria. [OK]
                        Console.Clear();
                        Cabecalho();
                        opcaoEscolhida = menu.ChamarMenuCategorias();
                        if (opcaoEscolhida == 1)
                        {
                            Console.Clear();
                            Cabecalho();
                            CadastrarCategoria(listaDeCategoria, listaDeRevista, ref quantidadeDeCategorias);
                        }
                        else if (opcaoEscolhida == 2)
                        {
                            Console.Clear();
                            Cabecalho();
                            AdicionarRevistaCategoria(listaDeCategoria, listaDeRevista);
                        }
                        #endregion  
                        break;

                }
            }

        }

        #region Metodo Cabecalho. [OK]

        static void Cabecalho()
        {
            Console.WriteLine("======================= Clube da Leitura =======================");
            Console.WriteLine();
            Console.WriteLine("   Programa para gerenciar os emprestimos do clube da leitura.");
            Console.WriteLine();
            Console.WriteLine("================================================================");
        }

        #endregion

        #region Metodos de Cadastro. [OK]

        static void CadastrarRevista(Revista[] listaDeRevista, Caixa[] listaDeCaixa, Categoria[] listaDeCategoria, ref int quantidadeDeRevistas)
        {
            Revista revista1 = new Revista();
            Notificacao notificacao = new Notificacao();
            string numeroEdicaoEmString;
            string anoEmString;
            string caixaEmString;
            int numeroDaCaixa = 0;

            if (listaDeCaixa[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! Cadastre uma caixa antes de prosseguir com o registro de revistas.");
                return;
            }

            Console.Clear();
            Cabecalho();

            ListarCaixas(listaDeCaixa);

            Console.WriteLine();
            Console.WriteLine("======== Registro da Revista ========");

            #region Coletar dados sobre a revista e armazenar. [OK]

            Console.WriteLine();
            Console.Write("Digite o tipo de colecao da revista: ");
            revista1.tipoColecao = Console.ReadLine();

            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o numero de edicao da revista: ");
                numeroEdicaoEmString = Console.ReadLine();

                numeroValido = int.TryParse(numeroEdicaoEmString, out revista1.numeroEdicao);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o ano da revista: ");
                anoEmString = Console.ReadLine();

                numeroValido = int.TryParse(anoEmString, out revista1.anoRevista);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o numero da caixa: ");
                caixaEmString = Console.ReadLine();

                numeroValido = int.TryParse(caixaEmString, out numeroDaCaixa);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            #endregion

            #region Pegar a posicao da caixa e armazenar revista na caixa. [OK]

            numeroDaCaixa = numeroDaCaixa - 1;

            int contador = 0;

            for (int i = 0; i < listaDeCaixa.Length; i++)
            {
                if (listaDeCaixa[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            numeroDaCaixa = numeroDaCaixa + 1;

            for (int i = 0; i <= contador; i++)
            {
                if (listaDeCaixa[i].numero == numeroDaCaixa)
                {
                    revista1.caixaArmazenada = listaDeCaixa[i];
                    int espacoVazioCaixas = listaDeCaixa[i].obterPosicaoVaziaRevista();
                    listaDeCaixa[i].revistas[espacoVazioCaixas] = revista1;
                }
            }

            #endregion

            #region Pegar Categoria da Revista. [OK]

            bool validaCategoria = false;

            while (validaCategoria == false)
            {
                Console.WriteLine();
                Console.Write("Digite a categoria da revista: ");
                string nomeCategoriaRevista = Console.ReadLine();

                for (int i = 0; i < listaDeCategoria.Length; i++)
                {
                    if (i == listaDeCategoria.Length - 1)
                    {
                        notificacao.ApresentarMensagem(ConsoleColor.Red, "Categoria inexistente, por favor, realize o cadastro primeiro.");
                        return;
                    }
                    else if (listaDeCategoria[i] != null && nomeCategoriaRevista == listaDeCategoria[i].nome)
                    {
                        revista1.categoriaDaRevista = listaDeCategoria[i];
                        validaCategoria = true;
                        break;
                    }
                }

                #endregion

                #region Guardar os dados da revista e incrementar a array. [OK]

                revista1.reserva = false;
                listaDeRevista[quantidadeDeRevistas] = revista1;
                quantidadeDeRevistas++;

                #endregion
            }
        }

        static void CadastrarCaixa(Caixa[] listaDeCaixa, ref int quantidadeDeCaixas)
        {
            Caixa caixa1 = new Caixa();
            Notificacao notificacao = new Notificacao();

            Console.Clear();
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine("======== Registro da Caixa ========");

            #region Coletar dados sobre a caixa e armazenar. [OK]

            Console.WriteLine();
            Console.Write("Digite a cor da caixa: ");
            caixa1.cor = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite a etiqueta da caixa: ");
            caixa1.etiqueta = Console.ReadLine();

            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.WriteLine();
                Console.Write("Digite o numero da caixa: ");
                string numeroEmString = Console.ReadLine();

                numeroValido = int.TryParse(numeroEmString, out caixa1.numero);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            notificacao.ApresentarMensagem(ConsoleColor.Green, "Caixa cadastrada com sucesso.");

            #endregion

            #region Guardar os dados da caixa e incrementar a array. [OK]

            listaDeCaixa[quantidadeDeCaixas] = caixa1;
            quantidadeDeCaixas++;

            #endregion

        }

        static void CadastrarAmigo(Amigo[] listaDeAmigo, Revista[] listaDeRevista, ref int quantidadeDeAmigos)
        {
            Amigo amigo1 = new Amigo();
            Notificacao notificacao = new Notificacao();

            Console.Clear();
            Cabecalho();

            Console.WriteLine();
            Console.WriteLine("======== Registro de Amigo ========");

            #region Coletar dados sobre o amigo e armazenar. [OK]

            Console.WriteLine();
            Console.Write("Digite o nome do amigo: ");
            amigo1.nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o nome do responsavel do amigo: ");
            amigo1.nomeResponsavel = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o telefone do amigo: ");
            amigo1.telefone = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o endereco do amigo: ");
            amigo1.endereco = Console.ReadLine();

            notificacao.ApresentarMensagem(ConsoleColor.Green, "Amigo cadastrado com sucesso.");

            #endregion

            #region Guardar os dados do amigo e incrementar a array. [OK]

            listaDeAmigo[quantidadeDeAmigos] = amigo1;
            quantidadeDeAmigos++;

            #endregion
        }

        static void CadastrarEmprestimo(Amigo[] listaDeAmigo, Revista[] listaDeRevista, Emprestimo[] listaDeEmprestimo, Reserva[] listaDeReserva, ref int quantidadeDeEmprestimos)
        {
            Emprestimo emprestimo1 = new Emprestimo();
            Notificacao notificacao = new Notificacao();

            bool validaAmigo = false;
            string emprestimoEmString = "";

            ListarAmigos(listaDeAmigo);

            #region Coletar dados sobre a revista e armazenar. [OK]

            while (validaAmigo == false)
            {
                Console.WriteLine();
                Console.Write("Digite o nome do amigo do emprestimo: ");
                emprestimoEmString = Console.ReadLine();

                for (int i = 0; i < listaDeAmigo.Length; i++)
                {
                    if (i == listaDeAmigo.Length - 1)
                    {
                        notificacao.ApresentarMensagem(ConsoleColor.Red, "Amigo inexistente, por favor, realize o cadastro primeiro.");
                        return;
                    }
                    else if (listaDeAmigo[i] != null && emprestimoEmString == listaDeAmigo[i].nome)
                    {
                        emprestimo1.amigo = listaDeAmigo[i];
                        validaAmigo = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < listaDeEmprestimo.Length; i++)
            {
                if (listaDeEmprestimo[i] != null && listaDeEmprestimo[i].amigo.nome == emprestimoEmString)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! Amigo ja possui um emprestimo.");
                    return;
                }
            }

            for (int i = 0; i < listaDeAmigo.Length; i++)
            {
                if (listaDeAmigo[i] != null && listaDeAmigo[i].multa == true)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! Multa em aberto, proibido realizar emprestimo.");
                }
            }


            // int diasCategoria = 0;
            bool validaRevista = false;

            while (validaRevista == false)
            {
                Console.WriteLine();
                Console.Write("Digite o id da revista emprestada: ");
                string idEmprestimoRevistaEmString = Console.ReadLine();

                bool idEmprestimoValido = int.TryParse(idEmprestimoRevistaEmString, out int idEmprestimoRevista);

                if (idEmprestimoValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }

                for (int i = 0; i < listaDeEmprestimo.Length; i++)
                {
                    if (listaDeEmprestimo[i] != null && listaDeEmprestimo[i].revista.idRevista == idEmprestimoRevista)
                    {
                        notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! Revista ja esta em um emprestimo.");
                        return;
                    }
                }

                /*
                 * 
                 * Nao consegui fazer funcionar os dias da categoria no emprestimo, verificar na correcao.
                 * 
                for (int i = 0; i < listaDeRevista.Length; i++)
                {
                    if (listaDeRevista[i] != null && idEmprestimoRevista == listaDeRevista[i].idRevista)
                    {
                        listaDeEmprestimo[i].revista = listaDeRevista[i];
                        diasCategoria = listaDeEmprestimo[i].revista.categoriaDaRevista.diasAEmprestar;
                        break;
                    }
                }
                */

                for (int i = 0; i < listaDeReserva.Length; i++)
                {
                    if (listaDeReserva[i] != null && listaDeReserva[i].revista.idRevista == idEmprestimoRevista && listaDeReserva[i].dataExpiraReserva > DateTime.Now)
                    {
                        notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! A revista esta reservada.");
                        return;
                    }
                }

                for (int i = 0; i < listaDeRevista.Length; i++)
                {
                    if (i == listaDeRevista.Length - 1)
                    {
                        notificacao.ApresentarMensagem(ConsoleColor.Red, "Revista inexistente, por favor, realize o cadastro primeiro.");
                        return;
                    }
                    if (listaDeRevista[i] != null && idEmprestimoRevista == listaDeRevista[i].idRevista)
                    {
                        emprestimo1.revista = listaDeRevista[i];
                        validaRevista = true;
                        break;
                    }
                }
            }


            DateTime dataEmprestimo;
            bool dataEmprestimoValida = false;

            while (dataEmprestimoValida == false)
            {
                Console.WriteLine();
                Console.Write("Digite a data de emprestimo da revista: ");
                string datadeEmprestimo = Console.ReadLine();
                dataEmprestimoValida = DateTime.TryParse(datadeEmprestimo, out dataEmprestimo);

                if (dataEmprestimoValida == true)
                {
                    emprestimo1.dataEmprestimo = dataEmprestimo;
                }

            }

            DateTime dataDevolucao;
            bool dataDevolucaoValida = false;

            while (dataDevolucaoValida == false)
            {
                Console.WriteLine();
                Console.Write("Digite a data de devolução: ");
                string dataDeDevolucao = Console.ReadLine();
                dataDevolucaoValida = DateTime.TryParse(dataDeDevolucao, out dataDevolucao);

                if (dataDevolucaoValida == true)
                {
                    emprestimo1.dataDevolucao = dataDevolucao;
                }

            }

            Console.WriteLine();

            #endregion

            #region Guardar os dados da revista e incrementar a array. [OK]

            listaDeEmprestimo[quantidadeDeEmprestimos] = emprestimo1;
            quantidadeDeEmprestimos++;

            #endregion
        }

        static void CadastrarDevolucao(Emprestimo[] listaDeEmprestimo, Emprestimo[] EmprestimosFeitos)
        {
            #region Coletar dados sobre o amigo a devolver. [OK]

            Console.WriteLine();
            Console.Write("Digite o nome do amigo da devolucao: ");
            string nomeDevolucao = Console.ReadLine();

            int j = 0;

            for (int i = 0; i < listaDeEmprestimo.Length; i++)
            {
                if (listaDeEmprestimo[i] != null && listaDeEmprestimo[i].amigo.nome != nomeDevolucao)
                {
                    EmprestimosFeitos[j] = listaDeEmprestimo[i];

                    j++;
                    break;
                }
            }

            listaDeEmprestimo = EmprestimosFeitos;

            #endregion
        }

        static void CadastrarReserva(Reserva[] listaDeReserva, Amigo[] listaDeAmigo, Revista[] listaDeRevista, Emprestimo[] listaDeEmprestimo, ref int quantidadeDeReservas, ref int quantidadeDeEmprestimos)
        {
            Reserva reserva1 = new Reserva();
            Notificacao notificacao = new Notificacao();

            ListarRevistas(listaDeRevista);

            #region Coletar dados sobre a reserva e armazenar. [OK]

            bool validaAmigo = false;
            string nomeDoAmigo = "";

            while (validaAmigo == false)
            {
                Console.WriteLine();
                Console.Write("Digite o nome do amigo para reservar: ");
                nomeDoAmigo = Console.ReadLine();

                for (int i = 0; i < listaDeAmigo.Length; i++)
                {
                    if (listaDeAmigo[i] != null && listaDeAmigo[i].nome == nomeDoAmigo)
                    {
                        reserva1.amigo = listaDeAmigo[i];
                        validaAmigo = true;
                        break;
                    }
                }
            }

            bool validaRevista = false;
            string emprestimoEmString = "";
            int emprestimoNumero = 0;

            while (validaRevista == false)
            {
                Console.WriteLine();
                Console.Write("Digite o id da revista a reservar: ");
                emprestimoEmString = Console.ReadLine();
                emprestimoNumero = int.Parse(emprestimoEmString);

                for (int i = 0; i < listaDeRevista.Length; i++)
                {
                    if (listaDeRevista[i] != null && emprestimoNumero == listaDeRevista[i].idRevista)
                    {
                        listaDeRevista[i].reserva = true;
                        reserva1.revista = listaDeRevista[i];
                        validaRevista = true;
                        break;
                    }
                }
            }

            reserva1.diasDaReserva = 2;
            reserva1.dataExpiraReserva = DateTime.Now.AddDays(reserva1.diasDaReserva);

            listaDeReserva[quantidadeDeReservas] = reserva1;
            quantidadeDeReservas++;

            #endregion

            #region Realizar Emprestimo. [OK]

            notificacao.ApresentarMensagem(ConsoleColor.Green, "Reserva cadastrada com sucesso.");

            Console.WriteLine();
            Console.WriteLine("Deseja realizar emprestimo? Sim ou Nao.");
            string respostaEmprestimo = Console.ReadLine();
            respostaEmprestimo = respostaEmprestimo.ToUpper();

            if (respostaEmprestimo == "SIM")
            {
                CadastrarEmprestimo(listaDeAmigo, listaDeRevista, listaDeEmprestimo, listaDeReserva, ref quantidadeDeEmprestimos);
            }

            #endregion
        }

        static void CadastrarCategoria(Categoria[] listaDeCategoria, Revista[] listaDeRevista, ref int quantidadeDeCategorias)
        {
            Categoria categoria1 = new Categoria();
            Notificacao notificacao = new Notificacao();

            Console.WriteLine();
            Console.Write("Digite o nome da categoria: ");
            string nomeDaCategoria = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite a quantidade de dias que a categoria pode ser emprestada: ");
            string diasAEmprestarString = Console.ReadLine();
            int diasAEmprestar = int.Parse(diasAEmprestarString);

            categoria1.nome = nomeDaCategoria;
            categoria1.diasAEmprestar = diasAEmprestar;

            listaDeCategoria[quantidadeDeCategorias] = categoria1;
            quantidadeDeCategorias++;
        }

        #endregion

        #region Metodos de Listagem. [OK]

        static void ListarCaixas(Caixa[] listaDeCaixa)
        {
            Notificacao notificacao = new Notificacao();
            int contador = 0;

            if (listaDeCaixa[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "Nao existem caixas registradas.");
                return;
            }

            #region Realiza a contagem das caixas e mostra. [OK]

            for (int i = 0; i < listaDeCaixa.Length; i++)
            {
                if (listaDeCaixa[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=============== Caixas ===============");
            Console.WriteLine("");
            Console.WriteLine("{0, -10} | {1, -55} | {2, -35}", "Numero", "Etiqueta", "Cor de Caixa");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i <= contador; i++)
            {
                Console.Write("{0, -10} | {1, -55} | {2, -35}", listaDeCaixa[i].numero, listaDeCaixa[i].etiqueta, listaDeCaixa[i].cor);
                Console.WriteLine();
            }

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Lista de Caixas carregada com sucesso.");

            Console.WriteLine();
            Console.WriteLine("======================================");

            #endregion
        }

        static void ListarRevistas(Revista[] listaDeRevista)
        {
            Notificacao notificacao = new Notificacao();
            int contador = 0;

            if (listaDeRevista[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "Nao existem revistas registradas.");
                return;
            }

            #region Realiza a contagem das revistas e mostra. [OK]

            for (int i = 0; i < listaDeRevista.Length; i++)
            {
                if (listaDeRevista[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=============== Revistas ===============");
            Console.WriteLine("");
            Console.WriteLine("{0, -10} | {1, -55} | {2, -35}", "ID", "Tipo da Revista", "N. da Caixa");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i <= contador; i++)
            {
                Console.Write("{0, -10} | {1, -55} | {2, -35}", listaDeRevista[i].idRevista, listaDeRevista[i].tipoColecao, listaDeRevista[i].caixaArmazenada.numero);
                Console.WriteLine();
            }

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Lista de Revistas carregada com sucesso.");

            Console.WriteLine();
            Console.WriteLine("======================================");

            #endregion
        }

        static void ListarAmigos(Amigo[] listaDeAmigo)
        {
            Notificacao notificacao = new Notificacao();
            int contador = 0;

            if (listaDeAmigo[0] == null)
            {
                notificacao.ApresentarMensagem(ConsoleColor.Red, "Nao existem amigos registrados.");
                return;
            }

            #region Realiza a contagem das revistas e mostra. [OK]

            for (int i = 0; i < listaDeAmigo.Length; i++)
            {
                if (listaDeAmigo[i] == null)
                {
                    contador = i - 1;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=============== Amigos ===============");
            Console.WriteLine("");
            Console.WriteLine("{0, -10} | {1, -55} | {2, -35}", "ID", "Nome do Amigo", "Nome do Responsavel");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i <= contador; i++)
            {
                Console.Write("{0, -10} | {1, -55} | {2, -35}", listaDeAmigo[i].idAmigo, listaDeAmigo[i].nome, listaDeAmigo[i].nomeResponsavel);
                Console.WriteLine();
            }

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Lista de Amigos carregada com sucesso.");

            Console.WriteLine();
            Console.WriteLine("======================================");

            #endregion
        }

        static void ListarEmprestimosAberto(Emprestimo[] listaDeEmprestimo)
        {
            Notificacao notificacao = new Notificacao();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================== Emprestimos em Aberto ===================");
            Console.ResetColor();

            for (int i = 0; i < listaDeEmprestimo.Length; i++)
            {
                if (listaDeEmprestimo[i] == null)
                {
                    continue;
                }
                else
                {
                    if (listaDeEmprestimo[i].dataDevolucao >= DateTime.Today)
                    {
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Console.WriteLine("====== Amigo ======");
                        Console.WriteLine();
                        Console.WriteLine("Nome: " + listaDeEmprestimo[i].amigo.nome);
                        Console.WriteLine("Nome do responsavel: " + listaDeEmprestimo[i].amigo.nomeResponsavel);
                        Console.WriteLine("Telefone: " + listaDeEmprestimo[i].amigo.telefone);
                        Console.WriteLine("Endereco: " + listaDeEmprestimo[i].amigo.endereco);
                        Console.WriteLine();
                        Console.WriteLine("====== Revista ======");
                        Console.WriteLine();
                        Console.WriteLine("Tipo de colecao da revista: " + listaDeEmprestimo[i].revista.tipoColecao);
                        Console.WriteLine("Numero de edicao da revista: " + listaDeEmprestimo[i].revista.numeroEdicao);
                        Console.WriteLine("Ano da revista: " + listaDeEmprestimo[i].revista.anoRevista);
                        Console.WriteLine("Numero da caixa da revista: " + listaDeEmprestimo[i].revista.caixaArmazenada.numero);
                        Console.WriteLine();
                        Console.WriteLine("====== Datas ======");
                        Console.WriteLine();
                        Console.WriteLine("Data do emprestimo: " + listaDeEmprestimo[i].dataEmprestimo);
                        Console.WriteLine("Data de devolucao: " + listaDeEmprestimo[i].dataDevolucao);
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============================================================");
            Console.ResetColor();

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Emprestimos Abertos Carregados com sucessso.");
        }

        static void ListarEmprestimosDoMes(Emprestimo[] listaDeEmprestimo)
        {
            Notificacao notificacao = new Notificacao();

            int mes = 0;
            bool numeroValido = false;
            while (numeroValido == false)
            {
                Console.Write("Digite o mes a verificar: ");
                string mesEmString = Console.ReadLine();
                Console.WriteLine();

                numeroValido = int.TryParse(mesEmString, out mes);

                if (numeroValido == false)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "Dados incorretos, por favor, insira apenas numeros.");
                    continue;
                }
                else
                {
                    numeroValido = true;
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================== Emprestimos Mes {0} ===================", mes);
            Console.ResetColor();

            for (int i = 0; i < listaDeEmprestimo.Length; i++)
            {
                if (listaDeEmprestimo[i] == null)
                {
                    continue;
                }
                else
                {
                    if (listaDeEmprestimo[i].dataEmprestimo.Month == mes)
                    {
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Console.WriteLine("====== Amigo ======");
                        Console.WriteLine();
                        Console.WriteLine("Nome: " + listaDeEmprestimo[i].amigo.nome);
                        Console.WriteLine("Nome do responsavel: " + listaDeEmprestimo[i].amigo.nomeResponsavel);
                        Console.WriteLine("Telefone: " + listaDeEmprestimo[i].amigo.telefone);
                        Console.WriteLine("Endereco: " + listaDeEmprestimo[i].amigo.endereco);
                        Console.WriteLine();
                        Console.WriteLine("====== Revista ======");
                        Console.WriteLine();
                        Console.WriteLine("Tipo de colecao da revista: " + listaDeEmprestimo[i].revista.tipoColecao);
                        Console.WriteLine("Numero de edicao da revista: " + listaDeEmprestimo[i].revista.numeroEdicao);
                        Console.WriteLine("Ano da revista: " + listaDeEmprestimo[i].revista.anoRevista);
                        Console.WriteLine("Numero da caixa da revista: " + listaDeEmprestimo[i].revista.caixaArmazenada.numero);
                        Console.WriteLine();
                        Console.WriteLine("====== Datas ======");
                        Console.WriteLine();
                        Console.WriteLine("Data do emprestimo: " + listaDeEmprestimo[i].dataEmprestimo);
                        Console.WriteLine("Data de devolucao: " + listaDeEmprestimo[i].dataDevolucao);
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===========================================================");
            Console.ResetColor();

            notificacao.ApresentarMensagem(ConsoleColor.Yellow, "Emprestimos Abertos Carregados com sucessso.");
        }

        #endregion

        #region Metodos de Adicionar. [OK]

        static void AdicionarRevistaCategoria(Categoria[] listaDeCategoria, Revista[] listaDeRevista)
        {
            Notificacao notificacao = new Notificacao();
            int categoriaARegistrar = 0;

            Console.WriteLine();
            Console.Write("Digite o id da categoria para inserir revistas: ");
            string idDaCategoriaEmString = Console.ReadLine();
            int idDaCategoria = int.Parse(idDaCategoriaEmString);

            for (int i = 0; i < listaDeCategoria.Length; i++)
            {
                if (i == listaDeCategoria.Length - 1)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! Categoria inexistente, por favor, realize o cadastro primeiro.");
                    return;
                }
                else if (listaDeCategoria[i] != null && listaDeCategoria[i].idCategoria == idDaCategoria)
                {
                    categoriaARegistrar = i;
                    break;
                }
            }

            Console.WriteLine();
            Console.Write("Digite o id da revista para registar na categoria: ");
            string idDaRevistaEmString = Console.ReadLine();
            int idDaRevista = int.Parse(idDaRevistaEmString);

            for (int i = 0; i < listaDeRevista.Length; i++)
            {
                if (i == listaDeRevista.Length - 1)
                {
                    notificacao.ApresentarMensagem(ConsoleColor.Red, "ERRO! Revista inexistente, por favor, realize o cadastro primeiro.");
                    return;
                }
                else if (listaDeRevista[i] != null && listaDeRevista[i].idRevista == idDaRevista)
                {
                    listaDeCategoria[categoriaARegistrar].revistas[categoriaARegistrar] = listaDeRevista[i];
                }
            }
        }
        #endregion
    }
}
