using System;

namespace Lesson13_31_08_2021
{
interface IPlayable
{
    void Play();

    void Pause();
    void Stop();
}
interface IRecodable
{
    void Record();
    void Pause();
    void Stop();
}
class Player:IPlayable,IRecodable
{
  public void Play()=>System.Console.WriteLine("Play");
  public void Pause()=>System.Console.WriteLine("Pause");
  public void Stop()=>System.Console.WriteLine("Stop");
  public void Record()=>System.Console.WriteLine("Record"); 
}

    class Program
    {
        static void Main(string[] args)
        {
            Player player= new Player();
            Play(player);
        }
        public static void Play(Player player)
        {
            player.Pause();
            player.Play();
            player.Record();
            player.Stop();
        }
    }
}
