namespace MainMenu
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.btnDice = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainName = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.MVaule = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.lblDiceValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SNVaule = new System.Windows.Forms.Label();
            this.PLVaule = new System.Windows.Forms.Label();
            this.BLVaule = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NEVaule = new System.Windows.Forms.Label();
            this.DCVaule = new System.Windows.Forms.Label();
            this.TrVaule = new System.Windows.Forms.Label();
            this.SpritCart = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SpriteHat = new System.Windows.Forms.PictureBox();
            this.SpriteShoe = new System.Windows.Forms.PictureBox();
            this.SpriteCar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpritCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteShoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(507, 721);
            this.btnDice.Margin = new System.Windows.Forms.Padding(2);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(145, 31);
            this.btnDice.TabIndex = 0;
            this.btnDice.Text = "Roll Dice and Move";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadAllGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadAllGameToolStripMenuItem
            // 
            this.loadAllGameToolStripMenuItem.Name = "loadAllGameToolStripMenuItem";
            this.loadAllGameToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loadAllGameToolStripMenuItem.Text = "Load Previous Game";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // lblMainName
            // 
            this.lblMainName.AutoSize = true;
            this.lblMainName.Location = new System.Drawing.Point(21, 70);
            this.lblMainName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainName.Name = "lblMainName";
            this.lblMainName.Size = new System.Drawing.Size(43, 13);
            this.lblMainName.TabIndex = 5;
            this.lblMainName.Text = "Player#";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(21, 136);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(39, 13);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "Money";
            // 
            // MVaule
            // 
            this.MVaule.AutoSize = true;
            this.MVaule.Location = new System.Drawing.Point(98, 136);
            this.MVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MVaule.Name = "MVaule";
            this.MVaule.Size = new System.Drawing.Size(43, 13);
            this.MVaule.TabIndex = 7;
            this.MVaule.Text = "MVaule";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.Location = new System.Drawing.Point(11, 507);
            this.lblProperties.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(167, 24);
            this.lblProperties.TabIndex = 8;
            this.lblProperties.Text = "Owned Properties:";
            // 
            // lblDiceValue
            // 
            this.lblDiceValue.AutoSize = true;
            this.lblDiceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceValue.Location = new System.Drawing.Point(384, 670);
            this.lblDiceValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiceValue.Name = "lblDiceValue";
            this.lblDiceValue.Size = new System.Drawing.Size(199, 24);
            this.lblDiceValue.TabIndex = 10;
            this.lblDiceValue.Text = "Dice Number Rolled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "SpiteName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Player Loction";
            // 
            // SNVaule
            // 
            this.SNVaule.AutoSize = true;
            this.SNVaule.Location = new System.Drawing.Point(98, 166);
            this.SNVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SNVaule.Name = "SNVaule";
            this.SNVaule.Size = new System.Drawing.Size(49, 13);
            this.SNVaule.TabIndex = 16;
            this.SNVaule.Text = "SNVaule";
            // 
            // PLVaule
            // 
            this.PLVaule.AutoSize = true;
            this.PLVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLVaule.Location = new System.Drawing.Point(125, 208);
            this.PLVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PLVaule.Name = "PLVaule";
            this.PLVaule.Size = new System.Drawing.Size(69, 20);
            this.PLVaule.TabIndex = 17;
            this.PLVaule.Text = "PLVaule";
            // 
            // BLVaule
            // 
            this.BLVaule.AutoSize = true;
            this.BLVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLVaule.Location = new System.Drawing.Point(1035, 238);
            this.BLVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BLVaule.Name = "BLVaule";
            this.BLVaule.Size = new System.Drawing.Size(70, 20);
            this.BLVaule.TabIndex = 18;
            this.BLVaule.Text = "BLVaule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(888, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Block Loction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Name";
            // 
            // NEVaule
            // 
            this.NEVaule.AutoSize = true;
            this.NEVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEVaule.Location = new System.Drawing.Point(448, 52);
            this.NEVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NEVaule.Name = "NEVaule";
            this.NEVaule.Size = new System.Drawing.Size(121, 31);
            this.NEVaule.TabIndex = 21;
            this.NEVaule.Text = "NEVaule";
            // 
            // DCVaule
            // 
            this.DCVaule.AutoSize = true;
            this.DCVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCVaule.Location = new System.Drawing.Point(609, 670);
            this.DCVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DCVaule.Name = "DCVaule";
            this.DCVaule.Size = new System.Drawing.Size(97, 25);
            this.DCVaule.TabIndex = 22;
            this.DCVaule.Text = "DCVaule";
            // 
            // TrVaule
            // 
            this.TrVaule.AutoSize = true;
            this.TrVaule.Location = new System.Drawing.Point(68, 70);
            this.TrVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrVaule.Name = "TrVaule";
            this.TrVaule.Size = new System.Drawing.Size(44, 13);
            this.TrVaule.TabIndex = 23;
            this.TrVaule.Text = "TrVaule";
            // 
            // SpritCart
            // 
            this.SpritCart.BackColor = System.Drawing.Color.Transparent;
            this.SpritCart.Image = ((System.Drawing.Image)(resources.GetObject("SpritCart.Image")));
            this.SpritCart.Location = new System.Drawing.Point(775, 512);
            this.SpritCart.Name = "SpritCart";
            this.SpritCart.Size = new System.Drawing.Size(76, 63);
            this.SpritCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpritCart.TabIndex = 24;
            this.SpritCart.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1085, 725);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "NextPlayer";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SpriteHat
            // 
            this.SpriteHat.BackColor = System.Drawing.Color.Transparent;
            this.SpriteHat.Image = ((System.Drawing.Image)(resources.GetObject("SpriteHat.Image")));
            this.SpriteHat.Location = new System.Drawing.Point(775, 440);
            this.SpriteHat.Name = "SpriteHat";
            this.SpriteHat.Size = new System.Drawing.Size(76, 66);
            this.SpriteHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpriteHat.TabIndex = 26;
            this.SpriteHat.TabStop = false;
            // 
            // SpriteShoe
            // 
            this.SpriteShoe.BackColor = System.Drawing.Color.Transparent;
            this.SpriteShoe.Image = ((System.Drawing.Image)(resources.GetObject("SpriteShoe.Image")));
            this.SpriteShoe.Location = new System.Drawing.Point(775, 602);
            this.SpriteShoe.Name = "SpriteShoe";
            this.SpriteShoe.Size = new System.Drawing.Size(76, 72);
            this.SpriteShoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpriteShoe.TabIndex = 27;
            this.SpriteShoe.TabStop = false;
            // 
            // SpriteCar
            // 
            this.SpriteCar.BackColor = System.Drawing.Color.Transparent;
            this.SpriteCar.Image = ((System.Drawing.Image)(resources.GetObject("SpriteCar.Image")));
            this.SpriteCar.Location = new System.Drawing.Point(775, 374);
            this.SpriteCar.Name = "SpriteCar";
            this.SpriteCar.Size = new System.Drawing.Size(76, 60);
            this.SpriteCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpriteCar.TabIndex = 28;
            this.SpriteCar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Turns";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 721);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(919, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bank Manger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(896, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Would you Like to Buy";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(1039, 483);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 33;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(925, 483);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 34;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1172, 748);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpriteCar);
            this.Controls.Add(this.SpriteShoe);
            this.Controls.Add(this.SpriteHat);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.SpritCart);
            this.Controls.Add(this.TrVaule);
            this.Controls.Add(this.DCVaule);
            this.Controls.Add(this.NEVaule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BLVaule);
            this.Controls.Add(this.PLVaule);
            this.Controls.Add(this.SNVaule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiceValue);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.MVaule);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblMainName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpritCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteShoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblMainName;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label MVaule;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Label lblDiceValue;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SNVaule;
        private System.Windows.Forms.Label PLVaule;
        private System.Windows.Forms.Label BLVaule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NEVaule;
        private System.Windows.Forms.Label DCVaule;
        private System.Windows.Forms.Label TrVaule;
        private System.Windows.Forms.PictureBox SpritCart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox SpriteHat;
        private System.Windows.Forms.PictureBox SpriteShoe;
        private System.Windows.Forms.PictureBox SpriteCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}