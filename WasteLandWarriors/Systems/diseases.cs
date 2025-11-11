using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteLandWarriors.Display;

namespace WasteLandWarriors.Systems
{
    public class diseases
    {
        public Player p;
        public int healthStatus = 100;
        public bleedingType bleed = bleedingType.None;
        public bool dislocation = false;
        public bool cold = false;
        public poisoning poisoning = poisoning.None;
        public bool cholera = false;
        public burn burn = burn.Treated;
        public bool salmonela = false;
        public radiationSickness radiationSickness = radiationSickness.StageThree;
        int coldTick = 0;
        int coldUpdate = 0;
         int breaklegMoveCounter = 0;

        public diseases(Player p)
        {
            this.p = p;
            
            
        }
        public void Start()
        {
            p.timer.millsecTimer.Tick += TryDeseases;
            p.timer.millsecTimer.Tick += BreakLegMoveUpdate;
            p.TakeDamage += BreakLeg;
            p.KeyStateChanged += BreakLegMove;
        }
        public void TryDeseases(object sender, EventArgs e)
        {
            coldTick++;
            if(coldTick >= 100)
            {
                coldTick = 0;
                if(p.parameters.clothWet >= 300)
                {
                    Random random = new Random();
                    if(random.Next(4) == 0 && cold == false && p.parameters.bodyTemp < 70)
                    {
                        p.timer.millsecTimer.Tick += CountDeseases;
                        cold = true;
                        p.SendClientMessage("{B51010}ВНИМАНИЕ:{ABABAB} Вы простудились! Обратитесь в госпиталь или используйте антибиотики, а также избегайте переохлаждения.");
                        
                    }
                    
                }
            }
        }
        public void CountDeseases(object sender, EventArgs e)
        {
            if(cold == false)
            {
                p.timer.millsecTimer.Tick -= CountDeseases;
                coldUpdate = 0;
            }
            coldUpdate++;
            if(coldUpdate >= 1500) {
                coldUpdate = 0;
                if(p.parameters.bodyTemp >= 30)
                {
                    p.parameters.bodyTemp = 30;
                    p.playerInterface.OdejdaNum.Text = "30";
                    p.playerInterface.OdejdaPng.ForeColor = PlayerInterface.red;
                }
                p.DrunkLevel = 7000;
                p.SendClientMessage("{FFD26B}ПРОСТУДА: {3CCBE8}Вас знобит, вам холодно и вы чувствуете слабость. Обратитесь в госпиталь.");
            }
        }
        public void BreakLeg(object sender, DamageEventArgs e)
        {
            
            if(((e.Weapon == SampSharp.GameMode.Definitions.Weapon.Explosion)) && dislocation == false)
            {
                
                Random r = new Random();
                if(r.Next(2) == 1 && p.isAuth)
                {
                    dislocation = true;
                    p.SendClientMessage("{FFD26B}ВЫВИХ:{3CCBE8} Внимание! Вы получили вывих, обратитесь в госпиталь или зафиксируйте конечность бинтом.");
                }
               
            }
        }  
        public void BreakLegMove(object sender, KeyStateChangedEventArgs e)
        {
            if (dislocation == true)
            {
                if (p.InAnyVehicle == false)
                {
                    if (((int)e.NewKeys & (int)Keys.Jump) >= (int)Keys.Jump)
                    {
                        
                        p.SpecialAction = SpecialAction.None;
                        p.ClearAnimations();
                        p.SendClientMessage("{828282}У вас вывих, вы не можете бегать или прыгать.");


                    }
                }
            }
        }
        public void BreakLegMoveUpdate(object sender, EventArgs e)
        {
            breaklegMoveCounter++;
            if (breaklegMoveCounter >= 6)
            {
                breaklegMoveCounter = 0;
                if (dislocation == true && !p.InAnyVehicle)
                {
                    Keys keys = new Keys();
                    int updown = 0;
                    int leftright = 0;
                    p.GetKeys(out keys, out updown, out leftright);
                    if (((int)Keys.Sprint & (int)keys) >= (int)Keys.Sprint)
                    {
                        p.SpecialAction = SpecialAction.None;
                        p.ClearAnimations();
                        p.SendClientMessage("{828282}У вас вывих, вы не можете бегать или прыгать.");

                    }
                }
            }
        }
    }
    public enum bleedingType
    {
        None = 0,
        Capillary = 1,
        Venous = 2,
        Arterial = 3,

    }
    public enum poisoning
    {
        None = 0,
        Mild = 1,
        Average = 2,
        Severe = 3,

    }
    public enum burn
    {
        None = 0,
        Treated = 1,
        Burned = 2,

    }
    public enum radiationSickness
    {
        None = 0,
        StageOne = 1,
        StageTwo = 2,
        StageThree = 3,
        StageFour = 4,
    }

}
