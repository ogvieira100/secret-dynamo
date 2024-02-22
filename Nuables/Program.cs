// See https://aka.ms/new-console-template for more information
using System.Text;

namespace T
{
    public class NullAble 
    {

        public string Descricao { get; set; }

        public int Idade { get; set; }

        public NullAble NullAblec { get; set; }

        public List<NullAble> NullAbles { get; set; }

    }
    public  class Principal{


        public static void Main(string[]args)
        {

            /*testando tratamento de nullos */
            var nul = new NullAble();
            nul.NullAbles = new List<NullAble>();   
            var desc =  nul.NullAblec?.Descricao;
            var desc2 = nul.NullAblec?.NullAblec?.Descricao;
            var desc3 = nul.NullAblec?.NullAbles.FirstOrDefault(x=>!string.IsNullOrEmpty(x.Descricao))?.Descricao;

            Console.WriteLine("Hello, World!");

            var cpf = "21961378043";
            Console.WriteLine(Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00"));




            StringBuilder numerosBuilder = new StringBuilder();
            var num = numerosBuilder.ToString();
            Console.WriteLine($"{numerosBuilder.ToString()}");
            Console.ReadKey();

        }
    
    }

 
}

