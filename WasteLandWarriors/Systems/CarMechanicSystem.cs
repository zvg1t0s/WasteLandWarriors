using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Entities;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors.Systems
{
    public class CarMechanicSystem
    {
        
        public static void Mechanic(Player p)
        {
            var mechanicMenu = new ListDialog("Механик", "Принять", "Отмена");

            mechanicMenu.AddItem("Перебить замки");
            mechanicMenu.AddItem("Тюнинг");
            mechanicMenu.Response += onMechanicDialogResponse;
            mechanicMenu.Show(p);
            p.ClearAnimations();
            void onMechanicDialogResponse(object sender, DialogResponseEventArgs e) {
                if (e.ListItem == 0)
                {
                    var veh = VehicleManager.FindClosestCar(new SampSharp.GameMode.Vector3(-196.06013f, 1219.5857f, 19.902187f), 10f);
                    if (veh != null && veh.Owner == null)
                    {
                        var vehicleAccept = new MessageDialog("Покупка", $"Вы хотите купить \"{veh.vehicle.Model.ToString()}\" за {veh.Cost}$?", "Купить", "Отмена");
                        vehicleAccept.Response += OnVehAcceptResponse;
                        vehicleAccept.Show(p);
                        void OnVehAcceptResponse(object sender, DialogResponseEventArgs e)
                        {
                            if (e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                            {
                                if (p.Money >= veh.Cost)
                                {
                                    VehicleManager.RespawnVehicle(veh);
                                    p.user.AddCar(new VehicleEntity(veh.ModelType, 1000, new SampSharp.GameMode.Vector3(0,0,0), p.user, veh.Cost));


                                }
                                else
                                {
                                    p.SendClientMessage("{BA0000}У вас недостаточно денег!");
                                }
                            }
                        }
                    }
                }
                else if (e.ListItem == 1) {

                    var vehicles = new ListDialog("Тюнинг", "Выбрать", "Отмена");
                    vehicles.Response += onTuneMenuCarsResponse;
                    
                    foreach (var vehicle in p.user.cars) {
                        vehicles.AddItem(vehicle.ModelType.ToString());
                        
                    }
                    vehicles.Show(p);
                    void onTuneMenuCarsResponse(object sender, DialogResponseEventArgs e){
                        for (int i = 0; i < p.user.cars.Count; i++)
                        {
                            if (e.ListItem == i)
                            {
                                var tuneVeh = p.user.cars[i];
                                var tuneMenu = new ListDialog("Выберите тюнинг", "Выбрать", "Отмена");
                                tuneMenu.Response += tuneMenuResponse;

                                tuneMenu.AddItem("Поменять цвет");
                                tuneMenu.AddItem("Броня");
                                tuneMenu.AddItem("Нитро");
                                tuneMenu.AddItem("Аэрография");
                                tuneMenu.AddItem("Колёса");
                                tuneMenu.AddItem("Гидравлика");
                                tuneMenu.AddItem("Обвесы");
                                

                                tuneMenu.Show(p);

                                void tuneMenuResponse(object sender, DialogResponseEventArgs e)
                                {
                                    if (e.ListItem == 0)
                                    {
                                        
                                        var carColorInput = new InputDialog("Введите цвет", "Введите id цветов через запятую\nНапример - 2 , 0", false, "Принять", "Отмена");
                                        carColorInput.Response += carColorInputResponse;
                                        carColorInput.Show(p);
                                        void carColorInputResponse(object sender, DialogResponseEventArgs e)
                                        {
                                            if (e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                            {
                                                int[] num;
                                                num = Array.ConvertAll(e.InputText.Split(','), int.Parse);
                                                tuneVeh.vehicle.ChangeColor(num[0], num[1]);

                                                var carColorAccept = new MessageDialog("1", "Подтвердите покупку: 1500$", "Купить", "Отмена");
                                                carColorAccept.Response += carcolorAcceptResponse;
                                                carColorAccept.Show(p);
                                                void carcolorAcceptResponse(object sender, DialogResponseEventArgs e)
                                                {
                                                    if (e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if (p.Money >= 1500)
                                                        {
                                                            tuneVeh.Color1 = num[0];
                                                            tuneVeh.Color2 = num[1];
                                                            p.Money -= 1500;
                                                        }
                                                        else
                                                        {
                                                            p.SendClientMessage("У вас недостаточно денег!");
                                                        }

                                                    }
                                                    tuneVeh.vehicle.ChangeColor(tuneVeh.Color1, tuneVeh.Color2);
                                                    carColorAccept.Response -= carcolorAcceptResponse;
                                                }
                                            }

                                        }
                                    }
                                    else if (e.ListItem == 1) {
                                        var armourSelect = new ListDialog("Выберите броню", "Выбрать", "Отмена");
                                        armourSelect.AddItem("10K HP");
                                        armourSelect.AddItem("50K HP");
                                        armourSelect.Response += armourSelectResponse;
                                        armourSelect.Show(p);
                                        void armourSelectResponse(object sender, DialogResponseEventArgs d)
                                        {
                                            if(d.ListItem == 0)
                                            {
                                                var dialogAccept = new MessageDialog("1","Подтвердите покупку: 20000$", "Купить","Отмена");
                                                dialogAccept.Response += dialogAcceptResponse;
                                                dialogAccept.Show(p);
                                                void dialogAcceptResponse(object sender, DialogResponseEventArgs f)
                                                {
                                                    p.SendClientMessage("response");
                                                    if(f.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if(p.Money >= 20000)
                                                        {
                                                            tuneVeh.VehicleHealth = 10000;
                                                            tuneVeh.vehicle.Health = tuneVeh.VehicleHealth;
                                                            p.Money -= 20000;
                                                            p.SendClientMessage("Вы успешно купили броню x10");
                                                        }
                                                        else
                                                        {
                                                            p.SendClientMessage("У вас недостаточно денег!");
                                                        }
                                                    }
                                                }
                                                armourSelect.Response -= armourSelectResponse;
                                            }
                                            else if(d.ListItem == 1)
                                            {
                                                var dialogAccept = new MessageDialog("1", "Подтвердите покупку: 90000$", "Купить", "Отмена");
                                                dialogAccept.Response += dialogAcceptResponse;
                                                dialogAccept.Show(p);
                                                void dialogAcceptResponse(object sender, DialogResponseEventArgs f)
                                                {
                                                    if (f.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if (p.Money >= 90000)
                                                        {
                                                            tuneVeh.VehicleHealth = 50000;
                                                            tuneVeh.vehicle.Health = tuneVeh.VehicleHealth;
                                                            p.Money -= 90000;
                                                            p.SendClientMessage("Вы успешно купили броню x50!");
                                                        }
                                                        else
                                                        {
                                                            p.SendClientMessage("У вас недостаточно денег!");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if(e.ListItem == 2)
                                    {
                                        var nitroSelect = new ListDialog("Нитро","Выбрать", "Отмена");
                                        nitroSelect.AddItem("NITRO X2");
                                        nitroSelect.AddItem("NITRO X5");
                                        nitroSelect.AddItem("NITRO X10");
                                        nitroSelect.Response += nitroselectResponse;
                                        nitroSelect.Show(p);
                                        void nitroselectResponse(object sender, DialogResponseEventArgs e){
                                            if (e.ListItem == 0) {
                                                var dialogAccept = new MessageDialog("1", "Подтвердите покупку нитро X2: 1000$", "Купить", "Отмена");
                                                dialogAccept.Response += dialogAcceptResponse;
                                                dialogAccept.Show(p);
                                                void dialogAcceptResponse(object sender, DialogResponseEventArgs f)
                                                {
                                                    if (f.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if (p.Money >= 1000)
                                                        {
                                                            tuneVeh.Nitro = 1009;
                                                            tuneVeh.vehicle.AddComponent(1009);
                                                            p.Money -= 1000;
                                                            p.SendClientMessage("Вы успешно купили нитро x2!");
                                                        }
                                                        else
                                                        {
                                                            p.SendClientMessage("У вас недостаточно денег!");
                                                        }
                                                    }
                                                }
                                            }
                                            if (e.ListItem == 1)
                                            {
                                                var dialogAccept = new MessageDialog("1", "Подтвердите покупку нитро X5: 2000$", "Купить", "Отмена");
                                                dialogAccept.Response += dialogAcceptResponse;
                                                dialogAccept.Show(p);
                                                void dialogAcceptResponse(object sender, DialogResponseEventArgs f)
                                                {
                                                    if (f.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if (p.Money >= 2000)
                                                        {
                                                            tuneVeh.Nitro = 1008;
                                                            tuneVeh.vehicle.AddComponent(1008);
                                                            p.Money -= 2000;
                                                            p.SendClientMessage("Вы успешно купили нитро x5!");
                                                        }
                                                        else
                                                        {
                                                            p.SendClientMessage("У вас недостаточно денег!");
                                                        }
                                                    }
                                                }
                                            }
                                            if (e.ListItem == 2)
                                            {
                                                var dialogAccept = new MessageDialog("1", "Подтвердите покупку нитро X10: 5000$", "Купить", "Отмена");
                                                dialogAccept.Response += dialogAcceptResponse;
                                                dialogAccept.Show(p);
                                                void dialogAcceptResponse(object sender, DialogResponseEventArgs f)
                                                {
                                                    if (f.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if (p.Money >= 5000)
                                                        {
                                                            tuneVeh.Nitro = 1010;
                                                            tuneVeh.vehicle.AddComponent(1010);
                                                            p.Money -= 5000;
                                                            p.SendClientMessage("Вы успешно купили нитро x10!");
                                                        }
                                                        else
                                                        {
                                                            p.SendClientMessage("У вас недостаточно денег!");
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                    if(e.ListItem == 3)
                                    {
                                        var paintJobSelect = new ListDialog("Аэрография", "Выбрать", "Отмена");
                                        paintJobSelect.AddItem("Удалить аэрографию");
                                        for (int i = 1; i <= GetPaintJobsOfVehicle((int)tuneVeh.vehicle.Model); i++) {
                                            paintJobSelect.AddItem($"Аэрография вариант {i}");
                                        }
                                        
                                        paintJobSelect.Response += paintjobSelectResponse;
                                        paintJobSelect.Show(p);

                                        void paintjobSelectResponse(object sender, DialogResponseEventArgs e)
                                        {
                                            if(e.ListItem == 0 && e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                            {
                                                var deletePaintJoAcceptDialog = new MessageDialog("Подтверждение", "Вы уверены что хотите убрать аэрографию?", "Подтвердить", "Отмена");
                                                deletePaintJoAcceptDialog.Response += deletePaintJobAcceptResponse;
                                                deletePaintJoAcceptDialog.Show(p);
                                                void deletePaintJobAcceptResponse(object sender, DialogResponseEventArgs e)
                                                {
                                                    if(e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        tuneVeh.PaintJob = 0;
                                                        tuneVeh.vehicle.ChangePaintjob(0);
                                                        p.SendClientMessage("Вы убрали аэрографию.");
                                                    }
                                                    
                                                }
                                                paintJobSelect.Response -= paintjobSelectResponse;
                                                return;
                                            }
                                            else if(e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                            {
                                                tuneVeh.vehicle.ChangePaintjob(e.ListItem);
                                                var ApplyPaintJobDialog = new MessageDialog("Подтверждение", "Подтвердите покупку аэрографии: 5000$", "Купить", "Отмена");
                                                ApplyPaintJobDialog.Response += applyPaintJobResponse;
                                                ApplyPaintJobDialog.Show(p);
                                                void applyPaintJobResponse(object sender, DialogResponseEventArgs d)
                                                {
                                                    if(d.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if(p.Money >= 5000)
                                                        {
                                                            p.Money -= 5000;
                                                            tuneVeh.PaintJob = e.ListItem;
                                                        }
                                                        else
                                                        {
                                                            p.SendClientMessage("У вас недостаточно денег!");
                                                        }
                                                    }
                                                    
                                                }
                                                tuneVeh.vehicle.ChangePaintjob(tuneVeh.PaintJob);
                                            }
                                            
                                            

                                        }
                                        static int GetPaintJobsOfVehicle(int model)
                                        {
                                            switch (model)
                                            {
                                                case 483:
                                                    return 1;
                                                case 575:
                                                    return 2;
                                                case 534:
                                                    return 3;
                                                case 535:
                                                    return 3;
                                                case 536:
                                                    return 3;
                                                case 558:
                                                    return 3;
                                                case 559:
                                                    return 3;
                                                case 560:
                                                    return 3;
                                                case 561:
                                                    return 3;
                                                case 562:
                                                    return 3;
                                                case 565:
                                                    return 3;
                                                case 567:
                                                    return 3;
                                                case 576:
                                                    return 3;
                                                default:
                                                    return 0;

                                            }
                                        }
                                    }
                                    if(e.ListItem == 4)
                                    {
                                        var wheelsList = new ListDialog("Колёса", "Выбрать", "Отмена");
                                        wheelsList.AddItems(new string[] { "Shadow", "Mega", "Rimshine", "Wires", "Classic", "Twist", "Cutter", "Switch", "Grove", "Import", "Dollar", "Trance", "Atomic"});
                                        wheelsList.Response += wheelsListResponse;
                                        wheelsList.Show(p);
                                        void wheelsListResponse(object sender, DialogResponseEventArgs e)
                                        {
                                            int wheel = 1073;
                                            if(e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                            {
                                                tuneVeh.vehicle.AddComponent(wheel + e.ListItem);
                                                var acceptWheelDialog = new MessageDialog("Подтверждение", "Подтвердите покупку колёс за 5000$", "Купить", "Отмена");
                                                acceptWheelDialog.Response += acceptWheelDialogResponse;
                                                void acceptWheelDialogResponse(object sender, DialogResponseEventArgs d)
                                                {
                                                    if(d.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                                    {
                                                        if(p.Money >= 5000)
                                                        {
                                                            p.SendClientMessage("Вы успешно поменяли колёса");
                                                            p.Money -= 5000;
                                                            tuneVeh.Wheels = wheel + e.ListItem;
                                                        }
                                                        else {
                                                            p.SendClientMessage("Недостаточно денег!");
                                                        
                                                        }
                                                    }
                                                }
                                                
                                            }
                                            tuneVeh.vehicle.RemoveComponent(wheel + e.ListItem);
                                            tuneVeh.vehicle.AddComponent(tuneVeh.Wheels);
                                        }

                                    }
                                    if(e.ListItem == 5)
                                    {
                                        var acceptHydraulics = new MessageDialog("Подтверждение", "Подтвердите установку гидравлики за 5000$", "Купить", "Отмена");
                                        acceptHydraulics.Response += acceptWheelDialogResponse;
                                        void acceptWheelDialogResponse(object sender, DialogResponseEventArgs e)
                                        {
                                            if(e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left)
                                            {
                                                if(p.Money >= 5000)
                                                {
                                                    p.Money -= 5000;
                                                    tuneVeh.vehicle.AddComponent(1087);
                                                    tuneVeh.Hydraulics = 1087;
                                                    
                                                }
                                                else
                                                {
                                                    p.SendClientMessage("У вас недостаточно денег!");
                                                }
                                            }
                                        }

                                    }
                                    if (e.ListItem == 6) {
                                        var bodyKitsMenu = new ListDialog("Обвесы", "Выбрать", "Отмена");
                                        bodyKitsMenu.AddItem("Спойлер");
                                        bodyKitsMenu.AddItem("Капот");
                                        bodyKitsMenu.AddItem("Капот");
                                        bodyKitsMenu.AddItem("Капот");
                                        bodyKitsMenu.AddItem("Капот");
                                        bodyKitsMenu.AddItem("Капот");

                                    }
                                    tuneMenu.Response -= tuneMenuResponse;
                                }

                            }
                                /**
                                tuneMenu.AddItem("Пороги");
                                tuneMenu.AddItem("Передний бампер");
                                tuneMenu.AddItem("Задний бампер");
                                tuneMenu.AddItem("Спойлер");
                                tuneMenu.AddItem("Выхлоп");
                                **/

                                //carMenu.Response -= CarMenuDialogResponse;
                                // p.SendClientMessage($"Вы успешно заспавнили {p.user.cars[i].vehicle.Model.ToString()}");
                                break;

                            
                        }
                    }

                }
            }
        }
    }
}
