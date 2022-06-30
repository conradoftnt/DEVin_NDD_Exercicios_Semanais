namespace GeraEstoque.Screens
{
    public static class MenuScreen
    {
        public static void Iniciar()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Seja bem vindo");
            Console.Write(Environment.NewLine);

            Console.Write(@"Seja bem vindo ao GeraEstoque 1.0
----------------------------------------
1  Cadastrar produto
2  Consultar produto
3  Modificar produto
4  Excluir produto
0  Sair

Digite a opção: ");

            var opcao = Console.ReadLine();

            Console.Write(Environment.NewLine);

            switch (opcao)
            {
                case "1":
                    CriarProdutoScreen.Iniciar();
                    Iniciar();
                    break;

                case "2":
                    Iniciar();
                    break;

                case "3":
                    Iniciar();
                    break;

                case "4":
                    Iniciar();
                    break;

                case "0":
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                default:
                    Iniciar();
                    break;
            }
        }
    }
}