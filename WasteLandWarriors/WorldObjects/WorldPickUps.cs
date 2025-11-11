using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using WasteLandWarriors.Display;
using WasteLandWarriors.AC;



namespace WasteLandWarriors.WorldObjects
{
    internal class WorldPickUps
    {
        public WorldPickUps()
        {
            var glavaPickUpExit = Pickup.Create(1318, 1, new Vector3(1325.5162, 1570.7372, 3000.0054), 1001);
            RakcheatNatives.AC_CreatePickup(0, 1318, 1, new Vector3(1325.5162, 1570.7372, 3000.0054));
            var glavaPickUpEnter = Pickup.Create(1318, 1, new Vector3(-206.8012, 1119.1671, 20.429688), -1);
            RakcheatNatives.AC_CreatePickup(1, 1318, 1, new Vector3(-206.8012, 1119.1671, 20.429688));
            TextLabel tlglava = new TextLabel("{f2e82c}Глава поселения", 0, new Vector3(-206.8012, 1119.1671, 20.429688), 15.0f, 0);
            var ShopPickUpEnter = Pickup.Create(1318, 1, new Vector3(-176.74492, 1111.7572, 19.742188), -1);
            RakcheatNatives.AC_CreatePickup(2, 1318, 1, new Vector3(-176.74492, 1111.7572, 19.742188));
            TextLabel tlshop = new TextLabel("{f2e82c}Магазин", 0, new Vector3(-176.74492, 1111.7572, 19.742188), 15.0f, 0);
            var ShopPickUpExit = Pickup.Create(1318, 1, new Vector3(1333.2317, 1360.9196, 3001.1155), 1003);
            RakcheatNatives.AC_CreatePickup(3, 1318, 1, new Vector3(1333.2317, 1360.9196, 3001.1155));
            var BarPickUpEnter = Pickup.Create(1254, 1, new Vector3(-181.0763, 1034.7943, 19.742188));
            RakcheatNatives.AC_CreatePickup(4, 1254, 1, new Vector3(-181.0763, 1034.7943, 19.742188));

            TextLabel tlbar = new TextLabel("{f2e82c}Бар", 0, new Vector3(-181.0763, 1034.7943, 19.742188), 15.0f, 0);
            var BarPickUpExit = Pickup.Create(1318, 1, new Vector3(501.8956, -68.29118, 998.7578));
            RakcheatNatives.AC_CreatePickup(5, 1318, 1, new Vector3(501.8956, -68.29118, 998.7578));
            var ShelterPickUpEnter = Pickup.Create(1318, 1, new Vector3(-123.73604, 1116.3884, 19.8), 0);
            RakcheatNatives.AC_CreatePickup(6, 1318, 1, new Vector3(-123.73604, 1116.3884, 19.8));
            var ShelterPickUpExit = Pickup.Create(1318, 1, new Vector3(2205.5872, 1551.649, 1008.3), 1010);
            RakcheatNatives.AC_CreatePickup(7, 1318, 1, new Vector3(2205.5872, 1551.649, 1008.3));

            TextLabel terminalTl = new TextLabel("{ffffff}Терминал {268bf0}[F]", 0, new Vector3(2216.2234, 1578.7838, 1000), 5, 1010);
            var HospitallvEnter = Pickup.Create(1318,1,new Vector3(1607.3867, 1816.0675, 10.8203125),0);
            RakcheatNatives.AC_CreatePickup(8, 1318, 1, new Vector3(1607.3867, 1816.0675, 10.8203125));

            TextLabel tlhospitlalv = new TextLabel("{f2e82c}Больница", 0, new Vector3(-1607.3867, 1816.0675, 10.8203125), 15.0f, 0);
            var HospitallvExit = Pickup.Create(1318, 1, new Vector3(1344.1179, 1509.212, 2998.7922), 1011);
            RakcheatNatives.AC_CreatePickup(9, 1318, 1, new Vector3(1344.1179, 1509.212, 2998.7922));
            var lvpdupenexit = Pickup.Create(1318, 1, new Vector3(288.7364, 167.7454, 1007.1719), 1020);
            RakcheatNatives.AC_CreatePickup(10, 1318, 1, new Vector3(288.7364, 167.7454, 1007.1719));
            var lvpddownexit = Pickup.Create(1318, 1, new Vector3(238.6272, 139.0427, 1003.0234), 1020);
            RakcheatNatives.AC_CreatePickup(11, 1318, 1, new Vector3(238.6272, 139.0427, 1003.0234));

            var lvpddupenter = Pickup.Create(1318, 1, new Vector3(2337.1045, 2458.5579, 14.9688), 0);
            RakcheatNatives.AC_CreatePickup(12, 1318, 1, new Vector3(2337.1045, 2458.5579, 14.9688));

            var lvpddownenter = Pickup.Create(1318, 1, new Vector3(2287.0823, 2432.0588, 10.8203), 0);
            RakcheatNatives.AC_CreatePickup(13, 1318, 1, new Vector3(2287.0823, 2432.0588, 10.8203));

            var neftEnter = Pickup.Create(1318, 1, new Vector3(606.70984, 1252.2295, 22.426962), 0);
            RakcheatNatives.AC_CreatePickup(14, 1318, 1, new Vector3(606.70984, 1252.2295, 22.426962));
            var neftExit = Pickup.Create(1318, 1, new Vector3(510.6517, 1361.8317, 3009.3687), 1022);
            RakcheatNatives.AC_CreatePickup(15, 1318, 1, new Vector3(510.6517, 1361.8317, 3009.3687));


        }
        public void OnPickUp(BasePlayer player, PickUpPickupEventArgs e)
        {
            if (e.Pickup.Id == 0)
            {
                Time.SetTimeTo(player);
                //player.Interior = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                Time.SetTimeTo(player);
                player.VirtualWorld = 0;
                // player.SetTime(hours, minutes);
                player.Position = new Vector3(-204.44403, 1122.2489, 19.742188);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(-204.44403, 1122.2489, 19.742188));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 1)
            {
                player.SetTime(12,0);
                player.VirtualWorld = 1001;
                RakcheatNatives.AC_setInterior(player.Id, 1);

              //  player.Interior = 1;
                player.Angle = 318.07553f;
                player.Position = new Vector3(1327.1235, 1572.3376, 3000.0054);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(1327.1235, 1572.3376, 3000.0054));
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 2)
            {
                player.SetTime(12, 0);
                player.VirtualWorld = 1003;
                RakcheatNatives.AC_setInterior(player.Id, 1);
                //player.Interior = 1;
                player.Angle = 132.94858f;
                player.Position = new Vector3(1331.1042, 1361.6592, 3001.1155);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(1331.1042, 1361.6592, 3001.1155));
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 3)
            {
                
                player.VirtualWorld = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                // player.Interior = 0;
                Time.SetTimeTo(player);
                player.Angle = 177.61566f;
                player.Position = new Vector3(-178.5, 1108.9822, 19.742188);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(-178.5, 1108.9822, 19.742188));
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 4)
            {

                player.SetTime(12, 0);
                player.VirtualWorld = 1002;
                RakcheatNatives.AC_setInterior(player.Id, 11);

               // player.Interior = 11;
                player.Angle = 176.73378f;
                player.Position = new Vector3(501.7085, -70.99589, 998.7578);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(501.7085, -70.99589, 998.7578));
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 5)
            {
                
                player.VirtualWorld = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                Time.SetTimeTo(player);
                //  player.Interior = 0;
                player.Angle = 92.65823f;
                player.Position = new Vector3(-181.37987, 1037.9471, 19.742188);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(-181.37987, 1037.9471, 19.742188));
                player.PutCameraBehindPlayer();

            }
            if (e.Pickup.Id == 6)
            {
                player.SetTime(12, 0);
                player.VirtualWorld = 1010;
                RakcheatNatives.AC_setInterior(player.Id, 1);

               // player.Interior = 1;
                player.Angle = 270;
                player.Position = new Vector3(2208.2427, 1551.448, 1007.3);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(2208.2427, 1551.448, 1007.3));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 7)
            {
                
                player.VirtualWorld = 0;
                player.Interior = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                Time.SetTimeTo(player);

                //   player.Interior = 0;
                player.Angle = 90;
                player.Position = new Vector3(-126.51506, 1121.0647, 19.8);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(-126.51506, 1121.0647, 19.8));
                player.PutCameraBehindPlayer();
            }
            if(e.Pickup.Id == 8)
            {
                player.SetTime(12,0);
                player.VirtualWorld = 1011;
                RakcheatNatives.AC_setInterior(player.Id, 1);

              //  player.Interior = 1;
                player.Angle = 270;
                player.Position = new Vector3(1343.8586, 1512.859, 2998.7922);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(1343.8586, 1512.859, 2998.7922));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 9)
            {
                
                player.VirtualWorld = 0;
              //  player.Interior = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                Time.SetTimeTo(player);
                player.Angle = 90;
                player.Position = new Vector3(1607.3867, 1821.0675, 10.8203125);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(1607.3867, 1821.0675, 10.8203125));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 10)
            {
                
                player.VirtualWorld = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                Time.SetTimeTo(player);
                //  player.Interior = 0;
                player.Angle = 180;
                player.Position = new Vector3(2337.1045, 2454.5579, 14.9688);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(2337.1045, 2454.5579, 14.9688));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 11)
            {
                
                player.VirtualWorld = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                Time.SetTimeTo(player);
                //  player.Interior = 0;
                player.Angle = 180;
                player.Position = new Vector3(2287.0823, 2429.0588, 10.8203);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(2287.0823, 2429.0588, 10.8203));

                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 12)
            {
                player.SetTime(12,0);
                player.VirtualWorld = 1020;
                RakcheatNatives.AC_setInterior(player.Id, 3);

              //  player.Interior = 3;
                player.Angle = 0;
                player.Position = new Vector3(288.7364, 169.7456, 1007.1719);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(288.7364, 169.7456, 1007.1719));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 13)
            {
                player.SetTime(12, 0);
                player.VirtualWorld = 1020;
                RakcheatNatives.AC_setInterior(player.Id, 3);

             //  player.Interior = 3;
                player.Angle = 0;
                player.Position = new Vector3(238.6272, 141.0429, 1003.0234);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(238.6272, 141.0429, 1003.0234));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 14)
            {
                player.SetTime(0, 0);
                player.SetWeather(20);
                player.VirtualWorld = 1022;
                RakcheatNatives.AC_setInterior(player.Id, 1);

                player.Interior = 1;
                player.Angle = 0;
                player.Position = new Vector3(505.81113, 1363.5312, 3009.3687);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(505.81113, 1363.5312, 3009.3687));
                player.PutCameraBehindPlayer();
            }
            if (e.Pickup.Id == 15)
            {
                
                player.VirtualWorld = 0;
                RakcheatNatives.AC_setInterior(player.Id, 0);
                Time.SetTimeTo(player);
                player.Interior = 0;
                player.Angle = 0;
                player.Position = new Vector3(601.999, 1249.4803, 22.426962);
                RakcheatNatives.AC_SetPlayerPos(player, new Vector3(601.999, 1249.4803, 22.426962));
                player.PutCameraBehindPlayer();
            }
        }// -126.51506, 1121.0647, 19.8, 90
        
    }

}
