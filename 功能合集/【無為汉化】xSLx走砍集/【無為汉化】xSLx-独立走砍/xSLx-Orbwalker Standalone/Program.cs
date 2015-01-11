﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using xSLx_Orbwalker;

namespace xSLx_Orbwalker_Standalone
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        public static void Game_OnGameLoad(EventArgs args)
        {
            Game.PrintChat("<font color=\"#33CC00\">銆愮劇鐐烘眽鍖栥€憍SLx鐙珛璧扮爫</font> loaded. - By <font color=\"#0066FF\">E2Slayer</font>");

            //xSLxOrbwalker Load part
            var menu = new Menu("【無為汉化】xSLx独立走砍", "my_mainmenu", true);
            var orbwalkerMenu = new Menu("xSLx走砍", "my_Orbwalker");
            xSLxOrbwalker.AddToMenu(orbwalkerMenu);
            menu.AddSubMenu(orbwalkerMenu);
            menu.AddToMainMenu();


            //xSLxActivator Load part
            var targetselectormenu = new Menu("目标选择器", "Common_TargetSelector");
            TargetSelector.AddToMenu(targetselectormenu);
            menu.AddSubMenu(targetselectormenu);
        }
    }
}
