namespace MobSlayer
{
    /// <summary>
    /// Class for modifying the game's value in one place
    /// Refernce point for real-time modification
    /// </summary>
    public class BN
    {
        public readonly int StartingMoney = 500;

        public readonly int ShooterPrice = 150;
        public readonly int CannonPrice = 300;
        public readonly int FrostPrice = 200;

        public readonly int ShooterDamage = 2;
        public readonly float ShooterShotSpeed = 0.7f;
        public readonly int ShooterRange = 250;

        public readonly int CannonDamage = 10;
        public readonly float CannonShotSpeed = 2f;
        public readonly int CannonRange = 140;
        public readonly float CannonAoe = 120f;

        public readonly int FrostDamage = 1;
        public readonly float FrostShotSpeed = 0.3f;
        public readonly int FrostRange = 300;
        public readonly float FrostSlowDuration = 1.5f;
        public readonly float FrostSlowAmount = 0.6f;


        public int BatHealth = 10; // Max Health
        public int BatKillReward = 25; // Money recieved by killing bat
        public int BirdKillReward = 10; // Money recieved by killing weak bat

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
