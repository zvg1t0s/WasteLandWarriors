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
using System.Security.Cryptography.X509Certificates;

namespace WasteLandWarriors.WorldObjects
{
    internal class PlayerMappingObjects
    {
        BasePlayer player;
        public PlayerMappingObjects(BasePlayer p) { 
            player = p;

        }
        public static void DisposeAll(Player p)
        {
            DynamicObject.All.Where(x => x.Player == p).ToList().ForEach(x => x.Dispose());
        }
        public void CreateNShow()
        {
            var bar1 = new DynamicObject(19433, new Vector3(505.475189, -78.922294, 1003.211303), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            bar1.SetMaterial(0, 3922, "bistro", "sw_wallbrick_01", 0);
            
            var bar2 = new DynamicObject(19376, new Vector3(511.085784, -78.926460, 999.708374), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            bar2.SetMaterial(0, 3922, "bistro", "sw_wallbrick_01", 0);
            


            //CreateDynamicObject(2205, 510.326538, -81.602119, 997.940856, 0.000000, 0.000000, 107.400016, 1011, object_int, -1, 300.00, 300.00); 
            var bar3 = new DynamicObject(2205, new Vector3(510.326538, -81.602119, 997.940856), new Vector3(0.000000, 0.000000, 107.400016), 1002, 11, player, 25, 25);
            
            //CreateDynamicObject(1671, 511.589538, -80.387573, 998.391113, 0.000000, 0.000000, -54.700004, 1011, object_int, -1, 300.00, 300.00); 
            var bar4 = new DynamicObject(1671, new Vector3(511.589538, -80.387573, 998.391113), new Vector3(0.000000, 0.000000, -54.700004), 1002, 11, player, 25, 25);
            
            //CreateDynamicObject(1728, 511.626251, -85.992668, 997.900878, 0.000000, 0.000000, -109.900039, 1011, object_int, -1, 300.00, 300.00);
            var bar5 = new DynamicObject(1728, new Vector3(511.626251, -85.992668, 997.900878), new Vector3(0.000000, 0.000000, -109.900039), 1002, 11, player, 25, 25);
            
            //CreateDynamicObject(2083, 509.925415, -85.762634, 997.830627, 0.000000, 0.000000, -129.800018, 1011, object_int, -1, 300.00, 300.00);
            var bar6 = new DynamicObject(2083, new Vector3(509.925415, -85.762634, 997.830627), new Vector3(0.000000, 0.000000, -129.800018), 1002, 11, player, 25, 25);
            
            //CreateDynamicObject(1729, 509.318237, -88.108978, 997.910888, 0.000000, 0.000000, 162.700042, 1011, object_int, -1, 300.00, 300.00); 
            var bar7 = new DynamicObject(1729, new Vector3(509.318237, -88.108978, 997.910888), new Vector3(0.000000, 0.000000, 162.700042), 1002, 11, player, 25, 25);
            
            //CreateDynamicObject(1575, 510.075561, -86.646141, 998.301269, 0.000000, 0.000000, 57.100006, 1011, object_int, -1, 300.00, 300.00); 
            var bar8 = new DynamicObject(1575, new Vector3(510.075561, -86.646141, 998.301269), new Vector3(0.000000, 0.000000, 57.100006), 1002, 11, player, 25, 25);
           
            //CreateDynamicObject(335, 510.063659, -86.532058, 998.660644, 178.699996, -6.399999, -12.599999, 1011, object_int, -1, 300.00, 300.00); 
            var bar9 = new DynamicObject(335, new Vector3(510.063659, -86.532058, 998.660644), new Vector3(178.699996, -6.399999, -12.599999), 1002, 11, player, 25, 25);
            
            //CreateDynamicObject(19177, 510.096099, -86.580162, 998.481018, 0.000000, 0.000000, 0.000000, 1011, object_int, -1, 300.00, 300.00); 
            var bar10 = new DynamicObject(19177, new Vector3(510.096099, -86.580162, 998.481018), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19177, 510.216217, -86.320182, 998.340881, 0.000000, 0.000000, 0.000000, 1011, object_int, -1, 300.00, 300.00); 
            var bar11 = new DynamicObject(19177, new Vector3(510.216217, -86.320182, 998.340881), new Vector3(0.0, 0.0, 0.0), 1002, 11, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(3109, 505.189270, -89.185325, 999.141174, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar12 = new DynamicObject(3109, new Vector3(505.189270, -89.185325, 999.141174), new Vector3(0.0, 0.0, -90.0), 1002, 11, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(348, 510.340576, -80.542182, 998.911010, 270.000000, -166.199981, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar13 = new DynamicObject(348, new Vector3(510.340576, -80.542182, 998.911010), new Vector3(270.000000, -166.199981, 0.000000), 1002, 11, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19893, 510.302368, -81.220336, 998.871154, 0.000000, 0.000000, 133.500000, object_world, object_int, -1, 300.00, 300.00); 
            var bar14 = new DynamicObject(19893, new Vector3(510.302368, -81.220336, 998.871154), new Vector3(0.0, 0.0, 133.5), 1002, 11, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1550, 509.668945, -79.683685, 998.398986, 15.200001, 0.000000, 38.900001, object_world, object_int, -1, 300.00, 300.00); 
            var bar15 = new DynamicObject(1550, new Vector3(509.668945, -79.683685, 998.398986), new Vector3(15.200001, 0.000000, 38.900001), 1002, 11, player, 25, 25);
           
            //tmpobjid = CreateDynamicObject(2059, 510.137420, -80.590240, 998.881835, 0.000000, 0.000000, -51.000007, object_world, object_int, -1, 300.00, 300.00); 
            var bar16 = new DynamicObject(2059, new Vector3(510.137420, -80.590240, 998.881835), new Vector3(0.000000, 0.000000, -51.000007), 1002, 11, player, 25, 25);
           
            //tmpobjid = CreateDynamicObject(1665, 510.132781, -80.162391, 998.891845, 0.000000, 0.000000, 58.299995, object_world, object_int, -1, 300.00, 300.00); 
            var bar17 = new DynamicObject(1665, new Vector3(510.132781, -80.162391, 998.891845), new Vector3(0.000000, 0.000000, 58.299995), 1002, 11, player, 25, 25);
           
            //tmpobjid = CreateDynamicObject(18673, 510.059875, -80.152351, 997.350585, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar18 = new DynamicObject(18673, new Vector3(510.059875, -80.152351, 997.350585), new Vector3(0.0, 0.0, 0.0), 1002, 11, player, 25, 25);
        
            //tmpobjid = CreateDynamicObject(1893, 510.169097, -81.358398, 1002.201416, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var bar19 = new DynamicObject(1893, new Vector3(510.169097, -81.358398, 1002.201416), new Vector3(0.0, 0.0, 90.0), 1002, 11, player, 25, 25);
            
            //____________________________________________________________________SHOP MAPP______________________________________________________________
            //tmpobjid = CreateDynamicObject(19379, 1330.697998, 1363.093750, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "des_tunnellight", 0x00000000);
            var shop1 = new DynamicObject(19379, new Vector3(1330.697998, 1363.093750, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop1.SetMaterial(0, 16640, "a51", "des_tunnellight", 0);
            

            //tmpobjid = CreateDynamicObject(19379, 1324.976562, 1358.404785, 3000.029541, 0.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop2 = new DynamicObject(19379, new Vector3(1324.976562, 1358.404785, 3000.029541), new Vector3(0.000000, 180.000000, 0.000000), 1003, 1, player, 25, 25);
            shop2.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            

            //tmpobjid = CreateDynamicObject(19379, 1335.397216, 1358.404785, 3000.029541, 90.000000, 180.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "des_tunnellight", 0x00000000);
            var shop3 = new DynamicObject(19379, new Vector3(1335.397216, 1358.404785, 3000.029541), new Vector3(90.000000, 180.000000, 0.000000), 1003, 1, player, 25, 25);
            shop3.SetMaterial(0, 16640, "a51", "des_tunnellight", 0);
            

            //tmpobjid = CreateDynamicObject(19379, 1330.187500, 1353.653564, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop4 = new DynamicObject(19379, new Vector3(1330.187500, 1353.653564, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop4.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            

            //tmpobjid = CreateDynamicObject(19379, 1333.060546, 1362.302246, 3000.029541, -90.000000, 315.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop5 = new DynamicObject(19379, new Vector3(1333.060546, 1362.302246, 3000.029541), new Vector3(-90.000000, 315.000000, 0.000000), 1003, 1, player, 25, 25);
            shop5.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            
            //tmpobjid = CreateDynamicObject(19379, 1330.095947, 1358.404785, 3003.939208, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 11301, "carshow_sfse", "ws_officy_ceiling", 0x00000000);
            var shop6 = new DynamicObject(19379, new Vector3(1330.095947, 1358.404785, 3003.939208), new Vector3(0.000000, 90.000000, 0.000000), 1003, 1, player, 25, 25);
            shop6.SetMaterial(0, 11301, "carshow_sfse", "ws_officy_ceiling", 0);
            

            //tmpobjid = CreateDynamicObject(19379, 1337.008422, 1363.023925, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop7 = new DynamicObject(19379, new Vector3(1337.008422, 1363.023925, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop7.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            

            //tmpobjid = CreateDynamicObject(19379, 1320.377929, 1363.023925, 3000.029541, -90.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop8 = new DynamicObject(19379, new Vector3(1320.377929, 1363.023925, 3000.029541), new Vector3(-90.000000, 270.000000, 0.000000), 1003, 1, player, 25, 25);
            shop8.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            
            //tmpobjid = CreateDynamicObject(19379, 1335.328002, 1364.022827, 3000.029541, -90.000000, 270.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop9 = new DynamicObject(19379, new Vector3(1335.328002, 1364.022827, 3000.029541), new Vector3(-90.000000, 270.000000, 90.000000), 1003, 1, player, 25, 25);
            shop9.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            
            //tmpobjid = CreateDynamicObject(19379, 1335.328002, 1349.572509, 3000.029541, -90.000000, 270.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0x00000000);
            var shop10 = new DynamicObject(19379, new Vector3(1335.328002, 1349.572509, 3000.029541), new Vector3(-90.000000, 270.000000, 90.000000), 1003, 1, player, 25, 25);
            shop10.SetMaterial(0, 5406, "jeffers5a_lae", "vgshopwall05_64", 0);
            
            //tmpobjid = CreateDynamicObject(14902, 1329.656372, 1377.856445, 3000.035400, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            //tmpobjid = CreateDynamicObject(14902, 1320.457275, 1364.107666, 3000.035400, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 

            //tmpobjid = CreateDynamicObject(14902, 1329.656372, 1377.856445, 3000.035400, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop11 = new DynamicObject(14902, new Vector3(1329.656372, 1377.876464, 3000.035400), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(14902, 1320.457275, 1364.107666, 3000.035400, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop12 = new DynamicObject(14902, new Vector3(1320.457275, 1364.107666, 3000.035400), new Vector3(0.000000, 0.000000, 270.000000), 1003, 1, player, 25, 25);
            

            //tmpobjid = CreateDynamicObject(1532, 1333.204711, 1362.015747, 3000.095458, 0.000000, 0.000000, -45.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop13 = new DynamicObject(1532, new Vector3(1333.204711, 1362.015747, 3000.095458), new Vector3(0.000000, 0.000000, -45.000000), 1003, 1, player, 25, 25);
            

            //tmpobjid = CreateDynamicObject(2582, 1335.048950, 1357.887695, 3000.956298, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop14 = new DynamicObject(2582, new Vector3(1335.048950, 1357.887695, 3000.956298), new Vector3(0.000000, 0.000000, 270.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1893, 1332.182373, 1355.174072, 3004.317138, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop15 = new DynamicObject(1893, new Vector3(1332.182373, 1355.174072, 3004.317138), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1893, 1332.182373, 1359.994628, 3004.317138, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop16 = new DynamicObject(1893, new Vector3(1332.182373, 1359.994628, 3004.317138), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            

            //tmpobjid = CreateDynamicObject(1893, 1326.941040, 1355.174072, 3004.337158, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop17 = new DynamicObject(1893, new Vector3(1326.941040, 1355.174072, 3004.337158), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            

            //tmpobjid = CreateDynamicObject(1893, 1326.911987, 1359.995605, 3004.083496, 0.000000, -12.000000, -5.999999, object_world, object_int, -1, 300.00, 300.00); 
            var shop18 = new DynamicObject(1893, new Vector3(1326.911987, 1359.995605, 3004.083496), new Vector3(0.000000, -12.000000, -5.999999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2582, 1335.048950, 1355.907104, 3000.956298, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop19 = new DynamicObject(2582, new Vector3(1335.048950, 1355.907104, 3000.956298), new Vector3(0.000000, 0.000000, 270.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(11706, 1334.541015, 1360.332885, 3000.306152, 87.700012, -33.399997, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop20 = new DynamicObject(11706, new Vector3(1334.541015, 1360.332885, 3000.306152), new Vector3(87.700012, -33.399997, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1984, 1328.613647, 1356.336425, 3000.105468, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop21 = new DynamicObject(1984, new Vector3(1328.613647, 1356.336425, 3000.105468), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1850, 1329.979736, 1354.135498, 3000.045410, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop22 = new DynamicObject(1850, new Vector3(1329.979736, 1354.135498, 3000.045410), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1850, 1326.920288, 1354.135498, 3000.045410, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop23 = new DynamicObject(1850, new Vector3(1326.920288, 1354.135498, 3000.045410), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1843, 1325.734252, 1356.451293, 3000.035400, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop24 = new DynamicObject(1843, new Vector3(1325.734252, 1356.451293, 3000.035400), new Vector3(0.000000, 0.000000, 90.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2365, 1332.344360, 1354.440551, 3000.095458, 0.000000, 0.000000, 23.400003, object_world, object_int, -1, 300.00, 300.00); 
            var shop25 = new DynamicObject(2365, new Vector3(1332.344360, 1354.440551, 3000.095458), new Vector3(0.000000, 0.000000, 23.400003), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1886, 1325.594848, 1354.228271, 3004.075195, 9.300000, 0.000000, 128.400024, object_world, object_int, -1, 300.00, 300.00); 
            var shop26 = new DynamicObject(1886, new Vector3(1325.594848, 1354.228271, 3004.075195), new Vector3(9.300000, 0.000000, 128.400024), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2541, 1331.121704, 1354.183471, 3002.056884, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop27 = new DynamicObject(2541, new Vector3(1331.121704, 1354.183471, 3002.056884), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2541, 1330.131103, 1354.183471, 3002.056884, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop28 = new DynamicObject(2541, new Vector3(1330.131103, 1354.183471, 3002.056884), new Vector3(0.000000, 0.000000, 180.000000), 1003, 1, player, 25, 25);
           
            //tmpobjid = CreateDynamicObject(1455, 1331.355224, 1354.209960, 3000.445800, 0.000000, 0.000000, -43.799995, object_world, object_int, -1, 300.00, 300.00); 
            var shop29 = new DynamicObject(1455, new Vector3(1331.355224, 1354.209960, 3000.445800), new Vector3(0.000000, 0.000000, -43.799995), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1546, 1330.912353, 1354.084594, 3000.455810, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop30 = new DynamicObject(1546, new Vector3(1330.912353, 1354.084594, 3000.455810), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1546, 1331.252685, 1354.084594, 3000.886230, 0.000000, 0.000000, 74.399986, object_world, object_int, -1, 300.00, 300.00); 
            var shop31 = new DynamicObject(1546, new Vector3(1331.252685, 1354.084594, 3000.886230), new Vector3(0.000000, 0.000000, 74.399986), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1577, 1330.351196, 1354.097045, 3000.345703, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop32 = new DynamicObject(1577, new Vector3(1330.351196, 1354.097045, 3000.345703), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1577, 1330.311157, 1354.097045, 3000.485839, 0.000000, 0.000000, -12.499998, object_world, object_int, -1, 300.00, 300.00); 
            var shop33 = new DynamicObject(1577, new Vector3(1330.311157, 1354.097045, 3000.485839), new Vector3(0.000000, 0.000000, -12.499998), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1778, 1335.137329, 1354.365600, 3000.105468, 0.000000, 0.000000, -43.200008, object_world, object_int, -1, 300.00, 300.00); 
            var shop34 = new DynamicObject(1778, new Vector3(1335.137329, 1354.365600, 3000.105468), new Vector3(0.000000, 0.000000, -43.200008), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1810, 1329.083251, 1355.350097, 3000.095458, 0.000000, 0.000000, 146.000030, object_world, object_int, -1, 300.00, 300.00); 
            var shop35 = new DynamicObject(1810, new Vector3(1329.083251, 1355.350097, 3000.095458), new Vector3(0.000000, 0.000000, 146.000030), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1901, 1330.687866, 1354.001708, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop36 = new DynamicObject(1901, new Vector3(1330.687866, 1354.001708, 3000.786132), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1901, 1330.577758, 1354.091796, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop37 = new DynamicObject(1901, new Vector3(1330.577758, 1354.091796, 3000.786132), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1901, 1330.797607, 1354.131835, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop38 = new DynamicObject(1901, new Vector3(1330.797607, 1354.131835, 3000.786132), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1901, 1330.887695, 1354.001708, 3000.786132, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop39 = new DynamicObject(1901, new Vector3(1330.887695, 1354.001708, 3000.786132), new Vector3(0.0, 0.0, 0.0), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1951, 1329.758544, 1354.114868, 3000.545898, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop40 = new DynamicObject(1951, new Vector3(1329.758544, 1354.114868, 3000.545898), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(1951, 1329.518310, 1354.214965, 3000.545898, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop41 = new DynamicObject(1951, new Vector3(1329.518310, 1354.214965, 3000.545898), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2057, 1327.954467, 1354.087646, 3000.555908, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop42 = new DynamicObject(2057, new Vector3(1327.954467, 1354.087646, 3000.555908), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2060, 1326.858032, 1354.109130, 3000.485839, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop43 = new DynamicObject(2060, new Vector3(1326.858032, 1354.109130, 3000.485839), new Vector3(0.000000, 0.000000, 0.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2286, 1333.476196, 1353.765136, 3002.371826, 0.000000, -6.099999, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop44 = new DynamicObject(2286, new Vector3(1333.476196, 1353.765136, 3002.371826), new Vector3(0.000000, -6.099999, 180.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2342, 1329.139282, 1356.332031, 3001.156494, 0.000000, 0.000000, 42.099998, object_world, object_int, -1, 300.00, 300.00); 
            var shop45 = new DynamicObject(2342, new Vector3(1329.139282, 1356.332031, 3001.156494), new Vector3(0.000000, 0.000000, 42.099998), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2647, 1329.337646, 1354.131347, 3002.157470, 0.000000, 0.000000, -119.500000, object_world, object_int, -1, 300.00, 300.00); 
            var shop46 = new DynamicObject(2647, new Vector3(1329.337646, 1354.131347, 3002.157470), new Vector3(0.000000, 0.000000, -119.500000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(11736, 1331.146972, 1354.106323, 3001.266601, 0.000000, 0.000000, 18.899999, object_world, object_int, -1, 300.00, 300.00); 
            var shop47 = new DynamicObject(11736, new Vector3(1331.146972, 1354.106323, 3001.266601), new Vector3(0.000000, 0.000000, 18.899999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(11738, 1330.609130, 1354.075195, 3001.256591, 0.000000, 0.000000, -10.399998, object_world, object_int, -1, 300.00, 300.00); 
            var shop48 = new DynamicObject(11738, new Vector3(1330.609130, 1354.075195, 3001.256591), new Vector3(0.000000, 0.000000, -10.399998), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(11738, 1330.077270, 1354.041137, 3001.256591, 0.000000, 0.000000, 8.899999, object_world, object_int, -1, 300.00, 300.00); 
            var shop49 = new DynamicObject(11738, new Vector3(1330.077270, 1354.041137, 3001.256591), new Vector3(0.000000, 0.000000, 8.899999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19563, 1329.972534, 1354.043334, 3000.796142, 0.000000, 0.000000, -22.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop50 = new DynamicObject(19563, new Vector3(1329.972534, 1354.043334, 3000.796142), new Vector3(0.000000, 0.000000, -22.799999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19563, 1330.203979, 1354.077148, 3000.796142, 0.000000, 0.000000, -22.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop51 = new DynamicObject(19563, new Vector3(1330.203979, 1354.077148, 3000.796142), new Vector3(0.000000, 0.000000, -22.799999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19573, 1328.375244, 1354.012939, 3000.892822, 99.999931, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop52 = new DynamicObject(19563, new Vector3(1328.375244, 1354.012939, 3000.892822), new Vector3(99.999931, 0.000000, -90.000000), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19998, 1327.512451, 1354.024047, 3000.906250, 0.000000, 0.000000, -29.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop53 = new DynamicObject(19998, new Vector3(1327.512451, 1354.024047, 3000.906250), new Vector3(0.000000, 0.000000, -29.799999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19998, 1327.268066, 1354.060302, 3000.906250, 0.000000, 0.000000, -29.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop54 = new DynamicObject(19998, new Vector3(1327.268066, 1354.060302, 3000.906250), new Vector3(0.000000, 0.000000, -29.799999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19998, 1327.028686, 1354.104858, 3000.906250, 0.000000, 0.000000, -29.799999, object_world, object_int, -1, 300.00, 300.00); 
            var shop55 = new DynamicObject(19998, new Vector3(1327.028686, 1354.104858, 3000.906250), new Vector3(0.000000, 0.000000, -29.799999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(19107, 1327.910766, 1354.175170, 3002.101318, -14.500000, -88.199913, -3.399999, object_world, object_int, -1, 300.00, 300.00); 
            var shop56 = new DynamicObject(19107, new Vector3(1327.910766, 1354.175170, 3002.101318), new Vector3(-14.500000, -88.199913, -3.399999), 1003, 1, player, 25, 25);
            
            //tmpobjid = CreateDynamicObject(2002, 1325.560302, 1360.847412, 3000.115478, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var shop57 = new DynamicObject(2002, new Vector3(1325.560302, 1360.847412, 3000.115478), new Vector3(0.000000, 0.000000, 90.000000), 1003, 1, player, 25, 25);
            // - dynamic fk mapp 
            //new tmpobjid, object_world = -1, object_int = -1;
            //tmpobjid = CreateDynamicObject(19321, -165.911666, 1162.784790, 24.745386, 0.000000, -1.700000, 540.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 10850, "bakerybit2_sfse", "frate64_yellow", 0x00000000);
            var fk1 = new DynamicObject(19321, new Vector3(-165.911666, 1162.784790, 24.745386), new Vector3(0.000000, -1.700000, 540.000000), 0, 0, player, 200, 200);
            
            //SetDynamicObjectMaterial(tmpobjid, 1, 10850, "bakerybit2_sfse", "frate_doors64yellow", 0x00000000);
            fk1.SetMaterial(1, 10850, "barekybit2_sfse", "frate_doors64yellow", 0);
            
            //tmpobjid = CreateDynamicObject(19462, -436.328308, 1223.960449, 33.771858, 0.299998, 90.000000, 12.099986, object_world, object_int, -1, 300.00, 300.00); 
            var fk2 = new DynamicObject(19462, new Vector3(-436.328308, 1223.960449, 33.771858), new Vector3(0.299998, 90.000000, 12.099986), 0, 0, player, 200, 200);
            fk2.SetMaterial(0, 1692, "moregenroofstuff", "skylight_meshed", 0);
            //SetDynamicObjectMaterial(tmpobjid, 0, 1692, "moregenroofstuff", "skylight_meshed", 0x00000000);
            //tmpobjid = CreateDynamicObject(970, -438.493011, 1226.274047, 34.281845, 0.000000, 0.000000, -78.399917, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            var fk3 = new DynamicObject(970, new Vector3(-438.493011, 1226.274047, 34.281845), new Vector3(0.000000, 0.000000, -78.399917), 0, 0, player, 200, 200);
            fk3.SetMaterial(0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
            fk3.SetMaterial(1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
             //tmpobjid = CreateDynamicObject(970, -437.399078, 1220.945678, 34.281845, 0.000000, 0.000000, -78.399917, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0x00000000);
            var fk4 = new DynamicObject(970, new Vector3(-437.399078, 1220.945678, 34.281845), new Vector3(0.000000, 0.000000, -78.399917), 0, 0, player, 200, 200);
            fk4.SetMaterial(0, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
            fk4.SetMaterial(1, 2772, "airp_prop", "CJ_BANDEDMETAL", 0);
            //tmpobjid = CreateDynamicObject(19906, -116.160247, 1122.709106, 21.272209, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16644, "a51_detailstuff", "steel256128", 0x00000000);
            var fk5 = new DynamicObject(19906, new Vector3(-116.160247, 1122.709106, 21.272209), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            fk5.SetMaterial(0, 16644, "a51_detailstuff", "steel256128", 0);

             //tmpobjid = CreateDynamicObject(19906, -116.160247, 1110.476074, 21.272209, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, 16644, "a51_detailstuff", "steel256128", 0x00000000);
            var fk6 = new DynamicObject(19906, new Vector3(-116.160247, 1110.476074, 21.272209), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            fk6.SetMaterial(0, 16644, "a51_detailstuff", "steel256128", 0);
            //tmpobjid = CreateDynamicObject(3861, -80.803718, 1184.961181, 19.859954, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk7 = new DynamicObject(3861, new Vector3(-80.803718, 1184.961181, 19.859954), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3863, -86.881233, 1184.968261, 19.832212, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk8 = new DynamicObject(3863, new Vector3(-86.881233, 1184.968261, 19.832212), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3861, -92.363731, 1184.961181, 19.859954, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk9 = new DynamicObject(3861, new Vector3(-92.363731, 1184.961181, 19.859954), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1440, -80.108375, 1169.435302, 19.242193, 0.000000, 0.000000, -91.900001, object_world, object_int, -1, 300.00, 300.00); 
            var fk10 = new DynamicObject(1440, new Vector3(-80.108375, 1169.435302, 19.242193), new Vector3(0.000000, 0.000000, -91.900001), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(9238, -79.800178, 1163.579345, 20.492195, 0.000000, 0.000000, -18.700000, object_world, object_int, -1, 300.00, 300.00); 
            var fk11 = new DynamicObject(9238, new Vector3(-79.800178, 1163.579345, 20.492195), new Vector3(0.000000, 0.000000, -18.700000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -103.746353, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk12 = new DynamicObject(994, new Vector3(-103.746353, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -95.876480, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk13 = new DynamicObject(994, new Vector3(-95.876480, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -81.816604, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk14 = new DynamicObject(994, new Vector3(-81.816604, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -88.096534, 1188.331665, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk15 = new DynamicObject(994, new Vector3(-88.096534, 1188.331665, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(994, -105.526397, 1180.331298, 18.749971, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk16 = new DynamicObject(994, new Vector3(-105.526397, 1180.331298, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(994, -105.526397, 1173.972778, 18.749971, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk17 = new DynamicObject(994, new Vector3(-105.526397, 1173.972778, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(994, -105.526397, 1158.428833, 18.749971, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk18 = new DynamicObject(994, new Vector3(-105.526397, 1158.428833, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            var fk19 = new DynamicObject(994, new Vector3(-105.526397, 1166.210327, 18.749971), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -97.646392, 1158.428833, 18.749971, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk20 = new DynamicObject(994, new Vector3(-97.646392, 1158.428833, 18.749971), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -95.446426, 1158.428833, 18.749971, 0.000000, 0.000000, -28.899986, object_world, object_int, -1, 300.00, 300.00); 
            var fk21 = new DynamicObject(994, new Vector3(-95.446426, 1158.428833, 18.749971), new Vector3(0.000000, 0.000000, -28.899986), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1155.418090, 18.749971, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk22 = new DynamicObject(994, new Vector3(), new Vector3(), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(994, -83.686347, 1155.418090, 18.749971, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk23 = new DynamicObject(994, new Vector3(-83.686347, 1155.418090, 18.749971), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(994, -75.626426, 1161.878662, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk24 = new DynamicObject(994, new Vector3(-75.626426, 1161.878662, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1188.309326, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk25 = new DynamicObject(994, new Vector3(-75.626426, 1188.309326, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1168.155273, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk26 = new DynamicObject(994, new Vector3(-75.626426, 1168.155273, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1174.423461, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk27 = new DynamicObject(994, new Vector3(-75.626426, 1174.423461, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(994, -75.626426, 1180.682983, 18.749971, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk28 = new DynamicObject(994, new Vector3(-75.626426, 1180.682983, 18.749971), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2671, -97.292160, 1176.086914, 18.749971, 0.000000, 0.000000, -70.799995, object_world, object_int, -1, 300.00, 300.00); 
            var fk29 = new DynamicObject(2671, new Vector3(-97.292160, 1176.086914, 18.749971), new Vector3(0.000000, 0.000000, -70.799995), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2670, -91.722518, 1180.281738, 18.829973, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk30 = new DynamicObject(2670, new Vector3(-91.722518, 1180.281738, 18.829973), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2671, -101.407836, 1181.432006, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk31 = new DynamicObject(2671, new Vector3(-101.407836, 1181.432006, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3863, -97.571243, 1184.968261, 19.832212, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk32 = new DynamicObject(3863, new Vector3(-97.571243, 1184.968261, 19.832212), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3014, -81.628555, 1164.227905, 18.932191, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk33 = new DynamicObject(3014, new Vector3(-81.628555, 1164.227905, 18.932191), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3014, -81.533897, 1164.878662, 18.932191, 0.000000, 0.000000, -17.699996, object_world, object_int, -1, 300.00, 300.00); 
            var fk34 = new DynamicObject(3014, new Vector3(-81.533897, 1164.878662, 18.932191), new Vector3(0.000000, 0.000000, -17.699996), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3014, -81.101936, 1165.374755, 18.932191, 0.000000, 0.000000, -34.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk35 = new DynamicObject(3014, new Vector3(-81.101936, 1165.374755, 18.932191), new Vector3(0.000000, 0.000000, -34.299995), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3014, -81.270996, 1165.127075, 19.392202, 0.000000, 0.000000, -34.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk36 = new DynamicObject(3014, new Vector3(-81.270996, 1165.127075, 19.392202), new Vector3(0.000000, 0.000000, -34.299995), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3014, -81.664154, 1164.547851, 19.412172, 0.000000, 2.299961, -34.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk37 = new DynamicObject(3014, new Vector3(-81.664154, 1164.547851, 19.412172), new Vector3(0.000000, 2.299961, -34.299995), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2040, -80.635620, 1165.645141, 18.832189, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk38 = new DynamicObject(2040, new Vector3(-80.635620, 1165.645141, 18.832189), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2040, -80.947235, 1165.786865, 18.832189, 0.000000, 0.000000, -98.199989, object_world, object_int, -1, 300.00, 300.00); 
            var fk39 = new DynamicObject(2040, new Vector3(-80.947235, 1165.786865, 18.832189), new Vector3(0.000000, 0.000000, -98.199989), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2040, -80.952682, 1165.460083, 19.298551, 5.299997, 0.000000, -119.500007, object_world, object_int, -1, 300.00, 300.00); 
            var fk40 = new DynamicObject(2040, new Vector3(-80.952682, 1165.460083, 19.298551), new Vector3(5.299997, 0.000000, -119.500007), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(355, -81.636398, 1165.197998, 19.034393, 9.199998, -90.000000, 61.300014, object_world, object_int, -1, 300.00, 300.00); 
            var fk41 = new DynamicObject(355, new Vector3(-81.636398, 1165.197998, 19.034393), new Vector3(9.199998, -90.000000, 61.300014), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(358, -81.310081, 1164.917236, 19.705297, -88.499923, -177.600006, 44.100021, object_world, object_int, -1, 300.00, 300.00); 
            var fk42 = new DynamicObject(358, new Vector3(-81.310081, 1164.917236, 19.705297), new Vector3(-88.499923, -177.600006, 44.100021), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1271, -83.008399, 1160.570800, 19.072195, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk43 = new DynamicObject(1271, new Vector3(-83.008399, 1160.570800, 19.072195), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1271, -82.719406, 1161.493286, 19.072195, 0.000000, 0.000000, -29.799997, object_world, object_int, -1, 300.00, 300.00); 
            var fk44 = new DynamicObject(1271, new Vector3(-82.719406, 1161.493286, 19.072195), new Vector3(0.000000, 0.000000, -29.799997), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1271, -82.967864, 1161.059936, 19.752193, 0.000000, 0.000000, -24.699991, object_world, object_int, -1, 300.00, 300.00); 
            var fk45 = new DynamicObject(1271, new Vector3(-82.967864, 1161.059936, 19.752193), new Vector3(0.000000, 0.000000, -24.699991), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3862, -103.372169, 1177.188110, 19.899993, 0.000000, 0.000000, 90.800048, object_world, object_int, -1, 300.00, 300.00); 
            var fk46 = new DynamicObject(3862, new Vector3(-103.372169, 1177.188110, 19.899993), new Vector3(0.000000, 0.000000, 90.800048), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3862, -103.282890, 1170.797729, 19.899993, 0.000000, 0.000000, 90.800048, object_world, object_int, -1, 300.00, 300.00); 
            var fk47 = new DynamicObject(3862, new Vector3(-103.282890, 1170.797729, 19.899993), new Vector3(0.000000, 0.000000, 90.800048), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3861, -103.243782, 1165.081176, 19.859954, 0.000000, 0.000000, -270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk48 = new DynamicObject(3861, new Vector3(-103.243782, 1165.081176, 19.859954), new Vector3(0.000000, 0.000000, -270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1342, -78.701759, 1178.785888, 19.742198, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk49 = new DynamicObject(1342, new Vector3(-78.701759, 1178.785888, 19.742198), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1342, -78.701759, 1174.595458, 19.742198, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk50 = new DynamicObject(1342, new Vector3(-78.701759, 1174.595458, 19.742198), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3171, -93.008857, 1161.033691, 18.692186, 0.000000, 0.000000, -109.300025, object_world, object_int, -1, 300.00, 300.00); 
            var fk51 = new DynamicObject(3171, new Vector3(-93.008857, 1161.033691, 18.692186), new Vector3(0.000000, 0.000000, -109.300025), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2115, -91.583679, 1163.970947, 18.742187, 0.000000, 0.000000, -1.399999, object_world, object_int, -1, 300.00, 300.00); 
            var fk52 = new DynamicObject(2115, new Vector3(-91.583679, 1163.970947, 18.742187), new Vector3(0.000000, 0.000000, -1.399999), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2232, -89.481521, 1161.511108, 19.302200, 0.000000, 0.000000, -159.500045, object_world, object_int, -1, 300.00, 300.00); 
            var fk53 = new DynamicObject(2232, new Vector3(-89.481521, 1161.511108, 19.302200), new Vector3(0.000000, 0.000000, -159.500045), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(2232, -88.946716, 1162.189208, 19.302200, 0.000000, 0.000000, -133.200027, object_world, object_int, -1, 300.00, 300.00); 
            var fk54 = new DynamicObject(2232, new Vector3(-88.946716, 1162.189208, 19.302200), new Vector3(0.000000, 0.000000, -133.200027), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2322, -89.182647, 1161.856689, 20.192209, 0.000000, 0.000000, -132.900024, object_world, object_int, -1, 300.00, 300.00); 
            var fk55 = new DynamicObject(2322, new Vector3(-89.182647, 1161.856689, 20.192209), new Vector3(0.000000, 0.000000, -132.900024), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18872, -90.349845, 1164.089843, 19.532190, 0.000000, 0.000000, 33.799999, object_world, object_int, -1, 300.00, 300.00); 
            var fk56 = new DynamicObject(18872, new Vector3(-90.349845, 1164.089843, 19.532190), new Vector3(0.000000, 0.000000, 33.799999), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18872, -90.457901, 1164.017822, 19.532190, 0.000000, 0.000000, 33.799999, object_world, object_int, -1, 300.00, 300.00); 
            var fk57 = new DynamicObject(18872, new Vector3(-90.457901, 1164.017822, 19.532190), new Vector3(0.000000, 0.000000, 33.799999), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18867, -90.627708, 1163.989624, 19.532197, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk58 = new DynamicObject(18867, new Vector3(-90.627708, 1163.989624, 19.532197), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18875, -90.617301, 1164.211303, 19.552200, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk59 = new DynamicObject(18875, new Vector3(-90.617301, 1164.211303, 19.552200), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1839, -90.676040, 1163.997680, 18.722187, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk60 = new DynamicObject(1839, new Vector3(-90.676040, 1163.997680, 18.722187), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1839, -91.586067, 1163.997680, 18.722187, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk61 = new DynamicObject(1839, new Vector3(-91.586067, 1163.997680, 18.722187), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1785, -91.465965, 1164.010620, 19.622188, 0.000000, 0.000000, 28.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk62 = new DynamicObject(1785, new Vector3(-91.465965, 1164.010620, 19.622188), new Vector3(0.000000, 0.000000, 28.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19318, -90.946540, 1161.736938, 19.401264, -11.600000, 0.000000, 161.099990, object_world, object_int, -1, 300.00, 300.00); 
            var fk63 = new DynamicObject(19318, new Vector3(-90.946540, 1161.736938, 19.401264), new Vector3(-11.600000, 0.000000, 161.099990), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3031, -87.934089, 1162.640991, 20.282199, 0.000000, 0.000000, 72.799995, object_world, object_int, -1, 300.00, 300.00); 
            var fk64 = new DynamicObject(3031, new Vector3(-87.934089, 1162.640991, 20.282199), new Vector3(0.000000, 0.000000, 72.799995), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3031, -92.773498, 1161.287963, 23.102201, 0.000000, 0.000000, -172.199981, object_world, object_int, -1, 300.00, 300.00); 
            var fk65 = new DynamicObject(3031, new Vector3(-92.773498, 1161.287963, 23.102201), new Vector3(0.000000, 0.000000, -172.199981), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19602, -82.697998, 1161.581298, 19.472187, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk66 = new DynamicObject(19602, new Vector3(-82.697998, 1161.581298, 19.472187), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1439, -83.778106, 1187.782104, 18.812189, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk67 = new DynamicObject(1439, new Vector3(-83.778106, 1187.782104, 18.812189), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1439, -104.838081, 1180.363037, 18.812189, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk68 = new DynamicObject(1439, new Vector3(-104.838081, 1180.363037, 18.812189), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2670, -91.722518, 1165.581909, 18.829973, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk69 = new DynamicObject(2670, new Vector3(-91.722518, 1165.581909, 18.829973), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1437, -170.510177, 1173.039184, 22.534311, -63.200057, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk70 = new DynamicObject(1437, new Vector3(-170.510177, 1173.039184, 22.534311), new Vector3(-63.200057, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(8572, -176.897857, 1172.841430, 20.942203, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk71 = new DynamicObject(8572, new Vector3(-176.897857, 1172.841430, 20.942203), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1711, -178.369247, 1176.847412, 21.911260, 0.000000, 0.000000, 134.399963, object_world, object_int, -1, 300.00, 300.00); 
            var fk72 = new DynamicObject(1711, new Vector3(-178.369247, 1176.847412, 21.911260), new Vector3(0.000000, 0.000000, 134.399963), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1438, -174.368743, 1179.872070, 21.911260, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk73 = new DynamicObject(1438, new Vector3(-174.368743, 1179.872070, 21.911260), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2111, -177.731231, 1178.913940, 22.291254, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk74 = new DynamicObject(2111, new Vector3(-177.731231, 1178.913940, 22.291254), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3062, -170.501571, 1177.096191, 23.351274, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk75 = new DynamicObject(3062, new Vector3(-170.501571, 1177.096191, 23.351274), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19321, -166.945556, 1178.674926, 23.406112, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk76 = new DynamicObject(19321, new Vector3(-166.945556, 1178.674926, 23.406112), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3062, -170.501571, 1180.196533, 23.351274, 0.000000, 0.000000, 154.500076, object_world, object_int, -1, 300.00, 300.00); 
            var fk77 = new DynamicObject(3062, new Vector3(-170.501571, 1180.196533, 23.351274), new Vector3(0.000000, 0.000000, 154.500076), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1793, -166.838562, 1179.865112, 21.933109, 0.000000, 0.000000, -107.399971, object_world, object_int, -1, 300.00, 300.00); 
            var fk78 = new DynamicObject(1793, new Vector3(-166.838562, 1179.865112, 21.933109), new Vector3(0.000000, 0.000000, -107.399971), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1362, -171.524703, 1177.684204, 22.531274, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk79 = new DynamicObject(1362, new Vector3(-171.524703, 1177.684204, 22.531274), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18688, -171.631439, 1177.581420, 21.341255, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk80 = new DynamicObject(18688, new Vector3(-171.631439, 1177.581420, 21.341255), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(1372, -165.089385, 1173.205932, 18.862190, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk81 = new DynamicObject(1372, new Vector3(-165.089385, 1173.205932, 18.862190), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(1372, -167.489410, 1173.205932, 18.862190, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk82 = new DynamicObject(1372, new Vector3(-167.489410, 1173.205932, 18.862190), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(14861, -168.618057, 1169.144897, 19.099996, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk83 = new DynamicObject(14861, new Vector3(-168.618057, 1169.144897, 19.099996), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1483, -167.113601, 1170.209594, 21.602216, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk84 = new DynamicObject(1483, new Vector3(-167.113601, 1170.209594, 21.602216), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(1483, -167.113601, 1172.929565, 18.092205, 0.000000, 180.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk85 = new DynamicObject(1483, new Vector3(-167.113601, 1172.929565, 18.092205), new Vector3(0.000000, 180.000000, -90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1464, -172.671707, 1173.013305, 19.810003, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk86 = new DynamicObject(1464, new Vector3(-172.671707, 1173.013305, 19.810003), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1464, -169.911727, 1173.013305, 19.810003, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk87 = new DynamicObject(1464, new Vector3(-169.911727, 1173.013305, 19.810003), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(14880, -165.141937, 1169.664916, 19.079984, 0.000000, 0.000000, 90.199996, object_world, object_int, -1, 300.00, 300.00); 
            var fk88 = new DynamicObject(14880, new Vector3(-165.141937, 1169.664916, 19.079984), new Vector3(0.000000, 0.000000, 90.199996), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1265, -170.466110, 1168.853637, 19.119993, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk89 = new DynamicObject(1265, new Vector3(-170.466110, 1168.853637, 19.119993), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1721, -175.000732, 1172.779785, 18.729988, 0.000000, 0.000000, 119.400016, object_world, object_int, -1, 300.00, 300.00); 
            var fk90 = new DynamicObject(1721, new Vector3(-175.000732, 1172.779785, 18.729988), new Vector3(0.000000, 0.000000, 119.400016), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1219, -180.085861, 1165.808837, 19.932189, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk91 = new DynamicObject(1219, new Vector3(-180.085861, 1165.808837, 19.932189), new Vector3(0.000000, -90.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1219, -180.095855, 1160.959228, 19.932262, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk92 = new DynamicObject(1219, new Vector3(-180.095855, 1160.959228, 19.932262), new Vector3(0.000000, -90.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1219, -180.105850, 1184.277832, 19.932346, 0.000000, -90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk93 = new DynamicObject(1219, new Vector3(-180.105850, 1184.277832, 19.932346), new Vector3(0.000000, -90.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18660, -173.350509, 1181.628295, 23.541265, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk94 = new DynamicObject(18660, new Vector3(-173.350509, 1181.628295, 23.541265), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2866, -177.994857, 1178.681518, 22.711265, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk95 = new DynamicObject(2866, new Vector3(-177.994857, 1178.681518, 22.711265), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1812, -165.158523, 1159.527832, 23.256544, 0.000000, 3.400002, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk96 = new DynamicObject(1812, new Vector3(-165.158523, 1159.527832, 23.256544), new Vector3(0.000000, 3.400002, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1812, -165.158523, 1163.027954, 23.256544, 0.000000, 3.400002, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk97 = new DynamicObject(1812, new Vector3(-165.158523, 1163.027954, 23.256544), new Vector3(0.000000, 3.400002, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1812, -166.960144, 1160.145751, 23.365673, 0.000000, 3.400002, -5.299999, object_world, object_int, -1, 300.00, 300.00); 
            var fk98 = new DynamicObject(1812, new Vector3(-166.960144, 1160.145751, 23.365673), new Vector3(0.000000, 3.400002, -5.299999), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1369, -171.112365, 1162.002197, 24.006126, 0.000000, 1.799999, 164.999923, object_world, object_int, -1, 300.00, 300.00); 
            var fk99 = new DynamicObject(1369, new Vector3(-171.112365, 1162.002197, 24.006126), new Vector3(0.000000, 1.799999, 164.999923), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1722, -174.651443, 1163.716430, 23.516119, -1.299993, 2.300000, -59.500000, object_world, object_int, -1, 300.00, 300.00); 
            var fk100 = new DynamicObject(1722, new Vector3(-174.651443, 1163.716430, 23.516119), new Vector3(-1.299993, 2.300000, -59.500000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1362, -173.948303, 1161.040771, 24.056156, 1.799998, 1.600000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk101 = new DynamicObject(1362, new Vector3(-173.948303, 1161.040771, 24.056156), new Vector3(1.799998, 1.600000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18688, -174.046630, 1160.951293, 22.996103, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk102 = new DynamicObject(18688, new Vector3(-174.046630, 1160.951293, 22.996103), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1474, -168.349624, 1160.214111, 24.676137, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk103 = new DynamicObject(1474, new Vector3(-168.349624, 1160.214111, 24.676137), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1474, -168.349624, 1161.714599, 24.676137, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk104 = new DynamicObject(1474, new Vector3(-168.349624, 1161.714599, 24.676137), new Vector3(0.000000, 0.000000, 270.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(917, -168.969360, 1164.771850, 23.496051, 0.000000, 1.800001, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk105 = new DynamicObject(917, new Vector3(-168.969360, 1164.771850, 23.496051), new Vector3(0.000000, 1.800001, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -81.232734, 1305.032470, 10.902971, 0.000000, 0.000000, 360.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk106 = new DynamicObject(3279, new Vector3(-81.232734, 1305.032470, 10.902971), new Vector3(0.000000, 0.000000, 360.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -56.142932, 1305.032470, 10.622963, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk107 = new DynamicObject(3279, new Vector3(-56.142932, 1305.032470, 10.622963), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -371.263000, 1272.294189, 23.312990, 0.000000, 0.000000, 360.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk108 = new DynamicObject(3279, new Vector3(-371.263000, 1272.294189, 23.312990), new Vector3(0.000000, 0.000000, 360.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(12991, -381.001556, 1267.727294, 23.648094, 0.000000, 0.000000, -76.899948, object_world, object_int, -1, 300.00, 300.00); 
            var fk109 = new DynamicObject(12991, new Vector3(-381.001556, 1267.727294, 23.648094), new Vector3(0.000000, 0.000000, -76.899948), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, 173.302993, 1130.456787, 13.462953, 0.000000, 0.000000, 161.800018, object_world, object_int, -1, 300.00, 300.00); 
            var fk110 = new DynamicObject(3279, new Vector3(173.302993, 1130.456787, 13.462953), new Vector3(0.000000, 0.000000, 161.800018), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1437, 96.145240, 1173.430541, 18.434040, -20.000003, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk111 = new DynamicObject(1437, new Vector3(96.145240, 1173.430541, 18.434040), new Vector3(-20.000003, 0.000000, -90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1431, 103.847793, 1177.935791, 23.004253, 0.000000, 0.000000, 99.299987, object_world, object_int, -1, 300.00, 300.00); 
            var fk112 = new DynamicObject(1431, new Vector3(103.847793, 1177.935791, 23.004253), new Vector3(0.000000, 0.000000, 99.299987), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1431, 104.093673, 1175.803710, 23.004253, 0.000000, 0.000000, 90.200004, object_world, object_int, -1, 300.00, 300.00); 
            var fk113 = new DynamicObject(1431, new Vector3(104.093673, 1175.803710, 23.004253), new Vector3(0.000000, 0.000000, 90.200004), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2985, 103.234451, 1176.754272, 22.429550, 0.000000, 0.000000, 9.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk114 = new DynamicObject(2985, new Vector3(103.234451, 1176.754272, 22.429550), new Vector3(0.000000, 0.000000, 9.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2973, 104.437965, 1170.842407, 22.424585, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk115 = new DynamicObject(2973, new Vector3(104.437965, 1170.842407, 22.424585), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2359, 102.877006, 1178.120727, 22.657268, 0.000000, 0.000000, 95.300010, object_world, object_int, -1, 300.00, 300.00); 
            var fk116 = new DynamicObject(2359, new Vector3(102.877006, 1178.120727, 22.657268), new Vector3(0.000000, 0.000000, 95.300010), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2977, 96.367874, 1171.428466, 17.514059, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk117 = new DynamicObject(2977, new Vector3(96.367874, 1171.428466, 17.514059), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2977, 96.367874, 1170.228149, 17.514059, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk118 = new DynamicObject(2977, new Vector3(96.367874, 1170.228149, 17.514059), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3015, 102.837356, 1170.074707, 22.591102, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk119 = new DynamicObject(3015, new Vector3(102.837356, 1170.074707, 22.591102), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3015, 102.837356, 1170.554809, 22.591102, 0.000000, 0.000000, -9.500000, object_world, object_int, -1, 300.00, 300.00); 
            var fk120 = new DynamicObject(3015, new Vector3(102.837356, 1170.554809, 22.591102), new Vector3(0.000000, 0.000000, -9.500000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3014, 102.739761, 1171.062011, 22.680717, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk121 = new DynamicObject(3014, new Vector3(102.739761, 1171.062011, 22.680717), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1431, 102.671936, 1179.756835, 23.004253, 0.000000, 0.000000, 143.399963, object_world, object_int, -1, 300.00, 300.00); 
            var fk122 = new DynamicObject(1431, new Vector3(102.671936, 1179.756835, 23.004253), new Vector3(0.000000, 0.000000, 143.399963), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19996, 101.728736, 1177.355590, 22.491416, 0.000000, 0.000000, 64.999992, object_world, object_int, -1, 300.00, 300.00); 
            var fk123 = new DynamicObject(19996, new Vector3(101.728736, 1177.355590, 22.491416), new Vector3(0.000000, 0.000000, 64.999992), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, 294.230133, 1236.629760, 13.882926, 0.000000, 0.000000, -125.899955, object_world, object_int, -1, 300.00, 300.00); 
            var fk124 = new DynamicObject(3279, new Vector3(294.230133, 1236.629760, 13.882926), new Vector3(0.000000, 0.000000, -125.899955), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(3279, 272.742156, 1247.566162, 14.562927, 0.000000, 0.000000, -125.899955, object_world, object_int, -1, 300.00, 300.00); 
            var fk125 = new DynamicObject(3279, new Vector3(272.742156, 1247.566162, 14.562927), new Vector3(0.000000, 0.000000, -125.899955), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, 208.148681, 976.581604, 27.442966, 0.000000, 0.000000, 108.900070, object_world, object_int, -1, 300.00, 300.00); 
            var fk126 = new DynamicObject(3279, new Vector3(208.148681, 976.581604, 27.442966), new Vector3(0.000000, 0.000000, 108.900070), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, 232.312774, 985.868530, 27.102958, 0.000000, 0.000000, 108.900070, object_world, object_int, -1, 300.00, 300.00); 
            var fk127 = new DynamicObject(3279, new Vector3(232.312774, 985.868530, 27.102958), new Vector3(0.000000, 0.000000, 108.900070), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -129.893020, 807.794189, 19.802949, 0.000000, 0.000000, 108.900070, object_world, object_int, -1, 300.00, 300.00); 
            var fk128 = new DynamicObject(3279, new Vector3(-129.893020, 807.794189, 19.802949), new Vector3(0.000000, 0.000000, 108.900070), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -275.602600, 809.060485, 13.773155, -2.099999, 0.000000, 38.500072, object_world, object_int, -1, 300.00, 300.00); 
            var fk129 = new DynamicObject(3279, new Vector3(-275.602600, 809.060485, 13.773155), new Vector3(-2.099999, 0.000000, 38.500072), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -398.146850, 994.450561, 9.602944, 0.000000, 0.000000, -37.999885, object_world, object_int, -1, 300.00, 300.00); 
            var fk130 = new DynamicObject(3279, new Vector3(-398.146850, 994.450561, 9.602944), new Vector3(0.000000, 0.000000, -37.999885), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19966, -445.321228, 1218.676391, 28.736557, -4.399999, 6.500000, -96.800018, object_world, object_int, -1, 300.00, 300.00); 
            var fk131 = new DynamicObject(19966, new Vector3(-445.321228, 1218.676391, 28.736557), new Vector3(-4.399999, 6.500000, -96.800018), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(8615, -433.956665, 1230.297729, 32.151775, 0.000000, 0.000000, -168.099960, object_world, object_int, -1, 300.00, 300.00); 
            var fk132 = new DynamicObject(8615, new Vector3(-433.956665, 1230.297729, 32.151775), new Vector3(0.000000, 0.000000, -168.099960), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2985, -436.756530, 1223.901855, 33.837959, 0.000000, 0.000000, -166.399932, object_world, object_int, -1, 300.00, 300.00); 
            var fk133 = new DynamicObject(2985, new Vector3(-436.756530, 1223.901855, 33.837959), new Vector3(0.000000, 0.000000, -166.399932), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2060, -437.351257, 1223.039794, 33.977897, 0.000000, 0.000000, -45.200000, object_world, object_int, -1, 300.00, 300.00); 
            var fk134 = new DynamicObject(2060, new Vector3(-437.351257, 1223.039794, 33.977897), new Vector3(0.000000, 0.000000, -45.200000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2060, -437.595275, 1224.205200, 33.957901, 0.000000, 0.000000, -103.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk135 = new DynamicObject(2060, new Vector3(-437.595275, 1224.205200, 33.957901), new Vector3(0.000000, 0.000000, -103.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2060, -437.611145, 1224.136840, 34.187862, 0.000000, 0.000000, -103.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk136 = new DynamicObject(2060, new Vector3(-437.611145, 1224.136840, 34.187862), new Vector3(0.000000, 0.000000, -103.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2060, -437.407653, 1223.096435, 34.237854, 0.000000, 0.000000, -45.200000, object_world, object_int, -1, 300.00, 300.00); 
            var fk137 = new DynamicObject(2060, new Vector3(-437.407653, 1223.096435, 34.237854), new Vector3(0.000000, 0.000000, -45.200000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2060, -437.713409, 1223.598144, 34.447822, 0.000000, 0.000000, -79.600028, object_world, object_int, -1, 300.00, 300.00); 
            var fk138 = new DynamicObject(2060, new Vector3(-437.713409, 1223.598144, 34.447822), new Vector3(0.000000, 0.000000, -79.600028), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3585, -421.725006, 1231.690673, 31.116085, -5.900001, 0.000000, 9.599995, object_world, object_int, -1, 300.00, 300.00); 
            var fk139 = new DynamicObject(3585, new Vector3(-421.725006, 1231.690673, 31.116085), new Vector3(-5.900001, 0.000000, 9.599995), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(3585, -413.564331, 1232.900756, 31.344280, -3.900000, -0.699998, 6.799995, object_world, object_int, -1, 300.00, 300.00); 
            var fk140 = new DynamicObject(3585, new Vector3(-413.564331, 1232.900756, 31.344280), new Vector3(-3.900000, -0.699998, 6.799995), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3633, -434.771697, 1220.246704, 34.281646, 0.000000, 0.000000, 15.000007, object_world, object_int, -1, 300.00, 300.00); 
            var fk141 = new DynamicObject(3633, new Vector3(-434.771697, 1220.246704, 34.281646), new Vector3(0.000000, 0.000000, 15.000007), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3593, -482.617584, 1216.961425, 29.047889, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk142 = new DynamicObject(3593, new Vector3(-482.617584, 1216.961425, 29.047889), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3788, -429.329010, 1221.959472, 29.896795, 0.000000, 0.000000, 11.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk143 = new DynamicObject(3788, new Vector3(-429.329010, 1221.959472, 29.896795), new Vector3(0.000000, 0.000000, 11.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2041, -434.532012, 1220.602416, 34.965194, 0.000000, 0.000000, -31.400003, object_world, object_int, -1, 300.00, 300.00); 
            var fk144 = new DynamicObject(2041, new Vector3(-434.532012, 1220.602416, 34.965194), new Vector3(0.000000, 0.000000, -31.400003), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2619, -435.697326, 1219.263427, 35.640365, -3.300004, 0.000000, -79.699951, object_world, object_int, -1, 300.00, 300.00); 
            var fk145 = new DynamicObject(2619, new Vector3(-435.697326, 1219.263427, 35.640365), new Vector3(-3.300004, 0.000000, -79.699951), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2358, -437.496948, 1225.206176, 33.982406, 0.000000, 0.000000, 135.499923, object_world, object_int, -1, 300.00, 300.00); 
            var fk146 = new DynamicObject(2358, new Vector3(-437.496948, 1225.206176, 33.982406), new Vector3(0.000000, 0.000000, 135.499923), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -145.505035, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk147 = new DynamicObject(19641, new Vector3(-145.505035, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -137.505004, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk148 = new DynamicObject(19641, new Vector3(-137.505004, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
           //tmpobjid = CreateDynamicObject(19641, -129.504943, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk149 = new DynamicObject(19641, new Vector3(-129.504943, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -121.505065, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk150 = new DynamicObject(19641, new Vector3(-121.505065, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -113.505088, 1108.478027, 18.749988, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk151 = new DynamicObject(19641, new Vector3(-113.505088, 1108.478027, 18.749988), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -109.685111, 1112.296875, 18.749988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk152 = new DynamicObject(19641, new Vector3(-109.685111, 1112.296875, 18.749988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -109.685111, 1120.295776, 18.749988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk153 = new DynamicObject(19641, new Vector3(-109.685111, 1120.295776, 18.749988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(19641, -109.685111, 1128.295776, 18.749988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk154 = new DynamicObject(19641, new Vector3(-109.685111, 1128.295776, 18.749988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(8674, -150.538604, 1113.586791, 22.000013, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk155 = new DynamicObject(8674, new Vector3(-150.538604, 1113.586791, 22.000013), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
             //tmpobjid = CreateDynamicObject(8674, -150.538604, 1123.937133, 22.000013, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk156 = new DynamicObject(8674, new Vector3(-150.538604, 1123.937133, 22.000013), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(8674, -150.538604, 1131.647338, 22.000013, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk157 = new DynamicObject(8674, new Vector3(-150.538604, 1131.647338, 22.000013), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -113.575134, 1132.186889, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk158 = new DynamicObject(19641, new Vector3(-113.575134, 1132.186889, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -121.575126, 1132.186889, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk159 = new DynamicObject(19641, new Vector3(-121.575126, 1132.186889, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -129.575134, 1132.186889, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk160 = new DynamicObject(19641, new Vector3(-129.575134, 1132.186889, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -145.829360, 1130.541137, 18.649986, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk161 = new DynamicObject(3279, new Vector3(-145.829360, 1130.541137, 18.649986), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19641, -146.525085, 1136.707763, 18.749988, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk162 = new DynamicObject(19641, new Vector3(-146.525085, 1136.707763, 18.749988), new Vector3(0.000000, 0.000000, 180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19912, -132.262512, 1131.557617, 20.342159, 0.000000, 0.000000, -27.100027, object_world, object_int, -1, 300.00, 300.00); 
            //var fk163 = new DynamicObject(19912, new Vector3(-132.262512, 1131.557617, 20.342159), new Vector3(0.000000, 0.000000, -27.100027), 0, 0, player, 200, 200);
            //fk163.ShowInWorld(0);
            //tmpobjid = CreateDynamicObject(16095, -129.823028, 1127.316772, 18.739988, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk164 = new DynamicObject(16095, new Vector3(-129.823028, 1127.316772, 18.739988), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1697, -129.623046, 1127.234130, 23.799987, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk165 = new DynamicObject(1697, new Vector3(-129.623046, 1127.234130, 23.799987), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19909, -116.976196, 1116.400634, 18.749971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk166 = new DynamicObject(19909, new Vector3(-116.976196, 1116.400634, 18.749971), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2634, -122.862106, 1116.398803, 19.959980, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk167 = new DynamicObject(2634, new Vector3(-122.862106, 1116.398803, 19.959980), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1697, -114.963096, 1119.844238, 25.179985, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk168 = new DynamicObject(1697, new Vector3(-114.963096, 1119.844238, 25.179985), new Vector3(0.000000, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3279, -114.469375, 1127.069091, 18.649986, 0.000000, 0.000000, -180.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk169 = new DynamicObject(3279, new Vector3(-114.469375, 1127.069091, 18.649986), new Vector3(0.000000, 0.000000, -180.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3173, -223.104812, 1054.487792, 18.662185, 0.000000, 0.000000, -179.200103, object_world, object_int, -1, 300.00, 300.00); 
            var fk170 = new DynamicObject(3173, new Vector3(-223.104812, 1054.487792, 18.662185), new Vector3(0.000000, 0.000000, -179.200103), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3171, -234.733489, 1040.640258, 18.702186, 0.000000, 0.000000, -163.399993, object_world, object_int, -1, 300.00, 300.00); 
            var fk171 = new DynamicObject(3171, new Vector3(-234.733489, 1040.640258, 18.702186), new Vector3(0.000000, 0.000000, -163.399993), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19632, -229.703536, 1045.759765, 18.744390, 0.000000, 0.000000, 54.399997, object_world, object_int, -1, 300.00, 300.00); 
            var fk172 = new DynamicObject(19632, new Vector3(-229.703536, 1045.759765, 18.744390), new Vector3(0.000000, 0.000000, 54.399997), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1358, -221.183593, 1045.108764, 19.942193, 0.000000, 0.000000, 37.899993, object_world, object_int, -1, 300.00, 300.00); 
            var fk173 = new DynamicObject(1358, new Vector3(-221.183593, 1045.108764, 19.942193), new Vector3(0.000000, 0.000000, 37.899993), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(12957, -234.719238, 1058.412475, 19.402202, 0.000000, 0.000000, 27.000009, object_world, object_int, -1, 300.00, 300.00); 
            var fk174 = new DynamicObject(12957, new Vector3(-234.719238, 1058.412475, 19.402202), new Vector3(0.000000, 0.000000, 27.000009), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1334, -235.815216, 1046.485717, 19.552198, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk175 = new DynamicObject(1334, new Vector3(-235.815216, 1046.485717, 19.552198), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(3005, -230.595062, 1047.780395, 18.742187, 0.000000, 0.000000, -38.199996, object_world, object_int, -1, 300.00, 300.00); 
            var fk176 = new DynamicObject(3005, new Vector3(-230.595062, 1047.780395, 18.742187), new Vector3(0.000000, 0.000000, -38.199996), 0, 0, player, 200, 200);
           //tmpobjid = CreateDynamicObject(18862, -221.315933, 1044.479736, 18.792165, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk177 = new DynamicObject(18862, new Vector3(-221.315933, 1044.479736, 18.792165), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1415, -226.201004, 1060.501464, 18.742187, 0.000000, 0.000000, -48.299995, object_world, object_int, -1, 300.00, 300.00); 
            var fk178 = new DynamicObject(1415, new Vector3(-226.201004, 1060.501464, 18.742187), new Vector3(0.000000, 0.000000, -48.299995), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(2674, -227.133834, 1047.771240, 18.762187, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk179 = new DynamicObject(2674, new Vector3(-227.133834, 1047.771240, 18.762187), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1793, -232.665802, 1057.979248, 18.712186, 0.000000, 0.000000, -52.399978, object_world, object_int, -1, 300.00, 300.00); 
            var fk180 = new DynamicObject(1793, new Vector3(-232.665802, 1057.979248, 18.712186), new Vector3(0.000000, 0.000000, -52.399978), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19573, -224.934127, 1050.061523, 18.758342, -5.899999, 0.000000, -89.399971, object_world, object_int, -1, 300.00, 300.00); 
            var fk181 = new DynamicObject(19573, new Vector3(-224.934127, 1050.061523, 18.758342), new Vector3(-5.899999, 0.000000, -89.399971), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(18663, -213.790100, 1065.782714, 24.396249, 3.599999, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk182 = new DynamicObject(18663, new Vector3(-213.790100, 1065.782714, 24.396249), new Vector3(3.599999, 0.000000, 90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1457, -225.685302, 1067.539916, 20.382207, 0.000000, 0.000000, -177.400009, object_world, object_int, -1, 300.00, 300.00); 
            var fk183 = new DynamicObject(1457, new Vector3(-225.685302, 1067.539916, 20.382207), new Vector3(0.000000, 0.000000, -177.400009), 0, 0, player, 200, 200);
            
            //tmpobjid = CreateDynamicObject(1793, -227.856887, 1067.403930, 18.382179, 0.000000, 0.000000, -87.999946, object_world, object_int, -1, 300.00, 300.00); 
            var fk184 = new DynamicObject(1793, new Vector3(-227.856887, 1067.403930, 18.382179), new Vector3(0.000000, 0.000000, -87.999946), 0, 0, player, 200, 200);
           
            //tmpobjid = CreateDynamicObject(1438, -228.462478, 1068.048828, 18.722187, 0.000000, 0.000000, 124.100013, object_world, object_int, -1, 300.00, 300.00); 
            var fk185 = new DynamicObject(1438, new Vector3(-228.462478, 1068.048828, 18.722187), new Vector3(0.000000, 0.000000, 124.100013), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1370, -223.796768, 1067.992309, 19.272199, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk186 = new DynamicObject(1370, new Vector3(-223.796768, 1067.992309, 19.272199), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 200);
           //tmpobjid = CreateDynamicObject(1462, -219.683837, 1072.614746, 18.732187, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00); 
            var fk187 = new DynamicObject(1462, new Vector3(-219.683837, 1072.614746, 18.732187), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(849, -223.431808, 1071.410400, 19.002193, 0.000000, 0.000000, -35.500000, object_world, object_int, -1, 300.00, 300.00); 
            var fk188 = new DynamicObject(849, new Vector3(-223.431808, 1071.410400, 19.002193), new Vector3(0.000000, 0.000000, -35.500000), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(1812, -230.462188, 1068.958251, 18.732187, 0.000000, 0.000000, 81.500007, object_world, object_int, -1, 300.00, 300.00); 
            var fk189 = new DynamicObject(1812, new Vector3(-230.462188, 1068.958251, 18.732187), new Vector3(0.000000, 0.000000, 81.500007), 0, 0, player, 200, 200);
            //tmpobjid = CreateDynamicObject(19306, -225.753463, 1069.229370, 21.957248, 0.000000, 14.900001, 82.700004, object_world, object_int, -1, 300.00, 300.00); 
            var fk190 = new DynamicObject(19306, new Vector3(-225.753463, 1069.229370, 21.957248), new Vector3(0.000000, 14.900001, 82.700004), 0, 0, player, 200, 200);
         
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
            //CreateDynamicObject(18268, 632.580566, 128.976120, 32.572262, 0.000000, 0.000000, 112.700043, -1, -1, -1, STREAMER_OBJECT_SD, 550.0); // 0
            var waterfall2 = new DynamicObject(18268, new Vector3(632.580566, 128.976120, 32.572262), new Vector3(0.000000, 0.000000, 112.700043), 0, 0, player, 200, 150);
            //CreateDynamicObject(747, 636.809143, 111.383476, 7.198639, 0.000000, 0.000000, 101.100105, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall3 = new DynamicObject(747, new Vector3(636.809143, 111.383476, 7.198639), new Vector3(0.000000, 0.000000, 101.100105), 0, 0, player, 200, 150);
            //CreateDynamicObject(873, 608.037415, 135.089325, 8.404539, 6.599977, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall4 = new DynamicObject(873, new Vector3(608.037415, 135.089325, 8.404539), new Vector3(6.599977, 0.000000, 1.000000), 0, 0, player, 200, 150);
            //CreateDynamicObject(819, 603.273193, 131.819519, 7.663627, 0.000000, 0.000000, 53.999947, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall5 = new DynamicObject(819, new Vector3(603.273193, 131.819519, 7.663627), new Vector3(0.000000, 0.000000, 53.999947), 0, 0, player, 200, 150);
            //CreateDynamicObject(18568, 606.114929, 125.994530, 7.630869, -2.500003, -4.999997, 87.500053, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall6 = new DynamicObject(18568, new Vector3(606.114929, 125.994530, 7.630869), new Vector3(-2.500003, -4.999997, 87.500053), 0, 0, player, 200, 150);
            //CreateDynamicObject(873, 608.760315, 144.729675, 8.841343, 10.999979, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall7 = new DynamicObject(873, new Vector3(608.760315, 144.729675, 8.841343), new Vector3(10.999979, 0.000000, 1.000000), 0, 0, player, 200, 150);
            //CreateDynamicObject(12986, 607.096191, 123.792526, 8.280583, 3.600008, 0.000000, -2.600002, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall8 = new DynamicObject(12986, new Vector3(607.096191, 123.792526, 8.280583), new Vector3(3.600008, 0.000000, -2.600002), 0, 0, player, 200, 150);
            //CreateDynamicObject(873, 620.225952, 139.902786, 8.697538, 6.899972, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall9 = new DynamicObject(873, new Vector3(620.225952, 139.902786, 8.697538), new Vector3(6.899972, 0.000000, 1.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(819, 599.420105, 123.963882, 7.353628, 0.000000, 0.000000, 53.999947, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall10 = new DynamicObject(819, new Vector3(599.420105, 123.963882, 7.353628), new Vector3(0.000000, 0.000000, 53.999947), 0, 0, player, 200, 150);
            // CreateDynamicObject(810, 610.618835, 120.646385, 6.473177, 0.000000, 0.000000, -53.199989, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall11 = new DynamicObject(810, new Vector3(610.618835, 120.646385, 6.473177), new Vector3(0.000000, 0.000000, -53.199989), 0, 0, player, 200, 150);
            // CreateDynamicObject(745, 635.041565, 109.403000, 6.009204, 0.000000, 0.000000, 43.900009, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall12 = new DynamicObject(745, new Vector3(635.041565, 109.403000, 6.009204), new Vector3(0.000000, 0.000000, 43.900009), 0, 0, player, 200, 150);
            // CreateDynamicObject(747, 638.941040, 112.225151, 7.298641, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall13 = new DynamicObject(747, new Vector3(638.941040, 112.225151, 7.298641), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(819, 606.219421, 118.178474, 6.243624, 0.000000, 0.000000, 152.099884, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall14 = new DynamicObject(819, new Vector3(606.219421, 118.178474, 6.243624), new Vector3(0.000000, 0.000000, 152.099884), 0, 0, player, 200, 150);
            // CreateDynamicObject(819, 599.434448, 116.721138, 6.455822, 0.000000, -10.799983, 53.999947, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall15 = new DynamicObject(819, new Vector3(599.434448, 116.721138, 6.455822), new Vector3(0.000000, -10.799983, 53.999947), 0, 0, player, 200, 150);
            // CreateDynamicObject(831, 608.061584, 112.483994, 6.386795, 4.999999, 0.000000, -33.500046, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall16 = new DynamicObject(831, new Vector3(608.061584, 112.483994, 6.386795), new Vector3(4.999999, 0.000000, -33.500046), 0, 0, player, 200, 150);
            // CreateDynamicObject(811, 632.107483, 135.785629, 10.476581, 0.000000, -2.900000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall17 = new DynamicObject(811, new Vector3(632.107483, 135.785629, 10.476581), new Vector3(0.000000, -2.900000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(19842, 636.680908, 100.705933, 6.184311, -9.800001, 0.000000, 50.999989, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall18 = new DynamicObject(19842, new Vector3(636.680908, 100.705933, 6.184311), new Vector3(-9.800001, 0.000000, 50.999989), 0, 0, player, 200, 150);
            // CreateDynamicObject(900, 629.041443, 94.328903, 5.874938, 0.000000, 0.000000, 158.800217, -1, -1, -1, STREAMER_OBJECT_SD, 450.0); // 0
            var waterfall19 = new DynamicObject(900, new Vector3(629.041443, 94.328903, 5.874938), new Vector3(0.000000, 0.000000, 158.800217), 0, 0, player, 200, 150);
            //  CreateDynamicObject(748, 644.973389, 105.738647, 7.058135, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall20 = new DynamicObject(748, new Vector3(644.973389, 105.738647, 7.058135), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            //  CreateDynamicObject(873, 592.004517, 112.057312, 5.772486, 6.599977, 0.000000, 1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            var waterfall21 = new DynamicObject(873, new Vector3(592.004517, 112.057312, 5.772486), new Vector3(6.599977, 0.000000, 1.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(748, 644.510254, 102.656044, 7.038139, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall22 = new DynamicObject(748, new Vector3(644.510254, 102.656044, 7.038139), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            //  CreateDynamicObject(819, 645.988586, 103.295326, 7.664309, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall23 = new DynamicObject(819, new Vector3(645.988586, 103.295326, 7.664309), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            //  CreateDynamicObject(823, 650.331909, 105.921837, 9.952043, 16.300013, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall24 = new DynamicObject(823, new Vector3(650.331909, 105.921837, 9.952043), new Vector3(16.300013, 0.000000, -53.699982), 0, 0, player, 200, 150);
            //  CreateDynamicObject(18271, 600.672302, 111.478630, 27.372145, 0.000000, 0.000000, -169.300247, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall25 = new DynamicObject(18271, new Vector3(600.672302, 111.478630, 27.372145), new Vector3(0.000000, 0.000000, -169.300247), 0, 0, player, 200, 150);
            //  CreateDynamicObject(19840, 646.483948, 97.932259, 5.989109, -12.400012, 0.000000, -129.200180, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall26 = new DynamicObject(19840, new Vector3(646.483948, 97.932259, 5.989109), new Vector3(-12.400012, 0.000000, -129.200180), 0, 0, player, 200, 150);
            //  CreateDynamicObject(18269, 584.691345, 139.058365, 29.488359, -10.900004, -11.899983, 110.500153, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall27 = new DynamicObject(18269, new Vector3(584.691345, 139.058365, 29.488359), new Vector3(-10.900004, -11.899983, 110.500153), 0, 0, player, 200, 150);
            //  CreateDynamicObject(19840, 652.128540, 95.422844, 7.495713, -28.100065, 0.000000, -139.400162, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall28 = new DynamicObject(19840, new Vector3(652.128540, 95.422844, 7.495713), new Vector3(-28.100065, 0.000000, -139.400162), 0, 0, player, 200, 150);
            //  CreateDynamicObject(18271, 670.058167, 162.202118, 33.902176, 0.000000, 0.000000, 139.899689, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall29 = new DynamicObject(18271, new Vector3(670.058167, 162.202118, 33.902176), new Vector3(0.000000, 0.000000, 139.899689), 0, 0, player, 200, 150);
             //  CreateDynamicObject(823, 627.671509, 108.917091, 7.372014, 0.000000, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall30 = new DynamicObject(823, new Vector3(627.671509, 108.917091, 7.372014), new Vector3(0.000000, 0.000000, -53.699982), 0, 0, player, 200, 150);
            //  CreateDynamicObject(18268, 632.580566, 128.976120, 32.572262, 0.000000, 0.000000, 112.700043, -1, -1, -1, STREAMER_OBJECT_SD, 550.0); // 0
            var waterfall31 = new DynamicObject(18268, new Vector3(632.580566, 128.976120, 32.572262), new Vector3(0.000000, 0.000000, 112.700043), 0, 0, player, 200, 150);
            // CreateDynamicObject(823, 638.846802, 114.074333, 8.292024, 0.000000, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall32 = new DynamicObject(823, new Vector3(638.846802, 114.074333, 8.292024), new Vector3(0.000000, 0.000000, -53.699982), 0, 0, player, 200, 150);
            //  CreateDynamicObject(747, 636.809143, 111.383476, 7.198639, 0.000000, 0.000000, 101.100105, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall33 = new DynamicObject(747, new Vector3(636.809143, 111.383476, 7.198639), new Vector3(0.000000, 0.000000, 101.100105), 0, 0, player, 200, 150);
            //  CreateDynamicObject(745, 635.041565, 109.403000, 6.009204, 0.000000, 0.000000, 43.900009, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall34 = new DynamicObject(745, new Vector3(635.041565, 109.403000, 6.009204), new Vector3(0.000000, 0.000000, 43.900009), 0, 0, player, 200, 150);
            //  CreateDynamicObject(747, 638.941040, 112.225151, 7.298641, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall35 = new DynamicObject(747, new Vector3(638.941040, 112.225151, 7.298641), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(744, 633.984619, 105.421783, 5.541283, 0.000000, 0.000000, -119.399979, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall36 = new DynamicObject(744, new Vector3(633.984619, 105.421783, 5.541283), new Vector3(0.000000, 0.000000, -119.399979), 0, 0, player, 200, 150);
            // CreateDynamicObject(744, 641.451172, 109.985519, 6.651288, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall37 = new DynamicObject(744, new Vector3(641.451172, 109.985519, 6.651288), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(19840, 636.959656, 104.741341, 3.660635, 0.000000, 0.000000, -54.600075, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall38 = new DynamicObject(19840, new Vector3(636.959656, 104.741341, 3.660635), new Vector3(0.000000, 0.000000, -54.600075), 0, 0, player, 200, 150);
            // CreateDynamicObject(19840, 637.219604, 103.746078, 3.926028, -10.600004, 0.000000, -84.200264, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall39 = new DynamicObject(19840, new Vector3(637.219604, 103.746078, 3.926028), new Vector3(-10.600004, 0.000000, -84.200264), 0, 0, player, 200, 150);
            //CreateDynamicObject(18741, 639.034180, 104.104660, 5.966312, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall40 = new DynamicObject(18741, new Vector3(639.034180, 104.104660, 5.966312), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            //CreateDynamicObject(19840, 640.478577, 104.649033, 3.910635, 0.000000, 0.000000, 30.599873, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall41 = new DynamicObject(19840, new Vector3(640.478577, 104.649033, 3.910635), new Vector3(0.000000, 0.000000, 30.599873), 0, 0, player, 200, 150);
            // CreateDynamicObject(19840, 640.478577, 104.649033, 3.660635, 0.000000, 0.000000, 88.499878, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall42 = new DynamicObject(19840, new Vector3(640.478577, 104.649033, 3.660635), new Vector3(0.000000, 0.000000, 88.499878), 0, 0, player, 200, 150);
            // CreateDynamicObject(19842, 636.680908, 100.705933, 6.184311, -9.800001, 0.000000, 50.999989, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall43 = new DynamicObject(19842, new Vector3(636.680908, 100.705933, 6.184311), new Vector3(-9.800001, 0.000000, 50.999989), 0, 0, player, 200, 150);
            //CreateDynamicObject(748, 644.600159, 107.633759, 7.268137, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall44 = new DynamicObject(748, new Vector3(644.600159, 107.633759, 7.268137), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(900, 629.041443, 94.328903, 5.874938, 0.000000, 0.000000, 158.800217, -1, -1, -1, STREAMER_OBJECT_SD, 450.0); // 0
            var waterfall45 = new DynamicObject(900, new Vector3(629.041443, 94.328903, 5.874938), new Vector3(0.000000, 0.000000, 158.800217), 0, 0, player, 200, 150);
            // CreateDynamicObject(748, 644.973389, 105.738647, 7.058135, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall46 = new DynamicObject(748, new Vector3(644.973389, 105.738647, 7.058135), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            // CreateDynamicObject(748, 645.023743, 104.044678, 7.058135, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall47 = new DynamicObject(748, new Vector3(645.023743, 104.044678, 7.058135), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            // CreateDynamicObject(748, 644.510254, 102.656044, 7.038139, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall48 = new DynamicObject(748, new Vector3(644.510254, 102.656044, 7.038139), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            // CreateDynamicObject(819, 645.988586, 103.295326, 7.664309, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall49 = new DynamicObject(819, new Vector3(645.988586, 103.295326, 7.664309), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(823, 650.331909, 105.921837, 9.952043, 16.300013, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall50 = new DynamicObject(823, new Vector3(650.331909, 105.921837, 9.952043), new Vector3(16.300013, 0.000000, -53.699982), 0, 0, player, 200, 150);
            // CreateDynamicObject(18269, 621.041382, 90.476845, 30.704412, 0.000000, 0.000000, -174.700058, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall51 = new DynamicObject(18269, new Vector3(621.041382, 90.476845, 30.704412), new Vector3(0.000000, 0.000000, -174.700058), 0, 0, player, 200, 150);
            // CreateDynamicObject(748, 645.930847, 100.306152, 6.978138, 0.000000, 0.000000, -31.999998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            var waterfall52 = new DynamicObject(748, new Vector3(645.930847, 100.306152, 6.978138), new Vector3(0.000000, 0.000000, -31.999998), 0, 0, player, 200, 150);
            // CreateDynamicObject(19840, 646.483948, 97.932259, 5.989109, -12.400012, 0.000000, -129.200180, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall53 = new DynamicObject(19840, new Vector3(646.483948, 97.932259, 5.989109), new Vector3(-12.400012, 0.000000, -129.200180), 0, 0, player, 200, 150);
            // CreateDynamicObject(823, 649.201599, 99.978813, 8.922026, 0.000000, 0.000000, -53.699982, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall54 = new DynamicObject(823, new Vector3(649.201599, 99.978813, 8.922026), new Vector3(0.000000, 0.000000, -53.699982), 0, 0, player, 200, 150);
            // CreateDynamicObject(819, 650.978943, 97.405319, 9.524314, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall55 = new DynamicObject(819, new Vector3(650.978943, 97.405319, 9.524314), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
             // CreateDynamicObject(19840, 652.128540, 95.422844, 7.495713, -28.100065, 0.000000, -139.400162, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall56 = new DynamicObject(19840, new Vector3(652.128540, 95.422844, 7.495713), new Vector3(-28.100065, 0.000000, -139.400162), 0, 0, player, 200, 150);
           // CreateDynamicObject(19840, 652.078430, 93.522972, 8.327264, -13.100025, 0.000000, -121.299965, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall57 = new DynamicObject(19840, new Vector3(652.078430, 93.522972, 8.327264), new Vector3(-13.100025, 0.000000, -121.299965), 0, 0, player, 200, 150);
            // CreateDynamicObject(745, 648.537109, 89.582680, 8.577349, 0.000000, -28.699997, -56.899994, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall58 = new DynamicObject(745, new Vector3(648.537109, 89.582680, 8.577349), new Vector3(0.000000, -28.699997, -56.899994), 0, 0, player, 200, 150);
            // CreateDynamicObject(18747, 652.719421, 92.898064, 8.374566, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall59 = new DynamicObject(18747, new Vector3(652.719421, 92.898064, 8.374566), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(744, 650.184875, 89.637444, 8.200315, 0.000000, 0.000000, -178.099869, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall60 = new DynamicObject(744, new Vector3(650.184875, 89.637444, 8.200315), new Vector3(0.000000, 0.000000, -178.099869), 0, 0, player, 200, 150);
            // CreateDynamicObject(18742, 651.894226, 91.012543, 6.507471, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            var waterfall61 = new DynamicObject(18742, new Vector3(651.894226, 91.012543, 6.507471), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(744, 655.182434, 93.622955, 10.470328, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall62 = new DynamicObject(744, new Vector3(655.182434, 93.622955, 10.470328), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            // CreateDynamicObject(19840, 653.643555, 91.464394, 9.986589, 9.899991, 0.000000, -113.299881, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            var waterfall63 = new DynamicObject(19840, new Vector3(653.643555, 91.464394, 9.986589), new Vector3(9.899991, 0.000000, -113.299881), 0, 0, player, 200, 150);
            // CreateDynamicObject(745, 657.156555, 92.852562, 12.624348, -26.899965, 0.000000, 59.799984, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall64 = new DynamicObject(745, new Vector3(657.156555, 92.852562, 12.624348), new Vector3(-26.899965, 0.000000, 59.799984), 0, 0, player, 200, 150);
            // CreateDynamicObject(745, 653.838135, 88.058426, 12.017090, 0.000000, -28.699997, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall65 = new DynamicObject(745, new Vector3(653.838135, 88.058426, 12.017090), new Vector3(0.000000, -28.699997, 0.000000), 0, 0, player, 200, 150);
             // CreateDynamicObject(745, 656.569214, 90.938438, 12.855083, -26.899965, 0.000000, 59.799984, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall66 = new DynamicObject(745, new Vector3(656.569214, 90.938438, 12.855083), new Vector3(-26.899965, 0.000000, 59.799984), 0, 0, player, 200, 150);
            // CreateDynamicObject(744, 656.749573, 88.653137, 13.441802, 0.000000, -42.800026, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            var waterfall67 = new DynamicObject(744, new Vector3(656.749573, 88.653137, 13.441802), new Vector3(0.000000, -42.800026, 0.000000), 0, 0, player, 200, 150);
             // CreateDynamicObject(719, 679.415710, 134.655609, 9.822523, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall68 = new DynamicObject(719, new Vector3(679.415710, 134.655609, 9.822523), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 200, 150);
            
            // CreateDynamicObject(18271, 670.058167, 162.202118, 33.902176, 0.000000, 0.000000, 139.899689, -1, -1, -1, STREAMER_OBJECT_SD, 500.0); // 0
            var waterfall69 = new DynamicObject(18271, new Vector3(670.058167, 162.202118, 33.902176), new Vector3(0.000000, 0.000000, 139.899689), 0, 0, player, 200, 150);
            
            // ПОСТ СНАЙПЕРА 
            // tmpobjid = CreateDynamicObject(12957, 179.947875, 868.839782, 17.914817, 6.999998, 0.000000, 39.900009, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 18065, "ab_sfammumain", "plywood_gym", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 18759, "dmcages", "metaldrumold1", 0xFFFFCCCC);
            // SetDynamicObjectMaterial(tmpobjid, 2, -1, "none", "none", 0xFFFFFF99);
            var post1 = new DynamicObject(12957, new Vector3(179.947875, 868.839782, 17.914817), new Vector3(6.999998, 0.000000, 39.900009), 0, 0, player, 300,300);
            post1.SetMaterial(0, 18065, "ab_sfammumain", "plywood_gym", 0x00000000);
            post1.SetMaterial(1, 18759, "dmcages", "metaldrumold1", 0xFFFFCCFF);
            post1.SetMaterial(2, -1, "none", "none", 0xFFFFFFFF);

            var post2 = new DynamicObject(3267, new Vector3(179.431411, 869.399108, 17.343687), new Vector3(0.000000, 9.299997, -95.999992), 0, 0, player, 300, 300);
            post2.SetMaterial(0, -1, "none", "none", 0xAF3333FF);
            post2.SetMaterial(1, -1, "none", "none", 0xAF3333FF);
            post2.SetMaterial(2, -1, "none", "none", 0xAF3333FF);
            post2.SetMaterial(3, -1, "none", "none", 0xAF3333FF);
            post2.SetMaterial(4, -1, "none", "none", 0xAF3333FF);
            post2.SetMaterial(5, -1, "none", "none", 0xAF3333FF);
            //post2.ShowInWorld(0);
            var post3 = new DynamicObject(359, new Vector3(180.105346, 869.888061, 17.962865), new Vector3(-83.299972, 49.099990, 12.399995), 0, 0, player, 300, 300);
            post3.SetMaterial(0, 2567, "ab", "ab_metalholes", 0x00000000);
            
            var post4 = new DynamicObject(2907, new Vector3(180.958847, 868.784118, 17.726039), new Vector3(-67.400001, 0.000000, -130.000015), 0, 0, player, 300, 300);
            post4.SetMaterial(0, -1, "none", "none", 0xFF666666);
           
            
            var post5 = new DynamicObject(3447, new Vector3(114.213058, 801.270141, 26.232803), new Vector3(0.000000, 180.000000, -100.899978), 0, 0, player, 300, 300);
            post5.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post5.SetMaterial(1, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post5.SetMaterial(2, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post5.SetMaterial(3, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post5.SetMaterial(4, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post5.SetMaterial(5, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            
            

            var post6 = new DynamicObject(3447, new Vector3(108.173988, 802.433593, 26.242803), new Vector3(0.000000, 180.000000, -100.899978), 0, 0, player, 300, 300);
            post6.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post6.SetMaterial(1, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post6.SetMaterial(2, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post6.SetMaterial(3, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post6.SetMaterial(4, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            post6.SetMaterial(5, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            
            var post7 = new DynamicObject(19376, new Vector3(112.334465, 801.867675, 30.029579), new Vector3(0.000000, 90.000000, -11.700001), 0, 0, player, 300, 300);
            post7.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
           
            var post8 = new DynamicObject(19376, new Vector3(112.334465, 801.867675, 33.669601), new Vector3(0.000000, 90.000000, -11.700001), 0, 0, player, 300, 300);
            post8.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            
            var post9 = new DynamicObject(19433, new Vector3(113.766769, 799.077697, 31.855520), new Vector3(0.000000, 0.000000, -12.800007), 0, 0, player, 300, 300);
            post9.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            var post10 = new DynamicObject(19433, new Vector3(114.191329, 801.062377, 30.825527), new Vector3(90.000000, -12.099999, 0.000000), 0, 0, player, 300, 300);
            post10.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
             var post11 = new DynamicObject(19433, new Vector3(114.728309, 803.310180, 31.855520), new Vector3(0.000000, 0.000000, -12.800007), 0, 0, player, 300, 300);
            post11.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            var post12 = new DynamicObject(19376, new Vector3(112.334465, 801.867675, 33.669601), new Vector3(0.000000, 90.000000, -11.700001), 0, 0, player, 300, 300);
            post12.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
           
            // tmpobjid = CreateDynamicObject(3633, 113.937919, 804.223510, 30.575511, 0.000000, 0.000000, -12.399994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post13 = new DynamicObject(3633, new Vector3(113.937919, 804.223510, 30.575511), new Vector3(0.000000, 0.000000, -12.399994), 0, 0, player, 300, 300);
            post13.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            //  tmpobjid = CreateDynamicObject(3633, 112.638954, 804.509155, 30.575511, 0.000000, 0.000000, -12.399994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post14 = new DynamicObject(3633, new Vector3(112.638954, 804.509155, 30.575511), new Vector3(0.000000, 0.000000, -12.399994), 0, 0, player, 300, 300);
            post14.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            //  tmpobjid = CreateDynamicObject(3633, 111.418159, 804.777343, 30.575511, 0.000000, 0.000000, -12.399994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post15 = new DynamicObject(3633, new Vector3(111.418159, 804.777343, 30.575511), new Vector3(0.000000, 0.000000, -12.399994), 0, 0, player, 300, 300);
            post15.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
             //  tmpobjid = CreateDynamicObject(3633, 110.148475, 805.056640, 30.575511, 0.000000, 0.000000, -6.899994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post16 = new DynamicObject(3633, new Vector3(110.148475, 805.056640, 30.575511), new Vector3(0.000000, 0.000000, -6.899994), 0, 0, player, 300, 300);
            post16.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            //  tmpobjid = CreateDynamicObject(3633, 110.148475, 805.056640, 31.525526, 0.000000, 0.000000, -6.899994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post17 = new DynamicObject(3633, new Vector3(110.148475, 805.056640, 31.525526), new Vector3(0.000000, 0.000000, -6.899994), 0, 0, player, 300, 300);
            post17.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            //  tmpobjid = CreateDynamicObject(3633, 111.418159, 804.777343, 31.525510, 0.000000, 0.000000, -12.399994, object_world, object_int, -1, 300.00, 300.00);
            //   SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post18 = new DynamicObject(3633, new Vector3(111.418159, 804.777343, 31.525510), new Vector3(0.000000, 0.000000, -12.399994), 0, 0, player, 300, 300);
            post18.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
             //  tmpobjid = CreateDynamicObject(3633, 112.638954, 804.509155, 31.525524, 0.000000, 0.000000, -12.399994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post19 = new DynamicObject(3633, new Vector3(112.638954, 804.509155, 31.525524), new Vector3(0.000000, 0.000000, -12.399994), 0, 0, player, 300, 300);
            post19.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            //   tmpobjid = CreateDynamicObject(3633, 113.937919, 804.223510, 31.515520, 0.000000, 0.000000, -12.399994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post20 = new DynamicObject(3633, new Vector3(113.937919, 804.223510, 31.515520), new Vector3(0.000000, 0.000000, -12.399994), 0, 0, player, 300, 300);
            post20.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            
             var post21 = new DynamicObject(19433, new Vector3(111.849128, 798.772460, 30.825527), new Vector3(90.000000, -12.099999, 90.000000), 0, 0, player, 300, 300);
            post21.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            
            var post22 = new DynamicObject(19433, new Vector3(109.205070, 799.319335, 30.815526), new Vector3(90.000000, -12.099999, 90.000000), 0, 0, player, 300, 300);
            post22.SetMaterial(0, 3374, "ce_farmxref", "sw_barnwood5", 0x00000000);
            
            //tmpobjid = CreateDynamicObject(3633, 108.279563, 798.684143, 30.575511, 0.000000, 0.000000, -6.899994, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post23 = new DynamicObject(3633, new Vector3(108.279563, 798.684143, 30.575511), new Vector3(0.000000, 0.000000, -6.899994), 0, 0, player, 300, 300);
            post23.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            
            // tmpobjid = CreateDynamicObject(3633, 109.671287, 798.364990, 30.575511, 0.000000, 0.000000, -6.899994, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post24 = new DynamicObject(3633, new Vector3(109.671287, 798.364990, 30.575511), new Vector3(0.000000, 0.000000, -6.899994), 0, 0, player, 300, 300);
            post24.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            
            // tmpobjid = CreateDynamicObject(3633, 110.973358, 798.137084, 30.575511, 0.000000, 0.000000, -6.899994, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post25 = new DynamicObject(3633, new Vector3(110.973358, 798.137084, 30.575511), new Vector3(0.000000, 0.000000, -6.899994), 0, 0, player, 300, 300);
            post25.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            
            //  tmpobjid = CreateDynamicObject(3633, 112.398216, 797.955749, 30.575511, 0.000000, 0.000000, -12.799994, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 17003, "countrys", "rustc256128", 0x00000000);
            var post26 = new DynamicObject(3633, new Vector3(112.398216, 797.955749, 30.575511), new Vector3(0.000000, 0.000000, -12.799994), 0, 0, player, 300, 300);
            post26.SetMaterial(1, 17003, "countrys", "rustc256128", 0x00000000);
            
            var post27 = new DynamicObject(19108, new Vector3(113.772743, 802.898742, 31.086963), new Vector3(-14.899999, -86.200080, -14.500000), 0, 0, player, 300, 300);
            post27.SetMaterial(0, 11100, "bendytunnel_sfse", "blackmetal", 0x00000000);
            
            var post28 = new DynamicObject(2064, new Vector3(174.977813, 783.787597, 21.427362), new Vector3(17.999996, 0.000000, 62.400009), 0, 0, player, 300, 300);
            post28.SetMaterial(0, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            
            //   tmpobjid = CreateDynamicObject(2035, 180.481536, 868.493530, 17.743103, -2.399994, -111.599967, -53.599971, object_world, object_int, -1, 300.00, 300.00);
            var post29 = new DynamicObject(2035, new Vector3(180.481536, 868.493530, 17.743103), new Vector3(-2.399994, -111.599967, -53.599971), 0, 0, player, 300, 300);
            //   tmpobjid = CreateDynamicObject(1327, 193.189086, 858.760681, 15.180621, 0.000000, 95.399986, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post30 = new DynamicObject(1327, new Vector3(193.189086, 858.760681, 15.180621), new Vector3(0.000000, 95.399986, 0.000000), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(1327, 189.058303, 863.850952, 15.792070, 0.000000, 95.399986, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post31 = new DynamicObject(1327, new Vector3(189.058303, 863.850952, 15.792070), new Vector3(0.000000, 95.399986, 0.000000), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(1414, 113.372222, 805.022888, 32.573123, 0.000000, 0.000000, -12.309999, object_world, object_int, -1, 300.00, 300.00);
            var post32 = new DynamicObject(1414, new Vector3(113.372222, 805.022888, 32.573123), new Vector3(0.000000, 0.000000, -12.309999), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(1414, 110.435646, 805.684448, 32.573150, 0.000000, 0.000000, -12.309999, object_world, object_int, -1, 300.00, 300.00);
            var post33 = new DynamicObject(1414, new Vector3(110.435646, 805.684448, 32.573150), new Vector3(0.000000, 0.000000, -12.309999), 0, 0, player, 300, 300);
            
            //  tmpobjid = CreateDynamicObject(3117, 114.082519, 800.185607, 30.545471, 90.000000, 77.099983, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post34 = new DynamicObject(3117, new Vector3(114.082519, 800.185607, 30.545471), new Vector3(90.000000, 77.099983, 0.000000), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(3117, 114.543014, 802.285705, 30.545471, 90.000000, 77.099983, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post35 = new DynamicObject(3117, new Vector3(114.543014, 802.285705, 30.545471), new Vector3(90.000000, 77.099983, 0.000000), 0, 0, player, 300, 300);
            
            //  tmpobjid = CreateDynamicObject(964, 113.572402, 802.906433, 30.055515, 0.000000, 0.000000, -65.699958, object_world, object_int, -1, 300.00, 300.00);
            var post366 = new DynamicObject(964, new Vector3(113.572402, 802.906433, 30.055515), new Vector3(0.000000, 0.000000, -65.699958), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(1812, 108.872169, 800.209106, 30.115516, 0.000000, 0.000000, -106.300003, object_world, object_int, -1, 300.00, 300.00);
            var post36 = new DynamicObject(1812, new Vector3(108.872169, 800.209106, 30.115516), new Vector3(0.000000, 0.000000, -106.300003), 0, 0, player, 300, 300);
            
            //  tmpobjid = CreateDynamicObject(2036, 113.457786, 799.087951, 30.697496, 0.000000, -70.699989, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post37 = new DynamicObject(2036, new Vector3(113.457786, 799.087951, 30.697496), new Vector3(0.000000, -70.699989, 0.000000), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(2037, 113.252258, 803.139770, 31.075508, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post38 = new DynamicObject(2037, new Vector3(113.252258, 803.139770, 31.075508), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(2039, 113.454071, 802.463073, 31.055532, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post39 = new DynamicObject(2039, new Vector3(113.454071, 802.463073, 31.055532), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(11747, 113.158470, 802.860473, 31.035516, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post40 = new DynamicObject(11747, new Vector3(113.158470, 802.860473, 31.035516), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(2060, 175.738128, 782.924987, 20.963338, 0.000000, 0.000000, 70.099937, object_world, object_int, -1, 300.00, 300.00);
            var post41 = new DynamicObject(2060, new Vector3(175.738128, 782.924987, 20.963338), new Vector3(0.000000, 0.000000, 70.099937), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(2060, 175.738128, 782.924987, 20.793338, 0.000000, 0.000000, 70.099937, object_world, object_int, -1, 300.00, 300.00);
            var post42 = new DynamicObject(2060, new Vector3(175.738128, 782.924987, 20.793338), new Vector3(0.000000, 0.000000, 70.099937), 0, 0, player, 300, 300);
            
            //  tmpobjid = CreateDynamicObject(2060, 175.208358, 782.308898, 20.783338, 0.000000, 0.000000, 38.099933, object_world, object_int, -1, 300.00, 300.00);
            var post43 = new DynamicObject(2060, new Vector3(175.208358, 782.308898, 20.783338), new Vector3(0.000000, 0.000000, 38.099933), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(2060, 175.208358, 782.308898, 20.993343, 0.000000, 0.000000, 38.099933, object_world, object_int, -1, 300.00, 300.00);
            var post44 = new DynamicObject(2060, new Vector3(175.208358, 782.308898, 20.993343), new Vector3(0.000000, 0.000000, 38.099933), 0, 0, player, 300, 300);
            
            //  tmpobjid = CreateDynamicObject(2060, 175.982681, 783.804443, 20.993343, 0.000000, 0.000000, 78.699913, object_world, object_int, -1, 300.00, 300.00);
            var post45 = new DynamicObject(2060, new Vector3(175.982681, 783.804443, 20.993343), new Vector3(0.000000, 0.000000, 78.699913), 0, 0, player, 300, 300);
            
            //   tmpobjid = CreateDynamicObject(2060, 175.982681, 783.804443, 21.263349, 0.000000, 0.000000, 78.699913, object_world, object_int, -1, 300.00, 300.00);
            var post46 = new DynamicObject(2060, new Vector3(175.982681, 783.804443, 21.263349), new Vector3(0.000000, 0.000000, 78.699913), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(2060, 175.707247, 783.064270, 21.193329, 0.000000, 0.000000, 69.599960, object_world, object_int, -1, 300.00, 300.00);
            var post47 = new DynamicObject(2060, new Vector3(175.707229, 783.064270, 21.193347), new Vector3(0.000000, 0.000000, 69.599960), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(2060, 175.351272, 782.464172, 21.203329, 0.000000, 0.000000, 57.199970, object_world, object_int, -1, 300.00, 300.00);
            var post48 = new DynamicObject(2060, new Vector3(175.351272, 782.464172, 21.203329), new Vector3(0.000000, 0.000000, 57.199970), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(845, 142.861862, 822.868774, 24.143335, 0.000000, 0.000000, 79.099990, object_world, object_int, -1, 300.00, 300.00);
            var post49 = new DynamicObject(845, new Vector3(142.861862, 822.868774, 24.143335), new Vector3(0.000000, 0.000000, 79.099990), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(883, 150.111160, 810.187988, 25.213596, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post50 = new DynamicObject(883, new Vector3(129.111160, 810.187988, 25.213596), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(883, 151.111160, 800.737670, 25.363599, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post51 = new DynamicObject(883, new Vector3(129.111160, 800.737670, 25.363599), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(883, 143.281158, 800.737670, 23.263593, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post52 = new DynamicObject(883, new Vector3(143.281158, 800.737670, 23.263593), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(883, 136.811187, 820.347778, 23.973579, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post53 = new DynamicObject(883, new Vector3(136.811187, 820.347778, 23.973579), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(888, 164.381958, 812.681274, 20.817733, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post54 = new DynamicObject(888, new Vector3(164.381958, 812.681274, 20.817733), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(888, 162.338394, 776.697387, 21.592592, 0.000000, 0.000000, 123.000000, object_world, object_int, -1, 300.00, 300.00);
            var post55 = new DynamicObject(888, new Vector3(162.338394, 776.697387, 21.59259), new Vector3(0.000000, 0.000000, 123.000000), 0, 0, player, 300, 300);
            

            // tmpobjid = CreateDynamicObject(891, 134.049697, 773.162597, 25.001918, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post56 = new DynamicObject(891, new Vector3(134.049697, 773.162597, 25.001918), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(765, 106.602859, 776.127957, 28.432466, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post57 = new DynamicObject(765, new Vector3(106.602859, 776.127929, 28.432466), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(883, 89.791137, 803.147949, 32.143661, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post58 = new DynamicObject(883, new Vector3(89.791137, 803.147949, 32.143661), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(842, 113.986541, 789.573547, 28.645605, 0.000000, 12.600002, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post59 = new DynamicObject(842, new Vector3(113.986541, 789.573547, 28.645605), new Vector3(0.000000, 12.600002, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(747, 146.052413, 793.834655, 23.811565, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post60 = new DynamicObject(747, new Vector3(146.052413, 793.834655, 23.811565), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(745, 158.921279, 813.888061, 21.182636, 0.000000, 0.000000, -98.199996, object_world, object_int, -1, 300.00, 300.00);
            var post61 = new DynamicObject(745, new Vector3(158.921279, 813.888061, 21.182636), new Vector3(0.000000, 0.000000, -98.199996), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(883, 117.811218, 862.058166, 27.273649, 0.000000, 0.000000, 75.800003, object_world, object_int, -1, 300.00, 300.00);
            var post62 = new DynamicObject(883, new Vector3(117.811218, 829.058166, 27.273649), new Vector3(0.000000, 0.000000, 75.800003), 0, 0, player, 300, 300);
            

            // tmpobjid = CreateDynamicObject(3568, 308.348083, 778.045532, 14.532345, -3.629988, -0.499999, -154.199859, object_world, object_int, -1, 300.00, 300.00);
            var post63 = new DynamicObject(3568, new Vector3(308.348083, 778.045532, 14.532345), new Vector3(-3.629988, -0.499999, -154.199859), 0, 0, player, 300, 300);
            

            // tmpobjid = CreateDynamicObject(1438, 303.753540, 786.940612, 12.816252, -6.499999, 0.000000, -159.800003, object_world, object_int, -1, 300.00, 300.00);
            var post64 = new DynamicObject(1438, new Vector3(303.753540, 786.940612, 12.816252), new Vector3(-6.499999, 0.000000, -159.800003), 0, 0, player, 300, 300);
           
            // tmpobjid = CreateDynamicObject(1431, 301.693420, 788.839477, 13.587911, 0.000000, 4.659998, -64.400001, object_world, object_int, -1, 300.00, 300.00);
            var post65 = new DynamicObject(1431, new Vector3(301.693420, 788.839477, 13.587911), new Vector3(0.000000, 4.659998, -64.400001), 0, 0, player, 300, 300);
           

            //  tmpobjid = CreateDynamicObject(2654, 302.467926, 787.192443, 13.109884, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post66 = new DynamicObject(2654, new Vector3(302.467926, 787.192443, 13.109884), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(747, 206.142410, 833.124633, 13.161579, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            var post67 = new DynamicObject(747, new Vector3(206.142410, 833.124633, 13.161579), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            

            //  tmpobjid = CreateDynamicObject(3594, 225.402420, 836.686767, 13.464322, 0.300002, -2.899999, 41.000007, object_world, object_int, -1, 300.00, 300.00);
            var post68 = new DynamicObject(3594, new Vector3(225.402420, 836.686767, 13.464322), new Vector3(0.300002, -2.899999, 41.000007), 0, 0, player, 300, 300);
           

            //tmpobjid = CreateDynamicObject(1800, 2066.083007, 2496.368652, 9.182893, 0.000000, 0.000000, -71.799972, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 1, 19962, "samproadsigns", "materialtext1", 0x00000000);
            var lvstreets1 = new DynamicObject(1800, new Vector3(2066.083007, 2496.368652, 9.182893), new Vector3(0.000000, 0.000000, -71.799972), 0, 0, player, 300, 300);
            lvstreets1.SetMaterial(1, 19962, "samproadsigns", "materialtext1");
            

            // tmpobjid = CreateDynamicObject(2907, 2309.559326, 2453.817626, 9.850313, 180.000000, 0.000000, -38.500003, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFF999999);
            // SetDynamicObjectMaterial(tmpobjid, 1, -1, "none", "none", 0xFF660000);
            var lvstreets2 = new DynamicObject(2907, new Vector3(2309.559326, 2453.817626, 9.850313), new Vector3(180.000000, 0.000000, -38.500003), 0, 0, player, 300, 300);
            lvstreets2.SetMaterial(0, -1, "none", "none", 0xFF999999);
            lvstreets2.SetMaterial(1, -1, "none", "none", 0xFF660000);
            

            //  tmpobjid = CreateDynamicObject(19370, 2305.685791, 2462.001464, 9.730310, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0x00000000);
            var lvstreets3 = new DynamicObject(19370, new Vector3(2305.685791, 2462.001464, 9.730310), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            lvstreets3.SetMaterial(0, 14612, "ab_abattoir_box", "ab_bloodfloor");
           
            //  tmpobjid = CreateDynamicObject(19370, 2303.225097, 2462.001464, 9.740309, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0x00000000);
            var lvstreets4 = new DynamicObject(19370, new Vector3(2303.225097, 2462.001464, 9.740309), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            lvstreets4.SetMaterial(0, 14612, "ab_abattoir_box", "ab_bloodfloor");
            
            //  tmpobjid = CreateDynamicObject(19370, 2308.375976, 2453.995849, 9.740309, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0x00000000);
            var lvstreets5 = new DynamicObject(19370, new Vector3(2308.375976, 2453.995849, 9.740309), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            lvstreets5.SetMaterial(0, 14612, "ab_abattoir_box", "ab_bloodfloor");
            

            //  tmpobjid = CreateDynamicObject(19370, 2302.245605, 2433.054443, 9.773771, 0.099999, 90.199996, -48.600002, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0x00000000);
            var lvstreets6 = new DynamicObject(19370, new Vector3(2302.245605, 2433.054443, 9.773771), new Vector3(0.099999, 90.199996, -48.600002), 0, 0, player, 300, 300);
            lvstreets6.SetMaterial(0, 14612, "ab_abattoir_box", "ab_bloodfloor");
            

            //  tmpobjid = CreateDynamicObject(3092, 1907.937866, 707.978393, 12.543086, 0.000000, 19.799997, 76.800064, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 1982, "new_cabinets", "meat1", 0x00000000);
            var lvstreets7 = new DynamicObject(3092, new Vector3(1907.937866, 707.978393, 12.543086), new Vector3(0.000000, 19.799997, 76.800064), 0, 0, player, 300, 300);
            lvstreets7.SetMaterial(1, 1982, "new_cabinets", "meat1");
            
            
            //  tmpobjid = CreateDynamicObject(19368, 1907.883178, 708.015441, 9.766384, 0.000000, 90.000000, 138.500122, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0x00000000);
            var lvstreets8 = new DynamicObject(19368, new Vector3(1907.883178, 708.015441, 9.766384), new Vector3(0.000000, 90.000000, 138.500122), 0, 0, player, 300, 300);
            lvstreets8.SetMaterial(0, 14612, "ab_abattoir_box", "ab_bloodfloor");
            

            void CreateDynamicObject(int objectId, double x, double y, double z, double rx, double ry, double rz, int objectWorld, int object_int, int hueta, double trista, double trista2)
            {
                var objecto = new DynamicObject(objectId, new Vector3(x,y,z), new Vector3(rx,ry,rz), objectWorld, object_int,player, (float)trista, (float)trista2);
                
            }
            int object_world = 0;
            int object_int = 0;
            //fso_map = CreateDynamicObject(19376, 296.398468, 189.338058, 1011.240234, 0.000000, 0.000000, 90.000000, -1, 3, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 12944, "ce_bankalley2", "sw_brick04", 0);

            var lvpd1 = new DynamicObject(19376, new Vector3(296.398468, 189.338058, 1011.240234), new Vector3(0.000000, 0.000000, 90.000000), 1020, 3, player, 300, 300);
            lvpd1.SetMaterial(0, 12944, "ce_bankalley2", "sw_brick04");
            //fso_map = CreateDynamicObject(19370, 268.082581, 177.380569, 1003.318359, 0.200000, 56.900005, 1.400005, -1, 3, -1, STREAMER_OBJECT_SD, 250.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);
            var lvpd2 = new DynamicObject(19370, new Vector3(268.082581, 177.380569, 1003.318359), new Vector3(0.200000, 56.900005, 1.400005), 1020, 3, player, 300, 300);
            lvpd2.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor");
            //fso_map = CreateDynamicObject(19376, 275.149078, 189.358047, 1011.240234, 0.000000, 0.000000, 90.000000, -1, 3, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 12944, "ce_bankalley2", "sw_brick04", 0);

            var lvpd3 = new DynamicObject(19376, new Vector3(275.149078, 189.358047, 1011.240234), new Vector3(0.000000, 0.000000, 90.000000), 1020, 3, player, 300, 300);
            lvpd3.SetMaterial(0, 12944, "ce_bankalley2", "sw_brick04");
            //fso_map = CreateDynamicObject(19370, 252.314835, 169.140182, 1001.943604, 0.000000, 90.000000, 0.000000, -1, 3, -1, STREAMER_OBJECT_SD, 250.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);
            var lvpd4 = new DynamicObject(19370, new Vector3(252.314835, 169.140182, 1001.943604), new Vector3(0.000000, 90.000000, 0.000000), 1020, 3, player, 300, 300);
            lvpd4.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor");
            //fso_map = CreateDynamicObject(19370, 249.133545, 147.213730, 1002.000000, 0.200000, 90.000000, 176.700089, -1, 3, -1, STREAMER_OBJECT_SD, 250.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);
            var lvpd5 = new DynamicObject(19370, new Vector3(249.133545, 147.213730, 1002.000000), new Vector3(0.200000, 90.000000, 176.700089), 1020, 3, player, 300, 300);
            lvpd5.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor");

            //fso_map = CreateDynamicObject(19376, 238.679092, 185.807907, 1002.359497, 0.000000, 0.000000, 90.000000, -1, 3, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 12944, "ce_bankalley2", "sw_brick04", 0);
            var lvpd6 = new DynamicObject(19376, new Vector3(238.679092, 185.807907, 1002.359497), new Vector3(0.000000, 0.000000, 90.000000), 1020, 3, player, 300, 300);
            lvpd6.SetMaterial(0, 12944, "ce_bankalley2", "sw_brick04");

            //fso_map = CreateDynamicObject(19370, 248.016663, 149.211349, 1001.993408, 0.200000, 90.000000, 176.700089, -1, 3, -1, STREAMER_OBJECT_SD, 250.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);
            var lvpd7 = new DynamicObject(19370, new Vector3(248.016663, 149.211349, 1001.993408), new Vector3(0.200000, 90.000000, 176.700089), 1020, 3, player, 300, 300);
            lvpd7.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor");

            //fso_map = CreateDynamicObject(19370, 229.690781, 145.688156, 1001.953430, 0.200000, 90.000000, 143.299988, -1, 3, -1, STREAMER_OBJECT_SD, 250.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);
            var lvpd8 = new DynamicObject(19370, new Vector3(229.690781, 145.688156, 1001.953430), new Vector3(0.200000, 90.000000, 143.299988), 1020, 3, player, 300, 300);
            lvpd8.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor");


            CreateDynamicObject(18451, 962.422485, 1732.462158, 8.058440, 0.000000, 0.000000, -110.699958, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 977.146301, 1722.231811, 7.988439, 0.000000, 0.000000, -47.499996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(960, 957.537231, 1713.951049, 7.968439, 0.000000, 0.000000, -44.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 971.981384, 1741.771240, 7.918441, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(850, 973.558654, 1752.275756, 7.758438, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, 976.512634, 1698.437622, 8.698454, 0.000000, 0.000000, 33.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1349, 955.104614, 1747.247924, 8.208449, 0.000000, 0.000000, -34.399997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 956.555053, 1741.892456, 7.918441, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19967, 995.783142, 1697.680053, 9.730083, -98.299880, -1.000000, 72.900024, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 938.425903, 1838.242797, 9.820526, 0.000000, -4.900002, 93.399971, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 921.442565, 1861.580688, 10.320322, 0.000000, 0.000000, -113.200042, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 916.565124, 1866.152587, 10.330320, 0.000000, 0.000000, 40.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 908.831970, 1877.718505, 10.191885, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 905.320007, 1892.351806, 10.121885, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 962.399414, 1853.853393, 10.111880, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1300, 949.304321, 1862.322265, 10.180318, 90.000000, 54.400012, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1338, 941.242004, 1877.039306, 10.510317, 0.000000, 0.000000, -71.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1372, 965.492797, 1874.950073, 9.920313, 0.000000, 0.000000, -33.100017, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(933, 949.776916, 1885.986816, 9.800312, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1438, 939.791870, 1878.434082, 9.820311, 0.000000, 0.000000, 119.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1259, 926.729125, 1903.354003, 12.281867, 360.000000, 90.000000, -127.199729, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1350, 913.253112, 1945.369750, 10.019669, 86.200042, -101.999969, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 903.604309, 2002.092041, 10.211878, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3460, 904.685852, 2015.120727, 9.861884, 0.000000, 90.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2669, 883.020629, 2023.206054, 11.160321, 0.000000, 0.000000, 52.800018, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 882.574096, 2023.831909, 10.420310, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, 884.510742, 2005.119018, 11.040313, 0.000000, 0.000000, 147.399978, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1415, 885.228820, 2007.483276, 9.820311, 0.000000, 0.000000, 96.299980, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1334, 876.411560, 2016.120605, 10.920324, 0.000000, 0.000000, 41.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 879.904052, 2014.772094, 10.350312, 0.000000, 0.000000, 52.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(849, 871.900695, 2026.990966, 10.070307, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2679, 877.236938, 2021.153564, 9.830389, -89.499862, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 867.795593, 2006.430297, 9.920313, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 890.264404, 2014.506713, 9.920313, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, 890.500366, 2005.209472, 9.840312, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18451, 906.252807, 2067.895507, 9.971880, 0.000000, 0.000000, 19.200006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 909.833679, 2096.235839, 10.071884, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 905.058654, 2150.906982, 10.061882, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 885.608764, 2111.892578, 10.190312, 0.000000, 0.000000, 36.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3046, 891.314331, 2082.599365, 10.150319, 0.000000, 0.000000, 48.399990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(942, 1025.854370, 2122.041503, 10.348942, 90.000000, 122.800064, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1009.526306, 2116.972656, 9.820311, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1005.939270, 2096.184082, 10.090313, 0.000000, 0.000000, 17.700000, object_world, object_int, -1, 300.00, 300.00);
            //

            CreateDynamicObject(2960, 1003.318115, 2169.324951, 10.167435, 0.000000, 3.399960, 0.000000, object_world, object_int, -1, 300.00, 300.00);


            CreateDynamicObject(2991, 996.595092, 2129.773925, 10.440320, 0.000000, 0.000000, 56.599994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1331, 1013.899902, 2208.503906, 10.701889, 0.000000, 0.000000, 30.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1021.466735, 2246.732666, 10.220313, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(12957, 983.925231, 2307.198730, 11.116226, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(913, 993.380187, 2311.537353, 11.021861, 0.000000, 3.500005, 49.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(960, 999.729309, 2259.739990, 10.161886, 0.000000, 0.000000, 33.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1224, 995.586303, 2234.059082, 10.425174, 0.000000, 0.000000, 19.999998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18248, 977.148193, 2224.476806, 17.770330, 0.000000, 0.000000, 156.799942, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18246, 940.634338, 2222.349365, 12.090304, 0.000000, 0.000000, 0.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16317, 980.753662, 2236.923828, 9.880316, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3866, 1040.973388, 2252.510742, 17.570301, 0.000000, 0.000000, 540.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16305, 1035.226074, 2248.471191, 12.950305, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(12957, 1058.637451, 2272.867187, 10.590313, 0.000000, 0.000000, -60.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(963, 1019.565246, 2277.697753, 9.820311, 0.000000, 0.000000, 60.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(924, 1034.363403, 2267.299560, 10.050316, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1369, 1034.092773, 2276.057861, 10.440325, 0.000000, 0.000000, -30.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3035, 1024.538940, 2269.022949, 10.460992, 77.900085, -16.999992, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1010.029296, 1486.412353, 10.161879, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1007.314208, 1532.922729, 10.151885, 0.000000, 0.000000, 165.599975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1004.883422, 1620.215942, 10.143445, 0.000000, 0.000000, 13.699999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1438, 1015.331115, 1560.456054, 9.760310, 0.000000, 0.000000, -22.300001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1257, 1072.895996, 2058.254150, 10.963727, 1.200000, 0.000000, 25.800006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1787.258666, 2545.780517, 13.285946, 0.000000, 0.000000, -27.299997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1787.756591, 2538.866943, 13.390908, 1.500000, 0.000000, -143.100036, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1797.104614, 2540.698974, 13.585946, 0.000000, 0.000000, -125.099975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1797.104614, 2540.698974, 13.585946, 0.000000, 0.000000, -125.099975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1797.707153, 2535.063476, 13.695947, 0.000000, 0.000000, -125.099975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1806.078857, 2523.834472, 13.955953, 0.000000, 0.000000, -145.699874, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1814.391967, 2517.936035, 13.955953, 0.000000, 0.000000, -158.799896, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1809.515502, 2516.044677, 13.815951, 0.000000, 0.000000, -158.799896, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1814.700073, 2512.004394, 13.815951, 0.000000, 0.000000, -107.599884, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1810.168090, 2506.184082, 13.815951, 0.000000, 0.000000, 131.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1819.598754, 2504.511230, 13.955953, 0.000000, 0.000000, -158.799896, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1815.449218, 2501.603271, 13.955953, 0.000000, 0.000000, -158.799896, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3460, 1439.707641, 2710.405517, 9.917860, 0.000000, -91.399856, -80.899986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1334, 1375.497558, 2716.267089, 10.771873, 0.000000, 0.000000, -49.099994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1327.678466, 2679.976318, 10.250310, 0.000000, 0.000000, 72.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1326.994628, 2690.070312, 10.250310, 0.000000, 0.000000, 143.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, 1350.186767, 2669.071533, 10.030315, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, 1437.281005, 2648.326904, 10.992617, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, 1432.069580, 2648.326904, 10.702610, 90.000000, -51.200012, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1366, 1458.729370, 2719.182373, 10.258397, 17.399990, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11730, 1478.329833, 2711.745361, 9.978622, 90.000000, 26.500000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1538.041381, 2718.785400, 10.258492, 0.000000, 6.199999, -38.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3568, 1110.650268, 2463.197021, 12.010456, 0.000000, 0.000000, -127.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1079.655517, 2494.551025, 10.104831, 0.000000, 0.000000, 55.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1074.785278, 2493.093505, 10.104831, 0.000000, 0.000000, 55.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 1083.042602, 2491.789550, 10.491602, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1080.866699, 2489.023925, 10.104831, 0.000000, 0.000000, 55.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(14468, 1078.364379, 2494.344970, 10.183449, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1089.096191, 2488.149658, 10.104831, 0.000000, 0.000000, 55.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 1088.981567, 2493.901123, 10.491602, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 1085.780151, 2501.212890, 10.061594, 0.000000, 0.000000, 49.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 1042.898437, 2538.969482, 9.530336, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 1007.436584, 2554.643554, 9.530336, 0.000000, 0.000000, 50.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1084.137451, 2504.027832, 10.104831, 0.000000, 0.000000, 55.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1091.121459, 2502.375244, 10.104831, 0.000000, 0.000000, -103.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 1129.860839, 2475.950683, 9.501605, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 1125.171508, 2473.067871, 9.501605, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(14469, 1111.974365, 2461.688232, 9.652280, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(14469, 1115.807495, 2460.343017, 9.652280, 0.000000, 0.000000, -31.300006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1134.960937, 2453.736816, 10.104831, 0.000000, 0.000000, 55.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1197.742309, 2475.949951, 8.539357, 3.400000, 0.000000, 79.199989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, 1768.941650, 2761.571777, 11.025952, 0.000000, 0.000000, -16.300001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1327, 1764.034423, 2768.633544, 9.835936, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(14467, 1763.854370, 2804.851318, 8.308565, -57.799980, 38.899993, -1.099939, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1369, 1761.210083, 2727.505126, 10.435940, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1328, 1798.632568, 2708.554443, 10.012209, -107.799980, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1327, 1808.588623, 2715.885253, 9.681875, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 1757.253540, 2715.327392, 9.671875, 0.000000, 0.000000, 52.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 1690.479980, 2722.384765, 9.671875, 0.000000, 0.000000, 6.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 1699.585571, 2482.698242, 6.218131, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 1699.553833, 2482.758300, 7.097651, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13590, 1742.007934, 2485.808105, 6.918496, 0.000000, 0.000000, 104.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 1731.290893, 2471.419921, 7.097651, 0.000000, 0.000000, -128.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1754.189208, 2488.946777, 6.957800, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1754.849853, 2488.946777, 6.717801, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1755.530517, 2489.036865, 6.437795, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1756.359619, 2489.205078, 6.452846, 0.000000, 26.800008, 14.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1757.282958, 2489.352783, 6.388140, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1756.622314, 2489.963378, 6.388140, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1349, 1745.846069, 2495.427978, 6.398120, 0.000000, 0.000000, -95.399986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1462, 1744.771850, 2488.508544, 5.828703, 0.000000, 0.000000, -168.199935, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 1877.849121, 2525.597900, 6.192911, 0.000000, 0.000000, -75.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 1896.097534, 2524.859863, 6.192911, 0.000000, 0.000000, -75.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3460, 1949.633789, 2746.106201, 9.883278, -3.399996, 88.500068, -178.199920, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1478, 1933.290771, 2733.893798, 9.925797, 0.000000, 87.499984, 151.300018, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(769, 2110.389160, 2799.909179, 9.620306, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(777, 2112.321533, 2834.306640, 9.260305, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1327, 2141.080322, 2838.431396, 9.820311, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(924, 2144.355468, 2836.865478, 10.010315, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(960, 2145.261474, 2832.000244, 10.160319, 0.000000, 0.000000, -25.199998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1439, 2134.944580, 2838.056396, 9.844840, 0.000000, 0.000000, -25.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2677, 2141.079345, 2834.102539, 10.110306, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, 2143.322998, 2837.959472, 9.850313, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(913, 2132.435546, 2847.565673, 10.643946, 0.000000, 0.000000, 18.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2145.191650, 2747.658447, 10.740318, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2131.435302, 2753.352783, 9.920310, 0.000000, 0.000000, 55.399997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 2157.327636, 2749.028564, 9.920310, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 2157.327636, 2758.170898, 9.920310, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 2144.260009, 2758.041992, 14.420078, 0.000000, 25.500007, -88.900077, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 2139.847167, 2751.417724, 14.168968, 0.000000, 17.500003, 360.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2131.825683, 2744.675292, 10.160320, 0.000000, 0.000000, 58.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2150.204589, 2791.192871, 10.740318, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2147.563476, 2802.553466, 10.740318, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3465, 2141.578857, 2754.847900, 10.128722, 0.000000, -94.900062, -86.600013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 2097.039306, 2575.311523, 6.192911, 0.000000, 0.000000, -75.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1300, 2096.980957, 2484.598388, 10.225304, 90.100021, 0.000000, 179.905456, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1300, 2046.270019, 2485.979980, 10.175300, 0.000000, 0.000000, 142.705413, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3866, 2131.385498, 2526.359375, 17.501785, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3887, 2091.352050, 2514.314453, 17.658887, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(820, 2106.968017, 2519.881835, 8.747659, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 2114.635009, 2525.101318, 10.897971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(875, 2121.546630, 2530.199218, 10.779800, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(875, 2130.935058, 2530.199218, 10.779800, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2095.626708, 2500.724121, 9.735039, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2113.586425, 2500.724121, 9.735039, 0.000000, 0.000000, -111.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(935, 2124.400390, 2508.776367, 10.351387, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2071.633300, 2516.483398, 10.565044, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1447, 2053.877197, 2498.666503, 9.909912, 90.000000, -38.400009, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1447, 2056.976318, 2510.870117, 9.909912, 90.000000, 44.499980, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16405, 2069.516845, 2496.568847, 11.502397, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3005, 2070.316894, 2495.571533, 9.873600, 0.000000, 0.000000, -53.300003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3302, 2067.529052, 2494.243408, 13.002761, 22.599998, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(850, 2072.849121, 2487.621093, 9.951842, 0.000000, 0.000000, 26.800001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 2067.875732, 2493.763427, 10.989410, 80.800132, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 2070.466064, 2493.763427, 10.989410, 80.800132, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 2074.652587, 2497.871337, 10.069974, 0.000000, 0.000000, 20.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(853, 2093.782714, 2516.395019, 10.183971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2671, 2074.071777, 2490.738769, 9.839360, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, 2067.516845, 2494.778564, 10.347846, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2140.991455, 2480.589355, 9.735039, 0.000000, 0.000000, 0.900005, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2138.583496, 2502.653076, 9.735039, 0.000000, 0.000000, 105.700012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2119.994628, 2488.069335, 10.605046, 0.000000, 0.000000, 105.700012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(12957, 2121.879882, 2488.310791, 10.320302, 0.000000, 0.000000, -13.399998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2129.234375, 2485.511230, 10.605046, 0.000000, 0.000000, 68.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3046, 2148.513671, 2473.068847, 10.170314, 0.000000, 0.000000, 46.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3866, 2257.704833, 2390.593017, 17.050310, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(812, 2264.290283, 2396.124511, 11.120325, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 2254.533203, 2398.727783, 10.010315, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 2250.292968, 2389.246093, 10.010315, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 2259.762939, 2389.246093, 10.010315, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(865, 2240.889892, 2398.576660, 10.010315, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(825, 2257.457763, 2390.624755, 10.400300, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2248.564208, 2394.609619, 11.020323, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1431, 2274.834228, 2421.084716, 10.331883, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1292, 2278.637695, 2419.614501, 10.101877, 90.000000, 27.199996, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2042, 2286.436279, 2429.347167, 9.930315, 0.000000, 0.000000, -32.400001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2042, 2284.823242, 2429.239990, 9.920313, 0.000000, 0.000000, 142.699981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3796, 2294.387939, 2430.414062, 9.820311, 0.000000, 0.000000, 80.900001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2299.764648, 2431.851562, 11.062778, 0.000000, -71.999969, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2973, 2301.979248, 2434.475341, 9.820311, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2973, 2301.979248, 2437.091796, 9.820311, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2906, 2303.115234, 2435.782714, 10.510327, 0.000000, 0.000000, 92.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2907, 2302.470947, 2432.746582, 9.910310, 180.000000, 0.000000, 56.400009, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1411, 2301.274658, 2440.967773, 11.320305, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1411, 2301.274658, 2443.579101, 11.320305, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1411, 2301.945312, 2448.609375, 11.320305, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1413, 2302.286376, 2454.284912, 10.967441, -18.000003, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1413, 2304.127929, 2459.602539, 9.900314, 90.000000, 29.000005, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(939, 2309.633056, 2460.605957, 12.180314, 0.000000, 0.000000, -5.900000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2907, 2306.879394, 2453.817626, 9.850313, 180.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(939, 2314.854248, 2460.066406, 12.180314, 0.000000, 0.000000, -5.900000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1412, 2320.720703, 2462.067138, 11.710313, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1412, 2320.720703, 2462.067138, 14.160320, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2973, 2285.005615, 2431.224853, 9.820311, 0.000000, 0.000000, -70.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2973, 2281.561035, 2431.335205, 9.820311, 0.000000, 0.000000, -88.500022, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2221.452392, 2366.474609, 10.079678, 0.000000, 0.000000, -23.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2196.216796, 2339.812255, 10.011867, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3567, 2156.291992, 1992.562377, 10.620331, 0.699998, 0.000000, -41.299991, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2202.954345, 2021.486816, 10.001873, 0.000000, 0.000000, -29.799999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1327, 2131.153564, 1903.789672, 9.601873, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(933, 2120.353759, 1813.084106, 9.611872, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1448, 2106.226318, 1768.604858, 9.671875, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2754, 2067.713134, 1721.339355, 10.071884, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2067.816650, 1661.271118, 10.139658, 0.000000, 0.000000, -15.099999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2070.584960, 1635.782104, 10.139658, 0.000000, 0.000000, 6.199999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2063.256347, 1591.771850, 10.139658, 0.000000, 0.000000, 169.199981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2047.340209, 1590.042358, 10.139658, 0.000000, 0.000000, -105.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19772, 2072.027587, 1532.426147, 10.241879, 0.000000, 0.000000, 22.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2047.056884, 1477.364501, 10.139658, 0.000000, 0.000000, 174.899932, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1340, 2074.603515, 1391.656616, 10.371864, 0.000000, 270.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(967, 2073.335693, 1287.741577, 10.451883, 90.000000, -44.700012, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1349, 2044.089477, 1297.350463, 10.191884, 0.000000, 0.000000, -30.799999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3463, 2053.059326, 1354.488281, 9.834244, 88.300010, 59.800006, -179.999984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1334, 2079.147460, 1151.652709, 10.909671, 0.000000, 0.000000, -5.900000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 2048.508789, 1123.912719, 9.991881, 0.000000, 0.000000, -17.300001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 2069.273925, 1165.755981, 9.991881, 0.000000, 0.000000, -2.299993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3465, 2114.909912, 914.718994, 10.217793, 0.000000, 90.000000, 118.799919, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 2073.950195, 853.585693, 6.125771, 0.000000, 0.000000, 95.499992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2085.477050, 847.764770, 6.096264, 0.000000, 0.000000, -89.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2081.108642, 851.787902, 6.096264, 0.000000, 0.000000, -89.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2088.277587, 851.850769, 6.096264, 0.000000, 0.000000, -89.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2093.169189, 848.672790, 6.096264, 0.000000, 0.000000, -89.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2092.889404, 855.236755, 6.096264, 0.000000, 0.000000, -71.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2066.991455, 844.061950, 6.096264, 0.000000, 0.000000, 148.600036, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 2063.303955, 848.744079, 6.125771, 0.000000, 0.000000, -121.400009, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 2046.736328, 862.778503, 6.125771, 0.000000, 0.000000, -156.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2046.577636, 856.872253, 6.096264, 0.000000, 0.000000, 52.599987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2051.238769, 857.386413, 6.096264, 0.000000, 0.000000, 52.599987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2056.794921, 858.846496, 6.096264, 0.000000, 0.000000, 4.599987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 2057.760253, 841.526367, 6.125771, 0.000000, 0.000000, -34.800025, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2032.784057, 837.792602, 6.096264, 0.000000, 0.000000, 88.900009, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2043.399902, 838.489440, 6.096264, 0.000000, 0.000000, 109.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2030.242797, 833.112487, 6.096264, 0.000000, 0.000000, 94.400070, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2047.192504, 834.416931, 6.096264, 0.000000, 0.000000, 94.400070, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2046.228027, 846.949768, 6.096264, 0.000000, 0.000000, 94.400070, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2054.296386, 851.512023, 6.483668, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2062.539794, 851.512023, 6.483668, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2072.736328, 851.512023, 6.483668, 0.000000, 0.000000, 13.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2069.460449, 837.438842, 6.483668, 0.000000, 0.000000, 63.800079, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2041.584594, 837.055969, 6.483668, 0.000000, 0.000000, 63.800079, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2029.480590, 852.008483, 6.096264, 0.000000, 0.000000, -92.499916, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2048.488281, 872.379211, 6.256268, 0.000000, 0.000000, -92.499916, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2045.048217, 888.025878, 6.786273, 1.500000, 0.000000, 0.300083, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2050.434326, 889.143859, 6.814806, 1.500000, 0.000000, 0.300083, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2048.315429, 877.790771, 6.483668, 0.000000, 0.000000, 63.800079, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1952.445678, 848.343078, 6.096264, 0.000000, 0.000000, -67.299926, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1912.073364, 832.962219, 6.996278, 0.000000, 0.000000, 78.200096, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1789.195678, 1053.119750, 5.734365, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1805.056030, 1075.669677, 5.734365, 0.000000, 0.000000, 90.699981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1790.022949, 1090.957153, 6.094377, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1789.850463, 1123.095703, 12.084383, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1800.352172, 1123.095703, 12.084383, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1811.959106, 1123.095703, 11.984445, 2.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1793.084106, 1263.158325, 12.114393, 0.000000, 0.000000, 88.500015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1787.281860, 1252.385498, 5.961997, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1799.720825, 1287.294067, 6.493127, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1808.860595, 1287.294067, 6.493127, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1808.860595, 1297.614257, 6.493127, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1790.339965, 1319.266967, 6.162001, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1788.079467, 1336.166870, 6.162001, 0.000000, 0.000000, 5.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1792.200317, 1320.643432, 6.493127, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1805.275634, 1406.739501, 6.071994, 0.000000, 0.000000, 161.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1795.224121, 1432.344116, 7.084230, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1789.145019, 1447.944458, 7.084230, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1789.145019, 1464.272094, 7.084230, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1802.227783, 1463.766845, 7.084230, 0.000000, 0.000000, -41.000003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1802.060180, 1453.845581, 7.084230, 0.000000, 0.000000, -14.899999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1792.063720, 1461.855102, 6.071994, 0.000000, 0.000000, 161.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1778.763427, 1588.229736, 5.794225, 0.000000, 0.000000, -92.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1814.705932, 1586.598144, 5.794225, 0.000000, 0.000000, -92.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1801.351806, 1860.328735, 6.124517, 0.000000, 0.000000, -35.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1806.646362, 1865.507446, 6.134518, 0.000000, 0.000000, -54.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(12957, 1812.262451, 1869.165283, 6.261316, 0.000000, 0.000000, -72.099990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2985, 1808.789916, 1864.308349, 5.720992, 0.000000, 0.000000, 108.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1805.582397, 1870.755981, 5.745969, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1791.259765, 1833.240844, 6.124517, 0.000000, 0.000000, 53.799995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1787.291381, 1690.939575, 6.394228, 0.000000, 0.000000, -92.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1805.853027, 1703.216308, 11.979219, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 1783.225830, 2162.426269, 3.275754, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1778.747070, 2161.416992, 4.027893, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1781.517822, 2161.416992, 4.027893, 0.000000, 0.000000, -7.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1781.517822, 2161.416992, 4.777898, 0.000000, 0.000000, -7.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1778.653808, 2161.517089, 4.777898, 0.000000, 0.000000, -3.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1793.028808, 2164.219726, 3.517893, 0.000000, 0.000000, -64.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1793.028808, 2164.219726, 4.447894, 0.000000, 0.000000, -64.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1793.116699, 2164.241699, 5.457904, 0.000000, 0.000000, -76.499954, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2162.085205, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2156.855224, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2151.623291, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2146.401611, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1799.522094, 2142.696777, 2.959167, 90.000000, 16.599998, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2122.919677, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2117.687744, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2112.446044, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2107.165283, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19869, 1797.495483, 2101.954833, 3.799166, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1414, 1797.652465, 2105.169189, 5.002444, 0.000000, 5.199998, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1414, 1797.641967, 2110.143554, 5.057465, 0.000000, -7.999997, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1414, 1797.641967, 2120.428222, 5.111288, 0.000000, -0.299999, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1414, 1797.641967, 2161.790039, 5.057847, 0.000000, -0.299999, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1414, 1797.641967, 2154.931884, 5.021928, 0.000000, -0.299999, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1414, 1797.641967, 2145.310546, 4.971565, 0.000000, -0.299999, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 1783.225830, 2086.253906, 3.275754, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1779.217895, 2087.607666, 4.027893, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1781.797363, 2087.607666, 4.087894, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1780.766479, 2087.631591, 5.047904, 0.000000, 0.000000, -91.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1780.765258, 2087.571533, 5.937910, 0.000000, 0.000000, -91.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1792.911987, 2087.317382, 3.567905, 0.000000, 0.000000, -91.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1792.911987, 2087.317382, 4.447908, 0.000000, 0.000000, -91.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1792.911987, 2087.317382, 5.407908, 0.000000, 0.000000, -91.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, 1782.074951, 2100.873779, 2.895992, 0.000000, 0.000000, 60.899986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, 1782.039672, 2098.341308, 2.915992, 0.000000, 0.000000, 89.199989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2047, 1792.528564, 2086.063720, 4.995142, 0.000000, 0.000000, -4.899998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19950, 1775.844116, 2016.356445, 3.403822, 0.000000, 17.400003, 31.400011, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1362, 1781.049194, 2092.126708, 3.504524, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18688, 1780.954833, 2092.103759, 2.749853, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, 1782.179199, 2108.351318, 2.965992, 0.000000, 0.000000, 89.199989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, 1782.331054, 2111.365966, 2.965992, 0.000000, 0.000000, 89.199989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1362, 1779.348876, 2105.064697, 3.517696, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19632, 1779.366943, 2105.078613, 3.587426, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2846, 1781.776977, 2101.055175, 2.921781, 0.000000, 0.000000, -42.600002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(14863, 1790.785522, 2160.790771, 3.516558, 0.000000, 0.000000, 24.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2673, 1789.635620, 2118.315185, 3.001511, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 1791.596801, 2101.380615, 3.210068, 0.000000, 0.000000, 52.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1431, 1780.460693, 2119.467773, 3.411357, 0.000000, 0.000000, -26.600002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1431, 1779.343383, 2121.417968, 3.511357, 0.000000, 0.000000, -89.699966, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(939, 1779.336547, 2126.035400, 5.305160, 0.000000, 0.000000, 89.699958, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(939, 1779.395019, 2137.077392, 5.305160, 0.000000, 0.000000, 89.699958, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1421, 1779.399780, 2131.824218, 3.769259, 0.000000, 0.000000, 103.899986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1299, 1793.461791, 2114.527832, 3.318333, 0.000000, 0.000000, -49.699993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19587, 1781.405761, 2149.793945, 2.961245, 0.599999, 1.599999, 18.499998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2843, 1784.286010, 2109.889404, 2.924486, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1793, 1783.416137, 2113.368896, 2.778362, 0.000000, 0.000000, 21.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(14880, 1781.180541, 2143.539794, 3.264385, 0.000000, 0.000000, -48.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1362, 1779.348876, 2149.616210, 3.497696, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19632, 1779.346923, 2149.670654, 3.587426, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1787.757446, 2074.260253, 3.586103, 0.000000, 0.000000, 135.599990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1784.390502, 2065.468017, 3.586103, 0.000000, 0.000000, -12.999983, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1791.262207, 2043.192260, 9.096407, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1785.571899, 2043.192260, 9.096407, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 1811.440429, 2043.192260, 9.096407, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3569, 1806.726440, 2295.777343, 7.057693, 0.000000, 0.000000, 22.499992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3632, 1778.809692, 2119.889160, 3.454018, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 1725.550048, 1897.563598, 10.276984, 0.000000, 0.000000, -159.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1369, 1616.372558, 1821.557861, 10.421459, 0.000000, 0.000000, -50.899986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1369, 1608.370483, 1831.396240, 10.334283, -102.199935, 0.000000, 39.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1327, 1609.326782, 1845.938476, 9.723880, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18451, 1595.962890, 1843.504150, 10.312527, 0.000000, 0.000000, -72.399986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(635, 1601.428100, 1826.507446, 14.287650, 0.000000, -90.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(635, 1597.657348, 1826.507446, 14.287650, 0.000000, -90.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(636, 1609.715820, 1826.528564, 13.326986, 0.000000, -90.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 1620.494262, 1844.507202, 9.273270, 0.000000, 0.000000, 46.699993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1800, 1623.993774, 1821.979980, 9.696353, 0.000000, 0.000000, 30.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 1630.890502, 1826.542968, 10.057779, 0.000000, 0.000000, -42.700008, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1800, 1629.986450, 1838.264160, 9.696353, 0.000000, 0.000000, -55.800010, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 1674.448608, 1713.046020, 10.054951, 0.000000, 0.000000, 52.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3460, 1457.459716, 1868.823242, 9.813447, -4.500000, 90.000000, 141.299896, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 1213.949462, 1947.730834, 6.238324, 0.000000, 0.000000, 120.199935, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1208.220703, 2050.666992, 6.953049, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1210.251098, 2037.387084, 6.953049, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1225.202026, 2037.234008, 6.953049, 0.000000, 0.000000, -6.800001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1227.417724, 2055.830566, 6.953049, 0.000000, 0.000000, -6.800001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 1206.625366, 2045.579467, 5.951725, 0.000000, 0.000000, 159.199981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1226.972290, 1764.636718, 6.072705, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1226.828979, 1747.305053, 6.246570, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1198.782470, 1707.515380, 6.232709, 0.000000, 0.000000, -14.799997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1212.615600, 1601.735961, 6.232709, 0.000000, 0.000000, 3.500006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1206.904663, 1526.487304, 6.232709, 0.000000, 0.000000, 1.000006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1309, 1188.757080, 1746.622558, 18.428337, -9.299999, -13.999997, -57.424510, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1309, 1204.170898, 1463.845214, 8.101653, 0.299999, 73.300041, -12.937155, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1208.966430, 1469.466674, 6.252712, 0.000000, 0.000000, 84.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1205.413818, 1474.462158, 6.252712, 0.000000, 0.000000, 35.399986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1211.937622, 1483.948120, 6.252712, 0.000000, 0.000000, 0.399992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1241.787231, 1484.156738, 7.342722, 2.499999, 10.400002, -166.699905, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(933, 1229.892578, 1381.924560, 5.739444, 0.000000, 0.000000, -31.900001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3568, 1206.617675, 1102.201171, 8.370448, 0.000000, 0.000000, -162.799942, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1246.920288, 915.127746, 7.164833, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1238.548706, 935.792785, 6.884831, 0.000000, 0.000000, 39.000026, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1253.158935, 947.623901, 6.884831, 0.000000, 0.000000, 39.000026, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1270.298828, 929.271057, 6.884831, 0.000000, 0.000000, 34.600036, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 1268.059204, 902.282958, 6.884831, 0.000000, 0.000000, 16.200033, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 1801.959838, 844.295410, 9.956722, 0.000000, 0.000000, 58.200008, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1697.543823, 849.510498, 7.570388, 0.000000, 0.000000, -62.100002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1648.559204, 831.475463, 6.180381, 0.000000, 0.000000, 79.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1619.337402, 842.535522, 6.340384, 0.000000, 0.000000, 79.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1553.097412, 831.852294, 6.420386, 0.000000, 0.000000, 97.300025, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(12957, 2076.346923, 753.002441, 10.317751, 0.000000, 0.000000, -122.200019, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(627, 1921.464355, 704.151000, 10.529684, 90.000000, 0.000000, 44.999931, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3005, 1921.323486, 725.958801, 9.832446, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 1911.063232, 693.049255, 10.051301, 0.000000, 0.000000, 34.400005, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2677, 1890.275512, 705.670837, 10.137083, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2590, 1907.979248, 707.987121, 15.162596, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1528, 1885.902343, 723.179382, 12.844694, 10.199997, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1344, 1884.839965, 720.753234, 10.294992, 90.199996, 136.199951, 180.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1920.112548, 689.136596, 10.339736, 0.000000, 0.000000, -41.799991, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(913, 1953.843505, 670.194152, 10.616386, 0.000000, 0.000000, -110.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3119, 1944.946411, 677.790344, 10.044281, 0.000000, 0.000000, -22.100000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1441, 1928.009765, 673.474792, 10.456267, 0.000000, 0.000000, -150.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(850, 1914.079345, 677.762329, 9.922384, 0.000000, 0.000000, -17.800001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 2385.925048, 1026.573608, 10.123695, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19377, 2387.013916, 1044.431396, 9.870284, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2427.904785, 1013.573059, 10.271347, 0.000000, 0.000000, -23.399999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 2632.187500, 1102.937988, 14.180504, 0.000000, 20.700008, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, 2632.187500, 1108.657104, 14.180504, 0.000000, 20.700008, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 2634.916503, 1073.868774, 10.310323, 0.000000, 0.000000, -25.600002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2676.704833, 1004.330261, 6.234381, 0.000000, 0.000000, -22.799997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2697.159423, 1037.571777, 6.234381, 0.000000, 0.000000, -17.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2722.875244, 1202.411743, 6.294377, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2709.384521, 1275.862304, 6.294377, 0.000000, 0.000000, 18.600004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2725.520019, 1380.375610, 6.082001, 0.000000, 0.000000, 144.000045, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2688.226318, 1433.462524, 7.901109, 0.000000, 6.299997, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1259, 2700.484375, 1507.543090, 9.581922, 35.099990, 18.999998, 110.700012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2725.511718, 1585.006347, 6.231999, 0.000000, 0.000000, 171.299987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1290, 2724.183105, 1687.411621, 6.019919, -90.300071, 93.800003, 44.900028, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2473.729248, 2136.603027, 10.041877, 0.000000, 0.000000, 13.799999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2416.401123, 2152.335449, 10.171874, 0.000000, 0.000000, -66.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1835, 2479.292236, 2157.136718, 10.170320, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 2352.951904, 2097.756591, 9.908235, 0.000000, 0.000000, 31.799999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 2284.538330, 2150.410644, 9.931880, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2359, 2563.031494, 2104.429931, 10.040314, 0.000000, 0.000000, -23.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2359, 2560.001220, 2102.104736, 10.040314, 0.000000, 0.000000, -39.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1431, 2554.531005, 2102.044433, 10.340324, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2926, 2549.016845, 2104.043945, 9.810312, 0.000000, 0.000000, -29.399999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3796, 2611.650390, 2093.922851, 9.787751, 0.000000, 0.000000, -41.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2705.347900, 2134.775390, 6.320139, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2697.858154, 2420.179199, 6.126001, 0.000000, 0.000000, -145.299987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2645.055664, 2478.065429, 6.306003, 0.000000, 0.000000, -145.299987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3568, 2603.049316, 2546.616943, 7.169816, 0.000000, 0.000000, 45.399971, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(873, 2560.383544, 2561.461914, 4.053074, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2543.302978, 2589.811767, 4.439377, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, 2459.591796, 2605.562988, 5.208765, 0.000000, 0.000000, 31.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2407.217773, 2412.938476, 10.141885, 0.000000, 0.000000, 48.699993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2429.565429, 2396.833984, 10.141885, 0.000000, 0.000000, -171.100082, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 2346.295654, 2430.706787, 8.739093, -3.799999, -13.199990, -55.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1441, 2252.056396, 2449.080566, 10.380317, 0.000000, 0.000000, 17.499996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1421, 2247.493896, 2458.035156, 10.500319, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3796, 2259.341796, 2464.631347, 9.780311, 0.000000, 0.000000, 35.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3866, 2202.222656, 2476.171386, 17.501785, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 2178.697509, 2498.432617, 10.150316, 0.000000, 0.000000, -56.700016, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18451, 2177.046630, 2477.091308, 10.270315, 0.000000, 0.000000, 30.499998, object_world, object_int, -1, 300.00, 300.00);
            //LV MAPP UP
            int STREAMER_OBJECT_SD = 100;
            //LVPD MAP
            CreateDynamicObject(1438, 291.318481, 168.648346, 1006.088379, 0.000000, 0.000000, -148.900146, 1020, 3, -1, object_world, 200.0); // 0
            CreateDynamicObject(1544, 282.922302, 172.298172, 1007.091797, 0.000000, 0.000000, 0.000000, 1020, 3, -1, object_world, 50.0); // 0
            CreateDynamicObject(2036, 283.084015, 173.133072, 1007.141846, 0.000000, 0.000000, -25.900002, 1020, 3, 1020, object_world, 80.0); // 0
            CreateDynamicObject(933, 282.713470, 172.784561, 1006.128479, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, object_world, 200.0); // 0
            CreateDynamicObject(2672, 293.256256, 176.079315, 1006.459045, 0.000000, 0.000000, -36.799999, 1020, 3, 1020, object_world, 200.0); // 0
            CreateDynamicObject(2673, 286.199036, 177.724121, 1006.271545, 0.000000, 0.000000, 34.299999, 1020, 3, 1020, object_world, 100.0); // 0
            CreateDynamicObject(2059, 298.785004, 174.081299, 1006.231628, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, object_world, 80.0); // 0
            CreateDynamicObject(2673, 281.509766, 180.730957, 1006.282104, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, object_world, 100.0); // 0
            CreateDynamicObject(917, 275.505371, 176.347656, 1006.321045, 0.000000, 0.000000, 35.799995, 1020, 3, 1020, object_world, 60.0); // 0
            CreateDynamicObject(2673, 275.298615, 176.893341, 1006.291443, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, object_world, 100.0); // 0
            CreateDynamicObject(2908, 269.571503, 173.029816, 1008.397156, -90.999939, 0.000000, -135.799850, 1020, 3, 1020, object_world, 50.0); // 0
            CreateDynamicObject(2906, 269.402405, 173.851501, 1006.711365, 0.000000, 0.000000, 79.200012, 1020, 3, 1020, object_world, 60.0); // 0
            CreateDynamicObject(2906, 269.498016, 174.352432, 1006.711365, 0.000000, 0.000000, -13.999983, 1020, 3, 1020, object_world, 60.0); // 0
            CreateDynamicObject(1407, 263.933258, 170.380630, 1007.078674, -90.399994, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1468, 263.138123, 168.740005, 1005.734070, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1468, 263.138123, 168.740005, 1004.074036, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1456, 262.973267, 168.746841, 1004.533386, 0.000000, 0.000000, 179.800018, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2845, 262.171051, 173.878555, 1002.032471, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(955, 261.541504, 169.244415, 1002.413147, 0.000000, 0.000000, -178.300095, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1800, 261.742798, 172.536469, 1001.903015, 0.000000, 0.000000, -72.399940, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1800, 261.413483, 168.203674, 1002.440918, 0.299998, -87.700020, -76.200035, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1369, 263.395966, 181.594681, 1002.603027, 0.000000, 0.000000, -37.399998, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(3276, 260.199371, 169.738754, 1001.547607, -1.799919, 89.199966, -0.200049, 1020, 3, 1020, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1407, 259.283447, 170.380630, 1007.078674, -90.399994, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2145, 259.628784, 168.960724, 1002.246338, 0.000000, 90.399986, -178.899994, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1468, 258.117828, 168.740005, 1004.963623, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1456, 257.873138, 168.764557, 1005.313660, 0.000000, 0.000000, 179.800018, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1456, 257.873138, 168.764557, 1003.653259, 0.000000, 0.000000, -179.899963, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(14863, 259.016113, 180.766861, 1002.629578, 0.000000, 0.000000, 73.499954, 1020, 3, 1020, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(2310, 256.529022, 169.049942, 1002.452942, 0.000000, 0.000000, -83.799957, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2310, 255.963287, 169.042145, 1002.452942, 0.000000, 0.000000, -99.799973, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(3276, 254.940399, 170.028107, 1006.695190, -62.899914, 0.000000, -0.100048, 1020, 3, 1020, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1407, 254.533600, 170.380630, 1007.078674, -90.399994, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3276, 254.909866, 169.754898, 1001.473511, -1.799919, 89.199966, -0.200049, 1020, 3, 1020, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1800, 254.479218, 173.092392, 1001.903015, 0.000000, 0.000000, -110.900024, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(639, 252.406998, 168.813858, 1005.194092, 0.000000, 0.000000, 270.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(2907, 252.451126, 169.153259, 1002.055359, 177.000168, 0.000000, -22.199999, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1804, 254.142731, 181.089783, 1001.816772, 5.499999, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1407, 249.813721, 170.380630, 1007.078674, -90.399994, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3276, 249.670425, 169.770889, 1001.400391, -1.799919, 89.199966, -0.200049, 1020, 3, 1020, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1812, 250.423904, 180.100510, 1002.023132, 0.000000, 0.000000, 27.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2708, 249.188629, 162.509613, 1001.983337, 0.000000, 0.000000, -81.099991, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19088, 247.846390, 169.962387, 1007.234436, 0.000000, 0.000000, -148.100021, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2567, 248.018417, 166.463486, 1003.953308, 0.000000, 0.000000, -89.500046, 1020, 3, 1020, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3092, 247.716766, 170.149338, 1004.158081, 0.100001, 2.400000, 0.800020, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(1416, 248.946442, 160.016983, 1002.613647, 0.000000, 0.000000, -33.299999, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(11729, 249.615295, 157.773453, 1002.063538, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1812, 248.704315, 179.224304, 1002.023132, 0.000000, 0.000000, 27.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(367, 247.587326, 170.216568, 1002.053345, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2844, 248.730225, 179.949875, 1002.022461, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(19370, 250.080566, 155.237579, 1003.373291, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2779, 249.431396, 156.853348, 1001.962585, 0.000000, 0.000000, -38.199940, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1705, 249.484589, 155.595901, 1002.023499, 0.000000, 0.000000, -86.699966, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1407, 245.173630, 170.379135, 1007.068665, -90.399994, 0.200000, -0.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1812, 246.010223, 179.045334, 1002.023132, 0.000000, 0.000000, 3.799998, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1412, 247.270157, 152.527435, 1003.310364, 19.800005, 0.000000, 47.600006, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3276, 243.444107, 164.355804, 1006.339355, -36.799969, 0.000000, -90.100014, 1020, 3, 1020, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(19996, 244.083023, 179.910736, 1001.978943, 0.000000, 0.000000, -48.199997, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(19366, 242.579193, 169.875488, 1007.063110, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(19366, 242.512360, 166.676270, 1007.084961, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(19366, 242.445786, 163.487289, 1007.106323, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2567, 247.467209, 148.190979, 1003.953308, 0.000000, 0.000000, -73.500031, 1020, 3, 1020, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(2063, 242.046005, 165.844818, 1007.456726, 89.900040, -10.699998, 176.000061, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2063, 241.918488, 162.850586, 1008.085693, 0.000000, 0.000000, 0.900000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19366, 242.378799, 160.288193, 1007.128784, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(19832, 242.282547, 159.943954, 1008.207825, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2977, 242.305313, 159.767319, 1007.058105, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19366, 241.139618, 169.905640, 1007.060669, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(19832, 242.282547, 159.714081, 1008.207825, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(19996, 242.551926, 180.505783, 1001.978943, 0.000000, 0.000000, 14.100012, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1426, 242.181458, 161.102158, 1002.132568, 0.000000, 0.000000, 85.099968, 1020, 3, 1020, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(19366, 241.072845, 166.706467, 1007.082703, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(19366, 240.996201, 163.517654, 1007.103882, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2088, 242.305176, 181.776047, 1002.022461, 0.000000, 0.000000, 3.800003, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3092, 240.870010, 163.904434, 1003.041687, -2.199999, 0.000000, 89.699997, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(3276, 240.529053, 164.361237, 1006.356873, 39.600025, 0.000000, -90.100014, 1020, 3, 1020, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(19590, 240.629028, 163.858505, 1003.527649, 20.099970, 0.000000, 87.899994, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(19366, 240.929276, 160.318512, 1007.126160, -0.400000, 89.900040, -1.200000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2567, 248.225342, 142.724533, 1003.953308, 0.000000, 0.000000, -89.500046, 1020, 3, 1020, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(2060, 240.538498, 159.001266, 1007.323792, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2985, 240.228027, 159.646805, 1007.201721, 0.000000, 0.000000, -98.700005, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19366, 241.991455, 153.234848, 1007.176514, -0.400000, 89.900040, -1.200000, 1020, 3, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2060, 240.148514, 159.001266, 1007.544006, 0.000000, 0.000000, -6.799998, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2060, 239.595505, 159.187485, 1007.333801, 0.000000, 0.000000, -27.499996, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2671, 238.670074, 177.362228, 1002.090088, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(19366, 239.946182, 156.232224, 1002.087341, -0.100000, 89.900040, 30.299997, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(16444, 236.917206, 179.994125, 1002.249329, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2604, 244.858231, 140.251465, 1002.833313, 0.000000, 0.000000, 179.800034, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1450, 235.230621, 171.817322, 1002.659912, 0.000000, 0.000000, 92.500008, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2866, 235.081329, 165.879639, 1002.063599, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(1440, 234.109482, 158.950958, 1002.509827, 0.000000, 0.000000, 53.700020, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2860, 233.160736, 159.940948, 1003.043457, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(11718, 231.576187, 164.573135, 1002.903503, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(11711, 238.626160, 138.356964, 1004.983643, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(1462, 227.659134, 168.611862, 1002.037598, 0.000000, 0.000000, 270.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(19303, 229.925674, 151.974365, 1002.072876, 90.000000, 22.600006, 90.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2860, 234.015442, 140.962524, 1002.053345, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(913, 227.639221, 157.582718, 1002.843262, 0.000000, 0.000000, -90.800011, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2860, 232.914886, 141.084229, 1002.040466, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2860, 233.119110, 140.256668, 1003.523376, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(3035, 232.963745, 140.435226, 1002.793396, 0.000000, 0.000000, -179.200012, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1430, 225.115387, 173.069366, 1002.302246, 0.000000, 84.299988, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(1357, 224.300888, 180.259155, 1002.340576, 0.000000, 0.000000, 29.200001, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(2670, 224.536789, 158.176147, 1002.130127, 0.000000, 0.000000, -30.800001, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2567, 226.380066, 147.040482, 1003.953308, 0.000000, 0.000000, -79.499954, 1020, 3, 1020, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(2676, 221.441086, 179.013687, 1002.170593, 0.000000, 0.000000, 15.400000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3005, 219.855072, 169.096420, 1002.032471, 0.000000, 0.000000, -16.900000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2674, 219.515869, 166.286469, 1002.043335, 0.000000, 0.000000, -47.299992, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1449, 216.812500, 176.805374, 1002.512939, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2191, 217.664505, 156.842773, 1002.513367, 270.000000, 36.900009, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1448, 212.653198, 168.785980, 1002.112549, 0.000000, 0.000000, 36.099991, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(1302, 208.411896, 166.018066, 1001.940369, 0.800000, 0.099992, -89.399940, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1776, 208.420120, 164.303925, 1003.193176, -1.900002, -36.299896, -89.500015, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2672, 207.731125, 161.686676, 1002.312866, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3119, 205.010757, 167.308624, 1002.332886, 0.000000, 0.000000, -58.899994, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3260, 204.581879, 163.204727, 1002.933350, 0.000000, 0.000000, 90.000015, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1462, 205.255112, 156.775146, 1002.022949, 0.000000, 0.000000, 90.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3260, 204.581879, 161.174683, 1002.933350, 0.000000, 0.000000, 90.000015, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3005, 203.684204, 158.598526, 1002.022766, 0.000000, 0.000000, 179.499710, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(910, 203.080231, 156.804276, 1003.243591, 0.000000, 0.000000, 178.199890, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2677, 201.582809, 167.788010, 1002.312744, 0.000000, 0.000000, -24.799999, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1442, 199.990234, 159.839615, 1002.583008, 0.000000, 0.000000, -7.799999, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(1647, 196.003113, 157.645508, 1002.182800, 0.000000, 0.000000, -11.999998, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1812, 194.465240, 158.960541, 1002.003174, 0.000000, 0.000000, -174.100037, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19944, 193.962494, 179.351227, 1002.032654, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2845, 193.925079, 157.423111, 1002.033081, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(1647, 192.968292, 157.574097, 1002.182800, 0.000000, 0.000000, 0.699998, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19944, 192.572586, 179.351227, 1002.032654, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1812, 191.529190, 158.972488, 1002.003174, 0.000000, 0.000000, 171.599915, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19944, 191.102554, 179.351227, 1002.032654, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2845, 191.585083, 156.483185, 1002.033081, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(2257, 191.400436, 156.263596, 1004.782043, 0.000000, 0.000000, -179.200043, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2845, 191.186340, 158.722427, 1002.033081, 0.000000, 0.000000, -137.200027, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(19924, 189.729446, 179.131210, 1006.429260, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19944, 189.752747, 179.351227, 1002.032654, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1647, 190.010269, 157.655212, 1002.182800, 0.000000, 0.000000, 6.899999, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19944, 188.482758, 179.351227, 1002.032654, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1647, 188.770386, 157.655212, 1002.182800, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2845, 188.869141, 158.819489, 1002.033081, 0.000000, 0.000000, 42.599998, 1020, 3, 1020, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(3011, 230.284821, 146.376633, 1002.317810, 19.500000, -115.299988, -1.200001, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(11715, 231.730515, 164.077377, 1002.933350, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 50.0); // 0
            CreateDynamicObject(11715, 231.603851, 164.049210, 1002.913330, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 50.0); // 0
            CreateDynamicObject(3008, 229.544983, 145.442352, 1001.883240, 0.000000, 0.000000, 0.000000, 1020, 3, 1020, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(3012, 229.470291, 145.165588, 1002.023071, 0.000000, 0.000000, -74.200020, 1020, 3, 1020, STREAMER_OBJECT_SD, 50.0); // 0

            //1550.657, 1297.947, 255.852 , 1549.374, 1293.149, 255.272
             var authWindow1 = new DynamicObject(12957, new Vector3(1548.196899, 1287.194335, 254.036849), new Vector3(0.000000, 0.000000, 150.899917), 1021, 0, player, 200, 200);
            authWindow1.SetMaterial(0, 10838, "airwelcomesign_sfse", "sl_rustyrailing", 0x00000000);
            authWindow1.SetMaterial(1, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            //tmpobjid = CreateDynamicObject(3267, 1547.650878, 1286.367431, 253.405746, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 13295, "ce_terminal", "des_adobewall2", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 2, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 3, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 4, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 5, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            var authWindow2 = new DynamicObject(3267, new Vector3(1547.650878, 1286.367431, 253.405746), new Vector3(0.000000, 0.000000, 0.000000), 1021, 0, player, 200, 200);
            authWindow2.SetMaterial(0, 13295, "ce_terminal", "des_adobewall2", 0x00000000);
            authWindow2.SetMaterial(1, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            authWindow2.SetMaterial(2, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            authWindow2.SetMaterial(3, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            authWindow2.SetMaterial(4, 13295, "ce_terminal", "Gen_Metal", 0x00000000);
            authWindow2.SetMaterial(5, 13295, "ce_terminal", "Gen_Metal", 0x00000000);

            //tmpobjid = CreateDynamicObject(2907, 1547.921386, 1288.070922, 254.006713, -72.499984, 0.000000, -24.699996, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFF323232);
            var authWindow3 = new DynamicObject(2907, new Vector3(1547.921386, 1288.070922, 254.006713), new Vector3(-72.499984, 0.000000, -24.699996), 1021, 0, player, 200, 200);
            authWindow3.SetMaterial(0, -1, "none", "none", 0xFF323232);

           // tmpobjid = CreateDynamicObject(2908, 1547.893920, 1287.964111, 254.462966, -79.900070, -3.700003, -120.800041, object_world, object_int, -1, 300.00, 300.00);
           // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFA323232);
            var authWindow4 = new DynamicObject(2908, new Vector3(1547.893920, 1287.964111, 254.462966), new Vector3(-79.900070, -3.700003, -120.800041), 1021, 0, player, 200, 200);
            authWindow4.SetMaterial(0, -1, "none", "none", 0xFF323232);

              var authWindow5 = new DynamicObject(3073, new Vector3(1548.456298, 1277.114746, 255.116943), new Vector3(0.000000, 0.000000, 152.300079), 1021, 0, player, 200, 200);
            authWindow5.SetMaterial(0, 12992, "ce_oldbridge", "Gen_Rusty_Poll", 0xFF999999);
            authWindow5.SetMaterial(1, 12992, "ce_oldbridge", "Gen_Rusty_Poll", 0xFFFFCCCC);

            CreateDynamicObject(11512, 1615.002929, 1259.036132, 278.349975, 0.000000, 0.000000, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1538.205932, 1280.134521, 254.043533, -0.899999, 0.000000, -59.899997, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1542.285644, 1287.491210, 253.930175, -0.899999, 0.000000, -63.999984, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1521.806762, 1276.772094, 254.546096, -2.799999, 0.000000, -48.899974, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1515.090576, 1264.026611, 255.573501, -4.999999, 0.000000, -41.299980, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1511.054931, 1267.568847, 255.573501, -4.999999, 0.000000, -41.299980, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 1501.208984, 1247.590209, 257.455078, -4.999999, 0.000000, -30.599981, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(11512, 1427.188720, 1189.987548, 275.430389, 0.000000, 0.000000, -132.900085, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(18688, 1548.854125, 1289.176025, 252.992401, 0.000000, 0.000000, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(1025, 1548.013305, 1289.588500, 253.641693, 0.000000, 0.000000, 141.000015, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3014, 1544.622558, 1290.282958, 253.632812, 0.000000, 0.000000, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(2035, 1548.120361, 1290.084594, 253.881561, 0.000000, -65.299972, -31.500009, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1545.374755, 1285.508056, 253.973968, 0.000000, 0.000000, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(935, 1545.234619, 1281.035522, 253.794036, 0.000000, 0.000000, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3568, 1561.609741, 1289.992065, 255.806503, 0.000000, 0.000000, -63.700096, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(1431, 1552.356323, 1285.752807, 253.942260, 0.000000, 0.000000, 65.400001, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(3005, 1548.776733, 1284.852294, 253.458969, 0.000000, 0.000000, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(2359, 1551.189331, 1287.897338, 253.636993, 0.000000, 2.100001, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(926, 1550.477050, 1279.213745, 254.048263, 0.000000, 0.000000, 0.000000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(2036, 1552.039672, 1286.323364, 254.016784, 0.000000, -66.799942, -25.100000, 1021, 0, -1, 300.00, 300.00);
            CreateDynamicObject(19110, 1552.385253, 1285.444335, 254.557617, -14.099996, -86.900024, 6.999998, 1021, 0, -1, 300.00, 300.00);

            //NEFTEZAVOD СНАРУЖИ

            CreateDynamicObject(3585, 606.797607, 1287.600586, 12.415212, 0.000000, 0.000000, 30.400017, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1688, 600.878906, 1284.166748, 14.998566, 0.000000, 0.000000, 29.800014, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(16088, 612.204285, 1292.773315, 10.977405, 0.000000, 0.000000, 29.499994, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3564, 599.212280, 1283.203247, 12.404109, 0.000000, 0.000000, 29.999996, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3633, 611.423950, 1278.435669, 11.162645, 0.000000, 0.000000, 32.099995, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 609.999878, 1277.539673, 11.162645, 0.000000, 0.000000, 32.099995, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1687, 597.658630, 1282.319336, 14.787458, 0.000000, 0.000000, 29.999996, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3577, 601.703064, 1276.571533, 11.468744, 0.000000, 0.000000, 30.899990, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3632, 606.675842, 1275.400879, 11.188741, 0.000000, 0.000000, -143.499969, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(3287, 612.878540, 1275.032593, 13.997729, 0.000000, 0.000000, -59.099983, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1449, 619.969116, 1282.908203, 11.158740, 0.000000, 0.000000, -56.999958, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1215, 594.486633, 1280.579834, 12.001053, -109.099838, 0.000000, -61.500027, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(16337, 621.189575, 1283.974243, 10.701877, 0.000000, 0.000000, -56.599991, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1522, 622.048462, 1285.139893, 10.678752, 0.000000, 0.000000, -57.199966, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 598.409058, 1273.858765, 11.162645, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3576, 592.319763, 1279.207275, 13.859945, 0.000000, 1.200000, 30.699999, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1635, 612.246521, 1272.984253, 19.147491, 0.000000, 0.000000, -60.099991, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3633, 598.346924, 1272.322876, 11.162645, 0.000000, 0.000000, -43.799995, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 596.892883, 1273.205811, 11.162645, 0.000000, 0.000000, 15.600007, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(5261, 603.142578, 1268.853760, 12.848752, 0.000000, 0.000000, -149.800171, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1428, 597.592041, 1304.747559, 9.091431, -74.000038, 0.399998, -25.700014, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3576, 593.567871, 1270.959106, 12.199935, 0.000000, 0.000000, 36.199993, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1428, 598.775635, 1307.158203, 9.185767, -72.900055, 0.399998, -25.700014, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1428, 598.181580, 1307.364990, 15.119058, 15.500000, 0.399998, 18.499987, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1428, 598.206299, 1307.350220, 17.779881, 15.500000, 0.399998, 18.499987, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1428, 598.271851, 1266.647583, 14.318758, 0.000000, 0.000000, -152.400131, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1428, 598.232727, 1307.332153, 20.459988, 15.500000, 0.399998, 18.499987, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3567, 586.716003, 1275.856812, 11.800275, 2.299998, 0.699994, 120.799934, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1426, 598.200806, 1265.778931, 12.788722, 0.000000, 0.000000, 119.600098, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1426, 598.142700, 1265.860718, 10.698737, 0.000000, 0.000000, -60.799980, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3630, 586.474487, 1275.764160, 14.129073, 0.000000, 1.600000, 30.299988, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1428, 598.258301, 1307.315918, 23.130444, 15.500000, 0.399998, 18.499987, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1428, 598.183899, 1264.875366, 11.718750, 0.000000, 0.000000, 32.100006, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(13367, 597.047485, 1311.168945, 21.027449, 0.000000, 0.000000, -71.599976, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(19166, 581.864563, 1273.651245, 14.393625, -9.299998, -90.000107, 30.099991, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(11727, 580.548889, 1274.066284, 14.563511, -0.499998, 0.000000, 30.100000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2969, 580.929382, 1271.373169, 13.965435, -0.300000, 1.099998, 53.500004, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(639, 588.557312, 1263.494995, 18.268341, 0.000000, 0.000000, 29.200006, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(922, 580.539673, 1271.211792, 13.829196, 0.000000, 1.699998, 31.300009, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3577, 584.814880, 1264.950928, 11.388743, 0.000000, 0.000000, 93.899986, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2843, 579.143738, 1271.593384, 13.498010, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1215, 579.104187, 1271.372314, 12.338103, 1.799998, -88.599976, 31.300009, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(19321, 579.036804, 1271.415894, 14.193541, 0.000000, -0.599999, -59.800007, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3633, 584.170349, 1264.653320, 12.542652, 0.000000, 0.000000, 3.900012, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(11727, 578.281677, 1272.752441, 14.563511, -0.499998, 0.000000, 30.100000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(1812, 578.934753, 1271.390015, 13.040163, 0.000000, 0.000000, -50.300007, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(639, 579.720276, 1269.826294, 13.618303, -0.200000, 4.999999, 120.099930, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(19942, 578.895203, 1270.472778, 14.012579, 0.000000, 0.000000, -90.300041, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0
            CreateDynamicObject(18661, 577.117859, 1272.100464, 14.498600, 0.000000, -0.699998, -59.700020, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(18703, 577.718262, 1269.330444, 12.355383, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3287, 630.746582, 1262.363770, 15.203977, 0.000000, 0.000000, -61.699986, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3062, 576.786316, 1268.317871, 14.124052, -0.699998, 0.000000, -167.699966, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3062, 574.868286, 1269.432007, 14.114525, -0.699998, 0.000000, 77.899948, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1421, 572.305176, 1270.630127, 11.634064, 0.000000, 0.000000, 28.799997, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3287, 633.026672, 1258.128174, 15.203977, 0.000000, 0.000000, -61.699986, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3633, 572.244141, 1266.526367, 13.170356, 0.000000, 0.000000, 26.700001, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(16088, 570.592651, 1269.230835, 11.387412, 0.000000, 0.000000, 29.499994, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3567, 571.437683, 1267.131104, 11.979617, 1.099998, -0.500005, -60.600075, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3796, 578.404114, 1257.347778, 10.676496, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(2063, 569.621155, 1268.482178, 11.883241, 11.299938, -2.599999, 30.300028, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(639, 591.763611, 1248.243286, 18.458345, 0.000000, 0.000000, 29.200006, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3633, 569.923035, 1265.316162, 13.170356, 0.000000, 0.000000, 5.299997, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(639, 597.700073, 1245.817261, 20.338375, 0.000000, 0.000000, 119.200005, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3631, 636.385742, 1253.348022, 12.855389, 0.000000, 0.000000, 28.100000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3633, 567.188293, 1265.574707, 13.170356, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(964, 568.002808, 1264.080688, 12.731808, 0.000000, -1.100000, 27.599993, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3567, 639.829285, 1255.239624, 11.442852, 0.000000, 0.000000, -61.500008, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3577, 565.485657, 1263.800781, 13.471677, 0.000000, -1.399999, 29.600008, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3631, 643.664246, 1257.234619, 12.855389, 0.000000, 0.000000, 28.100000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(16088, 647.046265, 1314.230957, 11.247402, 0.000000, 0.000000, 31.399996, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1466, 580.314758, 1246.766235, 11.838753, 0.000000, 0.000000, 34.199993, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1466, 580.314758, 1246.766235, 13.938755, 0.000000, 0.000000, 34.199993, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1215, 563.625916, 1262.764893, 12.523775, 0.000000, -90.799973, 31.500002, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(3066, 638.508911, 1248.661133, 11.611907, 0.000000, 0.000000, -63.300011, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1428, 578.459106, 1245.242432, 14.061066, -28.400030, 0.000000, -62.400131, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1466, 578.056274, 1245.232178, 11.838753, 0.000000, 0.000000, 34.199993, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1431, 574.752319, 1245.153687, 11.248751, 0.000000, 0.000000, 30.300014, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2991, 575.044006, 1243.622559, 11.268745, 0.000000, 0.000000, 33.600018, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3564, 559.778015, 1260.555786, 12.675393, 0.000000, 0.000000, 29.100008, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3066, 640.889709, 1244.288330, 11.611907, 0.000000, 0.000000, -63.300011, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16304, 548.366333, 1278.946899, 14.357666, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 425.0); // 0
            CreateDynamicObject(16304, 605.226379, 1227.276489, 15.467653, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 425.0); // 0
            CreateDynamicObject(2991, 562.655151, 1236.519165, 11.388746, 0.000000, 0.000000, 27.800018, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1431, 561.430542, 1237.368408, 11.248751, 0.000000, 0.000000, 30.300014, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1466, 559.878357, 1234.582764, 11.838753, 0.000000, 0.000000, 34.199993, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1428, 559.750183, 1234.353882, 13.996568, -30.100012, 0.199999, 124.299950, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1466, 557.678345, 1233.087769, 11.838753, 0.000000, 0.000000, 34.199993, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1466, 557.678345, 1233.087769, 13.948746, 0.000000, 0.000000, 34.199993, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(16088, 536.949890, 1249.811279, 11.637415, 0.000000, 0.000000, 31.600002, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16088, 499.683075, 1230.018066, 12.557419, 0.000000, -0.699998, 28.000004, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16088, 463.482086, 1216.998291, 14.332398, 0.000000, -0.699998, 12.300004, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16088, 420.674683, 1209.261719, 16.711248, 0.000000, 3.299998, 9.000004, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16088, 371.968536, 1207.143188, 18.833061, 0.000000, 0.899999, 0.100005, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16088, 327.881958, 1210.859497, 20.576408, 0.000000, 0.899999, -6.499989, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1347, 577.690674, 1269.316040, 13.452923, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(1215, 563.625916, 1262.764893, 12.523775, 0.000000, -90.799973, 31.500002, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2843, 579.143738, 1271.593384, 13.498010, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1215, 579.104187, 1271.372314, 12.338103, 1.799998, -88.599976, 31.300009, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(11727, 576.136414, 1271.509033, 14.563511, -0.499998, 0.000000, 30.100000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(1215, 594.486633, 1280.579834, 12.001053, -109.099838, 0.000000, -61.500027, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1215, 595.344421, 1281.045288, 11.801988, -95.299973, 0.000000, -61.500027, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(11727, 578.281677, 1272.752441, 14.563511, -0.499998, 0.000000, 30.100000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2969, 580.115540, 1270.980347, 13.978590, -0.300000, 1.099998, 15.500002, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(11727, 580.548889, 1274.066284, 14.563511, -0.499998, 0.000000, 30.100000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2969, 580.929382, 1271.373169, 13.965435, -0.300000, 1.099998, 53.500004, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(1215, 602.804565, 1285.314453, 11.804902, 87.800056, 0.000000, -59.999992, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(3632, 606.675842, 1275.400879, 11.188741, 0.000000, 0.000000, -143.499969, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1215, 608.368103, 1274.235229, 12.707035, 65.099968, -1.699998, 37.000023, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(3632, 607.728638, 1275.083252, 11.188741, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1215, 598.246704, 1307.406128, 24.442875, -4.299999, -86.899956, 19.099989, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(19942, 578.895203, 1270.472778, 14.012579, 0.000000, 0.000000, -90.300041, -1, -1, -1, STREAMER_OBJECT_SD, 50.0); // 0

            //NEFTEZAVOD INTERIOR

            CreateDynamicObject(2672, 502.683167, 1367.620239, 3005.171387, 0.000000, 0.000000, -16.399998, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(5820, 499.803101, 1365.522217, 3004.881104, 0.000000, 0.000000, -90.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(1412, 503.043243, 1363.818237, 3006.112305, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2674, 499.600800, 1366.011597, 3006.677246, -0.200000, 40.000011, 85.600014, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2674, 505.640564, 1366.845581, 3004.951172, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 502.961060, 1362.372314, 3005.391602, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2633, 503.497742, 1362.663086, 3006.742920, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3005, 504.114075, 1369.932007, 3004.932129, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 504.240997, 1362.372314, 3005.391602, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1412, 497.783325, 1363.818237, 3006.112305, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2670, 504.364014, 1371.522095, 3005.002686, 0.000000, 0.000000, 44.599998, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(873, 507.333984, 1368.680054, 3005.261719, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 350.0); // 0

            CreateDynamicObject(3761, 497.912079, 1372.790161, 3006.847412, 0.000000, -0.300015, -0.100000, 1022, 1, 1022, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(2671, 509.406006, 1371.000244, 3004.921875, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2670, 506.442444, 1374.303955, 3004.991943, 0.000000, 0.000000, 0.000000, 1022, 1, 1022, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3014, 497.705658, 1374.601685, 3005.882080, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2633, 507.768250, 1362.663086, 3006.742920, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3014, 497.705658, 1375.162231, 3005.882080, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2633, 512.048340, 1362.663086, 3006.742920, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3633, 512.301270, 1362.372314, 3005.391602, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1412, 512.673157, 1363.818237, 3006.112305, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(635, 502.046265, 1377.366211, 3006.272461, 0.000000, -90.000000, 90.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3109, 511.429352, 1361.475708, 3009.558838, 0.000000, 0.000000, 90.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(635, 505.456177, 1377.366211, 3006.272461, 0.000000, -90.000000, 90.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3675, 505.154602, 1377.659180, 3005.561768, 270.000000, 0.000000, 270.000000, 1022, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1428, 513.912415, 1364.501953, 3006.551270, 0.000000, 0.000000, -177.399963, 1022, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 513.620972, 1362.372314, 3005.391602, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 513.620972, 1362.372314, 3006.332520, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2670, 503.002502, 1378.453857, 3005.021973, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3014, 506.945587, 1377.493652, 3005.191895, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(1676, 512.263123, 1373.432251, 3005.892090, 0.000000, 0.000000, -85.999924, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 513.620972, 1362.672485, 3008.881348, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2949, 514.717590, 1367.718018, 3004.841064, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3675, 505.154602, 1378.730225, 3005.561768, 270.000000, 0.000000, 270.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3675, 497.384735, 1377.641602, 3011.227295, 0.000000, 0.000000, 90.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3643, 513.317322, 1374.595825, 3005.892090, 0.000000, 0.000000, 4.500000, 1022, 1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3675, 497.384735, 1378.730225, 3011.227295, 0.000000, 0.000000, 90.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(2633, 516.317871, 1362.663086, 3006.742920, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3633, 513.180298, 1375.978638, 3005.321533, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 513.180298, 1375.978638, 3006.252441, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3005, 509.842621, 1379.099609, 3004.902344, 0.000000, 0.000000, 0.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, 513.180298, 1377.519653, 3005.321533, 0.000000, 0.000000, 101.699966, 1022, 1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(639, 502.639618, 1380.375488, 3012.748535, 0.000000, 0.000000, 90.000000, 1022, 1, -1, STREAMER_OBJECT_SD, 300.0); // 0

            // fso_map = CreateDynamicObject(19379, 501.988953, 1366.104736, 3004.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 4835, "airoads_las", "concretenewb256", 0);
            var neftezavodint1 = new DynamicObject(19379, new Vector3(501.988953, 1366.104736, 3004.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint1.SetMaterial(0, 4835, "airoads_las", "concretenewb256", 0);
            //fso_map = CreateDynamicObject(19379, 501.748291, 1361.373535, 3009.951172, 0.000000, 180.000000, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint2 = new DynamicObject(19379, new Vector3(501.748291, 1361.373535, 3009.951172), new Vector3(0.000000, 180.000000, 90.000000), 1022, 1, player, 200, 200);
            neftezavodint2.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            //fso_map = CreateDynamicObject(19379, 496.848816, 1366.103027, 3009.951172, 0.000000, 180.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint3 = new DynamicObject(19379, new Vector3(496.848816, 1366.103027, 3009.951172), new Vector3(0.000000, 180.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint3.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            //fso_map = CreateDynamicObject(19379, 501.988953, 1375.732788, 3004.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 4835, "airoads_las", "concretenewb256", 0);
            var neftezavodint4 = new DynamicObject(19379, new Vector3(501.988953, 1375.732788, 3004.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint4.SetMaterial(0, 4835, "airoads_las", "concretenewb256", 0);

            // fso_map = CreateDynamicObject(19379, 501.988953, 1366.104736, 3014.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            var neftezavodint5 = new DynamicObject(19379, new Vector3(501.988953, 1366.104736, 3014.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint5.SetMaterial(0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            //fso_map = CreateDynamicObject(19379, 512.488464, 1366.104736, 3004.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 4835, "airoads_las", "concretenewb256", 0);
            var neftezavodint6 = new DynamicObject(19379, new Vector3(512.488464, 1366.104736, 3004.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint6.SetMaterial(0, 4835, "airoads_las", "concretenewb256", 0);
            //fso_map = CreateDynamicObject(19379, 511.377808, 1361.373535, 3009.951172, 0.000000, 180.000000, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint7 = new DynamicObject(19379, new Vector3(511.377808, 1361.373535, 3009.951172), new Vector3(0.000000, 180.000000, 90.000000), 1022, 1, player, 200, 200);
            neftezavodint7.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            // fso_map = CreateDynamicObject(19379, 496.848816, 1375.732788, 3009.951172, 0.000000, 180.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint8 = new DynamicObject(19379, new Vector3(496.848816, 1375.732788, 3009.951172), new Vector3(0.000000, 180.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint8.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);

            //fso_map = CreateDynamicObject(19379, 501.988953, 1375.732788, 3014.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            var neftezavodint9 = new DynamicObject(19379, new Vector3(501.988953, 1375.732788, 3014.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint9.SetMaterial(0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            // fso_map = CreateDynamicObject(19379, 514.858582, 1366.103027, 3009.951172, 0.000000, 180.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint10 = new DynamicObject(19379, new Vector3(514.858582, 1366.103027, 3009.951172), new Vector3(0.000000, 180.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint10.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            //fso_map = CreateDynamicObject(19379, 512.488464, 1375.732788, 3004.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 4835, "airoads_las", "concretenewb256", 0);
            var neftezavodint11 = new DynamicObject(19379, new Vector3(512.488464, 1375.732788, 3004.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint11.SetMaterial(0, 4835, "airoads_las", "concretenewb256", 0);
            //fso_map = CreateDynamicObject(19379, 512.488464, 1366.104736, 3014.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            var neftezavodint12 = new DynamicObject(19379, new Vector3(512.488464, 1366.104736, 3014.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint12.SetMaterial(0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            //fso_map = CreateDynamicObject(19379, 501.748291, 1380.464355, 3009.951172, 0.000000, 180.000000, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint13 = new DynamicObject(19379, new Vector3(501.748291, 1380.464355, 3009.951172), new Vector3(0.000000, 180.000000, 90.000000), 1022, 1, player, 200, 200);
            neftezavodint13.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            //fso_map = CreateDynamicObject(19379, 514.859558, 1375.732788, 3009.951172, 0.000000, 180.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint14 = new DynamicObject(19379, new Vector3(514.859558, 1375.732788, 3009.951172), new Vector3(0.000000, 180.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint14.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            //fso_map = CreateDynamicObject(19379, 512.488464, 1375.732788, 3014.806152, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            var neftezavodint15 = new DynamicObject(19379, new Vector3(512.488464, 1375.732788, 3014.806152), new Vector3(0.000000, 90.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint15.SetMaterial(0, 7555, "bballcpark1", "backstageceiling1_128", 0);
            //fso_map = CreateDynamicObject(19379, 511.377808, 1380.463745, 3009.951172, 0.000000, 180.000000, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint16 = new DynamicObject(19379, new Vector3(511.377808, 1380.463745, 3009.951172), new Vector3(0.000000, 180.000000, 90.000000), 1022, 1, player, 200, 200);
            neftezavodint16.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);

            //fso_map = CreateDynamicObject(19379, 517.648621, 1375.732788, 3009.951172, 0.000000, 180.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 16271, "des_factory", "corr_2_plaintiledblue", 0);
            var neftezavodint17 = new DynamicObject(19379, new Vector3(517.648621, 1375.732788, 3009.951172), new Vector3(0.000000, 180.000000, 0.000000), 1022, 1, player, 200, 200);
            neftezavodint17.SetMaterial(0, 16271, "des_factory", "corr_2_plaintiledblue", 0);

            //AEROMAPPING DOWN
            CreateDynamicObject(11088, 29.782531, 2443.886718, 22.124378, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(9361, 419.707885, 2553.255371, 17.845235, 0.000000, 0.000000, -46.500011, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11461, 428.870635, 2558.081054, 14.744462, 0.000000, 0.000000, -77.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11011, 344.067840, 2466.694335, 19.464380, 0.000000, 0.000000, 89.599929, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11293, 307.627716, 2541.668212, 21.519773, 0.000000, 0.000000, -1.299998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3287, 380.061706, 2595.855468, 16.513013, 0.000000, 87.999977, 1.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3866, 268.650573, 2543.008789, 23.224210, 0.000000, 0.000000, -90.600013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1684, 260.517669, 2540.709228, 17.354684, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11445, 372.114196, 2445.702636, 15.644372, 0.000000, 0.000000, -169.499923, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11441, 358.477661, 2452.809570, 15.484375, 0.000000, 0.000000, 143.999969, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(10401, 317.367919, 2465.279052, 17.744354, 0.000000, 0.000000, -45.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16287, 355.204406, 2540.417968, 15.555076, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16287, 343.829925, 2540.456298, 15.666425, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18236, 389.275695, 2540.536865, 15.544464, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18274, 376.742340, 2540.546386, 15.527557, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(617, 415.803619, 2557.050048, 14.970746, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(691, 450.342407, 2540.004150, 15.870951, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(692, 432.126007, 2531.378662, 15.484375, 0.000000, 0.000000, 139.599990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(692, 414.902099, 2557.075195, 15.382160, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(738, 385.966247, 2548.921875, 15.610266, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(738, 373.311218, 2548.949707, 15.611741, 0.000000, 0.000000, 179.799865, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(773, 361.275238, 2439.791992, 15.464378, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(773, 319.137512, 2426.679687, 15.621472, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1687, 389.256774, 2530.801513, 16.359754, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1687, 376.755615, 2530.812744, 16.407289, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3425, 373.183654, 2469.775390, 26.794410, 0.000000, 0.000000, 60.499977, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(764, 265.773284, 2538.414794, 15.484375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(772, 322.051818, 2579.722412, 15.534683, 0.000000, 0.000000, -44.799995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(769, 291.177490, 2450.504882, 15.384371, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3363, 257.625122, 2576.489746, 15.231225, 0.000000, 0.000000, 147.899948, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(17055, 410.430725, 2554.000244, 17.685070, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3269, 213.649124, 2540.869628, 15.200450, 1.600000, -2.899997, -57.099967, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3364, 295.372406, 2466.767089, 15.414376, 0.000000, 0.000000, 133.200073, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18451, 357.353485, 2460.614013, 16.881156, 0.000000, 0.000000, -162.399978, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18451, 395.624328, 2546.308593, 15.998253, 0.000000, 0.399998, -43.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16134, 444.837249, 2469.988037, 13.564373, 0.000000, 0.000000, 40.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16134, 450.632812, 2481.878173, 12.982336, 1.099997, 0.000000, -110.000045, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16134, 450.632873, 2494.588867, 12.004375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16134, 454.568511, 2507.945556, 13.004370, 0.000000, 0.000000, -46.300006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2048, 414.621734, 2538.302001, 20.118434, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1479, 401.301177, 2539.807373, 16.943426, 0.000000, 0.000000, 60.099975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1458, 316.202423, 2536.554931, 16.006967, 16.500001, 0.000000, 6.999997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1483, 384.973876, 2534.881347, 17.248983, 0.000000, 0.000000, -0.599999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3168, 430.459869, 2481.781982, 15.424377, 0.000000, 0.000000, -45.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3174, 421.253356, 2479.990966, 15.464373, 0.000000, 0.000000, -121.300010, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3171, 433.032806, 2492.136718, 15.464372, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3172, 434.101867, 2503.235595, 15.530812, 0.599999, 0.000000, 6.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3168, 428.217285, 2515.035644, 15.474381, 0.000000, 0.000000, 55.899986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3172, 414.689453, 2488.280273, 15.484375, 0.000000, 0.000000, -154.200027, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3175, 414.085083, 2499.286376, 15.484375, 0.000000, 0.000000, 165.900054, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1457, 382.246093, 2547.179443, 17.195449, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18634, 415.715515, 2536.077148, 19.002311, 0.000000, 93.899993, -66.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18635, 416.141601, 2535.982910, 19.009241, -80.700019, 5.199998, 51.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18633, 416.201324, 2535.955078, 18.175590, -1.699995, 97.199844, -135.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19167, 415.421325, 2536.366943, 18.955957, 0.000000, 0.199955, -40.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19273, 386.843688, 2546.189208, 17.620225, 0.000000, -0.299997, -89.999961, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19273, 373.951171, 2546.096191, 16.258340, -90.600028, 5.499991, -43.099964, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19313, 433.342742, 2477.909179, 18.696966, 0.000000, 0.000000, 74.599945, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19313, 436.340362, 2491.512695, 18.703561, 0.000000, 0.000000, -99.399848, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19313, 436.652465, 2505.336181, 18.749488, 0.000000, 0.000000, -83.300018, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19313, 435.172454, 2519.237548, 18.760356, 0.000000, 0.000000, 95.399978, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19321, 431.308166, 2519.006347, 17.080535, 21.700002, 26.500019, -138.600128, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19626, 412.210021, 2537.220947, 18.947401, -7.200013, -2.500000, 34.099964, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19619, 416.685394, 2537.634277, 18.518444, 0.000000, 0.000000, -90.100044, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19622, 412.292572, 2537.091308, 18.790632, -16.599985, -1.000000, 68.299964, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19589, 426.705596, 2551.754150, 16.712850, 4.299995, 164.599945, 33.999992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19636, 433.015808, 2519.134033, 16.568376, 1.799998, -43.199989, -19.600008, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19637, 432.616790, 2518.329345, 16.356199, 18.500003, -27.800010, -53.999996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19636, 432.026733, 2517.800292, 16.069749, -34.300006, -2.299999, 48.000003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19638, 432.509338, 2519.591796, 16.280054, 47.799976, -4.800006, -116.099975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19638, 432.306243, 2519.004638, 16.181867, -39.700019, -41.700038, 5.599997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19637, 431.885467, 2518.638183, 15.740792, 3.899997, -28.399999, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19636, 431.946105, 2520.418701, 15.853243, -30.599992, 12.199999, 89.799972, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19624, 412.621215, 2534.814697, 18.266565, -81.599967, 0.000000, -111.400001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19831, 424.924774, 2480.528564, 15.494374, 0.000000, 0.000000, -169.900024, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19817, 362.808288, 2539.022216, 15.655776, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19817, 367.326995, 2539.017578, 15.657922, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.181335, 2555.886962, 15.930233, 0.000000, 0.000000, 58.799995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.139862, 2555.019287, 15.794729, -12.899995, 90.999984, 72.900001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.005554, 2552.296875, 15.831377, -18.600004, 12.800000, 166.400024, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.091735, 2553.025146, 15.810236, 0.000000, 0.000000, 52.599979, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.400817, 2553.865234, 15.793883, 159.699981, -90.899971, 124.099945, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.691223, 2554.570312, 15.974459, 38.900001, -1.200003, -60.599994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.677581, 2555.309326, 15.845546, -39.400001, 0.000000, 131.399902, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19812, 416.261138, 2553.756835, 16.308797, -115.599952, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19815, 417.265380, 2556.384277, 16.442829, 0.000000, 22.099990, -1.199998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11691, 422.111358, 2554.336669, 15.713482, -50.300006, -1.300003, -63.999988, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19994, 423.697204, 2555.239013, 15.767800, 0.000000, -93.599998, -15.199994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19994, 423.413116, 2552.306152, 15.574101, 0.000000, 35.800003, -92.900024, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19994, 423.167419, 2552.630371, 15.738477, -80.900062, 2.900000, -20.600021, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19899, 420.206359, 2555.435302, 15.470233, 0.000000, 0.000000, -115.500007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19900, 417.466125, 2552.185058, 15.709995, 76.399986, -0.499998, -123.699981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19900, 417.210937, 2553.525878, 15.544878, 0.000000, -36.499996, 55.600002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19921, 419.374572, 2555.455322, 16.810239, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19903, 417.763427, 2555.742187, 15.470233, 0.000000, 0.000000, -67.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19917, 420.579193, 2555.132324, 16.730243, 0.000000, 0.000000, 47.099990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19816, 420.082397, 2555.303222, 17.610239, 0.000000, -90.000007, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19816, 420.525543, 2555.134765, 17.621755, 0.000000, -89.199989, -57.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19867, 415.053070, 2497.330810, 15.474374, 0.000000, 0.000000, 63.300006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19867, 416.364349, 2489.019287, 15.444374, 0.000000, 0.000000, 99.300003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19867, 419.564666, 2481.959960, 15.543073, 0.000000, 86.099929, 28.199998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19867, 429.507110, 2483.725830, 15.584361, -89.100044, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19867, 431.246032, 2492.294677, 15.548414, 0.000000, -83.999977, -44.499992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19867, 432.093627, 2505.630859, 15.484375, 0.000000, -0.699998, -71.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19867, 426.648895, 2513.402587, 15.486501, 0.000000, 69.800033, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19898, 367.129455, 2536.661621, 15.688926, 0.000000, -2.200001, 56.000007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19898, 363.066986, 2535.511962, 15.760246, 0.000000, 0.000000, -41.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19898, 364.939270, 2538.742187, 15.686340, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19898, 362.686889, 2541.225830, 15.666885, 0.000000, 0.000000, 169.400039, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19898, 367.143798, 2540.188964, 15.655303, 0.000000, 0.000000, -71.000038, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19872, 355.269866, 2539.526855, 13.974467, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19872, 343.870788, 2539.745361, 13.980807, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19903, 340.833007, 2542.331298, 15.779911, 0.000000, 0.000000, -40.400005, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19903, 356.828308, 2545.557617, 15.982598, 0.000000, -88.700012, -140.100021, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19899, 351.828491, 2544.721679, 15.715375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19899, 347.186828, 2544.316894, 15.769086, 0.000000, 0.000000, 179.500030, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19900, 346.768768, 2546.175292, 16.074113, -6.099997, 71.699996, -28.400001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19900, 356.394348, 2547.355468, 15.560177, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19815, 347.701995, 2538.132324, 17.532024, 0.000000, 0.000000, -89.999946, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19815, 351.364257, 2540.289550, 17.365688, 0.000000, 0.000000, 89.999977, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19870, 352.449554, 2547.820556, 16.735151, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19870, 340.997192, 2547.872314, 16.800941, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19915, 432.893341, 2497.124511, 15.820470, 0.000000, 87.099975, -53.300003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19915, 434.792633, 2496.531738, 15.599351, -39.700012, 25.499998, 128.199874, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19933, 433.870605, 2497.137451, 15.789512, -66.100006, 89.000015, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(853, 431.675598, 2486.527587, 15.864377, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(933, 419.655883, 2483.697509, 15.414374, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(928, 419.170288, 2483.757080, 16.664365, 0.499998, 0.000000, -44.499996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(926, 419.802734, 2483.354248, 16.634378, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(926, 419.885711, 2483.990966, 16.616720, 89.099990, 111.699989, -42.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1347, 417.009124, 2487.619384, 16.054380, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1347, 414.094024, 2493.851318, 15.842221, 90.399971, 43.999996, -0.399998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1347, 432.503173, 2500.690185, 16.054380, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, 412.012023, 2487.431396, 16.654392, 0.000000, 0.000000, -64.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1331, 413.687500, 2484.194580, 16.344383, 0.000000, 0.000000, -65.599967, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1331, 414.463836, 2482.481933, 16.332111, -40.500000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(850, 412.532440, 2482.836914, 15.584377, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(910, 419.083953, 2478.409179, 15.973320, -87.199996, -0.200001, 147.799957, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(851, 417.263793, 2480.267822, 15.764373, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, 417.874420, 2480.952636, 16.185287, 0.000000, -63.699989, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1441, 410.447387, 2490.660400, 16.234384, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1327, 410.619323, 2491.891845, 16.097337, -24.799995, 51.400009, -12.600000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1264, 412.432708, 2485.280029, 15.854374, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 410.594360, 2488.926025, 15.934370, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 413.187011, 2485.474121, 16.121477, 29.499992, 24.200000, 22.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1462, 412.131652, 2498.217529, 15.484375, 0.000000, 0.000000, -106.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1450, 412.254028, 2494.312988, 16.064376, 0.099999, 0.000000, -50.299995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1369, 415.080169, 2492.085449, 16.054382, 0.000000, 0.000000, 106.300003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(933, 432.216827, 2498.793701, 15.434372, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(933, 432.194213, 2510.230712, 16.117708, -59.099994, -79.299995, 15.899995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 430.979675, 2508.367187, 15.954380, 0.000000, 0.000000, -57.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1299, 430.286499, 2488.197509, 15.924373, 0.000000, 0.000000, 23.400014, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(851, 425.178314, 2478.852294, 15.784375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1450, 418.525573, 2484.788818, 16.064376, 0.000000, 0.000000, 122.599975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(960, 414.907928, 2495.445312, 15.864379, 0.000000, 0.000000, -36.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 419.662048, 2492.510498, 15.824379, 0.000000, 0.000000, -30.799993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 427.389343, 2484.984375, 15.764377, 0.000000, 0.000000, -35.600002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 428.393402, 2509.940673, 15.774377, 0.000000, 0.000000, -68.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 414.420318, 2531.986083, 18.452098, 0.000000, 0.000000, -39.799999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 414.067901, 2535.007812, 18.232517, 0.000000, 0.000000, -59.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1415, 418.129760, 2533.984619, 15.629955, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1344, 420.506988, 2533.921630, 16.374931, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2673, 418.983428, 2532.323974, 15.761737, 0.000000, 0.000000, -31.399997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(852, 415.407287, 2533.247558, 15.589398, 0.000000, 0.000000, -67.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 420.687316, 2531.748779, 15.751899, 0.000000, 0.000000, -34.500007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 418.808807, 2531.208251, 15.770548, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1338, 427.797088, 2518.425048, 16.184381, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1338, 433.794799, 2520.935302, 16.033895, 85.000007, -2.299998, -34.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1338, 432.533721, 2521.922607, 16.061487, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1462, 426.694854, 2518.326416, 15.484375, 0.000000, 0.000000, 146.499908, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(850, 430.759613, 2515.808105, 15.574377, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 423.597442, 2495.438720, 15.834379, 0.000000, 0.000000, -76.299980, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 423.219573, 2511.298828, 15.874380, 0.000000, 0.000000, -134.999984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2673, 427.340423, 2501.984375, 15.614377, 0.000000, 0.000000, -52.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2673, 421.310485, 2483.266845, 15.574377, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2673, 422.849090, 2492.087890, 15.584376, 0.000000, 0.000000, -73.599990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(849, 422.710906, 2497.010742, 15.634375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(939, 433.267303, 2538.432373, 17.534360, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(852, 424.223114, 2536.427978, 15.351560, 0.000000, 0.000000, 65.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 424.240753, 2550.333740, 15.307308, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1299, 427.685821, 2548.988281, 15.638098, 0.000000, 0.000000, 24.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 426.133758, 2548.587158, 15.630570, 0.000000, 0.000000, -104.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1450, 425.931549, 2514.262695, 16.074377, 0.000000, 0.000000, -40.100002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 420.044158, 2511.322021, 15.964378, 0.000000, 0.000000, -39.000003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 415.500701, 2502.320068, 15.964380, 0.000000, 0.000000, 4.299991, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2676, 419.148315, 2497.634277, 15.654376, 0.000000, 0.000000, -67.999977, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2676, 428.168823, 2496.159423, 15.614377, 0.000000, 0.000000, -65.300010, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2676, 420.883483, 2486.739257, 15.604375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, 393.366516, 2535.816894, 16.763776, 0.000000, 0.000000, -90.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(853, 404.213348, 2537.568359, 15.865774, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(853, 425.738342, 2543.903320, 15.735164, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(851, 416.707977, 2544.121093, 15.507419, 0.000000, 0.000000, -64.199981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 410.997955, 2522.169921, 15.804379, 0.000000, 0.000000, -90.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 411.127929, 2515.157958, 15.814379, 0.000000, 0.000000, 89.799995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 410.530212, 2507.075683, 15.814379, 0.000000, 0.000000, -87.700012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 400.049194, 2522.328613, 15.814378, 0.000000, 0.000000, -76.900016, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 400.786193, 2514.688232, 15.804381, 0.000000, 0.000000, -95.500007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 399.453796, 2506.674804, 15.824378, 0.000000, 0.000000, -86.900001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 388.702819, 2506.677246, 15.834381, 0.000000, 0.000000, -93.899986, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 390.261688, 2514.835937, 15.834379, 0.000000, 0.000000, -90.800033, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 387.997131, 2523.521240, 15.814379, 0.000000, 0.000000, -86.999961, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(952, 349.528900, 2542.978759, 17.002950, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(952, 349.456207, 2536.139160, 17.003637, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(939, 372.762176, 2534.894287, 17.935367, 0.000000, 0.000000, 89.799980, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(849, 383.249908, 2591.404785, 15.834378, 0.000000, 0.000000, -36.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(853, 380.721527, 2604.394287, 15.854375, 0.000000, 0.000000, 97.099983, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(853, 392.119293, 2600.287353, 15.854374, 0.000000, 0.000000, -43.700008, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(851, 385.880401, 2607.365722, 15.784379, 0.000000, 0.000000, -71.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2676, 384.835845, 2597.108154, 15.604373, 0.000000, 0.000000, -71.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2676, 386.455230, 2604.449951, 15.644374, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 378.421844, 2599.430664, 15.791851, 0.000000, 0.000000, -47.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 382.115539, 2595.042968, 15.764376, 0.000000, 0.000000, -146.999984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 389.351379, 2593.614990, 15.754379, 0.000000, 0.000000, -158.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1224, 387.153808, 2602.801269, 16.134376, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1224, 387.572326, 2601.148681, 16.064376, 0.000000, 0.000000, 67.700012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1224, 386.824676, 2601.679199, 16.024370, 0.000000, 0.000000, -40.100002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1224, 387.426239, 2601.885498, 17.224386, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18248, 378.989288, 2573.809570, 23.434122, 0.000000, 0.000000, 70.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18248, 345.673492, 2485.023925, 23.434368, 0.000000, 0.000000, 134.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2677, 422.815093, 2504.818847, 15.764374, 0.000000, 0.000000, -52.499996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, 425.154205, 2487.509521, 15.574377, 0.000000, 0.000000, -50.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, 423.664337, 2482.466796, 15.514373, 0.000000, 0.000000, -153.099990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1572, 427.226867, 2481.844238, 16.034370, 0.000000, 0.000000, -19.800001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1429, 427.316741, 2482.000244, 15.890688, -82.699996, 2.400000, -148.599975, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1429, 429.889953, 2489.139160, 16.486755, -70.899993, 1.200000, -89.100021, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(923, 431.694915, 2503.518310, 16.344366, 0.000000, 0.000000, -46.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 417.042541, 2507.843994, 15.614377, 0.000000, 0.000000, -68.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 410.174743, 2518.899169, 15.594372, 0.000000, 0.000000, -41.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 405.841766, 2514.425781, 15.574377, 0.000000, 0.000000, -43.999992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 394.408203, 2506.490966, 15.564374, 0.000000, 0.000000, -76.400001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 388.751586, 2519.364257, 15.612112, 0.000000, 0.000000, -101.899978, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 395.860412, 2537.717773, 15.643974, 0.000000, 0.000000, -153.399978, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 421.476318, 2546.792236, 15.430192, 0.000000, 0.000000, -34.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 414.414978, 2548.683837, 15.618795, 0.000000, 0.000000, 58.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 410.450897, 2531.849853, 15.864770, 0.000000, 0.000000, -82.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 401.839599, 2540.161865, 15.685486, 0.000000, 0.000000, -109.400016, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 394.777404, 2517.802001, 15.784379, 0.000000, 0.000000, -121.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 388.532043, 2510.559326, 15.802929, 0.000000, 6.000000, -65.299995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 405.267608, 2508.465576, 15.704380, 0.000000, 0.000000, -105.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 415.034149, 2511.620361, 15.764376, 0.000000, 0.000000, -124.799995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 403.189239, 2519.515136, 15.634375, 0.000000, 0.000000, -27.100002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 398.774017, 2510.723388, 15.574377, 0.000000, 0.000000, -123.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 395.234680, 2527.571777, 15.614883, 0.000000, 0.000000, -98.499977, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 384.306762, 2543.116455, 15.729063, 0.000000, 0.000000, 79.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 380.937225, 2540.553955, 15.809066, 0.000000, 0.000000, 99.199981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1264, 381.415313, 2548.379394, 15.829067, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 383.209960, 2548.108398, 16.009063, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 382.269836, 2547.949951, 15.849066, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 382.226776, 2546.816162, 15.839063, 0.000000, 0.000000, -153.700012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 381.418975, 2547.391845, 15.859066, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1264, 382.548278, 2548.405761, 16.199068, 0.000000, 0.000000, 73.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 382.282623, 2546.465332, 16.039068, 0.000000, 0.000000, -158.699966, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 382.165649, 2544.734130, 15.669065, 0.000000, -0.099999, 50.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 371.626159, 2543.612060, 15.659065, 0.000000, 0.000000, -81.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 360.775878, 2532.152832, 15.837216, 0.000000, 0.000000, -50.600002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 353.161376, 2534.967529, 15.832968, 0.000000, 0.000000, -31.199995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, 354.446777, 2545.402343, 15.841835, 0.000000, 0.000000, -127.999984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 357.301666, 2535.584960, 15.994690, 0.000000, 0.000000, -56.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 273.429534, 2544.668945, 15.812500, 0.000000, 0.000000, -58.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 261.793029, 2550.816894, 16.162506, 0.000000, 0.000000, -26.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(913, 266.138397, 2551.566406, 16.602500, 0.000000, 0.000000, 89.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(912, 266.221496, 2553.082031, 16.708801, -0.599999, -115.500030, 75.100021, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(911, 266.132324, 2554.886230, 16.502433, 0.000000, -50.799995, 104.500007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(913, 267.339599, 2553.748291, 16.486015, -20.500000, 3.299993, 92.100013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(922, 278.469879, 2551.972900, 16.712509, 0.000000, 0.000000, -91.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1299, 275.674468, 2554.504638, 16.212503, 0.000000, 0.000000, -23.800001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1450, 277.290924, 2553.162597, 16.362497, 0.000000, 0.000000, 34.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1264, 276.255645, 2555.617187, 17.032487, 0.000000, 0.000000, -19.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 276.203460, 2553.354003, 16.252506, 0.000000, 0.000000, -96.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(852, 263.262145, 2544.628662, 15.772502, 0.000000, 0.000000, 51.999992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(852, 259.716278, 2554.610107, 15.751649, 0.000000, 0.000000, 41.500007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(851, 275.028900, 2548.608398, 16.102504, 0.000000, 0.000000, -82.600013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 269.374481, 2551.975585, 15.902501, 0.000000, 0.000000, -74.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 271.803741, 2541.381591, 15.942502, 0.000000, 0.000000, -101.700019, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, 269.523986, 2544.024902, 15.842498, 0.000000, 0.000000, -111.099967, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, 274.357757, 2554.521240, 15.822501, 0.000000, 0.000000, -75.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 276.233459, 2551.554687, 15.912508, 0.000000, 0.000000, 77.600006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1299, 341.413635, 2533.758056, 16.159748, 0.000000, 0.000000, 49.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(830, 366.854461, 2453.832275, 16.134372, 0.000000, 0.000000, -131.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(830, 341.979766, 2460.869140, 17.294073, 0.000000, 0.000000, -121.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1365, 358.440063, 2471.020996, 17.654066, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(942, 347.723205, 2471.114746, 19.021190, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(832, 376.034606, 2453.330810, 17.164377, 0.000000, 0.000000, -138.799896, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(850, 373.675354, 2446.295410, 15.564380, 0.000000, 0.000000, -127.000007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, 373.816223, 2449.458251, 16.124370, 0.000000, 0.000000, -53.099994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 373.233825, 2445.731689, 15.764375, 0.000000, 0.000000, -45.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(854, 359.181182, 2453.527099, 15.696559, 0.000000, 0.000000, -75.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1264, 357.870452, 2453.135253, 15.864375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 358.673767, 2452.692626, 16.106565, 0.000000, 0.000000, -133.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, 358.432281, 2453.576171, 15.956554, 0.000000, 0.000000, 156.999938, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(924, 359.103088, 2455.060058, 15.674374, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1357, 359.769592, 2451.853515, 15.774374, 0.000000, 0.000000, 124.699981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 356.453704, 2466.793945, 16.913993, 0.000000, 0.000000, -108.999992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2675, 345.802642, 2463.156494, 16.734069, 0.000000, 0.000000, -105.400001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 400.803710, 2497.344482, 15.564374, 0.000000, 0.000000, 47.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 375.361694, 2522.479492, 15.607446, 0.000000, 0.000000, -135.299972, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 353.096801, 2478.294189, 15.654376, 0.000000, 0.000000, -52.699993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, 390.724487, 2499.962402, 15.814380, 0.000000, 0.000000, -94.500022, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, 396.910278, 2500.237304, 15.774374, 0.000000, 0.000000, 59.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18253, 330.757354, 2487.117919, 18.206487, 0.000000, 0.000000, -43.800010, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(922, 351.876892, 2535.772460, 16.567022, 0.000000, 0.000000, -90.600013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, 338.845336, 2491.955078, 16.554378, 0.000000, 0.000000, -45.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, 337.478485, 2495.365722, 16.414382, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(925, 340.886352, 2546.526123, 16.822021, 0.000000, 0.000000, 89.600006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(931, 346.484375, 2534.025146, 16.831142, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(930, 347.173706, 2542.366699, 16.238607, 0.000000, 0.000000, -69.699981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1348, 340.463195, 2540.300537, 16.460523, 0.000000, 0.000000, -90.000030, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1348, 351.827178, 2542.592285, 16.400203, 0.000000, 0.000000, 90.499938, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3576, 332.419219, 2548.350585, 17.231792, 0.000000, 0.000000, -16.100002, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3630, 332.810150, 2538.251953, 17.216793, 0.000000, 0.000000, 89.699981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2669, 319.435363, 2550.789062, 17.137392, 0.000000, 0.000000, 25.399997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2669, 323.864959, 2551.604736, 17.108659, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2678, 323.084197, 2548.951904, 16.968313, 0.000000, 0.000000, -36.399997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2679, 323.906768, 2548.006591, 15.845786, -89.900009, 3.299998, 140.499984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3796, 332.376434, 2552.845214, 15.808048, 0.000000, 0.000000, 22.699993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3633, 323.165100, 2553.526367, 16.387788, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3633, 324.543334, 2553.527099, 16.381013, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3632, 323.082946, 2552.101562, 16.189243, 44.400001, -89.199996, 56.100009, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1348, 319.044891, 2552.573486, 16.619712, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1348, 320.235260, 2550.909423, 16.589748, 0.000000, 0.000000, -55.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1347, 318.917053, 2547.308349, 16.509756, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2164, 413.896972, 2530.221679, 18.148437, 0.000000, 0.000000, -179.400131, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2200, 416.530944, 2532.322753, 18.148437, 0.000000, 0.000000, -89.799987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1810, 423.393096, 2480.752929, 15.464373, 0.000000, 0.000000, 177.000030, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1810, 422.560577, 2481.407226, 15.484375, 0.000000, 0.000000, 143.899948, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1810, 430.577087, 2493.655517, 15.967618, 1.399999, -89.200019, -113.400009, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3864, 365.015777, 2547.778320, 21.554376, 0.000000, 0.000000, 90.100051, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1216, 386.526367, 2540.094970, 16.209075, 0.000000, 0.000000, -90.100044, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3459, 425.598327, 2525.160888, 15.631171, 88.799957, -48.700057, -1.499987, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3459, 316.930969, 2526.388427, 15.811910, 90.099983, 167.300079, -116.600013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 327.574249, 2493.496337, 15.714380, 0.000000, 0.000000, 41.199985, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, 308.181945, 2463.662597, 15.484375, 0.000000, 0.000000, 126.299995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 316.960052, 2465.199462, 16.024375, 0.000000, 0.000000, -133.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, 307.892852, 2472.851562, 16.074380, 0.000000, 0.000000, 71.100013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(754, 316.348327, 2458.345703, 15.362199, 0.000000, 0.000000, -59.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(754, 306.888214, 2469.476318, 15.471733, 0.000000, 0.000000, -35.000003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(759, 316.361694, 2471.196289, 15.474964, 0.000000, 0.000000, -140.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(759, 306.662139, 2458.126220, 15.606563, 0.000000, 0.000000, -89.299980, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(651, 302.621337, 2474.732177, 15.634371, 0.000000, 0.000000, 34.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(651, 365.995880, 2448.364257, 15.644378, 0.000000, 0.000000, 38.699996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(826, 372.008514, 2461.057861, 15.484375, 0.000000, 0.000000, 35.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 373.928649, 2472.627441, 15.484375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 394.586975, 2510.073486, 15.484375, 0.000000, 0.000000, -53.599994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 400.465789, 2502.131835, 15.484375, 0.000000, 0.000000, -57.099994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 431.310333, 2524.671630, 15.549608, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 432.108489, 2534.814208, 15.409664, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 412.851684, 2526.163330, 15.508673, 0.000000, 0.000000, 53.799999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 381.365325, 2526.568847, 15.595835, 0.000000, 0.000000, 69.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 371.168548, 2522.284179, 15.576637, 0.000000, 0.000000, -57.199993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(759, 319.474853, 2534.648925, 15.737440, 0.000000, 0.000000, -18.500001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(759, 326.645233, 2555.196777, 15.752747, 0.000000, 0.000000, 50.400012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16113, 410.892822, 2604.712402, 13.478324, 0.000000, 0.000000, -9.099999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16112, 415.288391, 2606.758544, 14.665536, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16667, 356.864624, 2590.231689, 12.849947, 0.000000, 0.000000, 46.099990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16139, 373.913665, 2639.130371, 11.442794, 0.000000, 0.000000, -58.300006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(773, 333.070587, 2496.175537, 15.460680, 0.000000, 0.000000, 44.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(893, 373.320373, 2465.747558, 15.434378, 0.000000, 0.000000, -123.199974, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(895, 434.164123, 2511.171386, 15.484375, 0.000000, 0.000000, 145.600112, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(895, 411.578399, 2496.182861, 15.484375, 0.000000, 0.000000, 179.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3625, 392.902679, 2482.084960, 17.984418, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3264, 434.803070, 2525.152343, 15.734758, 0.000000, 0.000000, 95.399978, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3264, 417.545593, 2551.502929, 15.170668, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3264, 357.821136, 2532.791259, 15.661562, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3264, 346.579010, 2532.867919, 15.726779, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19825, 416.649902, 2535.064208, 20.278436, 0.000000, 0.000000, -90.100013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3578, 392.869262, 2488.069091, 16.234388, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11445, 319.970977, 2436.799072, 15.618956, 0.000000, 0.000000, -163.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11441, 307.309936, 2439.265869, 15.450428, 0.000000, 0.000000, 144.400009, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3576, 343.515594, 2470.457031, 18.061201, 0.000000, 0.000000, 89.399971, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3577, 400.210754, 2481.014648, 18.835054, 0.000000, 0.000000, -179.699890, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3796, 391.233215, 2479.595947, 18.085042, 0.000000, 0.000000, -99.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3569, 294.921661, 2542.291748, 18.200611, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3566, 287.265197, 2542.052490, 18.199628, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3565, 403.131378, 2478.769042, 16.834396, 0.000000, 0.000000, -90.099922, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3791, 404.170471, 2544.891845, 15.960659, 0.000000, 0.000000, -95.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3787, 413.615173, 2531.853027, 16.161188, 0.000000, 0.000000, -40.299983, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3787, 423.543701, 2540.298095, 16.040903, 0.000000, 0.000000, 130.199981, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3791, 385.192291, 2533.586669, 16.062055, 0.000000, 0.000000, -73.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(864, 397.847320, 2535.375244, 15.554659, 0.000000, 0.000000, -55.300003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(864, 402.518615, 2555.831787, 15.501026, 0.000000, 0.000000, -34.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(864, 389.121154, 2560.982421, 15.598526, 0.000000, 0.000000, 128.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(864, 394.678161, 2575.697753, 15.455982, 0.000000, 0.000000, -37.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(864, 383.086700, 2600.580078, 15.484375, 0.000000, 0.000000, -43.999992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(864, 407.409881, 2547.517822, 15.415972, 0.000000, 0.000000, 41.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(864, 418.198577, 2505.127441, 15.484375, 0.000000, 0.000000, 27.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 427.621154, 2492.673095, 15.484375, 0.000000, 0.000000, -33.099994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(866, 403.927032, 2493.301513, 15.484375, 0.000000, 0.000000, -45.999996, object_world, object_int, -1, 300.00, 300.00);

            //QEBRADOS MAPP DOWN
            //tmpobjid = CreateDynamicObject(19433, -1532.112426, 2656.818115, 54.251419, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0x00000000);
            var qebrados1 = new DynamicObject(19433, new Vector3(-1532.112426, 2656.818115, 54.251419), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            qebrados1.SetMaterial(0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0);

            // tmpobjid = CreateDynamicObject(19433, -1531.201538, 2656.878173, 55.191337, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0x00000000);
            var qebrados2 = new DynamicObject(19433, new Vector3(-1531.201538, 2656.878173, 55.191337), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            qebrados2.SetMaterial(0, 14612, "ab_abattoir_box", "ab_bloodfloor", 0);

            // tmpobjid = CreateDynamicObject(19831, -1527.274780, 2644.495361, 54.745948, 0.000000, 0.000000, -22.400007, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "Metalox64", 0x00000000);
            // SetDynamicObjectMaterial(tmpobjid, 1, 16640, "a51", "Metalox64", 0x00000000);
            var qebrados3 = new DynamicObject(19831, new Vector3(-1527.274780, 2644.495361, 54.745948), new Vector3(0.000000, 0.000000, -22.400007), 0, 0, player, 300, 300);
            qebrados3.SetMaterial(0, 16640, "a51", "Metalox64", 0);
            qebrados3.SetMaterial(1, 16640, "a51", "Metalox64", 0);

            // tmpobjid = CreateDynamicObject(2906, -1527.287841, 2644.468261, 55.622097, 2.600000, 93.800003, -112.499992, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFF996600);
            var qebrados4 = new DynamicObject(2906, new Vector3(-1527.287841, 2644.468261, 55.622097), new Vector3(2.600000, 93.800003, -112.499992), 0, 0, player, 300, 300);
            qebrados4.SetMaterial(0, -1, "none", "none", 0xFF996600);

            //  tmpobjid = CreateDynamicObject(1413, -1534.995605, 2569.827148, 56.085842, 0.000000, 0.000000, -90.499946, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 1597, "centralresac1", "kbtree3_test", 0x00000000);
            var qebrados5 = new DynamicObject(1413, new Vector3(-1534.995605, 2569.827148, 56.085842), new Vector3(0.000000, 0.000000, -90.499946), 0, 0, player, 300, 300);
            qebrados5.SetMaterial(0, 1597, "centralresac1", "kbtree3_test", 0);

            //  tmpobjid = CreateDynamicObject(19375, -1420.796020, 2591.099121, 55.188316, 0.000000, 0.000000, 89.400009, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "concretegroundl1_256", 0x00000000);
            var qebrados6 = new DynamicObject(19375, new Vector3(-1420.796020, 2591.099121, 55.188316), new Vector3(0.000000, 0.000000, 89.400009), 0, 0, player, 300, 300);
            qebrados6.SetMaterial(0, 16640, "a51", "concretegroundl1_256", 0);

            //  tmpobjid = CreateDynamicObject(19439, -1483.589599, 2609.723632, 57.247196, 0.000000, 58.200027, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 16136, "des_telescopestuff", "dish_panel_B", 0x00000000);
            var qebrados7 = new DynamicObject(19439, new Vector3(-1483.589599, 2609.723632, 57.247196), new Vector3(0.000000, 58.200027, 90.000000), 0, 0, player, 300, 300);
            qebrados7.SetMaterial(0, 16136, "des_telescopestuff", "dish_panel_B", 0);

            //  tmpobjid = CreateDynamicObject(16133, -1342.953002, 2587.552001, 50.008716, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            var qebrados8 = new DynamicObject(16133, new Vector3(-1342.953002, 2587.552001, 50.008716), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            qebrados8.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);

            //  tmpobjid = CreateDynamicObject(19366, -1483.269897, 2642.794433, 59.296108, 0.000000, 9.099993, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "bonyrd_skin2", 0x00000000);
            var qebrados9 = new DynamicObject(19366, new Vector3(-1483.269897, 2642.794433, 59.296108), new Vector3(0.000000, 9.099993, 90.000000), 0, 0, player, 300, 300);
            qebrados9.SetMaterial(0, 16640, "a51", "bonyrd_skin2", 0);

            //   tmpobjid = CreateDynamicObject(944, -1478.045410, 2638.272705, 58.481277, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //   SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            var qebrados11 = new DynamicObject(944, new Vector3(-1478.045410, 2638.272705, 58.481277), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            qebrados11.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);

            //   tmpobjid = CreateDynamicObject(19379, -1470.875488, 2615.993164, 60.487976, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //   SetDynamicObjectMaterial(tmpobjid, 0, 16326, "des_byoffice", "plainwoodenfence1_256", 0x00000000);
            
            //   tmpobjid = CreateDynamicObject(1997, -1506.617797, 2537.101074, 54.687500, 0.000000, 0.000000, -62.700000, object_world, object_int, -1, 300.00, 300.00);
            //   SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFFFFFFFF);
            var qebrados13 = new DynamicObject(1997, new Vector3(-1506.617797, 2537.101074, 54.687500), new Vector3(0.000000, 0.000000, -62.700000), 0, 0, player, 300, 300);
            qebrados13.SetMaterial(0, -1, "none", "none", 0xFFFFFFFF);

            //   tmpobjid = CreateDynamicObject(19379, -1470.875488, 2623.430664, 60.467979, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //   SetDynamicObjectMaterial(tmpobjid, 0, 16326, "des_byoffice", "plainwoodenfence1_256", 0x00000000);
            
            //    tmpobjid = CreateDynamicObject(2892, -1558.161621, 2671.061279, 54.655960, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //   SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "Metalox64", 0x00000000);
            var qebrados15 = new DynamicObject(2892, new Vector3(-1558.161621, 2671.061279, 54.655960), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            qebrados15.SetMaterial(0, 16640, "a51", "Metalox64", 0);

            //    tmpobjid = CreateDynamicObject(2115, -1479.093627, 2639.739990, 58.232109, -88.200004, 0.000000, 59.300075, object_world, object_int, -1, 300.00, 300.00);
            //   SetDynamicObjectMaterial(tmpobjid, 0, 14789, "ab_sfgymmain", "gym_floor6", 0x00000000);
            var qebrados16 = new DynamicObject(2115, new Vector3(-1479.093627, 2639.739990, 58.232109), new Vector3(-88.200004, 0.000000, 59.300075), 0, 0, player, 300, 300);
            qebrados16.SetMaterial(0, 14789, "ab_sfgymmain", "gym_floor6", 0);
            //tmpobjid = CreateDynamicObject(3040, -1523.754272, 2569.414062, 54.508640, -63.800041, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 1, -1, "none", "none", 0x01FFFFFF);
            //SetDynamicObjectMaterial(tmpobjid, 2, -1, "none", "none", 0x00FFFFFF);
            //SetDynamicObjectMaterial(tmpobjid, 4, -1, "none", "none", 0x00FFFFFF);
            var qebrados17 = new DynamicObject(3040, new Vector3(-1523.754272, 2569.414062, 54.508640), new Vector3(-63.800041, 0.000000, 90.000000), 0, 0, player, 300, 300);
            qebrados17.SetMaterial(1, -1, "none", "none", 0x01FFFFFF);
            qebrados17.SetMaterial(2, -1, "none", "none", 0x00FFFFFF);
            qebrados17.SetMaterial(4, -1, "none", "none", 0x00FFFFFF);

            //tmpobjid = CreateDynamicObject(3040, -1521.162963, 2569.414062, 54.545864, -63.800041, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 1, -1, "none", "none", 0x01FFFFFF);
            //SetDynamicObjectMaterial(tmpobjid, 2, -1, "none", "none", 0x00FFFFFF);
            //SetDynamicObjectMaterial(tmpobjid, 4, -1, "none", "none", 0x00FFFFFF);
            var qebrados18 = new DynamicObject(3040, new Vector3(-1521.162963, 2569.414062, 54.545864), new Vector3(-63.800041, 0.000000, 270.000000), 0, 0, player, 300, 300);
            qebrados18.SetMaterial(1, -1, "none", "none", 0x01FFFFFF);
            qebrados18.SetMaterial(2, -1, "none", "none", 0x00FFFFFF);
            qebrados18.SetMaterial(4, -1, "none", "none", 0x00FFFFFF);

            //tmpobjid = CreateDynamicObject(1771, -1522.066650, 2569.696044, 54.775947, 0.000000, 0.000000, 7.499998, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 1, -1, "none", "none", 0x00FFFFFF);
            var qebrados19 = new DynamicObject(1771, new Vector3(-1522.066650, 2569.696044, 54.775947), new Vector3(0.000000, 0.000000, 7.499998), 0, 0, player, 300, 300);
            qebrados19.SetMaterial(1, -1, "none", "none", 0x00FFFFFF);

            //tmpobjid = CreateDynamicObject(1310, -1514.009277, 2573.520507, 54.923355, -14.999999, 0.000000, -96.899993, object_world, object_int, -1, 300.00, 300.00); 
            //SetDynamicObjectMaterial(tmpobjid, 0, -1, "none", "none", 0xFF333300);
            var qebrados20 = new DynamicObject(1310, new Vector3(-1514.009277, 2573.520507, 54.923355), new Vector3(-14.999999, 0.000000, -96.899993), 0, 0, player, 300, 300);
            qebrados20.SetMaterial(0, -1, "none", "none", 0xFF333300);

            CreateDynamicObject(1440, -1486.790893, 2615.993408, 55.315696, 0.000000, 0.000000, -89.799957, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, -1486.810180, 2621.372070, 55.315696, 0.000000, 0.000000, -89.799957, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1686, -1327.104736, 2685.018798, 49.710357, -2.499997, -97.699913, 95.099945, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(926, -1306.750610, 2696.008300, 49.312458, 0.000000, 0.000000, -24.299995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, -1291.009765, 2705.433593, 49.572517, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1349, -1280.537719, 2704.014404, 49.612487, 0.000000, 0.000000, -18.200000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19589, -1242.576416, 2692.817871, 49.209709, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2672, -1274.156005, 2707.454589, 49.352481, 0.000000, 0.000000, -67.000053, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2671, -1258.232788, 2712.831542, 49.082473, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(639, -1323.744384, 2683.158691, 53.154235, 0.000000, 0.000000, 172.299972, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(635, -1324.650146, 2676.933105, 54.649032, 1.100000, -90.000000, 171.900573, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1326.772583, 2677.782226, 49.174247, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3092, -1391.911010, 2643.528564, 57.159324, -1.299997, -2.199998, 91.500099, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(635, -1325.324096, 2671.489990, 54.644245, 1.100000, -90.000000, 171.900573, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1431.605468, 2459.201416, 59.628982, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1438.802001, 2469.338867, 60.173393, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1439.295288, 2457.982421, 59.338417, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1358, -1433.592651, 2457.228027, 60.647144, 5.099998, -8.099997, 9.100001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1495.468017, 2601.400878, 54.927436, 2.899999, 0.000000, 97.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11453, -1409.662841, 2651.622070, 54.808815, -90.100021, 0.000000, -57.000003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, -1514.471313, 2569.936523, 55.445934, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3573, -1303.170043, 2704.423828, 51.682456, 0.000000, 0.000000, -172.000106, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19632, -1514.446533, 2569.963623, 55.165885, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16444, -1395.012573, 2644.067382, 55.253398, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3035, -1389.139648, 2649.062988, 55.731765, -0.799993, 0.000000, -90.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2059, -1516.483886, 2570.085449, 54.855976, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1389.136108, 2648.577880, 56.824176, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3035, -1389.098388, 2651.283447, 55.718357, -0.199999, 0.399999, -90.400016, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1450, -1390.460937, 2648.670654, 55.623043, 1.299997, -0.699990, 175.900024, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1391.173095, 2651.274169, 55.410022, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1390.583007, 2651.466064, 55.854709, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1390.233032, 2651.145263, 55.424732, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1533.769775, 2660.305908, 55.561355, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1450, -1532.815185, 2660.074707, 55.918514, 0.399999, 0.399999, -89.399978, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(12957, -1401.226318, 2647.292236, 55.327503, 1.200000, 0.899999, -52.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2906, -1533.450805, 2660.499023, 55.604690, -30.500005, 2.499999, -23.600021, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, -1402.225219, 2649.147216, 55.367511, 0.000000, 0.499999, -148.900009, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1428, -1267.954345, 2712.620361, 50.427024, -12.299982, 0.000000, 26.399997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, -1339.821411, 2642.826660, 49.799232, 0.000000, 0.000000, 158.599990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, -1337.610717, 2638.679199, 49.823612, 0.000000, 0.000000, -40.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1349, -1275.733276, 2710.908447, 49.812500, 0.000000, 0.000000, -81.799980, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1349, -1253.677978, 2702.826416, 49.434364, -87.600006, 0.000000, -81.799980, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, -1341.553466, 2639.753417, 49.933639, 0.000000, -0.100000, 49.199989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, -1284.384277, 2691.755859, 49.462463, 0.000000, 0.000000, -43.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1356.115844, 2671.802978, 50.264225, 0.000000, 0.000000, -48.400001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(845, -1360.570068, 2642.469482, 51.485496, 0.000000, 0.000000, -91.099945, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, -1505.184692, 2576.734130, 55.908695, 2.399999, 71.299957, 0.600001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1326.772583, 2677.782226, 49.174247, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1400.983398, 2644.289550, 54.934268, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1280.152954, 2665.310302, 48.953262, 2.899999, 0.000000, 97.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, -1531.987548, 2641.281738, 55.285949, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2673, -1533.265502, 2658.905517, 55.422229, 0.300000, 0.399999, -35.700000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(337, -1533.484008, 2658.894775, 55.451293, -10.099999, 93.499977, -0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1431, -1532.652221, 2653.970458, 55.791301, 0.000000, 0.000000, 88.200027, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3172, -1521.643676, 2634.382568, 54.825942, 0.000000, 0.000000, -19.500013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(322, -1532.322631, 2657.384033, 55.307426, 32.899993, 0.000000, -3.599999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, -1524.504028, 2632.614746, 54.925998, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, -1526.625854, 2639.140625, 54.955936, 0.000000, 0.000000, 72.599998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1523.373291, 2673.250244, 54.687500, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1440, -1521.760498, 2640.634277, 55.385913, 0.000000, 0.000000, -114.600059, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1537.731323, 2673.250244, 54.687500, 0.000000, 0.000000, 54.199993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1428, -1531.385253, 2623.649902, 56.335918, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18451, -1269.416381, 2669.071044, 48.051708, 0.399999, -1.099999, 113.499977, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(672, -1414.023681, 2700.911376, 59.848072, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1338, -1260.758789, 2697.349365, 49.422477, 0.000000, 0.000000, -17.699998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(672, -1410.295532, 2675.862548, 55.348445, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(672, -1428.990356, 2687.071289, 55.618766, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2912, -1528.364135, 2644.786621, 54.845939, 0.000000, 0.000000, -5.600000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11722, -1528.496826, 2644.858398, 55.675971, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1665, -1528.425537, 2644.589599, 55.565925, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(643, -1527.416259, 2629.112548, 55.315883, 0.000000, 0.000000, 12.700049, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1800, -1519.031005, 2525.280273, 54.657482, 0.000000, 0.000000, 26.600000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1800, -1510.644531, 2524.871093, 54.637481, 0.000000, 0.000000, -31.299991, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1369, -1515.996337, 2523.457275, 55.380100, 0.000000, 0.000000, 67.900001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1521.063476, 2531.682617, 54.687500, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1506.666625, 2528.795654, 54.687500, 0.000000, 0.000000, 54.300003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(635, -1520.567749, 2518.354736, 58.261695, 0.000000, 270.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, -1510.490600, 2611.033447, 56.035934, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(635, -1517.408081, 2522.198486, 57.501728, 0.000000, 270.000000, 360.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(635, -1517.378051, 2524.020263, 57.541721, 0.000000, 270.000000, 360.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1544.910766, 2570.214111, 54.835937, 0.000000, 0.000000, -19.300001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(849, -1401.861572, 2624.920654, 55.112911, -1.800000, -0.100000, 52.999992, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, -1507.320800, 2611.033447, 56.145969, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1328, -1411.834716, 2625.998291, 54.883258, -85.299987, 0.000000, -34.099994, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1450, -1506.413208, 2610.044677, 55.405906, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, -1411.329101, 2627.059570, 54.697513, 0.000000, 0.000000, 47.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(956, -1455.119995, 2592.891113, 55.234401, 90.000000, 0.000000, 153.599929, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3005, -1412.982299, 2632.334472, 54.840278, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1294, -1520.890747, 2596.927734, 54.914852, 91.499977, 0.000000, 178.599990, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1294, -1482.197021, 2598.358886, 58.043594, -7.100027, -27.199909, -78.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19586, -1528.229614, 2644.560791, 55.577552, -3.600011, -89.699974, 159.999923, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(944, -1483.616210, 2607.765380, 55.715919, 0.000000, 0.000000, -5.399998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19589, -1494.838745, 2601.018310, 54.687500, 0.000000, 0.000000, 91.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1340.824218, 2640.371093, 50.746139, 2.899999, 0.000000, 97.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1493.375732, 2601.115966, 54.934043, 23.299976, -120.400039, -10.699995, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1496.194946, 2600.184326, 55.037990, 40.799999, 0.000000, -97.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1494.434814, 2600.684570, 55.388011, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1494.955078, 2601.563232, 55.318004, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1493.595214, 2599.153564, 55.037994, 0.000000, 0.000000, -43.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1265, -1494.954711, 2598.893798, 55.037998, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1428, -1483.404052, 2606.030273, 55.513164, -37.100009, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18704, -1518.698486, 2658.784423, 61.840476, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1494.979858, 2637.063232, 54.687500, 0.000000, 0.000000, -40.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1494.784667, 2655.981689, 54.687500, 0.000000, 0.000000, -40.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1474.318237, 2653.598144, 53.977523, 0.000000, 0.000000, -40.699989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1463.962524, 2644.690673, 53.977523, 0.000000, 0.000000, -134.099960, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(18451, -1427.355834, 2608.166259, 55.151973, 0.000000, 0.000000, 115.200027, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1424.423217, 2607.640136, 54.934268, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3337, -1337.150024, 2632.399902, 50.898399, 0.000000, 0.000000, 130.000030, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(849, -1465.368530, 2593.357421, 55.065929, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3035, -1462.670654, 2586.428466, 55.575885, 0.000000, 0.000000, 93.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1294, -1490.960205, 2573.522216, 59.042087, 0.000000, -0.599997, -22.499996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11543, -1461.160034, 2627.679931, 62.351600, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1421, -1483.028442, 2642.040527, 58.511249, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1413, -1485.679199, 2621.593750, 59.277992, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3302, -1485.855957, 2625.593261, 59.415908, 90.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3252, -1576.723632, 2646.414306, 54.835937, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1413, -1485.679199, 2617.544677, 59.277992, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3302, -1485.855957, 2625.793457, 56.865901, 90.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1447, -1485.629760, 2629.516601, 59.111293, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1447, -1485.629760, 2634.406982, 59.071350, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1447, -1485.629760, 2639.666015, 59.071350, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(983, -1472.813598, 2611.278808, 58.217998, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, -1479.326171, 2635.260009, 57.761280, 0.000000, 0.000000, -82.099967, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1804, -1478.629516, 2633.976318, 57.643352, 1.899999, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, -1477.306640, 2631.652587, 57.761280, 0.000000, 0.000000, 176.999816, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2972, -1477.247436, 2638.142822, 59.037963, 0.000000, 0.000000, -3.699997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2972, -1478.783447, 2638.244140, 59.037963, 0.000000, 0.000000, 18.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(8674, -1474.021606, 2630.750244, 56.235935, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, -1478.843872, 2631.732177, 57.761280, 0.000000, 0.000000, 176.999816, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(8674, -1463.729980, 2630.750244, 56.235935, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(8674, -1458.489624, 2625.579833, 56.235935, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(8572, -1473.518798, 2624.558593, 56.551326, 0.000000, 0.000000, -180.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(805, -1558.127197, 2621.616455, 55.485939, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2943, -1521.258911, 2610.207031, 55.525943, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(842, -1473.296997, 2620.499755, 57.861274, 0.000000, 0.000000, -17.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(926, -1518.934326, 2567.293212, 55.095954, 0.000000, 0.000000, -10.799998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1521.289672, 2581.876953, 54.167537, 0.000000, 0.000000, 0.000007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, -1509.419555, 2670.098876, 55.107490, 0.000000, 0.000000, -51.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1800, -1477.213867, 2639.464355, 57.568019, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1567.716552, 2672.193603, 54.507503, 0.000000, 0.000000, 54.199993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(11729, -1478.124511, 2642.810791, 57.687988, 0.000000, 0.000000, 7.399999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19999, -1477.036010, 2639.989746, 57.737995, 0.000000, 0.000000, -53.500003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1597.893310, 2664.778808, 54.939857, -0.300000, -1.699999, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2059, -1479.106323, 2640.540527, 57.797966, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1422, -1618.249023, 2658.895996, 54.454986, 0.000000, 0.000000, 25.399999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1422, -1623.063720, 2656.610107, 54.454986, 0.000000, 0.000000, 25.399999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1424, -1620.183593, 2656.763916, 54.674682, -0.399999, 0.000000, 26.999984, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19624, -1478.789794, 2642.825439, 58.177940, 0.000000, 0.000000, -40.400005, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1602.589111, 2664.884765, 54.778614, -0.300000, -1.599999, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1593.205444, 2664.672607, 55.060779, -0.300000, -2.299999, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1427, -1624.942382, 2654.406494, 54.648406, 0.000000, 0.000000, 26.900003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1427, -1615.698730, 2658.998779, 54.648406, 0.000000, 0.000000, 26.900003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1458, -1595.723754, 2659.488037, 54.561901, 0.499999, -6.000000, -35.899997, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(13591, -1615.093017, 2642.828613, 56.010341, -1.399999, -8.699995, -55.199996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1588.530761, 2664.566406, 55.271408, -0.300000, -2.300000, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1812, -1485.558837, 2635.180175, 58.271270, 0.000000, 90.000000, -28.600156, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1583.887207, 2664.460937, 55.477985, -0.300000, -1.900000, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3005, -1482.317260, 2625.448730, 57.791275, 0.000000, 0.000000, -26.500000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1579.240966, 2664.356445, 55.552154, -0.300000, -0.100000, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1413, -1482.303466, 2614.747802, 57.888019, 90.000000, 0.000000, -60.199954, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1574.541381, 2664.248046, 55.560367, -0.300000, -0.100000, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1410, -1569.872558, 2664.139892, 55.568531, -0.300000, -0.100000, -1.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1431, -1479.442626, 2623.287597, 58.281257, 0.000000, 0.000000, 45.400001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1572.108398, 2645.300537, 54.327507, 0.000000, 0.000000, 54.199993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1595.280151, 2655.652343, 54.507503, 0.000000, 0.000000, 54.199993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1547.838134, 2657.854492, 54.507503, 0.000000, 0.000000, 54.199993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2907, -1474.306640, 2630.811767, 55.367263, -100.099983, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2905, -1474.443725, 2631.179687, 54.904186, 0.000000, -79.299957, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2905, -1474.264160, 2631.124023, 54.723533, -37.099994, -79.299957, 1.000001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(14873, -1562.568603, 2638.556152, 55.655933, 0.000000, 0.000000, 88.200012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(12957, -1562.482666, 2647.864501, 55.595924, 0.000000, 0.000000, -90.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1457, -1561.146118, 2624.132812, 56.415920, 0.000000, 0.000000, 125.999923, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, -1484.923583, 2623.069824, 58.361244, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, -1484.923583, 2632.409912, 58.361244, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1562.776977, 2630.311279, 54.507503, 0.000000, 0.000000, 100.800003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3171, -1584.127319, 2642.237792, 54.825698, 0.000000, 0.000000, -160.799942, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1441, -1570.100952, 2651.892822, 55.455856, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1451, -1574.396484, 2637.673339, 55.625926, 0.000000, 0.000000, -178.899948, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1452, -1578.683593, 2635.872314, 55.825881, 0.000000, 0.000000, 144.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1439, -1572.196655, 2653.363769, 54.895927, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1423.664306, 2662.551025, 54.934268, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1453.010009, 2671.382324, 54.934268, 0.000000, 0.000000, 88.399993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19816, -1443.178710, 2651.937255, 55.105934, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3593, -1428.135009, 2643.482421, 55.117439, 0.000000, 0.000000, 5.400000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19816, -1442.948486, 2651.737060, 55.105934, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16405, -1562.290771, 2691.768554, 56.435939, 0.000000, 0.000000, -94.000007, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1555.848510, 2688.649169, 54.507503, 0.000000, 0.000000, 54.199993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1514.799682, 2689.286865, 54.507503, 0.000000, 0.000000, 36.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1458, -1508.632202, 2696.032226, 54.991127, 2.499987, 0.000000, 39.299999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, -1276.982910, 2683.624511, 49.091037, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1266.249267, 2670.270507, 48.538368, 2.899999, 0.000000, 106.199989, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1266.482055, 2671.102050, 47.709457, 2.899999, 0.000000, 97.000015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1219, -1247.583618, 2666.374511, 47.221969, -2.300001, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, -1209.971313, 2679.230468, 45.417499, 0.000000, 0.000000, -78.700004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1503, -1272.492309, 2666.932373, 47.223194, 0.000000, 0.000000, -71.100013, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1427, -1203.809448, 2695.129638, 45.487163, 0.000000, 0.000000, -113.199974, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1279.983154, 2665.308837, 48.944660, 2.899999, 0.000000, 89.500022, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1370, -1227.693969, 2676.295898, 45.993961, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1399.565307, 2559.350585, 58.356220, -6.299994, 0.000000, -22.099996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1392.142089, 2577.602050, 56.070804, -6.299994, 0.000000, 38.200004, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, -1390.402832, 2571.789062, 57.376556, -5.599999, 0.000000, -17.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16118, -1443.411376, 2525.548339, 49.381488, 0.000000, 0.000000, 138.500015, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(16503, -1479.081298, 2519.670166, 68.890975, 0.000000, -35.499973, -32.900012, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(805, -1567.754028, 2569.940185, 68.239707, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(805, -1568.527954, 2577.873535, 67.751235, 0.000000, 0.000000, -59.099998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(837, -1569.985351, 2584.609619, 67.148551, -0.799999, 1.100000, 106.599945, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1431, -1569.858886, 2592.868652, 66.547515, 0.000000, 0.000000, -79.899993, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(3594, -1543.752319, 2731.737060, 61.902538, -3.400000, 0.000000, 53.799980, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2977, -1513.243896, 2576.258544, 54.835937, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1482, -1515.666503, 2570.468017, 56.185932, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(874, -1524.141845, 2574.191894, 53.967548, 0.000000, 0.000000, -68.500022, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19996, -1514.269897, 2571.680175, 54.825927, 0.000000, 0.000000, -62.300003, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2060, -1516.276245, 2567.223876, 54.835937, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2060, -1515.166137, 2567.223876, 54.835937, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2060, -1514.489257, 2567.223632, 54.971672, 1.000000, 11.300001, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2866, -1517.761108, 2567.346923, 54.835929, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1636, -1513.442138, 2575.847656, 56.220752, -44.500003, 0.000000, -2.800001, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2044, -1513.356689, 2576.380859, 56.065944, 0.000000, 0.000000, -63.900020, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1672, -1513.089111, 2576.044189, 56.067337, -29.799991, 71.799934, -57.100006, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2674, -1515.747680, 2573.138427, 54.845996, 0.000000, 0.000000, -21.699998, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(2670, -1520.507080, 2573.520019, 54.925949, 0.000000, 0.000000, -17.899999, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1442, -1519.922119, 2582.157958, 55.445934, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19632, -1519.946899, 2582.197021, 55.165885, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(17055, -1526.568237, 2583.534179, 55.595943, 0.000000, 0.000000, -177.400024, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1344, -1528.702758, 2567.777343, 55.635940, 0.000000, 0.000000, -179.399948, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(1349, -1529.898803, 2570.510498, 55.355884, 0.000000, 0.000000, -29.499996, object_world, object_int, -1, 300.00, 300.00);
            CreateDynamicObject(19904, -1514.040405, 2570.862792, 55.150653, -3.799998, 12.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);

            //PUSTINA MAP OBJECTS DOWN

            //tmpobjid = CreateDynamicObject(16091, 861.846679, 716.928955, 10.933140, 0.000000, 0.000000, 22.099996, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "Metalox64", 0x00000000);
            var desertmap1 = new DynamicObject(16091, new Vector3(861.846679, 716.928955, 10.933140), new Vector3(0.000000, 0.000000, 22.099996),0,0,player, 400,400);
            desertmap1.SetMaterial(0, 16640, "a51", "Metalox64", 0);
            //tmpobjid = CreateDynamicObject(16091, 869.441528, 698.599426, 10.933140, 0.000000, 0.000000, 22.099996, object_world, object_int, -1, 300.00, 300.00);
            // SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "Metalox64", 0x00000000);
            var desertmap2 = new DynamicObject(16091, new Vector3(869.441528, 698.599426, 10.933140), new Vector3(0.000000, 0.000000, 22.099996), 0, 0, player, 400, 400);
            desertmap2.SetMaterial(0, 16640, "a51", "Metalox64", 0);
            // tmpobjid = CreateDynamicObject(16091, 867.903564, 697.974182, 10.933140, 0.000000, 0.000000, 22.099996, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "Metalox64", 0x00000000);
            var desertmap3 = new DynamicObject(16091, new Vector3(867.903564, 697.974182, 10.933140), new Vector3(0.000000, 0.000000, 22.099996), 0, 0, player, 400, 400);
            desertmap3.SetMaterial(0, 16640, "a51", "Metalox64", 0);

            // tmpobjid = CreateDynamicObject(16091, 860.326354, 716.311462, 10.933140, 0.000000, 0.000000, 22.099996, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 16640, "a51", "Metalox64", 0x00000000);
            var desertmap4 = new DynamicObject(16091, new Vector3(860.326354, 716.311462, 10.933140), new Vector3(0.000000, 0.000000, 22.099996), 0, 0, player, 400, 400);
            desertmap4.SetMaterial(0, 16640, "a51", "Metalox64", 0);

            //  tmpobjid = CreateDynamicObject(19641, -1507.965209, 1979.807495, 46.449943, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 3374, "ce_farmxref", "sw_barndoor1", 0x00000000);
            var desertmap5 = new DynamicObject(19641, new Vector3(-1507.965209, 1979.807495, 46.449943), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 400, 400);
            desertmap5.SetMaterial(0, 3374, "ce_farmxref", "sw_barndoor1", 0);
            //  tmpobjid = CreateDynamicObject(19641, -1510.276245, 1971.014892, 46.449943, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 3374, "ce_farmxref", "sw_barndoor1", 0x00000000);
            var desertmap6 = new DynamicObject(19641, new Vector3(-1510.276245, 1971.014892, 46.449943), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 400, 400);
            desertmap6.SetMaterial(0, 3374, "ce_farmxref", "sw_barndoor1", 0);

            //  tmpobjid = CreateDynamicObject(1494, -1506.292480, 1970.975341, 47.451869, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 3374, "ce_farmxref", "sw_barndoor2", 0x00000000);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 3374, "ce_farmxref", "sw_barndoor1", 0x00000000);
            var desertmap7 = new DynamicObject(1494, new Vector3(-1506.292480, 1970.975341, 47.451869), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 400, 400);
            desertmap7.SetMaterial(0, 3374, "ce_farmxref", "sw_barndoor2", 0);
            desertmap7.SetMaterial(1, 3374, "ce_farmxref", "sw_barndoor1", 0);

            //  tmpobjid = CreateDynamicObject(3850, -1506.395263, 1971.005615, 50.401668, 180.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 3374, "ce_farmxref", "sw_barndoor1", 0x00000000);
            var desertmap8 = new DynamicObject(3850, new Vector3(-1506.395263, 1971.005615, 50.401668), new Vector3(180.000000, 0.000000, 90.000000), 0, 0, player, 400, 400);
            desertmap8.SetMaterial(0, 3374, "ce_farmxref", "sw_barndoor1", 0);

            //  tmpobjid = CreateDynamicObject(3073, -403.227478, 1882.585815, 56.232219, 4.299998, 0.000000, 31.800006, object_world, object_int, -1, 300.00, 300.00);
            //  SetDynamicObjectMaterial(tmpobjid, 0, 3411, "ce_railbridge", "rusta256128", 0xFFFFFFFF);
            //  SetDynamicObjectMaterial(tmpobjid, 1, 3411, "ce_railbridge", "rusta256128", 0x00000000);
            var desertmap9 = new DynamicObject(3073, new Vector3(-403.227478, 1882.585815, 56.232219), new Vector3(4.299998, 0.000000, 31.800006), 0, 0, player, 400, 400);
            desertmap9.SetMaterial(0, 3411, "ce_railbridge", "rusta256128", 0xFFFFFFFF);
            desertmap9.SetMaterial(1, 3411, "ce_railbridge", "rusta256128", 0);

            CreateDynamicObject(1308, 393.742004, 1526.119995, 11.742197, 81.194503, -34.699699, -105.525642, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1308, 487.109008, 1498.530029, -0.007811, 45.800006, -84.600021, -85.700050, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3362, 373.178161, 1393.341186, 7.254005, 2.399998, 2.699999, -162.400039, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3286, 505.580535, 1382.355102, 8.366163, 0.000000, 0.000000, -20.299999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(16404, 476.913818, 1396.748657, 5.619925, 0.000000, 0.000000, 38.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3302, 476.932586, 1395.020019, 4.306402, -1.399999, 4.699998, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3269, 457.268157, 1475.627441, 3.112584, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(761, 465.704803, 1346.708007, 5.135488, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(761, 477.785858, 1389.245361, 4.144128, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(11428, 503.436553, 1293.785278, 12.296769, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(11443, 457.178894, 1282.446044, 8.821325, 0.000000, 0.000000, -34.800003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3363, 375.331420, 1259.164916, 8.880457, 0.000000, 0.000000, -31.100009, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3255, 249.301651, 1455.889038, 9.784585, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3168, -27.695299, 1362.550048, 9.455930, 0.000000, 90.000000, -44.000034, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1442, -19.844680, 1344.755126, 8.701877, 0.000000, 0.000000, 145.399948, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1369, 3.754863, 1382.024414, 8.758140, 0.000000, 0.000000, -26.800003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1777, 3.431957, 1376.170898, 8.931881, 0.000000, 0.000000, 14.899998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1777, 7.791020, 1377.443969, 8.931881, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1439, 5.279202, 1376.881347, 8.041876, 0.000000, 0.000000, 17.899999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2675, 1.276994, 1347.910888, 8.241875, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1438, -16.491668, 1345.473144, 8.121872, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1219, 10.307456, 1364.904052, 8.421875, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(850, -15.486042, 1385.439575, 8.281876, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1357, 371.714233, 1397.661254, 7.791555, 0.000000, -7.499995, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, 384.545410, 1474.390625, 7.643068, 3.299997, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, 441.117095, 1452.246704, 6.305123, -7.599997, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, 442.997375, 1426.494628, 8.561143, -0.099997, 0.000000, 22.299997, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(850, 420.280670, 1370.455932, 8.099605, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3005, 410.363067, 1398.616699, 6.594668, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2677, 360.995300, 1357.166137, 8.305356, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(926, 484.324371, 1434.380737, 3.201688, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3415, 526.396667, 1513.410644, 0.011268, 0.000000, 0.000000, -29.499998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1440, 524.785461, 1515.309448, 0.491181, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(935, 373.205780, 1264.027954, 9.635957, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(933, 58.933502, 896.037353, 23.185987, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 114.819091, 893.598876, 21.476631, 4.899999, 0.000000, 56.400005, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 469.688323, 1167.703369, 7.783469, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, 762.048034, 1670.222778, 4.568400, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1686, 619.257751, 1687.508911, 6.239717, 0.000000, 88.400024, -19.999992, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 612.545288, 1684.041870, 6.751945, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 598.988952, 1689.022338, 6.751945, 0.000000, 0.000000, 159.999923, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(639, 604.824768, 1695.924926, 10.247774, 0.000000, 0.000000, 35.200038, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(639, 612.918273, 1684.452026, 10.237772, 0.000000, 0.000000, 35.200038, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 589.358093, 1654.887573, 6.504026, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(923, 664.269775, 1719.920043, 6.891415, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 658.185363, 1720.472656, 5.929955, 0.000000, 0.000000, -70.199996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 650.639526, 1711.082885, 5.989957, 0.000000, 0.000000, -70.199996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 616.225341, 1701.722534, 6.141949, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3631, 665.153503, 1729.569702, 6.502182, 0.000000, 0.000000, 40.200050, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(922, 651.390136, 1702.465820, 6.812434, 0.000000, 0.000000, -50.600017, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3568, 659.906616, 1744.376953, 7.484329, 0.000000, -5.199998, -46.699989, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 514.039855, 1642.403564, 12.185607, 1.700000, 6.799999, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3568, 670.313720, 2120.014404, 19.382354, 6.899997, 0.000000, 16.500000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 659.046142, 2159.533691, 20.263256, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 654.526550, 2303.201904, 26.185104, 0.000000, 0.000000, 88.600013, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 643.843994, 2321.466796, 26.105100, 0.000000, 0.000000, 8.100013, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 672.624145, 2244.103027, 24.656793, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 669.173950, 2216.941406, 23.606769, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, 631.646850, 2441.551025, 29.866426, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 692.667541, 2381.249267, 30.396766, 0.000000, 0.000000, 38.500007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 723.888977, 2352.367431, 29.339817, 1.799999, 0.000000, 74.900009, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 781.154602, 1877.894287, 3.918008, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 782.022460, 1865.260131, 3.918008, 0.000000, 0.000000, -132.099975, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, 783.452758, 1886.956298, 4.237665, 0.000000, 0.000000, 94.999961, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(17036, 691.556213, 1878.996093, 4.412759, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3005, 690.363098, 1878.214599, 4.636251, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1345, 692.983764, 1873.610595, 5.289717, 0.000000, 0.000000, -34.299995, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1441, 688.842834, 1877.089355, 5.208086, 0.000000, 0.000000, -90.500000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2671, 683.754516, 1878.754516, 4.595469, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1341, 672.733520, 1847.742675, 5.289037, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1503, 667.964721, 1828.788696, 4.468609, 0.000000, 0.000000, -44.299987, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1365, 679.612365, 1831.093017, 5.330032, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1327, 687.548400, 1829.780029, 4.232501, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1327, 684.278625, 1830.388671, 4.172501, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 907.069824, 996.187500, 10.244998, 2.599998, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 734.898315, 675.732604, 10.024632, 0.000000, 0.000000, 72.800003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 706.204650, 661.255126, 9.214616, 0.000000, 0.000000, 84.200004, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 624.051147, 666.641845, 4.688413, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 820.776733, 678.072448, 10.718742, 0.000000, 0.000000, -67.599975, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 735.780578, 682.493041, 10.323740, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 454.896575, 744.758666, 4.548620, -1.700000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 389.596771, 750.429748, 5.449484, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 547.973754, 673.455322, 2.770852, 0.000000, 0.000000, 63.100009, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3006, 972.833374, 749.008300, 9.250349, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 921.929077, 834.967834, 12.564718, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 901.299682, 834.967834, 12.564718, 0.000000, 0.000000, 104.299987, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, 924.117980, 863.466674, 12.564718, 0.000000, 0.000000, 104.299987, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1358, 915.943603, 703.846374, 11.005185, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(5820, 869.777160, 689.031250, 15.654373, 0.000000, 0.000000, 20.699987, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 867.587402, 708.719970, 10.923612, 0.000000, 0.000000, 27.100004, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 867.587402, 708.719970, 11.753619, 0.000000, 0.000000, 27.100004, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 867.587402, 708.719970, 12.573627, 0.000000, 0.000000, -148.499984, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 867.662597, 708.747802, 13.413633, 0.000000, 0.000000, 20.300006, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(8674, 865.182434, 706.663513, 19.099760, 90.000000, 21.099992, 92.099967, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1653, 862.093383, 718.185729, 19.480133, 0.000000, 0.000000, 112.200057, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1653, 866.936706, 706.316772, 19.490133, 0.000000, 0.000000, 112.200057, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1653, 870.563354, 697.428100, 19.490133, 0.000000, 0.000000, 112.200057, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19868, 862.259338, 725.129699, 10.409906, 0.000000, 0.000000, -160.100036, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19868, 867.213989, 726.923278, 10.409906, 0.000000, 0.000000, -160.100036, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19868, 872.132019, 728.703125, 10.409906, 0.000000, 0.000000, -160.100036, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19868, 875.425842, 692.722229, 10.509915, 0.000000, 0.000000, 22.699974, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19868, 880.259704, 694.744262, 10.509915, 0.000000, 0.000000, 22.699974, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19868, 884.557128, 696.397521, 10.509915, 90.000000, 11.300000, 22.699974, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19868, 889.799011, 698.734985, 10.509915, 0.000000, 0.000000, 22.699974, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, 881.653381, 727.696105, 10.243724, 0.000000, 0.000000, 134.799972, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 907.742248, 720.493347, 10.239484, 0.000000, 0.000000, -57.700000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 899.933959, 708.778991, 10.239484, 0.000000, 0.000000, -70.199981, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 916.483825, 719.666748, 10.239484, 0.000000, 0.000000, -70.199981, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 911.160156, 734.457153, 10.239484, 0.000000, 0.000000, -70.199981, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2985, 863.063903, 714.388977, 19.146083, 0.000000, 0.000000, 23.499996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2985, 860.176879, 721.220092, 19.146083, 0.000000, 0.000000, 16.299993, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2985, 871.325256, 694.213500, 19.146083, 0.000000, 0.000000, 16.299993, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1431, 869.929016, 697.154907, 19.702589, 0.000000, 0.000000, -57.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, 315.066619, 744.787109, 5.588166, -1.700000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(18246, 260.963500, 664.892822, 9.728713, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1440, 146.208267, 728.026733, 5.736051, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3568, -70.863983, 609.118957, 14.688859, 1.299998, 0.000000, 113.700012, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(18451, 154.991378, 674.866271, 4.979410, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(849, 26.998012, 641.395629, 6.633580, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(734, 6.183293, 677.680358, 16.785005, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(733, 26.291809, 559.694641, 6.951018, 0.000000, 0.000000, 58.700008, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(735, 113.062545, 611.978576, 6.188460, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(734, -118.246788, 677.680358, 17.144996, 0.000000, 0.000000, 67.999984, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(735, -317.983276, 619.614318, 15.287687, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(842, 79.093879, 604.829345, 7.258879, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(12957, 48.199275, 594.341918, 7.582580, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1358, -148.990631, 561.165588, 5.321825, -4.600002, 5.999999, 43.500007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1448, -254.374572, 548.744873, 15.208495, 0.000000, 0.000000, 55.300006, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -166.433441, 584.729919, 15.214676, 0.000000, 0.000000, -39.799995, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2669, -558.673583, 623.163330, 17.145370, 2.200000, -0.699999, 180.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3567, -566.802551, 635.695251, 16.495702, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3577, -557.584960, 630.735534, 16.392576, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2991, -566.938537, 640.619445, 17.966636, 0.000000, 0.000000, 102.899993, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -753.284118, 701.262145, 17.635208, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -753.284118, 714.932006, 17.085195, 0.000000, 0.000000, 23.100002, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -782.193725, 715.026977, 17.665208, 0.000000, 0.000000, 50.500003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -791.952514, 741.863281, 16.555210, 0.000000, 0.000000, 50.500003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -833.360107, 750.413879, 18.355251, 0.000000, 0.000000, 50.500003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1427, -763.829284, 696.809448, 17.963359, 0.000000, 0.000000, 47.600002, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(11700, -754.374755, 692.554870, 17.002614, -6.899994, 1.899993, -150.600006, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1503, -739.939514, 739.969482, 17.628355, 0.000000, 0.000000, -144.500045, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13590, -732.297607, 692.504150, 17.821598, -1.999999, 0.000000, -108.899986, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19321, -743.670227, 696.748046, 18.471761, 1.899999, 0.000000, 71.000015, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -631.517883, 649.005798, 16.206735, 0.000000, 0.000000, 67.800018, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -657.218261, 654.709777, 16.206735, 0.000000, 0.000000, 67.800018, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(735, -461.812927, 719.993957, 15.367696, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(735, -744.032836, 724.694091, 15.367696, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3276, -725.434814, 823.181335, 15.516329, 92.004676, 86.866523, -90.047180, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -699.130859, 955.592285, 11.821956, 0.000000, 0.000000, -24.599998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(11665, -684.237976, 935.687194, 11.986396, 0.000000, 90.999977, 179.500152, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(933, -847.218200, 933.274536, 25.080919, 0.000000, 34.199954, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3363, -780.032714, 858.961242, 11.518370, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(734, -1026.333862, 1147.798583, 26.506662, 0.000000, 0.000000, -74.400024, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(734, -1498.573730, 2021.785034, 44.834438, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(735, -1490.620361, 2140.994873, 44.491897, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(735, -1546.214843, 2385.827636, 43.241973, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(639, -1466.786132, 1858.549926, 36.341056, 0.000000, 0.000000, 93.899940, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(639, -1474.646118, 1858.014892, 36.341056, 0.000000, 0.000000, 93.899940, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1451.704589, 1855.870239, 32.588237, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -929.938903, 1201.379516, 32.753643, 1.800000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -840.570800, 960.349914, 24.442392, 0.000000, 0.000000, -1.699999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -1356.497070, 2068.498046, 51.851585, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(17036, -1359.431030, 2048.812255, 51.300338, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2675, -1528.241699, 1724.202880, 1.633899, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3788, -1472.909423, 1713.839965, 1.977715, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(853, -1364.934082, 1712.998901, 4.546792, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1219, -1402.383422, 1703.267944, 3.193987, 0.000000, 0.000000, 28.700000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2671, -1533.115478, 1767.313964, 16.062416, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2671, -1632.753784, 1813.915527, 11.451675, 4.500001, 3.799998, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -1619.970458, 1867.122802, 16.103429, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -1737.449340, 2172.163574, 16.712419, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -1754.030639, 2172.163574, 16.282409, 0.000000, 0.000000, 87.600021, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(639, -1942.829223, 2384.340332, 51.478233, 0.000000, 0.000000, -158.900070, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(639, -1939.831054, 2376.574218, 51.478233, 0.000000, 0.000000, -158.900070, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1932.799194, 2378.476318, 49.794643, 0.000000, 0.000000, 2.299997, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(817, -1941.212524, 2374.963378, 53.695400, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(817, -1947.952636, 2383.532226, 53.695400, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(635, -1941.428466, 2380.039306, 52.258247, 0.000000, -90.999992, -158.699905, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3364, -1762.225952, 2217.608398, 1.981304, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1457, -1731.689941, 2210.461914, 3.667166, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2803, -1503.766357, 1971.917724, 47.760368, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2589, -1509.736694, 1977.289916, 52.802219, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2589, -1509.736694, 1975.199951, 52.802219, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2589, -1509.736694, 1972.789794, 52.802219, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1412, -1507.275756, 1980.129150, 48.608993, 8.800002, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2803, -1503.766357, 1973.365844, 47.760368, 0.000000, 0.000000, -109.800010, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2805, -1505.016967, 1972.730712, 51.913242, 0.000000, 0.000000, 93.799995, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(12957, -1512.839721, 1967.458251, 48.098461, 0.000000, 0.000000, 67.599998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1554, -1502.419067, 1960.492065, 47.997936, 0.000000, 0.000000, -31.599992, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(841, -1506.603881, 1961.084228, 47.551902, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(734, -1524.193969, 1958.154418, 46.934459, 0.000000, 0.000000, 108.400054, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3425, -1501.687133, 1953.186645, 56.960880, -0.300000, 65.200019, 0.099999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -1617.509155, 1836.410766, 25.303440, 0.000000, 0.000000, -42.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -1560.817260, 1897.835571, 24.943563, -3.499998, 0.000000, 25.400007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -1487.743286, 1865.754882, 31.949438, -1.699998, 0.000000, 25.400007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1442, -1206.059936, 1839.180664, 41.221858, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(960, -1209.573730, 1834.466796, 41.278312, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1345, -1209.786010, 1841.818969, 41.466888, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(851, -1208.705810, 1829.751464, 40.942874, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1219, -1206.588256, 1821.849731, 40.941776, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2676, -1196.352294, 1824.283569, 40.833827, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2676, -1196.352294, 1847.974365, 40.403877, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2677, -1234.718994, 1897.768066, 41.275882, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2671, -1277.541137, 1933.700439, 43.027091, 4.699999, -0.699999, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(850, -1332.694702, 1984.478881, 50.760429, 5.499999, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1441, -1355.593017, 2157.656005, 47.576721, 0.000000, 0.000000, 113.100067, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2673, -1353.825073, 2183.042480, 48.348354, 2.099999, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2673, -1353.593627, 2057.259521, 52.199047, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1448, -1353.288330, 2059.464111, 52.193813, 0.000000, 0.000000, 8.099999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1328, -1353.774169, 2055.005126, 52.380828, -87.199966, 0.000000, -150.100143, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(924, -1346.900024, 2069.061279, 51.003368, -6.899996, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1370, -1336.027221, 2057.836425, 52.167022, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(926, -1347.348510, 2179.871582, 48.238769, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1349, -1216.634643, 1809.263549, 41.096626, 0.000000, -0.499999, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2672, -1215.677124, 1816.014282, 41.009941, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1439, -1245.555419, 1814.676391, 39.961238, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(11700, -1128.020263, 1795.849121, 40.634540, -7.599997, -4.899998, -71.200004, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1219, -1066.922485, 1840.823120, 49.822914, 8.600000, -10.400000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -1051.053100, 1731.135009, 30.794977, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3035, -1089.991088, 1741.013549, 32.089241, 0.000000, 2.299997, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1440, -1133.996582, 1649.839355, 23.975997, 0.000000, -2.799999, -51.599994, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(18101, -1148.174316, 1647.496093, 23.161222, -4.399998, 0.000000, 32.099998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -1129.926147, 1585.937622, 20.524875, -0.899999, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2610, -1122.906860, 1563.110473, 20.907238, 270.000000, -94.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3244, -999.875671, 1736.196655, 57.940460, 139.999832, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -1053.682006, 1662.391601, 25.194959, 0.000000, 0.000000, 20.700000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1431, -889.238769, 1253.058593, 34.323223, 0.000000, -2.899998, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3568, -1264.446289, 1720.681152, 18.315757, 0.000000, 0.000000, 75.000007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2059, -1123.914306, 1463.293945, 24.151966, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1369, -1098.322875, 1455.254272, 27.189975, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1094.782226, 1485.051025, 26.425668, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1124.387695, 1523.077880, 21.501329, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1124.387695, 1545.298339, 21.041318, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1137.357788, 1578.147338, 21.041318, 0.000000, 0.000000, -99.500007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1197.776611, 1691.018432, 19.221363, 0.000000, 0.000000, -99.500007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1270.424194, 1725.066040, 17.191356, 0.000000, 0.000000, -99.500007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1272.836303, 1754.882934, 18.111370, 0.000000, 0.000000, -99.500007, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1305.874145, 1774.998168, 22.451408, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1346.656250, 1787.689331, 30.111421, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1406.400634, 1850.547607, 35.641433, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1375.501586, 1851.882324, 35.641433, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1422.270141, 1801.899536, 36.401424, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1395.533447, 1801.154663, 36.401424, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1388.525756, 1793.035888, 35.491451, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1450.767456, 1705.779907, 2.011451, 0.000000, 0.000000, -125.499977, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1440, -1044.593750, 1253.622924, 39.517211, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, -1058.377197, 1216.373413, 38.218162, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -1031.606811, 1275.321533, 39.507366, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(734, -1012.715759, 1333.835937, 32.405792, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -991.070007, 1191.602539, 30.815193, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(873, -976.830810, 1247.696044, 32.520298, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(873, -976.830810, 1266.345581, 32.740318, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -999.269836, 1251.604370, 33.242012, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(12957, -298.270355, 1756.987060, 42.389724, 0.000000, 0.000000, -10.100000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3005, -309.081024, 1763.908447, 42.656490, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3035, -311.974395, 1770.120239, 43.396080, 0.000000, 0.000000, 18.399999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1358, -316.968017, 1761.542358, 42.967048, 0.000000, 0.000000, -30.100000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -294.876098, 1768.608520, 41.985546, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -313.422882, 1751.012695, 42.255550, 0.000000, 0.000000, -118.599990, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -297.139739, 1739.351806, 41.995536, 0.000000, 0.000000, 163.699981, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(849, -320.787322, 1742.726684, 42.284091, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -639.023315, 2055.140136, 60.516471, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -698.111206, 2066.715087, 60.046501, 0.000000, 0.000000, 65.999984, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -754.584106, 2055.529296, 60.046501, 0.000000, 0.000000, 65.999984, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -776.723266, 2059.179931, 60.046501, 0.000000, 0.000000, 65.999984, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -783.023620, 2045.027709, 60.046501, 0.000000, 0.000000, 65.999984, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -809.857727, 2034.766723, 60.046501, 0.000000, 0.000000, 65.999984, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -829.464355, 2034.098754, 60.046501, 0.000000, 0.000000, 115.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -876.889709, 1988.333129, 60.046501, 0.000000, 0.000000, 115.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -885.282226, 1977.823486, 60.046501, 0.000000, 0.000000, 115.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -901.654846, 1995.701049, 60.046501, 0.000000, 0.000000, 115.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -906.312316, 2005.379028, 60.046501, 0.000000, 0.000000, 115.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -918.501220, 2021.619384, 60.046501, 0.000000, 0.000000, 115.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -918.501220, 2021.619384, 60.046501, 0.000000, 0.000000, 115.699996, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -746.793884, 2065.439941, 59.654354, 0.000000, 0.000000, 85.299987, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -586.676147, 2030.583374, 59.937099, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1440, -782.801757, 2036.047607, 59.871299, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, -851.655212, 1860.286376, 59.244865, 0.000000, 0.000000, -75.699989, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -862.578430, 1878.402709, 59.617893, 0.000000, 0.000000, 15.899998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -867.225219, 1894.715332, 59.617893, 0.000000, 0.000000, 15.899998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -864.825439, 1908.039916, 59.617893, 0.000000, 0.000000, -162.500030, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -869.725891, 1931.397338, 59.647888, 0.000000, 0.000000, -162.500030, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -898.363037, 2003.167602, 60.357860, 0.000000, 0.000000, -162.500030, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -911.925109, 1998.891601, 60.357860, 0.000000, 0.000000, -162.500030, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -888.199218, 1996.609008, 60.181320, 5.099998, 0.000000, 62.099914, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -419.478088, 1765.626342, 71.805068, -5.299997, 0.000000, 48.099983, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(16134, -436.710327, 1589.360961, 32.503807, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(16111, -405.852783, 1785.473999, 52.174983, 0.000000, 0.000000, -144.900161, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13637, -464.253326, 1630.744628, 38.124958, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(16367, -424.264343, 1664.944213, 37.336795, -5.099997, 0.000000, -120.799964, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3577, -420.106903, 1666.788574, 36.351367, 5.199999, 0.000000, -27.700004, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(18451, -407.148651, 2030.217163, 65.939994, -11.099999, 0.000000, -49.299987, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -475.222595, 2010.850341, 59.562000, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, -399.180908, 2083.830810, 60.971164, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(13591, -519.378784, 2593.670410, 52.732765, 0.000000, 0.000000, 50.500003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -225.867172, 2708.090087, 61.526321, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -215.596130, 2705.935058, 61.226333, 0.000000, 0.000000, 47.599998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -254.741409, 2698.599121, 61.864841, 0.000000, 0.000000, 40.300003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3593, -222.240875, 2736.209472, 62.072368, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1458, -204.172470, 2662.518554, 61.941490, 0.000000, 0.000000, -42.799999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1438, -230.112258, 2710.090820, 61.960124, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1440, -223.228881, 2709.568603, 62.417755, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1219, -229.797531, 2711.404541, 63.377880, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1219, -224.877532, 2711.404541, 63.377880, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(850, -161.973648, 2640.907714, 62.746292, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(19589, -216.652252, 2597.858154, 61.678272, 0.000000, 0.000000, -38.400001, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2677, -218.036010, 2606.217773, 61.989593, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1441, -257.730285, 2605.860351, 62.458087, 0.000000, 0.000000, 175.599975, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2671, -238.038482, 2700.227783, 61.550739, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2676, -184.351501, 2655.505126, 61.942615, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1299, -194.978118, 2664.708984, 62.181770, 0.000000, 0.000000, 17.299999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(850, -231.107696, 2668.029052, 61.729804, 0.000000, 0.000000, 19.399999, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1227, -308.204925, 2626.478271, 63.220672, 0.000000, 0.000000, -31.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1219, -311.692504, 2641.602294, 62.650882, 0.000000, 0.000000, 37.699993, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(2676, -285.459747, 2635.697998, 61.986862, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -261.092803, 2631.161865, 61.872936, 0.000000, 0.000000, 63.300003, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3567, -124.683158, 2632.642578, 63.643646, 0.000000, 0.000000, -85.100006, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1438, -131.847702, 2632.087646, 64.455375, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1440, -125.656509, 2633.380615, 65.011581, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1421, -134.438522, 2632.079589, 63.610843, 0.000000, 0.000000, 89.399993, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1346, -219.774932, 2641.251464, 62.498687, 90.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1291, -174.232467, 2644.476074, 62.847900, 90.000000, 0.000000, -25.700008, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1223, -192.742004, 2688.800048, 61.799377, 90.000000, 0.000000, 0.000027, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3447, -239.551437, 2650.306152, 62.671901, -83.300109, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(3594, -570.209777, 2742.334228, 61.527336, 5.700000, -3.499999, -132.199951, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1415, -730.156372, 2747.618164, 46.317817, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1358, -743.230590, 2747.607421, 47.289958, 0.000000, 0.000000, 15.799997, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1370, -735.360107, 2745.004638, 49.660545, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(1438, -742.469421, 2745.224121, 46.139476, 5.499998, 0.000000, 14.400001, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1886.417480, 2380.595214, 47.187149, 5.599997, 0.000000, 2.299997, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1885.958618, 2326.796630, 39.985389, 5.599997, 0.000000, 2.299997, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(874, -1845.917602, 2304.672363, 31.059724, 15.099999, 0.000000, 2.299997, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(835, -443.914550, 684.988525, 22.617303, 0.000000, -5.399999, 22.800001, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(847, -427.810119, 624.715820, 17.424163, 0.000000, 0.000000, -44.599998, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(935, -171.152526, 566.607238, 15.371288, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(864, -217.270538, 566.930541, 15.104313, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(864, -196.330581, 570.240722, 15.104313, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(864, -146.106399, 576.371582, 15.104313, 0.000000, 0.000000, -54.499980, object_world, object_int, -1, 400.00, 400.00);
            CreateDynamicObject(918, -115.487709, 591.094421, 1.920445, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 400.00, 400.00);


            //SKLADSF DOWN

            CreateDynamicObject(19948, -421.082367, -639.692932, 10.465971, 0.000000, 0.000000, 136.099991, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(19949, -424.915405, -627.717590, 10.045531, 0.000000, 0.000000, 61.400002, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3594, -458.288757, -625.163086, 15.298603, 1.200000, 5.799997, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(874, -472.690613, -616.523071, 15.854409, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(2900, -480.003693, -612.582153, 16.244745, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(874, -480.320618, -602.332764, 15.854409, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(3593, -483.153870, -603.781982, 16.798517, 0.000000, 1.600000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1414, -491.092987, -593.502808, 17.347881, 101.000168, 7.899997, -2.800000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2926, -492.863861, -583.138916, 19.530846, 12.099980, 5.400003, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(985, -485.586639, -562.724731, 26.218502, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(985, -494.939331, -559.641846, 26.216978, 0.000000, 0.000000, -129.399826, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(2674, -492.677399, -550.594360, 24.543415, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1462, -507.409698, -562.202698, 24.513441, 0.000000, 0.000000, 180.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(16644, -491.237244, -541.885986, 32.368595, 0.000000, 1.300000, -44.199978, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(2676, -504.062469, -553.272156, 24.643417, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(874, -487.272858, -533.006226, 24.273411, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(3504, -500.872406, -541.630310, 25.023426, 89.699997, 0.000000, 33.799995, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1219, -473.625458, -511.048157, 24.736790, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(874, -476.092773, -511.475952, 24.443415, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(8073, -494.826447, -520.720093, 28.497845, 0.000000, 0.000000, 179.899948, -1, -1, -1, STREAMER_OBJECT_SD, 450.0); // 0
            CreateDynamicObject(1449, -515.981812, -539.127625, 25.013426, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2949, -516.726868, -538.899841, 24.493437, 0.000000, 0.000000, 89.800041, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1426, -520.425293, -539.677002, 24.639326, -0.400001, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1440, -520.404846, -539.449219, 25.003426, -3.299999, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3569, -529.489258, -548.062378, 26.893415, 0.000000, 0.000000, -178.299988, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1460, -525.305847, -538.959290, 24.752728, -0.499998, 89.000000, -1.100016, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2949, -526.097168, -538.895020, 24.493437, 0.000000, 0.000000, 89.700027, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1414, -515.680237, -527.116089, 34.982769, 97.700020, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1503, -489.781647, -502.544434, 24.857830, 0.000000, 0.000000, 70.599998, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1460, -534.255798, -543.457336, 24.594431, 90.700058, 61.099945, -6.100017, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3594, -470.084290, -487.837067, 25.047850, 0.000000, 0.000000, 1.299998, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1460, -536.391968, -540.445313, 24.628248, 90.700058, -161.600006, -6.100017, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(12957, -480.413208, -487.734802, 25.267847, 0.000000, 0.000000, -3.099998, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3761, -509.153717, -505.389191, 26.507868, 0.000000, 0.000000, 82.199982, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(2949, -540.678589, -538.896118, 24.493437, 0.000000, 0.000000, 89.900040, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(18665, -542.573853, -538.906921, 25.913433, 0.000000, 0.000000, 90.199936, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2949, -515.465027, -506.803772, 24.483437, 0.000000, 0.000000, -89.599968, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1460, -516.189819, -506.786865, 24.752285, 0.000000, 90.499985, 180.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1412, -519.111877, -507.070740, 26.885265, 0.000000, 89.900002, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1458, -513.952087, -501.185242, 24.743422, 0.000000, 0.000000, 52.999996, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1412, -521.591797, -507.070740, 26.880936, 0.000000, 89.900002, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(18664, -523.738342, -506.766174, 26.523438, 0.000000, 0.000000, -90.000023, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2949, -524.795044, -506.810699, 24.523438, 0.000000, 0.000000, -90.599953, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3633, -523.729675, -505.737396, 24.983425, 0.000000, 0.000000, 34.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1460, -525.520081, -506.696777, 24.670847, 0.000000, 90.499985, 180.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(874, -497.472717, -484.256073, 24.073406, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(3593, -474.263519, -472.117096, 25.027832, 0.000000, 0.000000, -0.499998, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(2949, -554.039185, -538.912964, 24.493437, 0.000000, 0.000000, 89.900040, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1441, -535.424744, -514.193054, 35.071178, -7.299995, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3566, -494.650635, -477.575562, 26.907846, 0.000000, 0.000000, 177.299866, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0

            // fso_map = CreateDynamicObject(19366, -534.896973, -506.598175, 24.453409, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);

            var skladsf1 = new DynamicObject(19366, new Vector3(-534.896973, -506.598175, 24.453409), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            skladsf1.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);

            CreateDynamicObject(923, -563.867004, -544.403992, 25.313433, 0.000000, 0.000000, -38.699997, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
           // fso_map = CreateDynamicObject(19366, -536.646606, -506.598175, 24.463409, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 1
          //  SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);

            var skladsf2 = new DynamicObject(19366, new Vector3(-536.646606, -506.598175, 24.463409), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            skladsf2.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);

            CreateDynamicObject(1412, -537.022217, -507.070740, 26.854013, 0.000000, 89.900002, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1412, -537.022217, -507.070740, 26.854013, 0.000000, 89.900002, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1412, -534.327698, -503.784912, 24.577211, -90.200012, 87.700005, -7.500000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2949, -539.295532, -506.789398, 24.523438, 0.000000, 0.000000, -90.599953, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3569, -504.925659, -477.733643, 26.913439, 0.000000, 0.000000, 177.800034, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(5261, -565.241333, -540.372253, 26.743460, 0.000000, 0.000000, -0.099977, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3593, -499.542755, -471.885895, 25.027832, 0.000000, 0.000000, -1.799999, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0

            //fso_map = CreateDynamicObject(19360, -546.713623, -506.844513, 25.925764, 10.300000, 0.000000, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 1
            //SetDynamicObjectMaterialText(fso_map, 0, "WHITE POWER", 140, "Mistral", 50, 1, 0xFF3B090A, 0, 1);

            var skladsf3 = new DynamicObject(19360, new Vector3(-546.713623, -506.844513, 25.925764), new Vector3(10.300000, 0.000000, 90.000000), 0, 0, player, 300, 300);
            skladsf3.SetMaterialText(0, "WHITE POWER", ObjectMaterialSize.X512X512, "Mistral", 50, true, 0xFF3B090A,0,ObjectMaterialTextAlign.Center);


            CreateDynamicObject(19087, -546.660034, -505.029205, 30.671337, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2949, -572.590454, -538.910767, 24.493437, 0.000000, 0.000000, 89.900040, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(8613, -547.162598, -502.688965, 28.863449, 0.000000, 0.000000, 179.700027, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1460, -551.001282, -506.370361, 24.726685, -8.399997, 98.999985, -179.999985, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2678, -524.984680, -481.146240, 24.547848, 270.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2949, -552.517578, -506.761627, 24.523438, 0.000000, 0.000000, -89.599968, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3594, -535.037781, -487.110382, 25.047850, 0.000000, 0.000000, 1.299998, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3796, -549.443176, -499.505066, 24.513395, 0.000000, 0.000000, -111.900009, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1412, -556.816589, -507.057892, 26.646076, 1.300001, 80.399956, -1.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2669, -525.074707, -475.462677, 25.777851, 0.000000, 0.000000, 27.900000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1412, -558.404663, -506.821045, 26.956169, 4.499999, 84.300003, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(3630, -565.649292, -504.678711, 25.893454, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(12957, -546.977478, -479.486725, 25.047844, 0.000000, 0.000000, 67.300011, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1460, -574.492371, -507.026947, 26.953569, 0.000000, 90.499985, 180.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1412, -574.971558, -507.070740, 26.787771, 0.000000, 89.900002, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1460, -576.092834, -507.026947, 26.939594, 0.000000, 90.499985, 180.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1412, -577.401306, -507.070740, 26.783525, 0.000000, 89.900002, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(1460, -577.713318, -507.026947, 26.925438, 0.000000, 90.499985, 180.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(2932, -592.494446, -525.162292, 25.953407, 0.000000, 90.000000, -18.300003, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
          //  fso_map = CreateDynamicObject(19366, -591.477173, -521.478210, 24.443415, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 1
         //   SetDynamicObjectMaterial(fso_map, 0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);
            var skladsf4 = new DynamicObject(19366, new Vector3(-591.477173, -521.478210, 24.443415), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            skladsf4.SetMaterial(0, 14613, "ab_abattoir_box", "ab_bloodfloor", 0);


            CreateDynamicObject(3593, -569.882996, -487.663177, 25.027832, 0.000000, 0.000000, -0.499998, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(3593, -588.185120, -475.172821, 25.027832, 0.000000, 0.000000, 54.399994, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(12943, -607.703674, -495.604492, 24.473413, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(931, -571.986511, -505.941895, 25.493437, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(2673, -480.934692, -523.563538, 24.607824, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(935, -564.022949, -545.348572, 25.083427, 0.000000, 0.000000, 160.199966, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(935, -564.788757, -544.804565, 25.083427, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2907, -546.642822, -505.002838, 27.728329, -97.499969, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(2906, -546.446777, -504.819000, 28.172901, 29.800001, -95.600037, -6.200000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(2060, -548.358765, -479.482758, 24.957832, 0.000000, 0.000000, -21.199999, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0

            //BOLOTO
            // fso_map = CreateDynamicObject(19439, -804.839172, -1978.503052, 5.525670, 0.000000, 82.200058, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 16322, "a51_stores", "des_ghotwood1", 0);
            // fso_map = CreateDynamicObject(12937, -806.308228, -1968.413940, 8.133056, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 2
            // SetDynamicObjectMaterial(fso_map, 11, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);
            // SetDynamicObjectMaterial(fso_map, 10, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);
            var boloto1 = new DynamicObject(19439, new Vector3(-804.839172, -1978.503052, 5.525670), new Vector3(0.000000, 82.200058, 90.000000), 0, 0, player, 300, 300);
            boloto1.SetMaterial(0, 16322, "a51_stores", "des_ghotwood1", 0);
            var boloto2 = new DynamicObject(12937, new Vector3(-806.308228, -1968.413940, 8.133056), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            boloto2.SetMaterial(10, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);
            boloto2.SetMaterial(11, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);

            //fso_map = CreateDynamicObject(19379, -801.439758, -1992.357422, 0.384436, 0.000000, 180.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 19400, "all_walls", "cj_lightwood", 0);
            var boloto3 = new DynamicObject(19379, new Vector3(-801.439758, -1992.357422, 0.384436), new Vector3(0.000000, 180.000000, 0.000000), 0, 0, player, 300, 300);
            boloto3.SetMaterial(0, 19400, "all_walls", "cj_lightwood", 0);



            // fso_map = CreateDynamicObject(19379, -796.269775, -1987.598145, 0.804437, 90.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            // SetDynamicObjectMaterial(fso_map, 0, 19400, "all_walls", "cj_lightwood", 0);
            var boloto4 = new DynamicObject(19379, new Vector3(-796.269775, -1987.598145, 0.804437), new Vector3(90.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            boloto4.SetMaterial(0, 19400, "all_walls", "cj_lightwood", 0);

            //fso_map = CreateDynamicObject(19379, -796.269775, -1992.357422, 5.384437, 0.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 10426, "backroad_sfs", "Bow_church_dirt", 0);
            var boloto5 = new DynamicObject(19379, new Vector3(-796.269775, -1992.357422, 5.384437), new Vector3(0.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            boloto5.SetMaterial(0, 10426, "backroad_sfs", "Bow_church_dirt", 0);

            //fso_map = CreateDynamicObject(3634, -796.188049, -1957.470581, 7.590407, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 2
            // SetDynamicObjectMaterial(fso_map, 1, 3374, "ce_farmxref", "sw_barnwood4", 0);
            //SetDynamicObjectMaterial(fso_map, 0, 17067, "cw2_logcabins", "sw_cabinroof", 0);
            var boloto6 = new DynamicObject(3634, new Vector3(-796.188049, -1957.470581, 7.590407), new Vector3(0.000000, 0.000000, 0.000000), 0, 0, player, 300, 300);
            
            boloto6.SetMaterial(0, 17067, "cw2_logcabins", "sw_cabinroof", 0xFFFFFFFF);
            boloto6.SetMaterial(1, 3374, "ce_farmxref", "sw_barnwood4", 0);

            //fso_map = CreateDynamicObject(12937, -789.467041, -1978.124390, 8.103055, 0.000000, 0.000000, -90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 2
            // SetDynamicObjectMaterial(fso_map, 11, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);
            // SetDynamicObjectMaterial(fso_map, 10, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);
            var boloto7 = new DynamicObject(12937, new Vector3(-789.467041, -1978.124390, 8.103055), new Vector3(0.000000, 0.000000, -90.000000), 0, 0, player, 300, 300);
            boloto7.SetMaterial(10, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);
            boloto7.SetMaterial(11, 5150, "wiresetc_las2", "ganggraf01_LA_m", 0);

            //fso_map = CreateDynamicObject(19379, -796.269775, -1997.177002, 0.804437, 90.000000, 90.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //SetDynamicObjectMaterial(fso_map, 0, 19400, "all_walls", "cj_lightwood", 0);
            var boloto8 = new DynamicObject(19379, new Vector3(-796.269775, -1997.177002, 0.804437), new Vector3(90.000000, 90.000000, 0.000000), 0, 0, player, 300, 300);
            boloto8.SetMaterial(0, 19400, "all_walls", "cj_lightwood", 0);

            // fso_map = CreateDynamicObject(19379, -791.108154, -1992.357422, 0.384436, 0.000000, 180.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 1
            //  SetDynamicObjectMaterial(fso_map, 0, 19400, "all_walls", "cj_lightwood", 0);
            var boloto9 = new DynamicObject(19379, new Vector3(-791.108154, -1992.357422, 0.384436), new Vector3(0.000000, 180.000000, 0.000000), 0, 0, player, 300, 300);
            boloto9.SetMaterial(0, 19400, "all_walls", "cj_lightwood", 0);

            CreateDynamicObject(16502, -818.490784, -1975.603394, 2.920518, 0.000000, 7.099996, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(3927, -822.367676, -1973.407837, 7.183251, -12.600002, 0.000000, -60.100029, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(16405, -816.086853, -1983.385376, 3.802466, 0.000000, 14.500003, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1440, -810.401611, -1972.600464, 6.440498, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(16502, -806.317505, -1975.633423, 2.905994, 0.000000, 7.099996, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(635, -806.979370, -1980.791870, 7.262991, 0.000000, -90.000000, -90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(3362, -804.616333, -1983.248657, 4.789602, 0.000000, 0.000000, 90.900002, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(635, -802.548767, -1980.841919, 7.312993, 0.000000, -90.000000, -90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(924, -800.202087, -1979.083252, 5.488179, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 80.0); // 0
            CreateDynamicObject(1448, -799.945007, -1972.739502, 5.279150, 0.000000, 0.000000, 49.500008, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(2959, -799.444763, -1979.374512, 5.310121, -0.599997, -90.100029, 22.100027, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(16444, -800.065613, -1968.552979, 0.157686, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 250.0); // 0
            CreateDynamicObject(17000, -807.236084, -1993.510254, -1.795461, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 400.0); // 0
            CreateDynamicObject(1437, -798.048401, -1983.211426, 5.703088, -27.000013, 0.000000, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(1449, -800.493347, -1962.482544, 5.901021, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(16502, -796.906250, -1967.631226, 2.854538, 0.000000, 7.099996, 270.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16502, -796.896240, -1983.680420, 2.850383, 0.000000, 7.099996, 90.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1355, -797.822144, -1985.974121, 5.710425, 5.899998, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 60.0); // 0
            CreateDynamicObject(933, -795.780396, -1980.462524, 5.495638, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(960, -793.780396, -1973.976074, 6.365221, 0.000000, 0.000000, 36.599995, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(1217, -794.812622, -1962.996460, 5.783700, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 100.0); // 0
            CreateDynamicObject(3409, -798.828613, -1994.302002, 5.220364, 0.000000, 0.000000, 0.000000, -1, -1, -1, STREAMER_OBJECT_SD, 300.0); // 0
            CreateDynamicObject(16502, -791.596863, -1981.274902, 2.989575, 0.000000, 7.099996, 360.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(16502, -791.596863, -1966.343750, 2.989575, 0.000000, 7.099996, 360.000000, -1, -1, -1, STREAMER_OBJECT_SD, 350.0); // 0
            CreateDynamicObject(1452, -793.203064, -1989.056763, 6.430372, 0.000000, 0.000000, -76.299988, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1451, -795.866394, -1995.631714, 6.190373, 0.000000, 0.000000, -179.000153, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1451, -794.135498, -1995.541504, 6.190373, 0.000000, 0.000000, -174.200104, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0
            CreateDynamicObject(1451, -792.657715, -1995.257202, 6.190373, 0.000000, 0.000000, -154.599930, -1, -1, -1, STREAMER_OBJECT_SD, 200.0); // 0

        }

        public void Remove()
        {
            BasePlayer playerid = player;
             void RemoveBuildingForPlayer(BasePlayer p, int objectid, double x, double y, double z, double pos)
            {
                GlobalObject.Remove(p, objectid, new Vector3(x,y,z), (float)pos);
            }
            //PUSTINA REMOVES DOWN
            RemoveBuildingForPlayer(playerid, 16270, 573.687, 1419.260, 19.695, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 578.507, 1424.619, 10.531, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 578.507, 1424.619, 10.531, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 534.687, 1471.109, 3.804, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 534.687, 1471.109, 3.804, 0.250);
            RemoveBuildingForPlayer(playerid, 3427, 487.101, 1528.229, 0.125, 0.250);
            RemoveBuildingForPlayer(playerid, 16277, 487.101, 1528.229, 0.125, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 433.968, 1565.969, 10.984, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 433.968, 1565.969, 10.984, 0.250);
            RemoveBuildingForPlayer(playerid, 3427, 422.914, 1513.410, 10.718, 0.250);
            RemoveBuildingForPlayer(playerid, 16273, 422.914, 1513.410, 10.718, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 419.445, 1411.880, 6.765, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 419.445, 1411.880, 6.765, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 405.593, 1463.839, 6.390, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 405.593, 1463.839, 6.390, 0.250);
            RemoveBuildingForPlayer(playerid, 3427, 435.054, 1269.689, 8.695, 0.250);
            RemoveBuildingForPlayer(playerid, 16274, 435.054, 1269.689, 8.695, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 491.023, 1306.910, 8.265, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 491.023, 1306.910, 8.265, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 563.015, 1308.989, 9.468, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 563.015, 1308.989, 9.468, 0.250);
            RemoveBuildingForPlayer(playerid, 3427, 588.164, 1340.959, 9.859, 0.250);
            RemoveBuildingForPlayer(playerid, 16276, 588.164, 1340.959, 9.859, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 628.148, 1354.410, 11.382, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 628.148, 1354.410, 11.382, 0.250);
            RemoveBuildingForPlayer(playerid, 3427, 648.937, 1471.380, 8.367, 0.250);
            RemoveBuildingForPlayer(playerid, 16279, 648.937, 1471.380, 8.367, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 600.843, 1500.150, 7.257, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 600.843, 1500.150, 7.257, 0.250);
            RemoveBuildingForPlayer(playerid, 3426, 353.703, 1302.040, 11.562, 0.250);
            RemoveBuildingForPlayer(playerid, 3428, 353.703, 1302.040, 11.562, 0.250);
            RemoveBuildingForPlayer(playerid, 3427, 375.039, 1335.050, 10.218, 0.250);
            RemoveBuildingForPlayer(playerid, 16275, 375.039, 1335.050, 10.218, 0.250);
            RemoveBuildingForPlayer(playerid, 3427, 500.195, 1389.800, 3.570, 0.250);
            RemoveBuildingForPlayer(playerid, 16278, 500.195, 1389.800, 3.570, 0.250);
            RemoveBuildingForPlayer(playerid, 16269, 448.070, 1413.790, 17.968, 0.250);
            RemoveBuildingForPlayer(playerid, 16268, 464.234, 1311.729, 20.742, 0.250);
            RemoveBuildingForPlayer(playerid, 16744, 351.984, 1368.900, 20.109, 0.250);
            RemoveBuildingForPlayer(playerid, 16745, 392.914, 1511.560, 21.585, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 550.000, 1354.270, 9.335, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 545.601, 1314.699, 9.242, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 557.914, 1393.420, 12.109, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 546.484, 1454.989, 4.515, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 594.859, 1406.170, 10.218, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 620.804, 1374.510, 10.890, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 611.132, 1439.160, 8.710, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 411.460, 1305.020, 11.210, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 449.726, 1306.770, 9.468, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 456.320, 1348.119, 5.851, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 531.125, 1208.920, 8.914, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 475.234, 1286.979, 8.500, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 514.375, 1292.699, 8.695, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 476.992, 1386.380, 4.242, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 349.000, 1353.599, 7.789, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 353.015, 1373.430, 6.914, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 354.320, 1392.839, 5.742, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 361.390, 1413.439, 5.851, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 376.531, 1425.229, 6.531, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 376.593, 1441.910, 6.617, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 374.789, 1460.030, 6.734, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 390.789, 1335.369, 10.054, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 379.914, 1477.099, 7.593, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 396.507, 1480.500, 7.625, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 423.773, 1392.540, 6.679, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 453.679, 1419.369, 4.554, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 464.234, 1462.030, 4.242, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 384.265, 1494.130, 8.507, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 439.609, 1493.699, 8.789, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 374.960, 1299.739, 11.546, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 393.742, 1526.119, 11.742, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 398.359, 1545.079, 13.773, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 388.492, 1510.390, 10.164, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 581.226, 1467.300, 5.585, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 588.265, 1501.170, 7.062, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 627.843, 1473.459, 7.726, 0.250);
            RemoveBuildingForPlayer(playerid, 1308, 487.109, 1498.530, -0.007, 0.250);
            RemoveBuildingForPlayer(playerid, 3673, 247.929, 1461.859, 33.414, 0.250);
            RemoveBuildingForPlayer(playerid, 3682, 247.929, 1461.859, 33.414, 0.250);
            RemoveBuildingForPlayer(playerid, 3674, 247.554, 1471.089, 35.898, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 254.679, 1464.630, 22.468, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 255.531, 1472.979, 19.757, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 252.125, 1473.890, 16.296, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 252.813, 1473.829, 11.406, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 253.820, 1456.130, 16.296, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 253.820, 1458.109, 10.117, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 255.531, 1454.550, 19.148, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 253.820, 1458.109, 23.781, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 254.679, 1468.209, 18.296, 0.250);
            RemoveBuildingForPlayer(playerid, 3675, 254.679, 1451.829, 27.492, 0.250);
            RemoveBuildingForPlayer(playerid, 3258, 222.507, 1444.699, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3289, 222.507, 1444.699, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3258, 212.078, 1426.030, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3289, 212.078, 1426.030, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 16778, -79.937, 1385.589, 9.000, 0.250);
            RemoveBuildingForPlayer(playerid, 3168, -27.695, 1362.550, 8.085, 0.250);
            RemoveBuildingForPlayer(playerid, 3343, -27.695, 1362.550, 8.085, 0.250);
            RemoveBuildingForPlayer(playerid, 1697, 37.179, 1380.979, 9.765, 0.250);
            RemoveBuildingForPlayer(playerid, 1697, 37.726, 1370.150, 9.765, 0.250);
            RemoveBuildingForPlayer(playerid, 1697, 37.992, 1358.880, 9.765, 0.250);
            RemoveBuildingForPlayer(playerid, 3256, 218.257, 1467.540, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3290, 218.257, 1467.540, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3256, 190.914, 1371.770, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3290, 190.914, 1371.770, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3258, 183.742, 1444.869, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3289, 183.742, 1444.869, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3258, 207.539, 1371.239, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3289, 207.539, 1371.239, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3258, 221.179, 1390.300, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 3289, 221.179, 1390.300, 9.585, 0.250);
            RemoveBuildingForPlayer(playerid, 773, 91.953, 910.484, 14.546, 0.250);
            RemoveBuildingForPlayer(playerid, 1686, 603.484, 1707.229, 6.179, 0.250);
            RemoveBuildingForPlayer(playerid, 1686, 606.898, 1702.219, 6.179, 0.250);
            RemoveBuildingForPlayer(playerid, 1686, 620.531, 1682.459, 6.179, 0.250);
            RemoveBuildingForPlayer(playerid, 1686, 624.046, 1677.599, 6.179, 0.250);
            RemoveBuildingForPlayer(playerid, 1686, 617.125, 1687.449, 6.179, 0.250);
            RemoveBuildingForPlayer(playerid, 3276, -722.101, 822.710, 16.273, 0.250);
            RemoveBuildingForPlayer(playerid, 3276, -735.109, 835.453, 15.718, 0.250);
            RemoveBuildingForPlayer(playerid, 3276, -735.890, 823.843, 16.273, 0.250);
            RemoveBuildingForPlayer(playerid, 3276, -736.671, 812.234, 16.828, 0.250);
            RemoveBuildingForPlayer(playerid, 11665, -685.171, 935.695, 13.320, 0.250);
            RemoveBuildingForPlayer(playerid, 11631, -691.593, 942.718, 13.875, 0.250);
            RemoveBuildingForPlayer(playerid, 1686, -1477.660, 1859.729, 31.820, 0.250);
            RemoveBuildingForPlayer(playerid, 1686, -1465.479, 1868.270, 31.820, 0.250);
            RemoveBuildingForPlayer(playerid, 3425, -1513.560, 1953.160, 58.507, 0.250);
            RemoveBuildingForPlayer(playerid, 3336, -1056.030, 1198.050, 37.906, 0.250);
            RemoveBuildingForPlayer(playerid, 16776, -237.022, 2662.840, 62.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -192.742, 2688.800, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -251.546, 2647.370, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -192.742, 2648.800, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -270.312, 2695.699, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -293.929, 2695.699, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -251.546, 2688.870, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -245.007, 2706.709, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -229.046, 2695.699, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -211.593, 2695.699, 61.609, 0.250);
            RemoveBuildingForPlayer(playerid, 1223, -198.852, 2706.709, 61.609, 0.250);

            //PUSTINA REMOVES UP
            // RemoveBuildingForPlayer(playerid, 1686, -1327.030, 2685.590, 49.453, 0.250);
            GlobalObject.Remove(player, 1686, new Vector3(-1327.030, 2685.590, 49.453), 0.25f);

            // RemoveBuildingForPlayer(playerid, 1686, -1328.589, 2674.709, 49.453, 0.250);
            GlobalObject.Remove(player, 1686, new Vector3(-1328.589, 2674.709, 49.453), 0.25f);

            // RemoveBuildingForPlayer(playerid, 11677, -1303.369, 2664.080, 53.578, 0.250);
            GlobalObject.Remove(player, 11677, new Vector3(-1303.369, 2664.080, 53.578), 0.25f);

            //  RemoveBuildingForPlayer(playerid, 11453, -1414.510, 2650.479, 57.562, 0.250);
            GlobalObject.Remove(player, 11453, new Vector3(-1414.510, 2650.479, 57.562), 0.25f);

            //  RemoveBuildingForPlayer(playerid, 956, -1455.119, 2591.659, 55.234, 0.250);
            GlobalObject.Remove(player, 956, new Vector3(-1455.119, 2591.659, 55.234), 0.25f);

            //  RemoveBuildingForPlayer(playerid, 1294, -1520.890, 2597.040, 59.273, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-1520.890, 2597.040, 59.273), 0.25f);

            //  RemoveBuildingForPlayer(playerid, 1294, -1483.949, 2597.040, 59.273, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-1483.949, 2597.040, 59.273), 0.25f);

            //   RemoveBuildingForPlayer(playerid, 3278, -1479.699, 2611.399, 59.617, 0.250);
            GlobalObject.Remove(player, 3278, new Vector3(-1483.650, 2611.399, 59.617), 30.25f);

            //  RemoveBuildingForPlayer(playerid, 3278, -1483.650, 2611.399, 59.617, 0.250);
            //  RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2613.590, 59.617, 0.250);
            //   RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2617.629, 59.617, 0.250);
            //   RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2621.629, 59.617, 0.250);
            //  RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2625.610, 59.617, 0.250);
            //  RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2629.469, 59.617, 0.250);
            //   RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2633.330, 59.617, 0.250);
            //   RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2637.179, 59.617, 0.250);
            //  RemoveBuildingForPlayer(playerid, 3278, -1485.719, 2641.040, 59.617, 0.250);
            //   RemoveBuildingForPlayer(playerid, 3337, -1337.150, 2632.399, 50.898, 0.250);

            //   RemoveBuildingForPlayer(playerid, 1294, -1491.729, 2573.840, 59.273, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-1491.729, 2573.840, 59.273), 0.25f);

            //   RemoveBuildingForPlayer(playerid, 1294, -1500.119, 2612.860, 59.273, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-1500.119, 2612.860, 59.273), 0.25f);

            //   RemoveBuildingForPlayer(playerid, 1294, -1491.729, 2628.459, 59.273, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-1491.729, 2628.459, 59.273), 0.25f);

            //   RemoveBuildingForPlayer(playerid, 11543, -1461.160, 2627.679, 62.351, 0.250);
            //   RemoveBuildingForPlayer(playerid, 11673, -1461.160, 2627.679, 62.351, 0.250);
            //   RemoveBuildingForPlayer(playerid, 1294, -1500.119, 2628.449, 59.273, 0.250);
            GlobalObject.Remove(player, 1294, new Vector3(-1500.119, 2628.449, 59.273), 0.25f);

            //   RemoveBuildingForPlayer(playerid, 11544, -1483.280, 2642.379, 56.695, 0.250);
            GlobalObject.Remove(player, 11544, new Vector3(-1483.280, 2642.379, 56.695), 0.25f);

            //SVERHU QEBRADOS REMOVES
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
            //LAS VENTURAS REMOVES
            GlobalObject.Remove(player, 1251, new Vector3(997.046, 1710.949, 11.265), 0.25f);
            GlobalObject.Remove(player, 1251, new Vector3(998.093, 1755.689, 11.265), 0.25f);
            GlobalObject.Remove(player, 1250, new Vector3(997.726, 1759.130, 10.851), 10f);
            GlobalObject.Remove(player, 652, new Vector3(987.203, 1763.589, 7.867), 1000f);
            GlobalObject.Remove(player, 645, new Vector3(993.796, 1723.500, 9.492), 300f);
            GlobalObject.Remove(player, 1350, new Vector3(1001.909, 1963.770, 9.812), 3000f);
            GlobalObject.Remove(player, 3460, new Vector3(903.000, 1993.010, 13.765), 0.25f);

            GlobalObject.Remove(player, 3460, new Vector3(911.789, 2022.869, 13.765), 0.25f);
            GlobalObject.Remove(player, 3460, new Vector3(903.000, 2055.199, 13.765), 0.25f);
            GlobalObject.Remove(player, 7492, new Vector3(1028.160, 2240.770, 13.398), 1f);
            GlobalObject.Remove(player, 7670, new Vector3(1028.160, 2240.770, 13.398), 1f);
            GlobalObject.Remove(player, 7657, new Vector3(1047.390, 2063.689, 11.539), 1f);
            //
            GlobalObject.Remove(player, 1257, new Vector3(1073.380, 2062.080, 11.093), 0.25f);
            GlobalObject.Remove(player, 3460, new Vector3(1439.939, 2708.949, 13.765), 0.25f);
            //645
            GlobalObject.Remove(player, 645, new Vector3(1423.939, 2695.699, 9.585), 0.25f);
            GlobalObject.Remove(player, 645, new Vector3(1437.619, 2695.699, 9.820), 0.25f);
            GlobalObject.Remove(player, 645, new Vector3(1451.300, 2695.699, 9.226), 0.25f);
            //1350

            GlobalObject.Remove(player, 1350, new Vector3(1912.969, 2732.020, 9.812), 0.25f);
            GlobalObject.Remove(player, 1350, new Vector3(1917.280, 2747.540, 9.812), 0.25f);
            GlobalObject.Remove(player, 1350, new Vector3(1902.040, 2752.229, 9.812), 0.25f);
            //3460
            GlobalObject.Remove(player, 3460, new Vector3(1949.170, 2746.550, 13.765), 0.25f);
            GlobalObject.Remove(player, 1478, new Vector3(1933.310, 2732.239, 10.445), 0.25f);
            //1350
            GlobalObject.Remove(player, 1350, new Vector3(2033.800, 2649.840, 9.812), 0.25f);
            GlobalObject.Remove(player, 1350, new Vector3(2076.840, 2736.379, 9.812), 0.25f);

            GlobalObject.Remove(player, 1350, new Vector3(2092.870, 2731.600, 9.812), 0.25f);
            GlobalObject.Remove(player, 1350, new Vector3(2082.060, 2752.709, 9.812), 0.25f);

            GlobalObject.Remove(player, 7391, new Vector3(2143.379, 2761.969, 14.828), 0.25f);

            GlobalObject.Remove(player, 3465, new Vector3(2141.669, 2753.320, 11.273), 0.25f);
            
            GlobalObject.Remove(player, 7269, new Vector3(2140.419, 2535.250, 12.734), 0.25f);
            GlobalObject.Remove(player, 7270, new Vector3(2140.419, 2535.250, 12.734), 0.25f);
            GlobalObject.Remove(player, 3520, new Vector3(2074.040, 2464.159, 9.820), 100f);
            GlobalObject.Remove(player, 7228, new Vector3(2093.649, 2488.800, 9.820), 0.25f);
            GlobalObject.Remove(player, 7147, new Vector3(2093.649, 2488.800, 9.820), 0.25f);
            GlobalObject.Remove(player, 1300, new Vector3(2096.000, 2485.979, 10.445), 51f);
            GlobalObject.Remove(player, 6868, new Vector3(2093.649, 2488.800, 9.820), 0.25f);
            GlobalObject.Remove(player, 7147, new Vector3(2093.649, 2488.800, 9.820), 0.25f);

            GlobalObject.Remove(player, 1532, new Vector3(2248.429, 2395.770, 9.804), 0.25f);
            GlobalObject.Remove(player, 6946, new Vector3(2263.129, 2391.550, 9.820), 0.25f);
            GlobalObject.Remove(player, 7118, new Vector3(2263.129, 2391.550, 9.820), 0.25f);
            GlobalObject.Remove(player, 647, new Vector3(2240.949, 2401.679, 11.539), 100f);

            GlobalObject.Remove(player, 7916, new Vector3(2087.959, 1901.550, 13.468), 0.25f);

            GlobalObject.Remove(player, 3516, new Vector3(2119.840, 2032.449, 12.992), 1500f);

            GlobalObject.Remove(player, 3463, new Vector3(2057.449, 1354.479, 10.164), 0.25f);
            GlobalObject.Remove(player, 9192, new Vector3(2136.159, 944.132, 15.054), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2114.909, 914.718, 11.257), 0.25f);
            GlobalObject.Remove(player, 3460, new Vector3(1459.859, 1868.819, 13.765), 0.25f);

            GlobalObject.Remove(player, 1309, new Vector3(1187.569, 1743.449, 18.226), 0.25f);
            GlobalObject.Remove(player, 1325, new Vector3(1187.569, 1743.449, 18.226), 0.25f);
            GlobalObject.Remove(player, 8322, new Vector3(1187.650, 1743.109, 29.390), 0.25f);
            GlobalObject.Remove(player, 1309, new Vector3(1195.089, 1463.949, 19.007), 0.25f);

            GlobalObject.Remove(player, 1325, new Vector3(1187.569, 1743.449, 18.226), 0.25f);
            GlobalObject.Remove(player, 8323, new Vector3(1195.260, 1463.949, 30.171), 0.25f);
            GlobalObject.Remove(player, 627, new Vector3(1923.839, 703.132, 11.929), 0.25f);
            GlobalObject.Remove(player, 1344, new Vector3(1884.839, 722.703, 10.625), 0.25f);
            GlobalObject.Remove(player, 625, new Vector3(1879.050, 698.914, 10.710), 0.25f);
            GlobalObject.Remove(player, 625, new Vector3(1879.050, 710.335, 10.710), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2634.639, 1111.750, 11.250), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2645.250, 1111.750, 11.250), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2639.879, 1100.959, 11.250), 0.25f);
            GlobalObject.Remove(player, 9190, new Vector3(2707.320, 1501.449, 27.210), 0.25f);
            GlobalObject.Remove(player, 1259, new Vector3(2705.649, 1501.550, 21.210), 0.25f);
            GlobalObject.Remove(player, 1268, new Vector3(2705.649, 1501.550, 21.210), 0.25f);
            GlobalObject.Remove(player, 1290, new Vector3(2717.770, 1681.859, 12.046), 0.25f);
            GlobalObject.Remove(player, 6874, new Vector3(2384.620, 2376.840, 9.820), 0.25f);
            GlobalObject.Remove(player, 7149, new Vector3(2384.620, 2376.840, 9.820), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2207.699, 2470.250, 11.312), 0.25f);
            GlobalObject.Remove(player, 6909, new Vector3(2205.629, 2474.969, 14.648), 0.25f);
            GlobalObject.Remove(player, 7154, new Vector3(2205.629, 2474.969, 14.648), 0.25f);
            GlobalObject.Remove(player, 7311, new Vector3(2163.209, 2473.050, 12.070), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2196.899, 2480.330, 11.312), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2196.899, 2470.250, 11.312), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2196.899, 2474.689, 11.312), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2207.699, 2480.330, 11.312), 0.25f);
            GlobalObject.Remove(player, 3465, new Vector3(2207.699, 2474.689, 11.312), 0.25f);
            GlobalObject.Remove(player, 3520, new Vector3(2216.709, 2495.110, 9.820), 50f);
            GlobalObject.Remove(player, 7390, new Vector3(2214.909, 2465.689, 14.828), 0.25f);



        }

    }
}
