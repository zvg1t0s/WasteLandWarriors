using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode;
using SampSharp.GameMode.World;
using SampSharp.GameMode.Definitions;

namespace WasteLandWarriors.WorldObjects
{
    internal class WorldMappingObjects
    {

        public static void Create()
        {

            GlobalObject ShopFloor = new GlobalObject(19379, new Vector3(1330.095947, 1358.404785, 3000.029541), new Vector3(00.000000, 90.000000, 0.000000), 25.0f);
            ShopFloor.SetMaterial(0, 18065, "ab_sfammumain", "gun_floor2", 0);
            //
            //METRO MAPP HERE MA BOYS 
            //CreateDynamicObject(1219, 809.394836, -1337.105347, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp1 = new GlobalObject(1219, new Vector3(809.394836, -1337.105347, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1219, 810.665222, -1337.105347, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp2 = new GlobalObject(1219, new Vector3(810.665222, -1337.105347, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);
            //CreateDynamicObject(19869, 811.019775, -1337.477295, 12.466875, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp3 = new GlobalObject(19869, new Vector3(811.019775, -1337.477295, 12.466875), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1219, 813.405884, -1337.105347, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp4 = new GlobalObject(1219, new Vector3(813.405884, -1337.105347, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1219, 808.114136, -1338.623901, 13.752862, 90.000000, 180.000000, 90.000000, -1, -1);
            GlobalObject vdnhp5 = new GlobalObject(1219, new Vector3(808.114136, -1338.623901, 13.752862), new Vector3(90.000000, 180.000000, 90.000000), 300.0f);
            // CreateDynamicObject(1219, 815.085693, -1337.052490, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp6 = new GlobalObject(1219, new Vector3(815.085693, -1337.052490, 13.752862), new Vector3(90.000000, 180.000000, 00.000000), 300.0f);
            //fso_map = CreateDynamicObject(19362, 811.086304, -1338.399170, 17.897688, 0.000000, 0.000000, 90.000000, -1, -1);
            //SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}Х", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp7 = new GlobalObject(19362, new Vector3(811.086304, -1338.399170, 17.897688), new Vector3(00.000000, 00.000000, 90.000000), 300.0f);
            vdnhp7.SetMaterialText(0, "{ff0000}X", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //CreateDynamicObject(1219, 808.765442, -1339.550903, 13.759748, 90.000000, 180.000000, -90.399940, -1, -1);
            GlobalObject vdnhp8 = new GlobalObject(1219, new Vector3(808.765442, -1339.550903, 13.759748), new Vector3(90.000000, 180.000000, -90.000000), 300.0f);
            //SetDynamicObjectMaterial(fso_map, 0, 18777, "TunnelSections", "stonewall4", 0);
            //fso_map = CreateDynamicObject(19455, 813.319458, -1338.412598, 17.719076, 0.000000, 0.000000, 90.000000, -1, -1);
            GlobalObject vdnhp9 = new GlobalObject(19455, new Vector3(813.319458, -1338.412598, 17.719076), new Vector3(0.00000f, 0.00000f, 90.0f), 300.0f);
            vdnhp9.SetMaterial(0, 18777, "TunnelSections", "stonewall4", 0);

            //fso_map = CreateDynamicObject(19362, 813.786194, -1338.399170, 17.897688, 0.000000, 0.000000, 90.000000, -1, -1);
            //SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}Н", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp10 = new GlobalObject(19362, new Vector3(813.786194, -1338.399170, 17.897688), new Vector3(00.000000, 00.000000, 90.000000), 300.0f);
            vdnhp10.SetMaterialText(0, "{ff0000}Н", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //CreateDynamicObject(19869, 808.369141, -1340.059448, 12.466879, 0.000000, 0.000000, 90.000000, -1, -1);
            GlobalObject vdnhp11 = new GlobalObject(19869, new Vector3(808.369141, -1340.059448, 12.466879), new Vector3(00.000000, 00.000000, 90.000000), 300.0f);
            //CreateDynamicObject(1219, 817.915649, -1337.092529, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp12 = new GlobalObject(1219, new Vector3(817.915649, -1337.092529, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1219, 817.565796, -1337.703125, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp13 = new GlobalObject(1219, new Vector3(817.565796, -1337.703125, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);
            //CreateDynamicObject(19869, 818.032471, -1337.477295, 12.466875, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp14 = new GlobalObject(19869, new Vector3(818.032471, -1337.477295, 12.466875), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //fso_map = CreateDynamicObject(19362, 816.536438, -1338.399170, 17.897688, 0.000000, 0.000000, 90.000000, -1, -1);
            //SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}Д", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp15 = new GlobalObject(19362, new Vector3(816.536438, -1338.399170, 17.897688), new Vector3(00.000000, 00.000000, 90.000000), 300.0f);
            vdnhp15.SetMaterialText(0, "{ff0000}Д", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //fso_map = CreateDynamicObject(19362, 808.585144, -1340.900269, 17.897688, 0.000000, 0.000000, 180.000000, -1, -1);
            //SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}В", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp16 = new GlobalObject(19362, new Vector3(808.585144, -1340.900269, 17.897688), new Vector3(00.000000, 00.000000, 180.000000), 300.0f);
            vdnhp16.SetMaterialText(0, "{ff0000}В", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //CreateDynamicObject(1219, 808.114136, -1341.364502, 13.752862, 90.000000, 180.000000, 90.000000, -1, -1);
            GlobalObject vdnhp17 = new GlobalObject(1219, new Vector3(808.114136, -1341.364502, 13.752862), new Vector3(90.000000, 180.000000, 90.000000), 300.0f);

            //CreateDynamicObject(19869, 819.791931, -1337.477295, 12.466875, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp18 = new GlobalObject(19869, new Vector3(819.791931, -1337.477295, 12.466875), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1219, 820.665466, -1337.092529, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp19 = new GlobalObject(1219, new Vector3(820.665466, -1337.092529, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1219, 808.746338, -1342.280518, 13.759748, 90.000000, 180.000000, -90.399940, -1, -1);
            GlobalObject vdnhp20 = new GlobalObject(1219, new Vector3(808.746338, -1342.280518, 13.759748), new Vector3(90.000000, 180.000000, -90.000000), 300.0f);

            //CreateDynamicObject(1219, 820.415649, -1337.703125, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp21 = new GlobalObject(1219, new Vector3(820.415649, -1337.703125, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);
            //fso_map = CreateDynamicObject(19362, 819.126282, -1338.399170, 17.897688, 0.000000, 0.000000, 90.000000, -1, -1);
            //SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}В", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp22 = new GlobalObject(19362, new Vector3(819.126282, -1338.399170, 17.897688), new Vector3(00.000000, 00.000000, 90.000000), 300.0f);
            vdnhp22.SetMaterialText(0, "{ff0000}В", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //fso_map = CreateDynamicObject(3092, 821.239746, -1337.375244, 17.547911, 0.000000, 0.000000, 0.000000, -1, -1);
            //SetDynamicObjectMaterial(fso_map, 1, 1243, "buoy", "buoyrust_128", 0);
            GlobalObject vdnhp23 = new GlobalObject(3092, new Vector3(821.239746, -1337.375244, 17.547911), new Vector3(0.00000f, 0.00000f, 00.0f), 300.0f);
            vdnhp23.SetMaterial(1, 1243, "lsv1", "lsv1", 0);
            //SetDynamicObjectMaterial(fso_map, 0, 3945, "alpha_fence", "bistro_alpha", 0);
            vdnhp23.SetMaterial(0, 3945, "alpha_fence", "bistro_alpha", 0);
            //fso_map = CreateDynamicObject(19362, 808.585144, -1343.201172, 17.897688, 0.000000, 0.000000, 180.000000, -1, -1);
            //SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}Д", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp24 = new GlobalObject(19362, new Vector3(808.585144, -1343.201172, 17.897688), new Vector3(00.000000, 00.000000, 180.000000), 300.0f);
            vdnhp24.SetMaterialText(0, "{ff0000}Д", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //fso_map = CreateDynamicObject(19455, 808.588989, -1343.263184, 17.719076, 0.000000, 0.000000, 180.000000, -1, -1);
            //SetDynamicObjectMaterial(fso_map, 0, 18777, "TunnelSections", "stonewall4", 0);
            GlobalObject vdnhp25 = new GlobalObject(19455, new Vector3(808.588989, -1343.263184, 17.719076), new Vector3(0.00000f, 0.00000f, 180.0f), 300.0f);
            vdnhp25.SetMaterial(0, 18777, "TunnelSections", "stonewall4", 0);
            // CreateDynamicObject(1362, 798.959534, -1332.036499, -0.927812, 0.000000, 0.000000, -35.200005, -1, -1);
            GlobalObject vdnhp26 = new GlobalObject(1362, new Vector3(798.959534, -1332.036499, -0.927812), new Vector3(0.000000, 0.000000, -35.200005), 300.0f);

            // CreateDynamicObject(19088, 821.234314, -1337.606323, 20.673393, 0.000000, 0.000000, 179.899979, -1, -1);
            GlobalObject vdnhp27 = new GlobalObject(19088, new Vector3(821.234314, -1337.606323, 20.673393), new Vector3(0.000000, 0.000000, 179.899979), 300.0f);

            // CreateDynamicObject(1219, 823.515808, -1337.092529, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp28 = new GlobalObject(1219, new Vector3(823.515808, -1337.092529, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);

            // CreateDynamicObject(1219, 808.114136, -1344.135010, 13.752862, 90.000000, 180.000000, 90.000000, -1, -1);
            GlobalObject vdnhp29 = new GlobalObject(1219, new Vector3(808.114136, -1344.135010, 13.752862), new Vector3(90.000000, 180.000000, 90.000000), 300.0f);

            // CreateDynamicObject(1219, 823.225464, -1337.703125, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp30 = new GlobalObject(1219, new Vector3(823.225464, -1337.703125, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);

            // CreateDynamicObject(18688, 798.828125, -1332.099976, -1.807812, 0.000000, 0.000000, -41.099995, -1, -1);
            GlobalObject vdnhp31 = new GlobalObject(1219, new Vector3(798.828125, -1332.099976, -1.807812), new Vector3(90.000000, 180.000000, -41.099995), 300.0f);
            //fso_map = CreateDynamicObject(19455, 822.919434, -1338.412598, 17.719076, 0.000000, 0.000000, 90.000000, -1, -1);
            //SetDynamicObjectMaterial(fso_map, 0, 18777, "TunnelSections", "stonewall4", 0);
            GlobalObject vdnhp32 = new GlobalObject(19455, new Vector3(822.919434, -1338.412598, 17.719076), new Vector3(0.00000f, 0.00000f, 90.0f), 300.0f);
            vdnhp32.SetMaterial(0, 18777, "TunnelSections", "stonewall4", 0);

            //CreateDynamicObject(1219, 808.727539, -1344.970215, 13.759748, 90.000000, 180.000000, -90.399940, -1, -1);
            GlobalObject vdnhp33 = new GlobalObject(1219, new Vector3(808.727539, -1344.970215, 13.759748), new Vector3(90.000000, 180.000000, -90.399940), 300.0f);
            //CreateDynamicObject(19869, 808.369141, -1345.239258, 12.466879, 0.000000, 0.000000, 90.000000, -1, -1);
            GlobalObject vdnhp34 = new GlobalObject(19869, new Vector3(808.369141, -1345.239258, 12.466879), new Vector3(0.000000, 0.000000, 90.000000), 300.0f);
            // CreateDynamicObject(19869, 824.963562, -1337.477051, 12.466875, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp35 = new GlobalObject(19869, new Vector3(824.963562, -1337.477051, 12.466875), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            // CreateDynamicObject(1362, 807.096313, -1339.546753, -0.937812, 0.000000, 0.000000, -43.300007, -1, -1);
            GlobalObject vdnhp36 = new GlobalObject(1362, new Vector3(807.096313, -1339.546753, -0.937812), new Vector3(0.000000, 0.000000, -43.300007), 300.0f);

            // CreateDynamicObject(1219, 826.285950, -1337.092529, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp37 = new GlobalObject(1219, new Vector3(826.285950, -1337.092529, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);

            // CreateDynamicObject(1219, 826.065735, -1337.703125, 13.752862, 90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject vdnhp38 = new GlobalObject(1219, new Vector3(826.065735, -1337.703125, 13.752862), new Vector3(90.000000, 180.000000, 0.000000), 300.0f);

            // CreateDynamicObject(18688, 806.948853, -1339.472534, -1.847811, 0.000000, 0.000000, -44.399998, -1, -1);
            GlobalObject vdnhp39 = new GlobalObject(1219, new Vector3(806.948853, -1339.472534, -1.847811), new Vector3(0.000000, 0.000000, -44.399998), 300.0f);
            //fso_map = CreateDynamicObject(19362, 808.585144, -1346.480835, 17.897688, 0.000000, 0.000000, 180.000000, -1, -1);
            //SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}Н", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp40 = new GlobalObject(19362, new Vector3(808.585144, -1346.480835, 17.897688), new Vector3(00.000000, 00.000000, 180.000000), 300.0f);
            vdnhp40.SetMaterialText(0, "{ff0000}Н", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //fso_map = CreateDynamicObject(19362, 808.585144, -1349.780396, 17.897688, 0.000000, 0.000000, 180.000000, -1, -1);
            // SetDynamicObjectMaterialText(fso_map, 0, "{ff0000}Х", 10, "Consolas", 0, 1, 0xFFFFFFFFFFFF0000, 0, 1);
            GlobalObject vdnhp41 = new GlobalObject(19362, new Vector3(808.585144, -1349.780396, 17.897688), new Vector3(00.000000, 00.000000, 180.000000), 300.0f);
            vdnhp41.SetMaterialText(0, "{ff0000}Х", ObjectMaterialSize.X32X32, "Consolas", 0, true, new SampSharp.GameMode.SAMP.Color(256f, 0f, 0f), 0, ObjectMaterialTextAlign.Center);
            //CreateDynamicObject(1219, 808.114136, -1346.885132, 13.752862, 90.000000, 180.000000, 90.000000, -1, -1);
            GlobalObject vdnhp42 = new GlobalObject(1219, new Vector3(808.114136, -1346.885132, 13.752862), new Vector3(90.000000, 180.000000, 90.000000), 300.0f);

            //CreateDynamicObject(1440, 785.643127, -1317.135986, 12.892807, 0.000000, 0.000000, 127.899963, -1, -1);
            GlobalObject vdnhp43 = new GlobalObject(1440, new Vector3(785.643127, -1317.135986, 12.892807), new Vector3(0.000000, 0.000000, 127.899963), 300.0f);

            //CreateDynamicObject(1219, 808.708923, -1347.661255, 13.759748, 90.000000, 180.000000, -90.399940, -1, -1);
            GlobalObject vdnhp44 = new GlobalObject(1219, new Vector3(808.708923, -1347.661255, 13.759748), new Vector3(90.000000, 180.000000, -90.399940), 300.0f);

            //CreateDynamicObject(1219, 808.114136, -1349.634888, 13.752862, 90.000000, 180.000000, 90.000000, -1, -1);
            GlobalObject vdnhp45 = new GlobalObject(1219, new Vector3(808.114136, -1349.634888, 13.752862), new Vector3(90.000000, 180.000000, 90.000000), 300.0f);
            //CreateDynamicObject(1219, 808.690186, -1350.351685, 13.759748, 90.000000, 180.000000, -90.399940, -1, -1);
            GlobalObject vdnhp46 = new GlobalObject(1219, new Vector3(808.690186, -1350.351685, 13.759748), new Vector3(90.000000, 180.000000, -90.399940), 300.0f);

            //CreateDynamicObject(19869, 808.369141, -1350.410645, 12.466879, 0.000000, 0.000000, 90.000000, -1, -1);
            GlobalObject vdnhp47 = new GlobalObject(19869, new Vector3(808.369141, -1350.410645, 12.466879), new Vector3(0.000000, 0.000000, 90.000000), 300.0f);
            //CreateDynamicObject(1219, 808.114136, -1352.374756, 13.752862, 90.000000, 180.000000, 90.000000, -1, -1);
            GlobalObject vdnhp48 = new GlobalObject(1219, new Vector3(808.114136, -1352.374756, 13.752862), new Vector3(90.000000, 180.000000, 90.000000), 300.0f);

            //CreateDynamicObject(2840, 825.163757, -1347.352783, 12.501474, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp49 = new GlobalObject(1219, new Vector3(825.163757, -1347.352783, 12.501474), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1219, 808.671387, -1353.041748, 13.759748, 90.000000, 180.000000, -90.399940, -1, -1);
            GlobalObject vdnhp50 = new GlobalObject(1219, new Vector3(808.671387, -1353.041748, 13.759748), new Vector3(90.000000, 180.000000, -90.399940), 300.0f);
            //fso_map = CreateDynamicObject(19455, 808.588989, -1352.893188, 17.719076, 0.000000, 0.000000, 180.000000, -1, -1);
            //SetDynamicObjectMaterial(fso_map, 0, 18777, "TunnelSections", "stonewall4", 0);
            GlobalObject vdnhp51 = new GlobalObject(19455, new Vector3(808.588989, -1352.893188, 17.719076), new Vector3(0.00000f, 0.00000f, 180.0f), 300.0f);
            vdnhp51.SetMaterial(0, 18777, "TunnelSections", "stonewall4", 0);
            //CreateDynamicObject(2671, 822.852112, -1349.351074, 12.537049, 0.000000, 0.000000, -28.500002, -1, -1);
            GlobalObject vdnhp52 = new GlobalObject(2671, new Vector3(822.852112, -1349.351074, 12.537049), new Vector3(0.000000, 0.000000, -28.500002), 300.0f);

            //CreateDynamicObject(1440, 817.400208, -1352.201172, 12.992450, 0.000000, 0.000000, -125.099976, -1, -1);
            GlobalObject vdnhp53 = new GlobalObject(1440, new Vector3(817.400208, -1352.201172, 12.992450), new Vector3(0.000000, 0.000000, -125.099976), 300.0f);

            // CreateDynamicObject(1362, 827.076843, -1347.560669, 13.126866, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp54 = new GlobalObject(1362, new Vector3(827.076843, -1347.560669, 13.126866), new Vector3(0.000000, 0.000000, 0.0), 300.0f);

            // CreateDynamicObject(1219, 808.114136, -1355.065308, 13.752862, 90.000000, 180.000000, 90.000000, -1, -1);
            GlobalObject vdnhp55 = new GlobalObject(1219, new Vector3(808.114136, -1355.065308, 13.752862), new Vector3(90.000000, 180.000000, 90.000000), 300.0f);

            // CreateDynamicObject(849, 821.047913, -1352.279541, 12.789195, 0.000000, 0.000000, -56.599995, -1, -1);
            GlobalObject vdnhp56 = new GlobalObject(849, new Vector3(821.047913, -1352.279541, 12.789195), new Vector3(0.000000, 0.000000, -56.599995), 300.0f);//

            // CreateDynamicObject(1219, 808.677429, -1355.632813, 13.759748, 90.000000, 180.000000, -88.099976, -1, -1);
            GlobalObject vdnhp57 = new GlobalObject(1219, new Vector3(808.677429, -1355.632813, 13.759748), new Vector3(90.000000, 180.000000, -88.099976), 300.0f);

            // CreateDynamicObject(19869, 808.369141, -1355.582520, 12.466879, 0.000000, 0.000000, 90.000000, -1, -1);
            GlobalObject vdnhp58 = new GlobalObject(19869, new Vector3(808.369141, -1355.582520, 12.466879), new Vector3(0.000000, 0.000000, 90.000000), 300.0f);

            // CreateDynamicObject(3594, 840.170471, -1323.998535, 12.992815, 0.000000, 0.000000, -65.099983, -1, -1);
            GlobalObject vdnhp59 = new GlobalObject(3594, new Vector3(840.170471, -1323.998535, 12.992815), new Vector3(0.000000, 0.000000, -65.099983), 300.0f);

            // CreateDynamicObject(3564, 785.869751, -1340.842285, -0.881461, 0.000000, 0.000000, -41.399990, -1, -1);
            GlobalObject vdnhp60 = new GlobalObject(3564, new Vector3(785.869751, -1340.842285, -0.881461), new Vector3(0.000000, 0.000000, -41.399990), 300.0f);

            // CreateDynamicObject(3564, 794.012817, -1348.152344, -0.881461, 0.000000, 0.000000, -42.799976, -1, -1);
            GlobalObject vdnhp61 = new GlobalObject(3564, new Vector3(794.012817, -1348.152344, -0.881461), new Vector3(0.000000, 0.000000, -42.799976), 300.0f);

            //  CreateDynamicObject(3564, 776.920837, -1331.066162, -0.945018, 0.000000, 0.000000, 47.099972, -1, -1);
            GlobalObject vdnhp62 = new GlobalObject(3564, new Vector3(776.920837, -1331.066162, -0.945018), new Vector3(0.000000, 0.000000, 47.099972), 300.0f);

            // CreateDynamicObject(1362, 822.361450, -1353.078613, -0.937812, 0.000000, 0.000000, -32.200008, -1, -1);
            GlobalObject vdnhp63 = new GlobalObject(1362, new Vector3(822.361450, -1353.078613, -0.937812), new Vector3(0.000000, 0.000000, -32.200008), 300.0f);

            //  CreateDynamicObject(18688, 822.173889, -1353.079712, -1.801461, 0.000000, 0.000000, -44.299999, -1, -1);
            GlobalObject vdnhp64 = new GlobalObject(18688, new Vector3(822.173889, -1353.079712, -1.801461), new Vector3(0.000000, 0.000000, -44.299999), 300.0f);

            //  CreateDynamicObject(3564, 804.736206, -1357.443237, -0.881461, 0.000000, 0.000000, -42.799976, -1, -1);
            GlobalObject vdnhp65 = new GlobalObject(3564, new Vector3(804.736206, -1357.443237, -0.881461), new Vector3(0.000000, 0.000000, -42.799976), 300.0f);

            //  CreateDynamicObject(3564, 773.915771, -1334.370117, -0.937812, 0.000000, 0.000000, 47.799992, -1, -1);
            GlobalObject vdnhp66 = new GlobalObject(3564, new Vector3(773.915771, -1334.370117, -0.937812), new Vector3(0.000000, 0.000000, 47.799992), 300.0f);

            //  CreateDynamicObject(3564, 813.225403, -1365.305298, -0.881461, 0.000000, 0.000000, -42.799976, -1, -1);
            GlobalObject vdnhp67 = new GlobalObject(3564, new Vector3(813.225403, -1365.305298, -0.881461), new Vector3(0.000000, 0.000000, -42.799976), 300.0f);

            //  CreateDynamicObject(1362, 832.833923, -1362.559204, -0.911461, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp68 = new GlobalObject(1362, new Vector3(832.833923, -1362.559204, -0.911461), new Vector3(0.000000, 0.000000, 0.0), 300.0f);

            //  CreateDynamicObject(18688, 832.657166, -1362.567871, -1.711460, 0.000000, 0.000000, -39.799999, -1, -1);
            GlobalObject vdnhp69 = new GlobalObject(18688, new Vector3(832.657166, -1362.567871, -1.711460), new Vector3(0.000000, 0.000000, -39.799999), 300.0f);

            //  CreateDynamicObject(3564, 820.797485, -1372.317627, -0.881461, 0.000000, 0.000000, -42.799976, -1, -1);
            GlobalObject vdnhp70 = new GlobalObject(3564, new Vector3(820.797485, -1372.317627, -0.881461), new Vector3(0.000000, 0.000000, -42.799976), 300.0f);

            //  CreateDynamicObject(1362, 841.491211, -1370.560913, -0.921461, 0.000000, 0.000000, -38.099991, -1, -1);
            GlobalObject vdnhp71 = new GlobalObject(1362, new Vector3(841.491211, -1370.560913, -0.921461), new Vector3(0.000000, 0.000000, -38.099991), 300.0f);

            // CreateDynamicObject(18688, 841.317261, -1370.639282, -1.811460, 0.000000, 0.000000, -39.899998, -1, -1);
            GlobalObject vdnhp72 = new GlobalObject(18688, new Vector3(841.317261, -1370.639282, -1.811460), new Vector3(0.000000, 0.000000, -39.899998), 300.0f);

            // CreateDynamicObject(1440, 842.652039, -1372.261597, -1.061460, 0.000000, 0.000000, -40.800003, -1, -1);
            GlobalObject vdnhp73 = new GlobalObject(1440, new Vector3(842.652039, -1372.261597, -1.061460), new Vector3(0.000000, 0.000000, -40.800003), 300.0f);

            //  CreateDynamicObject(3564, 828.985840, -1379.900635, -0.881461, 0.000000, 0.000000, -42.799976, -1, -1);
            GlobalObject vdnhp74 = new GlobalObject(3564, new Vector3(828.985840, -1379.900635, -0.881461), new Vector3(0.000000, 0.000000, -42.799976), 300.0f);

            // CreateDynamicObject(1449, 846.555908, -1375.013306, -0.961461, 0.000000, 0.000000, -39.500004, -1, -1);
            GlobalObject vdnhp75 = new GlobalObject(1449, new Vector3(846.555908, -1375.013306, -0.961461), new Vector3(0.000000, 0.000000, -39.500004), 300.0f);

            //  CreateDynamicObject(1431, 840.134705, -1382.089600, -1.041460, 0.000000, 0.000000, -41.099995, -1, -1);
            GlobalObject vdnhp76 = new GlobalObject(1431, new Vector3(840.134705, -1382.089600, -1.041460), new Vector3(0.000000, 0.000000, -41.099995), 300.0f);
            //ВАЛЕРА

            //  CreateDynamicObject(1440, 876.842224, -1320.755249, 13.107939, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp77 = new GlobalObject(1440, new Vector3(876.842224, -1320.755249, 13.107939), new Vector3(0.000000, 0.000000, 0.000000), 300.0f); //

            //  CreateDynamicObject(1440, 849.266968, -1377.974121, -1.061460, 0.000000, 0.000000, -40.800003, -1, -1);
            GlobalObject vdnhp78 = new GlobalObject(1440, new Vector3(849.266968, -1377.974121, -1.061460), new Vector3(0.000000, 0.000000, -40.800003), 300.0f); //

            //  CreateDynamicObject(3564, 836.947266, -1387.273071, -0.881461, 0.000000, 0.000000, -42.799976, -1, -1);
            GlobalObject vdnhp79 = new GlobalObject(3564, new Vector3(836.947266, -1387.273071, -0.881461), new Vector3(0.000000, 0.000000, -42.799976), 300.0f); //

            //  CreateDynamicObject(1362, 852.549255, -1381.164063, -0.991461, 0.000000, 0.000000, -43.600002, -1, -1);
            GlobalObject vdnhp80 = new GlobalObject(1362, new Vector3(852.549255, -1381.164063, -0.991461), new Vector3(0.000000, 0.000000, -43.600002), 300.0f); //

            //  CreateDynamicObject(18688, 852.405579, -1381.203247, -1.791461, 0.000000, 0.000000, -36.900002, -1, -1);
            GlobalObject vdnhp81 = new GlobalObject(18688, new Vector3(852.405579, -1381.203247, -1.791461), new Vector3(0.000000, 0.000000, -36.900002), 300.0f); //

            //  CreateDynamicObject(955, 854.516357, -1382.729858, -1.141461, 0.000000, 0.000000, -42.599964, -1, -1);
            GlobalObject vdnhp82 = new GlobalObject(955, new Vector3(854.516357, -1382.729858, -1.141461), new Vector3(0.000000, 0.000000, -42.599964), 300.0f); //

            //  CreateDynamicObject(955, 855.407288, -1383.547974, -1.141461, 0.000000, 0.000000, -42.599964, -1, -1);
            GlobalObject vdnhp83 = new GlobalObject(955, new Vector3(855.407288, -1383.547974, -1.141461), new Vector3(0.000000, 0.000000, -42.599964), 300.0f); //

            // CreateDynamicObject(1220, 849.973022, -1388.678101, -0.928211, 0.000000, 26.999996, 43.299999, -1, -1);
            GlobalObject vdnhp84 = new GlobalObject(1220, new Vector3(849.973022, -1388.678101, -0.928211), new Vector3(0.000000, 26.999996, 43.299999), 300.0f); //

            // CreateDynamicObject(1220, 849.630737, -1389.536499, -0.501461, 0.000000, 26.999996, 43.299999, -1, -1);
            GlobalObject vdnhp85 = new GlobalObject(1220, new Vector3(849.630737, -1389.536499, -0.501461), new Vector3(0.000000, 26.999996, 43.299999), 300.0f); //

            // CreateDynamicObject(1458, 849.201416, -1389.912476, -1.291460, 0.000000, 0.000000, -45.700012, -1, -1);
            GlobalObject vdnhp86 = new GlobalObject(1458, new Vector3(849.201416, -1389.912476, -1.291460), new Vector3(0.000000, 0.000000, -45.700012), 300.0f); //

            //  CreateDynamicObject(1431, 848.823242, -1390.217529, -1.051460, 0.000000, 0.000000, -42.600006, -1, -1);
            GlobalObject vdnhp87 = new GlobalObject(1431, new Vector3(848.823242, -1390.217529, -1.051460), new Vector3(0.000000, 0.000000, -42.600006), 300.0f); //

            //  CreateDynamicObject(3564, 843.433594, -1393.279175, -0.881461, 0.000000, 0.000000, -42.799976, -1, -1);
            GlobalObject vdnhp88 = new GlobalObject(3564, new Vector3(843.433594, -1393.279175, -0.881461), new Vector3(0.000000, 0.000000, -42.799976), 300.0f); //

            //  CreateDynamicObject(1221, 851.232971, -1390.490601, -1.111461, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp89 = new GlobalObject(1221, new Vector3(851.232971, -1390.490601, -1.111461), new Vector3(0.000000, 0.000000, 0.000000), 300.0f); //

            //  CreateDynamicObject(1221, 851.823120, -1390.860962, -0.221460, 0.000000, 0.000000, 65.200005, -1, -1);
            GlobalObject vdnhp90 = new GlobalObject(1221, new Vector3(851.823120, -1390.860962, -0.221460), new Vector3(0.000000, 0.000000, 65.200005), 300.0f); //

            //  CreateDynamicObject(1221, 852.350952, -1390.687744, -1.111461, 0.000000, 0.000000, -75.199982, -1, -1);
            GlobalObject vdnhp91 = new GlobalObject(1221, new Vector3(852.350952, -1390.687744, -1.111461), new Vector3(0.000000, 0.000000, -75.199982), 300.0f); //

            //  CreateDynamicObject(1221, 851.232971, -1391.580811, -1.111461, 0.000000, 0.000000, 39.300007, -1, -1);
            GlobalObject vdnhp92 = new GlobalObject(1221, new Vector3(851.232971, -1391.580811, -1.111461), new Vector3(0.000000, 0.000000, 39.300007), 300.0f); //

            // CreateDynamicObject(3564, 848.172852, -1400.000977, -1.101461, 90.000000, -155.300064, 0.000000, -1, -1);
            GlobalObject vdnhp93 = new GlobalObject(3564, new Vector3(848.172852, -1400.000977, -1.101461), new Vector3(90.000000, -155.300064, 0.000000), 300.0f); //

            // CreateDynamicObject(1271, 855.426208, -1389.060547, -1.281461, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp94 = new GlobalObject(1271, new Vector3(855.426208, -1389.060547, -1.281461), new Vector3(0.000000, 0.000000, 0.000000), 300.0f); //

            // CreateDynamicObject(1271, 855.426208, -1389.581055, -0.611460, 0.000000, 0.000000, -8.299999, -1, -1);
            GlobalObject vdnhp95 = new GlobalObject(1271, new Vector3(855.426208, -1389.581055, -0.611460), new Vector3(0.000000, 0.000000, -8.299999), 300.0f); //

            //   CreateDynamicObject(1271, 855.109985, -1390.097412, -1.281461, 0.000000, 0.000000, -39.700005, -1, -1);
            GlobalObject vdnhp96 = new GlobalObject(1271, new Vector3(855.109985, -1390.097412, -1.281461), new Vector3(0.000000, 0.000000, -39.700005), 300.0f);//

            //  CreateDynamicObject(1271, 854.649658, -1390.614258, -0.641461, 0.000000, 0.000000, 34.099998, -1, -1);
            GlobalObject vdnhp97 = new GlobalObject(1271, new Vector3(854.649658, -1390.614258, -0.641461), new Vector3(0.000000, 0.000000, 34.099998), 300.0f);//

            // CreateDynamicObject(1271, 854.185730, -1390.928711, -1.281461, 0.000000, 0.000000, -23.599998, -1, -1);
            GlobalObject vdnhp98 = new GlobalObject(1271, new Vector3(854.185730, -1390.928711, -1.281461), new Vector3(0.000000, 0.000000, -23.599998), 300.0f); //

            //  CreateDynamicObject(3014, 854.724365, -1389.407349, -1.301460, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp99 = new GlobalObject(3014, new Vector3(854.724365, -1389.407349, -1.301460), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);//

            //  CreateDynamicObject(3014, 854.303955, -1390.228149, -1.301460, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp100 = new GlobalObject(3014, new Vector3(854.303955, -1390.228149, -1.301460), new Vector3(0.000000, 0.000000, 0.000000), 300.0f); //

            //  CreateDynamicObject(3014, 855.084167, -1390.168091, -0.701461, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject vdnhp101 = new GlobalObject(3014, new Vector3(855.084167, -1390.168091, -0.701461), new Vector3(0.000000, 0.000000, 0.000000), 300.0f); //

            /*
            //METRO END

            //ТЕРАААААА
            //CreateDynamicObject(874, -305.799988, 2215.830078, 48.529999, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv1 = new GlobalObject(874, new Vector3(-305.799988, 2215.830078, 48.529999), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);


            //CreateDynamicObject(735, -306.049988, 2217.770020, 47.060001, 0.000000, 0.000000, 173.039993, -1, -1);
            GlobalObject terrv2 = new GlobalObject(735, new Vector3(-306.049988, 2217.770020, 47.060001), new Vector3(0.000000, 0.000000, 173.039993), 300.0f);

            //CreateDynamicObject(874, -313.019989, 2217.399902, 46.549999, 0.000000, 0.000000, 0.000000, -1, -1); 
            GlobalObject terrv3 = new GlobalObject(874, new Vector3(-313.019989, 2217.399902, 46.549999), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(874, -314.200012, 2217.959961, 44.490002, 0.000000, 0.000000, 262.029999, -1, -1);
            GlobalObject terrv4 = new GlobalObject(874, new Vector3(-314.200012, 2217.959961, 44.490002), new Vector3(0.000000, 0.000000, 262.029999), 300.0f);
            //CreateDynamicObject(874, -319.790009, 2218.229980, 42.930000, 0.000000, 0.000000, 262.029999, -1, -1);
            GlobalObject terrv5 = new GlobalObject(874, new Vector3(-319.790009, 2218.229980, 42.930000), new Vector3(0.000000, 0.000000, 262.029999), 300.0f);
            //CreateDynamicObject(1412, -347.743286, 2200.257080, 41.520000, 90.000000, 0.000000, 46.060001, -1, -1);
            GlobalObject terrv6 = new GlobalObject(1412, new Vector3(-347.743286, 2200.257080, 41.520000), new Vector3(90.000000, 0.000000, 46.060001), 300.0f);
            //CreateDynamicObject(1412, -351.858704, 2196.270020, 42.708000, -10.000000, 0.000000, 23.340000, -1, -1);
            GlobalObject terrv7 = new GlobalObject(1412, new Vector3(-351.858704, 2196.270020, 42.708000), new Vector3(-10.000000, 0.000000, 23.340000), 300.0f);
            //CreateDynamicObject(874, -331.250000, 2220.830078, 41.459999, 0.000000, 0.000000, 221.899994, -1, -1);
            GlobalObject terrv8 = new GlobalObject(874, new Vector3(-331.250000, 2220.830078, 41.459999), new Vector3(0.000000, 0.000000, 221.899994), 300.0f);
            //CreateDynamicObject(874, -355.369995, 2195.830078, 41.330002, 0.000000, 0.000000, 78.389999, -1, -1);
            GlobalObject terrv9 = new GlobalObject(874, new Vector3(-355.369995, 2195.830078, 41.330002), new Vector3(0.000000, 0.000000, 78.389999), 300.0f);
            //CreateDynamicObject(1414, -356.762115, 2194.503418, 42.653999, 0.000000, 0.000000, 12.300000, -1, -1);
            GlobalObject terrv10 = new GlobalObject(1414, new Vector3(-356.762115, 2194.503418, 42.653999), new Vector3(0.000000, 0.000000, 12.300000), 300.0f);
            //CreateDynamicObject(1412, -356.783966, 2194.593750, 42.708000, 0.000000, 0.000000, 192.119934, -1, -1);
            GlobalObject terrv11 = new GlobalObject(1412, new Vector3(-356.783966, 2194.593750, 42.708000), new Vector3(0.000000, 0.000000, 192.119934), 300.0f);
            //CreateDynamicObject(874, -344.391296, 2208.942627, 41.213001, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv12 = new GlobalObject(874, new Vector3(-344.391296, 2208.942627, 41.213001), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(3593, -364.517761, 2188.029053, 41.853901, 0.000000, 0.000000, 194.160004, -1, -1);
            GlobalObject terrv13 = new GlobalObject(3593, new Vector3(-364.517761, 2188.029053, 41.853901), new Vector3(0.000000, 0.000000, 194.160004), 300.0f);
            //CreateDynamicObject(1447, -361.874786, 2193.363770, 42.653999, 0.000000, 0.000000, 13.260000, -1, -1);
            GlobalObject terrv14 = new GlobalObject(1447, new Vector3(-361.874786, 2193.363770, 42.653999), new Vector3(0.000000, 0.000000, 13.260000), 300.0f);
            //CreateDynamicObject(874, -368.554077, 2186.473633, 40.489399, 0.000000, 0.000000, 1.800000, -1, -1);
            GlobalObject terrv15 = new GlobalObject(874, new Vector3(-368.554077, 2186.473633, 40.489399), new Vector3(0.000000, 0.000000, 1.800000), 300.0f);
            //CreateDynamicObject(1412, -366.995697, 2192.278564, 42.653999, 0.000000, -2.000000, 12.120000, -1, -1);
            GlobalObject terrv16 = new GlobalObject(1412, new Vector3(-366.995697, 2192.278564, 42.653999), new Vector3(0.000000, -2.000000, 12.120000), 300.0f);
            //CreateDynamicObject(773, -415.470001, 2096.000000, 60.150002, 0.000000, 0.000000, 282.489990, -1, -1);
            GlobalObject terrv17 = new GlobalObject(773, new Vector3(-415.470001, 2096.000000, 60.150002), new Vector3(0.000000, 0.000000, 282.489990), 300.0f);
            //CreateDynamicObject(1218, -358.206512, 2205.001465, 41.901798, 0.000000, 90.000000, -13.080000, -1, -1);
            GlobalObject terrv18 = new GlobalObject(1218, new Vector3(-358.206512, 2205.001465, 41.901798), new Vector3(0.000000, 90.000000, -13.080000), 300.0f);
            //CreateDynamicObject(1218, -359.373047, 2204.390625, 41.939800, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv19 = new GlobalObject(1218, new Vector3(-359.373047, 2204.390625, 41.939800), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(967, -370.336914, 2192.258789, 41.090000, 6.000000, 0.000000, 283.859802, -1, -1);
            GlobalObject terrv20 = new GlobalObject(967, new Vector3(-370.336914, 2192.258789, 41.090000), new Vector3(6.000000, 0.000000, 283.859802), 300.0f);
            //CreateDynamicObject(1225, -360.908508, 2204.772949, 41.901100, 0.000000, 0.000000, 89.160004, -1, -1);
            GlobalObject terrv21 = new GlobalObject(1225, new Vector3(-360.908508, 2204.772949, 41.901100), new Vector3(0.000000, 0.000000, 89.160004), 300.0f);
            //CreateDynamicObject(2673, -370.518402, 2193.555664, 41.231400, 0.000000, 0.000000, 160.619904, -1, -1);
            GlobalObject terrv22 = new GlobalObject(2673, new Vector3(-370.518402, 2193.555664, 41.231400), new Vector3(0.000000, 0.000000, 160.619904), 300.0f);
            //CreateDynamicObject(2675, -376.265991, 2186.112305, 41.300400, 0.000000, 0.000000, -9.360000, -1, -1);
            GlobalObject terrv23 = new GlobalObject(2675, new Vector3(-376.265991, 2186.112305, 41.300400), new Vector3(0.000000, 0.000000, -9.360000), 300.0f);
            //CreateDynamicObject(970, -373.059692, 2191.350098, 41.545502, 0.000000, -1.500000, 14.700000, -1, -1);
            GlobalObject terrv24 = new GlobalObject(970, new Vector3(-373.059692, 2191.350098, 41.545502), new Vector3(0.000000, -1.500000, 14.700000), 300.0f);
            //CreateDynamicObject(1327, -377.230072, 2188.766113, 41.088001, 0.000000, 90.000000, 0.000000, -1, -1);
            GlobalObject terrv25 = new GlobalObject(1327, new Vector3(-377.230072, 2188.766113, 41.088001), new Vector3(0.000000, 90.000000, 0.000000), 300.0f);
            //CreateDynamicObject(967, -375.871307, 2191.016602, 40.874001, 0.000000, 0.000000, 102.960007, -1, -1);
            GlobalObject terrv26 = new GlobalObject(967, new Vector3(-375.871307, 2191.016602, 40.874001), new Vector3(0.000000, 0.000000, 102.960007), 300.0f);
            //CreateDynamicObject(2674, -375.173828, 2193.604004, 41.080200, 0.000000, 0.000000, 76.320000, -1, -1);
            GlobalObject terrv27 = new GlobalObject(2674, new Vector3(-375.173828, 2193.604004, 41.080200), new Vector3(0.000000, 0.000000, 76.320000), 300.0f);
            //CreateDynamicObject(2673, -376.213196, 2192.956299, 41.231400, 0.000000, 0.000000, 65.580002, -1, -1);
            GlobalObject terrv28 = new GlobalObject(2673, new Vector3(-376.213196, 2192.956299, 41.231400), new Vector3(0.000000, 0.000000, 65.580002), 300.0f);
            //CreateDynamicObject(3594, -382.734222, 2184.116699, 41.783401, 0.000000, 0.000000, 12.300000, -1, -1);
            GlobalObject terrv29 = new GlobalObject(3594, new Vector3(-382.734222, 2184.116699, 41.783401), new Vector3(0.000000, 0.000000, 12.300000), 300.0f);
            //CreateDynamicObject(1412, -379.014648, 2189.656982, 42.546001, 0.000000, -2.000000, 191.760101, -1, -1);
            GlobalObject terrv30 = new GlobalObject(1412, new Vector3(-379.014648, 2189.656982, 42.546001), new Vector3(0.000000, -2.000000, 191.760101), 300.0f);
            //CreateDynamicObject(1430, -364.550323, 2209.770752, 41.863899, 0.000000, 90.000000, 144.479996, -1, -1);
            GlobalObject terrv31 = new GlobalObject(1430, new Vector3(-364.550323, 2209.770752, 41.863899), new Vector3(0.000000, 90.000000, 144.479996), 300.0f);
            //CreateDynamicObject(1412, -342.448090, 2234.420898, 41.520000, 90.000000, 0.000000, -77.839996, -1, -1);
            GlobalObject terrv32 = new GlobalObject(1412, new Vector3(-342.448090, 2234.420898, 41.520000), new Vector3(90.000000, 0.000000, -77.839996), 300.0f);
            //CreateDynamicObject(874, -374.959991, 2198.459961, 40.770000, 0.000000, 0.000000, 94.379997, -1, -1);
            GlobalObject terrv33 = new GlobalObject(874, new Vector3(-374.959991, 2198.459961, 40.770000), new Vector3(0.000000, 0.000000, 94.379997), 300.0f);
            //CreateDynamicObject(2672, -366.309875, 2210.710693, 41.797600, 0.000000, 0.000000, -64.260002, -1, -1);
            GlobalObject terrv34 = new GlobalObject(2672, new Vector3(-366.309875, 2210.710693, 41.797600), new Vector3(0.000000, 0.000000, -64.260002), 300.0f);
            //CreateDynamicObject(2905, -356.995209, 2222.128418, 49.986401, -10.000000, 90.000000, -105.239998, -1, -1);
            GlobalObject terrv35 = new GlobalObject(2905, new Vector3(-356.995209, 2222.128418, 49.986401), new Vector3(-10.000000, 90.000000, -105.239998), 300.0f);
            //CreateDynamicObject(1412, -384.136383, 2188.589844, 42.653999, 0.000000, 0.000000, 191.760101, -1, -1);
            GlobalObject terrv36 = new GlobalObject(1412, new Vector3(-384.136383, 2188.589844, 42.653999), new Vector3(0.000000, 0.000000, 191.760101), 300.0f);
            //CreateDynamicObject(2906, -357.302948, 2222.147949, 50.428699, -60.000000, 0.000000, -135.600067, -1, -1);
            GlobalObject terrv37 = new GlobalObject(2906, new Vector3(-357.302948, 2222.147949, 50.428699), new Vector3(-60.000000, 0.000000, -135.600067), 300.0f);
            //CreateDynamicObject(2905, -357.047119, 2222.547119, 49.880402, -30.000000, 90.000000, -68.879997, -1, -1);
            GlobalObject terrv38 = new GlobalObject(2905, new Vector3(-357.047119, 2222.547119, 49.880402), new Vector3(-30.000000, 90.000000, -68.879997), 300.0f);
            //CreateDynamicObject(1517, -357.102509, 2222.588379, 50.253502, -10.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv39 = new GlobalObject(1517, new Vector3(-357.102509, 2222.588379, 50.253502), new Vector3(-10.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(2908, -357.293396, 2222.334473, 50.926300, -90.000000, 180.000000, 0.000000, -1, -1);
            GlobalObject terrv40 = new GlobalObject(2908, new Vector3(-357.293396, 2222.334473, 50.926300), new Vector3(-90.000000, 180.000000, 0.000000), 300.0f);
            //CreateDynamicObject(2907, -357.339203, 2222.368164, 50.381001, -90.000000, 90.000000, 0.000000, -1, -1);
            GlobalObject terrv41 = new GlobalObject(2907, new Vector3(-357.339203, 2222.368164, 50.381001), new Vector3(-90.000000, 90.000000, 0.000000), 300.0f);
            //CreateDynamicObject(2906, -357.223969, 2222.583984, 50.428699, -60.000000, 180.000000, 297.479889, -1, -1);
            GlobalObject terrv42 = new GlobalObject(2906, new Vector3(-357.223969, 2222.583984, 50.428699), new Vector3(-60.000000, 180.000000, 297.479889), 300.0f);
            //CreateDynamicObject(3594, -389.026489, 2183.076172, 41.783401, 0.000000, 0.000000, 12.300000, -1, -1);
            GlobalObject terrv43 = new GlobalObject(3594, new Vector3(-389.026489, 2183.076172, 41.783401), new Vector3(0.000000, 0.000000, 12.300000), 300.0f);
            //CreateDynamicObject(1412, -343.773804, 2240.048828, 42.762001, 10.000000, 2.000000, -56.240009, -1, -1);
            GlobalObject terrv44 = new GlobalObject(1412, new Vector3(-343.773804, 2240.048828, 42.762001), new Vector3(10.000000, 2.000000, -56.240009), 300.0f);
            //CreateDynamicObject(2676, -360.638428, 2225.512451, 41.625801, 0.000000, 0.000000, -296.399811, -1, -1);
            GlobalObject terrv45 = new GlobalObject(2676, new Vector3(-360.638428, 2225.512451, 41.625801), new Vector3(0.000000, 0.000000, -296.399811), 300.0f);
            //CreateDynamicObject(1412, -389.256439, 2187.761963, 42.653999, 0.000000, 0.000000, 186.300049, -1, -1);
            GlobalObject terrv46 = new GlobalObject(1412, new Vector3(-389.256439, 2187.761963, 42.653999), new Vector3(0.000000, 0.000000, 186.300049), 300.0f);
            //CreateDynamicObject(2671, -376.514099, 2207.791992, 41.106602, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv47 = new GlobalObject(2671, new Vector3(-376.514099, 2207.791992, 41.106602), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(874, -384.477081, 2198.304932, 40.621201, 0.000000, 0.000000, 72.300003, -1, -1);
            GlobalObject terrv48 = new GlobalObject(874, new Vector3(-384.477081, 2198.304932, 40.621201), new Vector3(0.000000, 0.000000, 72.300003), 300.0f);
            //CreateDynamicObject(1412, -346.567200, 2244.403809, 42.762001, 0.000000, 2.000000, -58.820000, -1, -1);
            GlobalObject terrv49 = new GlobalObject(1412, new Vector3(-346.567200, 2244.403809, 42.762001), new Vector3(0.000000, 2.000000, -58.820000), 300.0f);
            //CreateDynamicObject(874, -371.288788, 2218.344238, 41.321098, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv50 = new GlobalObject(874, new Vector3(-371.288788, 2218.344238, 41.321098), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            
            fso_map = CreateDynamicObject(19993, -382.810913, 2202.516357, 44.651901, 0.000000, 0.000000, 0.000000, -1, -1);
            SetDynamicObjectMaterial(fso_map, 0, 1453, "break_farm", "CJ_HAY", 0);
            
            GlobalObject terrvtexture1 = new GlobalObject(19993, new Vector3(-382.810913, 2202.516357, 44.651901), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            terrvtexture1.SetMaterial(0, 1453, "break_farm", "CJ_HAY", 0);
            //CreateDynamicObject(1412, -350.751099, 2248.326416, 41.520000, 90.000000, 0.000000, -53.540031, -1, -1);
            GlobalObject terrv51 = new GlobalObject(1412, new Vector3(-350.751099, 2248.326416, 41.520000), new Vector3(90.000000, 0.000000, -53.540031), 300.0f);
            //CreateDynamicObject(874, -363.053009, 2234.755371, 41.139801, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv52 = new GlobalObject(874, new Vector3(-363.053009, 2234.755371, 41.139801), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1447, -394.608612, 2187.346436, 42.546001, 0.000000, -3.000000, -3.180000, -1, -1);
            GlobalObject terrv53 = new GlobalObject(1447, new Vector3(-394.608612, 2187.346436, 42.546001), new Vector3(0.000000, -3.000000, -3.180000), 300.0f);
            //CreateDynamicObject(1439, -397.773621, 2186.358154, 40.840199, 0.000000, 0.000000, -2.820000, -1, -1);
            GlobalObject terrv54 = new GlobalObject(1439, new Vector3(-397.773621, 2186.358154, 40.840199), new Vector3(0.000000, 0.000000, -2.820000), 300.0f);
            //CreateDynamicObject(2671, -399.452209, 2183.674316, 40.832298, 0.000000, 0.000000, 134.399887, -1, -1);
            GlobalObject terrv55 = new GlobalObject(2671, new Vector3(-399.452209, 2183.674316, 40.832298), new Vector3(0.000000, 0.000000, 134.399887), 300.0f);
            //CreateDynamicObject(3302, -383.240112, 2213.674316, 41.457199, 0.000000, 0.000000, 44.580002, -1, -1);
            GlobalObject terrv56 = new GlobalObject(3302, new Vector3(-383.240112, 2213.674316, 41.457199), new Vector3(0.000000, 0.000000, 44.580002), 300.0f);
            //CreateDynamicObject(1439, -399.940948, 2186.720459, 40.840199, 0.000000, 0.000000, -12.780000, -1, -1);
            GlobalObject terrv57 = new GlobalObject(1439, new Vector3(-399.940948, 2186.720459, 40.840199), new Vector3(0.000000, 0.000000, -12.780000), 300.0f);
            //CreateDynamicObject(874, -415.392883, 2151.282959, 43.476330, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv58 = new GlobalObject(874, new Vector3(-415.392883, 2151.282959, 43.476330), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1447, -399.958618, 2187.487305, 42.546001, 0.000000, -3.000000, -11.460000, -1, -1);
            GlobalObject terrv59 = new GlobalObject(1447, new Vector3(-399.958618, 2187.487305, 42.546001), new Vector3(0.000000, -3.000000, -11.460000), 300.0f);
            //CreateDynamicObject(1412, -352.996094, 2253.884766, 42.762001, 0.000000, 2.000000, -53.060001, -1, -1);
            GlobalObject terrv60 = new GlobalObject(1412, new Vector3(-352.996094, 2253.884766, 42.762001), new Vector3(0.000000, 2.000000, -53.060001), 300.0f);
            //CreateDynamicObject(1428, -387.165009, 2214.099365, 42.776001, 0.000000, 0.000000, 15.120000, -1, -1);
            GlobalObject terrv61 = new GlobalObject(1428, new Vector3(-387.165009, 2214.099365, 42.776001), new Vector3(0.000000, 0.000000, 15.120000), 300.0f);
            //CreateDynamicObject(2062, -367.399475, 2241.216064, 41.853699, 0.000000, 90.000000, -19.500019, -1, -1);
            GlobalObject terrv62 = new GlobalObject(2062, new Vector3(-367.399475, 2241.216064, 41.853699), new Vector3(0.000000, 90.000000, -19.500019), 300.0f);
            //CreateDynamicObject(819, -359.399994, 2251.209961, 40.660000, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv63 = new GlobalObject(819, new Vector3(-359.399994, 2251.209961, 40.660000), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1449, -372.360229, 2236.187988, 41.959702, 0.000000, 0.000000, 12.780000, -1, -1);
            GlobalObject terrv64 = new GlobalObject(1449, new Vector3(-372.360229, 2236.187988, 41.959702), new Vector3(0.000000, 0.000000, 12.780000), 300.0f);
            //CreateDynamicObject(773, -359.160004, 2252.159912, 40.689999, 0.000000, 0.000000, 282.489990, -1, -1);
            GlobalObject terrv65 = new GlobalObject(773, new Vector3(-359.160004, 2252.159912, 40.689999), new Vector3(0.000000, 0.000000, 282.489990), 300.0f);
            //CreateDynamicObject(2062, -366.055450, 2244.509277, 41.906700, 0.000000, 90.000000, 71.160004, -1, -1);
            GlobalObject terrv66 = new GlobalObject(2062, new Vector3(-366.055450, 2244.509277, 41.906700), new Vector3(0.000000, 90.000000, 71.160004), 300.0f);
            //CreateDynamicObject(2062, -368.334137, 2242.154053, 42.012699, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv67 = new GlobalObject(2062, new Vector3(-368.334137, 2242.154053, 42.012699), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(2062, -368.518951, 2242.989990, 42.012699, 0.000000, 0.000000, 92.279991, -1, -1);
            GlobalObject terrv68 = new GlobalObject(2062, new Vector3(-368.518951, 2242.989990, 42.012699), new Vector3(0.000000, 0.000000, 92.279991), 300.0f);
            //CreateDynamicObject(1412, -405.361603, 2187.927246, 42.653999, 10.000000, 0.000000, 179.999908, -1, -1);
            GlobalObject terrv69 = new GlobalObject(1412, new Vector3(-405.361603, 2187.927246, 42.653999), new Vector3(10.000000, 0.000000, 179.999908), 300.0f);
            //CreateDynamicObject(735, -411.029999, 2178.199951, 37.529999, 0.000000, 0.000000, 173.039993, -1, -1);
            GlobalObject terrv70 = new GlobalObject(735, new Vector3(-411.029999, 2178.199951, 37.529999), new Vector3(0.000000, 0.000000, 173.039993), 300.0f);
            //CreateDynamicObject(819, -435.299988, 2083.739990, 59.900002, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv71 = new GlobalObject(819, new Vector3(-435.299988, 2083.739990, 59.900002), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(819, -411.190002, 2178.570068, 40.660000, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv72 = new GlobalObject(819, new Vector3(-411.190002, 2178.570068, 40.660000), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1413, -355.989197, 2258.170166, 42.938000, 0.000000, -2.000000, -235.139893, -1, -1);
            GlobalObject terrv73 = new GlobalObject(1413, new Vector3(-355.989197, 2258.170166, 42.938000), new Vector3(0.000000, -2.000000, -235.139893), 300.0f);
            //CreateDynamicObject(2062, -368.995697, 2244.820557, 42.012699, 0.000000, 0.000000, 155.039978, -1, -1);
            GlobalObject terrv74 = new GlobalObject(2062, new Vector3(-368.995697, 2244.820557, 42.012699), new Vector3(0.000000, 0.000000, 155.039978), 300.0f);
            //CreateDynamicObject(2674, -376.404724, 2237.527100, 41.665699, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrv75 = new GlobalObject(2674, new Vector3(-376.404724, 2237.527100, 41.665699), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //CreateDynamicObject(1412, -410.342896, 2189.227295, 41.096001, -88.000000, 0.000000, -10.520000, -1, -1);
            GlobalObject terrv76 = new GlobalObject(1412, new Vector3(-410.342896, 2189.227295, 41.096001), new Vector3(-88.000000, 0.000000, -10.520000), 300.0f);
            //МАЯ ТЕРРИТОРИЯ
            //CreateDynamicObject(1413, -359.479187, 2262.132324, 42.883999, 0.000000, 3.000000, -223.380005, -1, -1);
            GlobalObject terrz1 = new GlobalObject(1413, new Vector3(-359.479187, 2262.132324, 42.883999), new Vector3(0.000000, 3.000000, -223.380005), 300.0f);

            //CreateDynamicObject(11428, -442.880005, 2074.889893, 64.010002, 0.000000, 0.000000, 90.940002, -1, -1);
            GlobalObject terrz2 = new GlobalObject(11428, new Vector3(-442.880005, 2074.889893, 64.010002), new Vector3(0.000000, 0.000000, 90.940002), 300.0f);

            //CreateDynamicObject(918, -377.998108, 2246.792725, 41.954102, 0.000000, 0.000000, 48.900002, -1, -1);
            GlobalObject terrz3 = new GlobalObject(918, new Vector3(-377.998108, 2246.792725, 41.954102), new Vector3(0.000000, 0.000000, 48.900002), 300.0f);

            //CreateDynamicObject(874, -408.195190, 2206.438477, 41.164200, 0.000000, 0.000000, 38.340000, -1, -1);
            GlobalObject terrz4 = new GlobalObject(874, new Vector3(-408.195190, 2206.438477, 41.164200), new Vector3(0.000000, 0.000000, 38.340000), 300.0f);

            //CreateDynamicObject(1412, -417.083588, 2190.853271, 41.202000, -88.000000, 0.000000, 3.520000, -1, -1);
            GlobalObject terrz5 = new GlobalObject(1412, new Vector3(-417.083588, 2190.853271, 41.202000), new Vector3(-88.000000, 0.000000, 3.520000), 300.0f);

            //CreateDynamicObject(952, -375.787537, 2251.080811, 42.649700, 0.000000, 0.000000, -74.759979, -1, -1);
            GlobalObject terrz6 = new GlobalObject(952, new Vector3(-375.787537, 2251.080811, 42.649700), new Vector3(0.000000, 0.000000, -74.759979), 300.0f);

            //CreateDynamicObject(1449, -398.089508, 2224.234619, 41.904301, 0.000000, 0.000000, -72.059982, -1, -1);
            GlobalObject terrz7 = new GlobalObject(1449, new Vector3(-398.089508, 2224.234619, 41.904301), new Vector3(0.000000, 0.000000, -72.059982), 300.0f);

            //CreateDynamicObject(1413, -363.286285, 2265.688721, 42.667999, 0.000000, 3.000000, -222.360001, -1, -1);
            GlobalObject terrz8 = new GlobalObject(1413, new Vector3(-363.286285, 2265.688721, 42.667999), new Vector3(0.000000, 3.000000, -222.360001), 300.0f);

            //CreateDynamicObject(1462, -398.959229, 2226.407471, 41.428200, 0.000000, 0.000000, -73.079987, -1, -1);
            GlobalObject terrz9 = new GlobalObject(1462, new Vector3(-398.959229, 2226.407471, 41.428200), new Vector3(0.000000, 0.000000, -73.079987), 300.0f);

            //CreateDynamicObject(819, -451.869995, 2064.949951, 59.580002, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz10 = new GlobalObject(819, new Vector3(-451.869995, 2064.949951, 59.580002), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(3593, -394.901611, 2233.361816, 41.849602, 0.000000, 0.000000, -75.000000, -1, -1);
            GlobalObject terrz11 = new GlobalObject(3593, new Vector3(-394.901611, 2233.361816, 41.849602), new Vector3(0.000000, 0.000000, -75.000000), 300.0f);

            //CreateDynamicObject(2968, -412.308594, 2210.147461, 41.745602, 0.000000, 0.000000, -22.500000, -1, -1);
            GlobalObject terrz12 = new GlobalObject(2968, new Vector3(-412.308594, 2210.147461, 41.745602), new Vector3(0.000000, 0.000000, -22.500000), 300.0f);

            //CreateDynamicObject(918, -414.467804, 2206.994141, 41.732700, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz13 = new GlobalObject(918, new Vector3(-414.467804, 2206.994141, 41.732700), new Vector3(0.000000, 0.000000, 0.00), 300.0f);

            //CreateDynamicObject(918, -414.884369, 2206.625244, 41.732700, 0.000000, 0.000000, 64.980003, -1, -1);
            GlobalObject terrz14 = new GlobalObject(918, new Vector3(-414.884369, 2206.625244, 41.732700), new Vector3(0.000000, 0.000000, 64.980003), 300.0f);

            //CreateDynamicObject(1230, -412.653320, 2211.063721, 41.852100, 0.000000, 0.000000, 14.640000, -1, -1);
            GlobalObject terrz15 = new GlobalObject(1230, new Vector3(-412.653320, 2211.063721, 41.852100), new Vector3(0.000000, 0.000000, 14.640000), 300.0f);

            //CreateDynamicObject(1558, -412.158600, 2212.136719, 42.010300, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz16 = new GlobalObject(1558, new Vector3(-412.158600, 2212.136719, 42.010300), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(874, -405.713196, 2222.884277, 41.309299, 0.000000, 0.000000, 82.379997, -1, -1);
            GlobalObject terrz17 = new GlobalObject(874, new Vector3(-405.713196, 2222.884277, 41.309299), new Vector3(0.000000, 0.000000, 82.379997), 300.0f);

            //CreateDynamicObject(1413, -367.179810, 2269.259277, 42.397999, 0.000000, 3.000000, -222.360001, -1, -1);
            GlobalObject terrz18 = new GlobalObject(1413, new Vector3(-367.179810, 2269.259277, 42.397999), new Vector3(0.000000, 3.000000, -222.360001), 300.0f);

            //CreateDynamicObject(2676, -415.589294, 2207.871826, 41.533798, 0.000000, 0.000000, 42.060001, -1, -1);
            GlobalObject terrz19 = new GlobalObject(2676, new Vector3(-415.589294, 2207.871826, 41.533798), new Vector3(0.000000, 0.000000, 42.060001), 300.0f);

            //CreateDynamicObject(933, -379.023895, 2257.755859, 41.429600, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz20 = new GlobalObject(933, new Vector3(-379.023895, 2257.755859, 41.429600), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(2677, -393.673309, 2241.203613, 41.727501, 0.000000, 0.000000, 80.400002, -1, -1);
            GlobalObject terrz21 = new GlobalObject(2677, new Vector3(-393.673309, 2241.203613, 41.727501), new Vector3(0.000000, 0.000000, 80.400002), 300.0f);

            //CreateDynamicObject(3403, -416.331604, 2208.938965, 44.175598, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz22 = new GlobalObject(3403, new Vector3(-416.331604, 2208.938965, 44.175598), new Vector3(0.000000, 0.000000, 0.00000), 300.0f);

            //CreateDynamicObject(874, -429.799988, 2185.969971, 41.360001, 0.000000, 0.000000, 322.549988, -1, -1);
            GlobalObject terrz23 = new GlobalObject(874, new Vector3(-429.799988, 2185.969971, 41.360001), new Vector3(0.000000, 0.000000, 322.549988), 300.0f);

            //CreateDynamicObject(2675, -417.908783, 2210.969971, 41.533798, 0.000000, 0.000000, 13.740000, -1, -1);
            GlobalObject terrz24 = new GlobalObject(2675, new Vector3(-417.908783, 2210.969971, 41.533798), new Vector3(0.000000, 0.000000, 13.740000), 300.0f);

            //CreateDynamicObject(2968, -419.599396, 2209.518555, 41.745602, 0.000000, 0.000000, -44.520000, -1, -1);
            GlobalObject terrz25 = new GlobalObject(2968, new Vector3(-419.599396, 2209.518555, 41.745602), new Vector3(0.000000, 0.000000, -44.520000), 300.0f);

            //CreateDynamicObject(1438, -420.398895, 2208.458008, 41.427700, 0.000000, 0.000000, 97.379997, -1, -1);
            GlobalObject terrz26 = new GlobalObject(1438, new Vector3(-420.398895, 2208.458008, 41.427700), new Vector3(0.000000, 0.000000, 97.379997), 300.0f);

            //CreateDynamicObject(2971, -419.976288, 2211.079346, 41.373798, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz27 = new GlobalObject(2971, new Vector3(-419.976288, 2211.079346, 41.373798), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1412, -371.468170, 2272.223145, 42.167999, 0.000000, -3.500000, -27.180000, -1, -1);
            GlobalObject terrz28 = new GlobalObject(1412, new Vector3(-371.468170, 2272.223145, 42.167999), new Vector3(0.000000, -3.500000, -27.180000), 300.0f);

            //CreateDynamicObject(1347, -394.614838, 2251.035645, 41.903599, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz29 = new GlobalObject(1347, new Vector3(-394.614838, 2251.035645, 41.903599), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1412, -432.268585, 2196.547119, 42.653999, 0.000000, 0.000000, 151.800003, -1, -1);
            GlobalObject terrz30 = new GlobalObject(1412, new Vector3(-432.268585, 2196.547119, 42.653999), new Vector3(0.000000, 0.000000, 151.800003), 300.0f);

            //CreateDynamicObject(874, -406.995605, 2238.829102, 41.007500, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz31 = new GlobalObject(874, new Vector3(-406.995605, 2238.829102, 41.007500), new Vector3(0.000000, 0.000000, 0.00000), 300.0f);

            //CreateDynamicObject(1412, -376.089508, 2274.586182, 41.844002, 0.000000, -3.500000, -27.179991, -1, -1);
            GlobalObject terrz32 = new GlobalObject(1412, new Vector3(-376.089508, 2274.586182, 41.844002), new Vector3(0.000000, -3.500000, -27.179991), 300.0f);

            //CreateDynamicObject(874, -385.807709, 2267.532959, 40.516899, 0.000000, 0.000000, 60.720001, -1, -1);
            GlobalObject terrz300 = new GlobalObject(874, new Vector3(-385.807709, 2267.532959, 40.516899), new Vector3(0.000000, 0.000000, 60.720001), 300.0f);

            //CreateDynamicObject(1337, -420.370636, 2226.105225, 42.075600, 0.000000, 0.000000, -71.220016, -1, -1);
            GlobalObject terrz33 = new GlobalObject(1337, new Vector3(-420.370636, 2226.105225, 42.075600), new Vector3(0.000000, 0.000000, -71.220016), 300.0f);

            //CreateDynamicObject(1412, -436.458710, 2199.657471, 42.653999, 10.000000, 0.000000, 139.199982, -1, -1);
            GlobalObject terrz34 = new GlobalObject(1412, new Vector3(-436.458710, 2199.657471, 42.653999), new Vector3(10.000000, 0.000000, 139.199982), 300.0f);

            //CreateDynamicObject(874, -427.628021, 2216.021729, 41.309299, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz35 = new GlobalObject(874, new Vector3(-427.628021, 2216.021729, 41.309299), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1412, -380.894012, 2275.120117, 41.736000, 0.000000, 0.000000, 13.440000, -1, -1);
            GlobalObject terrz36 = new GlobalObject(1412, new Vector3(-380.894012, 2275.120117, 41.736000), new Vector3(0.000000, 0.000000, 13.440000), 300.0f);

            //CreateDynamicObject(1412, -385.888397, 2273.870117, 41.736000, 0.000000, 0.000000, 13.900000, -1, -1);
            GlobalObject terrz37 = new GlobalObject(1412, new Vector3(-385.888397, 2273.870117, 41.736000), new Vector3(0.000000, 0.000000, 13.900000), 300.0f);

            //CreateDynamicObject(1412, -440.023254, 2203.980225, 41.466999, 90.000000, 0.000000, -214.100037, -1, -1);
            GlobalObject terrz38 = new GlobalObject(1412, new Vector3(-440.023254, 2203.980225, 41.466999), new Vector3(90.000000, 0.000000, -214.100037), 300.0f);

            //CreateDynamicObject(967, -389.047150, 2272.344238, 40.106201, 0.000000, 0.000000, 282.600006, -1, -1);
            GlobalObject terrz39 = new GlobalObject(967, new Vector3(-389.047150, 2272.344238, 40.106201), new Vector3(0.000000, 0.000000, 282.600006), 300.0f);

            //CreateDynamicObject(1219, -406.695496, 2254.568604, 41.427299, 0.000000, 0.000000, -3.000000, -1, -1);
            GlobalObject terrz40 = new GlobalObject(1219, new Vector3(-406.695496, 2254.568604, 41.427299), new Vector3(0.000000, 0.000000, -3.000000), 300.0f);

            //CreateDynamicObject(960, -406.841187, 2254.709961, 42.014599, 0.000000, 0.000000, 18.600000, -1, -1);
            GlobalObject terrz41 = new GlobalObject(960, new Vector3(-406.841187, 2254.709961, 42.014599), new Vector3(0.000000, 0.000000, 18.600000), 300.0f);

            //CreateDynamicObject(874, -445.160004, 2200.449951, 42.090000, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz42 = new GlobalObject(874, new Vector3(-445.160004, 2200.449951, 42.090000), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(967, -394.614410, 2270.955566, 40.106201, 0.000000, 0.000000, 461.399902, -1, -1);
            GlobalObject terrz43 = new GlobalObject(967, new Vector3(-394.614410, 2270.955566, 40.106201), new Vector3(0.000000, 0.000000, 461.399902), 300.0f);

            //CreateDynamicObject(970, -392.530701, 2273.977295, 40.114498, 90.000000, 0.000000, -152.039993, -1, -1);
            GlobalObject terrz44 = new GlobalObject(970, new Vector3(-392.530701, 2273.977295, 40.114498), new Vector3(90.000000, 0.000000, -152.039993), 300.0f);

            //CreateDynamicObject(850, -443.577698, 2207.188477, 41.530399, 0.000000, 0.000000, -55.680000, -1, -1);
            GlobalObject terrz45 = new GlobalObject(850, new Vector3(-443.577698, 2207.188477, 41.530399), new Vector3(0.000000, 0.000000, -55.680000), 300.0f);

            //CreateDynamicObject(874, -429.229095, 2231.920654, 41.309299, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz46 = new GlobalObject(874, new Vector3(-429.229095, 2231.920654, 41.309299), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1441, -406.260010, 2262.100098, 41.910000, -5.700000, 3.720000, 0.000000, -1, -1);
            GlobalObject terrz47 = new GlobalObject(1441, new Vector3(-406.260010, 2262.100098, 41.910000), new Vector3(-5.700000, 3.720000, 0.000000), 300.0f);

            //CreateDynamicObject(1412, -398.033875, 2270.932617, 41.736000, 0.000000, 3.000000, 13.440000, -1, -1);
            GlobalObject terrz48 = new GlobalObject(1412, new Vector3(-398.033875, 2270.932617, 41.736000), new Vector3(0.000000, 3.000000, 13.440000), 300.0f);

            //CreateDynamicObject(3363, -450.369995, 2197.790039, 42.540001, -5.940000, 1.920000, 334.869995, -1, -1);
            GlobalObject terrz49 = new GlobalObject(3363, new Vector3(-450.369995, 2197.790039, 42.540001), new Vector3(-5.940000, 1.920000, 334.869995), 300.0f);

            //CreateDynamicObject(933, -436.390900, 2225.253174, 41.372501, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz50 = new GlobalObject(933, new Vector3(-436.390900, 2225.253174, 41.372501), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1574, -427.126099, 2239.598389, 41.375900, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz51 = new GlobalObject(1574, new Vector3(-427.126099, 2239.598389, 41.375900), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1357, -413.279999, 2257.080078, 41.700001, 0.000000, 0.000000, 321.829987, -1, -1);
            GlobalObject terrz52 = new GlobalObject(1357, new Vector3(-413.279999, 2257.080078, 41.700001), new Vector3(0.000000, 0.000000, 321.829987), 300.0f);

            //CreateDynamicObject(874, -415.790009, 2254.330078, 40.860001, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz53 = new GlobalObject(874, new Vector3(-415.790009, 2254.330078, 40.860001), new Vector3(0.000000, 0.000000, 0.0), 300.0f);

            //CreateDynamicObject(2671, -426.100983, 2241.726807, 41.463200, 0.000000, 0.000000, -73.320000, -1, -1);
            GlobalObject terrz54 = new GlobalObject(2671, new Vector3(-426.100983, 2241.726807, 41.463200), new Vector3(0.000000, 0.000000, -73.320000), 300.0f);

            //CreateDynamicObject(1413, -403.146210, 2269.861816, 42.020000, 0.000000, -3.000000, -168.720001, -1, -1);
            GlobalObject terrz55 = new GlobalObject(1413, new Vector3(-403.146210, 2269.861816, 42.020000), new Vector3(0.000000, -3.000000, -168.720001), 300.0f);

            //CreateDynamicObject(1357, -412.239990, 2260.010010, 41.700001, 0.000000, 0.000000, 211.509995, -1, -1);
            GlobalObject terrz56 = new GlobalObject(1357, new Vector3(-412.239990, 2260.010010, 41.700001), new Vector3(0.000000, 0.000000, 211.509995), 300.0f);

            //CreateDynamicObject(1773, -426.992859, 2245.875244, 42.170799, 0.000000, 0.000000, 93.480003, -1, -1);
            GlobalObject terrz57 = new GlobalObject(1773, new Vector3(-426.992859, 2245.875244, 42.170799), new Vector3(0.000000, 0.000000, 93.480003), 300.0f);

            //CreateDynamicObject(734, -454.487274, 2203.406250, 41.245300, 0.000000, 0.000000, 75.959999, -1, -1);
            GlobalObject terrz58 = new GlobalObject(734, new Vector3(-454.487274, 2203.406250, 41.245300), new Vector3(0.000000, 0.000000, 75.959999), 300.0f);
            
            fso_map = CreateDynamicObject(19993, -440.157104, 2227.749023, 42.093102, 0.000000, 0.000000, 0.000000, -1, -1);
            SetDynamicObjectMaterial(fso_map, 0, 1453, "break_farm", "CJ_HAY", 0);
            
            GlobalObject terrztexture1 = new GlobalObject(19993, new Vector3(-440.157104, 2227.749023, 42.093102), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            terrztexture1.SetMaterial(0, 1453, "break_farm", "CJ_HAY", 0);
            //CreateDynamicObject(1412, -408.233704, 2268.669922, 42.222000, 0.000000, 2.000000, 13.440000, -1, -1);
            GlobalObject terrz59 = new GlobalObject(1412, new Vector3(-408.233704, 2268.669922, 42.222000), new Vector3(0.000000, 2.000000, 13.440000), 300.0f);

            //CreateDynamicObject(874, -418.134888, 2257.813477, 41.343498, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz60 = new GlobalObject(874, new Vector3(-418.134888, 2257.813477, 41.343498), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(735, -487.959991, 2052.689941, 58.790001, 0.000000, 0.000000, 155.449997, -1, -1);
            GlobalObject terrz61 = new GlobalObject(735, new Vector3(-487.959991, 2052.689941, 58.790001), new Vector3(0.000000, 0.000000, 155.449997), 300.0f);

            //CreateDynamicObject(1412, -413.331085, 2267.335693, 42.438000, 10.000000, 2.000000, 12.240000, -1, -1);
            GlobalObject terrz62 = new GlobalObject(1412, new Vector3(-413.331085, 2267.335693, 42.438000), new Vector3(10.000000, 2.000000, 12.240000), 300.0f);

            //CreateDynamicObject(1327, -448.280914, 2221.588623, 42.185398, 10.000000, -20.000000, 0.000000, -1, -1);
            GlobalObject terrz63 = new GlobalObject(1327, new Vector3(-448.280914, 2221.588623, 42.185398), new Vector3(10.000000, -20.000000, 0.000000), 300.0f);

            //CreateDynamicObject(3425, -465.040009, 2188.820068, 55.279999, 356.859985, 20.000000, 260.149994, -1, -1);
            GlobalObject terrz64 = new GlobalObject(3425, new Vector3(-465.040009, 2188.820068, 55.279999), new Vector3(356.859985, 20.000000, 260.149994), 300.0f);

            //CreateDynamicObject(1447, -418.463104, 2266.498535, 42.653999, 0.000000, 0.000000, 190.020096, -1, -1);
            GlobalObject terrz65 = new GlobalObject(1447, new Vector3(-418.463104, 2266.498535, 42.653999), new Vector3(0.000000, 0.000000, 190.020096), 300.0f);

            //CreateDynamicObject(874, -419.649994, 2269.389893, 40.639999, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz66 = new GlobalObject(874, new Vector3(-419.649994, 2269.389893, 40.639999), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(1412, -423.561707, 2265.309326, 42.653999, 0.000000, 0.000000, 13.440000, -1, -1);
            GlobalObject terrz67 = new GlobalObject(1412, new Vector3(-423.561707, 2265.309326, 42.653999), new Vector3(0.000000, 0.000000, 13.440000), 300.0f);

            //CreateDynamicObject(1412, -428.696259, 2264.114014, 42.653999, 0.000000, 0.000000, 13.440000, -1, -1);
            GlobalObject terrz68 = new GlobalObject(1412, new Vector3(-428.696259, 2264.114014, 42.653999), new Vector3(0.000000, 0.000000, 13.440000), 300.0f);

            //CreateDynamicObject(1413, -433.834991, 2263.095459, 42.667999, 0.000000, 0.000000, -168.720001, -1, -1);
            GlobalObject terrz69 = new GlobalObject(1413, new Vector3(-433.834991, 2263.095459, 42.667999), new Vector3(0.000000, 0.000000, -168.720001), 300.0f);

            //CreateDynamicObject(3593, -446.549988, 2248.899902, 41.849998, 0.000000, 0.000000, 331.540009, -1, -1);
            GlobalObject terrz70 = new GlobalObject(3593, new Vector3(-446.549988, 2248.899902, 41.849998), new Vector3(0.000000, 0.000000, 331.540009), 300.0f);

            //CreateDynamicObject(735, -393.279999, 2304.000000, 35.099998, 0.000000, 0.000000, 69.809998, -1, -1);
            GlobalObject terrz71 = new GlobalObject(735, new Vector3(-393.279999, 2304.000000, 35.099998), new Vector3(0.000000, 0.000000, 69.809998), 300.0f);

            //CreateDynamicObject(1412, -441.743103, 2256.155273, 41.466000, 90.000000, 0.000000, 39.600010, -1, -1);
            GlobalObject terrz72 = new GlobalObject(1412, new Vector3(-441.743103, 2256.155273, 41.466000), new Vector3(90.000000, 0.000000, 39.600010), 300.0f);

            //CreateDynamicObject(1413, -438.426605, 2260.921631, 42.667999, 0.000000, 0.000000, -139.800156, -1, -1);
            GlobalObject terrz73 = new GlobalObject(1413, new Vector3(-438.426605, 2260.921631, 42.667999), new Vector3(0.000000, 0.000000, -139.800156), 300.0f);

            //CreateDynamicObject(874, -440.200012, 2260.469971, 40.750000, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz74 = new GlobalObject(874, new Vector3(-440.200012, 2260.469971, 40.750000), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(734, -435.902496, 2266.051270, 41.184101, 0.000000, 0.000000, 0.000000, -1, -1);
            GlobalObject terrz75 = new GlobalObject(734, new Vector3(-435.902496, 2266.051270, 41.184101), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);

            //CreateDynamicObject(850, -450.648102, 2249.116211, 41.530399, 0.000000, 0.000000, 51.180000, -1, -1);
            GlobalObject terrz76 = new GlobalObject(850, new Vector3(-450.648102, 2249.116211, 41.530399), new Vector3(0.000000, 0.000000, 51.180000), 300.0f);

            //CreateDynamicObject(1412, -449.074127, 2253.392090, 41.466000, 90.000000, 0.000000, -9.119990, -1, -1);
            GlobalObject terrz77 = new GlobalObject(1412, new Vector3(-449.074127, 2253.392090, 41.466000), new Vector3(90.000000, 0.000000, -9.119990), 300.0f);

            //CreateDynamicObject(773, -476.390015, 2317.020020, 62.820000, 0.000000, 0.000000, 282.489990, -1, -1);
            GlobalObject terrz78 = new GlobalObject(773, new Vector3(-476.390015, 2317.020020, 62.820000), new Vector3(0.000000, 0.000000, 282.489990), 300.0f);

            //CreateDynamicObject(1265, -397.616211, 2186.191406, 41.695499, 0.000000, 360.000000, 300.000000, -1, -1);
            GlobalObject terrz79 = new GlobalObject(1265, new Vector3(-397.616211, 2186.191406, 41.695499), new Vector3(0.000000, 360.000000, 300.000000), 300.0f);

            //CreateDynamicObject(1666, -366.226807, 2210.822510, 41.636299, 0.000000, 360.000000, 300.000000, -1, -1);
            GlobalObject terrz80 = new GlobalObject(1666, new Vector3(-366.226807, 2210.822510, 41.636299), new Vector3(0.000000, 360.000000, 300.000000), 300.0f);

            //CreateDynamicObject(1950, -394.001587, 2241.227539, 41.912399, 0.000000, 360.000000, 300.000000, -1, -1);
            GlobalObject terrz81 = new GlobalObject(1950, new Vector3(-394.001587, 2241.227539, 41.912399), new Vector3(0.000000, 360.000000, 300.000000), 300.0f);
            */
            //RemoveBuildingForPlayer(playerid, 3425, -466.429688, 2190.273438, 55.992199, 0.250000);
            //  RemoveBuildingForPlayer(playerid, 3396, 275.312500, 1874.242188, 7.750000, 0.250000);
            //GlobalObject.Remove(player, 3396, new Vector3(275.312500f, 1874.242188f, 7.750000f), 0.25f);//

            //Remove Buildings///////////////////////////////////////////////////////////////////////////////////////////////

            //Objects////////////////////////////////////////////////////////////////////////////////////////////////////////
            //tmpobjid = CreateDynamicObject(2206, -171.855133, 1213.638793, 20.030311, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 18065, "ab_sfammumain", "plywood_gym", 0x00000000);
            GlobalObject fkmapp1 = new GlobalObject(2206, new Vector3(-171.855133, 1213.638793, 20.030311), new Vector3(0.000000, 0.000000, 180.000000), 300.0f);
            fkmapp1.SetMaterial(0, 18065, "ab_sfammumain", "plywood_gym", 0);

            //tmpobjid = CreateDynamicObject(19772, -171.973815, 1228.211303, 20.570323, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0x00000000);
            GlobalObject fkmapp2 = new GlobalObject(19772, new Vector3(-171.973815, 1228.211303, 20.570323), new Vector3(0.000000, 0.000000, 180.000000), 300.0f);
            fkmapp2.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0);

            //tmpobjid = CreateDynamicObject(19772, -173.893692, 1228.211303, 20.570323, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0x00000000);
            GlobalObject fkmapp3 = new GlobalObject(19772, new Vector3(-173.893692, 1228.211303, 20.570323), new Vector3(0.000000, 0.000000, 180.000000), 300.0f);
            fkmapp3.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0);

            //tmpobjid = CreateDynamicObject(19772, -172.193939, 1227.350463, 20.310293, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0x00000000);
            GlobalObject fkmapp4 = new GlobalObject(19772, new Vector3(-172.193939, 1227.350463, 20.310293), new Vector3(0.000000, 0.000000, 270.000000), 300.0f);
            fkmapp4.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0);


            //tmpobjid = CreateDynamicObject(19772, -172.913787, 1228.211425, 21.850353, 90.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0x00000000);
            GlobalObject fkmapp5 = new GlobalObject(19772, new Vector3(-172.913787, 1228.211425, 21.850353), new Vector3(90.000000, 0.000000, 180.000000), 300.0f);
            fkmapp5.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0);

            //tmpobjid = CreateDynamicObject(19772, -172.913787, 1228.211425, 23.290380, 90.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0x00000000);
            GlobalObject fkmapp6 = new GlobalObject(19772, new Vector3(-172.913787, 1228.211425, 23.290380), new Vector3(90.000000, 0.000000, 180.000000), 300.0f);
            fkmapp6.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0);

            //tmpobjid = CreateDynamicObject(19772, -173.643798, 1227.350463, 20.310293, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 3967, "cj_airprt", "bigbrick", 0x00000000);
            GlobalObject fkmapp7 = new GlobalObject(19772, new Vector3(-173.643798, 1227.350463, 20.310293), new Vector3(0.000000, 0.000000, 270.000000), 300.0f);
            fkmapp7.SetMaterial(0, 3967, "cj_airprt", "bigbrick", 0);

            //tmpobjid = CreateDynamicObject(2206, -177.135025, 1220.840820, 20.030311, 0.000000, 0.000000, 450.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 18065, "ab_sfammumain", "plywood_gym", 0x00000000);
            GlobalObject fkmapp8 = new GlobalObject(2206, new Vector3(-177.135025, 1220.840820, 20.030311), new Vector3(0.000000, 0.000000, 450.000000), 300.0f);
            fkmapp8.SetMaterial(0, 18065, "ab_sfammumain", "plywood_gym", 0);

            //tmpobjid = CreateDynamicObject(19439, -193.225280, 1219.755493, 19.832208, 0.000000, 90.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 10871, "blacksky_sfse", "ws_altz_wall7_top", 0x00000000);
            GlobalObject fkmapp9 = new GlobalObject(19439, new Vector3(-193.225280, 1219.755493, 19.832208), new Vector3(0.000000, 90.000000, -90.000000), 300.0f);
            fkmapp9.SetMaterial(0, 18065, "ab_sfammumain", "plywood_gym", 0);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //tmpobjid = CreateDynamicObject(18267, -172.907287, 1219.782592, 19.952186, 0.000000, 0.000000, 0.300039, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp10 = new GlobalObject(18267, new Vector3(-172.907287, 1219.782592, 19.952186), new Vector3(0.000000, 0.000000, 0.300039), 300.0f);

            //tmpobjid = CreateDynamicObject(929, -168.808151, 1215.007446, 20.830327, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp11 = new GlobalObject(929, new Vector3(-168.808151, 1215.007446, 20.830327), new Vector3(0.000000, 0.000000, 0.0), 300.0f);

            //tmpobjid = CreateDynamicObject(2509, -172.198272, 1213.011596, 21.990322, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp12 = new GlobalObject(2509, new Vector3(-172.198272, 1213.011596, 21.990322), new Vector3(0.000000, 0.000000, 180.000000), 300.0f);

            //tmpobjid = CreateDynamicObject(2509, -173.508346, 1213.011596, 21.990322, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp13 = new GlobalObject(2509, new Vector3(-173.508346, 1213.011596, 21.990322), new Vector3(0.000000, 0.000000, 180.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(18635, -172.068420, 1213.864135, 20.943723, 88.400108, -33.000030, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp14 = new GlobalObject(18635, new Vector3(-172.068420, 1213.864135, 20.943723), new Vector3(88.400108, -33.000030, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(18633, -173.514022, 1213.485473, 20.967359, 0.000000, 94.100059, -42.800014, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp15 = new GlobalObject(18633, new Vector3(-173.514022, 1213.485473, 20.967359), new Vector3(0.000000, 94.100059, -42.800014), 300.0f);
            //tmpobjid = CreateDynamicObject(2048, -177.588012, 1218.329833, 22.360328, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp16 = new GlobalObject(2048, new Vector3(-177.588012, 1218.329833, 22.360328), new Vector3(0.000000, 0.000000, 90.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(2587, -176.432922, 1213.051635, 22.140314, 0.000000, 11.499984, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp17 = new GlobalObject(2587, new Vector3(-176.432922, 1213.051635, 22.140314), new Vector3(0.000000, 11.499984, 180.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(18688, -173.010620, 1227.851562, 18.750282, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp18 = new GlobalObject(18688, new Vector3(-173.010620, 1227.851562, 18.750282), new Vector3(0.0, 0.0, 0.0), 300.0f);
            //tmpobjid = CreateDynamicObject(18634, -172.385330, 1227.207153, 20.931745, -1.600004, 94.400001, 38.300022, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp19 = new GlobalObject(18634, new Vector3(-172.385330, 1227.207153, 20.931745), new Vector3(-1.600004, 94.400001, 38.300022), 300.0f);
            //tmpobjid = CreateDynamicObject(19573, -173.887847, 1226.703613, 20.031082, -2.200000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp20 = new GlobalObject(19573, new Vector3(-173.887847, 1226.703613, 20.031082), new Vector3(-2.200000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(3035, -168.841079, 1227.719970, 20.730327, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp21 = new GlobalObject(3035, new Vector3(-168.841079, 1227.719970, 20.730327), new Vector3(0.000000, 0.000000, -90.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19626, -169.884216, 1228.775146, 20.797676, -15.800000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp22 = new GlobalObject(19626, new Vector3(-169.884216, 1228.775146, 20.797676), new Vector3(-15.800000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19815, -177.596908, 1221.810302, 21.830352, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);

            GlobalObject fkmapp23 = new GlobalObject(19815, new Vector3(-177.596908, 1221.810302, 21.830352), new Vector3(0.000000, 0.000000, 90.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(1413, -132.562194, 1231.007080, 18.865201, -90.000000, 32.400001, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp24 = new GlobalObject(1413, new Vector3(-132.562194, 1231.007080, 18.865201), new Vector3(-90.000000, 32.400001, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(13591, -154.100234, 1234.181640, 19.052194, 0.000000, 0.000000, 9.400005, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp25 = new GlobalObject(13591, new Vector3(-154.100234, 1234.181640, 19.052194), new Vector3(0.000000, 0.000000, 9.400005), 300.0f);
            //tmpobjid = CreateDynamicObject(3593, -170.829849, 1232.379150, 19.212198, 0.000000, 0.000000, 98.999954, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp26 = new GlobalObject(3593, new Vector3(-170.829849, 1232.379150, 19.212198), new Vector3(0.000000, 0.000000, 98.999954), 300.0f);
            //tmpobjid = CreateDynamicObject(1463, -158.945632, 1226.081542, 19.052190, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp27 = new GlobalObject(1463, new Vector3(-158.945632, 1226.081542, 19.052190), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(12957, -146.348022, 1234.565673, 19.252193, 0.000000, 0.000000, 30.999998, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp28 = new GlobalObject(12957, new Vector3(-146.348022, 1234.565673, 19.252193), new Vector3(0.000000, 0.000000, 30.999998), 300.0f);
            //tmpobjid = CreateDynamicObject(1463, -158.945632, 1227.780883, 19.052190, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp29 = new GlobalObject(1463, new Vector3(-158.945632, 1227.780883, 19.052190), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(1463, -158.945632, 1227.000244, 19.292196, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp30 = new GlobalObject(1463, new Vector3(-158.945632, 1227.000244, 19.292196), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(2121, -165.929718, 1215.262329, 20.530323, 0.000000, 0.000000, 153.800064, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp31 = new GlobalObject(2121, new Vector3(-165.929718, 1215.262329, 20.530323), new Vector3(0.000000, 0.000000, 153.800064), 300.0f);
            //tmpobjid = CreateDynamicObject(19905, -210.518676, 1216.525268, 18.702186, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp32 = new GlobalObject(19905, new Vector3(-210.518676, 1216.525268, 18.702186), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(16448, -159.708465, 1225.942260, 22.812276, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp33 = new GlobalObject(16448, new Vector3(), new Vector3(), 300.0f);
            //tmpobjid = CreateDynamicObject(1282, -191.728240, 1205.869873, 19.361406, 0.000000, 0.000000, 142.699981, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp34 = new GlobalObject(1282, new Vector3(-191.728240, 1205.869873, 19.361406), new Vector3(0.000000, 0.000000, 142.699981), 300.0f);
            //tmpobjid = CreateDynamicObject(19817, -234.733367, 1216.109985, 18.702186, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp35 = new GlobalObject(19817, new Vector3(-234.733367, 1216.109985, 18.702186), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19872, -223.707260, 1215.260009, 18.823757, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp36 = new GlobalObject(19872, new Vector3(-223.707260, 1215.260009, 18.823757), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19899, -196.773849, 1223.368530, 18.902187, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp37 = new GlobalObject(19899, new Vector3(-196.773849, 1223.368530, 18.902187), new Vector3(0.000000, 0.000000, -90.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19900, -198.384811, 1223.570800, 18.882186, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp38 = new GlobalObject(19900, new Vector3(-198.384811, 1223.570800, 18.882186), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19899, -194.203948, 1223.368530, 18.902187, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp39 = new GlobalObject(19899, new Vector3(-194.203948, 1223.368530, 18.902187), new Vector3(0.000000, 0.000000, -90.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19903, -199.340820, 1223.544555, 18.902187, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp40 = new GlobalObject(19903, new Vector3(-199.340820, 1223.544555, 18.902187), new Vector3(0.000000, 0.000000, -90.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19900, -198.384811, 1223.570800, 18.882186, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp41 = new GlobalObject(19900, new Vector3(-198.384811, 1223.570800, 18.882186), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19815, -192.916748, 1219.778686, 20.600337, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp42 = new GlobalObject(19815, new Vector3(-192.916748, 1219.778686, 20.600337), new Vector3(0.000000, 0.000000, 270.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19906, -214.916839, 1210.147460, 24.383893, -27.000041, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp43 = new GlobalObject(19906, new Vector3(-214.916839, 1210.147460, 24.383893), new Vector3(-27.000041, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(19906, -223.904037, 1208.548950, 22.083766, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp44 = new GlobalObject(19906, new Vector3(-223.904037, 1208.548950, 22.083766), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(1025, -193.036407, 1216.802490, 21.522197, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp45 = new GlobalObject(1025, new Vector3(-193.036407, 1216.802490, 21.522197), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(1025, -193.036407, 1215.332275, 22.692224, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp46 = new GlobalObject(1025, new Vector3(-193.036407, 1215.332275, 22.692224), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(1025, -193.036407, 1213.891967, 21.522197, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp47 = new GlobalObject(1025, new Vector3(-193.036407, 1213.891967, 21.522197), new Vector3(0.000000, 0.000000, 0.000000), 300.0f);
            //tmpobjid = CreateDynamicObject(1025, -193.036407, 1212.242065, 22.692224, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp48 = new GlobalObject(1025, new Vector3(-193.036407, 1212.242065, 22.692224), new Vector3(0.0, 0.0, 0.0), 300.0f);
            //tmpobjid = CreateDynamicObject(1085, -193.317672, 1222.411010, 19.289224, 0.000000, -9.099895, -144.999938, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp49 = new GlobalObject(1085, new Vector3(-193.317672, 1222.411010, 19.289224), new Vector3(0.000000, -9.099895, -144.999938), 300.0f);
            //tmpobjid = CreateDynamicObject(3171, -137.414733, 1225.568847, 18.692186, 0.000000, 0.000000, 40.500000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp50 = new GlobalObject(3171, new Vector3(-137.414733, 1225.568847, 18.692186), new Vector3(0.000000, 0.000000, 40.500000), 300.0f);
            //tmpobjid = CreateDynamicObject(3168, -146.750991, 1228.765747, 18.715198, 0.000000, 0.000000, 83.200057, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp51 = new GlobalObject(3168, new Vector3(-146.750991, 1228.765747, 18.715198), new Vector3(0.000000, 0.000000, 83.200057), 300.0f);
            //tmpobjid = CreateDynamicObject(19632, -143.494338, 1220.778564, 18.742187, 0.000000, 0.000000, -22.100000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp52 = new GlobalObject(19632, new Vector3(-143.494338, 1220.778564, 18.742187), new Vector3(0.000000, 0.000000, -22.100000), 300.0f);
            //tmpobjid = CreateDynamicObject(2121, -142.523391, 1219.660888, 18.995204, 0.000000, -90.000000, -107.000076, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp53 = new GlobalObject(2121, new Vector3(-142.523391, 1219.660888, 18.995204), new Vector3(0.000000, -90.000000, -107.000076), 300.0f);
            //tmpobjid = CreateDynamicObject(2121, -142.321334, 1221.721557, 19.215209, 0.000000, 0.000000, -37.199977, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp54 = new GlobalObject(2121, new Vector3(-142.321334, 1221.721557, 19.215209), new Vector3(0.000000, 0.000000, -37.199977), 300.0f);
            //tmpobjid = CreateDynamicObject(2121, -144.646179, 1221.684326, 19.215209, 0.000000, 0.000000, 31.900020, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject fkmapp55 = new GlobalObject(2121, new Vector3(-144.646179, 1221.684326, 19.215209), new Vector3(0.000000, 0.000000, 31.900020), 300.0f);
            //UP+ FK MAPP 0.1a
            //GLAVA HOUSE FIRST VERSION
            //tmpobjid = CreateDynamicObject(19379, 1338.385009, 1572.716552, 2998.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14777, "int_casinoint3", "GB_midbar05", 0x00000000);
            GlobalObject glavamapp1 = new GlobalObject(19379, new Vector3(1338.385009, 1572.716552, 2998.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp1.SetMaterial(0, 14777, "int_casinoint3", "GB_midbar05", 0);

            //tmpobjid = CreateDynamicObject(19379, 1338.385009, 1582.346557, 2998.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14777, "int_casinoint3", "GB_midbar05", 0x00000000);
            GlobalObject glavamapp2 = new GlobalObject(19379, new Vector3(1338.385009, 1582.346557, 2998.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp2.SetMaterial(0, 14777, "int_casinoint3", "GB_midbar05", 0);

            //tmpobjid = CreateDynamicObject(19379, 1327.892333, 1572.716552, 3003.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4828, "airport3_las", "brwall_128", 0x00000000);
            GlobalObject glavamapp3 = new GlobalObject(19379, new Vector3(1327.892333, 1572.716552, 3003.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp3.SetMaterial(0, 4828, "airport3_las", "brwall_128", 0);

            //tmpobjid = CreateDynamicObject(19379, 1327.892333, 1582.338500, 2998.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14777, "int_casinoint3", "GB_midbar05", 0x00000000);
            GlobalObject glavamapp4 = new GlobalObject(19379, new Vector3(1327.892333, 1582.338500, 2998.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp4.SetMaterial(0, 14777, "int_casinoint3", "GB_midbar05", 0);

            //tmpobjid = CreateDynamicObject(19379, 1336.059204, 1586.072021, 2998.919433, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 30.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp5 = new GlobalObject(19379, new Vector3(1336.059204, 1586.072021, 2998.919433), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            glavamapp5.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1338.385009, 1572.716552, 3003.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 30.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4828, "airport3_las", "brwall_128", 0x00000000);
            GlobalObject glavamapp6 = new GlobalObject(19379, new Vector3(1338.385009, 1572.716552, 3003.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp6.SetMaterial(0, 4828, "airport3_las", "brwall_128", 0);

            //tmpobjid = CreateDynamicObject(19379, 1338.385009, 1582.346557, 3003.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4828, "airport3_las", "brwall_128", 0x00000000);
            GlobalObject glavamapp7 = new GlobalObject(19379, new Vector3(1338.385009, 1582.346557, 3003.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp7.SetMaterial(0, 4828, "airport3_las", "brwall_128", 0);

            //tmpobjid = CreateDynamicObject(19379, 1327.892333, 1572.716552, 2998.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14777, "int_casinoint3", "GB_midbar05", 0x00000000);
            GlobalObject glavamapp8 = new GlobalObject(19379, new Vector3(1327.892333, 1572.716552, 2998.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp8.SetMaterial(0, 14777, "int_casinoint3", "GB_midbar05", 0);

            //tmpobjid = CreateDynamicObject(19379, 1326.429199, 1568.072021, 2998.919433, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp9 = new GlobalObject(19379, new Vector3(1326.429199, 1568.072021, 2998.919433), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            glavamapp9.SetMaterial(0, 14777, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1327.892333, 1582.338500, 3003.919433, 0.000000, 90.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4828, "airport3_las", "brwall_128", 0x00000000);
            GlobalObject glavamapp10 = new GlobalObject(19379, new Vector3(1327.892333, 1582.338500, 3003.919433), new Vector3(0.000000, 90.000000, 0.000000), 30.0f);
            glavamapp10.SetMaterial(0, 4828, "airport3_las", "brwall_128", 0);

            //tmpobjid = CreateDynamicObject(19379, 1326.429199, 1586.072021, 2998.919433, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp11 = new GlobalObject(19379, new Vector3(1326.429199, 1586.072021, 2998.919433), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            glavamapp11.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1336.059204, 1568.072021, 2998.919433, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp12 = new GlobalObject(19379, new Vector3(1336.059204, 1568.072021, 2998.919433), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            glavamapp12.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1322.892333, 1572.716552, 2998.919433, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp13 = new GlobalObject(19379, new Vector3(1322.892333, 1572.716552, 2998.919433), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            glavamapp13.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1322.892333, 1582.338500, 2998.919433, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp14 = new GlobalObject(19379, new Vector3(1322.892333, 1582.338500, 2998.919433), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            glavamapp14.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1340.892333, 1582.338500, 2998.919433, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp15 = new GlobalObject(19379, new Vector3(1340.892333, 1582.338500, 2998.919433), new Vector3(0.0, 0.0, 0.0), 30.0f);
            glavamapp15.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1340.892333, 1572.716552, 2998.919433, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp16 = new GlobalObject(19379, new Vector3(1340.892333, 1572.716552, 2998.919433), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            glavamapp16.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(19379, 1324.880615, 1569.620605, 2998.919433, 0.000000, 0.000000, 45.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 4830, "airport2", "brnstucco1", 0x00000000);
            GlobalObject glavamapp17 = new GlobalObject(19379, new Vector3(1324.880615, 1569.620605, 2998.919433), new Vector3(0.000000, 0.000000, 45.000000), 30.0f);
            glavamapp17.SetMaterial(0, 4830, "airport2", "brnstucco1", 0);

            //tmpobjid = CreateDynamicObject(3034, 1330.667602, 1568.170288, 3001.087402, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14383, "burg_1", "kit_windo_12", 0x00000000);
            GlobalObject glavamapp18 = new GlobalObject(3034, new Vector3(1330.667602, 1568.170288, 3001.087402), new Vector3(0.000000, 0.000000, 180.000000), 30.0f);
            glavamapp18.SetMaterial(0, 14383, "burg_1", "kit_windo_12", 0);

            //tmpobjid = CreateDynamicObject(3034, 1337.277954, 1568.160278, 3001.087402, 0.000000, 0.000000, 180.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14383, "burg_1", "kit_windo_12", 0x00000000);
            GlobalObject glavamapp19 = new GlobalObject(3034, new Vector3(1337.277954, 1568.160278, 3001.087402), new Vector3(0.000000, 0.000000, 180.000000), 30.0f);
            glavamapp19.SetMaterial(0, 14383, "burg_1", "kit_windo_12", 0);

            //tmpobjid = CreateDynamicObject(3034, 1322.995117, 1575.552490, 3001.087402, 0.000000, 0.000000, 450.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14383, "burg_1", "kit_windo_12", 0x00000000);
            GlobalObject glavamapp20 = new GlobalObject(3034, new Vector3(1322.995117, 1575.552490, 3001.087402), new Vector3(0.000000, 0.000000, 450.000000), 30.0f);
            glavamapp20.SetMaterial(0, 14383, "burg_1", "kit_windo_12", 0);

            //tmpobjid = CreateDynamicObject(3034, 1322.995117, 1581.992431, 3001.087402, 0.000000, 0.000000, 450.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 14383, "burg_1", "kit_windo_12", 0x00000000);
            GlobalObject glavamapp21 = new GlobalObject(3034, new Vector3(1322.995117, 1581.992431, 3001.087402), new Vector3(0.000000, 0.000000, 450.000000), 30.0f);
            glavamapp21.SetMaterial(0, 14383, "burg_1", "kit_windo_12", 0);

            //tmpobjid = CreateDynamicObject(2366, 1336.479003, 1581.258178, 2998.544921, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //SetDynamicObjectMaterial(tmpobjid, 0, 1355, "break_s_bins", "CJ_WOOD_DARK", 0x00000000);
            //SetDynamicObjectMaterial(tmpobjid, 1, 1355, "break_s_bins", "CJ_WOOD_DARK", 0x00000000);
            GlobalObject glavamapp22 = new GlobalObject(2366, new Vector3(1336.479003, 1581.258178, 2998.544921), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            glavamapp22.SetMaterial(0, 1355, "break_s_bins", "CJ_WOOD_DARK", 0);
            glavamapp22.SetMaterial(0, 1355, "break_s_bins", "CJ_WOOD_DARK", 0);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //tmpobjid = CreateDynamicObject(1535, 1323.655883, 1570.894409, 2999.005371, 0.000000, 0.000000, -45.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv1 = new GlobalObject(1535, new Vector3(1323.655883, 1570.894409, 2999.005371), new Vector3(0.000000, 0.000000, -45.000000), 30.0f); // - це так должно выгладеть          
                                                                                                                                                                       //tmpobjid = CreateDynamicObject(1535, 1325.815185, 1568.777587, 2999.005371, 0.000000, 0.000000, 135.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv2 = new GlobalObject(1535, new Vector3(1325.815185, 1568.777587, 2999.005371), new Vector3(0.000000, 0.000000, 135.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(16779, 1331.728881, 1577.794433, 3003.949951, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv3 = new GlobalObject(16779, new Vector3(1331.728881, 1577.794433, 3003.949951), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2207, 1335.423217, 1581.524658, 2999.005371, 0.000000, 0.000000, -45.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv4 = new GlobalObject(2207, new Vector3(1335.423217, 1581.524658, 2999.005371), new Vector3(0.000000, 0.000000, -45.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2207, 1338.090209, 1581.586181, 2999.005371, 0.000000, 0.000000, 495.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv5 = new GlobalObject(2207, new Vector3(1338.090209, 1581.586181, 2999.005371), new Vector3(0.000000, 0.000000, 495.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1671, 1338.528564, 1583.486450, 2999.415771, 0.000000, 0.000000, -32.699985, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv6 = new GlobalObject(1671, new Vector3(1338.528564, 1583.486450, 2999.415771), new Vector3(0.000000, 0.000000, -32.699985), 30.0f);
            //tmpobjid = CreateDynamicObject(2309, 1336.274291, 1579.074707, 2998.995361, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv7 = new GlobalObject(2309, new Vector3(1336.274291, 1579.074707, 2998.995361), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2309, 1334.570312, 1580.773803, 2998.995361, 0.000000, 0.000000, -71.599899, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv8 = new GlobalObject(2309, new Vector3(1334.570312, 1580.773803, 2998.995361), new Vector3(0.000000, 0.000000, -71.599899), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1339.877075, 1585.515502, 2998.995361, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv9 = new GlobalObject(2007, new Vector3(1339.877075, 1585.515502, 2998.995361), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1340.347534, 1585.025024, 2998.995361, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv10 = new GlobalObject(2007, new Vector3(1340.347534, 1585.025024, 2998.995361), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1338.896118, 1585.515502, 2998.995361, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv11 = new GlobalObject(2007, new Vector3(1338.896118, 1585.515502, 2998.995361), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1338.896118, 1585.515502, 3000.395263, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv12 = new GlobalObject(2007, new Vector3(1338.896118, 1585.515502, 3000.395263), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1339.877075, 1585.515502, 3000.395263, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv13 = new GlobalObject(2007, new Vector3(1339.877075, 1585.515502, 3000.395263), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1340.347534, 1585.025024, 3000.395263, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv14 = new GlobalObject(2007, new Vector3(1340.347534, 1585.025024, 3000.395263), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1340.347534, 1584.024047, 2998.995361, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv15 = new GlobalObject(2007, new Vector3(1340.347534, 1584.024047, 2998.995361), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2007, 1340.347534, 1584.024047, 3000.395263, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv16 = new GlobalObject(2007, new Vector3(1340.347534, 1584.024047, 3000.395263), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2111, 1326.589355, 1578.987060, 2999.335693, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv17 = new GlobalObject(2111, new Vector3(1326.589355, 1578.987060, 2999.335693), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1723, 1324.765502, 1578.014404, 2998.985351, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv18 = new GlobalObject(1723, new Vector3(1324.765502, 1578.014404, 2998.985351), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1724, 1326.038085, 1581.132934, 2998.995361, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv19 = new GlobalObject(1724, new Vector3(1326.038085, 1581.132934, 2998.995361), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2258, 1323.001342, 1578.817138, 3001.167480, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv20 = new GlobalObject(2258, new Vector3(1323.001342, 1578.817138, 3001.167480), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1723, 1328.318481, 1580.014892, 2998.985351, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv21 = new GlobalObject(1723, new Vector3(1328.318481, 1580.014892, 2998.985351), new Vector3(0.000000, 0.000000, 270.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2801, 1326.480834, 1579.095947, 2999.395751, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappv22 = new GlobalObject(2801, new Vector3(1326.480834, 1579.095947, 2999.395751), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2161, 1337.541870, 1585.966552, 2999.005371, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            //ZONA Z
            GlobalObject glavamappz1 = new GlobalObject(2161, new Vector3(1337.541870, 1585.966552, 2999.005371), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2161, 1337.541870, 1585.966552, 3000.356689, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz2 = new GlobalObject(2161, new Vector3(1337.541870, 1585.966552, 3000.356689), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1742, 1336.116577, 1586.089355, 2999.005371, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz3 = new GlobalObject(1742, new Vector3(1336.116577, 1586.089355, 2999.005371), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2161, 1334.760742, 1585.966552, 2999.005371, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz4 = new GlobalObject(2161, new Vector3(1334.760742, 1585.966552, 2999.005371), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2167, 1340.785888, 1583.020019, 2998.965332, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz5 = new GlobalObject(2167, new Vector3(1340.785888, 1583.020019, 2998.965332), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2167, 1340.785888, 1581.768798, 2998.965332, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz6 = new GlobalObject(2167, new Vector3(1340.785888, 1581.768798, 2998.965332), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2167, 1340.785888, 1583.020019, 3000.476806, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz7 = new GlobalObject(2167, new Vector3(1340.785888, 1583.020019, 3000.476806), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2167, 1340.785888, 1581.768798, 3000.476806, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz8 = new GlobalObject(2167, new Vector3(1340.785888, 1581.768798, 3000.476806), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2036, 1340.593872, 1582.423583, 2999.552490, 0.000000, -68.800018, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz9 = new GlobalObject(2036, new Vector3(1340.593872, 1582.423583, 2999.552490), new Vector3(0.000000, -68.800018, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1669, 1336.887939, 1582.615844, 2999.936279, 0.000000, 0.000000, 25.699998, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz10 = new GlobalObject(1669, new Vector3(1336.887939, 1582.615844, 2999.936279), new Vector3(0.000000, 0.000000, 25.699998), 30.0f);
            //tmpobjid = CreateDynamicObject(19818, 1336.997924, 1582.343750, 2999.866210, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz11 = new GlobalObject(19818, new Vector3(1336.997924, 1582.343750, 2999.866210), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(19893, 1337.688110, 1582.085449, 2999.786132, 0.000000, 0.000000, 170.500015, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz12 = new GlobalObject(19893, new Vector3(1337.688110, 1582.085449, 2999.786132), new Vector3(0.000000, 0.000000, 170.500015), 30.0f);
            //tmpobjid = CreateDynamicObject(2674, 1336.545532, 1583.177490, 2999.015380, 0.000000, 0.000000, -24.200016, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz13 = new GlobalObject(2674, new Vector3(1336.545532, 1583.177490, 2999.015380), new Vector3(0.000000, 0.000000, -24.200016), 30.0f);
            //tmpobjid = CreateDynamicObject(11705, 1336.472656, 1582.508911, 2999.746093, 0.000000, 0.000000, 110.699996, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz14 = new GlobalObject(11705, new Vector3(1336.472656, 1582.508911, 2999.746093), new Vector3(0.000000, 0.000000, 110.699996), 30.0f);
            //tmpobjid = CreateDynamicObject(2256, 1339.139770, 1585.963623, 3002.739013, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz15 = new GlobalObject(2256, new Vector3(1339.139770, 1585.963623, 3002.739013), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2204, 1340.817016, 1580.841552, 2999.005371, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz16 = new GlobalObject(2204, new Vector3(1340.817016, 1580.841552, 2999.005371), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(2253, 1340.596191, 1581.000488, 3001.047363, 0.000000, 0.000000, -16.599998, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz17 = new GlobalObject(2253, new Vector3(1340.596191, 1581.000488, 3001.047363), new Vector3(0.000000, 0.000000, -16.599998), 30.0f);
            //tmpobjid = CreateDynamicObject(638, 1330.740722, 1568.567871, 2999.625976, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz18 = new GlobalObject(638, new Vector3(1330.740722, 1568.567871, 2999.625976), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(638, 1337.341674, 1568.567871, 2999.625976, 0.000000, 0.000000, 90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz19 = new GlobalObject(638, new Vector3(1337.341674, 1568.567871, 2999.625976), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1713, 1337.076293, 1573.350219, 2999.005371, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz20 = new GlobalObject(1713, new Vector3(1337.076293, 1573.350219, 2999.005371), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1713, 1334.194580, 1571.668701, 2999.005371, 0.000000, 0.000000, 90.000000, objct_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz21 = new GlobalObject(1713, new Vector3(1334.194580, 1571.668701, 2999.005371), new Vector3(0.000000, 0.000000, 90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(19786, 1340.857910, 1572.564575, 3001.247558, 0.000000, 0.000000, -90.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz22 = new GlobalObject(19786, new Vector3(1340.857910, 1572.564575, 3001.247558), new Vector3(0.000000, 0.000000, -90.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(1814, 1339.769165, 1573.057495, 2998.975341, 0.000000, 0.000000, 270.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz23 = new GlobalObject(1814, new Vector3(1339.769165, 1573.057495, 2998.975341), new Vector3(0.000000, 0.000000, 270.000000), 30.0f);
            //tmpobjid = CreateDynamicObject(18075, 1331.966796, 1577.373657, 3003.880126, 0.000000, 0.000000, 0.000000, object_world, object_int, -1, 300.00, 300.00);
            GlobalObject glavamappz24 = new GlobalObject(18075, new Vector3(1331.966796, 1577.373657, 3003.880126), new Vector3(0.000000, 0.000000, 0.000000), 30.0f);
            

        }
    }
}
