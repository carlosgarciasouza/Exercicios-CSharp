

/*--- Manipulando Arrays ---*/
namespace testArray
{
    class Program
    {
        static void Main(String[] args)
        {
            //tipo[parametro] nome = new string[tamanho]{};
            string[] produtos = new string[5]
            {
                "Fifa 22", //0 ==> indice 1
                "Minecraft", //1 ==> indice 2
                "Need For Speed", //2 ==> indice 3
                "Forza", //3 ==> indice 4
                "Call of Duty" //4 ==> indice 5
            };


            //redeclaração funciona igual variaveis:

            produtos[0] = "Fifa 23";
            Console.WriteLine(produtos[0]);
        }
    }
}
/*--- Manipulando Arrays ---*/

