using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    public static class BN
    {
        public static int StartingMoney     = 510;

        public static int ShooterPrice      = 170;
        public static int CannonPrice       = 445;
        public static int FrostPrice        = 426;

        public static int ShooterDamage     = 8;
        public static float ShooterShotSpeed= 0.8f;
        public static int ShooterRange      = 220;

        public static int CannonDamage      = 10;
        public static float CannonShotSpeed = 2f;
        public static int CannonRange       = 140;
        public static int CannonAoe         = 20;

        public static int FrostDamage       = 1;
        public static float FrostShotSpeed  = 0.3f;
        public static int FrostRange        = 300;


        public static int BatHealth         = 10; // Max Health
        public static int BatKillReward     = 10; // Money recieved by killing

        public static float Wave1BatSpeed   = 0.1f;
        public static int Wave1BatsDensity  = 400;
        public static int Wave1BatsAmount   = 15;

        public static float Wave2BatSpeed   = 0.1f;
        public static int Wave2BatsDensity  = 400;
        public static int Wave2BatsAmount   = 15;

        public static float Wave3BatSpeed   = 0.1f;
        public static int Wave3BatsDensity  = 400;
        public static int Wave3BatsAmount   = 15;
    }
}
