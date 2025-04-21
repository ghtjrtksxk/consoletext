using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    class Shop
    {
        private Player _player;
        private Inventory _inventory;

        string alreadyPurchase = "이미 구매한 아이템입니다!";
        string lackGold = "Gold가 부족합니다!";
        
        Items[] sell_items;

        bool posShop = true;
        bool posPurchase = false;

        public Shop(Player player_info)
        {
            this._player = player_info;
            this._inventory = new Inventory(player_info);

            sell_items = new Items[]
            {
                new Items("woodenSword", 5 , "나무로 만든 검이다", 100),
                new Items("stoneSword", 10 , "돌로 만든 검이다", 300),
                new Items("ironSword", 15 , "철로 만든 검이다", 700),
                new Items("silverSword", 20, "은으로 만든 검이다.", 1500),
                new Items("goldSword", 30, "금으로 만든 검이다.", 3000),
                new Items("diamondSword", 40, "다이아몬드로 만든 검이다.", 5000)
            };
        }

        public void itemShop()
        {
            while (posShop) // posLobby < ㅡ > posShop < ㅡ > posPurchase 가장 밖의 반복문 조건을 불만족시켜야 나갈 수 있음
            {
                if(!posPurchase)
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

                    int result = LobbyScene.CheckInput(0, 1);
                   
                        switch (result)
                    {
                        case 1:
                            posPurchase = true;
                            break;
                        case 0:
                            posShop = false;
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else // (posPurchase)
                {  
                    Console.Clear();
                    Console.WriteLine("상점 - 아이템 구매\n아이템을 구매합니다.\n");
                    Console.WriteLine($"[보유 골드]\n{_player.gold} G\n");

                    for (int i = 0; i < sell_items.Length; i++)
                    {
                        Console.WriteLine($"- {(i + 1)}. {sell_items[i].name} | {sell_items[i].itemStat} | {sell_items[i].description} | {(_inventory.inventory_items.Contains(sell_items[i]) ? "구매완료" : $"{sell_items[i].price} G")}");
                    }

                    Console.WriteLine("\n- 0. 나가기\n");
                    Console.Write($"구매할 아이템 선택 (1 ~ {sell_items.Length})");

                    int result = LobbyScene.CheckInput(0, sell_items.Length);  

                    switch (result)
                    {
                        case 0:
                            posPurchase = false;
                            break;

                        default:
                            int targetItem = result - 1;
                            
                            if (_inventory.inventory_items.Contains(sell_items[targetItem]))
                            {
                                Console.WriteLine(alreadyPurchase);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                if (_player.gold < sell_items[targetItem].price)
                                {
                                    Console.WriteLine(lackGold); //골드가 부족합니다
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine(sell_items[targetItem].name + " 를 구매했습니다!");
                                    Thread.Sleep(1500);
                                    _inventory.Add(targetItem);
                                    _player.gold -= sell_items[targetItem].price;
                                }
                                
                            }
                            break;

                                //case "2":
                                //    if (Sw2_complete)
                                //    {
                                //        Console.WriteLine(alreadyPurchase);
                                //        Thread.Sleep(1000);
                                //    }
                                //    else
                                //    {
                                //        if (_player.gold < sell_items[1].price)
                                //        {
                                //            Console.WriteLine(lackGold);
                                //            Thread.Sleep(1000);
                                //        }
                                //        else
                                //        {
                                //            Console.WriteLine(sell_items[1].name + " 를 구매했습니다!");
                                //            Thread.Sleep(1500);
                                //            _player.gold -= sell_items[1].price;
                                //        }
                                //    }
                                //    break;
                                //case "3":
                                //    if (Sw3_complete)
                                //    {
                                //        Console.WriteLine(alreadyPurchase);
                                //        Thread.Sleep(1000);
                                //    }
                                //    else
                                //    {
                                //        if (_player.gold < sell_items[2].price)
                                //        {
                                //            Console.WriteLine(lackGold);
                                //            Thread.Sleep(1000);
                                //        }
                                //        else
                                //        {
                                //            Console.WriteLine(sell_items[2].name + " 를 구매했습니다!");
                                //            Thread.Sleep(1500);
                                //            Sw3_complete = true;
                                //            _player.gold -= sell_items[2].price;
                                //        }
                                //    }
                                //    break;
                                //case "4":
                                //    if (Sw4_complete)
                                //    {
                                //        Console.WriteLine(alreadyPurchase);
                                //        Thread.Sleep(1000);
                                //    }
                                //    else
                                //    {
                                //        if (_player.gold < sell_items[3].price)
                                //        {
                                //            Console.WriteLine(lackGold);
                                //            Thread.Sleep(1000);
                                //        }
                                //        else
                                //        {
                                //            Console.WriteLine(sell_items[3].name + " 를 구매했습니다!");
                                //            Thread.Sleep(1500);
                                //            _player.gold -= sell_items[3].price;
                                //        }
                                //    }
                                //    break;
                                //case "5":
                                //    if (Sw5_complete)
                                //    {
                                //        Console.WriteLine(alreadyPurchase);
                                //        Thread.Sleep(1000);
                                //    }
                                //    else
                                //    {
                                //        if (_player.gold < sell_items[4].price)
                                //        {
                                //            Console.WriteLine(lackGold);
                                //            Thread.Sleep(1000);
                                //        }
                                //        else
                                //        {
                                //            Console.WriteLine(sell_items[4].name + " 를 구매했습니다!");
                                //            Thread.Sleep(1500);
                                //            _player.gold -= sell_items[4].price;
                                //        }
                                //    }
                                //    break;
                                //case "6":
                                //    if (Sw6_complete)
                                //    {
                                //        Console.WriteLine(alreadyPurchase);
                                //        Thread.Sleep(1000);
                                //    }
                                //    else
                                //    {
                                //        if (_player.gold < sell_items[5].price)
                                //        {
                                //            Console.WriteLine(lackGold);
                                //            Thread.Sleep(1000);
                                //        }
                                //        else
                                //        {
                                //            Console.WriteLine(sell_items[5].name + " 를 구매했습니다!");
                                //            Thread.Sleep(1500);
                                //            _player.gold -= sell_items[5].price;
                                //        }
                                //    }
                                //    break;
                                }
                }
            }
        }
    }
}
