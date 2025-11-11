using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors.Others.Dialogs
{
    internal class ShopDialog
    {

        public static void ShowMainDialog(Player p)
        {
            var mainDialog = new ListDialog("{048A16}Магазин", "Принять", "Отмена");
            mainDialog.AddItem("{F06107}Поговорить с продавцом");
            mainDialog.AddItem("{F06107}Задания");
            mainDialog.AddItem("{22F22E}Продовольствие");
            mainDialog.AddItem("{22F22E}Снаряжение");
            mainDialog.AddItem("{22F22E}Разное");
            mainDialog.Response += DialogResponse;
            void DialogResponse(Object sender, DialogResponseEventArgs e)
            {
                if (e.DialogButton != DialogButton.Right )
                {
                    switch (e.ListItem)
                    {
                        case 0:
                            p.SendClientMessage("{8A8A8A}ВЫ: {E0D294}Йоу, расскажи о себе.");

                            p.SendClientMessage("{8A8A8A}ПРОДАВЕЦ: {E0D294}Приветствую путник, я местный продавец всякой всячины.");
                            p.SendClientMessage("{8A8A8A}ПРОДАВЕЦ: {E0D294}У меня ты можешь купить вещи первой необходимости.");

                            break;
                        case 1:
                            p.SendClientMessage("{8A8A8A}ПРОДАВЕЦ: {E0D294}Пока заданий нет.");
                            break;
                        case 2:
                            var foodShopDialog = new TablistDialog("Продовольствие",2,"Купить","Отмена");
                            foodShopDialog.Add(new[] { "{94E09A}Бутылка воды", "{4EA655} $20" });
                            foodShopDialog.Add(new[] { "{94E09A}Газировка", "{4EA655} $30" });
                            foodShopDialog.Add(new[] { "{94E09A}Водка", "{4EA655} $40" });
                            foodShopDialog.Add(new[] { "{94E09A}Пиво", "{4EA655} $25" });
                            foodShopDialog.Add(new[] { "{94E09A}Хлеб", "{4EA655} $10" });
                            foodShopDialog.Add(new[] { "{94E09A}Сухой паек", "{4EA655} $30" });
                            foodShopDialog.Add(new[] { "{94E09A}Пачка сигарет", "{4EA655} $20" });
                            foodShopDialog.Response += foodshopDialogResponse;
                            void foodshopDialogResponse(object sender, DialogResponseEventArgs e)
                            {
                                if(e.DialogButton != DialogButton.Right)
                                {
                                    switch (e.ListItem)
                                    {
                                        case 0:
                                            if(p.Money >= 20)
                                            {
                                                p.Money -= 20;
                                                p.SendClientMessage("{154516}Вы купили бутылку воды за {F71919}20$");
                                               // PlayerLootObject.AddtoInventory(p, 22);

                                            }
                                            break;
                                        case 1:
                                            if(p.Money >= 30)
                                            {
                                                p.Money -= 30;
                                                p.SendClientMessage("{154516}Вы купили газировку за {F71919}30$");
                                             //   PlayerLootObject.AddtoInventory(p, 23);
                                            }
                                            break;
                                        case 2:
                                            if(p.Money >= 40)
                                            {
                                                p.Money -= 40;
                                                p.SendClientMessage("{154516}Вы купили бутылку водки за {F71919}40$");
                                             //   PlayerLootObject.AddtoInventory (p, 9);
                                            }
                                            break;
                                        case 3:
                                            if(p.Money >= 25)
                                            {
                                                p.Money -= 25;
                                                p.SendClientMessage("{154516}Вы купили бутылку пива за {F71919}25$");
                                             //   PlayerLootObject.AddtoInventory(p, 24);
                                            }
                                            break;
                                        case 4:
                                            if(p.Money >= 10)
                                            {
                                                p.Money -= 10;
                                                p.SendClientMessage("{154516}Вы купили буханку хлеба за {F71919}10$");
                                            //    PlayerLootObject.AddtoInventory(p, 25);
                                                
                                            }
                                            break;
                                        case 5:
                                            if(p.Money >= 30)
                                            {
                                                p.Money -= 30;
                                                p.SendClientMessage("{154516}Вы купили сухпаёк за {F71919}30$");
                                            //    PlayerLootObject.AddtoInventory(p, 26);

                                            }
                                            break;
                                        case 6:
                                            if(p.Money >= 20)
                                            {
                                                p.Money -= 20;
                                                p.SendClientMessage("{154516}Вы купили пачку сигарет за {F71919}20$");
                                            //    PlayerLootObject.AddtoInventory(p, 8);
                                            }
                                        break;
                                    }
                                }
                            }
                            foodShopDialog.Show(p);
                            break;
                        case 3:
                            var snaryagaDialog = new TablistDialog("Снаряжение", 2, "Купить", "Отмена");
                            snaryagaDialog.Add(new[] { "{94E09A}Спички", "{4EA655} $10" });
                            snaryagaDialog.Add(new[] { "{94E09A}Бинт", "{4EA655} $15" });
                            snaryagaDialog.Add(new[] { "{94E09A}Аптечка", "{4EA655} $30" });
                            snaryagaDialog.Add(new[] { "{94E09A}Пустая канистра", "{4EA655} $40" });
                            snaryagaDialog.Add(new[] { "{94E09A}Канистра с бензином", "{4EA655} $60" });
                            snaryagaDialog.Add(new[] { "{94E09A}Палатка", "{4EA655} $50" });
                            snaryagaDialog.Add(new[] { "{94E09A}Мыло", "{4EA655} $15" });
                            snaryagaDialog.Response += snaryagaDialogResponse;
                            void snaryagaDialogResponse(object sender, DialogResponseEventArgs e)
                            {
                                if (e.DialogButton != DialogButton.Right)
                                {
                                    switch (e.ListItem)
                                    {
                                        case 0:
                                            if (p.Money >= 10)
                                            {
                                                p.Money -= 10;
                                                p.SendClientMessage("{154516}Вы купили спички за {F71919}10$");
                                               // PlayerLootObject.AddtoInventory(p, 21);

                                            }
                                            break;
                                        case 1:
                                            if (p.Money >= 15)
                                            {
                                                p.Money -= 15;
                                                p.SendClientMessage("{154516}Вы купили бинт за {F71919}15$");
                                              //  PlayerLootObject.AddtoInventory(p, 3);

                                            }
                                            break;
                                        case 2:
                                            if (p.Money >= 30)
                                            {
                                                p.Money -= 30;
                                                p.SendClientMessage("{154516}Вы купили аптечку за {F71919}30$");
                                             //   PlayerLootObject.AddtoInventory(p, 2);

                                            }
                                            break;
                                        case 3:
                                            if (p.Money >= 40)
                                            {
                                                p.Money -= 40;
                                                p.SendClientMessage("{154516}Вы купили канистру за {F71919}40$");
                                             //   PlayerLootObject.AddtoInventory(p, 27);

                                            }
                                            break;
                                        case 4:
                                            if(p.Money >= 60)
                                            {
                                                p.Money -= 60;
                                                p.SendClientMessage("{154516}Вы купили канистру с бензином за {F71919}60$");
                                            //    PlayerLootObject.AddtoInventory(p, 28);

                                            }
                                            break;
                                        case 5:
                                            if(p.Money >= 50)
                                            {
                                                p.Money -= 50;
                                                p.SendClientMessage("{154516}Вы купили палатку за {F71919}50$");
                                            //    PlayerLootObject.AddtoInventory(p, 29);
                                            }
                                            break;
                                        case 6:
                                            if(p.Money >= 15)
                                            {

                                                p.Money -= 15;
                                                p.SendClientMessage("{154516}Вы купили мыло за {F71919}15$");
                                            //    PlayerLootObject.AddtoInventory(p, 30);
                                            }
                                            break;
                                    }
                                }
                            }
                            snaryagaDialog.Show(p);
                            break;

                    }
                }
            }
            mainDialog.Show(p);
        }
    }
}
