using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobSlayer
{
    public class Wave
    {
        public int mBetweenCreation;
        public int nrOfmonstInCurrentWave;
        public float enemiesSpeed;
        public Wave(int wave)
        {
            SetWaveProperties(wave);
        }
        private void SetWaveProperties(int wave)
        {
            switch (wave)
            {
                case 0:
                    mBetweenCreation        = Main.gsm.BN.Wave1BatsDensity;
                    nrOfmonstInCurrentWave  = Main.gsm.BN.Wave1BatsAmount;
                    enemiesSpeed            = Main.gsm.BN.Wave1BatSpeed;
                    break;
                case 1:
                    mBetweenCreation        = Main.gsm.BN.Wave2BatsDensity;
                    nrOfmonstInCurrentWave  = Main.gsm.BN.Wave2BatsAmount;
                    enemiesSpeed            = Main.gsm.BN.Wave2BatSpeed;
                    break;
                case 2:
                    mBetweenCreation        = Main.gsm.BN.Wave3BatsDensity;
                    nrOfmonstInCurrentWave  = Main.gsm.BN.Wave3BatsAmount;
                    enemiesSpeed            = Main.gsm.BN.Wave3BatSpeed;

                    break;
                default:
                    mBetweenCreation = Main.gsm.BN.Wave3BatsDensity;
                    nrOfmonstInCurrentWave = Main.gsm.BN.Wave3BatsAmount;
                    enemiesSpeed = Main.gsm.BN.Wave2BatSpeed;

                    break;

            }
        }
    }
}
