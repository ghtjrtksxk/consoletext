using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    class ReadyScene
    {
        private Player _player;

        public void ReadName()
        {
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다. \n ");
            while (true)
            {
                Console.Clear();
                Console.Write("원하시는 이름을 설정해주세요 ( 2 ~ 6자 ) : ");
                string input_name = Console.ReadLine();

                if (input_name.Length < 2 || input_name.Length > 6)
                {
                    Console.Clear();
                    Console.WriteLine("이름이 너무 짧거나 깁니다.");
                    Thread.Sleep(2000);  //2초
                }
                else
                {
                    Console.Clear();
                    _player = new Player(input_name);

                    Console.WriteLine($"{_player.name} 님, 환영합니다!\n");

                    return;
                }
            }
        }
        public Player Name_return()
        {
            return _player;
        }

        public void ReadJob()
        {
            while (true)
            {
                Thread.Sleep(2000);
                Console.Clear(); //2초

                Console.Write("원하시는 직업을 설정해주세요. [1 : 탱커(Tanker), 2 : 암살자(Assassin), 3 : 저격수(Sniper)] :  ");
                string input_job = Console.ReadLine();
                bool isSuccess = int.TryParse(input_job, out _);

                if (!isSuccess)
                {
                    Console.Write("\n잘못된 입력입니다!");
                }
                else
                {
                    int job = int.Parse(input_job);

                    if (job >= 1 && job <= 3)
                    {
                        _player.job = (Job)job;

                        Console.WriteLine($"\n{_player.job}를 선택했습니다!");

                        return;
                    }
                    else
                    {
                        Console.Write("\n잘못된 입력입니다!");
                    }
                }
            }
        }
        public Player Job_return()
        {
            return _player;
        }
    }
}

