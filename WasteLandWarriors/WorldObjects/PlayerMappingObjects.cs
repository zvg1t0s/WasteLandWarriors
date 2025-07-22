using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode;
using SampSharp.Streamer.World;
using SampSharp.Streamer;
using SampSharp.GameMode.Definitions;

namespace WasteLandWarriors.WorldObjects
{
    internal class PlayerMappingObjects
    {
        BasePlayer player;
        public PlayerMappingObjects(BasePlayer p) { 
            player = p;

        }
        public void CreateNShow()
        {
            var bar1 = new DynamicObject(19433, new Vector3(505.475189, -78.922294, 1003.211303), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            bar1.SetMaterial(0, 3922, "bistro", "sw_wallbrick_01", 0);
            bar1.ShowInInterior(11);
            var bar2 = new DynamicObject(19376, new Vector3(511.085784, -78.926460, 999.708374), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            bar2.SetMaterial(0, 3922, "bistro", "sw_wallbrick_01", 0);
            bar2.ShowInInterior(11);


            //tmpobjid = CreateDynamicObject(2205, 510.326538, -81.602119, 997.940856, 0.000000, 0.000000, 107.400016, 1011, object_int, -1, 300.00, 300.00); 
            var bar3 = new DynamicObject(2205, new Vector3(510.326538, -81.602119, 997.940856), new Vector3(0.000000, 0.000000, 107.400016), 1002, 11, player, 25, 25);
            bar3.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(1671, 511.589538, -80.387573, 998.391113, 0.000000, 0.000000, -54.700004, 1011, object_int, -1, 300.00, 300.00); 
            var bar4 = new DynamicObject(1671, new Vector3(511.589538, -80.387573, 998.391113), new Vector3(0.000000, 0.000000, -54.700004), 1002, 11, player, 25, 25);
            bar4.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(1728, 511.626251, -85.992668, 997.900878, 0.000000, 0.000000, -109.900039, 1011, object_int, -1, 300.00, 300.00);
            var bar5 = new DynamicObject(1728, new Vector3(511.626251, -85.992668, 997.900878), new Vector3(0.000000, 0.000000, -109.900039), 1002, 11, player, 25, 25);
            bar5.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(2083, 509.925415, -85.762634, 997.830627, 0.000000, 0.000000, -129.800018, 1011, object_int, -1, 300.00, 300.00);
            var bar6 = new DynamicObject(2083, new Vector3(509.925415, -85.762634, 997.830627), new Vector3(0.000000, 0.000000, -129.800018), 1002, 11, player, 25, 25);
            bar6.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(1729, 509.318237, -88.108978, 997.910888, 0.000000, 0.000000, 162.700042, 1011, object_int, -1, 300.00, 300.00); 
            var bar7 = new DynamicObject(1729, new Vector3(509.318237, -88.108978, 997.910888), new Vector3(0.000000, 0.000000, 162.700042), 1002, 11, player, 25, 25);
            bar7.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(1575, 510.075561, -86.646141, 998.301269, 0.000000, 0.000000, 57.100006, 1011, object_int, -1, 300.00, 300.00); 
            var bar8 = new DynamicObject(1575, new Vector3(510.075561, -86.646141, 998.301269), new Vector3(0.000000, 0.000000, 57.100006), 1002, 11, player, 25, 25);
            bar8.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(335, 510.063659, -86.532058, 998.660644, 178.699996, -6.399999, -12.599999, 1011, object_int, -1, 300.00, 300.00); 
            var bar9 = new DynamicObject(335, new Vector3(510.063659, -86.532058, 998.660644), new Vector3(178.699996, -6.399999, -12.599999), 1002, 11, player, 25, 25);
            bar9.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(19177, 510.096099, -86.580162, 998.481018, 0.000000, 0.000000, 0.000000, 1011, object_int, -1, 300.00, 300.00); 
            var bar10 = new DynamicObject(19177, new Vector3(510.096099, -86.580162, 998.481018), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            bar10.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(19177, 510.216217, -86.320182, 998.340881, 0.000000, 0.000000, 0.000000, 1011, object_int, -1, 300.00, 300.00); 
            var bar11 = new DynamicObject(19177, new Vector3(510.216217, -86.320182, 998.340881), new Vector3(0.0, 0.0, 0.0), 1002, 11, player, 25, 25);
            bar11.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(3109, 505.189270, -89.185325, 999.141174, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar12 = new DynamicObject(3109, new Vector3(505.189270, -89.185325, 999.141174), new Vector3(0.0, 0.0, -90.0), 1002, 11, player, 25, 25);
            bar12.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(348, 510.340576, -80.542182, 998.911010, 270.000000, -166.199981, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar13 = new DynamicObject(348, new Vector3(510.340576, -80.542182, 998.911010), new Vector3(270.000000, -166.199981, 0.000000), 1002, 11, player, 25, 25);
            bar13.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(19893, 510.302368, -81.220336, 998.871154, 0.000000, 0.000000, 133.500000, object_world, object_int, -1, 300.00, 300.00); 
            var bar14 = new DynamicObject(19893, new Vector3(510.302368, -81.220336, 998.871154), new Vector3(0.0, 0.0, 133.5), 1002, 11, player, 25, 25);
            bar14.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(1550, 509.668945, -79.683685, 998.398986, 15.200001, 0.000000, 38.900001, object_world, object_int, -1, 300.00, 300.00); 
            var bar15 = new DynamicObject(1550, new Vector3(509.668945, -79.683685, 998.398986), new Vector3(15.200001, 0.000000, 38.900001), 1002, 11, player, 25, 25);
            bar15.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(2059, 510.137420, -80.590240, 998.881835, 0.000000, 0.000000, -51.000007, object_world, object_int, -1, 300.00, 300.00); 
            var bar16 = new DynamicObject(2059, new Vector3(510.137420, -80.590240, 998.881835), new Vector3(0.000000, 0.000000, -51.000007), 1002, 11, player, 25, 25);
            bar16.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(1665, 510.132781, -80.162391, 998.891845, 0.000000, 0.000000, 58.299995, object_world, object_int, -1, 300.00, 300.00); 
            var bar17 = new DynamicObject(1665, new Vector3(510.132781, -80.162391, 998.891845), new Vector3(0.000000, 0.000000, 58.299995), 1002, 11, player, 25, 25);
            bar17.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(18673, 510.059875, -80.152351, 997.350585, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar18 = new DynamicObject(18673, new Vector3(510.059875, -80.152351, 997.350585), new Vector3(0.0, 0.0, 0.0), 1002, 11, player, 25, 25);
            bar18.ShowInInterior(11);
            //tmpobjid = CreateDynamicObject(1893, 510.169097, -81.358398, 1002.201416, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar19 = new DynamicObject(1893, new Vector3(510.169097, -81.358398, 1002.201416), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            bar19.ShowInInterior(11);
            //____________________________________________________________________SHOP MAPP______________________________________________________________
            //tmpobjid = CreateDynamicObject(19379, 1330.697998, 1363.093750, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "des_tunnellight", 0x00000000);
            var shop1 = new DynamicObject(19379, new Vector3(1330.697998, 1363.093750, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop1.SetMaterial(0, 16640, "a51", "des_tunnellight", 0);
            shop1.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1324.976562, 1358.404785, 3000.029541, 0.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop2 = new DynamicObject(19379, new Vector3(1324.976562, 1358.404785, 3000.029541), new Vector3(0.000000, 180.000000, 0.000000), 1003, 1, player, 25, 25);
            shop2.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            shop2.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1335.397216, 1358.404785, 3000.029541, 90.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "des_tunnellight", 0x00000000);
            var shop3 = new DynamicObject(19379, new Vector3(1335.397216, 1358.404785, 3000.029541), new Vector3(90.000000, 180.000000, 0.000000), 1003, 1, player, 25, 25);
            shop3.SetMaterial(0, 16640, "a51", "des_tunnellight", 0);
            shop3.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1330.187500, 1353.653564, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop4 = new DynamicObject(19379, new Vector3(1330.187500, 1353.653564, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop4.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            shop4.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1333.060546, 1362.302246, 3000.029541, -90.000000, 315.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop5 = new DynamicObject(19379, new Vector3(1333.060546, 1362.302246, 3000.029541), new Vector3(-90.000000, 315.000000, 0.000000), 1003, 1, player, 25, 25);
            shop5.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            shop5.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1330.095947, 1358.404785, 3003.939208, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 11301, "carshow_sfse", "ws_officy_ceiling", 0x00000000);
            var shop6 = new DynamicObject(19379, new Vector3(1330.095947, 1358.404785, 3003.939208), new Vector3(0.000000, 90.000000, 0.000000), 1003, 1, player, 25, 25);
            shop6.SetMaterial(0, 11301, "carshow_sfse", "ws_officy_ceiling", 0);
            shop6.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1337.008422, 1363.023925, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop7 = new DynamicObject(19379, new Vector3(1337.008422, 1363.023925, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop7.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            shop7.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1320.377929, 1363.023925, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop8 = new DynamicObject(19379, new Vector3(1320.377929, 1363.023925, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop8.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            shop8.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1335.328002, 1364.022827, 3000.029541, -90.000000, 270.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop9 = new DynamicObject(19379, new Vector3(1335.328002, 1364.022827, 3000.029541), new Vector3(-90.000000, 270.000000, 90.000000), 1003, 1, player, 25, 25);
            shop9.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            shop9.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19379, 1335.328002, 1349.572509, 3000.029541, -90.000000, 270.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop10 = new DynamicObject(19379, new Vector3(1335.328002, 1349.572509, 3000.029541), new Vector3(-90.000000, 270.000000, 90.000000), 1003, 1, player, 25, 25);
            shop10.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            shop10.ShowInWorld(1003);
            //tmpobjid = CreateDynamicObject(14902, 1329.656372, 1377.856445, 3000.035400, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            //tmpobjid = CreateDynamicObject(14902, 1320.457275, 1364.107666, 3000.035400, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 

            //tmpobjid = CreateDynamicObject(14902, 1329.656372, 1377.856445, 3000.035400, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop11 = new DynamicObject(14902, new Vector3(1329.656372, 1377.876464, 3000.035400), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            shop11.ShowInWorld(1003);
            //tmpobjid = CreateDynamicObject(14902, 1320.457275, 1364.107666, 3000.035400, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop12 = new DynamicObject(14902, new Vector3(1320.457275, 1364.107666, 3000.035400), new Vector3(0.000000, 0.000000, 270.000000), 1003, 1, player, 25, 25);
            shop12.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1532, 1333.204711, 1362.015747, 3000.095458, 0.000000, 0.000000, -45.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop13 = new DynamicObject(1532, new Vector3(1333.204711, 1362.015747, 3000.095458), new Vector3(0.000000, 0.000000, -45.000000), 1003, 1, player, 25, 25);
            shop13.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2582, 1335.048950, 1357.887695, 3000.956298, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop14 = new DynamicObject(2582, new Vector3(1335.048950, 1357.887695, 3000.956298), new Vector3(0.000000, 0.000000, 270.000000), 1003, 1, player, 25, 25);
            shop14.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1893, 1332.182373, 1355.174072, 3004.317138, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop15 = new DynamicObject(1893, new Vector3(1332.182373, 1355.174072, 3004.317138), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop15.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1893, 1332.182373, 1359.994628, 3004.317138, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop16 = new DynamicObject(1893, new Vector3(1332.182373, 1359.994628, 3004.317138), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop16.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1893, 1326.941040, 1355.174072, 3004.337158, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop17 = new DynamicObject(1893, new Vector3(1326.941040, 1355.174072, 3004.337158), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop17.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1893, 1326.911987, 1359.995605, 3004.083496, 0.000000, -12.000000, -5.999999, object_world, object_int, -1, 300.00, 300.00); 
            var shop18 = new DynamicObject(1893, new Vector3(1326.911987, 1359.995605, 3004.083496), new Vector3(0.000000, -12.000000, -5.999999), 1003, 1, player, 25, 25);
            shop18.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2582, 1335.048950, 1355.907104, 3000.956298, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop19 = new DynamicObject(2582, new Vector3(1335.048950, 1355.907104, 3000.956298), new Vector3(0.000000, 0.000000, 270.000000), 1003, 1, player, 25, 25);
            shop19.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(11706, 1334.541015, 1360.332885, 3000.306152, 87.700012, -33.399997, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop20 = new DynamicObject(11706, new Vector3(1334.541015, 1360.332885, 3000.306152), new Vector3(87.700012, -33.399997, 0.000000), 1003, 1, player, 25, 25);
            shop20.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1984, 1328.613647, 1356.336425, 3000.105468, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop21 = new DynamicObject(1984, new Vector3(1328.613647, 1356.336425, 3000.105468), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop21.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1850, 1329.979736, 1354.135498, 3000.045410, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop22 = new DynamicObject(1850, new Vector3(1329.979736, 1354.135498, 3000.045410), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            shop22.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1850, 1326.920288, 1354.135498, 3000.045410, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop23 = new DynamicObject(1850, new Vector3(1326.920288, 1354.135498, 3000.045410), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            shop23.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1843, 1325.734252, 1356.451293, 3000.035400, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop24 = new DynamicObject(1843, new Vector3(1325.734252, 1356.451293, 3000.035400), new Vector3(0.000000, 0.000000, 90.000000), 1003, 1, player, 25, 25);
            shop24.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2365, 1332.344360, 1354.440551, 3000.095458, 0.000000, 0.000000, 23.400003, object_world, object_int, -1, 300.00, 300.00); 
            var shop25 = new DynamicObject(2365, new Vector3(1332.344360, 1354.440551, 3000.095458), new Vector3(0.000000, 0.000000, 23.400003), 1003, 1, player, 25, 25);
            shop25.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1886, 1325.594848, 1354.228271, 3004.075195, 9.300000, 0.000000, 128.400024, object_world, object_int, -1, 300.00, 300.00); 
            var shop26 = new DynamicObject(1886, new Vector3(1325.594848, 1354.228271, 3004.075195), new Vector3(9.300000, 0.000000, 128.400024), 1003, 1, player, 25, 25);
            shop26.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2541, 1331.121704, 1354.183471, 3002.056884, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop27 = new DynamicObject(2541, new Vector3(1331.121704, 1354.183471, 3002.056884), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            shop27.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2541, 1330.131103, 1354.183471, 3002.056884, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop28 = new DynamicObject(2541, new Vector3(1330.131103, 1354.183471, 3002.056884), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            shop28.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1455, 1331.355224, 1354.209960, 3000.445800, 0.000000, 0.000000, -43.799995, object_world, object_int, -1, 300.00, 300.00); 
            var shop29 = new DynamicObject(1455, new Vector3(1331.355224, 1354.209960, 3000.445800), new Vector3(0.000000, 0.000000, -43.799995), 1003, 1, player, 25, 25);
            shop29.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1546, 1330.912353, 1354.084594, 3000.455810, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop30 = new DynamicObject(1546, new Vector3(1330.912353, 1354.084594, 3000.455810), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop30.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1546, 1331.252685, 1354.084594, 3000.886230, 0.000000, 0.000000, 74.399986, object_world, object_int, -1, 300.00, 300.00); 
            var shop31 = new DynamicObject(1546, new Vector3(1331.252685, 1354.084594, 3000.886230), new Vector3(0.000000, 0.000000, 74.399986), 1003, 1, player, 25, 25);
            shop31.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1577, 1330.351196, 1354.097045, 3000.345703, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop32 = new DynamicObject(1577, new Vector3(1330.351196, 1354.097045, 3000.345703), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop32.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1577, 1330.311157, 1354.097045, 3000.485839, 0.000000, 0.000000, -12.499998, object_world, object_int, -1, 300.00, 300.00); 
            var shop33 = new DynamicObject(1577, new Vector3(1330.311157, 1354.097045, 3000.485839), new Vector3(0.000000, 0.000000, -12.499998), 1003, 1, player, 25, 25);
            shop33.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1778, 1335.137329, 1354.365600, 3000.105468, 0.000000, 0.000000, -43.200008, object_world, object_int, -1, 300.00, 300.00); 
            var shop34 = new DynamicObject(1778, new Vector3(1335.137329, 1354.365600, 3000.105468), new Vector3(0.000000, 0.000000, -43.200008), 1003, 1, player, 25, 25);
            shop34.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1810, 1329.083251, 1355.350097, 3000.095458, 0.000000, 0.000000, 146.000030, object_world, object_int, -1, 300.00, 300.00); 
            var shop35 = new DynamicObject(1810, new Vector3(1329.083251, 1355.350097, 3000.095458), new Vector3(0.000000, 0.000000, 146.000030), 1003, 1, player, 25, 25);
            shop35.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1901, 1330.687866, 1354.001708, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop36 = new DynamicObject(1901, new Vector3(1330.687866, 1354.001708, 3000.786132), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop36.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1901, 1330.577758, 1354.091796, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop37 = new DynamicObject(1901, new Vector3(1330.577758, 1354.091796, 3000.786132), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop37.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1901, 1330.797607, 1354.131835, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop38 = new DynamicObject(1901, new Vector3(1330.797607, 1354.131835, 3000.786132), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop38.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1901, 1330.887695, 1354.001708, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop39 = new DynamicObject(1901, new Vector3(1330.887695, 1354.001708, 3000.786132), new Vector3(0.0, 0.0, 0.0), 1003, 1, player, 25, 25);
            shop39.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1951, 1329.758544, 1354.114868, 3000.545898, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop40 = new DynamicObject(1951, new Vector3(1329.758544, 1354.114868, 3000.545898), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop40.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(1951, 1329.518310, 1354.214965, 3000.545898, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop41 = new DynamicObject(1951, new Vector3(1329.518310, 1354.214965, 3000.545898), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop41.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2057, 1327.954467, 1354.087646, 3000.555908, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop42 = new DynamicObject(2057, new Vector3(1327.954467, 1354.087646, 3000.555908), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop42.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2060, 1326.858032, 1354.109130, 3000.485839, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop43 = new DynamicObject(2060, new Vector3(1326.858032, 1354.109130, 3000.485839), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            shop43.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2286, 1333.476196, 1353.765136, 3002.371826, 0.000000, -6.099999, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop44 = new DynamicObject(2286, new Vector3(1333.476196, 1353.765136, 3002.371826), new Vector3(0.000000, -6.099999, 180.000000), 1003, 1, player, 25, 25);
            shop44.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2342, 1329.139282, 1356.332031, 3001.156494, 0.000000, 0.000000, 42.099998, object_world, object_int, -1, 300.00, 300.00); 
            var shop45 = new DynamicObject(2342, new Vector3(1329.139282, 1356.332031, 3001.156494), new Vector3(0.000000, 0.000000, 42.099998), 1003, 1, player, 25, 25);
            shop45.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2647, 1329.337646, 1354.131347, 3002.157470, 0.000000, 0.000000, -119.500000, object_world, object_int, -1, 300.00, 300.00); 
            var shop46 = new DynamicObject(2647, new Vector3(1329.337646, 1354.131347, 3002.157470), new Vector3(0.000000, 0.000000, -119.500000), 1003, 1, player, 25, 25);
            shop46.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(11736, 1331.146972, 1354.106323, 3001.266601, 0.000000, 0.000000, 18.899999, object_world, object_int, -1, 300.00, 300.00); 
            var shop47 = new DynamicObject(11736, new Vector3(1331.146972, 1354.106323, 3001.266601), new Vector3(0.000000, 0.000000, 18.899999), 1003, 1, player, 25, 25);
            shop47.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(11738, 1330.609130, 1354.075195, 3001.256591, 0.000000, 0.000000, -10.399998, object_world, object_int, -1, 300.00, 300.00); 
            var shop48 = new DynamicObject(11738, new Vector3(1330.609130, 1354.075195, 3001.256591), new Vector3(0.000000, 0.000000, -10.399998), 1003, 1, player, 25, 25);
            shop48.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(11738, 1330.077270, 1354.041137, 3001.256591, 0.000000, 0.000000, 8.899999, object_world, object_int, -1, 300.00, 300.00); 
            var shop49 = new DynamicObject(11738, new Vector3(1330.077270, 1354.041137, 3001.256591), new Vector3(0.000000, 0.000000, 8.899999), 1003, 1, player, 25, 25);
            shop49.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19563, 1329.972534, 1354.043334, 3000.796142, 0.000000, 0.000000, -22.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop50 = new DynamicObject(19563, new Vector3(1329.972534, 1354.043334, 3000.796142), new Vector3(0.000000, 0.000000, -22.799999), 1003, 1, player, 25, 25);
            shop50.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19563, 1330.203979, 1354.077148, 3000.796142, 0.000000, 0.000000, -22.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop51 = new DynamicObject(19563, new Vector3(1330.203979, 1354.077148, 3000.796142), new Vector3(0.000000, 0.000000, -22.799999), 1003, 1, player, 25, 25);
            shop51.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19573, 1328.375244, 1354.012939, 3000.892822, 99.999931, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop52 = new DynamicObject(19563, new Vector3(1328.375244, 1354.012939, 3000.892822), new Vector3(99.999931, 0.000000, -90.000000), 1003, 1, player, 25, 25);
            shop52.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19998, 1327.512451, 1354.024047, 3000.906250, 0.000000, 0.000000, -29.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop53 = new DynamicObject(19998, new Vector3(1327.512451, 1354.024047, 3000.906250), new Vector3(0.000000, 0.000000, -29.799999), 1003, 1, player, 25, 25);
            shop53.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19998, 1327.268066, 1354.060302, 3000.906250, 0.000000, 0.000000, -29.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop54 = new DynamicObject(19998, new Vector3(1327.268066, 1354.060302, 3000.906250), new Vector3(0.000000, 0.000000, -29.799999), 1003, 1, player, 25, 25);
            shop54.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19998, 1327.028686, 1354.104858, 3000.906250, 0.000000, 0.000000, -29.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop55 = new DynamicObject(19998, new Vector3(1327.028686, 1354.104858, 3000.906250), new Vector3(0.000000, 0.000000, -29.799999), 1003, 1, player, 25, 25);
            shop55.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(19107, 1327.910766, 1354.175170, 3002.101318, -14.500000, -88.199913, -3.399999, object_world, object_int, -1, 300.00, 300.00); 
            var shop56 = new DynamicObject(19107, new Vector3(1327.910766, 1354.175170, 3002.101318), new Vector3(-14.500000, -88.199913, -3.399999), 1003, 1, player, 25, 25);
            shop56.ShowInWorld(1003);

            //tmpobjid = CreateDynamicObject(2002, 1325.560302, 1360.847412, 3000.115478, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop57 = new DynamicObject(2002, new Vector3(1325.560302, 1360.847412, 3000.115478), new Vector3(0.000000, 0.000000, 90.000000), 1003, 1, player, 25, 25);
            shop57.ShowInWorld(1003);
            // - dynamic fk mapp 
            //new tmpobjid, object_world = -1, object_int = -1;
            //tmpobjid = CreateDynamicObject(19321, -165.911666, 1162.784790, 24.745386, 0.000000, -1.700000, 540.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 10850, "bakerybit2_sfse", "frate64_yellow", 0x00000000);
            var fk1 = new DynamicObject(19321, new Vector3(-165.911666, 1162.784790, 24.745386), new Vector3(0.000000, -1.700000, 540.000000), 0, 0, player, 200, 200);
            fk1.SetMaterial(0, 10850, "barekybit2_sfse", "frate64_yellow", 0);

            //SetDynamicObjectMaterial(tmpobjid, 1, 10850, "bakerybit2_sfse", "frate_doors64yellow", 0x00000000);
            fk1.SetMaterial(1, 10850, "barekybit2_sfse", "frate_doors64yellow", 0);
            fk1.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19462, -436.328308, 1223.960449, 33.771858, 0.299998, 90.000000, 12.099986, object_world, object_int, -1, 300.00, 300.00); 
            var fk2 = new DynamicObject(19462, new Vector3(-436.328308, 1223.960449, 33.771858), new Vector3(0.299998, 90.000000, 12.099986), 0, 0, player, 200, 200);
            fk2.SetMaterial(0, 1692, "moregenroofstuff", "skylight_meshed", 0);
            fk2.ShowInWorld(0);
            //SetDynamicObjectMaterial(tmpobjid, 0, 1692, "moregenroofstuff", "skylight_meshed", 0x00000000);
            //tmpobjid = CreateDynamicObject(970, -438.493011, 1226.274047, 34.281845, 0.000000, 0.000000, -78.399917, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            var fk3 = new DynamicObject(970, new Vector3(-438.493011, 1226.274047, 34.281845), new Vector3(0.000000, 0.000000, -78.399917), 0, 0, player, 200, 200);
            fk3.SetMaterial(0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
            fk3.SetMaterial(1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
            fk3.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(970, -437.399078, 1220.945678, 34.281845, 0.000000, 0.000000, -78.399917, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            var fk4 = new DynamicObject(970, new Vector3(-437.399078, 1220.945678, 34.281845), new Vector3(0.000000, 0.000000, -78.399917), 0, 0, player, 200, 200);
            fk4.SetMaterial(0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
            fk4.SetMaterial(1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
            fk4.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19906, -116.160247, 1122.709106, 21.272209, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16644, "a51_detailstuff", "steel256128", 0x00000000);
            var fk5 = new DynamicObject(19906, new Vector3(-116.160247, 1122.709106, 21.272209), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk5.SetMaterial(0, 16644, "a51_detailstuff", "steel256128", 0);

            fk5.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19906, -116.160247, 1110.476074, 21.272209, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16644, "a51_detailstuff", "steel256128", 0x00000000);
            var fk6 = new DynamicObject(19906, new Vector3(-116.160247, 1110.476074, 21.272209), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk6.SetMaterial(0, 16644, "a51_detailstuff", "steel256128", 0);
            fk6.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3861, -80.803718, 1184.961181, 19.859954, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk7 = new DynamicObject(3861, new Vector3(-80.803718, 1184.961181, 19.859954), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk7.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3863, -86.881233, 1184.968261, 19.832212, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk8 = new DynamicObject(3863, new Vector3(-86.881233, 1184.968261, 19.832212), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk8.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3861, -92.363731, 1184.961181, 19.859954, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk9 = new DynamicObject(3861, new Vector3(-92.363731, 1184.961181, 19.859954), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk9.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1440, -80.108375, 1169.435302, 19.242193, 0.000000, 0.000000, -91.900001, object_world, object_int, -1, 300.00, 300.00); 
            var fk10 = new DynamicObject(1440, new Vector3(-80.108375, 1169.435302, 19.242193), new Vector3(0.000000, 0.000000, -91.900001), 0, 0, player, 200, 200);
            fk10.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(9238, -79.800178, 1163.579345, 20.492195, 0.000000, 0.000000, -18.700000, object_world, object_int, -1, 300.00, 300.00); 
            var fk11 = new DynamicObject(9238, new Vector3(-79.800178, 1163.579345, 20.492195), new Vector3(0.000000, 0.000000, -18.700000), 0, 0, player, 200, 200);
            fk11.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -103.746353, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk12 = new DynamicObject(994, new Vector3(-103.746353, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk12.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -95.876480, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk13 = new DynamicObject(994, new Vector3(-95.876480, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk13.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -81.816604, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk14 = new DynamicObject(994, new Vector3(-81.816604, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk14.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -88.096534, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk15 = new DynamicObject(994, new Vector3(-88.096534, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk15.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -105.526397, 1180.331298, 18.749971, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk16 = new DynamicObject(994, new Vector3(-105.526397, 1180.331298, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk16.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -105.526397, 1173.972778, 18.749971, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk17 = new DynamicObject(994, new Vector3(-105.526397, 1173.972778, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk17.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -105.526397, 1158.428833, 18.749971, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk18 = new DynamicObject(994, new Vector3(-105.526397, 1158.428833, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk18.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -105.526397, 1166.210327, 18.749971, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk19 = new DynamicObject(994, new Vector3(-105.526397, 1166.210327, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk19.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -97.646392, 1158.428833, 18.749971, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk20 = new DynamicObject(994, new Vector3(-97.646392, 1158.428833, 18.749971), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk20.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -95.446426, 1158.428833, 18.749971, 0.000000, 0.000000, -28.899986, object_world, object_int, -1, 300.00, 300.00); 
            var fk21 = new DynamicObject(994, new Vector3(-95.446426, 1158.428833, 18.749971), new Vector3(0.000000, 0.000000, -28.899986), 0, 0, player, 200, 200);
            fk21.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1155.418090, 18.749971, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk22 = new DynamicObject(994, new Vector3(), new Vector3(), 0, 0, player, 200, 200);
            fk22.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -83.686347, 1155.418090, 18.749971, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk23 = new DynamicObject(994, new Vector3(-83.686347, 1155.418090, 18.749971), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk23.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1161.878662, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk24 = new DynamicObject(994, new Vector3(-75.626426, 1161.878662, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk24.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1188.309326, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk25 = new DynamicObject(994, new Vector3(-75.626426, 1188.309326, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk25.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1168.155273, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk26 = new DynamicObject(994, new Vector3(-75.626426, 1168.155273, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk26.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1174.423461, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk27 = new DynamicObject(994, new Vector3(-75.626426, 1174.423461, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk27.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1180.682983, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk28 = new DynamicObject(994, new Vector3(-75.626426, 1180.682983, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk28.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2671, -97.292160, 1176.086914, 18.749971, 0.000000, 0.000000, -70.799995, object_world, object_int, -1, 300.00, 300.00); 
            var fk29 = new DynamicObject(2671, new Vector3(-97.292160, 1176.086914, 18.749971), new Vector3(0.000000, 0.000000, -70.799995), 0, 0, player, 200, 200);
            fk29.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2670, -91.722518, 1180.281738, 18.829973, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk30 = new DynamicObject(2670, new Vector3(-91.722518, 1180.281738, 18.829973), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk30.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2671, -101.407836, 1181.432006, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk31 = new DynamicObject(2671, new Vector3(-101.407836, 1181.432006, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk31.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3863, -97.571243, 1184.968261, 19.832212, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk32 = new DynamicObject(3863, new Vector3(-97.571243, 1184.968261, 19.832212), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk32.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3014, -81.628555, 1164.227905, 18.932191, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk33 = new DynamicObject(3014, new Vector3(-81.628555, 1164.227905, 18.932191), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk33.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3014, -81.533897, 1164.878662, 18.932191, 0.000000, 0.000000, -17.699996, object_world, object_int, -1, 300.00, 300.00); 
            var fk34 = new DynamicObject(3014, new Vector3(-81.533897, 1164.878662, 18.932191), new Vector3(0.000000, 0.000000, -17.699996), 0, 0, player, 200, 200);
            fk34.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3014, -81.101936, 1165.374755, 18.932191, 0.000000, 0.000000, -34.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk35 = new DynamicObject(3014, new Vector3(-81.101936, 1165.374755, 18.932191), new Vector3(0.000000, 0.000000, -34.299995), 0, 0, player, 200, 200);
            fk35.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3014, -81.270996, 1165.127075, 19.392202, 0.000000, 0.000000, -34.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk36 = new DynamicObject(3014, new Vector3(-81.270996, 1165.127075, 19.392202), new Vector3(0.000000, 0.000000, -34.299995), 0, 0, player, 200, 200);
            fk36.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3014, -81.664154, 1164.547851, 19.412172, 0.000000, 2.299961, -34.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk37 = new DynamicObject(3014, new Vector3(-81.664154, 1164.547851, 19.412172), new Vector3(0.000000, 2.299961, -34.299995), 0, 0, player, 200, 200);
            fk37.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2040, -80.635620, 1165.645141, 18.832189, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk38 = new DynamicObject(2040, new Vector3(-80.635620, 1165.645141, 18.832189), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk38.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2040, -80.947235, 1165.786865, 18.832189, 0.000000, 0.000000, -98.199989, object_world, object_int, -1, 300.00, 300.00); 
            var fk39 = new DynamicObject(2040, new Vector3(-80.947235, 1165.786865, 18.832189), new Vector3(0.000000, 0.000000, -98.199989), 0, 0, player, 200, 200);
            fk39.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2040, -80.952682, 1165.460083, 19.298551, 5.299997, 0.000000, -119.500007, object_world, object_int, -1, 300.00, 300.00); 
            var fk40 = new DynamicObject(2040, new Vector3(-80.952682, 1165.460083, 19.298551), new Vector3(5.299997, 0.000000, -119.500007), 0, 0, player, 200, 200);
            fk40.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(355, -81.636398, 1165.197998, 19.034393, 9.199998, -90.000000, 61.300014, object_world, object_int, -1, 300.00, 300.00); 
            var fk41 = new DynamicObject(355, new Vector3(-81.636398, 1165.197998, 19.034393), new Vector3(9.199998, -90.000000, 61.300014), 0, 0, player, 200, 200);
            fk41.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(358, -81.310081, 1164.917236, 19.705297, -88.499923, -177.600006, 44.100021, object_world, object_int, -1, 300.00, 300.00); 
            var fk42 = new DynamicObject(358, new Vector3(-81.310081, 1164.917236, 19.705297), new Vector3(-88.499923, -177.600006, 44.100021), 0, 0, player, 200, 200);
            fk42.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1271, -83.008399, 1160.570800, 19.072195, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk43 = new DynamicObject(1271, new Vector3(-83.008399, 1160.570800, 19.072195), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk43.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1271, -82.719406, 1161.493286, 19.072195, 0.000000, 0.000000, -29.799997, object_world, object_int, -1, 300.00, 300.00); 
            var fk44 = new DynamicObject(1271, new Vector3(-82.719406, 1161.493286, 19.072195), new Vector3(0.000000, 0.000000, -29.799997), 0, 0, player, 200, 200);
            fk44.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1271, -82.967864, 1161.059936, 19.752193, 0.000000, 0.000000, -24.699991, object_world, object_int, -1, 300.00, 300.00); 
            var fk45 = new DynamicObject(1271, new Vector3(-82.967864, 1161.059936, 19.752193), new Vector3(0.000000, 0.000000, -24.699991), 0, 0, player, 200, 200);
            fk45.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3862, -103.372169, 1177.188110, 19.899993, 0.000000, 0.000000, 90.800048, object_world, object_int, -1, 300.00, 300.00); 
            var fk46 = new DynamicObject(3862, new Vector3(-103.372169, 1177.188110, 19.899993), new Vector3(0.000000, 0.000000, 90.800048), 0, 0, player, 200, 200);
            fk46.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3862, -103.282890, 1170.797729, 19.899993, 0.000000, 0.000000, 90.800048, object_world, object_int, -1, 300.00, 300.00); 
            var fk47 = new DynamicObject(3862, new Vector3(-103.282890, 1170.797729, 19.899993), new Vector3(0.000000, 0.000000, 90.800048), 0, 0, player, 200, 200);
            fk47.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3861, -103.243782, 1165.081176, 19.859954, 0.000000, 0.000000, -270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk48 = new DynamicObject(3861, new Vector3(-103.243782, 1165.081176, 19.859954), new Vector3(0.000000, 0.000000, -270.000000), 0, 0, player, 200, 200);
            fk48.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1342, -78.701759, 1178.785888, 19.742198, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk49 = new DynamicObject(1342, new Vector3(-78.701759, 1178.785888, 19.742198), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk49.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1342, -78.701759, 1174.595458, 19.742198, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk50 = new DynamicObject(1342, new Vector3(-78.701759, 1174.595458, 19.742198), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk50.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3171, -93.008857, 1161.033691, 18.692186, 0.000000, 0.000000, -109.300025, object_world, object_int, -1, 300.00, 300.00); 
            var fk51 = new DynamicObject(3171, new Vector3(-93.008857, 1161.033691, 18.692186), new Vector3(0.000000, 0.000000, -109.300025), 0, 0, player, 200, 200);
            fk51.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2115, -91.583679, 1163.970947, 18.742187, 0.000000, 0.000000, -1.399999, object_world, object_int, -1, 300.00, 300.00); 
            var fk52 = new DynamicObject(2115, new Vector3(-91.583679, 1163.970947, 18.742187), new Vector3(0.000000, 0.000000, -1.399999), 0, 0, player, 200, 200);
            fk52.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2232, -89.481521, 1161.511108, 19.302200, 0.000000, 0.000000, -159.500045, object_world, object_int, -1, 300.00, 300.00); 
            var fk53 = new DynamicObject(2232, new Vector3(-89.481521, 1161.511108, 19.302200), new Vector3(0.000000, 0.000000, -159.500045), 0, 0, player, 200, 200);
            fk53.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2232, -88.946716, 1162.189208, 19.302200, 0.000000, 0.000000, -133.200027, object_world, object_int, -1, 300.00, 300.00); 
            var fk54 = new DynamicObject(2232, new Vector3(-88.946716, 1162.189208, 19.302200), new Vector3(0.000000, 0.000000, -133.200027), 0, 0, player, 200, 200);
            fk54.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2322, -89.182647, 1161.856689, 20.192209, 0.000000, 0.000000, -132.900024, object_world, object_int, -1, 300.00, 300.00); 
            var fk55 = new DynamicObject(2322, new Vector3(-89.182647, 1161.856689, 20.192209), new Vector3(0.000000, 0.000000, -132.900024), 0, 0, player, 200, 200);
            fk55.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18872, -90.349845, 1164.089843, 19.532190, 0.000000, 0.000000, 33.799999, object_world, object_int, -1, 300.00, 300.00); 
            var fk56 = new DynamicObject(18872, new Vector3(-90.349845, 1164.089843, 19.532190), new Vector3(0.000000, 0.000000, 33.799999), 0, 0, player, 200, 200);
            fk56.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18872, -90.457901, 1164.017822, 19.532190, 0.000000, 0.000000, 33.799999, object_world, object_int, -1, 300.00, 300.00); 
            var fk57 = new DynamicObject(18872, new Vector3(-90.457901, 1164.017822, 19.532190), new Vector3(0.000000, 0.000000, 33.799999), 0, 0, player, 200, 200);
            fk57.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18867, -90.627708, 1163.989624, 19.532197, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk58 = new DynamicObject(18867, new Vector3(-90.627708, 1163.989624, 19.532197), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk58.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18875, -90.617301, 1164.211303, 19.552200, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk59 = new DynamicObject(18875, new Vector3(-90.617301, 1164.211303, 19.552200), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk59.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1839, -90.676040, 1163.997680, 18.722187, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk60 = new DynamicObject(1839, new Vector3(-90.676040, 1163.997680, 18.722187), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk60.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1839, -91.586067, 1163.997680, 18.722187, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk61 = new DynamicObject(1839, new Vector3(-91.586067, 1163.997680, 18.722187), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk61.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1785, -91.465965, 1164.010620, 19.622188, 0.000000, 0.000000, 28.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk62 = new DynamicObject(1785, new Vector3(-91.465965, 1164.010620, 19.622188), new Vector3(0.000000, 0.000000, 28.000000), 0, 0, player, 200, 200);
            fk62.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19318, -90.946540, 1161.736938, 19.401264, -11.600000, 0.000000, 161.099990, object_world, object_int, -1, 300.00, 300.00); 
            var fk63 = new DynamicObject(19318, new Vector3(-90.946540, 1161.736938, 19.401264), new Vector3(-11.600000, 0.000000, 161.099990), 0, 0, player, 200, 200);
            fk63.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3031, -87.934089, 1162.640991, 20.282199, 0.000000, 0.000000, 72.799995, object_world, object_int, -1, 300.00, 300.00); 
            var fk64 = new DynamicObject(3031, new Vector3(-87.934089, 1162.640991, 20.282199), new Vector3(0.000000, 0.000000, 72.799995), 0, 0, player, 200, 200);
            fk64.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3031, -92.773498, 1161.287963, 23.102201, 0.000000, 0.000000, -172.199981, object_world, object_int, -1, 300.00, 300.00); 
            var fk65 = new DynamicObject(3031, new Vector3(-92.773498, 1161.287963, 23.102201), new Vector3(0.000000, 0.000000, -172.199981), 0, 0, player, 200, 200);
            fk65.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19602, -82.697998, 1161.581298, 19.472187, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk66 = new DynamicObject(19602, new Vector3(-82.697998, 1161.581298, 19.472187), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk66.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1439, -83.778106, 1187.782104, 18.812189, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk67 = new DynamicObject(1439, new Vector3(-83.778106, 1187.782104, 18.812189), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk67.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1439, -104.838081, 1180.363037, 18.812189, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk68 = new DynamicObject(1439, new Vector3(-104.838081, 1180.363037, 18.812189), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk68.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2670, -91.722518, 1165.581909, 18.829973, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk69 = new DynamicObject(2670, new Vector3(-91.722518, 1165.581909, 18.829973), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk69.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1437, -170.510177, 1173.039184, 22.534311, -63.200057, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk70 = new DynamicObject(1437, new Vector3(-170.510177, 1173.039184, 22.534311), new Vector3(-63.200057, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk70.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(8572, -176.897857, 1172.841430, 20.942203, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk71 = new DynamicObject(8572, new Vector3(-176.897857, 1172.841430, 20.942203), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk71.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1711, -178.369247, 1176.847412, 21.911260, 0.000000, 0.000000, 134.399963, object_world, object_int, -1, 300.00, 300.00); 
            var fk72 = new DynamicObject(1711, new Vector3(-178.369247, 1176.847412, 21.911260), new Vector3(0.000000, 0.000000, 134.399963), 0, 0, player, 200, 200);
            fk72.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1438, -174.368743, 1179.872070, 21.911260, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk73 = new DynamicObject(1438, new Vector3(-174.368743, 1179.872070, 21.911260), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk73.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2111, -177.731231, 1178.913940, 22.291254, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk74 = new DynamicObject(2111, new Vector3(-177.731231, 1178.913940, 22.291254), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk74.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3062, -170.501571, 1177.096191, 23.351274, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk75 = new DynamicObject(3062, new Vector3(-170.501571, 1177.096191, 23.351274), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk75.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19321, -166.945556, 1178.674926, 23.406112, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk76 = new DynamicObject(19321, new Vector3(-166.945556, 1178.674926, 23.406112), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk76.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3062, -170.501571, 1180.196533, 23.351274, 0.000000, 0.000000, 154.500076, object_world, object_int, -1, 300.00, 300.00); 
            var fk77 = new DynamicObject(3062, new Vector3(-170.501571, 1180.196533, 23.351274), new Vector3(0.000000, 0.000000, 154.500076), 0, 0, player, 200, 200);
            fk77.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1793, -166.838562, 1179.865112, 21.933109, 0.000000, 0.000000, -107.399971, object_world, object_int, -1, 300.00, 300.00); 
            var fk78 = new DynamicObject(1793, new Vector3(-166.838562, 1179.865112, 21.933109), new Vector3(0.000000, 0.000000, -107.399971), 0, 0, player, 200, 200);
            fk78.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1362, -171.524703, 1177.684204, 22.531274, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk79 = new DynamicObject(1362, new Vector3(-171.524703, 1177.684204, 22.531274), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk79.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18688, -171.631439, 1177.581420, 21.341255, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk80 = new DynamicObject(18688, new Vector3(-171.631439, 1177.581420, 21.341255), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk80.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1372, -165.089385, 1173.205932, 18.862190, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk81 = new DynamicObject(1372, new Vector3(-165.089385, 1173.205932, 18.862190), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk81.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1372, -167.489410, 1173.205932, 18.862190, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk82 = new DynamicObject(1372, new Vector3(-167.489410, 1173.205932, 18.862190), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk82.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(14861, -168.618057, 1169.144897, 19.099996, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk83 = new DynamicObject(14861, new Vector3(-168.618057, 1169.144897, 19.099996), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
            fk83.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1483, -167.113601, 1170.209594, 21.602216, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk84 = new DynamicObject(1483, new Vector3(-167.113601, 1170.209594, 21.602216), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
            fk84.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1483, -167.113601, 1172.929565, 18.092205, 0.000000, 180.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk85 = new DynamicObject(1483, new Vector3(-167.113601, 1172.929565, 18.092205), new Vector3(0.000000, 180.000000, -90.000000), 0, 0, player, 200, 200);
            fk85.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1464, -172.671707, 1173.013305, 19.810003, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk86 = new DynamicObject(1464, new Vector3(-172.671707, 1173.013305, 19.810003), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk86.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1464, -169.911727, 1173.013305, 19.810003, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk87 = new DynamicObject(1464, new Vector3(-169.911727, 1173.013305, 19.810003), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk87.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(14880, -165.141937, 1169.664916, 19.079984, 0.000000, 0.000000, 90.199996, object_world, object_int, -1, 300.00, 300.00); 
            var fk88 = new DynamicObject(14880, new Vector3(-165.141937, 1169.664916, 19.079984), new Vector3(0.000000, 0.000000, 90.199996), 0, 0, player, 200, 200);
            fk88.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1265, -170.466110, 1168.853637, 19.119993, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk89 = new DynamicObject(1265, new Vector3(-170.466110, 1168.853637, 19.119993), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk89.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1721, -175.000732, 1172.779785, 18.729988, 0.000000, 0.000000, 119.400016, object_world, object_int, -1, 300.00, 300.00); 
            var fk90 = new DynamicObject(1721, new Vector3(-175.000732, 1172.779785, 18.729988), new Vector3(0.000000, 0.000000, 119.400016), 0, 0, player, 200, 200);
            fk90.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1219, -180.085861, 1165.808837, 19.932189, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk91 = new DynamicObject(1219, new Vector3(-180.085861, 1165.808837, 19.932189), new Vector3(0.000000, -90.000000, 0.000000), 0, 0, player, 200, 200);
            fk91.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1219, -180.095855, 1160.959228, 19.932262, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk92 = new DynamicObject(1219, new Vector3(-180.095855, 1160.959228, 19.932262), new Vector3(0.000000, -90.000000, 0.000000), 0, 0, player, 200, 200);
            fk92.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1219, -180.105850, 1184.277832, 19.932346, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk93 = new DynamicObject(1219, new Vector3(-180.105850, 1184.277832, 19.932346), new Vector3(0.000000, -90.000000, 0.000000), 0, 0, player, 200, 200);
            fk93.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18660, -173.350509, 1181.628295, 23.541265, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk94 = new DynamicObject(18660, new Vector3(-173.350509, 1181.628295, 23.541265), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk94.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2866, -177.994857, 1178.681518, 22.711265, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk95 = new DynamicObject(2866, new Vector3(-177.994857, 1178.681518, 22.711265), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk95.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1812, -165.158523, 1159.527832, 23.256544, 0.000000, 3.400002, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk96 = new DynamicObject(1812, new Vector3(-165.158523, 1159.527832, 23.256544), new Vector3(0.000000, 3.400002, 0.000000), 0, 0, player, 200, 200);
            fk96.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1812, -165.158523, 1163.027954, 23.256544, 0.000000, 3.400002, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk97 = new DynamicObject(1812, new Vector3(-165.158523, 1163.027954, 23.256544), new Vector3(0.000000, 3.400002, 0.000000), 0, 0, player, 200, 200);
            fk97.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1812, -166.960144, 1160.145751, 23.365673, 0.000000, 3.400002, -5.299999, object_world, object_int, -1, 300.00, 300.00); 
            var fk98 = new DynamicObject(1812, new Vector3(-166.960144, 1160.145751, 23.365673), new Vector3(0.000000, 3.400002, -5.299999), 0, 0, player, 200, 200);
            fk98.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1369, -171.112365, 1162.002197, 24.006126, 0.000000, 1.799999, 164.999923, object_world, object_int, -1, 300.00, 300.00); 
            var fk99 = new DynamicObject(1369, new Vector3(-171.112365, 1162.002197, 24.006126), new Vector3(0.000000, 1.799999, 164.999923), 0, 0, player, 200, 200);
            fk99.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1722, -174.651443, 1163.716430, 23.516119, -1.299993, 2.300000, -59.500000, object_world, object_int, -1, 300.00, 300.00); 
            var fk100 = new DynamicObject(1722, new Vector3(-174.651443, 1163.716430, 23.516119), new Vector3(-1.299993, 2.300000, -59.500000), 0, 0, player, 200, 200);
            fk100.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1362, -173.948303, 1161.040771, 24.056156, 1.799998, 1.600000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk101 = new DynamicObject(1362, new Vector3(-173.948303, 1161.040771, 24.056156), new Vector3(1.799998, 1.600000, 0.000000), 0, 0, player, 200, 200);
            fk101.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18688, -174.046630, 1160.951293, 22.996103, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk102 = new DynamicObject(18688, new Vector3(-174.046630, 1160.951293, 22.996103), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk102.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1474, -168.349624, 1160.214111, 24.676137, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk103 = new DynamicObject(1474, new Vector3(-168.349624, 1160.214111, 24.676137), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk103.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1474, -168.349624, 1161.714599, 24.676137, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk104 = new DynamicObject(1474, new Vector3(-168.349624, 1161.714599, 24.676137), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            fk104.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(917, -168.969360, 1164.771850, 23.496051, 0.000000, 1.800001, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk105 = new DynamicObject(917, new Vector3(-168.969360, 1164.771850, 23.496051), new Vector3(0.000000, 1.800001, 0.000000), 0, 0, player, 200, 200);
            fk105.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -81.232734, 1305.032470, 10.902971, 0.000000, 0.000000, 360.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk106 = new DynamicObject(3279, new Vector3(-81.232734, 1305.032470, 10.902971), new Vector3(0.000000, 0.000000, 360.000000), 0, 0, player, 200, 200);
            fk106.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -56.142932, 1305.032470, 10.622963, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk107 = new DynamicObject(3279, new Vector3(-56.142932, 1305.032470, 10.622963), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
            fk107.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -371.263000, 1272.294189, 23.312990, 0.000000, 0.000000, 360.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk108 = new DynamicObject(3279, new Vector3(-371.263000, 1272.294189, 23.312990), new Vector3(0.000000, 0.000000, 360.000000), 0, 0, player, 200, 200);
            fk108.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(12991, -381.001556, 1267.727294, 23.648094, 0.000000, 0.000000, -76.899948, object_world, object_int, -1, 300.00, 300.00); 
            var fk109 = new DynamicObject(12991, new Vector3(-381.001556, 1267.727294, 23.648094), new Vector3(0.000000, 0.000000, -76.899948), 0, 0, player, 200, 200);
            fk109.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, 173.302993, 1130.456787, 13.462953, 0.000000, 0.000000, 161.800018, object_world, object_int, -1, 300.00, 300.00); 
            var fk110 = new DynamicObject(3279, new Vector3(173.302993, 1130.456787, 13.462953), new Vector3(0.000000, 0.000000, 161.800018), 0, 0, player, 200, 200);
            fk110.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1437, 96.145240, 1173.430541, 18.434040, -20.000003, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk111 = new DynamicObject(1437, new Vector3(96.145240, 1173.430541, 18.434040), new Vector3(-20.000003, 0.000000, -90.000000), 0, 0, player, 200, 200);
            fk111.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1431, 103.847793, 1177.935791, 23.004253, 0.000000, 0.000000, 99.299987, object_world, object_int, -1, 300.00, 300.00); 
            var fk112 = new DynamicObject(1431, new Vector3(103.847793, 1177.935791, 23.004253), new Vector3(0.000000, 0.000000, 99.299987), 0, 0, player, 200, 200);
            fk112.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1431, 104.093673, 1175.803710, 23.004253, 0.000000, 0.000000, 90.200004, object_world, object_int, -1, 300.00, 300.00); 
            var fk113 = new DynamicObject(1431, new Vector3(104.093673, 1175.803710, 23.004253), new Vector3(0.000000, 0.000000, 90.200004), 0, 0, player, 200, 200);
            fk113.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2985, 103.234451, 1176.754272, 22.429550, 0.000000, 0.000000, 9.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk114 = new DynamicObject(2985, new Vector3(103.234451, 1176.754272, 22.429550), new Vector3(0.000000, 0.000000, 9.000000), 0, 0, player, 200, 200);
            fk114.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2973, 104.437965, 1170.842407, 22.424585, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk115 = new DynamicObject(2973, new Vector3(104.437965, 1170.842407, 22.424585), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk115.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2359, 102.877006, 1178.120727, 22.657268, 0.000000, 0.000000, 95.300010, object_world, object_int, -1, 300.00, 300.00); 
            var fk116 = new DynamicObject(2359, new Vector3(102.877006, 1178.120727, 22.657268), new Vector3(0.000000, 0.000000, 95.300010), 0, 0, player, 200, 200);
            fk116.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2977, 96.367874, 1171.428466, 17.514059, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk117 = new DynamicObject(2977, new Vector3(96.367874, 1171.428466, 17.514059), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk117.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2977, 96.367874, 1170.228149, 17.514059, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk118 = new DynamicObject(2977, new Vector3(96.367874, 1170.228149, 17.514059), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk118.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3015, 102.837356, 1170.074707, 22.591102, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk119 = new DynamicObject(3015, new Vector3(102.837356, 1170.074707, 22.591102), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk119.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3015, 102.837356, 1170.554809, 22.591102, 0.000000, 0.000000, -9.500000, object_world, object_int, -1, 300.00, 300.00); 
            var fk120 = new DynamicObject(3015, new Vector3(102.837356, 1170.554809, 22.591102), new Vector3(0.000000, 0.000000, -9.500000), 0, 0, player, 200, 200);
            fk120.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3014, 102.739761, 1171.062011, 22.680717, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk121 = new DynamicObject(3014, new Vector3(102.739761, 1171.062011, 22.680717), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk121.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1431, 102.671936, 1179.756835, 23.004253, 0.000000, 0.000000, 143.399963, object_world, object_int, -1, 300.00, 300.00); 
            var fk122 = new DynamicObject(1431, new Vector3(102.671936, 1179.756835, 23.004253), new Vector3(0.000000, 0.000000, 143.399963), 0, 0, player, 200, 200);
            fk122.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19996, 101.728736, 1177.355590, 22.491416, 0.000000, 0.000000, 64.999992, object_world, object_int, -1, 300.00, 300.00); 
            var fk123 = new DynamicObject(19996, new Vector3(101.728736, 1177.355590, 22.491416), new Vector3(0.000000, 0.000000, 64.999992), 0, 0, player, 200, 200);
            fk123.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, 294.230133, 1236.629760, 13.882926, 0.000000, 0.000000, -125.899955, object_world, object_int, -1, 300.00, 300.00); 
            var fk124 = new DynamicObject(3279, new Vector3(294.230133, 1236.629760, 13.882926), new Vector3(0.000000, 0.000000, -125.899955), 0, 0, player, 200, 200);
            fk124.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, 272.742156, 1247.566162, 14.562927, 0.000000, 0.000000, -125.899955, object_world, object_int, -1, 300.00, 300.00); 
            var fk125 = new DynamicObject(3279, new Vector3(272.742156, 1247.566162, 14.562927), new Vector3(0.000000, 0.000000, -125.899955), 0, 0, player, 200, 200);
            fk125.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, 208.148681, 976.581604, 27.442966, 0.000000, 0.000000, 108.900070, object_world, object_int, -1, 300.00, 300.00); 
            var fk126 = new DynamicObject(3279, new Vector3(208.148681, 976.581604, 27.442966), new Vector3(0.000000, 0.000000, 108.900070), 0, 0, player, 200, 200);
            fk126.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, 232.312774, 985.868530, 27.102958, 0.000000, 0.000000, 108.900070, object_world, object_int, -1, 300.00, 300.00); 
            var fk127 = new DynamicObject(3279, new Vector3(232.312774, 985.868530, 27.102958), new Vector3(0.000000, 0.000000, 108.900070), 0, 0, player, 200, 200);
            fk127.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -129.893020, 807.794189, 19.802949, 0.000000, 0.000000, 108.900070, object_world, object_int, -1, 300.00, 300.00); 
            var fk128 = new DynamicObject(3279, new Vector3(-129.893020, 807.794189, 19.802949), new Vector3(0.000000, 0.000000, 108.900070), 0, 0, player, 200, 200);
            fk128.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -275.602600, 809.060485, 13.773155, -2.099999, 0.000000, 38.500072, object_world, object_int, -1, 300.00, 300.00); 
            var fk129 = new DynamicObject(3279, new Vector3(-275.602600, 809.060485, 13.773155), new Vector3(-2.099999, 0.000000, 38.500072), 0, 0, player, 200, 200);
            fk129.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -398.146850, 994.450561, 9.602944, 0.000000, 0.000000, -37.999885, object_world, object_int, -1, 300.00, 300.00); 
            var fk130 = new DynamicObject(3279, new Vector3(-398.146850, 994.450561, 9.602944), new Vector3(0.000000, 0.000000, -37.999885), 0, 0, player, 200, 200);
            fk130.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19966, -445.321228, 1218.676391, 28.736557, -4.399999, 6.500000, -96.800018, object_world, object_int, -1, 300.00, 300.00); 
            var fk131 = new DynamicObject(19966, new Vector3(-445.321228, 1218.676391, 28.736557), new Vector3(-4.399999, 6.500000, -96.800018), 0, 0, player, 200, 200);
            fk131.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(8615, -433.956665, 1230.297729, 32.151775, 0.000000, 0.000000, -168.099960, object_world, object_int, -1, 300.00, 300.00); 
            var fk132 = new DynamicObject(8615, new Vector3(-433.956665, 1230.297729, 32.151775), new Vector3(0.000000, 0.000000, -168.099960), 0, 0, player, 200, 200);
            fk132.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2985, -436.756530, 1223.901855, 33.837959, 0.000000, 0.000000, -166.399932, object_world, object_int, -1, 300.00, 300.00); 
            var fk133 = new DynamicObject(2985, new Vector3(-436.756530, 1223.901855, 33.837959), new Vector3(0.000000, 0.000000, -166.399932), 0, 0, player, 200, 200);
            fk133.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2060, -437.351257, 1223.039794, 33.977897, 0.000000, 0.000000, -45.200000, object_world, object_int, -1, 300.00, 300.00); 
            var fk134 = new DynamicObject(2060, new Vector3(-437.351257, 1223.039794, 33.977897), new Vector3(0.000000, 0.000000, -45.200000), 0, 0, player, 200, 200);
            fk134.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2060, -437.595275, 1224.205200, 33.957901, 0.000000, 0.000000, -103.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk135 = new DynamicObject(2060, new Vector3(-437.595275, 1224.205200, 33.957901), new Vector3(0.000000, 0.000000, -103.000000), 0, 0, player, 200, 200);
            fk135.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2060, -437.611145, 1224.136840, 34.187862, 0.000000, 0.000000, -103.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk136 = new DynamicObject(2060, new Vector3(-437.611145, 1224.136840, 34.187862), new Vector3(0.000000, 0.000000, -103.000000), 0, 0, player, 200, 200);
            fk136.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2060, -437.407653, 1223.096435, 34.237854, 0.000000, 0.000000, -45.200000, object_world, object_int, -1, 300.00, 300.00); 
            var fk137 = new DynamicObject(2060, new Vector3(-437.407653, 1223.096435, 34.237854), new Vector3(0.000000, 0.000000, -45.200000), 0, 0, player, 200, 200);
            fk137.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2060, -437.713409, 1223.598144, 34.447822, 0.000000, 0.000000, -79.600028, object_world, object_int, -1, 300.00, 300.00); 
            var fk138 = new DynamicObject(2060, new Vector3(-437.713409, 1223.598144, 34.447822), new Vector3(0.000000, 0.000000, -79.600028), 0, 0, player, 200, 200);
            fk138.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3585, -421.725006, 1231.690673, 31.116085, -5.900001, 0.000000, 9.599995, object_world, object_int, -1, 300.00, 300.00); 
            var fk139 = new DynamicObject(3585, new Vector3(-421.725006, 1231.690673, 31.116085), new Vector3(-5.900001, 0.000000, 9.599995), 0, 0, player, 200, 200);
            fk139.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3585, -413.564331, 1232.900756, 31.344280, -3.900000, -0.699998, 6.799995, object_world, object_int, -1, 300.00, 300.00); 
            var fk140 = new DynamicObject(3585, new Vector3(-413.564331, 1232.900756, 31.344280), new Vector3(-3.900000, -0.699998, 6.799995), 0, 0, player, 200, 200);
            fk140.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3633, -434.771697, 1220.246704, 34.281646, 0.000000, 0.000000, 15.000007, object_world, object_int, -1, 300.00, 300.00); 
            var fk141 = new DynamicObject(3633, new Vector3(-434.771697, 1220.246704, 34.281646), new Vector3(0.000000, 0.000000, 15.000007), 0, 0, player, 200, 200);
            fk141.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3593, -482.617584, 1216.961425, 29.047889, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk142 = new DynamicObject(3593, new Vector3(-482.617584, 1216.961425, 29.047889), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk142.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3788, -429.329010, 1221.959472, 29.896795, 0.000000, 0.000000, 11.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk143 = new DynamicObject(3788, new Vector3(-429.329010, 1221.959472, 29.896795), new Vector3(0.000000, 0.000000, 11.000000), 0, 0, player, 200, 200);
            fk143.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2041, -434.532012, 1220.602416, 34.965194, 0.000000, 0.000000, -31.400003, object_world, object_int, -1, 300.00, 300.00); 
            var fk144 = new DynamicObject(2041, new Vector3(-434.532012, 1220.602416, 34.965194), new Vector3(0.000000, 0.000000, -31.400003), 0, 0, player, 200, 200);
            fk144.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2619, -435.697326, 1219.263427, 35.640365, -3.300004, 0.000000, -79.699951, object_world, object_int, -1, 300.00, 300.00); 
            var fk145 = new DynamicObject(2619, new Vector3(-435.697326, 1219.263427, 35.640365), new Vector3(-3.300004, 0.000000, -79.699951), 0, 0, player, 200, 200);
            fk145.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2358, -437.496948, 1225.206176, 33.982406, 0.000000, 0.000000, 135.499923, object_world, object_int, -1, 300.00, 300.00); 
            var fk146 = new DynamicObject(2358, new Vector3(-437.496948, 1225.206176, 33.982406), new Vector3(0.000000, 0.000000, 135.499923), 0, 0, player, 200, 200);
            fk146.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -145.505035, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk147 = new DynamicObject(19641, new Vector3(-145.505035, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk147.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -137.505004, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk148 = new DynamicObject(19641, new Vector3(-137.505004, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk148.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -129.504943, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk149 = new DynamicObject(19641, new Vector3(-129.504943, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk149.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -121.505065, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk150 = new DynamicObject(19641, new Vector3(-121.505065, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk150.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -113.505088, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk151 = new DynamicObject(19641, new Vector3(-113.505088, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk151.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -109.685111, 1112.296875, 18.749988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk152 = new DynamicObject(19641, new Vector3(-109.685111, 1112.296875, 18.749988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk152.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -109.685111, 1120.295776, 18.749988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk153 = new DynamicObject(19641, new Vector3(-109.685111, 1120.295776, 18.749988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk153.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -109.685111, 1128.295776, 18.749988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk154 = new DynamicObject(19641, new Vector3(-109.685111, 1128.295776, 18.749988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk154.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(8674, -150.538604, 1113.586791, 22.000013, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk155 = new DynamicObject(8674, new Vector3(-150.538604, 1113.586791, 22.000013), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk155.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(8674, -150.538604, 1123.937133, 22.000013, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk156 = new DynamicObject(8674, new Vector3(-150.538604, 1123.937133, 22.000013), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk156.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(8674, -150.538604, 1131.647338, 22.000013, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk157 = new DynamicObject(8674, new Vector3(-150.538604, 1131.647338, 22.000013), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk157.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -113.575134, 1132.186889, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk158 = new DynamicObject(19641, new Vector3(-113.575134, 1132.186889, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk158.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -121.575126, 1132.186889, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk159 = new DynamicObject(19641, new Vector3(-121.575126, 1132.186889, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk159.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -129.575134, 1132.186889, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk160 = new DynamicObject(19641, new Vector3(-129.575134, 1132.186889, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk160.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -145.829360, 1130.541137, 18.649986, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk161 = new DynamicObject(3279, new Vector3(-145.829360, 1130.541137, 18.649986), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk161.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19641, -146.525085, 1136.707763, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk162 = new DynamicObject(19641, new Vector3(-146.525085, 1136.707763, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk162.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19912, -132.262512, 1131.557617, 20.342159, 0.000000, 0.000000, -27.100027, object_world, object_int, -1, 300.00, 300.00); 
            //var fk163 = new DynamicObject(19912, new Vector3(-132.262512, 1131.557617, 20.342159), new Vector3(0.000000, 0.000000, -27.100027), 0, 0, player, 200, 200);
            //fk163.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(16095, -129.823028, 1127.316772, 18.739988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk164 = new DynamicObject(16095, new Vector3(-129.823028, 1127.316772, 18.739988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk164.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1697, -129.623046, 1127.234130, 23.799987, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk165 = new DynamicObject(1697, new Vector3(-129.623046, 1127.234130, 23.799987), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk165.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19909, -116.976196, 1116.400634, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk166 = new DynamicObject(19909, new Vector3(-116.976196, 1116.400634, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk166.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2634, -122.862106, 1116.398803, 19.959980, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk167 = new DynamicObject(2634, new Vector3(-122.862106, 1116.398803, 19.959980), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk167.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1697, -114.963096, 1119.844238, 25.179985, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk168 = new DynamicObject(1697, new Vector3(-114.963096, 1119.844238, 25.179985), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk168.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3279, -114.469375, 1127.069091, 18.649986, 0.000000, 0.000000, -180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk169 = new DynamicObject(3279, new Vector3(-114.469375, 1127.069091, 18.649986), new Vector3(0.000000, 0.000000, -180.000000), 0, 0, player, 200, 200);
            fk169.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3173, -223.104812, 1054.487792, 18.662185, 0.000000, 0.000000, -179.200103, object_world, object_int, -1, 300.00, 300.00); 
            var fk170 = new DynamicObject(3173, new Vector3(-223.104812, 1054.487792, 18.662185), new Vector3(0.000000, 0.000000, -179.200103), 0, 0, player, 200, 200);
            fk170.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3171, -234.733489, 1040.640258, 18.702186, 0.000000, 0.000000, -163.399993, object_world, object_int, -1, 300.00, 300.00); 
            var fk171 = new DynamicObject(3171, new Vector3(-234.733489, 1040.640258, 18.702186), new Vector3(0.000000, 0.000000, -163.399993), 0, 0, player, 200, 200);
            fk171.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19632, -229.703536, 1045.759765, 18.744390, 0.000000, 0.000000, 54.399997, object_world, object_int, -1, 300.00, 300.00); 
            var fk172 = new DynamicObject(19632, new Vector3(-229.703536, 1045.759765, 18.744390), new Vector3(0.000000, 0.000000, 54.399997), 0, 0, player, 200, 200);
            fk172.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1358, -221.183593, 1045.108764, 19.942193, 0.000000, 0.000000, 37.899993, object_world, object_int, -1, 300.00, 300.00); 
            var fk173 = new DynamicObject(1358, new Vector3(-221.183593, 1045.108764, 19.942193), new Vector3(0.000000, 0.000000, 37.899993), 0, 0, player, 200, 200);
            fk173.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(12957, -234.719238, 1058.412475, 19.402202, 0.000000, 0.000000, 27.000009, object_world, object_int, -1, 300.00, 300.00); 
            var fk174 = new DynamicObject(12957, new Vector3(-234.719238, 1058.412475, 19.402202), new Vector3(0.000000, 0.000000, 27.000009), 0, 0, player, 200, 200);
            fk174.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1334, -235.815216, 1046.485717, 19.552198, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk175 = new DynamicObject(1334, new Vector3(-235.815216, 1046.485717, 19.552198), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk175.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(3005, -230.595062, 1047.780395, 18.742187, 0.000000, 0.000000, -38.199996, object_world, object_int, -1, 300.00, 300.00); 
            var fk176 = new DynamicObject(3005, new Vector3(-230.595062, 1047.780395, 18.742187), new Vector3(0.000000, 0.000000, -38.199996), 0, 0, player, 200, 200);
            fk176.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18862, -221.315933, 1044.479736, 18.792165, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk177 = new DynamicObject(18862, new Vector3(-221.315933, 1044.479736, 18.792165), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk177.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1415, -226.201004, 1060.501464, 18.742187, 0.000000, 0.000000, -48.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk178 = new DynamicObject(1415, new Vector3(-226.201004, 1060.501464, 18.742187), new Vector3(0.000000, 0.000000, -48.299995), 0, 0, player, 200, 200);
            fk178.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(2674, -227.133834, 1047.771240, 18.762187, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk179 = new DynamicObject(2674, new Vector3(-227.133834, 1047.771240, 18.762187), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk179.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1793, -232.665802, 1057.979248, 18.712186, 0.000000, 0.000000, -52.399978, object_world, object_int, -1, 300.00, 300.00); 
            var fk180 = new DynamicObject(1793, new Vector3(-232.665802, 1057.979248, 18.712186), new Vector3(0.000000, 0.000000, -52.399978), 0, 0, player, 200, 200);
            fk180.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19573, -224.934127, 1050.061523, 18.758342, -5.899999, 0.000000, -89.399971, object_world, object_int, -1, 300.00, 300.00); 
            var fk181 = new DynamicObject(19573, new Vector3(-224.934127, 1050.061523, 18.758342), new Vector3(-5.899999, 0.000000, -89.399971), 0, 0, player, 200, 200);
            fk181.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(18663, -213.790100, 1065.782714, 24.396249, 3.599999, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk182 = new DynamicObject(18663, new Vector3(-213.790100, 1065.782714, 24.396249), new Vector3(3.599999, 0.000000, 90.000000), 0, 0, player, 200, 200);
            fk182.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1457, -225.685302, 1067.539916, 20.382207, 0.000000, 0.000000, -177.400009, object_world, object_int, -1, 300.00, 300.00); 
            var fk183 = new DynamicObject(1457, new Vector3(-225.685302, 1067.539916, 20.382207), new Vector3(0.000000, 0.000000, -177.400009), 0, 0, player, 200, 200);
            fk183.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1793, -227.856887, 1067.403930, 18.382179, 0.000000, 0.000000, -87.999946, object_world, object_int, -1, 300.00, 300.00); 
            var fk184 = new DynamicObject(1793, new Vector3(-227.856887, 1067.403930, 18.382179), new Vector3(0.000000, 0.000000, -87.999946), 0, 0, player, 200, 200);
            fk184.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1438, -228.462478, 1068.048828, 18.722187, 0.000000, 0.000000, 124.100013, object_world, object_int, -1, 300.00, 300.00); 
            var fk185 = new DynamicObject(1438, new Vector3(-228.462478, 1068.048828, 18.722187), new Vector3(0.000000, 0.000000, 124.100013), 0, 0, player, 200, 200);
            fk185.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1370, -223.796768, 1067.992309, 19.272199, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk186 = new DynamicObject(1370, new Vector3(-223.796768, 1067.992309, 19.272199), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk186.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1462, -219.683837, 1072.614746, 18.732187, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk187 = new DynamicObject(1462, new Vector3(-219.683837, 1072.614746, 18.732187), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
            fk187.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(849, -223.431808, 1071.410400, 19.002193, 0.000000, 0.000000, -35.500000, object_world, object_int, -1, 300.00, 300.00); 
            var fk188 = new DynamicObject(849, new Vector3(-223.431808, 1071.410400, 19.002193), new Vector3(0.000000, 0.000000, -35.500000), 0, 0, player, 200, 200);
            fk188.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(1812, -230.462188, 1068.958251, 18.732187, 0.000000, 0.000000, 81.500007, object_world, object_int, -1, 300.00, 300.00); 
            var fk189 = new DynamicObject(1812, new Vector3(-230.462188, 1068.958251, 18.732187), new Vector3(0.000000, 0.000000, 81.500007), 0, 0, player, 200, 200);
            fk189.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(19306, -225.753463, 1069.229370, 21.957248, 0.000000, 14.900001, 82.700004, object_world, object_int, -1, 300.00, 300.00); 
            var fk190 = new DynamicObject(19306, new Vector3(-225.753463, 1069.229370, 21.957248), new Vector3(0.000000, 14.900001, 82.700004), 0, 0, player, 200, 200);
            fk190.ShowInWorld(0);

            //BUNKER MAPP YEAHHHH WORK IT

            //new tmpobjid, object_world = -1, object_int = -1;
            //tmpobjid = CreateDynamicObject(19379, 2203.672851, 1551.671508, 1011.881958, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0x00000000);
            var shelter1 = new DynamicObject(19379, new Vector3(2203.672851, 1551.671508, 1011.881958), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter1.SetMaterial(0, 3899, "hospital2", "cutscenebank128", 0);
            shelter1.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2927, 2203.738281, 1553.555419, 1009.532348, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter2 = new DynamicObject(2927, new Vector3(2203.738281, 1553.555419, 1009.532348), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter2.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter2.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2927, 2203.738281, 1549.454956, 1009.532348, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter3 = new DynamicObject(2927, new Vector3(2203.738281, 1549.454956, 1009.532348), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter3.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter3.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(934, 2220.886718, 1549.972534, 1004.907043, 0.000000, 0.000000, -46.299980, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter4 = new DynamicObject(934, new Vector3(2220.886718, 1549.972534, 1004.907043), new Vector3(0.000000, 0.000000, -46.299980), 1010, 1, player, 200, 200);
            shelter4.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter4.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2209.704833, 1585.082885, 998.942138, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0x00000000);
            var shelter5 = new DynamicObject(19379, new Vector3(2209.704833, 1585.082885, 998.942138), new Vector3(0.000000, 90.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter5.SetMaterial(0, 3899, "hospital2", "cutscenebank128", 0);
            shelter5.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2199.215820, 1585.082885, 998.942138, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0x00000000);
            var shelter6 = new DynamicObject(19379, new Vector3(2199.215820, 1585.082885, 998.942138), new Vector3(0.000000, 90.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter6.SetMaterial(0, 3899, "hospital2", "cutscenebank128", 0);
            shelter6.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2229.267089, 1590.803833, 999.312255, 90.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0xFFAAAAAA);
            var shelter7 = new DynamicObject(19379, new Vector3(2229.267089, 1590.803833, 999.312255), new Vector3(90.000000, 90.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter7.SetMaterial(0, 3899, "hospital2", "cutscenebank128", SampSharp.GameMode.SAMP.Color.Gray);
            shelter7.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2218.771972, 1590.803833, 995.318420, 90.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0xFFAAAAAA);
            var shelter8 = new DynamicObject(19379, new Vector3(2218.771972, 1590.803833, 995.318420), new Vector3(90.000000, 90.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter8.SetMaterial(0, 3899, "hospital2", "cutscenebank128", SampSharp.GameMode.SAMP.Color.Gray);
            shelter8.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2218.771972, 1590.803833, 1006.329040, 90.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0xFFAAAAAA);
            var shelter9 = new DynamicObject(19379, new Vector3(2218.771972, 1590.803833, 1006.329040), new Vector3(90.000000, 90.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter9.SetMaterial(0, 3899, "hospital2", "cutscenebank128", SampSharp.GameMode.SAMP.Color.Gray);
            shelter9.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(942, 2230.237060, 1592.285156, 1001.316101, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter10 = new DynamicObject(942, new Vector3(2230.237060, 1592.285156, 1001.316101), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter10.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter10.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1369, 2188.585205, 1580.473754, 999.554687, 0.000000, 0.000000, 136.900054, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3083, "billbox", "iron", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 1, 16640, "a51", "Metal3_128", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 2, 16640, "a51", "Metal3_128", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 3, 16640, "a51", "ws_castironwalk", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 4, 16640, "a51", "Metal3_128", 0x00000000);
            var shelter11 = new DynamicObject(1369, new Vector3(2188.585205, 1580.473754, 999.554687), new Vector3(0.000000, 0.000000, 136.900054), 1010, 1, player, 200, 200);
            shelter11.SetMaterial(0, 3083, "billbox", "iron", 0);
            shelter11.SetMaterial(1, 16640, "a51", "Metal3_128", 0);
            shelter11.SetMaterial(2, 16640, "a51", "Metal3_128", 0);
            shelter11.SetMaterial(3, 16640, "a51", "ws_castironwalk", 0);
            shelter11.SetMaterial(4, 16640, "a51", "Metal3_128", 0);
            shelter11.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2713, 2190.550048, 1591.147583, 999.088195, 0.000000, 0.000000, 69.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 14584, "ab_abbatoir01", "ab_tiles", 0x00000000);
            var shelter12 = new DynamicObject(2713, new Vector3(2190.550048, 1591.147583, 999.088195), new Vector3(0.000000, 0.000000, 69.000000), 1010, 1, player, 200, 200);
            shelter12.SetMaterial(0, 14584, "ab_abbatoir01", "ab_tiles", 0);
            shelter12.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1499, 2185.364746, 1589.930664, 998.976257, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 2567, "ab", "ab_metaledge", 0xFFAAAAAA);
            //SetDynamicObjectMaterial(tmpobjid, 1, 2567, "ab", "ab_metaledge", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 2, 3853, "gay_xref", "ws_gayflag2", 0x00000000);
            var shelter13 = new DynamicObject(1499, new Vector3(2185.364746, 1589.930664, 998.976257), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter13.SetMaterial(0, 2567, "ab", "ab_metaledge", SampSharp.GameMode.SAMP.Color.Gray);
            shelter13.SetMaterial(1, 2567, "ab", "ab_metaledge", 0);
            shelter13.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2190.550537, 1588.330810, 999.262023, 90.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0x00000000);
            var shelter14 = new DynamicObject(19379, new Vector3(2190.550537, 1588.330810, 999.262023), new Vector3(90.000000, 90.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter14.SetMaterial(0, 3899, "hospital2", "cutscenebank128", 0);
            shelter14.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2190.582275, 1593.095825, 998.892089, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 14584, "ab_abbatoir01", "ab_tiles", 0x00000000);
            var shelter15 = new DynamicObject(19379, new Vector3(2190.582275, 1593.095825, 998.892089), new Vector3(0.000000, 90.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter15.SetMaterial(0, 14584, "ab_abbatoir01", "ab_tiles", 0);
            shelter15.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2185.401123, 1593.550903, 1006.312316, 90.000000, 90.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0x00000000);
            var shelter16 = new DynamicObject(19379, new Vector3(2185.401123, 1593.550903, 1006.312316), new Vector3(90.000000, 90.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter16.SetMaterial(0, 3899, "hospital2", "cutscenebank128", 0);
            shelter16.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19379, 2185.399169, 1595.170166, 996.681884, 90.000000, 90.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 3899, "hospital2", "cutscenebank128", 0x00000000);
            var shelter17 = new DynamicObject(19379, new Vector3(2185.399169, 1595.170166, 996.681884), new Vector3(90.000000, 90.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter17.SetMaterial(0, 3899, "hospital2", "cutscenebank128", 0);
            shelter17.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19482, 2168.364257, 1583.974853, 1002.164916, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterialText(tmpobjid, 0, "LIVING SECTOR", 90, "Impact", 35, 1, 0xFFCC0000, 0x00000000, 1);
            var shelter18 = new DynamicObject(19482, new Vector3(2168.364257, 1583.974853, 1002.164916), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter18.SetMaterialText(0, "{CC0000}LIVING SECTOR", ObjectMaterialSize.X256X128, "Impact", 35, true, 0xFFCC0000, 0x00000000, ObjectMaterialTextAlign.Center);
            shelter18.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19482, 2168.358642, 1586.154174, 1000.352783, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterialText(tmpobjid, 0, "m", 140, "Webdings", 199, 0, 0xFFCC0000, 0x00000000, 0);
            var shelter19 = new DynamicObject(19482, new Vector3(2168.358642, 1586.154174, 1000.352783), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter19.SetMaterialText(0, "{CC0000}m", ObjectMaterialSize.X512X512, "Webdings", 199, false, 0xFFCC0000, 0x00000000, ObjectMaterialTextAlign.Left);
            shelter19.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2631, 2176.097412, 1577.504272, 998.914428, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 14808, "lee_strip2", "Strip_Carpet", 0xFFFFFFFF);
            //SetDynamicObjectMaterial(tmpobjid, 1, -1, "none", "none", 0xFF00FFFF);
            var shelter20 = new DynamicObject(2631, new Vector3(2176.097412, 1577.504272, 998.914428), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter20.SetMaterial(0, 14808, "lee_strip2", "Strip_Carpet", SampSharp.GameMode.SAMP.Color.White);
            shelter20.SetMaterial(1, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter20.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1420, 2216.264160, 1553.125976, 1008.810607, 0.000000, 180.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter21 = new DynamicObject(1420, new Vector3(2216.264160, 1553.125976, 1008.810607), new Vector3(0.000000, 180.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter21.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter21.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1420, 2216.264160, 1549.625610, 1008.810607, 0.000000, 180.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter22 = new DynamicObject(1420, new Vector3(2216.264160, 1549.625610, 1008.810607), new Vector3(0.000000, 180.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter22.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter22.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1685, 2223.366699, 1553.417968, 1004.419189, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter23 = new DynamicObject(1685, new Vector3(2223.366699, 1553.417968, 1004.419189), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter23.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter23.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19482, 2224.588867, 1553.613647, 1007.285400, 0.000000, -0.200118, 166.100036, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            //SetDynamicObjectMaterial(tmpobjid, 1, -1, "none", "none", 0xFFAAAAAA);
            //SetDynamicObjectMaterialText(tmpobjid, 0, "LEVEL -1", 90, "Impact", 45, 0, 0xFAD50000, 0x00000000, 1);
            var shelter24 = new DynamicObject(19482, new Vector3(2224.588867, 1553.613647, 1007.285400), new Vector3(0.000000, -0.200118, 166.100036), 1010, 1, player, 200, 200);
            shelter24.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter24.SetMaterial(1, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter24.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2674, 2217.819335, 1552.547973, 1003.738769, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter25 = new DynamicObject(2674, new Vector3(2217.819335, 1552.547973, 1003.738769), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter25.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter25.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19526, 2215.459472, 1578.758422, 998.978942, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 1, 16644, "a51_detailstuff", "a51_radardisp", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 2, 16644, "a51_detailstuff", "a51_radardisp", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 4, 16644, "a51_detailstuff", "a51_radardisp", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 5, 16377, "des_byofficeint", "hectics_text", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 6, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 7, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 8, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 9, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 10, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 11, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 12, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 13, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 14, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 15, 18064, "ab_sfammuunits", "rubber_mat", 0x00000000);
            //SetDynamicObjectMaterialText(tmpobjid, 3, "{E88725}[SHELTER]\n{000000}TERMINAL", 100, "Arial", 40, 1, 0xFF0D0C0C, 0xFF524847, 1);
            var shelter26 = new DynamicObject(19526, new Vector3(2215.459472, 1578.758422, 998.978942), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter26.SetMaterial(1, 16644, "a51_detailstuff", "a51_radardisp", 0);
            shelter26.SetMaterial(2, 16644, "a51_detailstuff", "a51_radardisp", 0);
            shelter26.SetMaterial(4, 16377, "a51_detailstuff", "a51_radardisp", 0);
            shelter26.SetMaterial(5, 18064, "des_byofficeint", "hectics_text", 0);
            shelter26.SetMaterial(6, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(7, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(8, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(9, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(10, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(11, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(12, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(13, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(14, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.SetMaterial(15, 18064, "ab_sfammuunits", "rubber_mat", 0);
            shelter26.ShowInWorld(1010);
            shelter26.SetMaterialText(3, "{E88725}[SHELTER]\n{000000}TERMINAL", ObjectMaterialSize.X256X256, "Arial", 40, true, SampSharp.GameMode.SAMP.Color.Gray, SampSharp.GameMode.SAMP.Color.DarkGray, ObjectMaterialTextAlign.Center);

            //tmpobjid = CreateDynamicObject(11711, 2225.488769, 1569.160278, 1002.045043, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFAAAAAA);
            var shelter27 = new DynamicObject(11711, new Vector3(2225.488769, 1569.160278, 1002.045043), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter27.SetMaterial(0, -1, "none", "none", SampSharp.GameMode.SAMP.Color.Gray);
            shelter27.ShowInWorld(1010);


            //tmpobjid = CreateDynamicObject(930, 2218.708007, 1547.297485, 1004.184875, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter28 = new DynamicObject(930, new Vector3(2218.708007, 1547.297485, 1004.184875), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter28.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(930, 2217.196533, 1547.297485, 1004.184875, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter29 = new DynamicObject(930, new Vector3(2217.196533, 1547.297485, 1004.184875), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter29.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19143, 2204.142578, 1547.050537, 1011.238525, 0.000000, 0.000000, -56.300014, object_world, object_int, -1, 300.00, 300.00); 
            var shelter30 = new DynamicObject(19143, new Vector3(2204.142578, 1547.050537, 1011.238525), new Vector3(0.000000, 0.000000, -56.300014), 1010, 1, player, 200, 200);
            shelter30.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1566, 2223.549072, 1598.201660, 1000.208435, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter31 = new DynamicObject(1566, new Vector3(2223.549072, 1598.201660, 1000.208435), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter31.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2206, 2217.399414, 1591.406494, 998.950683, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter32 = new DynamicObject(2206, new Vector3(2217.399414, 1591.406494, 998.950683), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter32.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2206, 2220.252197, 1591.406494, 998.950683, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter33 = new DynamicObject(2206, new Vector3(2220.252197, 1591.406494, 998.950683), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter33.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2206, 2223.104980, 1591.406494, 998.950683, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter34 = new DynamicObject(2206, new Vector3(2223.104980, 1591.406494, 998.950683), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter34.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19893, 2219.718017, 1591.345458, 999.884826, 0.000000, 0.000000, -164.500320, object_world, object_int, -1, 300.00, 300.00); 
            var shelter35 = new DynamicObject(19893, new Vector3(2219.718017, 1591.345458, 999.884826), new Vector3(0.000000, 0.000000, -164.500320), 1010, 1, player, 200, 200);
            shelter35.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1665, 2219.200927, 1591.434204, 999.909729, 0.000000, 0.000000, 123.800048, object_world, object_int, -1, 300.00, 300.00); 
            var shelter36 = new DynamicObject(1665, new Vector3(2219.200927, 1591.434204, 999.909729), new Vector3(0.000000, 0.000000, 123.800048), 1010, 1, player, 200, 200);
            shelter36.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1666, 2220.084228, 1591.606445, 999.958618, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter37 = new DynamicObject(1666, new Vector3(2220.084228, 1591.606445, 999.958618), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter37.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(18673, 2219.099121, 1591.392944, 998.365966, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter38 = new DynamicObject(18673, new Vector3(2219.099121, 1591.392944, 998.365966), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter38.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1671, 2219.067382, 1592.919799, 999.399658, 0.000000, 0.000000, 21.399997, object_world, object_int, -1, 300.00, 300.00); 
            var shelter39 = new DynamicObject(1671, new Vector3(2219.067382, 1592.919799, 999.399658), new Vector3(0.000000, 0.000000, 21.399997), 1010, 1, player, 200, 200);
            shelter39.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2161, 2218.991210, 1598.108520, 998.966247, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter40 = new DynamicObject(2161, new Vector3(2218.991210, 1598.108520, 998.966247), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter40.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2161, 2218.991210, 1598.108520, 1000.316711, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter41 = new DynamicObject(2161, new Vector3(2218.991210, 1598.108520, 1000.316711), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter41.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2161, 2220.332519, 1598.108520, 998.966247, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter42 = new DynamicObject(2161, new Vector3(2220.332519, 1598.108520, 998.966247), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter42.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19921, 2220.590087, 1591.559936, 999.977294, 0.000000, 0.000000, -156.999984, object_world, object_int, -1, 300.00, 300.00); 
            var shelter43 = new DynamicObject(19921, new Vector3(2220.590087, 1591.559936, 999.977294), new Vector3(0.000000, 0.000000, -156.999984), 1010, 1, player, 200, 200);
            shelter43.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19515, 2220.662597, 1597.878173, 1000.593322, -6.900022, -92.200119, -177.600082, object_world, object_int, -1, 300.00, 300.00); 
            var shelter44 = new DynamicObject(19515, new Vector3(2220.662597, 1597.878173, 1000.593322), new Vector3(-6.900022, -92.200119, -177.600082), 1010, 1, player, 200, 200);
            shelter44.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19141, 2220.665771, 1597.844482, 1000.880859, -48.899978, -92.999969, -174.200073, object_world, object_int, -1, 300.00, 300.00); 
            var shelter45 = new DynamicObject(19141, new Vector3(2220.665771, 1597.844482, 1000.880859), new Vector3(-48.899978, -92.999969, -174.200073), 1010, 1, player, 200, 200);
            shelter45.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2886, 2225.598632, 1598.158447, 1000.429626, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter46 = new DynamicObject(2886, new Vector3(2225.598632, 1598.158447, 1000.429626), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter46.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(11730, 2218.146728, 1597.876831, 998.858337, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter47 = new DynamicObject(11730, new Vector3(2218.146728, 1597.876831, 998.858337), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter47.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(11730, 2217.456054, 1597.876831, 998.858337, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter48 = new DynamicObject(11730, new Vector3(2217.456054, 1597.876831, 998.858337), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter48.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(11729, 2216.741210, 1597.878784, 998.862060, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter49 = new DynamicObject(11729, new Vector3(2216.741210, 1597.878784, 998.862060), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter49.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(964, 2215.701660, 1597.499633, 998.936523, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter50 = new DynamicObject(964, new Vector3(2215.701660, 1597.499633, 998.936523), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter50.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(964, 2215.711669, 1597.499877, 999.866699, 0.000000, 0.000000, 1.299999, object_world, object_int, -1, 300.00, 300.00); 
            var shelter51 = new DynamicObject(964, new Vector3(2215.711669, 1597.499877, 999.866699), new Vector3(0.000000, 0.000000, 1.299999), 1010, 1, player, 200, 200);
            shelter51.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(964, 2216.041259, 1595.879516, 998.936523, 0.000000, 0.000000, -35.499996, object_world, object_int, -1, 300.00, 300.00); 
            var shelter52 = new DynamicObject(964, new Vector3(2216.041259, 1595.879516, 998.936523), new Vector3(0.000000, 0.000000, -35.499996), 1010, 1, player, 200, 200);
            shelter52.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(942, 2230.237060, 1596.935302, 1001.316101, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter53 = new DynamicObject(942, new Vector3(2230.237060, 1596.935302, 1001.316101), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter53.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(3066, 2209.153808, 1589.490234, 1000.037292, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter54 = new DynamicObject(3066, new Vector3(2209.153808, 1589.490234, 1000.037292), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter54.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2567, 2199.839843, 1589.366333, 1000.887939, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter55 = new DynamicObject(2567, new Vector3(2199.839843, 1589.366333, 1000.887939), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter55.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1812, 2181.948486, 1578.779541, 998.953552, 0.000000, 0.000000, -168.699966, object_world, object_int, -1, 300.00, 300.00); 
            var shelter56 = new DynamicObject(1812, new Vector3(2181.948486, 1578.779541, 998.953552), new Vector3(0.000000, 0.000000, -168.699966), 1010, 1, player, 200, 200);
            shelter56.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1812, 2180.177978, 1579.312255, 998.953552, 0.000000, 0.000000, 163.300094, object_world, object_int, -1, 300.00, 300.00); 
            var shelter57 = new DynamicObject(1812, new Vector3(2180.177978, 1579.312255, 998.953552), new Vector3(0.000000, 0.000000, 163.300094), 1010, 1, player, 200, 200);
            shelter57.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1793, 2186.073486, 1575.394897, 998.843933, 0.000000, 0.000000, 0.299997, object_world, object_int, -1, 300.00, 300.00); 
            var shelter58 = new DynamicObject(1793, new Vector3(2186.073486, 1575.394897, 998.843933), new Vector3(0.000000, 0.000000, 0.299997), 1010, 1, player, 200, 200);
            shelter58.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1793, 2190.889404, 1576.462768, 998.843933, 0.000000, 0.000000, -12.699999, object_world, object_int, -1, 300.00, 300.00); 
            var shelter59 = new DynamicObject(1793, new Vector3(2190.889404, 1576.462768, 998.843933), new Vector3(0.000000, 0.000000, -12.699999), 1010, 1, player, 200, 200);
            shelter59.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2567, 2228.580078, 1586.550170, 1000.880004, 0.000000, 0.000000, -179.999984, object_world, object_int, -1, 300.00, 300.00); 
            var shelter60 = new DynamicObject(2567, new Vector3(2228.580078, 1586.550170, 1000.880004), new Vector3(0.000000, 0.000000, -179.999984), 1010, 1, player, 200, 200);
            shelter60.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2567, 2228.580078, 1580.680175, 1000.880004, 0.000000, 0.000000, -179.999984, object_world, object_int, -1, 300.00, 300.00); 
            var shelter61 = new DynamicObject(2567, new Vector3(2228.580078, 1580.680175, 1000.880004), new Vector3(0.000000, 0.000000, -179.999984), 1010, 1, player, 200, 200);
            shelter61.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1800, 2176.992431, 1575.162841, 998.815673, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter62 = new DynamicObject(1800, new Vector3(2176.992431, 1575.162841, 998.815673), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter62.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1800, 2175.022705, 1575.162841, 998.815673, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter63 = new DynamicObject(1800, new Vector3(2175.022705, 1575.162841, 998.815673), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter63.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2323, 2179.381835, 1577.332275, 998.951293, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter64 = new DynamicObject(2323, new Vector3(2179.381835, 1577.332275, 998.951293), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter64.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2520, 2194.961181, 1592.702514, 998.979003, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter65 = new DynamicObject(2520, new Vector3(2194.961181, 1592.702514, 998.979003), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter65.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1372, 2195.278808, 1581.078491, 999.144409, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter66 = new DynamicObject(1372, new Vector3(2195.278808, 1581.078491, 999.144409), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter66.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1449, 2183.611816, 1576.114746, 999.443420, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter67 = new DynamicObject(1449, new Vector3(2183.611816, 1576.114746, 999.443420), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter67.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2520, 2193.291015, 1592.702514, 998.979003, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter68 = new DynamicObject(2520, new Vector3(2193.291015, 1592.702514, 998.979003), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter68.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2676, 2172.893554, 1587.663940, 999.084899, 0.000000, 0.000000, 77.499984, object_world, object_int, -1, 300.00, 300.00); 
            var shelter69 = new DynamicObject(2676, new Vector3(2172.893554, 1587.663940, 999.084899), new Vector3(0.000000, 0.000000, 77.499984), 1010, 1, player, 200, 200);
            shelter69.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2676, 2180.240722, 1581.662231, 999.084899, 0.000000, 0.000000, 77.499984, object_world, object_int, -1, 300.00, 300.00); 
            var shelter70 = new DynamicObject(2676, new Vector3(2180.240722, 1581.662231, 999.084899), new Vector3(0.000000, 0.000000, 77.499984), 1010, 1, player, 200, 200);
            shelter70.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2520, 2191.570800, 1592.702514, 998.979003, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter71 = new DynamicObject(2520, new Vector3(2191.570800, 1592.702514, 998.979003), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter71.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1415, 2205.741455, 1580.084594, 999.108154, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter72 = new DynamicObject(1415, new Vector3(2205.741455, 1580.084594, 999.108154), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter72.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2514, 2195.207763, 1589.238647, 999.018859, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter73 = new DynamicObject(2514, new Vector3(2195.207763, 1589.238647, 999.018859), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter73.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2695, 2218.688232, 1594.807861, 1001.284118, 0.000000, 4.999998, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter74 = new DynamicObject(2695, new Vector3(2218.688232, 1594.807861, 1001.284118), new Vector3(0.000000, 4.999998, 0.000000), 1010, 1, player, 200, 200);
            shelter74.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19637, 2190.202148, 1586.943847, 1001.366699, 0.000000, 0.000000, 59.800003, object_world, object_int, -1, 300.00, 300.00); 
            var shelter75 = new DynamicObject(19637, new Vector3(2190.202148, 1586.943847, 1001.366699), new Vector3(0.000000, 0.000000, 59.800003), 1010, 1, player, 200, 200);
            shelter75.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1427, 2196.784423, 1582.560668, 999.537963, 0.000000, 0.000000, -73.100006, object_world, object_int, -1, 300.00, 300.00); 
            var shelter76 = new DynamicObject(1427, new Vector3(2196.784423, 1582.560668, 999.537963), new Vector3(0.000000, 0.000000, -73.100006), 1010, 1, player, 200, 200);
            shelter76.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2697, 2174.339599, 1579.773559, 1000.992004, 0.000000, 9.300004, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter77 = new DynamicObject(2697, new Vector3(2174.339599, 1579.773559, 1000.992004), new Vector3(0.000000, 9.300004, 90.000000), 1010, 1, player, 200, 200);
            shelter77.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1482, 2177.666748, 1577.774658, 1000.340759, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter78 = new DynamicObject(1482, new Vector3(2177.666748, 1577.774658, 1000.340759), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter78.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1428, 2176.712890, 1579.955932, 1000.402893, -4.099998, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter79 = new DynamicObject(1428, new Vector3(2176.712890, 1579.955932, 1000.402893), new Vector3(-4.099998, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter79.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1482, 2184.356201, 1577.774658, 1000.340759, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter80 = new DynamicObject(1482, new Vector3(2184.356201, 1577.774658, 1000.340759), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter80.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19906, 2195.860839, 1584.923583, 1004.899169, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter81 = new DynamicObject(19906, new Vector3(2195.860839, 1584.923583, 1004.899169), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter81.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1428, 2185.383300, 1579.966430, 1000.372924, -4.099998, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter82 = new DynamicObject(1428, new Vector3(2185.383300, 1579.966430, 1000.372924), new Vector3(-4.099998, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter82.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1812, 2182.368896, 1578.777099, 1001.753906, 0.000000, 0.000000, 179.600112, object_world, object_int, -1, 300.00, 300.00); 
            var shelter83 = new DynamicObject(1812, new Vector3(2182.368896, 1578.777099, 1001.753906), new Vector3(0.000000, 0.000000, 179.600112), 1010, 1, player, 200, 200);
            shelter83.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1793, 2177.258789, 1579.083251, 1001.744079, 0.000000, 0.000000, -88.900016, object_world, object_int, -1, 300.00, 300.00); 
            var shelter85 = new DynamicObject(1793, new Vector3(2177.258789, 1579.083251, 1001.744079), new Vector3(0.000000, 0.000000, -88.900016), 1010, 1, player, 200, 200);
            shelter85.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1432, 2169.720703, 1577.279296, 999.054748, 0.000000, 0.000000, 6.300002, object_world, object_int, -1, 300.00, 300.00); 
            var shelter86 = new DynamicObject(1432, new Vector3(2169.720703, 1577.279296, 999.054748), new Vector3(0.000000, 0.000000, 6.300002), 1010, 1, player, 200, 200);
            shelter86.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1812, 2185.690673, 1578.753906, 1001.753906, 0.000000, 0.000000, 131.400039, object_world, object_int, -1, 300.00, 300.00); 
            var shelter87 = new DynamicObject(1812, new Vector3(2185.690673, 1578.753906, 1001.753906), new Vector3(0.000000, 0.000000, 131.400039), 1010, 1, player, 200, 200);
            shelter87.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2672, 2174.587158, 1581.961303, 999.257629, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter88 = new DynamicObject(2672, new Vector3(2174.587158, 1581.961303, 999.257629), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter88.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2672, 2171.886962, 1579.351196, 999.257629, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter89 = new DynamicObject(2672, new Vector3(2171.886962, 1579.351196, 999.257629), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter89.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1432, 2169.568359, 1580.692504, 999.054748, 0.000000, 0.000000, 6.300002, object_world, object_int, -1, 300.00, 300.00); 
            var shelter90 = new DynamicObject(1432, new Vector3(2169.568359, 1580.692504, 999.054748), new Vector3(0.000000, 0.000000, 6.300002), 1010, 1, player, 200, 200);
            shelter90.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(935, 2168.728759, 1593.676025, 999.497558, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter91 = new DynamicObject(935, new Vector3(2168.728759, 1593.676025, 999.497558), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter91.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2822, 2169.595214, 1580.724487, 999.670593, 0.000000, 0.000000, 29.800004, object_world, object_int, -1, 300.00, 300.00); 
            var shelter92 = new DynamicObject(2822, new Vector3(2169.595214, 1580.724487, 999.670593), new Vector3(0.000000, 0.000000, 29.800004), 1010, 1, player, 200, 200);
            shelter92.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(17969, 2181.126708, 1594.109863, 1000.684387, 0.000000, 0.000000, 89.700012, object_world, object_int, -1, 300.00, 300.00); 
            var shelter93 = new DynamicObject(17969, new Vector3(2181.126708, 1594.109863, 1000.684387), new Vector3(0.000000, 0.000000, 89.700012), 1010, 1, player, 200, 200);
            shelter93.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2831, 2169.829345, 1577.406372, 999.678466, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter94 = new DynamicObject(2831, new Vector3(2169.829345, 1577.406372, 999.678466), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter94.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2514, 2195.197753, 1590.429809, 998.968811, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter95 = new DynamicObject(2514, new Vector3(2195.197753, 1590.429809, 998.968811), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter95.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2689, 2181.657226, 1579.281372, 1000.842773, 0.000000, 0.000000, 114.899963, object_world, object_int, -1, 300.00, 300.00); 
            var shelter96 = new DynamicObject(2689, new Vector3(2181.657226, 1579.281372, 1000.842773), new Vector3(0.000000, 0.000000, 114.899963), 1010, 1, player, 200, 200);
            shelter96.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2619, 2215.037353, 1593.346557, 1001.432434, -8.000001, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter97 = new DynamicObject(2619, new Vector3(2215.037353, 1593.346557, 1001.432434), new Vector3(-8.000001, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter97.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2055, 2189.841308, 1590.872070, 1000.987548, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter98 = new DynamicObject(2055, new Vector3(2189.841308, 1590.872070, 1000.987548), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter98.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2866, 2171.875244, 1576.486206, 998.974670, 0.000000, 0.000000, -138.400070, object_world, object_int, -1, 300.00, 300.00); 
            var shelter99 = new DynamicObject(2866, new Vector3(2171.875244, 1576.486206, 998.974670), new Vector3(0.000000, 0.000000, -138.400070), 1010, 1, player, 200, 200);
            shelter99.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19622, 2189.822753, 1590.810180, 999.698303, -9.099998, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter100 = new DynamicObject(19622, new Vector3(2189.822753, 1590.810180, 999.698303), new Vector3(-9.099998, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter100.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1738, 2186.107177, 1593.976074, 999.578674, 0.000000, 0.000000, 365.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter101 = new DynamicObject(1738, new Vector3(2186.107177, 1593.976074, 999.578674), new Vector3(0.000000, 0.000000, 365.000000), 1010, 1, player, 200, 200);
            shelter101.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1738, 2173.732910, 1593.975830, 999.578674, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter102 = new DynamicObject(1738, new Vector3(2173.732910, 1593.975830, 999.578674), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter102.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1738, 2180.945068, 1576.124267, 999.578674, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter103 = new DynamicObject(1738, new Vector3(2180.945068, 1576.124267, 999.578674), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter103.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2514, 2195.197753, 1591.880859, 998.968811, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter104 = new DynamicObject(2514, new Vector3(2195.197753, 1591.880859, 998.968811), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter104.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2612, 2221.003906, 1598.102050, 1002.285766, 0.000000, 3.199993, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter105 = new DynamicObject(2612, new Vector3(2221.003906, 1598.102050, 1002.285766), new Vector3(0.000000, 3.199993, 0.000000), 1010, 1, player, 200, 200);
            shelter105.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2687, 2185.271728, 1590.233642, 1000.907958, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter106 = new DynamicObject(2687, new Vector3(2185.271728, 1590.233642, 1000.907958), new Vector3(0.000000, 0.000000, -90.000000), 1010, 1, player, 200, 200);
            shelter106.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(11709, 2188.778320, 1593.942871, 999.659729, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter107 = new DynamicObject(11709, new Vector3(2188.778320, 1593.942871, 999.659729), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter107.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1893, 2186.011474, 1591.334228, 1004.098937, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter108 = new DynamicObject(1893, new Vector3(2186.011474, 1591.334228, 1004.098937), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter108.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1893, 2192.074218, 1591.334228, 1003.978698, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter109 = new DynamicObject(1893, new Vector3(2192.074218, 1591.334228, 1003.978698), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter109.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2063, 2185.813964, 1592.040649, 999.878112, 0.000000, 0.000000, 89.299987, object_world, object_int, -1, 300.00, 300.00); 
            var shelter110 = new DynamicObject(2063, new Vector3(2185.813964, 1592.040649, 999.878112), new Vector3(0.000000, 0.000000, 89.299987), 1010, 1, player, 200, 200);
            shelter110.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(935, 2169.508056, 1593.783935, 999.513854, 0.000000, 0.000000, -122.400054, object_world, object_int, -1, 300.00, 300.00); 
            var shelter111 = new DynamicObject(935, new Vector3(2169.508056, 1593.783935, 999.513854), new Vector3(0.000000, 0.000000, -122.400054), 1010, 1, player, 200, 200);
            shelter111.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2047, 2186.820312, 1579.627685, 1001.204406, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter112 = new DynamicObject(2047, new Vector3(2186.820312, 1579.627685, 1001.204406), new Vector3(0.000000, 0.000000, 180.000000), 1010, 1, player, 200, 200);
            shelter112.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(935, 2169.072753, 1593.856933, 1000.671264, 0.000000, 0.000000, -63.799961, object_world, object_int, -1, 300.00, 300.00); 
            var shelter113 = new DynamicObject(935, new Vector3(2169.072753, 1593.856933, 1000.671264), new Vector3(0.000000, 0.000000, -63.799961), 1010, 1, player, 200, 200);
            shelter113.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(930, 2170.610595, 1593.809204, 999.432495, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter114 = new DynamicObject(930, new Vector3(2170.610595, 1593.809204, 999.432495), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter114.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2961, 2215.016357, 1588.674804, 1000.443847, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter115 = new DynamicObject(2961, new Vector3(2215.016357, 1588.674804, 1000.443847), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter115.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19273, 2177.696533, 1594.208251, 1000.735961, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter116 = new DynamicObject(19273, new Vector3(2177.696533, 1594.208251, 1000.735961), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter116.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(3761, 2190.695068, 1587.432983, 1000.932861, 0.000000, 0.000000, 90.100021, object_world, object_int, -1, 300.00, 300.00); 
            var shelter117 = new DynamicObject(3761, new Vector3(2190.695068, 1587.432983, 1000.932861), new Vector3(0.000000, 0.000000, 90.100021), 1010, 1, player, 200, 200);
            shelter117.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19143, 2217.499267, 1546.946655, 1007.344482, 13.499997, -0.300000, 2.699999, object_world, object_int, -1, 300.00, 300.00); 
            var shelter118 = new DynamicObject(19143, new Vector3(2217.499267, 1546.946655, 1007.344482), new Vector3(13.499997, -0.300000, 2.699999), 1010, 1, player, 200, 200);
            shelter118.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2912, 2194.671875, 1587.506103, 999.028076, 0.000000, 0.000000, 26.399999, object_world, object_int, -1, 300.00, 300.00); 
            var shelter119 = new DynamicObject(2912, new Vector3(2194.671875, 1587.506103, 999.028076), new Vector3(0.000000, 0.000000, 26.399999), 1010, 1, player, 200, 200);
            shelter119.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(921, 2185.185302, 1589.223022, 1002.365905, 0.000000, 0.000000, -90.099983, object_world, object_int, -1, 300.00, 300.00); 
            var shelter120 = new DynamicObject(921, new Vector3(2185.185302, 1589.223022, 1002.365905), new Vector3(0.000000, 0.000000, -90.099983), 1010, 1, player, 200, 200);
            shelter120.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(939, 2182.549072, 1593.035644, 1001.374328, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter121 = new DynamicObject(939, new Vector3(2182.549072, 1593.035644, 1001.374328), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter121.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1449, 2178.723632, 1594.067504, 999.424316, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter122 = new DynamicObject(1449, new Vector3(2178.723632, 1594.067504, 999.424316), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter122.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1448, 2183.914306, 1591.821533, 999.036132, 0.000000, 0.000000, 41.400001, object_world, object_int, -1, 300.00, 300.00); 
            var shelter123 = new DynamicObject(1448, new Vector3(2183.914306, 1591.821533, 999.036132), new Vector3(0.000000, 0.000000, 41.400001), 1010, 1, player, 200, 200);
            shelter123.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1421, 2184.874755, 1590.738037, 999.625793, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter124 = new DynamicObject(1421, new Vector3(2184.874755, 1590.738037, 999.625793), new Vector3(0.000000, 0.000000, 90.000000), 1010, 1, player, 200, 200);
            shelter124.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1338, 2194.876708, 1576.813110, 999.671203, 0.000000, 0.000000, -143.899948, object_world, object_int, -1, 300.00, 300.00); 
            var shelter125 = new DynamicObject(1338, new Vector3(2194.876708, 1576.813110, 999.671203), new Vector3(0.000000, 0.000000, -143.899948), 1010, 1, player, 200, 200);
            shelter125.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2900, 2186.800292, 1587.668457, 998.953857, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter126 = new DynamicObject(2900, new Vector3(2186.800292, 1587.668457, 998.953857), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter126.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2478, 2191.562988, 1587.320922, 1000.826416, 0.000000, 0.000000, 15.699998, object_world, object_int, -1, 300.00, 300.00); 
            var shelter127 = new DynamicObject(2478, new Vector3(2191.562988, 1587.320922, 1000.826416), new Vector3(0.000000, 0.000000, 15.699998), 1010, 1, player, 200, 200);
            shelter127.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2842, 2180.611083, 1577.751464, 998.951965, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter128 = new DynamicObject(2842, new Vector3(2180.611083, 1577.751464, 998.951965), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter128.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(935, 2223.695556, 1553.049438, 1005.719543, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter129 = new DynamicObject(935, new Vector3(2223.695556, 1553.049438, 1005.719543), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter129.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(3785, 2220.143310, 1547.760253, 1006.507934, 0.000000, 0.000000, 124.800109, object_world, object_int, -1, 300.00, 300.00); 
            var shelter130 = new DynamicObject(3785, new Vector3(2220.143310, 1547.760253, 1006.507934), new Vector3(0.000000, 0.000000, 124.800109), 1010, 1, player, 200, 200);
            shelter130.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(3785, 2222.977539, 1549.979858, 1006.507934, 0.000000, 0.000000, 123.399902, object_world, object_int, -1, 300.00, 300.00); 
            var shelter131 = new DynamicObject(3785, new Vector3(2222.977539, 1549.979858, 1006.507934), new Vector3(0.000000, 0.000000, 123.399902), 1010, 1, player, 200, 200);
            shelter131.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19143, 2204.220458, 1556.209228, 1011.238525, -8.699996, 0.000000, -117.500015, object_world, object_int, -1, 300.00, 300.00); 
            var shelter132 = new DynamicObject(19143, new Vector3(2204.220458, 1556.209228, 1011.238525), new Vector3(-8.699996, 0.000000, -117.500015), 1010, 1, player, 200, 200);
            shelter132.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2057, 2228.000000, 1597.156982, 999.339782, 0.000000, 0.000000, -70.900024, object_world, object_int, -1, 300.00, 300.00); 
            var shelter133 = new DynamicObject(2057, new Vector3(2228.000000, 1597.156982, 999.339782), new Vector3(0.000000, 0.000000, -70.900024), 1010, 1, player, 200, 200);
            shelter133.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19559, 2220.133300, 1598.000610, 1000.924987, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter134 = new DynamicObject(19559, new Vector3(2220.133300, 1598.000610, 1000.924987), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter134.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1466, 2216.464599, 1571.361938, 1000.093017, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter135 = new DynamicObject(1466, new Vector3(2216.464599, 1571.361938, 1000.093017), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter135.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1466, 2216.464599, 1571.361938, 1002.433471, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter136 = new DynamicObject(1466, new Vector3(2216.464599, 1571.361938, 1002.433471), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter136.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1436, 2224.342529, 1571.351928, 1000.454772, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter137 = new DynamicObject(1436, new Vector3(2224.342529, 1571.351928, 1000.454772), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter137.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(935, 2215.713134, 1572.899291, 999.510498, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter138 = new DynamicObject(935, new Vector3(2215.713134, 1572.899291, 999.510498), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter138.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(935, 2215.542724, 1573.909179, 999.510498, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter139 = new DynamicObject(935, new Vector3(2215.542724, 1573.909179, 999.510498), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter139.ShowInWorld(1010);

            //tmpobjid = CreateDynamicObject(1566, 2175.637451, 1594.254272, 1000.356140, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter140 = new DynamicObject(1566, new Vector3(2175.637451, 1594.254272, 1000.356140), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter140.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2055, 2224.895263, 1590.683837, 1000.987548, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter141 = new DynamicObject(2055, new Vector3(2224.895263, 1590.683837, 1000.987548), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter141.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(2066, 2221.452392, 1597.686889, 998.890563, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter142 = new DynamicObject(2066, new Vector3(2221.452392, 1597.686889, 998.890563), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter142.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(1235, 2222.360351, 1597.780761, 999.442138, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shelter143 = new DynamicObject(1235, new Vector3(2222.360351, 1597.780761, 999.442138), new Vector3(0.000000, 0.000000, 0.000000), 1010, 1, player, 200, 200);
            shelter143.ShowInWorld(1010);
            //tmpobjid = CreateDynamicObject(19378, 1338.942871, 1522.088134, 2999.158691, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            
            //tmpobjid = CreateDynamicObject(19378, 1349.442871, 1522.088134, 2999.158691, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            //tmpobjid = CreateDynamicObject(14416, 1342.198608, 1515.430541, 2996.050292, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 12855, "cunte_cop", "sw_brick05", 0xFFFFFFFF);
            //SetDynamicObjectMaterial(tmpobjid, 1, 3967, "cj_airprt", "bigbrick", 0x00000000);
            // tmpobjid = CreateDynamicObject(19378, 1344.142089, 1510.431152, 2997.706298, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 16639, "a51_labs", "dam_terazzo", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(19378, 1349.442871, 1531.710815, 2999.158691, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(19378, 1338.942871, 1531.710815, 2999.158691, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(14416, 1346.188598, 1515.430541, 2996.050292, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 12855, "cunte_cop", "sw_brick05", 0xFFFFFFFF);
            // SetDynamicObjectMaterial(tmpobjid, 1, 3967, "cj_airprt", "bigbrick", 0x00000000);
            // tmpobjid = CreateDynamicObject(19378, 1348.190551, 1512.471435, 3001.640136, 0.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1340.188476, 1512.471435, 3001.640136, 0.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1344.069702, 1507.851562, 3001.640136, 0.000000, 180.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(2957, 1344.071899, 1507.892700, 2999.315185, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 8391, "ballys01", "vgncorpdoor1_512", 0xFFFFFFFF);
            //  tmpobjid = CreateDynamicObject(19378, 1344.142089, 1512.502807, 3004.316894, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            //tmpobjid = CreateDynamicObject(19378, 1333.642089, 1531.768920, 3004.316894, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(19378, 1344.142089, 1522.135864, 3004.316894, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(19378, 1354.642089, 1522.135864, 3004.316894, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(19378, 1333.642089, 1522.135864, 3004.316894, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            //  SetDynamicObjectMaterial(tmpobjid, 0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            //  tmpobjid = CreateDynamicObject(19378, 1344.142089, 1531.768920, 3004.316894, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            //  SetDynamicObjectMaterial(tmpobjid, 0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            //  tmpobjid = CreateDynamicObject(19378, 1354.642089, 1531.768920, 3004.316894, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            //  SetDynamicObjectMaterial(tmpobjid, 0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            //  tmpobjid = CreateDynamicObject(19378, 1336.823364, 1520.626708, 3001.640136, 0.000000, 180.000000, 45.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1351.564331, 1520.623291, 3001.640136, 0.000000, 180.000000, -45.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            //  SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1354.685424, 1528.579101, 3001.640136, 0.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            //  SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1333.654663, 1528.579101, 3001.640136, 0.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1349.802368, 1533.304077, 3001.640136, 0.000000, 180.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1340.179077, 1533.304077, 3001.640136, 0.000000, 180.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(19378, 1330.547241, 1533.304077, 3001.640136, 0.000000, 180.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); // âõîä ïëèòà
            // SetDynamicObjectMaterial(tmpobjid, 0, 10765, "airportgnd_sfse", "white", 0xFFD1E0E0);
            // tmpobjid = CreateDynamicObject(2928, 1338.932128, 1533.447509, 3000.465820, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 14577, "casinovault01", "dts_elevator_door", 0xFFFFFFFF);
            //  tmpobjid = CreateDynamicObject(2928, 1349.456176, 1533.447509, 3000.465820, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 14577, "casinovault01", "dts_elevator_door", 0xFFFFFFFF);
            //  tmpobjid = CreateDynamicObject(19439, 1344.182861, 1533.289672, 3002.317626, 103.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 3119, "cs_ry_props", "lightgrey", 0x00000000);
            //  tmpobjid = CreateDynamicObject(19483, 1344.258300, 1533.188110, 3002.254394, -13.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterialText(tmpobjid, 0, "Las Venturas\n Medical Center", 120, "Courier New", 60, 0, 0xFFCC0000, 0x00000000, 0);
            // tmpobjid = CreateDynamicObject(19929, 1344.181518, 1530.146606, 2999.244628, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-60-percent", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 18646, "matcolours", "grey-80-percent", 0x00000000);
            // tmpobjid = CreateDynamicObject(19925, 1342.323730, 1530.149780, 2999.244628, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-60-percent", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 18646, "matcolours", "grey-80-percent", 0x00000000);
            // tmpobjid = CreateDynamicObject(19929, 1342.322631, 1532.008422, 2999.244628, 0.000000, 0.000000, 360.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-60-percent", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 18646, "matcolours", "grey-80-percent", 0x00000000);
            // tmpobjid = CreateDynamicObject(1742, 1344.719360, 1533.281860, 2999.214599, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 1977, "cooler1", "shelf_stuff1", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 1977, "cooler1", "shelf_stuff1", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 2, 3629, "arprtxxref_las", "dirtywhite", 0x00000000);
            // tmpobjid = CreateDynamicObject(1997, 1339.258300, 1519.140014, 2999.234619, 0.000000, 0.000000, 45.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(1997, 1337.930541, 1521.667114, 2999.685058, 0.000000, 90.000000, 7.200090, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(2897, 1352.921508, 1530.726440, 2999.505859, 0.000000, 0.000000, -69.500022, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 3629, "arprtxxref_las", "dirtywhite", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(2907, 1343.223266, 1532.718383, 3000.053710, -76.799812, 49.299926, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(2906, 1343.013305, 1532.461425, 3000.097656, -35.900054, 0.000000, -176.600357, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(19836, 1351.396850, 1531.331542, 2999.254638, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(1620, 1351.334228, 1520.538574, 3003.418701, 0.000000, 0.000000, -45.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(1620, 1337.107177, 1520.481201, 3003.418701, 0.000000, 0.000000, 225.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(3089, 1354.579345, 1524.915283, 3000.485839, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 11631, "mp_ranchcut", "mpCJ_Black_metal", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            //  SetDynamicObjectMaterial(tmpobjid, 2, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 3, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            // tmpobjid = CreateDynamicObject(19433, 1356.296752, 1525.660156, 3001.827148, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            // tmpobjid = CreateDynamicObject(19433, 1355.345703, 1526.470947, 3000.165527, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            // tmpobjid = CreateDynamicObject(19433, 1355.345703, 1524.939453, 3000.165527, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            // tmpobjid = CreateDynamicObject(3089, 1333.747192, 1524.915283, 3000.485839, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 11631, "mp_ranchcut", "mpCJ_Black_metal", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 2, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 3, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            //tmpobjid = CreateDynamicObject(19433, 1333.005981, 1526.470947, 3000.165527, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            //tmpobjid = CreateDynamicObject(19433, 1332.058105, 1525.660156, 3001.827148, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            //tmpobjid = CreateDynamicObject(19433, 1333.005981, 1524.939453, 3000.165527, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            // tmpobjid = CreateDynamicObject(1776, 1346.802856, 1511.879516, 2998.185302, 90.000000, -13.099831, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(1997, 1334.600219, 1531.692871, 2999.234619, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(1997, 1334.600219, 1528.419677, 2999.234619, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // tmpobjid = CreateDynamicObject(932, 1345.327026, 1524.247070, 2999.215576, 0.000000, 0.000000, -41.800003, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 2994, "trolex", "trolley03", 0x00000000);
            // tmpobjid = CreateDynamicObject(2894, 1343.106689, 1530.108398, 3000.175537, 0.000000, 0.000000, -19.100013, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);

            var hospitallv1 = new DynamicObject(19378, new Vector3(1338.942871, 1522.088134, 2999.158691), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv1.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            hospitallv1.ShowInWorld(1011);

            var hospitallv2 = new DynamicObject(19378, new Vector3(1349.442871, 1522.088134, 2999.158691), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv2.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            hospitallv2.ShowInWorld(1011);

            var hospitallv3 = new DynamicObject(14416, new Vector3(1342.198608, 1515.430541, 2996.050292), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv3.SetMaterial(0, 12855, "cunte_cop", "sw_brick05", 0xFFFFFFFF);
            hospitallv3.SetMaterial(1, 3967, "cj_airprt", "bigbrick", 0x00000000);
            hospitallv3.ShowInWorld(1011);

            var hospitallv4 = new DynamicObject(19378, new Vector3(1344.142089, 1510.431152, 2997.706298), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv4.SetMaterial(0, 16639, "a51_labs", "dam_terazzo", 0xFFFFFFFF);
            hospitallv4.ShowInWorld(1011);

            var hospitallv5 = new DynamicObject(19378, new Vector3(1349.442871, 1531.710815, 2999.158691), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv5.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            hospitallv5.ShowInWorld(1011);

            var hospitallv6 = new DynamicObject(19378, new Vector3(1338.942871, 1531.710815, 2999.158691), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv6.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0xFFFFFFFF);
            hospitallv6.ShowInWorld(1011);

            var hospitallv7 = new DynamicObject(14416, new Vector3(1346.188598, 1515.430541, 2996.050292), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv7.SetMaterial(0, 12855, "cunte_cop", "sw_brick05", 0xFFFFFFFF);
            hospitallv7.SetMaterial(1, 3967, "cj_airprt", "bigbrick", 0x00000000);
            hospitallv7.ShowInWorld(1011);

            var hospitallv8 = new DynamicObject(19378, new Vector3(1348.190551, 1512.471435, 3001.640136), new Vector3(0.000000, 180.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv8.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv8.ShowInWorld(1011);

            var hospitallv9 = new DynamicObject(19378, new Vector3(1340.188476, 1512.471435, 3001.640136), new Vector3(0.000000, 180.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv9.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv9.ShowInWorld(1011);

            var hospitallv10 = new DynamicObject(19378, new Vector3(1344.069702, 1507.851562, 3001.640136), new Vector3(0.000000, 180.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv10.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv10.ShowInWorld(1011);

            var hospitallv11 = new DynamicObject(2957, new Vector3(1344.071899, 1507.892700, 2999.315185), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv11.SetMaterial(0, 8391, "ballys01", "vgncorpdoor1_512", 0xFFFFFFFF);
            hospitallv11.ShowInWorld(1011);

            var hospitallv12 = new DynamicObject(19378, new Vector3(1344.142089, 1512.502807, 3004.316894), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv12.SetMaterial(0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            hospitallv12.ShowInWorld(1011);

            var hospitallv13 = new DynamicObject(19378, new Vector3(1333.642089, 1531.768920, 3004.316894), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv13.SetMaterial(0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            hospitallv13.ShowInWorld(1011);

            var hospitallv14 = new DynamicObject(19378, new Vector3(1344.142089, 1522.135864, 3004.316894), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv14.SetMaterial(0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            hospitallv14.ShowInWorld(1011);

            var hospitallv15 = new DynamicObject(19378, new Vector3(1354.642089, 1522.135864, 3004.316894), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv15.SetMaterial(0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            hospitallv15.ShowInWorld(1011);

            var hospitallv16 = new DynamicObject(19378, new Vector3(1333.642089, 1522.135864, 3004.316894), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv16.SetMaterial(0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            hospitallv16.ShowInWorld(1011);

            var hospitallv17 = new DynamicObject(19378, new Vector3(1344.142089, 1531.768920, 3004.316894), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv17.SetMaterial(0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            hospitallv17.ShowInWorld(1011);

            var hospitallv18 = new DynamicObject(19378, new Vector3(1354.642089, 1531.768920, 3004.316894), new Vector3(0.000000, 90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv18.SetMaterial(0, 10023, "bigwhitesfe", "sfe_arch10", 0xFFFFFFFF);
            hospitallv18.ShowInWorld(1011);

            var hospitallv19 = new DynamicObject(19378, new Vector3(1336.823364, 1520.626708, 3001.640136), new Vector3(0.000000, 180.000000, 45.000000), 1011, 1, player, 50, 50);
            hospitallv19.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv19.ShowInWorld(1011);

            var hospitallv20 = new DynamicObject(19378, new Vector3(1351.564331, 1520.623291, 3001.640136), new Vector3(0.000000, 180.000000, -45.000000), 1011, 1, player, 50, 50);
            hospitallv20.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv20.ShowInWorld(1011);

            var hospitallv21 = new DynamicObject(19378, new Vector3(1354.685424, 1528.579101, 3001.640136), new Vector3(0.000000, 180.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv21.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv21.ShowInWorld(1011);

            var hospitallv22 = new DynamicObject(19378, new Vector3(1333.654663, 1528.579101, 3001.640136), new Vector3(0.000000, 180.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv22.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv22.ShowInWorld(1011);

            var hospitallv23 = new DynamicObject(19378, new Vector3(1349.802368, 1533.304077, 3001.640136), new Vector3(0.000000, 180.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv23.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv23.ShowInWorld(1011);

            var hospitallv24 = new DynamicObject(19378, new Vector3(1340.179077, 1533.304077, 3001.640136), new Vector3(0.000000, 180.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv24.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv24.ShowInWorld(1011);

            var hospitallv25 = new DynamicObject(19378, new Vector3(1330.547241, 1533.304077, 3001.640136), new Vector3(0.000000, 180.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv25.SetMaterial(0, 10765, "airportgnd_sfse", "white", 0xFFFFFFFF);
            hospitallv25.ShowInWorld(1011);

            var hospitallv26 = new DynamicObject(2928, new Vector3(1338.932128, 1533.447509, 3000.465820), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv26.SetMaterial(0, 14577, "casinovault01", "dts_elevator_door", 0xFFFFFFFF);
            hospitallv26.ShowInWorld(1011);

            var hospitallv27 = new DynamicObject(2928, new Vector3(1349.456176, 1533.447509, 3000.465820), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv27.SetMaterial(0, 14577, "casinovault01", "dts_elevator_door", 0xFFFFFFFF);
            hospitallv27.ShowInWorld(1011);
            /**
            var hospitallv28 = new DynamicObject(19439, new Vector3(1344.182861, 1533.289672, 3002.317626), new Vector3(103.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv28.SetMaterial(0, 3119, "cs_ry_props", "lightgrey", 0x00000000);
            hospitallv28.ShowInWorld(1011);

            var hospitallv29 = new DynamicObject(19483, new Vector3(1344.258300, 1533.188110, 3002.254394), new Vector3(-13.000000, 0.000000, -90.000000), 1011, 1, player, 50, 50);
            hospitallv29.SetMaterialText(0, "Las Venturas\n Medical Center", ObjectMaterialSize.X512X128, "Courier New", 60, false, 0xFFCC0000, 0x00000000, ObjectMaterialTextAlign.Left);
            hospitallv29.ShowInWorld(1011);
            **/

            var hospitallv30 = new DynamicObject(19929, new Vector3(1344.181518, 1530.146606, 2999.244628), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv30.SetMaterial(0, 18646, "matcolours", "grey-60-percent", 0x00000000);
            hospitallv30.SetMaterial(1, 18646, "matcolours", "grey-80-percent", 0x00000000);
            hospitallv30.ShowInWorld(1011);

            var hospitallv31 = new DynamicObject(19925, new Vector3(1342.323730, 1530.149780, 2999.244628), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv31.SetMaterial(0, 18646, "matcolours", "grey-60-percent", 0x00000000);
            hospitallv31.SetMaterial(1, 18646, "matcolours", "grey-80-percent", 0x00000000);
            hospitallv31.ShowInWorld(1011);

            var hospitallv32 = new DynamicObject(19929, new Vector3(1342.322631, 1532.008422, 2999.244628), new Vector3(0.000000, 0.000000, 360.000000), 1011, 1, player, 50, 50);
            hospitallv32.SetMaterial(0, 18646, "matcolours", "grey-60-percent", 0x00000000);
            hospitallv32.SetMaterial(1, 18646, "matcolours", "grey-80-percent", 0x00000000);
            hospitallv32.ShowInWorld(1011);

            var hospitallv33 = new DynamicObject(1742, new Vector3(1344.719360, 1533.281860, 2999.214599), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv33.SetMaterial(0, 1977, "cooler1", "shelf_stuff1", 0x00000000);
            hospitallv33.SetMaterial(1, 1977, "cooler1", "shelf_stuff1", 0x00000000);
            hospitallv33.SetMaterial(2, 3629, "arprtxxref_las", "dirtywhite", 0x00000000);
            hospitallv33.ShowInWorld(1011);

            var hospitallv34 = new DynamicObject(1997, new Vector3(1339.258300, 1519.140014, 2999.234619), new Vector3(0.000000, 0.000000, 45.000000), 1011, 1, player, 50, 50);
            hospitallv34.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv34.ShowInWorld(1011);

            var hospitallv35 = new DynamicObject(1997, new Vector3(1337.930541, 1521.667114, 2999.685058), new Vector3(0.000000, 90.000000, 7.200090), 1011, 1, player, 50, 50);
            hospitallv35.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv35.ShowInWorld(1011);

            var hospitallv36 = new DynamicObject(2897, new Vector3(1352.921508, 1530.726440, 2999.505859), new Vector3(0.000000, 0.000000, -69.500022), 1011, 1, player, 50, 50);
            hospitallv36.SetMaterial(0, 3629, "arprtxxref_las", "dirtywhite", 0xFFFFFFFF);
            hospitallv36.ShowInWorld(1011);

            var hospitallv37 = new DynamicObject(2907, new Vector3(1343.223266, 1532.718383, 3000.053710), new Vector3(-76.799812, 49.299926, -90.000000), 1011, 1, player, 50, 50);
            hospitallv37.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv37.ShowInWorld(1011);

            var hospitallv38 = new DynamicObject(2906, new Vector3(1343.013305, 1532.461425, 3000.097656), new Vector3(-35.900054, 0.000000, -176.600357), 1011, 1, player, 50, 50);
            hospitallv38.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv38.ShowInWorld(1011);

            var hospitallv39 = new DynamicObject(19836, new Vector3(1351.396850, 1531.331542, 2999.254638), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv39.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv39.ShowInWorld(1011);

            var hospitallv40 = new DynamicObject(1620, new Vector3(1351.334228, 1520.538574, 3003.418701), new Vector3(0.000000, 0.000000, -45.000000), 1011, 1, player, 50, 50);
            hospitallv40.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv40.ShowInWorld(1011);

            var hospitallv41 = new DynamicObject(1620, new Vector3(1337.107177, 1520.481201, 3003.418701), new Vector3(0.000000, 0.000000, 225.000000), 1011, 1, player, 50, 50);
            hospitallv41.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv41.ShowInWorld(1011);

            var hospitallv42 = new DynamicObject(3089, new Vector3(1354.579345, 1524.915283, 3000.485839), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv42.SetMaterial(0, 11631, "mp_ranchcut", "mpCJ_Black_metal", 0x00000000);
            hospitallv42.SetMaterial(1, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            hospitallv42.SetMaterial(2, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            hospitallv42.SetMaterial(3, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            hospitallv42.ShowInWorld(1011);

            var hospitallv43 = new DynamicObject(19433, new Vector3(1356.296752, 1525.660156, 3001.827148), new Vector3(0.000000, -90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv43.SetMaterial(0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            hospitallv43.ShowInWorld(1011);

            var hospitallv44 = new DynamicObject(19433, new Vector3(1355.345703, 1526.470947, 3000.165527), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv44.SetMaterial(0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            hospitallv44.ShowInWorld(1011);

            var hospitallv45 = new DynamicObject(19433, new Vector3(1355.345703, 1524.939453, 3000.165527), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv45.SetMaterial(0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            hospitallv45.ShowInWorld(1011);

            var hospitallv46 = new DynamicObject(3089, new Vector3(1333.747192, 1524.915283, 3000.485839), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv46.SetMaterial(0, 11631, "mp_ranchcut", "mpCJ_Black_metal", 0x00000000);
            hospitallv46.SetMaterial(1, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            hospitallv46.SetMaterial(2, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            hospitallv46.SetMaterial(3, 6284, "bev_law2", "pierwall03_law", 0x00000000);
            hospitallv46.ShowInWorld(1011);

            var hospitallv47 = new DynamicObject(19433, new Vector3(1333.005981, 1526.470947, 3000.165527), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv47.SetMaterial(0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            hospitallv47.ShowInWorld(1011);

            var hospitallv48 = new DynamicObject(19433, new Vector3(1332.058105, 1525.660156, 3001.827148), new Vector3(0.000000, -90.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv48.SetMaterial(0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            hospitallv48.ShowInWorld(1011);

            var hospitallv49 = new DynamicObject(19433, new Vector3(1333.005981, 1524.939453, 3000.165527), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv49.SetMaterial(0, 18646, "matcolours", "grey-70-percent", 0x00000000);
            hospitallv49.ShowInWorld(1011);

            var hospitallv50 = new DynamicObject(1776, new Vector3(1346.802856, 1511.879516, 2998.185302), new Vector3(90.000000, -13.099831, 270.000000), 1011, 1, player, 50, 50);
            hospitallv50.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv50.ShowInWorld(1011);

            var hospitallv51 = new DynamicObject(1997, new Vector3(1334.600219, 1531.692871, 2999.234619), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv51.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv51.ShowInWorld(1011);

            var hospitallv52 = new DynamicObject(1997, new Vector3(1334.600219, 1528.419677, 2999.234619), new Vector3(0.000000, 0.000000, 180.000000), 1011, 1, player, 50, 50);
            hospitallv52.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv52.ShowInWorld(1011);

            var hospitallv53 = new DynamicObject(932, new Vector3(1345.327026, 1524.247070, 2999.215576), new Vector3(0.000000, 0.000000, -41.800003), 1011, 1, player, 50, 50);
            hospitallv53.SetMaterial(0, 2994, "trolex", "trolley03", 0x00000000);
            hospitallv53.ShowInWorld(1011);

            var hospitallv54 = new DynamicObject(2894, new Vector3(1343.106689, 1530.108398, 3000.175537), new Vector3(0.000000, 0.000000, -19.100013), 1011, 1, player, 50, 50);
            hospitallv54.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);
            hospitallv54.ShowInWorld(1011);

            var hospitallv55 = new DynamicObject(19999, new Vector3(1343.345336, 1532.573242, 2999.244628), new Vector3(0.000000, 0.000000, 44.199821), 1011, 1, player, 50, 50);
            hospitallv55.ShowInWorld(1011);

            var hospitallv56 = new DynamicObject(19944, new Vector3(1351.189819, 1528.908325, 2999.255615), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv56.ShowInWorld(1011);

            var hospitallv57 = new DynamicObject(19944, new Vector3(1352.132690, 1528.653320, 2999.255615), new Vector3(0.000000, 0.000000, -2.000000), 1011, 1, player, 50, 50);
            hospitallv57.ShowInWorld(1011);

            var hospitallv58 = new DynamicObject(2674, new Vector3(1348.533569, 1526.225952, 2999.264648), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv58.ShowInWorld(1011);

            var hospitallv59 = new DynamicObject(2674, new Vector3(1343.571777, 1521.071899, 2999.264648), new Vector3(0.000000, 0.000000, -92.899986), 1011, 1, player, 50, 50);
            hospitallv59.ShowInWorld(1011);

            var hospitallv60 = new DynamicObject(2676, new Vector3(1346.586669, 1531.709960, 2999.375732), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv60.ShowInWorld(1011);

            var hospitallv61 = new DynamicObject(2673, new Vector3(1339.261352, 1525.867797, 2999.334716), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv61.ShowInWorld(1011);

            var hospitallv62 = new DynamicObject(2673, new Vector3(1345.951904, 1523.945922, 2999.334716), new Vector3(0.000000, 0.000000, -51.500007), 1011, 1, player, 50, 50);
            hospitallv62.ShowInWorld(1011);

            var hospitallv63 = new DynamicObject(2676, new Vector3(1343.215576, 1511.950561, 2997.904296), new Vector3(0.000000, 0.000000, -9.300002), 1011, 1, player, 50, 50);
            hospitallv63.ShowInWorld(1011);

            var hospitallv64 = new DynamicObject(14439, new Vector3(1344.593750, 1526.968383, 3006.182373), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv64.ShowInWorld(1011);

            var hospitallv65 = new DynamicObject(1209, new Vector3(1347.828857, 1513.041503, 2997.792236), new Vector3(0.000000, 0.000000, -90.000000), 1011, 1, player, 50, 50);
            hospitallv65.ShowInWorld(1011);

            var hospitallv66 = new DynamicObject(11711, new Vector3(1344.088867, 1507.922729, 3001.445800), new Vector3(0.000000, 0.000000, 0.000000), 1011, 1, player, 50, 50);
            hospitallv66.ShowInWorld(1011);

            var hospitallv67 = new DynamicObject(2687, new Vector3(1340.315673, 1512.416503, 2999.453857), new Vector3(0.000000, 0.000000, 90.000000), 1011, 1, player, 50, 50);
            hospitallv67.ShowInWorld(1011);

            var hospitallv68 = new DynamicObject(1723, new Vector3(1340.857177, 1510.566650, 2997.792236), new Vector3(0.000000, 0.000000, 82.900100), 1011, 1, player, 50, 50);
            hospitallv68.ShowInWorld(1011);

            var hospitallv69 = new DynamicObject(19807, new Vector3(1342.547729, 1530.374877, 3000.235595), new Vector3(0.000000, 0.000000, 160.800018), 1011, 1, player, 50, 50);
            hospitallv69.ShowInWorld(1011);

            var hospitallv70 = new DynamicObject(2824, new Vector3(1344.063354, 1530.139038, 3000.175537), new Vector3(0.000000, 0.000000, -179.600173), 1011, 1, player, 50, 50);
            hospitallv70.ShowInWorld(1011);

            var hospitallv71 = new DynamicObject(1886, new Vector3(1334.455932, 1532.644287, 3004.411132), new Vector3(12.100009, 0.000000, 49.299991), 1011, 1, player, 50, 50);
            hospitallv71.ShowInWorld(1011);

            var hospitallv72 = new DynamicObject(960, new Vector3(1340.630981, 1528.466308, 2999.594970), new Vector3(0.000000, 0.000000, 29.900001), 1011, 1, player, 50, 50);
            hospitallv72.ShowInWorld(1011);

            var hospitallv73 = new DynamicObject(1448, new Vector3(1341.000366, 1518.196044, 2999.315673), new Vector3(0.000000, 0.000000, 59.099998), 1011, 1, player, 50, 50);
            hospitallv73.ShowInWorld(1011);

            var hospitallv74 = new DynamicObject(928, new Vector3(1339.883056, 1523.561279, 2999.514892), new Vector3(0.000000, 0.000000, 17.400001), 1011, 1, player, 50, 50);
            hospitallv74.ShowInWorld(1011);

            var hospitallv75 = new DynamicObject(16377, new Vector3(1341.751586, 1525.005615, 2999.568359), new Vector3(92.199951, 0.000000, -23.500055), 1011, 1, player, 50, 50);
            hospitallv75.ShowInWorld(1011);

            var hospitallv76 = new DynamicObject(2066, new Vector3(1350.370849, 1520.135253, 2999.736083), new Vector3(-90.000000, 0.000000, 114.300041), 1011, 1, player, 50, 50);
            hospitallv76.ShowInWorld(1011);

            var hospitallv77 = new DynamicObject(2713, new Vector3(1347.676147, 1508.243286, 2997.912353), new Vector3(0.000000, 0.000000, 34.400047), 1011, 1, player, 50, 50);
            hospitallv77.ShowInWorld(1011);

            
            var bridgeb1 = new DynamicObject(3939, new Vector3(-964.803833, 2731.843994, 46.717041), new Vector3(0.000000, 0.000000, -41.699883), 0, 0, player, 200, 150);
            bridgeb1.SetMaterial(2, 3085, "blkbrdx", "tatty_wood_1", 0);
            bridgeb1.SetMaterial(1, 3085, "blkbrdx", "tatty_wood_1", 0);
            bridgeb1.SetMaterial(0, 3085, "blkbrdx", "tatty_wood_1", 0);
            bridgeb1.ShowInWorld(0);
            
            var bridgeb2 = new DynamicObject(19632, new Vector3(-964.098816, 2731.417725, 45.045353), new Vector3(0.000000, 0.000000, 20.299988), 0, 0, player, 200, 150);
            bridgeb2.ShowInWorld(0);
            
            var bridgeb3 = new DynamicObject(1771, new Vector3(-966.463135, 2731.565674, 44.945370), new Vector3(0.000000, 0.000000, -26.199984), 0, 0, player, 200, 150);
            bridgeb3.SetMaterial(1, 8487, "ballyswater", "waterclear256", 0);
            bridgeb3.SetMaterial(0, 3945, "alpha_fence", "bistro_alpha", 0);
            bridgeb3.ShowInWorld(0);
            
            var bridgeb4 = new DynamicObject(918, new Vector3(-964.519836, 2729.649414, 45.347031), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb4.ShowInWorld(0);
            
            var bridgeb5 = new DynamicObject(1431, new Vector3(-965.145081, 2729.263428, 45.521832), new Vector3(0.000000, 0.000000, -47.400005), 0, 0, player, 200, 150);
            bridgeb5.ShowInWorld(0);
            
            var bridgeb6 = new DynamicObject(1271, new Vector3(-962.385071, 2732.186279, 45.400116), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb6.ShowInWorld(0);

            var bridgeb7 = new DynamicObject(1771, new Vector3(-964.756226, 2733.989258, 44.965366), new Vector3(0.000000, 0.000000, -59.199993), 0, 0, player, 200, 150);
            bridgeb7.SetMaterial(1, 8487, "ballyswater", "waterclear256", 0);
            bridgeb7.SetMaterial(0, 3945, "alpha_fence", "bistro_alpha", 0);
            bridgeb7.ShowInWorld(0);
            
            var bridgeb8 = new DynamicObject(930, new Vector3(-961.889404, 2731.383789, 45.544048), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb8.ShowInWorld(0);

            var bridgeb9 = new DynamicObject(2036, new Vector3(-964.432373, 2728.512451, 45.534290), new Vector3(0.000000, -57.799969, 145.299988), 0, 0, player, 200, 150);
            bridgeb9.ShowInWorld(0);
            var bridgeb10 = new DynamicObject(19572, new Vector3(-961.679688, 2732.239014, 45.026691), new Vector3(0.000000, 0.000000, -21.499998), 0, 0, player, 200, 150);
            bridgeb10.ShowInWorld(0);
            var bridgeb11 = new DynamicObject(3005, new Vector3(-963.025085, 2727.239258, 45.045090), new Vector3(2.099998, 0.000000, -4.400011), 0, 0, player, 200, 150);
            bridgeb11.ShowInWorld(0);
            
            var bridgeb12 = new DynamicObject(1238, new Vector3(-963.139221, 2725.521240, 45.315624), new Vector3(0.000000, 0.000000, 332.692017), 0, 0, player, 200, 150);
            bridgeb12.ShowInWorld(0);
            var bridgeb13 = new DynamicObject(967, new Vector3(-961.511597, 2725.198730, 45.697021), new Vector3(90.000000, -39.399998, 30.000000), 0, 0, player, 200, 150);
            bridgeb13.ShowInWorld(0);
            var bridgeb14 = new DynamicObject(820, new Vector3(-971.789917, 2730.077881, 44.923569), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb14.ShowInWorld(0);
            
            var bridgeb15 = new DynamicObject(3015, new Vector3(-961.035583, 2725.368408, 45.046391), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb15.ShowInWorld(0);
            var bridgeb16 = new DynamicObject(11441, new Vector3(-960.525574, 2738.391113, 45.197006), new Vector3(0.000000, 0.000000, -146.000015), 0, 0, player, 200, 150);
            bridgeb16.ShowInWorld(0);
            var bridgeb17 = new DynamicObject(2599, new Vector3(-954.915283, 2731.691406, 45.550587), new Vector3(0.000000, 0.000000, 28.999994), 0, 0, player, 200, 150);
            bridgeb17.ShowInWorld(0);
            var bridgeb18 = new DynamicObject(2866, new Vector3(-953.144592, 2733.833984, 45.926510), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb18.ShowInWorld(0);
            
            var bridgeb19 = new DynamicObject(2856, new Vector3(-953.025269, 2733.206543, 45.918812), new Vector3(0.000000, 0.000000, 78.800003), 0, 0, player, 200, 150);
            bridgeb19.ShowInWorld(0);
            //CreateDynamicObject(2663, -953.117493, 2734.426514, 46.154842, 0.000000, 0.000000, -132.600006, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb20 = new DynamicObject(2663, new Vector3(-953.117493, 2734.426514, 46.154842), new Vector3(0.000000, 0.000000, -132.600006), 0, 0, player, 200, 150);
            bridgeb20.ShowInWorld(0);
            //CreateDynamicObject(2663, -953.190857, 2735.462891, 46.154842, 0.000000, 0.000000, -59.400009, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb21 = new DynamicObject(2663, new Vector3(-953.190857, 2735.462891, 46.154842), new Vector3(0.000000, 0.000000, -59.400009), 0, 0, player, 200, 150);
            bridgeb21.ShowInWorld(0);
            //CreateDynamicObject(19922, -952.949036, 2734.368896, 45.133797, 0.000000, 0.000000, -82.799988, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb22 = new DynamicObject(19922, new Vector3(-952.949036, 2734.368896, 45.133797), new Vector3(0.000000, 0.000000, -82.799988), 0, 0, player, 200, 150);
            bridgeb22.ShowInWorld(0);
            //CreateDynamicObject(1520, -952.608032, 2733.360840, 45.975117, 0.000000, 0.000000, -30.700005, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb23 = new DynamicObject(1520, new Vector3(-952.608032, 2733.360840, 45.975117), new Vector3(0.000000, 0.000000, -30.700005), 0, 0, player, 200, 150);
            bridgeb23.ShowInWorld(0);
            //CreateDynamicObject(1459, -965.035583, 2719.443848, 45.467186, 0.000000, 0.000000, 94.675293, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb24 = new DynamicObject(1459, new Vector3(-965.035583, 2719.443848, 45.467186), new Vector3(0.000000, 0.000000, 94.675293), 0, 0, player, 200, 150);
            bridgeb24.ShowInWorld(0);
            //CreateDynamicObject(1520, -952.446716, 2733.277100, 45.972847, 2.600000, 93.899986, -132.699966, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb25 = new DynamicObject(1520, new Vector3(-952.446716, 2733.277100, 45.972847), new Vector3(2.600000, 93.899986, -132.699966), 0, 0, player, 200, 150);
            bridgeb25.ShowInWorld(0);
            //CreateDynamicObject(2342, -952.622681, 2734.412842, 46.041187, 0.000000, 0.000000, -105.099976, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb26 = new DynamicObject(2342, new Vector3(-952.622681, 2734.412842, 46.041187), new Vector3(0.000000, 0.000000, -105.099976), 0, 0, player, 200, 150);
            bridgeb26.ShowInWorld(0);
            //CreateDynamicObject(2861, -952.778748, 2735.028564, 45.929363, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb27 = new DynamicObject(2861, new Vector3(-952.778748, 2735.028564, 45.929363), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb27.ShowInWorld(0);
            //CreateDynamicObject(1520, -952.437927, 2733.541016, 45.975117, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb28 = new DynamicObject(1520, new Vector3(-952.437927, 2733.541016, 45.975117), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb28.ShowInWorld(0);
            //CreateDynamicObject(19572, -952.664246, 2734.530762, 45.213470, 0.000000, 0.000000, -72.800003, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb29 = new DynamicObject(19572, new Vector3(-952.664246, 2734.530762, 45.213470), new Vector3(0.000000, 0.000000, -72.800003), 0, 0, player, 200, 150);
            bridgeb29.ShowInWorld(0);
            //CreateDynamicObject(19572, -952.475403, 2733.920654, 45.213470, 0.000000, 0.000000, -97.499985, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb30 = new DynamicObject(19572, new Vector3(-952.475403, 2733.920654, 45.213470), new Vector3(0.000000, 0.000000, -97.499985), 0, 0, player, 200, 150);
            bridgeb30.ShowInWorld(0);
            //CreateDynamicObject(2972, -953.085510, 2736.717041, 45.139622, 0.000000, 0.000000, -11.699987, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb31 = new DynamicObject(2972, new Vector3(-953.085510, 2736.717041, 45.139622), new Vector3(0.000000, 0.000000, -11.699987), 0, 0, player, 200, 150);
            bridgeb31.ShowInWorld(0);
            //CreateDynamicObject(3795, -969.715637, 2719.796875, 44.858509, 0.000000, 0.000000, 23.799999, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0

            var bridgeb32 = new DynamicObject(3795, new Vector3(-969.715637, 2719.796875, 44.858509), new Vector3(0.000000, 0.000000, 23.799999), 0, 0, player, 200, 150);
            bridgeb32.ShowInWorld(0);
            //CreateDynamicObject(19944, -974.631653, 2722.887451, 44.997200, 0.000000, 0.000000, 8.099999, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb33 = new DynamicObject(19944, new Vector3(-974.631653, 2722.887451, 44.997200), new Vector3(0.000000, 0.000000, 8.099999), 0, 0, player, 200, 150);
            bridgeb33.ShowInWorld(0);
            //CreateDynamicObject(19996, -951.655273, 2733.862793, 45.162563, 0.000000, 0.000000, -98.899994, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb34 = new DynamicObject(19996, new Vector3(-951.655273, 2733.862793, 45.162563), new Vector3(0.000000, 0.000000, -98.899994), 0, 0, player, 200, 150);
            bridgeb34.ShowInWorld(0);
            //CreateDynamicObject(19996, -951.830078, 2735.130859, 45.162563, 0.000000, 0.000000, -64.399994, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb35 = new DynamicObject(19996, new Vector3(-951.830078, 2735.130859, 45.162563), new Vector3(0.000000, 0.000000, -64.399994), 0, 0, player, 200, 150);
            bridgeb35.ShowInWorld(0);
            
            var bridgeb36 = new DynamicObject(3939, new Vector3(-951.177979, 2734.912842, 46.717041), new Vector3(0.000000, 0.000000, -91.399902), 0, 0, player, 200, 150);
            bridgeb36.SetMaterial(2,3085,"blkbrdx","tatty_wood_1", 0);
            bridgeb36.SetMaterial(1, 3085, "blkbrdx", "tatty_wood_1", 0);
            bridgeb36.SetMaterial(0, 3085, "blkbrdx", "tatty_wood_1", 0);
            bridgeb36.ShowInWorld(0);
            //CreateDynamicObject(19944, -975.695129, 2722.671875, 44.997200, 0.000000, 0.000000, 18.200001, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb37 = new DynamicObject(19944, new Vector3(-975.695129, 2722.671875, 44.997200), new Vector3(0.000000, 0.000000, 18.200001), 0, 0, player, 200, 150);
            bridgeb37.ShowInWorld(0);
            
            var bridgeb38 = new DynamicObject(3884, new Vector3(-968.991882, 2717.636230, 44.817200), new Vector3(0.000000, 0.000000, 86.400009), 0, 0, player, 200, 150);
            bridgeb38.SetMaterial(2, 3085, "countrys", "rustc256128", 0);
            bridgeb38.SetMaterial(1, 3085, "countrys", "rustc256128", 0);
            bridgeb38.SetMaterial(0, 3085, "countrys", "rustc256128", 0);
            bridgeb38.ShowInWorld(0);
      
            var bridgeb39 = new DynamicObject(18706, new Vector3(-969.336792, 2717.486816, 45.913876), new Vector3(15.100001, 32.300014, 0.000000), 0, 0, player, 200, 150);
            bridgeb39.ShowInWorld(0);
            
            var bridgeb40 = new DynamicObject(19632, new Vector3(-949.639282, 2730.580322, 45.225334), new Vector3(0.000000, 0.000000, 20.299988), 0, 0, player, 200, 150);
            bridgeb40.ShowInWorld(0);
            
            var bridgeb41 = new DynamicObject(3884, new Vector3(-968.991882, 2717.636230, 44.817200), new Vector3(0.000000, 0.000000, 86.400009), 0, 0, player, 200, 150);
            bridgeb41.SetMaterial(1, 3115, "carrierxr", "ws_carrierdeckbase", 0);
            bridgeb41.SetMaterial(0, 2956, "immcrax", "Metalox64", 0);
            bridgeb41.ShowInWorld(0);
            //CreateDynamicObject(19944, -976.930298, 2722.263672, 44.997200, 0.000000, 0.000000, 18.200001, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb42 = new DynamicObject(19944, new Vector3(-976.930298, 2722.263672, 44.997200), new Vector3(0.000000, 0.000000, 18.200001), 0, 0, player, 200, 150);
            bridgeb42.ShowInWorld(0);
            //CreateDynamicObject(19636, -949.654541, 2737.215332, 45.840946, 0.000000, 0.000000, -95.599998, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb43 = new DynamicObject(19636, new Vector3(-949.654541, 2737.215332, 45.840946), new Vector3(0.000000, 0.000000, -95.599998), 0, 0, player, 200, 150);
            bridgeb43.ShowInWorld(0);
            //CreateDynamicObject(1271, -949.661865, 2737.267334, 45.508606, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb44 = new DynamicObject(1271, new Vector3(-949.661865, 2737.267334, 45.508606), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb44.ShowInWorld(0);
            //CreateDynamicObject(19573, -948.632324, 2732.265137, 45.192486, 0.000000, 0.000000, -87.799942, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb45 = new DynamicObject(19573, new Vector3(-948.632324, 2732.265137, 45.192486), new Vector3(0.000000, 0.000000, -87.799942), 0, 0, player, 200, 150);
            bridgeb45.ShowInWorld(0);
            //CreateDynamicObject(2690, -948.449280, 2732.721924, 46.005344, 0.000000, 0.000000, -80.199997, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb46 = new DynamicObject(2690, new Vector3(-948.449280, 2732.721924, 46.005344), new Vector3(0.000000, 0.000000, -80.199997), 0, 0, player, 200, 150);
            bridgeb46.ShowInWorld(0);
            //CreateDynamicObject(2690, -948.441589, 2733.027832, 46.005344, 0.000000, 0.000000, -80.199997, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb47 = new DynamicObject(2690, new Vector3(-948.441589, 2733.027832, 46.005344), new Vector3(0.000000, 0.000000, -80.199997), 0, 0, player, 200, 150);
            bridgeb47.ShowInWorld(0);
            //CreateDynamicObject(917, -948.675476, 2736.031250, 45.988518, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb48 = new DynamicObject(917, new Vector3(-948.675476, 2736.031250, 45.988518), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb48.ShowInWorld(0);
            //CreateDynamicObject(1271, -948.902039, 2737.037109, 46.178589, 0.000000, 0.000000, -9.700000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb49 = new DynamicObject(1271, new Vector3(-948.902039, 2737.037109, 46.178589), new Vector3(0.000000, 0.000000, -9.700000), 0, 0, player, 200, 150);
            bridgeb49.ShowInWorld(0);
            //CreateDynamicObject(917, -948.675476, 2736.351563, 45.988518, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb50 = new DynamicObject(917, new Vector3(-948.675476, 2736.351563, 45.988518), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb50.ShowInWorld(0);
            //CreateDynamicObject(1271, -948.882019, 2737.037109, 45.508606, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb51 = new DynamicObject(1271, new Vector3(-948.882019, 2737.037109, 45.508606), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb51.ShowInWorld(0);
            //CreateDynamicObject(19572, -948.641785, 2736.355713, 45.833454, 0.000000, 0.000000, -179.299866, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb52 = new DynamicObject(19572, new Vector3(-948.641785, 2736.355713, 45.833454), new Vector3(0.000000, 0.000000, -179.299866), 0, 0, player, 200, 150);
            bridgeb42.ShowInWorld(0);
            //CreateDynamicObject(1271, -948.611755, 2736.216309, 45.508606, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb53 = new DynamicObject(1271, new Vector3(-948.611755, 2736.216309, 45.508606), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb53.ShowInWorld(0);
            //CreateDynamicObject(1025, -971.970032, 2716.560547, 45.073318, 0.000000, -29.300003, 148.199997, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb54 = new DynamicObject(1025, new Vector3(-971.970032, 2716.560547, 45.073318), new Vector3(0.000000, -29.300003, 148.199997), 0, 0, player, 200, 150);
            bridgeb54.ShowInWorld(0);
            //CreateDynamicObject(19917, -971.367371, 2715.813965, 45.127201, 0.000000, 0.000000, 36.500023, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            var bridgeb55 = new DynamicObject(19917, new Vector3(-971.367371, 2715.813965, 45.127201), new Vector3(0.000000, 0.000000, 36.500023), 0, 0, player, 200, 150);
            bridgeb55.ShowInWorld(0);
            //CreateDynamicObject(18726, -971.294678, 2715.610596, 44.917191, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb56 = new DynamicObject(18726, new Vector3(-971.294678, 2715.610596, 44.917191), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb56.ShowInWorld(0);
            //CreateDynamicObject(18688, -971.561462, 2715.677246, 44.187222, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb57 = new DynamicObject(18688, new Vector3(-971.561462, 2715.677246, 44.187222), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb57.ShowInWorld(0);
            //CreateDynamicObject(1025, -970.933105, 2715.227539, 45.019413, 0.000000, -29.300003, -57.200043, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb58 = new DynamicObject(1025, new Vector3(-970.933105, 2715.227539, 45.019413), new Vector3(0.000000, -29.300003, -57.200043), 0, 0, player, 200, 150);
            bridgeb58.ShowInWorld(0);
            //CreateDynamicObject(850, -975.928589, 2717.470703, 44.977215, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var bridgeb59 = new DynamicObject(850, new Vector3(-975.928589, 2717.470703, 44.977215), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb59.ShowInWorld(0);
            //CreateDynamicObject(930, -980.670959, 2722.913818, 45.477230, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            var bridgeb60 = new DynamicObject(930, new Vector3(-980.670959, 2722.913818, 45.477230), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb60.ShowInWorld(0);
            
            var bridgeb61 = new DynamicObject(3066, new Vector3(-946.354126, 2734.429443, 46.005978), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb61.SetMaterial(0,3945,"alpha_fence","bistro_alpha", 0xFFFFFFFF);
            bridgeb61.ShowInWorld(0);
            //CreateDynamicObject(2674, -981.424194, 2722.962402, 45.045631, 0.000000, 0.000000, 23.300003, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb62 = new DynamicObject(2674, new Vector3(-981.424194, 2722.962402, 45.045631), new Vector3(0.000000, 0.000000, 23.300003), 0, 0, player, 200, 150);
            bridgeb62.ShowInWorld(0);
            //CreateDynamicObject(1672, -982.158264, 2723.382813, 47.285625, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0
            var bridgeb63 = new DynamicObject(1672, new Vector3(-982.158264, 2723.382813, 47.285625), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb63.ShowInWorld(0);
            //CreateDynamicObject(1672, -982.303589, 2723.351563, 47.268776, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0
            var bridgeb64 = new DynamicObject(1672, new Vector3(-982.303589, 2723.351563, 47.268776), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb64.ShowInWorld(0);
            //CreateDynamicObject(1672, -982.273865, 2723.242920, 47.230839, 92.900017, -38.900005, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0
            var bridgeb65 = new DynamicObject(1672, new Vector3(-982.273865, 2723.242920, 47.230839), new Vector3(92.900017, -38.900005, 0.000000), 0, 0, player, 200, 150);
            bridgeb65.ShowInWorld(0);
            //CreateDynamicObject(1672, -982.453735, 2723.303467, 47.233894, 92.900017, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0
            var bridgeb66 = new DynamicObject(1672, new Vector3(-982.453735, 2723.303467, 47.233894), new Vector3(92.900017, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb66.ShowInWorld(0);
            //CreateDynamicObject(19942, -982.434387, 2723.048096, 46.015648, -84.500031, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0
            var bridgeb67 = new DynamicObject(19942, new Vector3(-982.434387, 2723.048096, 46.015648), new Vector3(-84.500031, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb67.ShowInWorld(0);
            //CreateDynamicObject(2977, -982.646790, 2722.816895, 44.825649, 0.000000, 0.000000, -54.000011, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb68 = new DynamicObject(2977, new Vector3(-982.646790, 2722.816895, 44.825649), new Vector3(0.000000, 0.000000, -54.000011), 0, 0, player, 200, 150);
            bridgeb68.ShowInWorld(0);
            //CreateDynamicObject(356, -982.803528, 2722.755371, 46.078144, -88.100006, 33.300014, 3.599999, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb69 = new DynamicObject(356, new Vector3(-982.803528, 2722.755371, 46.078144), new Vector3(-88.100006, 33.300014, 3.599999), 0, 0, player, 200, 150);
            bridgeb69.ShowInWorld(0);
            //fso_map = CreateDynamicObject(1464, -983.355896, 2722.670898, 46.117142, 0.000000, 0.000000, 188.300034, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 4
            //SetDynamicObjectMaterial(fso_map, 3, 18845, "MickyTextures", "metal013", 0);
            //SetDynamicObjectMaterial(fso_map, 2, 18845, "MickyTextures", "metal013", 0);
            //SetDynamicObjectMaterial(fso_map, 1, 19272, "DMCages", "metaldrumold1", 0);
            //SetDynamicObjectMaterial(fso_map, 0, 18886, "ElectroMagnet1", "metalox64", 0);
            var bridgeb70 = new DynamicObject(1464, new Vector3(-983.355896, 2722.670898, 46.117142), new Vector3(0.000000, 0.000000, 188.300034), 0, 0, player, 200, 150);
            bridgeb70.SetMaterial(3, 18845, "MickyTextures", "metal013", 0);
            bridgeb70.SetMaterial(2, 18845, "MickyTextures", "metal013", 0);
            bridgeb70.SetMaterial(1, 19272, "DMCages", "metaldrumold1", 0);
            bridgeb70.SetMaterial(0, 18886, "ElectroMagnet1", "metalox64", 0);
            bridgeb70.ShowInWorld(0);
            //fso_map = CreateDynamicObject(2064, -979.181396, 2716.929688, 45.447182, 0.000000, 0.000000, -72.199989, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 17003, "countrys", "rustc256128", 0);
            var bridgeb71 = new DynamicObject(2064, new Vector3(-979.181396, 2716.929688, 45.447182), new Vector3(0.000000, 0.000000, -72.199989), 0, 0, player, 200, 150);
            bridgeb71.SetMaterial(0,17003,"countrys","rustc256128", 0);
            bridgeb71.ShowInWorld(0);
            //CreateDynamicObject(1428, -983.067383, 2721.514160, 45.867188, 0.000000, 0.000000, 8.399990, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb72 = new DynamicObject(1428, new Vector3(-983.067383, 2721.514160, 45.867188), new Vector3(0.000000, 0.000000, 8.399990), 0, 0, player, 200, 150);
            bridgeb72.ShowInWorld(0);
            //CreateDynamicObject(2061, -980.510254, 2717.974854, 45.139133, 25.500004, 0.000000, -99.300003, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb73 = new DynamicObject(2061, new Vector3(-980.510254, 2717.974854, 45.139133), new Vector3(25.500004, 0.000000, -99.300003), 0, 0, player, 200, 150);
            bridgeb73.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.776917, 2717.820801, 44.987209, 0.000000, 0.000000, 87.699966, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb74 = new DynamicObject(2060, new Vector3(-980.776917, 2717.820801, 44.987209), new Vector3(0.000000, 0.000000, 87.699966), 0, 0, player, 200, 150);
            bridgeb74.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.779480, 2717.760742, 45.177177, 0.000000, 0.000000, 87.699966, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb75 = new DynamicObject(2060, new Vector3(-980.779480, 2717.760742, 45.177177), new Vector3(0.000000, 0.000000, 87.699966), 0, 0, player, 200, 150);
            bridgeb75.ShowInWorld(0);
            //fso_map = CreateDynamicObject(3850, -984.465271, 2723.056396, 47.685593, 0.000000, 0.000000, 98.499992, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 2
            //SetDynamicObjectMaterial(fso_map, 1, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            //SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb76 = new DynamicObject(3850, new Vector3(-984.465271, 2723.056396, 47.685593), new Vector3(0.000000, 0.000000, 98.499992), 0, 0, player, 200, 150);
            bridgeb76.SetMaterial(1,3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            bridgeb76.SetMaterial(0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            bridgeb76.ShowInWorld(0);
            //CreateDynamicObject(2977, -984.248474, 2722.687744, 44.807201, 0.000000, 0.000000, 13.499999, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb77 = new DynamicObject(2977, new Vector3(-984.248474, 2722.687744, 44.807201), new Vector3(0.000000, 0.000000, 13.499999), 0, 0, player, 200, 150);
            bridgeb77.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.798340, 2717.310303, 45.467144, 0.000000, 0.000000, 87.699966, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb78 = new DynamicObject(2060, new Vector3(-980.798340, 2717.310303, 45.467144), new Vector3(0.000000, 0.000000, 87.699966), 0, 0, player, 200, 150);
            bridgeb78.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.707031, 2716.825195, 44.987209, 0.000000, 0.000000, 110.399971, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb79 = new DynamicObject(2060, new Vector3(-980.707031, 2716.825195, 44.987209), new Vector3(0.000000, 0.000000, 110.399971), 0, 0, player, 200, 150);
            bridgeb79.ShowInWorld(0);
            //fso_map = CreateDynamicObject(2906, -981.251526, 2717.407959, 44.913361, 5.099997, 0.000000, 40.600117, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb80 = new DynamicObject(2906, new Vector3(-981.251526, 2717.407959, 44.913361), new Vector3(5.099997, 0.000000, 40.600117), 0, 0, player, 200, 150);
            bridgeb80.SetMaterial(0,3945,"alpha_fence","bistro_alpha", 0xFFFFFFFF);
            bridgeb80.ShowInWorld(0);
            // CreateDynamicObject(2060, -980.755615, 2716.753174, 45.627102, 0.000000, 0.000000, 98.799911, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb81 = new DynamicObject(2060, new Vector3(-980.755615, 2716.753174, 45.627102), new Vector3(0.000000, 0.000000, 98.799911), 0, 0, player, 200, 150);
            bridgeb81.ShowInWorld(0);
            //CreateDynamicObject(2040, -980.285522, 2716.241455, 45.007236, 0.000000, 95.299950, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb82 = new DynamicObject(2040, new Vector3(-980.285522, 2716.241455, 45.007236), new Vector3(0.000000, 95.299950, 0.000000), 0, 0, player, 200, 150);
            bridgeb82.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.856567, 2716.767822, 45.207176, 0.000000, 0.000000, 105.200043, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb83 = new DynamicObject(2060, new Vector3(-980.856567, 2716.767822, 45.207176), new Vector3(0.000000, 0.000000, 105.200043), 0, 0, player, 200, 150);
            bridgeb83.ShowInWorld(0);
            //CreateDynamicObject(2040, -980.250732, 2716.074219, 45.127247, 0.000000, 0.000000, 13.600002, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb84 = new DynamicObject(2040, new Vector3(-980.250732, 2716.074219, 45.127247), new Vector3(0.000000, 0.000000, 13.600002), 0, 0, player, 200, 150);
            bridgeb84.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.951416, 2716.736328, 44.987209, 0.000000, 0.000000, 110.399971, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb85 = new DynamicObject(2060, new Vector3(-980.951416, 2716.736328, 44.987209), new Vector3(0.000000, 0.000000, 110.399971), 0, 0, player, 200, 150);
            bridgeb79.ShowInWorld(0);
            //CreateDynamicObject(2040, -980.145508, 2715.810303, 44.947216, 0.000000, 0.000000, 34.299995, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb86 = new DynamicObject(2040, new Vector3(-980.145508, 2715.810303, 44.947216), new Vector3(0.000000, 0.000000, 34.299995), 0, 0, player, 200, 150);
            bridgeb86.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.677795, 2716.250732, 45.457130, 0.000000, 0.000000, 117.299965, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb87 = new DynamicObject(2060, new Vector3(-980.677795, 2716.250732, 45.457130), new Vector3(0.000000, 0.000000, 117.299965), 0, 0, player, 200, 150);
            bridgeb87.ShowInWorld(0);
            //CreateDynamicObject(19101, -981.194397, 2716.755127, 45.974850, -11.199995, -91.899986, 96.500031, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0
            var bridgeb88 = new DynamicObject(19101, new Vector3(-981.194397, 2716.755127, 45.974850), new Vector3(-11.199995, -91.899986, 96.500031), 0, 0, player, 200, 150);
            bridgeb88.ShowInWorld(0);
            //fso_map = CreateDynamicObject(2908, -981.200806, 2716.755371, 45.892227, -87.099983, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb89 = new DynamicObject(2908, new Vector3(-981.200806, 2716.755371, 45.892227), new Vector3(-87.099983, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb89.SetMaterial(0,3945,"alpha_fence", "bistro_alpha",0xFFFFFFFF);
            bridgeb89.ShowInWorld(0);
            //fso_map = CreateDynamicObject(2907, -981.241272, 2716.702393, 45.354961, -78.500122, 0.000000, 105.600044, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb90 = new DynamicObject(2907, new Vector3(-981.241272, 2716.702393, 45.354961), new Vector3(-78.500122, 0.000000, 105.600044), 0, 0, player, 200, 150);
            bridgeb90.SetMaterial(0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            bridgeb90.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.476257, 2715.857666, 45.197174, 0.000000, 0.000000, 117.299965, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb91 = new DynamicObject(2060, new Vector3(-980.476257, 2715.857666, 45.197174), new Vector3(0.000000, 0.000000, 117.299965), 0, 0, player, 200, 150);
            bridgeb91.ShowInWorld(0);
            //CreateDynamicObject(2036, -980.124207, 2715.485352, 45.380268, 0.000000, -100.900002, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb92 = new DynamicObject(2036, new Vector3(-980.124207, 2715.485352, 45.380268), new Vector3(0.000000, -100.900002, 0.000000), 0, 0, player, 200, 150);
            bridgeb92.ShowInWorld(0);
            //CreateDynamicObject(2060, -980.421326, 2715.751953, 44.987209, 0.000000, 0.000000, 117.299965, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb93 = new DynamicObject(2060, new Vector3(-980.421326, 2715.751953, 44.987209), new Vector3(0.000000, 0.000000, 117.299965), 0, 0, player, 200, 150);
            bridgeb93.ShowInWorld(0);
            //CreateDynamicObject(2675, -982.957947, 2718.582031, 44.937325, 0.000000, 0.000000, 94.899948, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb94 = new DynamicObject(2675, new Vector3(-982.957947, 2718.582031, 44.937325), new Vector3(0.000000, 0.000000, 94.899948), 0, 0, player, 200, 150);
            bridgeb94.ShowInWorld(0);
            //fso_map = CreateDynamicObject(2905, -981.744629, 2716.798096, 45.053528, -5.699998, 97.100021, 92.400192, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb95 = new DynamicObject(2905, new Vector3(-981.744629, 2716.798096, 45.053528), new Vector3(-5.699998, 97.100021, 92.400192), 0, 0, player, 200, 150);
            bridgeb95.SetMaterial(0,3945,"alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            bridgeb95.ShowInWorld(0);
            //fso_map = CreateDynamicObject(1464, -985.388000, 2721.851318, 46.117142, 0.000000, 0.000000, -81.699966, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 4
            //SetDynamicObjectMaterial(fso_map, 3, 18845, "MickyTextures", "metal013", 0);
            //SetDynamicObjectMaterial(fso_map, 2, 18845, "MickyTextures", "metal013", 0);
            //SetDynamicObjectMaterial(fso_map, 1, 19272, "DMCages", "metaldrumold1", 0);
            //SetDynamicObjectMaterial(fso_map, 0, 18886, "ElectroMagnet1", "metalox64", 0);
            var bridgeb96 = new DynamicObject(1464, new Vector3(-985.388000, 2721.851318, 46.117142), new Vector3(0.000000, 0.000000, -81.699966), 0, 0, player, 200, 150);
            bridgeb96.SetMaterial(3, 18845, "MickyTextures", "metal013", 0);
            bridgeb96.SetMaterial(2, 18845, "MickyTextures", "metal013", 0);
            bridgeb96.SetMaterial(1, 19272, "DMCages", "metaldrumold1", 0);
            bridgeb96.SetMaterial(0, 18886, "ElectroMagnet1", "metalox64", 0);
            bridgeb96.ShowInWorld(0);
            
            var bridgeb97 = new DynamicObject(2674, new Vector3(-985.088440, 2721.218018, 45.025574), new Vector3(0.000000, 0.000000, -127.599998), 0, 0, player, 200, 150);
            bridgeb97.ShowInWorld(0);
            //fso_map = CreateDynamicObject(3850, -985.952087, 2721.437744, 47.685593, 0.000000, 0.000000, 8.499991, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 5114, "beach_las2", "Bow_meshfence", 0);
            var bridgeb98 = new DynamicObject(3850, new Vector3(-985.952087, 2721.437744, 47.685593), new Vector3(0.000000, 0.000000, 8.499991), 0, 0, player, 200, 150);
            bridgeb98.SetMaterial(0,5114,"beach_las2", "Bow_meshfence", 0);
            bridgeb98.ShowInWorld(0);
            //fso_map = CreateDynamicObject(2985, -985.559265, 2720.553467, 47.178844, 0.000000, 0.000000, -152.299988, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb99 = new DynamicObject(2985, new Vector3(-985.559265, 2720.553467, 47.178844), new Vector3(0.000000, 0.000000, -152.299988), 0, 0, player, 200, 150);
            bridgeb99.SetMaterial(0,3945,"alpha_fence","bistro_alpha", 0xFFFFFFFF);
            bridgeb99.ShowInWorld(0);
            //fso_map = CreateDynamicObject(1464, -984.979614, 2719.052734, 46.043327, 0.000000, 2.199999, -81.699966, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 4
            //SetDynamicObjectMaterial(fso_map, 3, 18845, "MickyTextures", "metal013", 0);
            //SetDynamicObjectMaterial(fso_map, 2, 18845, "MickyTextures", "metal013", 0);
            //SetDynamicObjectMaterial(fso_map, 1, 19272, "DMCages", "metaldrumold1", 0);
            //SetDynamicObjectMaterial(fso_map, 0, 18886, "ElectroMagnet1", "metalox64", 0);
            var bridgeb100 = new DynamicObject(1464, new Vector3(-984.979614, 2719.052734, 46.043327), new Vector3(0.000000, 2.199999, -81.699966), 0, 0, player, 200, 150);
            bridgeb100.SetMaterial(3,18845,"MickyTextures", "metal013",0);
            bridgeb100.SetMaterial(2, 18845, "MickyTextures", "metal013", 0);
            bridgeb100.SetMaterial(1, 19272, "DMCages", "metaldrumold1", 0);
            bridgeb100.SetMaterial(0, 18886, "ElectroMagnet1", "metalox64", 0);
            bridgeb100.ShowInWorld(0);
            // CreateDynamicObject(1421, -984.991150, 2718.843750, 47.888760, 0.000000, 0.000000, -64.999985, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb101 = new DynamicObject(1421, new Vector3(-984.991150, 2718.843750, 47.888760), new Vector3(0.000000, 0.000000, -64.999985), 0, 0, player, 200, 150);
            bridgeb101.ShowInWorld(0);
            //CreateDynamicObject(2969, -984.867065, 2718.073975, 44.977200, 0.000000, 0.000000, 51.500011, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb102 = new DynamicObject(2969, new Vector3(-984.867065, 2718.073975, 44.977200), new Vector3(0.000000, 0.000000, 51.500011), 0, 0, player, 200, 150);
            bridgeb102.ShowInWorld(0);
            // CreateDynamicObject(2969, -985.155640, 2718.239990, 45.227177, 0.000000, 0.000000, -13.999976, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb103 = new DynamicObject(2969, new Vector3(-985.155640, 2718.239990, 45.227177), new Vector3(0.000000, 0.000000, -13.999976), 0, 0, player, 200, 150);
            bridgeb103.ShowInWorld(0);
            // CreateDynamicObject(2969, -985.383850, 2718.544189, 44.977200, 0.000000, 0.000000, 105.200027, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            var bridgeb104 = new DynamicObject(2969, new Vector3(-985.383850, 2718.544189, 44.977200), new Vector3(0.000000, 0.000000, 105.200027), 0, 0, player, 200, 150);
            bridgeb104.ShowInWorld(0);
            // CreateDynamicObject(3594, -952.184570, 2710.490234, 45.237335, 0.000000, 0.000000, 103.399956, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb105 = new DynamicObject(3594, new Vector3(-952.184570, 2710.490234, 45.237335), new Vector3(0.000000, 0.000000, 103.399956), 0, 0, player, 200, 150);
            bridgeb105.ShowInWorld(0);
            // fso_map = CreateDynamicObject(2985, -984.647888, 2716.775391, 44.836342, -1.499993, 0.000000, -156.700089, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb106 = new DynamicObject(2985, new Vector3(-984.647888, 2716.775391, 44.836342), new Vector3(-1.499993, 0.000000, -156.700089), 0, 0, player, 200, 150);
            bridgeb106.SetMaterial(0,3945,"alpha_fence","bistro_alpha",  0xFFFFFFFF);
            bridgeb106.ShowInWorld(0);
            // CreateDynamicObject(1431, -985.218140, 2716.467773, 45.157211, 0.000000, 0.000000, 121.999985, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb107 = new DynamicObject(1431, new Vector3(-985.218140, 2716.467773, 45.157211), new Vector3(0.000000, 0.000000, 121.999985), 0, 0, player, 200, 150);
            bridgeb107.ShowInWorld(0);
            // CreateDynamicObject(3594, -943.025757, 2715.100830, 45.217339, 0.000000, 0.000000, 92.899971, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb108 = new DynamicObject(3594, new Vector3(-943.025757, 2715.100830, 45.217339), new Vector3(0.000000, 0.000000, 92.899971), 0, 0, player, 200, 150);
            bridgeb108.ShowInWorld(0);
            // CreateDynamicObject(3594, -990.573792, 2716.421631, 45.217339, 0.000000, 0.000000, 92.899971, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb109 = new DynamicObject(3594, new Vector3(-990.573792, 2716.421631, 45.217339), new Vector3(0.000000, 0.000000, 92.899971), 0, 0, player, 200, 150);
            bridgeb109.ShowInWorld(0);
            // CreateDynamicObject(2676, -991.538757, 2712.955322, 44.977226, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var bridgeb110 = new DynamicObject(2676, new Vector3(-991.538757, 2712.955322, 44.977226), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb110.ShowInWorld(0);
            // CreateDynamicObject(3594, -934.224670, 2715.539551, 45.217339, 0.000000, 0.000000, 102.199921, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb111 = new DynamicObject(3594, new Vector3(-934.224670, 2715.539551, 45.217339), new Vector3(0.000000, 0.000000, 102.199921), 0, 0, player, 200, 150);
            bridgeb111.ShowInWorld(0);
            // fso_map = CreateDynamicObject(2899, -996.898010, 2716.911865, 44.957169, 0.000000, 0.000000, 78.499992, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0xFFFFFFFF);
            var bridgeb112 = new DynamicObject(2899, new Vector3(-996.898010, 2716.911865, 44.957169), new Vector3(0.000000, 0.000000, 78.499992), 0, 0, player, 200, 150);
            bridgeb112.SetMaterial(0,3945,"alpha_fence","bistro_alpha",0xFFFFFFFF);
            bridgeb112.ShowInWorld(0);
            // CreateDynamicObject(19587, -999.739685, 2719.936279, 45.027184, 0.000000, 0.000000, 65.300026, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            var bridgeb113 = new DynamicObject(19587, new Vector3(-999.739685, 2719.936279, 45.027184), new Vector3(0.000000, 0.000000, 65.300026), 0, 0, player, 200, 150);
            bridgeb113.ShowInWorld(0);
            // CreateDynamicObject(2675, -998.266296, 2712.993164, 44.937325, 0.000000, 0.000000, 94.899948, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb114 = new DynamicObject(2675, new Vector3(-998.266296, 2712.993164, 44.937325), new Vector3(0.000000, 0.000000, 94.899948), 0, 0, player, 200, 150);
            bridgeb114.ShowInWorld(0);
            // CreateDynamicObject(19587, -1002.362427, 2719.953857, 45.027184, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            var bridgeb115 = new DynamicObject(19587, new Vector3(-1002.362427, 2719.953857, 45.027184), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb115.ShowInWorld(0);
            // CreateDynamicObject(3594, -997.701660, 2708.005127, 45.217339, 0.000000, 0.000000, 106.800011, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb116 = new DynamicObject(3594, new Vector3(-997.701660, 2708.005127, 45.217339), new Vector3(0.000000, 0.000000, 106.800011), 0, 0, player, 200, 150);
            bridgeb116.ShowInWorld(0);
            //CreateDynamicObject(13591, -1003.630737, 2714.648438, 45.077362, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var bridgeb117 = new DynamicObject(13591, new Vector3(-1003.630737, 2714.648438, 45.077362), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb117.ShowInWorld(0);
            //CreateDynamicObject(1224, -1010.565857, 2718.281738, 45.577236, 0.000000, 0.000000, -22.500010, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb118 = new DynamicObject(1224, new Vector3(-1010.565857, 2718.281738, 45.577236), new Vector3(0.000000, 0.000000, -22.500010), 0, 0, player, 200, 150);
            bridgeb118.ShowInWorld(0);
            // CreateDynamicObject(935, -1024.815186, 2714.085938, 45.217293, 90.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            var bridgeb119 = new DynamicObject(935, new Vector3(-1024.815186, 2714.085938, 45.217293), new Vector3(90.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb119.ShowInWorld(0);
            // CreateDynamicObject(3594, -1022.684814, 2705.780029, 45.217339, 0.000000, 0.000000, 106.800011, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb120 = new DynamicObject(3594, new Vector3(-1022.684814, 2705.780029, 45.217339), new Vector3(0.000000, 0.000000, 106.800011), 0, 0, player, 200, 150);
            bridgeb120.ShowInWorld(0);
            // CreateDynamicObject(3594, -1031.907227, 2704.779297, 45.217339, 0.000000, 0.000000, 96.299965, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb121 = new DynamicObject(3594, new Vector3(-1031.907227, 2704.779297, 45.217339), new Vector3(0.000000, 0.000000, 96.299965), 0, 0, player, 200, 150);
            bridgeb121.ShowInWorld(0);
            // CreateDynamicObject(3594, -1044.441528, 2703.402100, 45.217339, 0.000000, 0.000000, 96.299965, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb122 = new DynamicObject(3594, new Vector3(-1044.441528, 2703.402100, 45.217339), new Vector3(0.000000, 0.000000, 96.299965), 0, 0, player, 200, 150);
            bridgeb122.ShowInWorld(0);
            // CreateDynamicObject(3594, -1063.626831, 2707.023682, 45.217339, 0.000000, 0.000000, 96.299965, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb123 = new DynamicObject(3594, new Vector3(-1063.626831, 2707.023682, 45.217339), new Vector3(0.000000, 0.000000, 96.299965), 0, 0, player, 200, 150);
            bridgeb123.ShowInWorld(0);
            // CreateDynamicObject(3594, -1078.862183, 2700.135742, 45.217339, 0.000000, 0.000000, 96.299965, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb124 = new DynamicObject(3594, new Vector3(-1078.862183, 2700.135742, 45.217339), new Vector3(0.000000, 0.000000, 96.299965), 0, 0, player, 200, 150);
            bridgeb124.ShowInWorld(0);
            // CreateDynamicObject(3594, -1092.697998, 2698.611084, 45.217339, 0.000000, 0.000000, 96.299965, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb125 = new DynamicObject(3594, new Vector3(-1092.697998, 2698.611084, 45.217339), new Vector3(0.000000, 0.000000, 96.299965), 0, 0, player, 200, 150);
            bridgeb125.ShowInWorld(0);
            // CreateDynamicObject(3594, -1094.719482, 2694.032227, 45.787243, -12.899998, 0.000000, 52.399990, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb126 = new DynamicObject(3594, new Vector3(-1094.719482, 2694.032227, 45.787243), new Vector3(-12.899998, 0.000000, 52.399990), 0, 0, player, 200, 150);
            bridgeb126.ShowInWorld(0);
            // CreateDynamicObject(3594, -1102.326294, 2701.704590, 45.217339, 0.000000, 0.000000, 70.799980, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb127 = new DynamicObject(3594, new Vector3(-1102.326294, 2701.704590, 45.217339), new Vector3(0.000000, 0.000000, 70.799980), 0, 0, player, 200, 150);
            bridgeb127.ShowInWorld(0);
            // CreateDynamicObject(865, -1102.378906, 2699.855469, 45.277264, 0.000000, 0.000000, 24.900000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var bridgeb128 = new DynamicObject(865, new Vector3(-1102.378906, 2699.855469, 45.277264), new Vector3(0.000000, 0.000000, 24.900000), 0, 0, player, 200, 150);
            bridgeb128.ShowInWorld(0);
            // CreateDynamicObject(3594, -1104.606323, 2697.298828, 45.217339, 0.000000, 0.000000, 134.999985, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb129 = new DynamicObject(3594, new Vector3(-1104.606323, 2697.298828, 45.217339), new Vector3(0.000000, 0.000000, 134.999985), 0, 0, player, 200, 150);
            bridgeb129.ShowInWorld(0);
            // CreateDynamicObject(3594, -1113.847046, 2699.843506, 45.217339, 0.000000, 0.000000, 102.500008, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb130 = new DynamicObject(3594, new Vector3(-1113.847046, 2699.843506, 45.217339), new Vector3(0.000000, 0.000000, 102.500008), 0, 0, player, 200, 150);
            bridgeb130.ShowInWorld(0);
            // CreateDynamicObject(1219, -1114.538330, 2696.202881, 45.069405, 0.000000, 0.000000, -46.800003, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb131 = new DynamicObject(1219, new Vector3(-1114.538330, 2696.202881, 45.069405), new Vector3(0.000000, 0.000000, -46.800003), 0, 0, player, 200, 150);
            bridgeb131.ShowInWorld(0);
            // CreateDynamicObject(3593, -1121.934814, 2696.129395, 45.384132, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb132 = new DynamicObject(3593, new Vector3(-1121.934814, 2696.129395, 45.384132), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            bridgeb132.ShowInWorld(0);
            // CreateDynamicObject(3593, -1135.326782, 2704.253174, 45.827618, 1.999997, 14.099998, -54.099987, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var bridgeb133 = new DynamicObject(3593, new Vector3(-1135.326782, 2704.253174, 45.827618), new Vector3(1.999997, 14.099998, -54.099987), 0, 0, player, 200, 150);
            bridgeb133.ShowInWorld(0);
            // CreateDynamicObject(933, -1149.420044, 2702.374023, 44.977207, 0.000000, 0.000000, 51.499992, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var bridgeb134 = new DynamicObject(933, new Vector3(-1149.420044, 2702.374023, 44.977207), new Vector3(0.000000, 0.000000, 51.499992), 0, 0, player, 200, 150);
            bridgeb134.ShowInWorld(0);
            //fso_map = CreateDynamicObject(12957, -969.894165, 2717.279785, 45.457191, 0.000000, 0.000000, -55.000008, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 2
            //SetDynamicObjectMaterial(fso_map, 1, 3115, "carrierxr", "ws_carrierdeckbase", 0);
            //SetDynamicObjectMaterial(fso_map, 0, 2956, "immcrax", "Metalox64", 0);
            var bridgeb135 = new DynamicObject(12957, new Vector3(-969.894165, 2717.279785, 45.457191), new Vector3(0.000000, 0.000000, -55.000008), 0, 0, player, 200, 150);
            bridgeb135.SetMaterial(1,3115,"carrierxr","ws_carrierdeckbase", 0);
            bridgeb135.SetMaterial(0, 2956, "immcrax", "Metalox64", 0);
            bridgeb135.ShowInWorld(0);

            //CreateDynamicObject(18269, 584.691345, 139.058365, 29.488359, -10.900004, -11.899983, 110.500153, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall1 = new DynamicObject(18269, new Vector3(584.691345, 139.058365, 29.488359), new Vector3(-10.900004, -11.899983, 110.500153), 0, 0, player, 200, 150);
            waterfall1.ShowInWorld(0);
            //CreateDynamicObject(18268, 632.580566, 128.976120, 32.572262, 0.000000, 0.000000, 112.700043, -1, -1, -1, STREAMER_OBJECT_SD, 550.0); // 0
            var waterfall2 = new DynamicObject(18268, new Vector3(632.580566, 128.976120, 32.572262), new Vector3(0.000000, 0.000000, 112.700043), 0, 0, player, 200, 150);
            waterfall2.ShowInWorld(0);
            //CreateDynamicObject(747, 636.809143, 111.383476, 7.198639, 0.000000, 0.000000, 101.100105, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall3 = new DynamicObject(747, new Vector3(636.809143, 111.383476, 7.198639), new Vector3(0.000000, 0.000000, 101.100105), 0, 0, player, 200, 150);
            waterfall3.ShowInWorld(0);
            //CreateDynamicObject(873, 608.037415, 135.089325, 8.404539, 6.599977, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall4 = new DynamicObject(873, new Vector3(608.037415, 135.089325, 8.404539), new Vector3(6.599977, 0.000000, 1.000000), 0, 0, player, 200, 150);
            waterfall4.ShowInWorld(0);
            //CreateDynamicObject(819, 603.273193, 131.819519, 7.663627, 0.000000, 0.000000, 53.999947, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall5 = new DynamicObject(819, new Vector3(603.273193, 131.819519, 7.663627), new Vector3(0.000000, 0.000000, 53.999947), 0, 0, player, 200, 150);
            waterfall5.ShowInWorld(0);
            //CreateDynamicObject(18568, 606.114929, 125.994530, 7.630869, -2.500003, -4.999997, 87.500053, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall6 = new DynamicObject(18568, new Vector3(606.114929, 125.994530, 7.630869), new Vector3(-2.500003, -4.999997, 87.500053), 0, 0, player, 200, 150);
            waterfall6.ShowInWorld(0);
            //CreateDynamicObject(873, 608.760315, 144.729675, 8.841343, 10.999979, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall7 = new DynamicObject(873, new Vector3(608.760315, 144.729675, 8.841343), new Vector3(10.999979, 0.000000, 1.000000), 0, 0, player, 200, 150);
            waterfall7.ShowInWorld(0);
            //CreateDynamicObject(12986, 607.096191, 123.792526, 8.280583, 3.600008, 0.000000, -2.600002, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall8 = new DynamicObject(12986, new Vector3(607.096191, 123.792526, 8.280583), new Vector3(3.600008, 0.000000, -2.600002), 0, 0, player, 200, 150);
            waterfall8.ShowInWorld(0);
            //CreateDynamicObject(873, 620.225952, 139.902786, 8.697538, 6.899972, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall9 = new DynamicObject(873, new Vector3(620.225952, 139.902786, 8.697538), new Vector3(6.899972, 0.000000, 1.000000), 0, 0, player, 200, 150);
            waterfall9.ShowInWorld(0);
            // CreateDynamicObject(819, 599.420105, 123.963882, 7.353628, 0.000000, 0.000000, 53.999947, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall10 = new DynamicObject(819, new Vector3(599.420105, 123.963882, 7.353628), new Vector3(0.000000, 0.000000, 53.999947), 0, 0, player, 200, 150);
            waterfall10.ShowInWorld(0);
            // CreateDynamicObject(810, 610.618835, 120.646385, 6.473177, 0.000000, 0.000000, -53.199989, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall11 = new DynamicObject(810, new Vector3(610.618835, 120.646385, 6.473177), new Vector3(0.000000, 0.000000, -53.199989), 0, 0, player, 200, 150);
            waterfall11.ShowInWorld(0);
            // CreateDynamicObject(745, 635.041565, 109.403000, 6.009204, 0.000000, 0.000000, 43.900009, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall12 = new DynamicObject(745, new Vector3(635.041565, 109.403000, 6.009204), new Vector3(0.000000, 0.000000, 43.900009), 0, 0, player, 200, 150);
            waterfall12.ShowInWorld(0);
            // CreateDynamicObject(747, 638.941040, 112.225151, 7.298641, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall13 = new DynamicObject(747, new Vector3(638.941040, 112.225151, 7.298641), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall13.ShowInWorld(0);
            // CreateDynamicObject(819, 606.219421, 118.178474, 6.243624, 0.000000, 0.000000, 152.099884, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall14 = new DynamicObject(819, new Vector3(606.219421, 118.178474, 6.243624), new Vector3(0.000000, 0.000000, 152.099884), 0, 0, player, 200, 150);
            waterfall14.ShowInWorld(0);
            // CreateDynamicObject(819, 599.434448, 116.721138, 6.455822, 0.000000, -10.799983, 53.999947, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall15 = new DynamicObject(819, new Vector3(599.434448, 116.721138, 6.455822), new Vector3(0.000000, -10.799983, 53.999947), 0, 0, player, 200, 150);
            waterfall15.ShowInWorld(0);
            // CreateDynamicObject(831, 608.061584, 112.483994, 6.386795, 4.999999, 0.000000, -33.500046, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall16 = new DynamicObject(831, new Vector3(608.061584, 112.483994, 6.386795), new Vector3(4.999999, 0.000000, -33.500046), 0, 0, player, 200, 150);
            waterfall16.ShowInWorld(0);
            // CreateDynamicObject(811, 632.107483, 135.785629, 10.476581, 0.000000, -2.900000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall17 = new DynamicObject(811, new Vector3(632.107483, 135.785629, 10.476581), new Vector3(0.000000, -2.900000, 0.000000), 0, 0, player, 200, 150);
            waterfall17.ShowInWorld(0);
            // CreateDynamicObject(19842, 636.680908, 100.705933, 6.184311, -9.800001, 0.000000, 50.999989, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall18 = new DynamicObject(19842, new Vector3(636.680908, 100.705933, 6.184311), new Vector3(-9.800001, 0.000000, 50.999989), 0, 0, player, 200, 150);
            waterfall18.ShowInWorld(0);
            // CreateDynamicObject(900, 629.041443, 94.328903, 5.874938, 0.000000, 0.000000, 158.800217, -1, -1, -1, STREAMER_OBJECT_SD, 450.0); // 0
            var waterfall19 = new DynamicObject(900, new Vector3(629.041443, 94.328903, 5.874938), new Vector3(0.000000, 0.000000, 158.800217), 0, 0, player, 200, 150);
            waterfall19.ShowInWorld(0);
            //  CreateDynamicObject(748, 644.973389, 105.738647, 7.058135, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall20 = new DynamicObject(748, new Vector3(644.973389, 105.738647, 7.058135), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            waterfall20.ShowInWorld(0);
            //  CreateDynamicObject(873, 592.004517, 112.057312, 5.772486, 6.599977, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall21 = new DynamicObject(873, new Vector3(592.004517, 112.057312, 5.772486), new Vector3(6.599977, 0.000000, 1.000000), 0, 0, player, 200, 150);
            waterfall21.ShowInWorld(0);
            // CreateDynamicObject(748, 644.510254, 102.656044, 7.038139, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall22 = new DynamicObject(748, new Vector3(644.510254, 102.656044, 7.038139), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            waterfall22.ShowInWorld(0);
            //  CreateDynamicObject(819, 645.988586, 103.295326, 7.664309, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall23 = new DynamicObject(819, new Vector3(645.988586, 103.295326, 7.664309), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall23.ShowInWorld(0);
            //  CreateDynamicObject(823, 650.331909, 105.921837, 9.952043, 16.300013, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall24 = new DynamicObject(823, new Vector3(650.331909, 105.921837, 9.952043), new Vector3(16.300013, 0.000000, -53.699982), 0, 0, player, 200, 150);
            waterfall24.ShowInWorld(0);
            //  CreateDynamicObject(18271, 600.672302, 111.478630, 27.372145, 0.000000, 0.000000, -169.300247, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall25 = new DynamicObject(18271, new Vector3(600.672302, 111.478630, 27.372145), new Vector3(0.000000, 0.000000, -169.300247), 0, 0, player, 200, 150);
            waterfall25.ShowInWorld(0);
            //  CreateDynamicObject(19840, 646.483948, 97.932259, 5.989109, -12.400012, 0.000000, -129.200180, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall26 = new DynamicObject(19840, new Vector3(646.483948, 97.932259, 5.989109), new Vector3(-12.400012, 0.000000, -129.200180), 0, 0, player, 200, 150);
            waterfall26.ShowInWorld(0);
            //  CreateDynamicObject(18269, 584.691345, 139.058365, 29.488359, -10.900004, -11.899983, 110.500153, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall27 = new DynamicObject(18269, new Vector3(584.691345, 139.058365, 29.488359), new Vector3(-10.900004, -11.899983, 110.500153), 0, 0, player, 200, 150);
            waterfall27.ShowInWorld(0);
            //  CreateDynamicObject(19840, 652.128540, 95.422844, 7.495713, -28.100065, 0.000000, -139.400162, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall28 = new DynamicObject(19840, new Vector3(652.128540, 95.422844, 7.495713), new Vector3(-28.100065, 0.000000, -139.400162), 0, 0, player, 200, 150);
            waterfall28.ShowInWorld(0);
            //  CreateDynamicObject(18271, 670.058167, 162.202118, 33.902176, 0.000000, 0.000000, 139.899689, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall29 = new DynamicObject(18271, new Vector3(670.058167, 162.202118, 33.902176), new Vector3(0.000000, 0.000000, 139.899689), 0, 0, player, 200, 150);
            waterfall29.ShowInWorld(0);
            //  CreateDynamicObject(823, 627.671509, 108.917091, 7.372014, 0.000000, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall30 = new DynamicObject(823, new Vector3(627.671509, 108.917091, 7.372014), new Vector3(0.000000, 0.000000, -53.699982), 0, 0, player, 200, 150);
            waterfall30.ShowInWorld(0);
            //  CreateDynamicObject(18268, 632.580566, 128.976120, 32.572262, 0.000000, 0.000000, 112.700043, -1, -1, -1, STREAMER_OBJECT_SD, 550.0); // 0
            var waterfall31 = new DynamicObject(18268, new Vector3(632.580566, 128.976120, 32.572262), new Vector3(0.000000, 0.000000, 112.700043), 0, 0, player, 200, 150);
            waterfall31.ShowInWorld(0);
            // CreateDynamicObject(823, 638.846802, 114.074333, 8.292024, 0.000000, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall32 = new DynamicObject(823, new Vector3(638.846802, 114.074333, 8.292024), new Vector3(0.000000, 0.000000, -53.699982), 0, 0, player, 200, 150);
            waterfall32.ShowInWorld(0);
            //  CreateDynamicObject(747, 636.809143, 111.383476, 7.198639, 0.000000, 0.000000, 101.100105, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall33 = new DynamicObject(747, new Vector3(636.809143, 111.383476, 7.198639), new Vector3(0.000000, 0.000000, 101.100105), 0, 0, player, 200, 150);
            waterfall33.ShowInWorld(0);
            //  CreateDynamicObject(745, 635.041565, 109.403000, 6.009204, 0.000000, 0.000000, 43.900009, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall34 = new DynamicObject(745, new Vector3(635.041565, 109.403000, 6.009204), new Vector3(0.000000, 0.000000, 43.900009), 0, 0, player, 200, 150);
            waterfall34.ShowInWorld(0);
            //  CreateDynamicObject(747, 638.941040, 112.225151, 7.298641, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall35 = new DynamicObject(747, new Vector3(638.941040, 112.225151, 7.298641), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall35.ShowInWorld(0);
            // CreateDynamicObject(744, 633.984619, 105.421783, 5.541283, 0.000000, 0.000000, -119.399979, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall36 = new DynamicObject(744, new Vector3(633.984619, 105.421783, 5.541283), new Vector3(0.000000, 0.000000, -119.399979), 0, 0, player, 200, 150);
            waterfall36.ShowInWorld(0);
            // CreateDynamicObject(744, 641.451172, 109.985519, 6.651288, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall37 = new DynamicObject(744, new Vector3(641.451172, 109.985519, 6.651288), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall37.ShowInWorld(0);
            // CreateDynamicObject(19840, 636.959656, 104.741341, 3.660635, 0.000000, 0.000000, -54.600075, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall38 = new DynamicObject(19840, new Vector3(636.959656, 104.741341, 3.660635), new Vector3(0.000000, 0.000000, -54.600075), 0, 0, player, 200, 150);
            waterfall38.ShowInWorld(0);
            // CreateDynamicObject(19840, 637.219604, 103.746078, 3.926028, -10.600004, 0.000000, -84.200264, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall39 = new DynamicObject(19840, new Vector3(637.219604, 103.746078, 3.926028), new Vector3(-10.600004, 0.000000, -84.200264), 0, 0, player, 200, 150);
            waterfall39.ShowInWorld(0);
            //CreateDynamicObject(18741, 639.034180, 104.104660, 5.966312, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall40 = new DynamicObject(18741, new Vector3(639.034180, 104.104660, 5.966312), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall40.ShowInWorld(0);
            //CreateDynamicObject(19840, 640.478577, 104.649033, 3.910635, 0.000000, 0.000000, 30.599873, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall41 = new DynamicObject(19840, new Vector3(640.478577, 104.649033, 3.910635), new Vector3(0.000000, 0.000000, 30.599873), 0, 0, player, 200, 150);
            waterfall41.ShowInWorld(0);
            // CreateDynamicObject(19840, 640.478577, 104.649033, 3.660635, 0.000000, 0.000000, 88.499878, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall42 = new DynamicObject(19840, new Vector3(640.478577, 104.649033, 3.660635), new Vector3(0.000000, 0.000000, 88.499878), 0, 0, player, 200, 150);
            waterfall42.ShowInWorld(0);
            // CreateDynamicObject(19842, 636.680908, 100.705933, 6.184311, -9.800001, 0.000000, 50.999989, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall43 = new DynamicObject(19842, new Vector3(636.680908, 100.705933, 6.184311), new Vector3(-9.800001, 0.000000, 50.999989), 0, 0, player, 200, 150);
            waterfall43.ShowInWorld(0);
            //CreateDynamicObject(748, 644.600159, 107.633759, 7.268137, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall44 = new DynamicObject(748, new Vector3(644.600159, 107.633759, 7.268137), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall44.ShowInWorld(0);
            // CreateDynamicObject(900, 629.041443, 94.328903, 5.874938, 0.000000, 0.000000, 158.800217, -1, -1, -1, STREAMER_OBJECT_SD, 450.0); // 0
            var waterfall45 = new DynamicObject(900, new Vector3(629.041443, 94.328903, 5.874938), new Vector3(0.000000, 0.000000, 158.800217), 0, 0, player, 200, 150);
            waterfall45.ShowInWorld(0);
            // CreateDynamicObject(748, 644.973389, 105.738647, 7.058135, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall46 = new DynamicObject(748, new Vector3(644.973389, 105.738647, 7.058135), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            waterfall46.ShowInWorld(0);
            // CreateDynamicObject(748, 645.023743, 104.044678, 7.058135, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall47 = new DynamicObject(748, new Vector3(645.023743, 104.044678, 7.058135), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            waterfall47.ShowInWorld(0);
            // CreateDynamicObject(748, 644.510254, 102.656044, 7.038139, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall48 = new DynamicObject(748, new Vector3(644.510254, 102.656044, 7.038139), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            waterfall48.ShowInWorld(0);
            // CreateDynamicObject(819, 645.988586, 103.295326, 7.664309, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall49 = new DynamicObject(819, new Vector3(645.988586, 103.295326, 7.664309), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall49.ShowInWorld(0);
            // CreateDynamicObject(823, 650.331909, 105.921837, 9.952043, 16.300013, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall50 = new DynamicObject(823, new Vector3(650.331909, 105.921837, 9.952043), new Vector3(16.300013, 0.000000, -53.699982), 0, 0, player, 200, 150);
            waterfall50.ShowInWorld(0);
            // CreateDynamicObject(18269, 621.041382, 90.476845, 30.704412, 0.000000, 0.000000, -174.700058, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall51 = new DynamicObject(18269, new Vector3(621.041382, 90.476845, 30.704412), new Vector3(0.000000, 0.000000, -174.700058), 0, 0, player, 200, 150);
            waterfall51.ShowInWorld(0);
            // CreateDynamicObject(748, 645.930847, 100.306152, 6.978138, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall52 = new DynamicObject(748, new Vector3(645.930847, 100.306152, 6.978138), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            waterfall52.ShowInWorld(0);
            // CreateDynamicObject(19840, 646.483948, 97.932259, 5.989109, -12.400012, 0.000000, -129.200180, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall53 = new DynamicObject(19840, new Vector3(646.483948, 97.932259, 5.989109), new Vector3(-12.400012, 0.000000, -129.200180), 0, 0, player, 200, 150);
            waterfall53.ShowInWorld(0);
            // CreateDynamicObject(823, 649.201599, 99.978813, 8.922026, 0.000000, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall54 = new DynamicObject(823, new Vector3(649.201599, 99.978813, 8.922026), new Vector3(0.000000, 0.000000, -53.699982), 0, 0, player, 200, 150);
            waterfall54.ShowInWorld(0);
            // CreateDynamicObject(819, 650.978943, 97.405319, 9.524314, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall55 = new DynamicObject(819, new Vector3(650.978943, 97.405319, 9.524314), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall55.ShowInWorld(0);
            // CreateDynamicObject(19840, 652.128540, 95.422844, 7.495713, -28.100065, 0.000000, -139.400162, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall56 = new DynamicObject(19840, new Vector3(652.128540, 95.422844, 7.495713), new Vector3(-28.100065, 0.000000, -139.400162), 0, 0, player, 200, 150);
            waterfall56.ShowInWorld(0);
            // CreateDynamicObject(19840, 652.078430, 93.522972, 8.327264, -13.100025, 0.000000, -121.299965, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall57 = new DynamicObject(19840, new Vector3(652.078430, 93.522972, 8.327264), new Vector3(-13.100025, 0.000000, -121.299965), 0, 0, player, 200, 150);
            waterfall57.ShowInWorld(0);
            // CreateDynamicObject(745, 648.537109, 89.582680, 8.577349, 0.000000, -28.699997, -56.899994, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall58 = new DynamicObject(745, new Vector3(648.537109, 89.582680, 8.577349), new Vector3(0.000000, -28.699997, -56.899994), 0, 0, player, 200, 150);
            waterfall58.ShowInWorld(0);
            // CreateDynamicObject(18747, 652.719421, 92.898064, 8.374566, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall59 = new DynamicObject(18747, new Vector3(652.719421, 92.898064, 8.374566), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall59.ShowInWorld(0);
            // CreateDynamicObject(744, 650.184875, 89.637444, 8.200315, 0.000000, 0.000000, -178.099869, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall60 = new DynamicObject(744, new Vector3(650.184875, 89.637444, 8.200315), new Vector3(0.000000, 0.000000, -178.099869), 0, 0, player, 200, 150);
            waterfall60.ShowInWorld(0);
            // CreateDynamicObject(18742, 651.894226, 91.012543, 6.507471, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall61 = new DynamicObject(18742, new Vector3(651.894226, 91.012543, 6.507471), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall61.ShowInWorld(0);
            // CreateDynamicObject(744, 655.182434, 93.622955, 10.470328, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall62 = new DynamicObject(744, new Vector3(655.182434, 93.622955, 10.470328), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall62.ShowInWorld(0);
            // CreateDynamicObject(19840, 653.643555, 91.464394, 9.986589, 9.899991, 0.000000, -113.299881, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall63 = new DynamicObject(19840, new Vector3(653.643555, 91.464394, 9.986589), new Vector3(9.899991, 0.000000, -113.299881), 0, 0, player, 200, 150);
            waterfall63.ShowInWorld(0);
            // CreateDynamicObject(745, 657.156555, 92.852562, 12.624348, -26.899965, 0.000000, 59.799984, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall64 = new DynamicObject(745, new Vector3(657.156555, 92.852562, 12.624348), new Vector3(-26.899965, 0.000000, 59.799984), 0, 0, player, 200, 150);
            waterfall64.ShowInWorld(0);
            // CreateDynamicObject(745, 653.838135, 88.058426, 12.017090, 0.000000, -28.699997, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall65 = new DynamicObject(745, new Vector3(653.838135, 88.058426, 12.017090), new Vector3(0.000000, -28.699997, 0.000000), 0, 0, player, 200, 150);
            waterfall65.ShowInWorld(0);
            // CreateDynamicObject(745, 656.569214, 90.938438, 12.855083, -26.899965, 0.000000, 59.799984, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall66 = new DynamicObject(745, new Vector3(656.569214, 90.938438, 12.855083), new Vector3(-26.899965, 0.000000, 59.799984), 0, 0, player, 200, 150);
            waterfall66.ShowInWorld(0);
            // CreateDynamicObject(744, 656.749573, 88.653137, 13.441802, 0.000000, -42.800026, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall67 = new DynamicObject(744, new Vector3(656.749573, 88.653137, 13.441802), new Vector3(0.000000, -42.800026, 0.000000), 0, 0, player, 200, 150);
            waterfall67.ShowInWorld(0);
            // CreateDynamicObject(719, 679.415710, 134.655609, 9.822523, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall68 = new DynamicObject(719, new Vector3(679.415710, 134.655609, 9.822523), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            waterfall68.ShowInWorld(0);
            // CreateDynamicObject(18271, 670.058167, 162.202118, 33.902176, 0.000000, 0.000000, 139.899689, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall69 = new DynamicObject(18271, new Vector3(670.058167, 162.202118, 33.902176), new Vector3(0.000000, 0.000000, 139.899689), 0, 0, player, 200, 150);
            waterfall69.ShowInWorld(0);



        }
        public void Remove()
        {
            GlobalObject.Remove(player, 3425, new Vector3(-466.429688, 2190.273438, 55.992199), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16777, -105.359, 1212.069, 18.734, 0.250);
            GlobalObject.Remove(player, 16777, new Vector3(-105.359, 1212.069, 18.734), 0.25f);

            //RemoveBuildingForPlayer(playerid, 1352, -109.944, 1188.020, 18.710, 0.250);
            GlobalObject.Remove(player, 16777, new Vector3(-105.359, 1212.069, 18.734), 0.25f);

            //RemoveBuildingForPlayer(playerid, 1352, -126.101, 1192.920, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-126.101, 1192.920, 18.710), 0.25f);

            //RemoveBuildingForPlayer(playerid, 1352, -180.108, 1203.900, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-180.108, 1203.900, 18.710), 0.25f);
            // RemoveBuildingForPlayer(playerid, 1352, -206.070, 1192.920, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-206.070, 1192.920, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -201.195, 1208.800, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-201.195, 1208.800, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -201.046, 1108.900, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-201.046, 1108.900, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -205.921, 1093.020, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-205.921, 1093.020, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -180.266, 1103.910, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-180.266, 1103.910, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -185.179, 1087.839, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-185.179, 1087.839, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -264.906, 1103.989, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-264.906, 1103.989, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -281.070, 1108.900, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-281.070, 1108.900, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -285.937, 1093.020, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-285.937, 1093.020, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -269.781, 1088.109, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-269.781, 1088.109, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 652, 71.179, 1182.170, 16.265, 0.250);
            GlobalObject.Remove(player, 652, new Vector3(71.179, 1182.170, 16.265), 0.25f);
            //RemoveBuildingForPlayer(playerid, 652, 59.039, 1181.680, 16.265, 0.250);
            GlobalObject.Remove(player, 652, new Vector3(59.039, 1181.680, 16.265), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1413, 72.085, 1206.880, 18.992, 0.250);
            GlobalObject.Remove(player, 1413, new Vector3(72.085, 1206.880, 18.992), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1413, 77.359, 1206.880, 18.992, 0.250);
            GlobalObject.Remove(player, 1413, new Vector3(77.359, 1206.880, 18.992), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1413, 66.796, 1207.160, 18.992, 0.250);
            GlobalObject.Remove(player, 1413, new Vector3(66.796, 1207.160, 18.992), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1413, 73.093, 1228.040, 19.078, 0.250);
            GlobalObject.Remove(player, 1413, new Vector3(73.093, 1228.040, 19.078), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1413, 78.257, 1226.849, 19.367, 0.250);
            GlobalObject.Remove(player, 1413, new Vector3(78.257, 1226.849, 19.367), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1413, 83.281, 1225.270, 19.820, 0.250);
            GlobalObject.Remove(player, 1413, new Vector3(83.281, 1225.270, 19.820), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, 49.140, 1193.640, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(49.140, 1193.640, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, 49.140, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(49.140, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, 20.914, 1193.640, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(20.914, 1193.640, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, 20.914, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(20.914, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -11.765, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-11.765, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -0.148, 1193.640, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-0.148, 1193.640, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -25.781, 1193.640, 22.812, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-25.781, 1193.640, 22.812), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -37.976, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-37.976, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -65.898, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-65.898, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -81.718, 1193.640, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-81.718, 1193.640, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -96.078, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-96.078, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -105.069, 1203.900, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-105.069, 1203.900, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -121.234, 1208.800, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-121.234, 1208.800, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -120.491, 1183.349, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-120.491, 1183.349, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -110.780, 1158.739, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-110.780, 1158.739, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -220.039, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-220.039, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -220.039, 1193.640, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-220.039, 1193.640, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -250.218, 1202.880, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-250.218, 1202.880, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -250.218, 1193.640, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-250.218, 1193.640, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1294, -280.226, 1184.750, 23.203, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-280.226, 1184.750, 23.203), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16781, -144.054, 1227.300, 18.898, 0.250);
            GlobalObject.Remove(player, 16781, new Vector3(-144.054, 1227.300, 18.898), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16506, -144.054, 1227.300, 18.898, 0.250);
            GlobalObject.Remove(player, 16506, new Vector3(-144.054, 1227.300, 18.898), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1345, -155.695, 1234.420, 19.476, 0.250);
            GlobalObject.Remove(player, 1345, new Vector3(-155.695, 1234.420, 19.476), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16776, -237.022, 2662.840, 62.609, 0.250);
            GlobalObject.Remove(player, 16776, new Vector3(-237.022, 2662.840, 62.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16066, -186.483, 1217.630, 20.562, 0.250);
            GlobalObject.Remove(player, 16066, new Vector3(-186.483, 1217.630, 20.562), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1308, -225.733, 1208.810, 17.367, 0.250);
            GlobalObject.Remove(player, 1308, new Vector3(-225.733, 1208.810, 17.367), 0.25f);
            //BAR REMOVE

            //RemoveBuildingForPlayer(playerid, 2681, 504.835, -81.171, 997.960, 0.250);
            GlobalObject.Remove(player, 2681, new Vector3(504.835, -81.171, 997.960), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2778, 504.820, -79.929, 997.960, 0.250);
            GlobalObject.Remove(player, 2778, new Vector3(504.820, -79.929, 997.960), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2964, 506.484, -84.835, 997.937, 0.250);
            GlobalObject.Remove(player, 2964, new Vector3(506.484, -84.835, 997.937), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2964, 510.101, -84.835, 997.937, 0.250);
            GlobalObject.Remove(player, 2964, new Vector3(510.101, -84.835, 997.937), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2232, 507.179, -88.390, 998.539, 0.250);
            GlobalObject.Remove(player, 2232, new Vector3(507.179, -88.390, 998.539), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2232, 510.523, -88.257, 998.539, 0.250);
            GlobalObject.Remove(player, 2232, new Vector3(510.523, -88.257, 998.539), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2691, 504.375, -81.328, 1000.409, 0.250);
            GlobalObject.Remove(player, 2691, new Vector3(504.375, -81.328, 1000.409), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2696, 512.390, -85.242, 999.734, 0.250);
            GlobalObject.Remove(player, 2696, new Vector3(512.390, -85.242, 999.734), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2659, 512.382, -86.664, 1000.849, 0.250);
            GlobalObject.Remove(player, 2659, new Vector3(512.382, -86.664, 1000.849), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2660, 509.851, -89.078, 1000.919, 0.250);
            GlobalObject.Remove(player, 2660, new Vector3(509.851, -89.078, 1000.919), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2662, 507.507, -89.070, 1000.460, 0.250);
            GlobalObject.Remove(player, 2662, new Vector3(507.507, -89.070, 1000.460), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2695, 505.359, -89.078, 1000.010, 0.250);
            GlobalObject.Remove(player, 2695, new Vector3(505.359, -89.078, 1000.010), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2657, 504.343, -88.031, 999.054, 0.250);
            GlobalObject.Remove(player, 2657, new Vector3(504.343, -88.031, 999.054), 0.25f);

            //RemoveBuildingForPlayer(playerid, 2670, 505.492, -81.296, 998.070, 0.250);
            GlobalObject.Remove(player, 2670, new Vector3(505.492, -81.296, 998.070), 0.25f);
            //fk 11 removes
            //RemoveBuildingForPlayer(playerid, 16735, -49.242, 1137.699, 28.781, 0.250);
            GlobalObject.Remove(player, 16735, new Vector3(-49.242, 1137.699, 28.781), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16736, 11.015, 959.882, 24.703, 0.250);
            GlobalObject.Remove(player, 16736, new Vector3(11.015, 959.882, 24.703), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16737, -94.617, 923.289, 26.179, 0.250);
            GlobalObject.Remove(player, 16737, new Vector3(-94.617, 923.289, 26.179), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16738, -217.492, 1026.819, 27.679, 0.250);
            GlobalObject.Remove(player, 16738, new Vector3(-217.492, 1026.819, 27.679), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16739, -297.101, 1152.969, 27.007, 0.250);
            GlobalObject.Remove(player, 16739, new Vector3(-297.101, 1152.969, 27.007), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16740, -152.320, 1144.069, 30.304, 0.250);
            GlobalObject.Remove(player, 16740, new Vector3(-152.320, 1144.069, 30.304), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16742, 207.429, 1077.300, 31.914, 0.250);
            GlobalObject.Remove(player, 16742, new Vector3(207.429, 1077.300, 31.914), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16743, 266.445, 1225.290, 32.281, 0.250);
            GlobalObject.Remove(player, 16743, new Vector3(266.445, 1225.290, 32.281), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16744, 351.984, 1368.900, 20.109, 0.250);
            GlobalObject.Remove(player, 16744, new Vector3(351.984, 1368.900, 20.109), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16745, 392.914, 1511.560, 21.585, 0.250);
            GlobalObject.Remove(player, 16745, new Vector3(392.914, 1511.560, 21.585), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16746, 472.687, 1639.569, 13.765, 0.250);
            GlobalObject.Remove(player, 16746, new Vector3(472.687, 1639.569, 13.765), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16442, -18.468, 1178.880, 29.375, 0.250);
            GlobalObject.Remove(player, 16442, new Vector3(-18.468, 1178.880, 29.375), 0.25f);
            //RemoveBuildingForPlayer(playerid, 956, -76.031, 1227.989, 19.125, 0.250);
            GlobalObject.Remove(player, 956, new Vector3(-76.031, 1227.989, 19.125), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16475, -98.195, 1180.069, 18.734, 0.250);
            GlobalObject.Remove(player, 16475, new Vector3(-98.195, 1180.069, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16476, -98.195, 1180.069, 18.734, 0.250);
            GlobalObject.Remove(player, 16476, new Vector3(-98.195, 1180.069, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1308, -96.718, 1164.349, 18.734, 0.250);
            GlobalObject.Remove(player, 1308, new Vector3(-96.718, 1164.349, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1345, -88.859, 1165.380, 19.460, 0.250);
            GlobalObject.Remove(player, 1345, new Vector3(-88.859, 1165.380, 19.460), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1308, -76.531, 1187.640, 18.734, 0.250);
            GlobalObject.Remove(player, 1308, new Vector3(-76.531, 1187.640, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16337, 713.804, 906.812, -19.914, 0.250);
            GlobalObject.Remove(player, 16337, new Vector3(713.804, 906.812, -19.914), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16334, 709.445, 915.929, 34.617, 0.250);
            GlobalObject.Remove(player, 16334, new Vector3(709.445, 915.929, 34.617), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1345, -170.171, 1169.050, 19.539, 0.250);
            GlobalObject.Remove(player, 1345, new Vector3(-170.171, 1169.050, 19.539), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1692, -174.242, 1177.900, 22.781, 0.250);
            GlobalObject.Remove(player, 1692, new Vector3(-174.242, 1177.900, 22.781), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1352, -109.944, 1188.020, 18.710, 0.250);
            GlobalObject.Remove(player, 1352, new Vector3(-109.944, 1188.020, 18.710), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16777, -105.359, 1212.069, 18.734, 0.250);
            GlobalObject.Remove(player, 16777, new Vector3(-105.359, 1212.069, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1308, 292.898, 1237.150, 14.859, 0.250);
            GlobalObject.Remove(player, 1308, new Vector3(292.898, 1237.150, 14.859), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16385, -122.741, 1122.750, 18.734, 0.250);
            GlobalObject.Remove(player, 16385, new Vector3(-122.741, 1122.750, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 16617, -122.741, 1122.750, 18.734, 0.250);
            GlobalObject.Remove(player, 16617, new Vector3(-122.741, 1122.750, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1412, -133.852, 1134.410, 20.023, 0.250);
            GlobalObject.Remove(player, 1412, new Vector3(-133.852, 1134.410, 20.023), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1308, -133.358, 1137.589, 18.734, 0.250);
            GlobalObject.Remove(player, 1308, new Vector3(-133.358, 1137.589, 18.734), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1412, -133.983, 1111.079, 20.023, 0.250);
            GlobalObject.Remove(player, 1412, new Vector3(-133.983, 1111.079, 20.023), 0.25f);
            //RemoveBuildingForPlayer(playerid, 669, -120.875, 1110.420, 18.679, 0.250);
            GlobalObject.Remove(player, 669, new Vector3(-120.875, 1110.420, 18.679), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1411, -136.539, 1108.229, 20.335, 0.250);
            GlobalObject.Remove(player, 1411, new Vector3(-136.539, 1108.229, 20.335), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1411, -141.733, 1108.229, 20.335, 0.250);
            GlobalObject.Remove(player, 1411, new Vector3(-141.733, 1108.229, 20.335), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1411, -146.929, 1108.229, 20.335, 0.250);
            GlobalObject.Remove(player, 1411, new Vector3(-146.929, 1108.229, 20.335), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1345, -149.852, 1133.770, 19.539, 0.250);
            GlobalObject.Remove(player, 1345, new Vector3(-149.852, 1133.770, 19.539), 0.25f);
            //RemoveBuildingForPlayer(playerid, 669, -228.828, 1050.750, 18.812, 0.250);
            GlobalObject.Remove(player, 669, new Vector3(-228.828, 1050.750, 18.812), 0.25f);
            //RemoveBuildingForPlayer(playerid, 669, -233.117, 1061.660, 18.859, 0.250);
            GlobalObject.Remove(player, 669, new Vector3(-233.117, 1061.660, 18.859), 0.25f);
            //fk 11 removes up
            //SHELTER REMOVES DOWN
            //RemoveBuildingForPlayer(playerid, 17566, 2520.729, -1673.839, 15.546, 0.250);
            GlobalObject.Remove(player, 17566, new Vector3(2520.729, -1673.839, 15.546), 0.25f);

            //RemoveBuildingForPlayer(playerid, 1776, 2202.449, 1617.010, 1000.059, 0.250);
            GlobalObject.Remove(player, 1776, new Vector3(2202.449, 1617.010, 1000.059), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1776, 2209.239, 1621.209, 1000.059, 0.250);
            GlobalObject.Remove(player, 1776, new Vector3(2209.239, 1621.209, 1000.059), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1776, 2222.370, 1602.640, 1000.059, 0.250);
            GlobalObject.Remove(player, 1776, new Vector3(2222.370, 1602.640, 1000.059), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2670, 2222.389, 1606.910, 999.062, 0.250);
            GlobalObject.Remove(player, 2670, new Vector3(2222.389, 1606.910, 999.062), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1775, 2222.199, 1606.770, 1000.049, 0.250);
            GlobalObject.Remove(player, 1775, new Vector3(2222.199, 1606.770, 1000.049), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2002, 2222.469, 1601.800, 998.960, 0.250);
            GlobalObject.Remove(player, 2002, new Vector3(2222.469, 1601.800, 998.960), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2002, 2211.000, 1621.109, 998.960, 0.250);
            GlobalObject.Remove(player, 2002, new Vector3(2211.000, 1621.109, 998.960), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1775, 2209.909, 1607.199, 1000.049, 0.250);
            GlobalObject.Remove(player, 1775, new Vector3(2209.909, 1607.199, 1000.049), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2681, 2206.729, 1615.770, 998.968, 0.250);
            GlobalObject.Remove(player, 2681, new Vector3(2206.729, 1615.770, 998.968), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2002, 2198.929, 1607.089, 998.953, 0.250);
            GlobalObject.Remove(player, 2002, new Vector3(2198.929, 1607.089, 998.953), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2197.300, 1609.229, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2197.300, 1609.229, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2198.510, 1609.229, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2198.510, 1609.229, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2201.810, 1609.209, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2201.810, 1609.209, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2203.020, 1609.209, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2203.020, 1609.209, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2208.229, 1609.229, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2208.229, 1609.229, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2209.439, 1609.229, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2209.439, 1609.229, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2197.280, 1610.599, 999.765, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2197.280, 1610.599, 999.765), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2197.239, 1613.130, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2197.239, 1613.130, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2197.250, 1614.930, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2197.250, 1614.930, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2198.510, 1611.069, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2198.510, 1611.069, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2203.020, 1611.040, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2203.020, 1611.040, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2201.810, 1611.040, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2201.810, 1611.040, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2198.449, 1613.130, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2198.449, 1613.130, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2201.820, 1613.030, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2201.820, 1613.030, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2203.020, 1612.989, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2203.020, 1612.989, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2198.449, 1614.959, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2198.449, 1614.959, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2201.820, 1614.770, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2201.820, 1614.770, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2203.020, 1614.819, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2203.020, 1614.819, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2209.459, 1613.000, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2209.459, 1613.000, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2209.439, 1611.050, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2209.439, 1611.050, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2208.260, 1613.000, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2208.260, 1613.000, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2208.229, 1611.050, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2208.229, 1611.050, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2209.459, 1614.839, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2209.459, 1614.839, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2208.270, 1614.839, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2208.270, 1614.839, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2198.800, 1617.000, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2198.800, 1617.000, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2197.889, 1617.000, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2197.889, 1617.000, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2203.189, 1617.000, 999.609, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2203.189, 1617.000, 999.609), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2222.320, 1610.260, 999.585, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2222.320, 1610.260, 999.585), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2222.320, 1611.020, 999.585, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2222.320, 1611.020, 999.585), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2219.050, 1613.020, 999.578, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2219.050, 1613.020, 999.578), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1811, 2219.050, 1613.979, 999.578, 0.250);
            GlobalObject.Remove(player, 1811, new Vector3(2219.050, 1613.979, 999.578), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1737, 2201.929, 1610.130, 998.953, 0.250);
            GlobalObject.Remove(player, 1737, new Vector3(2201.929, 1610.130, 998.953), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1737, 2197.419, 1610.160, 998.953, 0.250);
            GlobalObject.Remove(player, 1737, new Vector3(2197.419, 1610.160, 998.953), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1737, 2208.350, 1610.130, 998.953, 0.250);
            GlobalObject.Remove(player, 1737, new Vector3(2208.350, 1610.130, 998.953), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1737, 2197.360, 1614.050, 998.953, 0.250);
            GlobalObject.Remove(player, 1737, new Vector3(2197.360, 1614.050, 998.953), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1737, 2201.929, 1613.910, 998.953, 0.250);
            GlobalObject.Remove(player, 1737, new Vector3(2201.929, 1613.910, 998.953), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1737, 2208.379, 1613.910, 998.953, 0.250);
            GlobalObject.Remove(player, 1737, new Vector3(2208.379, 1613.910, 998.953), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2219.040, 1596.660, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2219.040, 1596.660, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 923, 2215.689, 1595.239, 999.843, 0.250);
            GlobalObject.Remove(player, 923, new Vector3(2215.689, 1595.239, 999.843), 0.25f);
            //RemoveBuildingForPlayer(playerid, 923, 2215.669, 1593.199, 999.851, 0.250);
            GlobalObject.Remove(player, 923, new Vector3(2215.669, 1593.199, 999.851), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2232.679, 1595.420, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2232.679, 1595.420, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 922, 2204.040, 1589.819, 999.859, 0.250);
            GlobalObject.Remove(player, 922, new Vector3(2204.040, 1589.819, 999.859), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1221, 2203.979, 1589.729, 1000.359, 0.250);
            GlobalObject.Remove(player, 1221, new Vector3(2203.979, 1589.729, 1000.359), 0.25f);
            //RemoveBuildingForPlayer(playerid, 922, 2198.899, 1589.819, 999.859, 0.250);
            GlobalObject.Remove(player, 922, new Vector3(2198.899, 1589.819, 999.859), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2178.159, 1578.699, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2178.159, 1578.699, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2169.719, 1578.699, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2169.719, 1578.699, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2184.939, 1578.699, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2184.939, 1578.699, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2184.699, 1591.270, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2184.699, 1591.270, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2192.219, 1578.699, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2192.219, 1578.699, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 2567, 2192.379, 1591.270, 1000.880, 0.250);
            GlobalObject.Remove(player, 2567, new Vector3(2192.379, 1591.270, 1000.880), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1221, 2179.169, 1593.589, 999.414, 0.250);
            GlobalObject.Remove(player, 1221, new Vector3(2179.169, 1593.589, 999.414), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1221, 2178.149, 1593.589, 999.414, 0.250);
            GlobalObject.Remove(player, 1221, new Vector3(2178.149, 1593.589, 999.414), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1221, 2178.399, 1593.589, 1000.340, 0.250);
            GlobalObject.Remove(player, 1221, new Vector3(2178.399, 1593.589, 1000.340), 0.25f);
            //RemoveBuildingForPlayer(playerid, 1220, 2178.199, 1593.630, 1001.159, 0.250);
            GlobalObject.Remove(player, 1220, new Vector3(2178.199, 1593.630, 1001.159), 0.25f);
            //RemoveBuildingForPlayer(playerid, 923, 2172.479, 1591.359, 999.843, 0.250);
            GlobalObject.Remove(player, 923, new Vector3(2172.479, 1591.359, 999.843), 0.25f);
        }
    }
}
