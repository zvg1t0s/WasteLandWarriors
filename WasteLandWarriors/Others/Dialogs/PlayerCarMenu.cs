using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Entities;

namespace WasteLandWarriors.Others.Dialogs
{
    public class PlayerCarMenu
    {
        public static void ShowCarMenu(Player p)
        {
            
            var carMenu = new ListDialog("Транспорт", "Спавн", "Отмена");
            carMenu.Response += CarMenuDialogResponse;
            
            if(p.user.cars.Count <= 0)
            {
                p.SendClientMessage("У вас нет транспорта!");
            }

            foreach (var car in p.user.cars) 
            {
                carMenu.AddItem(car.ModelType.ToString());

            }
            carMenu.Show(p);
            void CarMenuDialogResponse(object sender, DialogResponseEventArgs e)
            {
                if (e.DialogButton == SampSharp.GameMode.Definitions.DialogButton.Left) {
                    for (int i = 0; i < p.user.cars.Count; i++) { 
                        if(e.ListItem == i)
                        {
                            VehicleManager.DeleteVehicle(p.user.current);
                            p.user.current = VehicleManager.CreateAndSpawn(p.user.cars[i], p.Position);
                            carMenu.Response -= CarMenuDialogResponse;
                            p.SendClientMessage($"Вы успешно заспавнили {p.user.cars[i].vehicle.Model.ToString()}");
                            break;
                            
                        }
                    }
                }
            }
        }
    }
}
