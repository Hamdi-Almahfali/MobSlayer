using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    public class BN
    {
        public int StartingMoney     = 710;

        public int ShooterPrice      = 170;
        public int CannonPrice       = 445;
        public int FrostPrice        = 426;

        public int ShooterDamage     = 8;
        public float ShooterShotSpeed= 0.8f;
        public int ShooterRange      = 220;

        public int CannonDamage      = 10;
        public float CannonShotSpeed = 2f;
        public  int CannonRange       = 140;
        public int CannonAoe         = 20;

        public int FrostDamage       = 1;
        public float FrostShotSpeed  = 0.3f;
        public int FrostRange        = 300;
        public float FrostSlowDuration = 1f;
        public float FrostSlowAmount = 0.6f;


        public int BatHealth         = 10; // Max Health
        public int BatKillReward     = 10; // Money recieved by killing

        public float Wave1BatSpeed   = 0.1f;
        public int Wave1BatsDensity  = 400;
        public int Wave1BatsAmount   = 15;

        public float Wave2BatSpeed   = 0.1f;
        public int Wave2BatsDensity  = 400;
        public int Wave2BatsAmount   = 15;

        public float Wave3BatSpeed   = 0.1f;
        public int Wave3BatsDensity  = 400;
        public int Wave3BatsAmount   = 15;
        public BN()
        {

        }
    }
}
