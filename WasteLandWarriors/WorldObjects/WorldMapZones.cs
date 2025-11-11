using SampSharp.GameMode.World;
using SampSharp.Streamer.World;
using SampSharpGameMode1.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.WorldObjects
{
    internal class WorldMapZones
    {
        static GangZone gz1;
        static GangZone gz2;
        static GangZone gz3;
        static GangZone gz4;
        public static GangZone forestNearLBK1;
        public static GangZone forestNearLBK2;
        public static GangZone forestNearLBK3;
        public static GangZone forestNearLBK4;
        public static GangZone forestNearLBK5;
        public static GangZone forestNearLBK6;
        public static GangZone forestNearLBK7;
        public static GangZone forestNearLBK8;
        public static GangZone forestNearLBK9;
        public static GangZone forestNearLBK10;
        public static GangZone forestNearLBK11;
        public static GangZone forestNearLBK12;
        public static GangZone forestNearLBK13;
        public static GangZone forestNearLBK14;
        public static GangZone forestNearLBK15;
        public static GangZone forestNearLBK16;
        public static GangZone forestNearLBK17;
        public static GangZone forestNearLBK18;
        public static GangZone forestNearLBK19;
        public static GangZone forestNearLBK20;

        public static GangZone deadForest1;
        public static GangZone deadForest2;

        public static GangZone mineZone;


        public static void Create(Player pl)
        {
             gz1 = new GangZone(87.0f, 1789.5f, 303f, 1943.5f);
            gz1.Color = new SampSharp.GameMode.SAMP.Color(0x7FFF00FF);
            gz1.Show(pl);

             gz2 = new GangZone(-459f, 2195.5f, -334f, 2273.5f);
            gz2.Color = new SampSharp.GameMode.SAMP.Color(0x7FFF00FF);
            gz2.Show(pl);
             gz3 = new GangZone(549f, 88.5f, 615f, 149.5f);
            gz3.Color = new SampSharp.GameMode.SAMP.Color(0x7FFF00FF);
            gz3.Show(pl);
             gz4 = new GangZone(549f, 88.5f, 615f, 149.5f);
            gz4.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);

            forestNearLBK1 = new GangZone(782.484375f, 225.015625f, 1105.484375f, 325.015625f);
            forestNearLBK1.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            gz4.Show(pl);

            forestNearLBK2 = new GangZone(1253.96875f, 60.0234375f, 1430.96875f, 128.0234375f);
            forestNearLBK2.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            

            forestNearLBK3 = new GangZone(1261.953125f, 8.0390625f, 1385.953125f, 60.0390625f);
            forestNearLBK3.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK4 = new GangZone(1389.984375f, -135.984375f, 1544.984375f, -14.984375f);
            forestNearLBK4.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK5 = new GangZone(1289.9827880859375f, -166.96548461914062f, 1389.9827880859375f, -102.96548461914062f);
            forestNearLBK5.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK6 = new GangZone(1149.6528930664062f, -43.31964111328125f, 1238.6528930664062f, 17.68035888671875f);
            forestNearLBK6.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK7 = new GangZone(1072.6355590820312f, 495.7012939453125f, 1159.6355590820312f, 545.7012939453125f);
            forestNearLBK7.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK8 = new GangZone(1072.6216430664062f, 465.7117004394531f, 1260.6216430664062f, 495.7117004394531f);
            forestNearLBK8.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK9 = new GangZone(1160.6216430664062f, 402.7117004394531f, 1283.6216430664062f, 465.7117004394531f);
            forestNearLBK9.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK10 = new GangZone(974.4828491210938f, 325.01727294921875f, 1105.4828491210938f, 383.01727294921875f);
            forestNearLBK10.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK11 = new GangZone(824.3265991210938f, 362.0172424316406f, 875.3265991210938f, 417.0172424316406f);
            forestNearLBK11.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK12 = new GangZone(874.4793701171875f, 384.01727294921875f, 940.4793701171875f, 425.01727294921875f);
            forestNearLBK12.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK13 = new GangZone(940.4793701171875f, 404.2325439453125f, 971.4793701171875f, 464.2325439453125f);
            forestNearLBK13.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK14 = new GangZone(628.548828125f, 329.1214599609375f, 719.548828125f, 385.1214599609375f);
            forestNearLBK14.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK15 = new GangZone(1105.4828491210938f, 312.02423095703125f, 1183.4828491210938f, 366.02423095703125f);
            forestNearLBK15.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);
            
            forestNearLBK16 = new GangZone(576.5418090820312f, 231.1214599609375f, 695.5418090820312f, 278.1214599609375f);
            forestNearLBK16.Color = new SampSharp.GameMode.SAMP.Color(0x00FF7FFF);

            deadForest1 = new GangZone(-1637.62841796875f, 2125.673583984375f, -1438.62841796875f, 2351.673583984375f);

            deadForest2 = new GangZone(-1601.617919921875f, 1999.6839904785156f, -1395.617919921875f, 2125.6839904785156f);

            //{ "Zone 18", 534.6044921875, 936.3505554199219, 706.6044921875, 1001.3505554199219, 0xFF0000FF },

            mineZone = new GangZone(534.6044921875f, 936.3505554199219f, 706.6044921875f, 1001.3505554199219f);


            //{ "Zone 17", -1637.62841796875, 2125.673583984375, -1438.62841796875, 2351.673583984375, 0xFF0000FF },
            //{ "Zone 18", -1601.617919921875, 1999.6839904785156, -1395.617919921875, 2125.6839904785156, 0xFF0000FF },

            /**
             * { "Zone 24", 1253.96875, 60.0234375, 1430.96875, 128.0234375, 0xFF0000FF },
{ "Zone 25", 1261.953125, 8.0390625, 1385.953125, 60.0390625, 0xFF0000FF },
{ "Zone 27", 1389.984375, -135.984375, 1544.984375, -14.984375, 0xFF0000FF },
{ "Zone 29", 1289.9827880859375, -166.96548461914062, 1389.9827880859375, -102.96548461914062, 0xFF0000FF },
{ "Zone 30", 1149.6528930664062, -43.31964111328125, 1238.6528930664062, 17.68035888671875, 0xFF0000FF },
{ "Zone 31", 1072.6355590820312, 495.7012939453125, 1159.6355590820312, 545.7012939453125, 0xFF0000FF },
{ "Zone 32", 1072.6216430664062, 465.7117004394531, 1260.6216430664062, 495.7117004394531, 0xFF0000FF },
{ "Zone 33", 1160.6216430664062, 402.7117004394531, 1283.6216430664062, 465.7117004394531, 0xFF0000FF },
{ "Zone 34", 974.4828491210938, 325.01727294921875, 1105.4828491210938, 383.01727294921875, 0xFF0000FF },
{ "Zone 35", 824.3265991210938, 362.0172424316406, 875.3265991210938, 417.0172424316406, 0xFF0000FF },
{ "Zone 36", 874.4793701171875, 384.01727294921875, 940.4793701171875, 425.01727294921875, 0xFF0000FF },
{ "Zone 37", 940.4793701171875, 404.2325439453125, 971.4793701171875, 464.2325439453125, 0xFF0000FF },
{ "Zone 38", 628.548828125, 329.1214599609375, 719.548828125, 385.1214599609375, 0xFF0000FF },
{ "Zone 39", 1105.4828491210938, 312.02423095703125, 1183.4828491210938, 366.02423095703125, 0xFF0000FF },
{ "Zone 40", 576.5418090820312, 231.1214599609375, 695.5418090820312, 278.1214599609375, 0xFF0000FF },
            **/


            //{ "Zone 17", 782.484375, 225.015625, 1105.484375, 325.015625, 0x00FF00FF },
        }


    }
}
