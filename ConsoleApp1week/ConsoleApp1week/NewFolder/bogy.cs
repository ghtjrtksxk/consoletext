using System.Dynamic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System;

internal class MainScene
{
    static void Main(string[] args)
    {
        var readyName = new GetName(); //겟네임이라는 지역 생성, 플레이어 하나
        readyName.ReadName();

        var str_Name = readyName.GetPlayer();

        var readyJob = new GetJob(str_Name); //겟잡이라는 지역에도 플레이어 하나
        readyJob.ReadJob();

        var str_Job = readyJob.GetPlayer();

        var mainAction = new MainAction(str_Name, str_Job);
        mainAction.Show_mainScene();

        //while(true) //유니티 기준 Update()
        //{

        //    string input_name = Console.ReadLine();

        //    break;
        //}

        Console.WriteLine("게임이 종료되었습니다.");
    }
}

class GetName // 지역
{
    private Player name_player;

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
                name_player = new Player(input_name);

                Console.WriteLine($"{name_player.name} 님, 환영합니다!\n");

                return;
            }
        }
    }

    public Player GetPlayer()
    {
        return name_player;
    }
}
class GetJob //지역
{
    bool isGetJob = false;

    private Player job_player; 

    public GetJob(Player player)
    {
        this.job_player = player;
    }

    public void ReadJob()
    {
        while (!isGetJob)
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
                    job_player.job = (Job)job;

                    Console.WriteLine($"\n{job_player.job}를 선택했습니다!");

                    isGetJob = true;
                }
                else
                {
                    Console.Write("\n잘못된 입력입니다!");
                }
            }
        }
    }
    public Player GetPlayer()
    {
        return job_player;
    }
}
class MainAction
{
    private Player User_name;
    private Player User_job;

    string Armor1_price; string Armor2_price; string Armor3_price;
    string Weapon1_price; string Weapon2_price; string Weapon3_price;

    bool Armor1_complete = false; bool Armor2_complete = false; bool Armor3_complete = false;
    bool Weapon1_complete = false; bool Weapon2_complete = false; bool Weapon3_complete = false;

    string Armor1_info = "- 수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. ";
    string Armor2_info = "- 무쇠갑옷 | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. ";
    string Armor3_info = "- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. ";
    string Weapon1_info = "- 낡은 검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검입니다. ";
    string Weapon2_info = "- 청동 도끼 | 공격력 +5 | 어디선가 사용됐던 것 같은 도끼입니다. ";
    string Weapon3_info = "- 스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. ";

    List<string> inventory = new List<string>();

    private int gold = 1500;

    bool isShowStatus = false;

    bool isInventoryEquip = false;
    bool isEquip_Armor1 = false;
    bool isEquip_Armor2 = false;
    bool isEquip_Armor3 = false;
    bool isEquip_Weapon1 = false;
    bool isEquip_Weapon2 = false;
    bool isEquip_Weapon3 = false;

    public MainAction(Player player, Player player1)
    {
        this.User_name = player;
        this.User_job = player1;
    }

    public void Show_mainScene()
    {
        //bool isGameOver = false;
        //while (!isGameOver)
        //{
        //    Thread.Sleep(1500);
        //    Console.Clear();
        //    Console.WriteLine($"스파르타 마을에 오신 {User_name.name} 님, 환영합니다.");
        //    Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

        //    Console.WriteLine("1. 상태 보기 \n2. 인벤토리 \n3. 상점\n\n0. 게임종료");
        //    Console.Write("원하시는 행동을 입력해주세요. : ");

        //    string MainScene_input = Console.ReadLine();

        //    switch (MainScene_input)
        //    {
        //        case "1":
        //            ShowStatus();
        //            break;
        //        case "2":
        //            ShowInventory();
        //            break;
        //        case "3":
        //            ShowShop();
        //            break;
        //        case "0":
        //            isGameOver = true;
        //            break;
        //        default:
        //            Console.Write("잘못된 입력입니다.");
        //            break;
        //    }
        //}
    }
    public void ShowStatus()
    {
        //Console.Clear();
        //Console.WriteLine($"{User_name.name} 님의 상태");
        //Console.WriteLine("캐릭터의 정보가 표시됩니다.");

        //Console.WriteLine("Lv : 1");
        //Console.WriteLine("공격력 : 10");
        //Console.WriteLine($"직업 : {User_job.job}");
        //Console.WriteLine("방어력 : 5");
        //Console.WriteLine($"Gold : {gold} G");
        //Console.WriteLine("체력 : 100");

        //Console.WriteLine("\n0. 나가기\n");
        //Console.Write("입력 : ");
        //string Status_input = Console.ReadLine();
        //switch (Status_input)
        //{
        //    case "0":
        //        break;
        //    default:
        //        Console.Clear();
        //        Console.Write("잘못된 입력입니다.");
        //        Thread.Sleep(1000);
        //        ShowStatus();
        //        break;
        //}
    }

