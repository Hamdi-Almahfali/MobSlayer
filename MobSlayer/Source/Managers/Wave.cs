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
        public Wave(int wave)
        {
            SetWaveProperties(wave);
        }
        private void SetWaveProperties(int wave)
        {
            switch (wave)
            {
                case 0:
                    mBetweenCreation        = BN.Wave1BatsDensity;
                    nrOfmonstInCurrentWave  = BN.Wave1BatsAmount;
                    break;
                case 1:
                    mBetweenCreation        = BN.Wave2BatsDensity;
                    nrOfmonstInCurrentWave  = BN.Wave2BatsAmount;
                    break;
                case 2:
                    mBetweenCreation        = BN.Wave3BatsDensity;
                    nrOfmonstInCurrentWave  = BN.Wave3BatsAmount;
                    break;
                default:
                    mBetweenCreation = BN.Wave3BatsDensity;
                    nrOfmonstInCurrentWave = BN.Wave3BatsAmount;
                    break;

            }
        }
    }
}
