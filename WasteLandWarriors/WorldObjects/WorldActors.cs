using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampSharp.GameMode;

namespace WasteLandWarriors.WorldObjects
{
    internal class WorldActors
    {
        public WorldActors() {
            var MACTEP = Actor.Create(6, new Vector3(-175.88075f, 1226.6819f, 21.030312f), 216.54417f);
            MACTEP.IsInvulnerable = true;
            TextLabel tdmactep = new TextLabel("{FFFFFF}Мастер {268bf0}[F]", 0, new Vector3(-175.88075f, 1226.6819f, 21.030312f), 15.0f, 0);

            var barmen = Actor.Create(171, new Vector3(497.05154, -77.56168, 998.7651), 0);
            TextLabel tdbar = new TextLabel("{FFFFFF}Бар {268bf0}[F]", 0, new Vector3(497.05862, -76.04029, 998.7578), 15.0f, 1002);
            barmen.VirtualWorld = 1002;
            barmen.IsInvulnerable = true;

            var banditsHead = Actor.Create(149, new Vector3(510.90982, -80.66605, 998.96094), 113.04387f);
            banditsHead.VirtualWorld = 1002;
            banditsHead.IsInvulnerable = true;
            TextLabel banditsHeadTL = new TextLabel("{ffffff}Бампи Джонсон{268bf0}[F]", 0, new Vector3(509.29916, -81.20589, 998.96094), 20.0f, 1002);

            var shopSeller = Actor.Create(241, new Vector3(1329.6319, 1355.4971, 3001.1155), 0f);
            shopSeller.VirtualWorld = 1003;
            banditsHead.IsInvulnerable = true;
            TextLabel shopSellerTL = new TextLabel("{ffffff}Магазин {268bf0}[F]", 0, new Vector3(1329.6433, 1357.181, 3001.1155), 20.0f, 1003);

            //-225.80734, 1069.6211, 19.742188, 358,54773

            var bomjValera = Actor.Create(78, new Vector3(-225.80734, 1069.6211, 19.742188), 10f);
            bomjValera.VirtualWorld = 0;
            bomjValera.IsInvulnerable = true;

            TextLabel bomjValeraTd = new TextLabel("{ffffff}Даркел{268bf0}[F]", 0, new Vector3(-225.80734, 1069.6211, 19.742188), 20.0f, 0);

            // -225.72682, 1066.9615, 20.023155, 90

            var bomjValeraJ = Actor.Create(75, new Vector3(-225.72682, 1066.9615, 20.023155), 87f);
            bomjValeraJ.VirtualWorld = 0;
            bomjValeraJ.IsInvulnerable = true;
            bomjValeraJ.ApplyAnimation("CRACK", "CRCKIDLE4", 1, false, false, false, true, -1);

            var glava = Actor.Create(295, new Vector3(1337.9585, 1582.9047, 3000.0054), 138f);
            glava.VirtualWorld = 1001;
            glava.IsInvulnerable = true;
            TextLabel glavaTL = new TextLabel("{ffffff}Глава поселения {268bf0}[F]", 0, new Vector3(1335.6156, 1580.1486, 3000.0054), 20.0f, 1001);
            //2219.224, 1592.236, 1000, 180
            var general = Actor.Create(179, new Vector3(2219.224, 1592.236, 1000), 180f);
            general.VirtualWorld = 1010;
            general.IsInvulnerable = true;
            // 2219.3816, 1590.0101, 1000
            TextLabel generalTL = new TextLabel("{ffffff}Капитан Стюарт {268bf0}[F]", 0, new Vector3(2219.3816, 1590.0101, 1000), 20.0f, 1010);


            var glavaOhrana1 = Actor.Create(164, new Vector3(1335.9097, 1583.972, 3000.0054), 163f);
            glavaOhrana1.VirtualWorld = 1001;
            glavaOhrana1.IsInvulnerable = true;

            var glavaOhrana2 = Actor.Create(163, new Vector3(1324.1565, 1573.9795, 3000.0054), 271f);
            glavaOhrana2.VirtualWorld = 1001;
            glavaOhrana2.IsInvulnerable = true;

            var technicue = Actor.Create(289, new Vector3(-90.98175, 1162.773, 19.742188), 13.393677f);
            technicue.VirtualWorld = 0;
            technicue.IsInvulnerable = true;

            var witch = Actor.Create(196, new Vector3(-793.816, -1976.6213, 6.860173), 30f);
            TextLabel witchTD = new TextLabel("{FFFFFF}Ведьма {268bf0}[F]", 0, new Vector3(-793.816, -1976.6213, 6.860173), 20.0f, 0);
            witch.IsInvulnerable = true;
            //var soldierCenterRight = Actor.Create(286, new Vector3(-145.98532, 1129.9305, 35.72811), 325);
            //soldierCenterRight.VirtualWorld = 0;
            //soldierCenterRight.IsInvulnerable= true;

            //-196.06013, 1219.5857, 19.902187 165.61018
            var mecanic = Actor.Create(50, new Vector3(-196.06013f, 1219.5857f, 19.902187f), 165.61018f);
            TextLabel tdmecanic = new TextLabel("{FFFFFF}Механик {268bf0}[F]", 0, new Vector3(-196.06013, 1219.5857, 19.902187), 20.0f, 0);
            mecanic.IsInvulnerable = true;
        }

    }
}
