// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace T
{
    public class NullAble
    {

        public string Descricao { get; set; }

        public int Idade { get; set; }

        public NullAble NullAblec { get; set; }

        public List<NullAble> NullAbles { get; set; }

    }
    public class Principal
    {

        public static async Task Process()
        {

            await Task.Run(() => 
            {
                Console.WriteLine("Entrei no método");
                System.Threading.Thread.Sleep(TimeSpan.FromMinutes(2)); 
            });
        
        }
        public static async Task Exec()
        {
            bool temProximo = true;
            do
            {
                await Process();
                temProximo = false; 

            } while (temProximo);
        }

        public static async Task Main(string[] args)
        {

            //var cronExpression = "*/1 8-23 * * 1-5";
            //var schedule = Cronos.CronExpression.Parse(cronExpression);

            //while (true)
            //{
            //    DateTime? nextOcurrence = schedule.GetNextOccurrence(DateTime.UtcNow);
            //    TimeSpan timeSpamDelay = nextOcurrence.HasValue ? nextOcurrence.Value.Subtract(DateTime.UtcNow) : new TimeSpan(0, 0, 3600 - (DateTime.UtcNow.Minute * 60));
            //    try
            //    {

            //        await Exec();

            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    finally
            //    {
            //        await Task.Delay(timeSpamDelay);
            //    }


            //}


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

