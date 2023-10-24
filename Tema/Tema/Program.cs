namespace Tema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string usernamecorect = "fastan";
            const string passwordcorect = "depend";

            bool autentifacare = false;

            while(!autentifacare)
            {
                Console.WriteLine("Introduceti username: ");
                string username=Console.ReadLine();
                Console.WriteLine("Introduceti password: ");
                string password=Console.ReadLine();
                if (username == usernamecorect && password == passwordcorect) 
                {
                    Console.WriteLine("Bine ai venit, " + usernamecorect);
                    autentifacare=true;
                }
                else
                {
                    Console.WriteLine("Autentificare esuata. Incercati din nou. ");

                }
            }
        }
    }
}