using SampSharp.Core;
using System.Text;
using SampSharp.Streamer;


namespace WasteLandWarriors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            new GameModeBuilder()
                .Use<GameMode>()
                
                .UseEncoding(encoding: Encoding.GetEncoding(1251))
                .Run();
        }
    }
}
