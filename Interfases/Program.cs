using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    class Program
    {
        static void Main()
        {
            Player sonyWalkman = new Player();
            Console.WriteLine("Поздравляем с приобретением плеера Sony Walkman");
            sonyWalkman.Play();
            sonyWalkman.Pause();
            sonyWalkman.Record();
            sonyWalkman.Stop();

            // IPlayble sonyWalkman = new Player();
            // sonyWalkman. (можем вызвать методы из интерфейса IPlayable (Play, Pause, Stop), так как адрес sonyWalkman имеет тип IPlayable).
            // IRecordable sonyWalkman = new Player();
            // sonyWalkman.(можем вызвать методы из интерфейса IRecordable (Record, Pause, Stop), так как адрес sonyWalkman имеет тип IRecordable).

            // Delay
            Console.ReadKey();
        }
    }

    interface IPlayble
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayble, IRecordable
    {
        public void Pause() // метод Pause реализуется 1 раз для обоих интерфейсов, так как имеет одинаковое название в обоих интерфейсах: IPlayer и IRecordable
        {
            Console.WriteLine("Вы нажали кнопку 'Pause'");
        }

        public void Play()
        {
            Console.WriteLine("Вы нажали кнопку 'Play'");
        }

        public void Record()
        {
            Console.WriteLine("Вы нажали кнопку 'Record'");
        }

        public void Stop() // метод Stop реализуется 1 раз для обоих интерфейсов, так как имеет одинаковое название в обоих интерфейсах: IPlayer и IRecordable
        {
            Console.WriteLine("Вы нажали кнопку 'Stop'");
        }
    }
}