    public void ShowInventory()
    {
        int item_count = inventory.Count;

        Console.Clear();
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine($"보유 중인 아이템 수 : {item_count}\n");
        Console.WriteLine("[아이템 목록]\n");

        for (int i = 0; 0 < inventory.Count; i++)
        {
            if (!isInventoryEquip)
            {
                Console.WriteLine(inventory[i]);
            }
            else
            {
                Console.Write(i + 1 + " ");
            }
        }
        if (!isInventoryEquip)
        {
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기\n");
            Console.Write("입력 : ");
        }
        else
        {
            if (inventory.Count == 1)
            {
                Console.WriteLine("장착할 아이템 (1) : ");
            }
            else if (inventory.Count > 1)
            {
                Console.WriteLine("장착할 아이템 : ");
            }
            Console.WriteLine("0. 나가기\n");
            Console.Write("입력 : ");
        }

        string Inventory_input = Console.ReadLine();
        switch (Inventory_input)
        {
            case "1":
                isInventoryEquip = true;
                ShowInventory();
                break;
            case "0":
                isInventoryEquip = false;
                ShowInventory();
                break;
            default:
                Console.Clear();
                Console.Write("잘못된 입력입니다.");
                Thread.Sleep(1000);
                ShowInventory();
                break;
        }
    }

    public void ShowShop()
    {
        Console.Clear();
        Console.WriteLine("상점\n필요한 아이템을 얻을 수 있는 상점입니다.\n");
        Console.WriteLine($"[보유 골드]\n{gold} G\n");

        Console.WriteLine(Armor1_info);
        Console.WriteLine(Armor2_info);
        Console.WriteLine(Armor3_info);
        Console.WriteLine(Weapon1_info);
        Console.WriteLine(Weapon2_info);
        Console.WriteLine(Weapon3_info);

        Console.WriteLine("\n1. 아이템 구매");
        Console.WriteLine("0. 나가기\n");
        Console.WriteLine("입력 : ");

        string shop_input = Console.ReadLine();
        switch (shop_input)
        {
            case "1":
                Shopping();
                break;
            case "0":
                break;
            default:
                Console.Clear();
                Console.Write("잘못된 입력입니다.");
                Thread.Sleep(1000);
                ShowShop();
                break;
        }
    }

