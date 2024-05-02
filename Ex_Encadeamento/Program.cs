namespace Ex_Encadeamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Endereco end = new Endereco("14804-073", "Araraquara", "SP", "Antonio Pinheiro", "Rua", "Parque Residencial Vale do Sol", 170, "");
            Pessoa pes = new Pessoa("Othavio", 21, end);
            

            Console.WriteLine(pes.ToString());

        }
    }
}
