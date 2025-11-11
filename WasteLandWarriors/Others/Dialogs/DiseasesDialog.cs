using HarmonyLib;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteLandWarriors.Others.Dialogs
{
    internal class DiseasesDialog
    {

        public static void showDiseasesDialog(Player p)
        {
            string bleedstatus = "нет";
            string dislocationStatus = "нет";
            string coldStatus = "";
            string poisoningStatus = "";
            string choleraStatus = "";
            string burnStatus = "";
            string salmonelaStatus = "";
            string radiationSicknessStatus = "";
            switch (p.diseases.bleed)
            {
                case Systems.bleedingType.None:
                    bleedstatus = "{649156}Нет";
                    break;
                case Systems.bleedingType.Capillary:
                    bleedstatus = "{9E2424}Капиллярное";
                    break;
                case Systems.bleedingType.Venous:
                    bleedstatus = "{9E2424}Венозное";
                    break;
                case Systems.bleedingType.Arterial:
                    bleedstatus = "{9E2424}Артериальное";
                    break;
            }
            if (p.diseases.dislocation) {
                dislocationStatus = "{9E2424}Есть";
            }
            else
            {
                dislocationStatus = "{649156}Нет";
            }

            if (p.diseases.cold)
            {
                coldStatus = "{9E2424}Есть";
            }
            else
            {
                coldStatus = "{649156}Нет";
            }
            switch (p.diseases.poisoning)
            {
                case Systems.poisoning.None:
                    poisoningStatus = "{649156}Нет";
                    break;
                case Systems.poisoning.Mild:
                    poisoningStatus = "{9E2424}Слабое";
                    break;
                case Systems.poisoning.Average:
                    poisoningStatus = "{9E2424}Среднее";
                    break;
                case Systems.poisoning.Severe:
                    poisoningStatus = "{9E2424}Сильное";
                    break;
            }
            if (p.diseases.cholera)
            {
                choleraStatus = "{9E2424}Есть";
            }
            else
            {
                choleraStatus = "{649156}Нет";
            }
            switch (p.diseases.burn)
            {
                case Systems.burn.None:
                    burnStatus = "{649156}Нет";
                    break;
                case Systems.burn.Treated:
                    burnStatus = "{9E2424}Обработаны";
                    break;
                case Systems.burn.Burned:
                    burnStatus = "{9E2424}Воспалены";
                    break;

            }
            if (p.diseases.salmonela)
            {
                salmonelaStatus = "{9E2424}Есть";
            }
            else
            {
                salmonelaStatus = "{649156}Нет";
            }

            switch (p.diseases.radiationSickness)
            {
                case Systems.radiationSickness.None:
                    radiationSicknessStatus = "{649156}Нет";
                    break;
                case Systems.radiationSickness.StageOne:
                    radiationSicknessStatus = "{9E2424}Первая стадия";
                    break;
                case Systems.radiationSickness.StageTwo:
                    radiationSicknessStatus = "{9E2424}Вторая стадия";
                    break;
                case Systems.radiationSickness.StageThree:
                    radiationSicknessStatus = "{9E2424}Третья стадия";
                    break;
                case Systems.radiationSickness.StageFour:
                    radiationSicknessStatus = "{9E2424}Четвёртая стадия";
                    break;
            }


            var diseasesDialog = new TablistDialog("{995D5D}Здоровье", new[] { "{FFFFFF}Название", "{FFFFFF}Статус" }, "Принять");
            diseasesDialog.Add(
                new[] { "{995D5D}Состояние здоровья", $"{{649156}}{p.diseases.healthStatus} HP" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Кровотечение", $"{bleedstatus}" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Вывих", $"{dislocationStatus}" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Простуда", $"{coldStatus}" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Отравление", $"{poisoningStatus}" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Холера", $"{choleraStatus}" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Ожоги", $"{burnStatus}" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Сальмонела", $"{salmonelaStatus}" }
            );
            diseasesDialog.Add(
                new[] { "{995D5D}Лучевая болезнь", $"{radiationSicknessStatus}" }
            );

            void diseasesDialogResponse(object sender, DialogResponseEventArgs e)
            {
                
            }
            diseasesDialog.Show(p);
        }
        
    }
}
