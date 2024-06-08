using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    public class BN
    {
        public int StartingMoney = 500;

        public int ShooterPrice = 150;
        public int CannonPrice = 300;
        public int FrostPrice = 200;

        public int ShooterDamage = 5;
        public float ShooterShotSpeed = 1.1f;
        public int ShooterRange = 220;

        public int CannonDamage = 10;
        public float CannonShotSpeed = 2f;
        public int CannonRange = 140;
        public float CannonAoe = 120f;

        public int FrostDamage = 1;
        public float FrostShotSpeed = 0.3f;
        public int FrostRange = 300;
        public float FrostSlowDuration = 1.5f;
        public float FrostSlowAmount = 0.6f;


        public int BatHealth = 10; // Max Health
        public int BatKillReward = 10; // Money recieved by killing bat
        public int BirdKillReward = 5; // Money recieved by killing weak bat

        public float Wave1BatSpeed = 0.05f;
        public int Wave1BatsDensity = 400;
        public int Wave1BatsAmount = 5;

        public float Wave2BatSpeed = 0.05f;
        public int Wave2BatsDensity = 400;
        public int Wave2BatsAmount = 15;

        public float Wave3BatSpeed = 0.1f;
        public int Wave3BatsDensity = 200;
        public int Wave3BatsAmount = 15;
        public BN()
        {

        }
    }
}
