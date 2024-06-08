namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxLeft = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblPauseGame = new System.Windows.Forms.Label();
            this.gbxRight = new System.Windows.Forms.GroupBox();
            this.btnAddMultiBats = new System.Windows.Forms.Button();
            this.btnAddBat = new System.Windows.Forms.Button();
            this.lblBats = new System.Windows.Forms.Label();
            this.btnMinusHealth = new System.Windows.Forms.Button();
            this.btnAddHealth = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.tbxMoney = new System.Windows.Forms.TextBox();
            this.btnSetMoney = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfHealth = new System.Windows.Forms.Button();
            this.btnMinusBat = new System.Windows.Forms.Button();
            this.btnBatsClear = new System.Windows.Forms.Button();
            this.gbxLeft.SuspendLayout();
            this.gbxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLeft
            // 
            this.gbxLeft.Controls.Add(this.btnInfHealth);
            this.gbxLeft.Controls.Add(this.label1);
            this.gbxLeft.Controls.Add(this.btnPause);
            this.gbxLeft.Controls.Add(this.lblPauseGame);
            this.gbxLeft.Location = new System.Drawing.Point(12, 12);
            this.gbxLeft.Name = "gbxLeft";
            this.gbxLeft.Size = new System.Drawing.Size(201, 426);
            this.gbxLeft.TabIndex = 0;
            this.gbxLeft.TabStop = false;
            this.gbxLeft.Text = "Game Controls";
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(112, 34);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(69, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "OFF";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblPauseGame
            // 
            this.lblPauseGame.AutoSize = true;
            this.lblPauseGame.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseGame.Location = new System.Drawing.Point(7, 32);
            this.lblPauseGame.Name = "lblPauseGame";
            this.lblPauseGame.Size = new System.Drawing.Size(89, 22);
            this.lblPauseGame.TabIndex = 0;
            this.lblPauseGame.Text = "Pause Game";
            // 
            // gbxRight
            // 
            this.gbxRight.Controls.Add(this.btnBatsClear);
            this.gbxRight.Controls.Add(this.btnMinusBat);
            this.gbxRight.Controls.Add(this.btnAddMultiBats);
            this.gbxRight.Controls.Add(this.btnAddBat);
            this.gbxRight.Controls.Add(this.lblBats);
            this.gbxRight.Controls.Add(this.btnMinusHealth);
            this.gbxRight.Controls.Add(this.btnAddHealth);
            this.gbxRight.Controls.Add(this.lblHealth);
            this.gbxRight.Controls.Add(this.tbxMoney);
            this.gbxRight.Controls.Add(this.btnSetMoney);
            this.gbxRight.Controls.Add(this.lblMoney);
            this.gbxRight.Location = new System.Drawing.Point(220, 13);
            this.gbxRight.Name = "gbxRight";
            this.gbxRight.Size = new System.Drawing.Size(200, 425);
            this.gbxRight.TabIndex = 1;
            this.gbxRight.TabStop = false;
            this.gbxRight.Text = "Value Control";
            // 
            // btnAddMultiBats
            // 
            this.btnAddMultiBats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMultiBats.Location = new System.Drawing.Point(120, 218);
            this.btnAddMultiBats.Name = "btnAddMultiBats";
            this.btnAddMultiBats.Size = new System.Drawing.Size(49, 20);
            this.btnAddMultiBats.TabIndex = 9;
            this.btnAddMultiBats.Text = "+5";
            this.btnAddMultiBats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddMultiBats.UseVisualStyleBackColor = true;
            this.btnAddMultiBats.Click += new System.EventHandler(this.btnAddMultiBats_Click);
            // 
            // btnAddBat
            // 
            this.btnAddBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBat.Location = new System.Drawing.Point(66, 218);
            this.btnAddBat.Name = "btnAddBat";
            this.btnAddBat.Size = new System.Drawing.Size(49, 20);
            this.btnAddBat.TabIndex = 8;
            this.btnAddBat.Text = "+1";
            this.btnAddBat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddBat.UseVisualStyleBackColor = true;
            this.btnAddBat.Click += new System.EventHandler(this.btnAddBat_Click);
            // 
            // lblBats
            // 
            this.lblBats.AutoSize = true;
            this.lblBats.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBats.Location = new System.Drawing.Point(6, 216);
            this.lblBats.Name = "lblBats";
            this.lblBats.Size = new System.Drawing.Size(38, 22);
            this.lblBats.TabIndex = 7;
            this.lblBats.Text = "Bats";
            // 
            // btnMinusHealth
            // 
            this.btnMinusHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusHealth.Location = new System.Drawing.Point(120, 128);
            this.btnMinusHealth.Name = "btnMinusHealth";
            this.btnMinusHealth.Size = new System.Drawing.Size(49, 20);
            this.btnMinusHealth.TabIndex = 6;
            this.btnMinusHealth.Text = "-10";
            this.btnMinusHealth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusHealth.UseVisualStyleBackColor = true;
            this.btnMinusHealth.Click += new System.EventHandler(this.btnMinusHealth_Click);
            // 
            // btnAddHealth
            // 
            this.btnAddHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHealth.Location = new System.Drawing.Point(66, 128);
            this.btnAddHealth.Name = "btnAddHealth";
            this.btnAddHealth.Size = new System.Drawing.Size(49, 20);
            this.btnAddHealth.TabIndex = 5;
            this.btnAddHealth.Text = "+10";
            this.btnAddHealth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddHealth.UseVisualStyleBackColor = true;
            this.btnAddHealth.Click += new System.EventHandler(this.btnAddHealth_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHealth.Location = new System.Drawing.Point(6, 126);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(54, 22);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "Health";
            this.lblHealth.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxMoney
            // 
            this.tbxMoney.Location = new System.Drawing.Point(66, 36);
            this.tbxMoney.MaxLength = 3;
            this.tbxMoney.Name = "tbxMoney";
            this.tbxMoney.Size = new System.Drawing.Size(49, 20);
            this.tbxMoney.TabIndex = 0;
            this.tbxMoney.TextChanged += new System.EventHandler(this.tbxMoney_TextChanged);
            // 
            // btnSetMoney
            // 
            this.btnSetMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMoney.Location = new System.Drawing.Point(120, 36);
            this.btnSetMoney.Name = "btnSetMoney";
            this.btnSetMoney.Size = new System.Drawing.Size(49, 20);
            this.btnSetMoney.TabIndex = 2;
            this.btnSetMoney.Text = "SET";
            this.btnSetMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetMoney.UseVisualStyleBackColor = true;
            this.btnSetMoney.Click += new System.EventHandler(this.btnSetMoney_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMoney.Location = new System.Drawing.Point(6, 33);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(53, 22);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "Money";
            this.lblMoney.Click += new System.EventHandler(this.lblMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inf Health";
            // 
            // btnInfHealth
            // 
            this.btnInfHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfHealth.Location = new System.Drawing.Point(112, 130);
            this.btnInfHealth.Name = "btnInfHealth";
            this.btnInfHealth.Size = new System.Drawing.Size(69, 23);
            this.btnInfHealth.TabIndex = 3;
            this.btnInfHealth.Text = "OFF";
            this.btnInfHealth.UseVisualStyleBackColor = true;
            this.btnInfHealth.Click += new System.EventHandler(this.btnInfHealth_Click);
            // 
            // btnMinusBat
            // 
            this.btnMinusBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusBat.Location = new System.Drawing.Point(66, 244);
            this.btnMinusBat.Name = "btnMinusBat";
            this.btnMinusBat.Size = new System.Drawing.Size(49, 20);
            this.btnMinusBat.TabIndex = 10;
            this.btnMinusBat.Text = "-1";
            this.btnMinusBat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusBat.UseVisualStyleBackColor = true;
            this.btnMinusBat.Click += new System.EventHandler(this.btnMinusBat_Click);
            // 
            // btnBatsClear
            // 
            this.btnBatsClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatsClear.Location = new System.Drawing.Point(120, 244);
            this.btnBatsClear.Name = "btnBatsClear";
            this.btnBatsClear.Size = new System.Drawing.Size(49, 20);
            this.btnBatsClear.TabIndex = 11;
            this.btnBatsClear.Text = "Clear";
            this.btnBatsClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBatsClear.UseVisualStyleBackColor = true;
            this.btnBatsClear.Click += new System.EventHandler(this.btnBatsClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.gbxRight);
            this.Controls.Add(this.gbxLeft);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cheats Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxLeft.ResumeLayout(false);
            this.gbxLeft.PerformLayout();
            this.gbxRight.ResumeLayout(false);
            this.gbxRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLeft;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblPauseGame;
        private System.Windows.Forms.GroupBox gbxRight;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox tbxMoney;
        private System.Windows.Forms.Button btnSetMoney;
        private System.Windows.Forms.Label lblBats;
        private System.Windows.Forms.Button btnMinusHealth;
        private System.Windows.Forms.Button btnAddHealth;
        private System.Windows.Forms.Button btnAddMultiBats;
        private System.Windows.Forms.Button btnAddBat;
        private System.Windows.Forms.Button btnInfHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatsClear;
        private System.Windows.Forms.Button btnMinusBat;
    }
}

