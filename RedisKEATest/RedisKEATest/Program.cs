using StackExchange.Redis;
using System.Threading;
namespace RedisKEATest
{
    public class Program
    {
        public static string RedisConnectStr = "XXX.XX.XX.XX:XXXX,abortConnect=false,password=*****";//Redis連線字串請替換IP paswword
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(RedisConnectStr);//建立Redis連線
            IDatabase db = redis.GetDatabase(0);
            for (int i = 1; i <= 100000; i++)
            {
                db.HashSet("Monkey", "Count", i);//寫入HashSet
                //Thread.Sleep(100);
            }
        }
    }
}