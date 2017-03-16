using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EloBuddy;
using System.Threading.Tasks;
using EloBuddy.SDK;
using EloBuddy.SDK.Constants;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;

namespace AutoHarass
{
    public static class MenuManager
    {
        private static readonly Menu Menu;
        private static Menu CondemnMenu;

        public static bool IDDQD { get; set; }

        static MenuManager()
        {
            Menu = MainMenu.AddMenu("AutoHarass", "cAuto 2.0");

            Modes.Initialize();
        }


        public static void Initialize()
        {
        }
        public static class Modes
        {
            internal static object Gosu;
            private static readonly Menu Menu;

            static Modes()
            {
                Menu = MenuManager.Menu.AddSubMenu("Modes");
            }

            internal static void Initialize()
            {
                throw new NotImplementedException();
            }

            public static class Harass
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _UseW;
                private static readonly CheckBox _useE;
                private static readonly CheckBox _UseR;
                private static readonly Slider _manaPercent;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _UseW.CurrentValue; }
                }
                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }
                public static bool Mana
                {
                    get { return Player.Instance.ManaPercent > _manaPercent.CurrentValue; }
                }

                static Harass()
                {
                    Menu.AddGroupLabel("Harass");
                    _useQ = Menu.Add("Harass.Q", new CheckBox("Use Q"));
                    _UseW = Menu.Add("Harass.W", new CheckBox("Enemy Use W ", false));
                    _useE = Menu.Add("Harass.E", new CheckBox("Use E"));
                    _UseR = Menu.Add("Harass.R", new CheckBox("Use R"));
                    _manaPercent = Menu.Add("Harass.mana", new Slider("Min Mana %", 70, 0, 100));
                }


                public static class Gosu
                {
                    private static readonly CheckBox _godMode;

                    public static bool IDDQD
                    {
                        get { return _godMode.CurrentValue; }
                    }

                    public static void SetGod()
                    {
                        _godMode.CurrentValue = true;
                    }

                    public static void UnSetGod()
                    {
                        _godMode.CurrentValue = false;
                    }

                    static Gosu()
                    {
                    }

                    public static void Initialize()
                    {
                    }
                }
            }
        }
    }
}