    public void Shopping()
    {
        if (!Armor1_complete)
        {
            Armor1_price = "1000 G";
        }
        else
        {
            Armor1_price = "구매완료";
        }

        if (!Armor2_complete)
        {
            Armor2_price = " 2000 G";
        }
        else
        {
            Armor2_price = "구매완료";
        }

        if (!Armor3_complete)
        {
            Armor3_price = "3500 G";
        }
        else
        {
            Armor3_price = "구매완료";
        }

        if (!Weapon1_complete)
        {
            Weapon1_price = "600 G";
        }
        else
        {
            Weapon1_price = "구매완료";
        }

        if (!Weapon2_complete)
        {
            Weapon2_price = "1500 G";
        }
        else
        {
            Weapon2_price = "구매완료";
        }

        if (!Weapon3_complete)
        {
            Weapon3_price = "2500 G";
        }
        else
        {
            Weapon3_price = "구매완료";
        }

        Console.Clear();
        Console.WriteLine("상점 - 아이템 구매\n아이템을 구매합니다.\n");
        Console.WriteLine($"[보유 골드]\n{gold} G\n");

        Console.WriteLine("- 1. " + Armor1_info + Armor1_price);
        Console.WriteLine("- 2. " + Armor2_info + Armor2_price);
        Console.WriteLine("- 3. " + Armor3_info + Armor3_price);
        Console.WriteLine("- 4. " + Weapon1_info + Weapon1_price);
        Console.WriteLine("- 5. " + Weapon2_info + Weapon2_price);
        Console.WriteLine("- 6. " + Weapon3_info + Weapon3_price);

        Console.WriteLine("\n- 0. 나가기\n");
        Console.Write("구매할 아이템 (1~6) : ");
        string Shopping_input = Console.ReadLine();

        switch (Shopping_input)
        {
            case "1":
                if (Armor1_complete)
                {
                    Console.WriteLine("이미 구매한 아이템입니다!");
                    Thread.Sleep(1000);
                }
                else
                {
                    if (gold < 1000)
                    {
                        Console.WriteLine("Gold가 부족합니다!");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("수련자 갑옷을 구매했습니다!");
                        Thread.Sleep(1500);
                        inventory.Add(Armor1_info);
                        Armor1_complete = true;
                        gold -= 1000;
                    }
                }
                Shopping();
                break;
            case "2":
                if (Armor2_complete)
                {
                    Console.WriteLine("이미 구매한 아이템입니다!");
                    Thread.Sleep(1000);
                }
                else
                {
                    if (gold < 2000)
                    {
                        Console.WriteLine("Gold가 부족합니다!");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("무쇠 갑옷을 구매했습니다!");
                        Thread.Sleep(1500);
                        inventory.Add(Armor2_info);
                        Armor2_complete = true;
                        gold -= 2000;
                    }
                }
                Shopping();
                break;
            case "3":
                if (Armor3_complete)
                {
                    Console.WriteLine("이미 구매한 아이템입니다!");
                    Thread.Sleep(1000);
                }
                else
                {
                    if (gold < 3500)
                    {
                        Console.WriteLine("Gold가 부족합니다!");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("스파르타의 갑옷을 구매했습니다!");
                        Thread.Sleep(1500);
                        inventory.Add(Armor3_info);
                        Armor3_complete = true;
                        gold -= 3500;
                    }
                }
                Shopping();
                break;
            case "4":
                if (Weapon1_complete)
                {
                    Console.WriteLine("이미 구매한 아이템입니다!");
                    Thread.Sleep(1000);
                }
                else
                {
                    if (gold < 600)
                    {
                        Console.WriteLine("Gold가 부족합니다!");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("낡은 검을 구매했습니다!");
                        Thread.Sleep(1500);
                        inventory.Add(Weapon1_info);
                        Weapon1_complete = true;
                        gold -= 600;
                    }
                }
                Shopping();
                break;
            case "5":
                if (Weapon2_complete)
                {
                    Console.WriteLine("이미 구매한 아이템입니다!");
                    Thread.Sleep(1000);
                }
                else
                {
                    if (gold < 1500)
                    {
                        Console.WriteLine("Gold가 부족합니다!");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("청동 도끼를 구매했습니다!");
                        Thread.Sleep(1500);
                        inventory.Add(Weapon2_info);
                        Weapon2_complete = true;
                        gold -= 1500;
                    }
                }
                Shopping();
                break;
            case "6":
                if (Weapon3_complete)
                {
                    Console.WriteLine("이미 구매한 아이템입니다!");
                    Thread.Sleep(1000);
                }
                else
                {
                    if (gold < 2500)
                    {
                        Console.WriteLine("Gold가 부족합니다!");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("스파르타 창을 구매했습니다!");
                        Thread.Sleep(1500);
                        inventory.Add(Weapon3_info);
                        Weapon3_complete = true;
                        gold -= 2500;
                    }
                }
                Shopping();
                break;
            case "0":
                ShowShop();
                break;
            default:
                Console.Clear();
                Console.WriteLine("잘못된 입력입니다.");
                Thread.Sleep(1000);
                Shopping();
                break;
        }
    }
}
class Player
{
    public string name;
    public Job job;

    public Player(string name, Job job = Job.Tanker)
    {
        this.name = name;
        this.job = job;
    }
}

public enum Job
{
    Tanker = 1,
    Assassin,
    Sniper
}