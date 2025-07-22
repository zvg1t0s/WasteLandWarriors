using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using WasteLandWarriors.Display;



namespace WasteLandWarriors.WorldObjects
{
    internal class WorldPickUps
    {
        public WorldPickUps()
        {
            var glavaPickUpExit = Pickup.Create(1318, 1, new Vector3(1325.5162, 1570.7372, 3000.0054), 1001);
            var glavaPickUpEnter = Pickup.Create(1318, 1, new Vector3(-206.8012, 1119.1671, 20.429688), -1);
            TextLabel tlglava = new TextLabel("{f2e82c}Глава поселения", 0, new Vector3(-206.8012, 1119.1671, 20.429688), 15.0f, 0);
            var ShopPickUpEnter = Pickup.Create(1318, 1, new Vector3(-176.74492, 1111.7572, 19.742188), -1);
            TextLabel tlshop = new TextLabel("{f2e82c}Магазин", 0, new Vector3(-176.74492, 1111.7572, 19.742188), 15.0f, 0);
            var ShopPickUpExit = Pickup.Create(1318, 1, new Vector3(1333.2317, 1360.9196, 3001.1155), 1003);
            var BarPickUpEnter = Pickup.Create(1254, 1, new Vector3(-181.0763, 1034.7943, 19.742188));
            TextLabel tlbar = new TextLabel("{f2e82c}Бар", 0, new Vector3(-181.0763, 1034.7943, 19.742188), 15.0f, 0);
            var BarPickUpExit = Pickup.Create(1318, 1, new Vector3(501.8956, -68.29118, 998.7578));
            var ShelterPickUpEnter = Pickup.Create(1318, 1, new Vector3(-123.73604, 1116.3884, 19.8), 0);
            var ShelterPickUpExit = Pickup.Create(1318, 1, new Vector3(2205.5872, 1551.649, 1008.3), 1010);
            TextLabel terminalTl = new TextLabel("{ffffff}Терминал {268bf0}[F]", 0, new Vector3(2216.2234, 1578.7838, 1000), 5, 1010);
            var HospitallvEnter = Pickup.Create(1318,1,new Vector3(1607.3867, 1816.0675, 10.8203125),0);
            TextLabel tlhospitlalv = new TextLabel("{f2e82c}Больница", 0, new Vector3(-1607.3867, 1816.0675, 10.8203125), 15.0f, 0);
            var HospitallvExit = Pickup.Create(1318, 1, new Vector3(1344.1179, 1509.212, 2998.7922), 1011);

        }
        public void OnPickUp(BasePlayer player, PickUpPickupEventArgs e)
        {
            if (e.Pickup.Id == 0)
            {
                Time.SetTimeTo(player);
                player.Interior = 0;
                player.VirtualWorld = 0;
                // player.SetTime(hours, minutes);
                player.Position = new Vector3(-204.44403, 1122.2489, 19.742188);
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 1)
            {
                player.SetTime(12,0);
                player.VirtualWorld = 1001;
                player.Interior = 1;
                player.Angle = 318.07553f;
                player.Position = new Vector3(1327.1235, 1572.3376, 3000.0054);
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 2)
            {
                player.SetTime(12, 0);
                player.VirtualWorld = 1003;
                player.Interior = 1;
                player.Angle = 132.94858f;
                player.Position = new Vector3(1331.1042, 1361.6592, 3001.1155);
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 3)
            {
                Time.SetTimeTo(player);
                player.VirtualWorld = 0;
                player.Interior = 0;
                player.Angle = 177.61566f;
                player.Position = new Vector3(-178.5, 1108.9822, 19.742188);
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 4)
            {

                player.SetTime(12, 0);
                player.VirtualWorld = 1002;
                player.Interior = 11;
                player.Angle = 176.73378f;
                player.Position = new Vector3(501.7085, -70.99589, 998.7578);
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 5)
            {
                Time.SetTimeTo(player);
                player.VirtualWorld = 0;
                player.Interior = 0;
                player.Angle = 92.65823f;
                player.Position = new Vector3(-181.37987, 1037.9471, 19.742188);
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 6)
            {
                player.SetTime(12, 0);
                player.VirtualWorld = 1010;
                player.Interior = 1;
                player.Angle = 270;
                player.Position = new Vector3(2208.2427, 1551.448, 1007.3);
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 7)
            {
                Time.SetTimeTo(player);
                player.VirtualWorld = 0;
                player.Interior = 0;
                player.Angle = 90;
                player.Position = new Vector3(-126.51506, 1121.0647, 19.8);
                player.PutCameraBehindPlayer();
            }
            if(e.Pickup.Id == 8)
            {
                player.SetTime(12,0);
                player.VirtualWorld = 1011;
                player.Interior = 1;
                player.Angle = 270;
                player.Position = new Vector3(1343.8586, 1512.859, 2998.7922);
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 9)
            {
                Time.SetTimeTo(player);
                player.VirtualWorld = 0;
                player.Interior = 0;
                player.Angle = 90;
                player.Position = new Vector3(1607.3867, 1821.0675, 10.8203125);
                player.PutCameraBehindPlayer();
            }
        }// -126.51506, 1121.0647, 19.8, 90
        
    }

}
