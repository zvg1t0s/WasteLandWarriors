using SampSharp.GameMode;
using SampSharp.GameMode.SAMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Others;

namespace WasteLandWarriors.WorldObjects
{
    internal class WorldLootSpawnpoints
    {
        public static int Idd = 0;
        int Id {  get; set; }
        public SampSharp.GameMode.Vector3 Position { get; set; }

        public string Description { get; set; }
        public int VirtualWorld { get;set; }

        public List<Loot> lootPool{ get; set; }

        public static List<WorldLootSpawnpoints> lootSpawns = new List<WorldLootSpawnpoints>();

        public static List<Loot> streetLoots = new List<Loot>();
        
        public static List<Loot> hospitalLoots = new List<Loot>();

        public static List<Loot> natureLoots = new List<Loot>();

        public WorldLootSpawnpoints(Vector3 pos, string desc, int vw, List<Loot> lootPool)
        {
            Idd++;
            Id = Idd;

            Position = pos;
            Description = desc;
            VirtualWorld = vw;

            this.lootPool = lootPool;
        }
        public static void CategoriesCreate()
        {
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Коробка"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Водка"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Дрова"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Спички"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Бутылка воды"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Банка газировки"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Сигареты"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Хлеб"));
            streetLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Сухпаёк"));

            hospitalLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Бинт"));
            hospitalLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Аптечка"));

