using System;

namespace KamaGamesNode
{
    class Program
    {
        static void Main()
        {
            Nodelist list = new Nodelist();
            list.AddElement("Петя");
            list.AddElement("Миша");
            list.AddElement("Настя");
            list.AddElement("Артем");
            list.AddElement("Игорь");
            list.AddElement("Егор");
            list.AddElement("Маша");
            list.AddElement("Марина");
            list.Present();
            list.Expand();
            list.Present();
        }
    }

    
}


