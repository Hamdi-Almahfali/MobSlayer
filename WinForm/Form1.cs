using System;
using System.Windows.Forms;
using MobSlayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public bool Pause { get => pause; set => pause = value; }
        bool pause;
        Main main;
        // Game Variables
        public int healthAmount;
        public int moneyAmount = 0;
        public Form1(Main main)
        {
            pause = false;
            this.main = main;
            InitializeComponent();
        }
        public Form1()
        {
            pause = false;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pause = !pause;
            if (pause)
            {
                btnPause.Text = "ON";
            }
            else
            {
                btnPause.Text = "OFF";
            }
        }

        private void lblMoney_Click(object sender, EventArgs e)
        {

        }


        private void tbxMoney_TextChanged(object sender, EventArgs e)
        {
            // Attempt to parse the text as an integer
            if (int.TryParse(tbxMoney.Text, out moneyAmount))
            {
                // Parsing was successful, you can use parsedValue
                Console.WriteLine("Parsed value: " + moneyAmount);
            }
            else
            {
                // Parsing failed, set parsedValue to 0 or handle the error
                moneyAmount = 0;
                Console.WriteLine("Invalid input, set parsedValue to 0");
            }
        }

        private void btnSetMoney_Click(object sender, EventArgs e)
        {
            Main.gsm.gameScene.Money = moneyAmount;
        }

        private void btnAddHealth_Click(object sender, EventArgs e)
        {
            if (Main.gsm.gameScene.Health >= 9)
                Main.gsm.gameScene.Health = 10;
            else
                Main.gsm.gameScene.Health += 1;
        }

        private void btnMinusHealth_Click(object sender, EventArgs e)
        {
            if (Main.gsm.gameScene.Health <= 1)
                Main.gsm.gameScene.Health = 1;
            else
                Main.gsm.gameScene.Health -= 1;

        }

        private void btnAddBat_Click(object sender, EventArgs e)
        {
            Main.gsm.gameScene._monsterManager.CurrentWave.nrOfmonstInCurrentWave++;
        }

        private void btnAddMultiBats_Click(object sender, EventArgs e)
        {
            Main.gsm.gameScene._monsterManager.CurrentWave.nrOfmonstInCurrentWave += 5;
            Main.gsm.gameScene._monsterManager.timeSinceLastMonst = 5;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMinusBat_Click(object sender, EventArgs e)
        {
            if (Main.gsm.gameScene._monsterManager.enemies.Count > 0)
            {
                foreach (Enemy enemy in Main.gsm.gameScene._monsterManager.enemies)
                {
                    if (enemy.IsHit)
                        continue;
                    Main.gsm.gameScene._monsterManager.enemies.Remove(enemy);
                }
            }
        }

        private void btnBatsClear_Click(object sender, EventArgs e)
        {
            Main.gsm.gameScene._monsterManager.enemies.Clear();
            Main.gsm.gameScene._monsterManager.CurrentWave.nrOfmonstInCurrentWave = 0;
            Main.gsm.gameScene._monsterManager.timeSinceLastMonst = 0;
        }

        private void btnInfHealth_Click(object sender, EventArgs e)
        {
            Main.gsm.gameScene.InfHealth = !Main.gsm.gameScene.InfHealth;
            if (Main.gsm.gameScene.InfHealth)
            {
                btnInfHealth.Text = "ON";
            }
            else
            {
                btnInfHealth.Text = "OFF";
            }
        }
    }
}
