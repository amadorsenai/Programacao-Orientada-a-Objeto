namespace FinancaDeMesa.Util
{
    public class MenuUtil
    {
        public static void MenuDeslogado (){
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("           Seja bem-vindo à MobiTec          ");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("           Escolha 1 opção:                  ");
            System.Console.WriteLine("           1 - Cadastro de usuário           ");
            System.Console.WriteLine("           2 - Login de usuário              ");
            System.Console.WriteLine("           0 - Sair                          ");
            System.Console.WriteLine("=============================================");
            System.Console.Write("Código: ");
        }

        public static void MenuLogado (){
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("       Seja bem-vindo à MobiTec {USUARIO}    ");
            System.Console.WriteLine("=============================================");
            System.Console.WriteLine("           Parabéns por se logar!            ");
            System.Console.WriteLine("           1 - Cadastrar transações          ");
            System.Console.WriteLine("           2 - Exibir transações totais      ");
            System.Console.WriteLine("           3 - Relatar no Word               ");
            System.Console.WriteLine("           4 - Exportar banco de dados       ");
            System.Console.WriteLine("           0 - SAIR                          ");
            System.Console.WriteLine("=============================================");
            System.Console.Write("Código: ");
        }
    }
}