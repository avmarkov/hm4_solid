using hm4_solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_solid
{
    public static class GameFactory
    {
        private static readonly Game Game;

        static GameFactory()
        {
            var settings = new Setting(0, 10, 7);
            var io = new ConsolFromIO();
            Game = new Game(settings, io);
        }

        public static Game GetInstance()
        {
            return Game;
        }

    }
}
