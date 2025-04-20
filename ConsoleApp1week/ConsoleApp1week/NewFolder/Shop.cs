using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    class Shop
    {
        private Player _player;
        private Inventory inventory;

        string alreadyPurchase = "이미 구매한 아이템입니다!";
        string lackGold = "Gold가 부족합니다!";
        Items[] sell_items;

        bool posShop = true;
        bool isItemPurchase = false;

        bool Sw1_complete = false; bool Sw2_complete = false; bool Sw3_complete = false;
        bool Sw4_complete = false; bool Sw5_complete = false; bool Sw6_complete = false;

        int itemNumber;
        public Shop(Player player_info)
        {
            this._player = player_info;

            sell_items = new Items[]
            {
                new Items(" ", " ", "woodenSword", 5 , "나무로 만든 검이다"," ", 100),
                new Items(" ", " ", "stoneSword", 10 , "돌로 만든 검이다"," ", 300),
                new Items(" ", " ", "ironSword", 15 , "철로 만든 검이다"," ", 700),
                new Items(" ", " ", "silverSword", 20, "은으로 만든 검이다.", " ", 1500),
                new Items(" ", " ", "goldSword", 30, "금으로 만든 검이다.", " ", 3000),
                new Items(" ", " ", "diamondSword", 40, "다이아몬드로 만든 검이다.", " ", 5000)
            };
        }

        public void itemShop()
        {
            while (posShop)
            {
                if(!isItemPurchase)
                {
                    Console.Clear();
                    Console.WriteLine("상점\n필요한 아이템을 얻을 수 있는 상점입니다.\n");
                    Console.WriteLine($"[보유 골드]\n{_player.gold} G\n");

                    for (int j = 0; j < sell_items.Length; j++)
                    {
                        Console.WriteLine(sell_items[j].name + " | " + sell_items[j].itemStat + " | " + sell_items[j].description);
                    }

                    Console.WriteLine("\n1. 아이템 구매");
                    Console.WriteLine("0. 나가기\n");
                    Console.Write("입력 : ");

                    string posShop_input = Console.ReadLine();
                    switch (posShop_input)
                    {
                        case "1":
                            isItemPurchase = true;
                            break;
                        case "0":
                            posShop = false;
                            Thread.Sleep(1000);
                            break;
                        default:
                            Console.Clear();
                            Console.Write("잘못된 입력입니다.");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else
                {  
                    Console.Clear();
                    Console.WriteLine("상점 - 아이템 구매\n아이템을 구매합니다.\n");
                    Console.WriteLine($"[보유 골드]\n{_player.gold} G\n");

                    for (int i = 0; i < sell_items.Length; i++)
                    {
                        itemNumber = i + 1;

                        Console.WriteLine("- " + itemNumber + "|"  + sell_items[i].name + " | " + sell_items[i].itemStat + " | " + sell_items[i].description + " | " + sell_items[i].price
                                                            + " | " + sell_items[i].buyState);
                    }

                    Console.WriteLine("\n- 0. 나가기\n");
                    Console.Write("구매할 아이템 (1~6) : ");
                    string posPurchaseInput = Console.ReadLine();   

                    switch (posPurchaseInput)
                    {
                        case "1":
                            if (Sw1_complete)
                            {
                                Console.WriteLine(alreadyPurchase);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                if (_player.gold < sell_items[0].price)
                                {
                                    Console.WriteLine(lackGold);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine(sell_items[0].name + " 를 구매했습니다!");
                                    Thread.Sleep(1500);
                                    //inventory.Items.Add(sell_items[0]);
                                    Sw1_complete = true;
                                    sell_items[0].buyState = "| 구매완료";
                                    _player.gold -= sell_items[0].price;
                                }
                            }
                            break;
                        case "2":
                            if (Sw2_complete)
                            {
                                Console.WriteLine(alreadyPurchase);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                if (_player.gold < sell_items[1].price)
                                {
                                    Console.WriteLine(lackGold);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine(sell_items[1].name + " 를 구매했습니다!");
                                    Thread.Sleep(1500);
                                    //inventory.Items.Add(sell_items[1]);
                                    Sw2_complete = true;
                                    sell_items[1].buyState = "| 구매완료";
                                    _player.gold -= sell_items[1].price;
                                }
                            }
                            break;
                        case "3":
                            if (Sw3_complete)
                            {
                                Console.WriteLine(alreadyPurchase);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                if (_player.gold < sell_items[2].price)
                                {
                                    Console.WriteLine(lackGold);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine(sell_items[2].name + " 를 구매했습니다!");
                                    Thread.Sleep(1500);
                                    //inventory.Items.Add(sell_items[2]);
                                    Sw3_complete = true;
                                    sell_items[2].buyState = " | 구매완료";
                                    _player.gold -= sell_items[2].price;
                                }
                            }
                            break;
                        case "4":
                            if (Sw4_complete)
                            {
                                Console.WriteLine(alreadyPurchase);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                if (_player.gold < sell_items[3].price)
                                {
                                    Console.WriteLine(lackGold);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine(sell_items[3].name + " 를 구매했습니다!");
                                    Thread.Sleep(1500);
                                    //inventory.Items.Add(sell_items[3]);
                                    Sw4_complete = true;
                                    sell_items[3].buyState = "| 구매완료";
                                    _player.gold -= sell_items[3].price;
                                }
                            }
                            break;
                        case "5":
                            if (Sw5_complete)
                            {
                                Console.WriteLine(alreadyPurchase);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                if (_player.gold < sell_items[4].price)
                                {
                                    Console.WriteLine(lackGold);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine(sell_items[4].name + " 를 구매했습니다!");
                                    Thread.Sleep(1500);
                                    //inventory.Items.Add(sell_items[4]);
                                    Sw5_complete = true;
                                    sell_items[4].buyState = "| 구매완료";
                                    _player.gold -= sell_items[4].price;
                                }
                            }
                            break;
                        case "6":
                            if (Sw6_complete)
                            {
                                Console.WriteLine(alreadyPurchase);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                if (_player.gold < sell_items[5].price)
                                {
                                    Console.WriteLine(lackGold);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine(sell_items[5].name + " 를 구매했습니다!");
                                    Thread.Sleep(1500);
                                    //inventory.Items.Add(sell_items[5]);
                                    Sw6_complete = true;
                                    sell_items[5].buyState = " | 구매완료";
                                    _player.gold -= sell_items[5].price;
                                }
                            }
                            break;
                        case "0":
                            isItemPurchase = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("잘못된 입력입니다.");
                            Thread.Sleep(1000);
                            break;
                    }
                }

            }

        }
    }
}
