using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    internal class MyGame : GameManager
    {
        public override void StartGame()
        {
            var ready = new ReadyScene();
            ready.ReadName();
            ready.ReadJob();

            var lobby = new LobbyScene(ready.Name_return());

            lobby.Lobby();


            Console.WriteLine("게임이 종료되었습니다.");
            // 다음 게임의 흐름...
        }
    }
}
