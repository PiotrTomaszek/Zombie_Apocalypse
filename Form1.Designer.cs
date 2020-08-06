namespace Zombie_Apocalypse_Tomaszek_Piotr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblTurnNumber = new System.Windows.Forms.Label();
            this.btnNextTurn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBxCzlowiek = new System.Windows.Forms.TextBox();
            this.tBxWojsko = new System.Windows.Forms.TextBox();
            this.tBxZombie = new System.Windows.Forms.TextBox();
            this.btbStartGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pBoxHuman = new System.Windows.Forms.PictureBox();
            this.pBoxMilitary = new System.Windows.Forms.PictureBox();
            this.pBoxZombie = new System.Windows.Forms.PictureBox();
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblMilitary = new System.Windows.Forms.Label();
            this.lblZombie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMilitary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxZombie)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGame.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGame.Location = new System.Drawing.Point(12, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(500, 500);
            this.pnlGame.TabIndex = 0;
            // 
            // lblTurnNumber
            // 
            this.lblTurnNumber.AutoSize = true;
            this.lblTurnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurnNumber.Location = new System.Drawing.Point(524, 207);
            this.lblTurnNumber.Name = "lblTurnNumber";
            this.lblTurnNumber.Size = new System.Drawing.Size(55, 20);
            this.lblTurnNumber.TabIndex = 1;
            this.lblTurnNumber.Text = "Turn: ";
            this.lblTurnNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextTurn.Location = new System.Drawing.Point(528, 230);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(158, 30);
            this.btnNextTurn.TabIndex = 5;
            this.btnNextTurn.Text = "Next Turn";
            this.btnNextTurn.UseVisualStyleBackColor = true;
            this.btnNextTurn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Human: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Military: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zombie: ";
            // 
            // tBxCzlowiek
            // 
            this.tBxCzlowiek.Location = new System.Drawing.Point(586, 57);
            this.tBxCzlowiek.Name = "tBxCzlowiek";
            this.tBxCzlowiek.Size = new System.Drawing.Size(100, 20);
            this.tBxCzlowiek.TabIndex = 1;
            this.tBxCzlowiek.TextChanged += new System.EventHandler(this.tBxCzlowiek_TextChanged);
            // 
            // tBxWojsko
            // 
            this.tBxWojsko.Location = new System.Drawing.Point(586, 74);
            this.tBxWojsko.Name = "tBxWojsko";
            this.tBxWojsko.Size = new System.Drawing.Size(100, 20);
            this.tBxWojsko.TabIndex = 2;
            // 
            // tBxZombie
            // 
            this.tBxZombie.Location = new System.Drawing.Point(586, 91);
            this.tBxZombie.Name = "tBxZombie";
            this.tBxZombie.Size = new System.Drawing.Size(100, 20);
            this.tBxZombie.TabIndex = 3;
            // 
            // btbStartGame
            // 
            this.btbStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btbStartGame.Location = new System.Drawing.Point(528, 135);
            this.btbStartGame.Name = "btbStartGame";
            this.btbStartGame.Size = new System.Drawing.Size(158, 28);
            this.btbStartGame.TabIndex = 4;
            this.btbStartGame.Text = "START GAME";
            this.btbStartGame.UseVisualStyleBackColor = true;
            this.btbStartGame.Click += new System.EventHandler(this.btbStartGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(524, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter values:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(586, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Return";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolTip.ForeColor = System.Drawing.Color.Red;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 20;
            this.toolTip.ShowAlways = true;
            // 
            // pBoxHuman
            // 
            this.pBoxHuman.BackColor = System.Drawing.Color.Yellow;
            this.pBoxHuman.Location = new System.Drawing.Point(528, 312);
            this.pBoxHuman.Name = "pBoxHuman";
            this.pBoxHuman.Size = new System.Drawing.Size(25, 25);
            this.pBoxHuman.TabIndex = 12;
            this.pBoxHuman.TabStop = false;
            // 
            // pBoxMilitary
            // 
            this.pBoxMilitary.BackColor = System.Drawing.Color.Brown;
            this.pBoxMilitary.Location = new System.Drawing.Point(528, 343);
            this.pBoxMilitary.Name = "pBoxMilitary";
            this.pBoxMilitary.Size = new System.Drawing.Size(25, 25);
            this.pBoxMilitary.TabIndex = 13;
            this.pBoxMilitary.TabStop = false;
            // 
            // pBoxZombie
            // 
            this.pBoxZombie.BackColor = System.Drawing.Color.LawnGreen;
            this.pBoxZombie.Location = new System.Drawing.Point(528, 375);
            this.pBoxZombie.Name = "pBoxZombie";
            this.pBoxZombie.Size = new System.Drawing.Size(25, 25);
            this.pBoxZombie.TabIndex = 14;
            this.pBoxZombie.TabStop = false;
            // 
            // lblHuman
            // 
            this.lblHuman.AutoSize = true;
            this.lblHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHuman.Location = new System.Drawing.Point(570, 312);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(68, 17);
            this.lblHuman.TabIndex = 15;
            this.lblHuman.Text = "Humans: ";
            // 
            // lblMilitary
            // 
            this.lblMilitary.AutoSize = true;
            this.lblMilitary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMilitary.Location = new System.Drawing.Point(570, 343);
            this.lblMilitary.Name = "lblMilitary";
            this.lblMilitary.Size = new System.Drawing.Size(60, 17);
            this.lblMilitary.TabIndex = 16;
            this.lblMilitary.Text = "Military: ";
            // 
            // lblZombie
            // 
            this.lblZombie.AutoSize = true;
            this.lblZombie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZombie.Location = new System.Drawing.Point(570, 375);
            this.lblZombie.Name = "lblZombie";
            this.lblZombie.Size = new System.Drawing.Size(70, 17);
            this.lblZombie.TabIndex = 17;
            this.lblZombie.Text = "Zombies: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(698, 531);
            this.Controls.Add(this.lblZombie);
            this.Controls.Add(this.lblMilitary);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.pBoxZombie);
            this.Controls.Add(this.pBoxMilitary);
            this.Controls.Add(this.pBoxHuman);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btbStartGame);
            this.Controls.Add(this.tBxZombie);
            this.Controls.Add(this.tBxWojsko);
            this.Controls.Add(this.tBxCzlowiek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextTurn);
            this.Controls.Add(this.lblTurnNumber);
            this.Controls.Add(this.pnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zombie Apocalypse";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMilitary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxZombie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblTurnNumber;
        private System.Windows.Forms.Button btnNextTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBxCzlowiek;
        private System.Windows.Forms.TextBox tBxWojsko;
        private System.Windows.Forms.TextBox tBxZombie;
        private System.Windows.Forms.Button btbStartGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pBoxHuman;
        private System.Windows.Forms.PictureBox pBoxMilitary;
        private System.Windows.Forms.PictureBox pBoxZombie;
        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label lblMilitary;
        private System.Windows.Forms.Label lblZombie;
    }
}

