namespace CRUD_App
{
    internal class Program
    {
        static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Controle de jogos ===");
            Console.WriteLine("Selecione uma opcao: ");
            Console.WriteLine("[1] Cadastrar um jogo");
            Console.WriteLine("[2] Excluir um jogo");
            Console.WriteLine("[3] Alterar um jogo");
            Console.WriteLine("[4] Localizar um jogo por nome");
            Console.WriteLine("[5] Listar os jogos por Genero");
            Console.WriteLine("[6] Listar os jogos por Console");
            Console.WriteLine("[7] Listar todos os jogos");
            Console.WriteLine("[9] Sair");
            Console.Write("Opcao: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void Main(string[] args)
        {
            ListaDeJogos listadejogos = new ListaDeJogos();
            List<Jogos> lista = new List<Jogos>(); 
            String nomejogo = "";
            int id = 0;


            Jogos jogo = new Jogos(1, "Ty Runner", "Jogo de corrida infinita", TipoGenero.Aventura, TipoConsole.Outro);
            listadejogos.Inserir(jogo);
            jogo = new Jogos(2, "Jackpot", "caca-niquel", TipoGenero.Casual, TipoConsole.Outro);
            listadejogos.Inserir(jogo);
            jogo = new Jogos(3, "Faroeste Zumbi", "Jogo de tiro", TipoGenero.Acao, TipoConsole.PC);
            listadejogos.Inserir(jogo);

            int op = 0; 
            while (op != 9)
            {
                op = ShowMenu();
                Console.Clear();
                switch (op)
                {
                    case 1: 
                        Console.WriteLine("Inserir um novo jogo");
                        jogo = new Jogos();
                        Console.Write("Id: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        jogo.Nome = Console.ReadLine();
                        Console.Write("Descricao: ");
                        jogo.Descricao = Console.ReadLine();
                        Console.Write("Informe o Genero Acao [0], Aventura [1], Casual [2], Puzze [3], Estrategia [4], Outro [5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Console PS4 [0], PS5 [1], Switch [2], Xbox One [3], Xbox Series X/S [4], PC [5], Outro[6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        if (listadejogos.Inserir(jogo))
                        {
                            Console.WriteLine("Jogo inserido!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo nao inserido!!!!");
                        }
                        Console.ReadKey();
                        break;
                    case 2: 
                        Console.WriteLine("Excluir jogo");
                        Console.Write("Informe o id do jogo: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (listadejogos.Excluir(id))
                        {
                            Console.WriteLine("Jogo excluido!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo nao excluido!!!!");
                        }
                        Console.ReadKey();
                        break;
                    case 3: 
                        Console.WriteLine("Alterar um jogo");
                        jogo = new Jogos();
                        Console.Write("Id: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        jogo.Nome = Console.ReadLine();
                        Console.Write("Descricao: ");
                        jogo.Descricao = Console.ReadLine();
                        Console.Write("Informe o Genero Acao [0], Aventura [1], Casual [2], Puzze [3], Estrategia [4], Outro [5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Console PS4 [0], PS5 [1], Switch [2], Xbox One [3], Xbox Series X/S [4], PC [5], Outro[6]: ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        if (listadejogos.Alterar(jogo))
                        {
                            Console.WriteLine("Jogo alterado!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Jogo nao alterado!!!!");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Localizar jogos");
                        Console.Write("Informe o nome do jogo: ");
                        nomejogo = Console.ReadLine();
                        lista = listadejogos.Localizar(nomejogo);

                        foreach (var j in lista)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5: 
                        Console.WriteLine("Listar todos os jogos por genero");
                        Console.Write("Informe o Genero Acao [0], Aventura [1], Casual [2], Puzze [3], Estrategia [4], Outro [5]: ");
                        TipoGenero genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());
                        lista = listadejogos.ListarPorGenero(genero);

                        foreach (var j in lista)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6: 
                        Console.WriteLine("Listar todos os jogos por console");
                        Console.Write("Informe o Console PS4 [0], PS5 [1], Switch [2], Xbox One [3], Xbox Series X/S [4], PC [5], Outro[6]: ");
                        TipoConsole console = (TipoConsole)Convert.ToInt32(Console.ReadLine());
                        lista = listadejogos.ListarPorConsole(console);

                        foreach (var j in lista)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 7: 
                        Console.WriteLine("Listar todos os jogos");
                        foreach (var j in listadejogos.Jogos)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