            natureLoots.Add(Loot.loots.FirstOrDefault(l => l.Name == "Дрова"));
        }
        public static void Create()
        {

            CategoriesCreate();

            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(318.62314, 1146.3755, 8.5859375), "ангар ферма 1", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(314.94275, 1146.4631, 8.5859375), "ангар ферма 2",0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(312.06485, 1146.1653, 8.5859375), "ангар ферма 3",0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(301.14612, 1144.3557, 9.1374855), "у двери дома на ферме",0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1349.5199, 1519.7617, 3001.0913), "болька на тумбе",1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1351.1698, 1529.4872, 3000.5916), "болька на трупе 1",1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1352.5359, 1531.277, 3000.6172), "болька на трупе 2",1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1345.1202, 1529.9883, 3001.1665), "болька на столе 1" ,1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1342.1926, 1531.0657, 3001.1665), "болька на столе 2", 1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1334.5996, 1531.5676, 3000.9724), "На дальней каталке",1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1346.81, 1511.9468, 2999.5967), "болька на упавшем автомате с едой", 1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1340.8671, 1511.3815, 2999.2869), "болька на кресле", 1011, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1347.4851, 1526.1783, 3000.2446), "болька на полу 1", 1011, hospitalLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1341.1509, 1518.3593, 3000.3877), "болька на палете", 1011, streetLoots));
            //(114,024475, 802,7457, 32,021255) sniperposboxfront
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(114.024475, 802.7457, 32.021255), "НА КОРОБКЕ ", 0, streetLoots));

            //(112,90884, 803,1611, 32,021255) sniperposboxback
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(112.90884, 803.1611, 32.021255), "НА КОРОБКЕ 2", 0, streetLoots));

            //(110,029785, 799,7383, 31,590155) sniperposboxbed
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(110.029785, 799.7383, 31.590155), "на кровати снайпера", 0, streetLoots));

            //(112,96947, 799,6617, 31,115517) sniperposboxnearsniper
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(112.96947, 799.6617, 31.115517), "у снайперки", 0, streetLoots));
            //(110,09682, 803,4662, 31,115517) sniperposboxnapolu
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(110.09682, 803.4662, 31.115517), "у коробки на полу", 0, streetLoots));

            //(137,13777, 821,541, 25,343147) nearsniperpostree
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(137.13777, 821.541, 25.343147), "у дерева", 0, natureLoots));

            //(143,13268, 820,68414, 24,497791) nearsniperpostreefall
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(143.13268, 820.68414, 24.497791), "у дерева упавшего", 0, natureLoots));

            //(159,35602, 817,71906, 22,686674) nearsniperpostrock
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(159.35602, 817.71906, 22.686674), "у камня", 0, natureLoots));

            //(174,42224, 782,8591, 21,947048) nearsniperpostartapos
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(174.42224, 782.8591, 21.947048), "у арты", 0, natureLoots));

            //(114,10807, 788,0644, 29,551226) nearsniperposshepki
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(114.10807, 788.0644, 29.551226), "у щепок", 0, natureLoots));

            //(89,61903, 801,5247, 33,080982) treebehindsniperpos
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(89.61903, 801.5247, 33.080982), "за деревом", 0, natureLoots));

            //(641,336, 1244,1533, 13,576939) на дальней зеленой хуйне нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(641.336, 1244.1533, 13.576939), "на дальней зеленой хуйне нз", 0, streetLoots));



            //(639,1341, 1249,0797, 13,576939) на ближней зеленой хуйне нз

            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(639.1341, 1249.0797, 13.576939), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(644,72687, 1257,6484, 14,434885) палет 1 нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(644.72687, 1257.6484, 14.434885), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(637,796, 1253,9738, 14,434885) палет 2 нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(637.796, 1253.9738, 14.434885), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(608,27264, 1288,077, 12,634093) восточный вагон нз 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(608.27264, 1288.077, 12.634093), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(605,1931, 1286,9446, 12,634093) восточный вагон нз 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(605.1931, 1286.9446, 12.634093), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(600,3542, 1276,8599, 13,2541275) северо восток палет 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(600.3542, 1276.8599, 13.2541275), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(586,0144, 1264,0801, 13,174127) северо восток палет ближний
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(586.0144, 1264.0801, 13.174127), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(579,0702, 1258,4912, 11,778058) большая коробка нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(579.0702, 1258.4912, 11.778058), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(577,6112, 1256,5753, 11,778058) большая коробка нз 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(577.6112, 1256.5753, 11.778058), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(579,67926, 1271,9746, 14,514801) на кровати в контейнере нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(579.67926, 1271.9746, 14.514801), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(578,41064, 1270,2201, 14,575062) в контейнере на коробке нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(578.41064, 1270.2201, 14.57506), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(571,0361, 1265,8574, 13,851597) нз на вагоне у конта
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(571.0361, 1265.8574, 13.851597), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(568,2325, 1265,9825, 13,7929125) нз на вагоне у конта 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(568.2325, 1265.9825, 13.7929125), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(513,50775, 1362,7437, 3010,3542) внутри нз спрва от входа
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(513.50775, 1362.7437, 3010.3542), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(513,09357, 1363,4058, 3005,892) под входом внутри нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(513.09357, 1363.4058, 3005.892), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(504,04425, 1363,4058, 3005,892) под входом внутри нз 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(504.04425, 1363.4058, 3005.892), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(510,08762, 1378,5787, 3005,892) у коробок нз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(510.08762, 1378.5787, 3005.892), "на ближней зеленой хуйне нз", 0, streetLoots));

            //(513,198, 1376,2639, 3007,7253) внутри нз на бочках
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(513.198, 1376.2639, 3007.7253), "на ближней зеленой хуйне нз", 0, streetLoots));

            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-981.3906, 2715.7556, 45.867188), "блокпост у трупа", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-962.7901, 2726.865, 46.02295), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-966.18713, 2731.8398, 46.00618), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-964.5709, 2734.056, 46.075058), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-962.51044, 2732.1946, 46.741085), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-953.101, 2734.8843, 46.92286), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-952.6503, 2733.1157, 46.92286), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-949.5188, 2737.3118, 47.00501), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-990.79785, 2716.2441, 46.823765), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-985.3658, 2721.6946, 48.19874), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-983.0317, 2722.9048, 48.19874), "блокпост ", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1044.3408, 2703.5688, 46.98767), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1090.3287, 2699.2622, 46.595222), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1122.5979, 2696.1353, 46.06382), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1149.2905, 2701.9678, 46.9909), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1242.4463, 2692.7346, 50.326897), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1270.3131, 2712.561, 52.619713), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1291.1311, 2705.1345, 51.25989), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1341.8143, 2640.2124, 50.613636), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1399.9028, 2646.6353, 56.759426) , "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1399.9604, 2648.2485, 56.23227), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1400.3727, 2647.7295, 56.216293), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1394.1711, 2642.9832, 56.305096), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1412.7189, 2631.8887, 55.746765), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1411.0343, 2626.5393, 55.6875), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1428.4275, 2643.3845, 55.797127), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1454.9071, 2593.6978, 56.63618), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1494.1603, 2600.1602, 55.804688), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1482.184, 2625.1929, 58.78129), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1482.2952, 2641.8914, 59.55051), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1477.091, 2642.1675, 59.33414), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1479.9828, 2640.4795, 58.787987), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1478.1272, 2635.623, 59.235916), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1479.0723, 2630.397, 59.235916), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1479.3611, 2623.3594, 59.838814), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1473.4926, 2619.9543, 58.78129), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1470.2228, 2629.8901, 58.773438), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1471.4896, 2630.4233, 58.773438), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1463.1987, 2628.6199, 58.773438), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1459.0518, 2622.1606, 58.773438), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1474.1659, 2630.2512, 55.835938) , "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1474.2156, 2624.5752, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1459.4979, 2616.7437, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1460.3771, 2627.0413, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1484.3752, 2607.586, 57.277016), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1519.5862, 2527.4805, 56.423603), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1509.3926, 2526.3845, 56.403603), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1519.4012, 2535.7273, 55.6875), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1489.1412, 2618.3176, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1465.7242, 2608.6199, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1434.1686, 2614.09, 55.835938) , "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1480.3289, 2658.7961, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1513.6909, 2646.7793, 56.17618), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1523.031, 2639.3682, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1527.4773, 2629.0154, 56.715965), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1527.3142, 2644.4883, 57.110313), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1534.7821, 2659.952, 56.28136), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1532.9381, 2659.0127, 56.28136), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1532.7267, 2654.9282, 56.79673), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1561.6808, 2647.8743, 56.467777), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1572.4153, 2653.3123, 56.688835), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1561.294, 2623.3062, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1522.469, 2571.5728, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1515.4318, 2568.3625, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1516.0958, 2572.593, 55.835938), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1451.6544, 2690.722, 56.17618), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1482.4619, 2701.6301, 56.254307), "КЕБРАДОС", 0, streetLoots));
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1508.8723, 2696.6802, 56.46854), "КЕБРАДОС", 0, streetLoots));

            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1307.5328, 2700.4585, 52.68809), "просто", 0, streetLoots)); // кведбрадос конты
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1299.7043, 2704.865, 52.68809), "просто", 0, streetLoots)); // кведбрадос конты 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2176.2397, 1585.3215, 999.9724), "просто", 0, streetLoots)); // bk
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(231.45062, 165.79593, 1003.90436), "просто", 1020, streetLoots)); // ресепшн пд кофе
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(229.93164, 145.80533, 1003.0385), "просто", 1020, streetLoots)); // части трупа в пд нижний вход мясо
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(189.6399, 179.82881, 1003.3686), "просто", 1020, streetLoots)); // на трупе у камер
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(192.46863, 179.49628, 1003.3686), "просто", 1020, streetLoots)); // на трупе у камер 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(200.02588, 169.56894, 1003.8229), "просто", 1020, streetLoots)); // на столе у камер 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(207.59554, 164.06401, 1003.02344), "просто", 1020, streetLoots)); // поврежденный вендинговый аппарат в офисе пд, еда снэки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(199.94598, 167.28482, 1003.8229), "просто", 1020, streetLoots)); // на столе у камер 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(203.32025, 157.67719, 1003.02344), "просто", 1020, streetLoots)); // у мусорки у камер пд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(207.7559, 166.08192, 1003.02344), "просто", 1020, streetLoots)); // вендинг аппарат питье газировка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(194.71962, 157.83675, 1003.4778), "просто", 1020, streetLoots)); // у кровати у камер пд 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(191.42865, 157.85168, 1003.4778), "просто", 1020, streetLoots)); // у кровати у камер пд 2
           // lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(207.79726, 161.88188, 1003.02344), "просто", , streetLoots)); // у автомата с газировкой пд 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(291.49075, 185.54767, 1008.1719), "просто", 1020, streetLoots)); // на ресепшене пд сверху
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(294.4744, 180.70424, 1008.1719), "просто", 1020, streetLoots)); // на ресепшене пд сверху 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(272.82608, 174.54732, 1007.6719), "просто", 1020, natureLoots)); // у камней лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(219.96269, 168.79327, 1003.02344), "просто", 1020, streetLoots)); // большой офис пд коробки, мусор какой-нибудь
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(263.97537, 173.16394, 1003.6691), "просто", 1020, streetLoots)); // у кровати лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(241.02779, 159.90215, 1008.2153), "просто", 1020, streetLoots)); // термак пд помпа или тт с маленьким шансом
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(241.65723, 162.41487, 1008.5), "просто", 1020, streetLoots)); // на полке лвпд, сделать y + 0.2 + z 0.3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(241.78671, 165.93137, 1008.7517), "просто", 1020, streetLoots)); // на полке лвпд упавшей для пт
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(247.836, 166.0437, 1006.89294), "просто", 1020, streetLoots)); // на ящике у окна лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(262.54755, 181.66582, 1003.02344), "просто", 1020, streetLoots)); // инвалидное кресло пд алкоголь
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(251.89055, 170.08438, 1008.1547), "просто", 1020, streetLoots)); // на лесах лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(258.04703, 170.12904, 1008.1544), "просто", 1020, streetLoots)); // на лесах лвпд 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(233.63171, 142.13289, 1003.02344), "просто", 1020, streetLoots)); // лвпд мусорка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2308.3538, 2453.6328, 10.826246), "просто", 0, streetLoots)); // лужа крови лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2303.5747, 2432.7114, 10.857087), "просто", 0, streetLoots)); // у пд труп зажатый остовом машины, сырое мясо
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2295.382, 2430.7935, 10.921873), "просто", 0, streetLoots)); // в коробке лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2292.8635, 2429.4146, 10.921873), "просто", 0, streetLoots)); // в коробке лвпд 2 снаружи
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2345.7063, 2432.2126, 8.975645), "просто", 0, streetLoots)); // въезд на парковку остов машины, мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2405.7095, 2411.299, 10.679668), "просто", 0, streetLoots)); // дорога пд текстура машины, мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2427.8398, 2396.5967, 10.671875), "просто", 0, streetLoots)); // дорога пд текстура машины, мусор 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2274.4177, 2421.1658, 11.889439), "просто", 0, streetLoots)); // коробки у пд у ящика
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2267.0396, 2397.513, 10.8203125), "просто", 0, streetLoots)); // развалка лвпд 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2418.836, 2283.4417, 10.8203125), "просто", 0, streetLoots)); // остановка между пд и аммо на секторе в лв. мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2259.465, 2388.2563, 10.8203125), "просто", 0, streetLoots)); // развалка лвпд 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2252.2402, 2381.8013, 10.8203125), "просто", 0, streetLoots)); // развалка лвпд 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2351.5654, 2096.7715, 10.671875), "просто", 0, streetLoots)); // дорога лв просто мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2220.2078, 2364.505, 11.360956), "просто", 0, streetLoots)); // на машинке у лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2120.3152, 2527.353, 10.821539), "просто", 0, streetLoots)); // под парковкой, мусор хз
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2213.059, 2468.19, 10.8203125), "просто", 0, streetLoots)); // под парковкой восточное здание
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2204.0403, 2484.9807, 10.8203125), "просто", 0, streetLoots)); // под парковкой восточное здание 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2176.5598, 2499.3562, 11.363446), "просто", 0, streetLoots)); // под парковкой куча машин
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2094.1245, 2515.6199, 10.819658), "просто", 0, streetLoots)); // под парковкой большое разрушенное здание, обязательно только еда!
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2177.3792, 2477.6384, 11.890173), "просто", 0, streetLoots)); // под парковкой машина
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2070.7715, 2494.817, 10.8203125), "просто", 0, streetLoots)); // под парковкой бомжатник алкоголь
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2068.2927, 2495.0737, 10.8203125), "просто", 0, streetLoots)); // под парковкой бомжатник спички
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2067.9023, 2497.8037, 10.8203125), "просто", 0, streetLoots)); // под парковкой бомжатник еда
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2046.0529, 2508.9265, 10.812967), "просто", 0, streetLoots)); // под парковкой у мостика
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2079.4775, 2519.8103, 17.4792), "просто", 0, streetLoots)); // под парковкой разрушка большая, второй этаж, мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2095.8643, 2521.377, 17.4792), "просто", 0, streetLoots)); // под парковкой разрушка большая, второй этаж, мусор 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2122.767, 2489.3223, 11.192155), "просто", 0, streetLoots)); // под парковкой разрушка большая, грузовик под ним, запчасти или дрова
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2081.61, 2461.908, 10.8203125), "просто", 0, streetLoots)); // под парковкой остановка, мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2096.8633, 2576.1487, 6.8725986), "просто", 0, streetLoots)); // под парковкой шоссе, мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2196.521, 2339.3396, 11.802439), "просто", 0, streetLoots)); // кар у лвпд
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2157.599, 1993.921, 12.525953), "просто", 0, streetLoots)); // lv прицеп у магаза
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2192.5005, 1993.8934, 12.296875), "просто", 0, streetLoots)); // lv у магаза
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2201.3179, 2019.535, 11.299824), "просто", 0, streetLoots)); // lв кар у магаза
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2549.0823, 2103.924, 10.857187), "просто", 0, streetLoots)); // аммо лв в коробке
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2554.1558, 2102.154, 11.89788), "просто", 0, streetLoots)); // аммо лв на коробках
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2611.994, 2094.3699, 10.889314), "просто", 0, streetLoots)); // аммо лв в большой коробке 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2612.0122, 2092.735, 10.889314), "просто", 0, streetLoots)); // аммо лв в большой коробке 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2414.0063, 2151.0012, 11.686529), "просто", 0, streetLoots)); // у казино в центре лв
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2285.352, 2149.767, 11.189865), "просто", 0, streetLoots)); // у казино на палете
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2120.9907, 1813.0468, 11.625562), "просто", 0, streetLoots)); // катушка лв стрип
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2071.2666, 1638.0447, 11.378354), "просто", 0, streetLoots)); // машина стрип 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2067.3774, 1659.3674, 11.392657), "просто", 0, streetLoots)); // машина стрип 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2046.47, 1475.3938, 11.404411), "просто", 0, streetLoots)); // машина стрип 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2072.483, 1286.8735, 10.800251), "просто", 0, streetLoots)); // будка стрип
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2068.7415, 1166.5676, 10.671875), "просто", 0, streetLoots)); // машина стрип 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2079.7825, 1153.0745, 10.8203125), "просто", 0, streetLoots)); // у мусорки стрип
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2114.8994, 914.8442, 11.447286), "просто", 0, streetLoots)); // стрип азс на колонке
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2383.993, 1026.4797, 11.571624), "просто", 0, streetLoots)); // фендер лв
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2429.1648, 1015.7327, 11.561025), "просто", 0, streetLoots)); // фендер лв 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2635.031, 1073.5769, 10.99001), "просто", 0, streetLoots)); // ждлв азс
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2697.307, 1037.7588, 7.800969), "просто", 0, streetLoots)); // ТЮ восток
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2677.5688, 1004.8224, 7.665718), "просто", 0, streetLoots)); // ТЮ восток 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2723.007, 1200.8239, 7.5273385), "просто", 0, streetLoots)); // ТЮ восток 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2710.0864, 1274.4093, 7.531772), "просто", 0, streetLoots)); // ТЮ восток 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2689.076, 1435.8552, 9.291707), "просто", 0, streetLoots)); // ТЮ восток 5
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2725.9475, 1586.9944, 7.4831796), "просто", 0, streetLoots)); // ТЮ восток 6
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2697.635, 2419.764, 7.860465), "просто", 0, streetLoots)); // ТЮ СВ
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2595.1516, 2551.347, 5.515662), "просто", 0, streetLoots)); // ТЮ СВ 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2141.472, 2755.2798, 11.328403), "просто", 0, streetLoots)); // азс север лв
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2134.617, 2837.823, 11.622472), "просто", 0, streetLoots)); // почта лв мусорка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2132.9219, 2846.8853, 10.8203125), "просто", 0, streetLoots)); // почта лв шкаф
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2145.1702, 2832.137, 11.460967), "просто", 0, streetLoots)); // почта лв сделать z -0.1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2141.2915, 2838.128, 11.386204), "просто", 0, streetLoots)); // почта лв шина
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1933.8014, 2734.5134, 10.8203125), "просто", 0, streetLoots)); // север лв
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1808.917, 2716.1055, 11.278477), "просто", 0, streetLoots)); // север лв мотель шина
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1761.2094, 2727.4656, 11.594091), "просто", 0, streetLoots)); // север лв мотель коляска -0.1 з
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1769.1697, 2760.9995, 12.289155), "просто", 0, streetLoots)); // север лв мотель мусорка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1764.2982, 2768.634, 11.354064), "просто", 0, streetLoots)); // север лв мотель шина 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1539.6393, 2721.1604, 11.834831), "просто", 0, streetLoots)); // север лв машина
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1478.7133, 2711.113, 11.228622), "просто", 0, streetLoots)); // север лв шкаф
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1328.2544, 2679.9656, 11.930867), "просто", 0, streetLoots)); // север лв парковка 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1326.6948, 2689.8738, 11.790602), "просто", 0, streetLoots)); // север лв парковка 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1432.0161, 2648.5796, 12.085182), "просто", 0, streetLoots)); // север лв вокзал
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1376.2854, 2716.0176, 12.725772), "просто", 0, streetLoots)); // север лв вокзал мусорка дорога
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1742.08, 2486.1655, 7.371585), "просто", 0, streetLoots)); // ТЮ север автобус
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1724.4028, 2481.6199, 7.7680483), "просто", 0, streetLoots)); // ТЮ север автобус 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1740.7692, 2477.6765, 7.5312405), "просто", 0, streetLoots)); // ТЮ север машины
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1734.507, 2475.1218, 9.054575), "просто", 0, streetLoots)); // ТЮ север машины 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1719.0417, 2470.3826, 7.7172875), "просто", 0, streetLoots)); // ТЮ север машины 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1877.7343, 2525.989, 6.8725986), "просто", 0, streetLoots)); // ТЮ север машины 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1802.5964, 2295.8933, 5.7926006), "просто", 0, streetLoots)); // ТЮЦ трак
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1800.3518, 2143.2222, 4.0294795), "просто", 0, streetLoots)); // ТЮЦ под мостом
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1779.896, 2082.3916, 3.9835403), "просто", 0, streetLoots)); // ТЮЦ под мостом 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1812.7632, 1868.9924, 7.133169), "просто", 0, streetLoots)); // ТЮЦ пикап
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1803.1362, 1862.1923, 7.550708), "просто", 0, streetLoots)); // ТЮЦ кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1792.0626, 1832.3599, 7.4424124), "просто", 0, streetLoots)); // ТЮЦ кар 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1787.1086, 1338.8939, 7.709302), "просто", 0, streetLoots)); // ТЮЦ кар 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1674.9878, 1713.7212, 10.734638), "просто", 0, streetLoots)); // мед лв кар у аэро
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1631.0553, 1826.8994, 11.315764), "просто", 0, streetLoots)); // поддон мед
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1632.0375, 1839.4908, 11.462473), "просто", 0, streetLoots)); // кровать мед снаружи
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1623.0717, 1823.9531, 11.462473), "просто", 0, streetLoots)); // кровать мед снаружи 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1608.1447, 1832.0975, 10.8203125), "просто", 0, streetLoots)); // мед коляска лв
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1596.4021, 1842.9624, 11.9323845), "просто", 0, streetLoots)); // машина мед лв
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1208.5009, 2045.2719, 7.4663987), "просто", 0, streetLoots)); // ШЮ ЗАПАД КАР
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1136.9594, 2451.8452, 11.515993), "просто", 0, streetLoots)); // ШЮ СЕВЕРО ЗАПДА КАР
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1115.023, 2463.0183, 10.59375), "просто", 0, streetLoots)); // ШЮ СЕВЕРО ЗАПАД ТРАК
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1088.5015, 2488.4292, 11.613649), "просто", 0, streetLoots)); // ШЮ СЕВЕРО ЗАПАД КАР 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1081.3862, 2489.071, 11.927134), "просто", 0, streetLoots)); // ШЮ СЕВЕРО ЗАПАД КАР 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1078.474, 2496.3938, 11.359671), "просто", 0, streetLoots)); // ШЮ СЕВЕРО ЗАПАД КАР 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1226.758, 1765.5881, 7.546945), "просто", 0, streetLoots)); // ШЮ запад кар 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1212.6439, 1602.3893, 7.725077), "просто", 0, streetLoots)); // ШЮ запад кар 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1206.8048, 1527.28, 7.730168), "просто", 0, streetLoots)); // ШЮ запад кар 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1206.7317, 1473.646, 7.4997287), "просто", 0, streetLoots)); // ШЮ запад кар 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1209.2546, 1470.4827, 7.9212227), "просто", 0, streetLoots)); // ШЮ запад кар 5
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1230.0664, 1382.1884, 7.753134), "просто", 0, streetLoots)); // ШЮ запад катушка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1173.1284, 1357.7412, 11.723465), "просто", 0, streetLoots)); // ЛВ автошкола стол
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1171.1311, 1353.2722, 10.921875), "просто", 0, streetLoots)); // ЛВ автошкола пол
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1173.7188, 1350.2113, 10.921875), "просто", 0, streetLoots)); // ЛВ автошкола пол 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1208.9491, 1106.9839, 6.8125), "просто", 0, streetLoots)); // ШЮ юго запад трак
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1551.6643, 831.4197, 7.808255), "просто", 0, streetLoots)); // ШЮ юг кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1696.9438, 849.7753, 9.395567), "просто", 0, streetLoots)); // ШЮ юг кар 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1800.6443, 842.7206, 11.354319), "просто", 0, streetLoots)); // ШЮ юг кар 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1800.4874, 840.5083, 11.36424), "просто", 0, streetLoots)); // ШЮ юг кар 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1911.4847, 832.81146, 8.514046), "просто", 0, streetLoots)); // ШЮ юг кар 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2046.4818, 857.0547, 7.678951), "просто", 0, streetLoots)); // ШЮ юг кар 5
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2056.4707, 859.89435, 7.556067), "просто", 0, streetLoots)); // ШЮ юг кар 6
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2064.6904, 849.75226, 7.51858), "просто", 0, streetLoots)); // ШЮ юг кар 7
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2073.6733, 849.4173, 7.304716), "просто", 0, streetLoots)); // ШЮ юг кар 8
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(2090.6733, 852.0631, 7.4240637), "просто", 0, streetLoots)); // ШЮ юг кар 9
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1921.7365, 690.4631, 11.598291), "просто", 0, streetLoots)); // lv мотель юг кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1914.1221, 677.8464, 10.8203125), "просто", 0, streetLoots)); // lv мотель юг железо
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1927.5842, 673.6816, 11.405454), "просто", 0, streetLoots)); // lv мотель юг коробки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1953.0212, 670.2756, 10.8203125), "просто", 0, streetLoots)); // lv мотель юг тумба юмба
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1921.6785, 725.2641, 10.8203125), "просто", 0, streetLoots)); // lv мотель юг коробки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1908.1552, 708.215, 10.852322), "просто", 0, streetLoots)); // lv мотель труп
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1903.7395, 741.4714, 14.2734375), "просто", 0, streetLoots)); // lv мотель трап
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(918.2179, 720.58386, 11.528397), "просто", 0, streetLoots)); // lv кпп кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(916.2278, 704.2028, 12.268388), "просто", 0, streetLoots)); // lv кпп мусорка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(884.2444, 725.53754, 11.721159), "просто", 0, streetLoots)); // lv кпп кары
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(869.5245, 698.98456, 20.144077), "просто", 0, streetLoots)); // lv кпп сверху коробки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(861.59033, 717.7239, 20.144077), "просто", 0, streetLoots)); // lv кпп сверху 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(863.9765, 711.49384, 20.144077), "просто", 0, streetLoots)); // lv кпп сверху 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(706.0154, 661.52795, 10.892444), "просто", 0, streetLoots)); // трасса шахта кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(454.96844, 744.6568, 6.2667303), "просто", 0, streetLoots)); // трасса шахта кар 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(304.1387, 786.7505, 14.344323), "просто", 0, streetLoots)); // мост шахты коробки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(300.7339, 790.20825, 14.186876), "просто", 0, streetLoots)); // мост шахты коробки 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(181.7615, 867.7784, 19.101372), "просто", 0, streetLoots)); // мост шахты кар разьебаный
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(193.07616, 859.0417, 16.675478), "просто", 0, streetLoots)); // мост шахты покрышка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(247.35258, 666.7057, 8.869338), "просто", 0, streetLoots)); // мост шахты трейлер у двери
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(273.84766, 653.6195, 9.840023), "просто", 0, streetLoots)); // мост шахты трейлер на коробке
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(48.31797, 595.2881, 8.454433), "просто", 0, streetLoots)); // машина у реки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-69.41486, 606.1824, 13.455164), "просто", 0, streetLoots)); // трак мост у фк
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-148.8833, 560.7364, 7.2116714), "просто", 0, streetLoots)); // мусорка под мостом фк
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-557.0638, 629.98456, 18.17796), "просто", 0, streetLoots)); // мост лв сф на палете
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-567.19495, 641.945, 19.596695), "просто", 0, streetLoots)); // мост лв сф на траке
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-566.43427, 640.0772, 19.596695), "просто", 0, streetLoots)); // мост лв сф на траке 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-558.83655, 621.5439, 16.99094), "просто", 0, streetLoots)); // мост лв сф в конте 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-657.5683, 654.5044, 16.886423), "просто", 0, streetLoots)); // мост лв сф в каре
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-712.4256, 683.8245, 18.063274), "просто", 0, streetLoots)); // мост лв сф в автобусе
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-733.1708, 692.72894, 18.288567), "просто", 0, streetLoots)); // мост лв сф в автобусе 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-725.84894, 701.64716, 18.292887), "просто", 0, streetLoots)); // мост лв сф на каре 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-841.1888, 958.7089, 25.698193), "просто", 0, streetLoots)); // мост лв сф на каре 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-699.6933, 954.75604, 13.231277), "просто", 0, streetLoots)); // дом торино кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-684.9831, 935.83356, 13.6328125), "просто", 0, streetLoots)); // дом торино 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-691.3012, 941.3851, 14.112077), "просто", 0, streetLoots)); // дом торино 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-661.36597, 879.037, 2.0071335), "просто", 0, streetLoots)); // дом торино порт
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-889.5074, 1251.9563, 34.770847), "просто", 0, streetLoots)); // мост сф коробки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-930.0531, 1201.5272, 34.36429), "просто", 0, streetLoots)); // мост сф кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1129.9097, 1584.174, 21.79104), "просто", 0, streetLoots)); // кар далька 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1123.3905, 1563.2123, 22.238192), "просто", 0, streetLoots)); // ящик далька
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1259.5132, 1721.6699, 16.988173), "просто", 0, streetLoots)); // у трака далька
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1401.8868, 1702.8824, 4.451972), "просто", 0, streetLoots)); // на поддоне далька
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1617.3743, 1836.7377, 25.983128), "просто", 0, streetLoots)); // машина далька
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1487.671, 1865.808, 32.628483), "просто", 0, streetLoots)); // азс кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1245.2458, 1814.5072, 41.759796), "просто", 0, streetLoots)); // далька клакинбел мусорка дорога
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1206.4329, 1821.9144, 42.39584), "просто", 0, streetLoots)); // далька клакинбел палет
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1209.5604, 1834.505, 42.47896), "просто", 0, streetLoots)); // далька клакинбел ящик z -0.2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1209.6539, 1841.876, 43.238945), "просто", 0, streetLoots)); // далька клакинбел мусорка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1353.662, 2067.3984, 53.394238), "просто", 0, streetLoots)); // далька рабачка кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1353.3239, 2055.4136, 53.117188), "просто", 0, streetLoots)); // далька рабачка у входа
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1353.2812, 2059.7808, 53.26576), "просто", 0, streetLoots)); // далька рабачка у входа 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1425.8306, 2171.6184, 50.625), "просто", 0, streetLoots)); // далька какой-то домик
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1356.4901, 2157.2434, 48.038155), "просто", 0, streetLoots)); // далька мусор у моста рыбака
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1513.666, 1967.9755, 48.970314), "просто", 0, streetLoots)); // далька мясник кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1502.0667, 1961.1724, 49.023438), "просто", 0, streetLoots)); // далька мясник у входа
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1511.9542, 1972.5585, 48.421875), "просто", 0, streetLoots)); // далька мясник амбар для мяса
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1510.977, 1975.8541, 48.421875), "просто", 0, streetLoots)); // далька мясник амбар для мяса 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1503.8191, 1974.7526, 48.421875), "просто", 0, streetLoots)); // далька мясник амбар для мяса 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1504.14, 1978.3716, 48.421875), "просто", 0, streetLoots)); // далька мясник амбар для мяса 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1940.1183, 2389.9216, 49.492188), "просто", 0, streetLoots)); // далька клуб на парковке
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1938.7054, 2376.2593, 49.695312), "просто", 0, streetLoots)); // далька клуб на парковке 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1669.5845, 2598.4978, 81.44531), "просто", 0, streetLoots)); // кебрадос верх домик
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1670.009, 2546.0981, 85.23477), "просто", 0, streetLoots)); // кебрадос верх домик 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1667.0961, 2483.7905, 87.179886), "просто", 0, streetLoots)); // кебрадос верх домик 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1545.6069, 2383.6333, 45.489845), "просто", 0, natureLoots)); // дерево кебрадос натуре
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1492.0558, 2139.8835, 46.851627), "просто", 0, natureLoots)); // дерево кебрадос натуре 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-1433.0421, 2456.7112, 61.926735), "просто", 0, natureLoots)); // мусорка кебрадос в сторону рыбки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-743.65686, 2747.13, 49.0429), "просто", 0, streetLoots)); // мусорка азс далька
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-730.5638, 2746.4236, 47.226562), "просто", 0, streetLoots)); // мусорка азс далька 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-569.91376, 2742.9004, 63.351303), "просто", 0, streetLoots)); // ржавый кар далька кок
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-523.0265, 2591.1619, 53.96443), "просто", 0, streetLoots)); // странное здание далька
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-311.56693, 2641.7007, 63.954132), "просто", 0, streetLoots)); // поддон кок
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-262.24686, 2631.929, 63.29646), "просто", 0, streetLoots)); // кар кок
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-216.62674, 2598.1458, 62.79546), "просто", 0, streetLoots)); // мусорка кок скраю
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-219.76859, 2641.2222, 64.153625), "просто", 0, streetLoots)); // будка кок
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-230.82022, 2667.9578, 62.627853), "просто", 0, streetLoots)); // железо кок
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-254.96315, 2698.2114, 62.54453), "просто", 0, streetLoots)); // кок кар у бара
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-231.02936, 2709.7627, 62.976562), "просто", 0, streetLoots)); // кок у бара
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-223.45709, 2710.53, 62.98433), "просто", 0, streetLoots)); // кок у бара 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-221.93172, 2736.257, 62.752056), "просто", 0, streetLoots)); // кок машина 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-195.44647, 2666.0662, 63.63763), "просто", 0, streetLoots)); // кок коробки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-127.72394, 2632.5195, 65.52619), "просто", 0, streetLoots)); // кок мост трак 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(-119.32662, 2633.242, 65.52619), "просто", 0, streetLoots)); // кок мост трак 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(357.35492, 2547.139, 16.595684), "просто", 0, streetLoots)); // гараж аэро 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(352.0091, 2539.2354, 16.729965), "просто", 0, streetLoots)); // гараж аэро 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(351.704, 2546.9014, 16.678032), "просто", 0, streetLoots)); // гараж аэро 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(346.78568, 2536.0588, 16.755478), "просто", 0, streetLoots)); // гараж аэро 2 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(345.7892, 2546.3345, 16.760345), "просто", 0, streetLoots)); // гараж аэро 2 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(341.47418, 2543.6067, 16.781422), "просто", 0, streetLoots)); // гараж аэро 2 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(341.37918, 2537.7205, 16.781887), "просто", 0, streetLoots)); // гараж аэро 2 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(319.21292, 2551.023, 16.919744), "просто", 0, streetLoots)); // аэро в конте
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(324.38986, 2551.9963, 16.891012), "просто", 0, streetLoots)); // аэро в конте 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(323.219, 2550.0396, 16.891012), "просто", 0, streetLoots)); // аэро в конте 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(333.22086, 2547.6252, 18.229727), "просто", 0, streetLoots)); // аэро в конте 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(331.89627, 2553.0815, 16.90961), "просто", 0, streetLoots)); // аэро в конте 5
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(274.71222, 2542.4265, 17.917688), "просто", 0, streetLoots)); // аэро кары
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(276.3907, 2552.346, 16.8125), "просто", 0, streetLoots)); // аэро мусор в углу
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(262.32877, 2551.1248, 16.842194), "просто", 0, streetLoots)); // аэро кар 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(317.43488, 2464.5864, 17.503548), "просто", 0, streetLoots)); // аэро кары куча на юге 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(310.68756, 2460.8125, 16.899694), "просто", 0, streetLoots)); // аэро кары куча на юге 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(307.79486, 2439.7812, 16.476562), "просто", 0, streetLoots)); // аэро кары куча на юге 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(343.3506, 2471.8306, 19.059135), "просто", 0, streetLoots)); // аэро домик сраный 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(357.16168, 2460.4111, 18.501015), "просто", 0, streetLoots)); // аэро домик сраный 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(358.1802, 2470.933, 19.806925), "просто", 0, streetLoots)); // аэро домик сраный 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(409.04172, 2489.8274, 16.484375), "просто", 0, streetLoots)); // аэро мусорка у трейлер парка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(400.9915, 2514.7817, 16.484375), "просто", 0, streetLoots)); // аэро кары у парка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(389.97995, 2515.0605, 16.514067), "просто", 0, streetLoots)); // аэро кары у парка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(388.31274, 2523.0967, 16.494066), "просто", 0, streetLoots)); // аэро кары у парка 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(382.8121, 2546.065, 17.297455), "просто", 0, streetLoots)); // аэро мусорная халупа
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(418.11682, 2554.2673, 16.470236), "просто", 0, streetLoots)); // аэро будка на севере 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(421.96216, 2553.3438, 16.489582), "просто", 0, streetLoots)); // аэро будка на севере 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(415.19974, 2535.9862, 19.648438), "просто", 0, streetLoots)); // аэро будка стол сделать y+ 0.4 + 0.5 z
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(414.8522, 2531.8677, 19.158188), "просто", 0, streetLoots)); // аэро будка 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(413.29156, 2535.9849, 19.148438), "просто", 0, streetLoots)); // аэро будка 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(390.51822, 2600.0007, 16.484375), "просто", 0, streetLoots)); // бочкапарк аэро 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(381.23694, 2604.088, 16.484375), "просто", 0, streetLoots)); // бочкапарк аэро 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(429.69662, 2509.2888, 16.484375), "просто", 0, streetLoots)); // аэро тпарк мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(432.262, 2498.724, 17.448063), "просто", 0, streetLoots)); // аэро тпарк мусор 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(429.54968, 2487.2283, 16.484375), "просто", 0, streetLoots)); // аэро тпарк мусор 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(419.09534, 2485.4617, 16.484375), "просто", 0, streetLoots)); // аэро тпарк мусор 4
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(430.6694, 2519.4639, 16.484375), "просто", 0, streetLoots)); // аэро конт синий
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(629.5517, 2442.0144, 31.261953), "просто", 0, streetLoots)); // куча говна на трассе лв аэро
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(672.8493, 2244.9287, 26.122223), "просто", 0, streetLoots)); // куча говна на трассе лв аэро 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(668.6138, 2114.7764, 17.487717), "просто", 0, streetLoots)); // трак лв близ
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(687.58594, 1829.5822, 5.8258896), "просто", 0, streetLoots)); // парковка у з51
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(684.70703, 1830.2694, 5.7679834), "просто", 0, streetLoots)); // парковка у з51 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(667.8242, 1731.7404, 8.081678), "просто", 0, streetLoots)); // палеты у з51
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(665.5347, 1721.0903, 7.1875), "просто", 0, streetLoots)); // магаз у з51
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(658.6896, 1715.1385, 7.1875), "просто", 0, streetLoots)); // магаз у з51 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(650.9683, 1701.0021, 6.9921875), "просто", 0, streetLoots)); // магаз у з51 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(620.8009, 1686.9536, 7.7019043), "просто", 0, streetLoots)); // азс у з51 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(589.3715, 1655.7233, 7.989134), "просто", 0, streetLoots)); // азс у з51 кар 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(514.1234, 1643.5283, 13.675624), "просто", 0, streetLoots)); // азс у з51 кар 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(541.4156, 1560.473, 1.3933256), "просто", 0, streetLoots)); // нефтечки здание 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(523.7402, 1514.4991, 1.0190805), "просто", 0, streetLoots)); // нефтечки здание 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(526.80426, 1514.5819, 1.0190805), "просто", 0, streetLoots)); // нефтечки здание 3
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(465.3169, 1471.5553, 6.027053), "просто", 0, streetLoots)); // нефтечки самолет
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(441.01575, 1452.1302, 6.9975133), "просто", 0, streetLoots)); // нефтечки кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(411.6226, 1397.959, 7.5859375), "просто", 0, streetLoots)); // нефтечки картонки
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(458.9993, 1281.938, 9.952035), "просто", 0, streetLoots)); // нефтечки песч домик
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(500.7182, 1295.6688, 9.317521), "просто", 0, streetLoots)); // нефтечки песч домик 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(690.57996, 1878.3634, 5.5881824), "просто", 0, streetLoots)); // у з51 домик
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(783.9576, 1885.2068, 5.746035), "просто", 0, streetLoots)); // у з51 аммо на карах
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(776.7252, 1866.3898, 5.9680977), "просто", 0, streetLoots)); // у з51 аммо на мусорке
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(809.73474, 1670.5876, 5.28125), "просто", 0, streetLoots)); // у з51 тир
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(796.9704, 1668.8967, 5.28125), "просто", 0, streetLoots)); // у з51 тир 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(976.7428, 1699.032, 9.961657), "просто", 0, streetLoots)); // дом мафии мусорка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(957.5716, 1713.9302, 9.269087), "просто", 0, streetLoots)); // дом мафии коробка z -0.1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(962.9479, 1732.2717, 9.678298), "просто", 0, streetLoots)); // дом мафии кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(957.0262, 1741.5586, 8.6484375), "просто", 0, streetLoots)); // дом мафии мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(971.8504, 1741.4872, 9.176426), "просто", 0, streetLoots)); // дом мафии палет
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(962.30286, 1854.4967, 11.62057), "просто", 0, streetLoots)); // запад лв кар 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(949.1937, 1886.0963, 11.814002), "просто", 0, streetLoots)); // запад лв катушка
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(940.8964, 1878.2731, 10.8203125), "просто", 0, streetLoots)); // запад лв мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(917.6567, 1864.6649, 11.571499), "просто", 0, streetLoots)); // запад лв кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(886.7032, 2006.0667, 10.8203125), "просто", 0, streetLoots)); // запад лв мусор
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(879.7872, 2016.6371, 10.8203125), "просто", 0, streetLoots)); // запад лв мусор 2
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(883.60443, 2022.3568, 10.942674), "просто", 0, streetLoots)); // запад лв конт
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(884.09607, 2111.0664, 11.594391), "просто", 0, streetLoots)); // запад лв куча машин
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(904.89044, 2150.986, 10.7415695), "просто", 0, streetLoots)); // запад лв кар
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(941.0861, 2213.3157, 10.8203125), "просто", 0, streetLoots)); // запад лв говнокары у трейлера
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(999.6669, 2259.6533, 11.462534), "просто", 0, streetLoots)); // запад лв коробка z -0.1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1051.3586, 2259.7734, 14.695541), "просто", 0, streetLoots)); // запад лв на 2 этаже хуйни
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1059.7427, 2273.2056, 11.462166), "просто", 0, streetLoots)); // запад лв на говновозке
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1025.0677, 2268.9014, 12.194482), "просто", 0, streetLoots)); // запад лв на мусорке упавшей
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(983.2783, 2307.3694, 11.988079), "просто", 0, streetLoots)); // запад лв на говновозке у дома
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1025.1836, 2120.6794, 12.445245), "просто", 0, streetLoots)); // на коробках у склада запад лв
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(996.5993, 2129.5024, 12.070378), "просто", 0, streetLoots)); // на коробках у склада запад лв 1
            lootSpawns.Add(new WorldLootSpawnpoints(new Vector3(1006.03424, 2098.089, 11.3935795), "просто", 0, streetLoots)); // на машине склад лв запад


        }
        public static void SpawnLoot()
        {
            int counter = 0;
            foreach(var lootSpawnPoint in lootSpawns)
            {
                Random r = new Random();
                
                if(r.Next(4) < 2)
                {

                    
                    Random rnd = new Random();
                    int index = rnd.Next(lootSpawnPoint.lootPool.Count);
                    if (index != -1) {
                        PlayerLootObject.Create(lootSpawnPoint.lootPool[index],100, lootSpawnPoint.Position, lootSpawnPoint.VirtualWorld);
                        counter++;
                    }

                }
            }
            Player.SendClientMessageToAll($"Заспавнилось лута: {counter}");
            
        }

    }
}
