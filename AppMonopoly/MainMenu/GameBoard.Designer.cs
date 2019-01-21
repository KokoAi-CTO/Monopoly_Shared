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
            this.SNVaule = new System.Windows.Forms.Label();
            this.PLVaule = new System.Windows.Forms.Label();
            this.BLVaule = new System.Windows.Forms.Label();
            this.NEVaule = new System.Windows.Forms.Label();
            this.DCVaule = new System.Windows.Forms.Label();
            this.TrVaule = new System.Windows.Forms.Label();
            this.SpritSim = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SpriteCry = new System.Windows.Forms.PictureBox();
            this.SpriteLove = new System.Windows.Forms.PictureBox();
            this.SpriteSimle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WYLB = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.OPVaule = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbnScores = new System.Windows.Forms.Label();
            this.lbnMony = new System.Windows.Forms.Label();
            this.lbnPLoc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbn2BlVaule = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpritSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteCry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteSimle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDice
            // 
            this.btnDice.BackColor = System.Drawing.Color.Transparent;
            this.btnDice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDice.BackgroundImage")));
            this.btnDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDice.Location = new System.Drawing.Point(488, 739);
            this.btnDice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(261, 47);
            this.btnDice.TabIndex = 0;
            this.btnDice.Text = "Roll Dice and Move";
            this.btnDice.UseVisualStyleBackColor = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.lblMainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainName.Location = new System.Drawing.Point(570, 39);
            this.lblMainName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainName.Name = "lblMainName";
            this.lblMainName.Size = new System.Drawing.Size(72, 24);
            this.lblMainName.TabIndex = 5;
            this.lblMainName.Text = "Player#";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Green;
            this.lblMoney.Location = new System.Drawing.Point(21, 317);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(79, 24);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "Money:";
            // 
            // MVaule
            // 
            this.MVaule.AutoSize = true;
            this.MVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVaule.Location = new System.Drawing.Point(100, 317);
            this.MVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MVaule.Name = "MVaule";
            this.MVaule.Size = new System.Drawing.Size(75, 24);
            this.MVaule.TabIndex = 7;
            this.MVaule.Text = "MVaule";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.ForeColor = System.Drawing.Color.Black;
            this.lblProperties.Location = new System.Drawing.Point(16, 507);
            this.lblProperties.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(167, 24);
            this.lblProperties.TabIndex = 8;
            this.lblProperties.Text = "Owned Properties:";
            // 
            // lblDiceValue
            // 
            this.lblDiceValue.AutoSize = true;
            this.lblDiceValue.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceValue.Location = new System.Drawing.Point(457, 703);
            this.lblDiceValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiceValue.Name = "lblDiceValue";
            this.lblDiceValue.Size = new System.Drawing.Size(207, 23);
            this.lblDiceValue.TabIndex = 10;
            this.lblDiceValue.Text = "Dice Number Rolled:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "SpiteName:";
            // 
            // SNVaule
            // 
            this.SNVaule.AutoSize = true;
            this.SNVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNVaule.Location = new System.Drawing.Point(182, 244);
            this.SNVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SNVaule.Name = "SNVaule";
            this.SNVaule.Size = new System.Drawing.Size(85, 24);
            this.SNVaule.TabIndex = 16;
            this.SNVaule.Text = "SNVaule";
            this.SNVaule.Click += new System.EventHandler(this.SNVaule_Click);
            // 
            // PLVaule
            // 
            this.PLVaule.AutoSize = true;
            this.PLVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLVaule.Location = new System.Drawing.Point(278, 277);
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
            this.BLVaule.Location = new System.Drawing.Point(1151, 448);
            this.BLVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BLVaule.Name = "BLVaule";
            this.BLVaule.Size = new System.Drawing.Size(70, 20);
            this.BLVaule.TabIndex = 18;
            this.BLVaule.Text = "BLVaule";
            // 
            // NEVaule
            // 
            this.NEVaule.AutoSize = true;
            this.NEVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEVaule.Location = new System.Drawing.Point(512, 77);
            this.NEVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NEVaule.Name = "NEVaule";
            this.NEVaule.Size = new System.Drawing.Size(90, 31);
            this.NEVaule.TabIndex = 21;
            this.NEVaule.Text = "Name";
            // 
            // DCVaule
            // 
            this.DCVaule.AutoSize = true;
            this.DCVaule.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCVaule.Location = new System.Drawing.Point(668, 703);
            this.DCVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DCVaule.Name = "DCVaule";
            this.DCVaule.Size = new System.Drawing.Size(91, 25);
            this.DCVaule.TabIndex = 22;
            this.DCVaule.Text = "DCVaule";
            // 
            // TrVaule
            // 
            this.TrVaule.AutoSize = true;
            this.TrVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrVaule.Location = new System.Drawing.Point(646, 39);
            this.TrVaule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrVaule.Name = "TrVaule";
            this.TrVaule.Size = new System.Drawing.Size(20, 24);
            this.TrVaule.TabIndex = 23;
            this.TrVaule.Text = "1";
            // 
            // SpritSim
            // 
            this.SpritSim.BackColor = System.Drawing.Color.Transparent;
            this.SpritSim.Image = ((System.Drawing.Image)(resources.GetObject("SpritSim.Image")));
            this.SpritSim.Location = new System.Drawing.Point(833, 564);
            this.SpritSim.Name = "SpritSim";
            this.SpritSim.Size = new System.Drawing.Size(47, 49);
            this.SpritSim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpritSim.TabIndex = 24;
            this.SpritSim.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1031, 741);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(190, 45);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "NextPlayer";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SpriteCry
            // 
            this.SpriteCry.BackColor = System.Drawing.Color.Transparent;
            this.SpriteCry.Image = ((System.Drawing.Image)(resources.GetObject("SpriteCry.Image")));
            this.SpriteCry.Location = new System.Drawing.Point(786, 564);
            this.SpriteCry.Name = "SpriteCry";
            this.SpriteCry.Size = new System.Drawing.Size(48, 49);
            this.SpriteCry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpriteCry.TabIndex = 26;
            this.SpriteCry.TabStop = false;
            // 
            // SpriteLove
            // 
            this.SpriteLove.BackColor = System.Drawing.Color.Transparent;
            this.SpriteLove.Image = ((System.Drawing.Image)(resources.GetObject("SpriteLove.Image")));
            this.SpriteLove.Location = new System.Drawing.Point(833, 607);
            this.SpriteLove.Name = "SpriteLove";
            this.SpriteLove.Size = new System.Drawing.Size(47, 52);
            this.SpriteLove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpriteLove.TabIndex = 27;
            this.SpriteLove.TabStop = false;
            // 
            // SpriteSimle
            // 
            this.SpriteSimle.BackColor = System.Drawing.Color.Transparent;
            this.SpriteSimle.Image = ((System.Drawing.Image)(resources.GetObject("SpriteSimle.Image")));
            this.SpriteSimle.Location = new System.Drawing.Point(786, 607);
            this.SpriteSimle.Name = "SpriteSimle";
            this.SpriteSimle.Size = new System.Drawing.Size(48, 52);
            this.SpriteSimle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpriteSimle.TabIndex = 28;
            this.SpriteSimle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "S\' turn";
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(24, 754);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 30;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1010, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bank Dipshit";
            // 
            // WYLB
            // 
            this.WYLB.AutoSize = true;
            this.WYLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WYLB.Location = new System.Drawing.Point(948, 448);
            this.WYLB.Name = "WYLB";
            this.WYLB.Size = new System.Drawing.Size(174, 20);
            this.WYLB.TabIndex = 32;
            this.WYLB.Text = "Would you Like to Buy?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.LawnGreen;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(1137, 507);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(84, 37);
            this.btnYes.TabIndex = 33;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(1031, 507);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(91, 37);
            this.btnNo.TabIndex = 34;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // OPVaule
            // 
            this.OPVaule.AutoSize = true;
            this.OPVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPVaule.Location = new System.Drawing.Point(18, 542);
            this.OPVaule.Name = "OPVaule";
            this.OPVaule.Size = new System.Drawing.Size(86, 24);
            this.OPVaule.TabIndex = 35;
            this.OPVaule.Text = "OPVaule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(786, 665);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1054, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // lbnScores
            // 
            this.lbnScores.AutoSize = true;
            this.lbnScores.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnScores.Location = new System.Drawing.Point(987, 271);
            this.lbnScores.Name = "lbnScores";
            this.lbnScores.Size = new System.Drawing.Size(0, 19);
            this.lbnScores.TabIndex = 38;
            // 
            // lbnMony
            // 
            this.lbnMony.AutoSize = true;
            this.lbnMony.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMony.Location = new System.Drawing.Point(987, 290);
            this.lbnMony.Name = "lbnMony";
            this.lbnMony.Size = new System.Drawing.Size(0, 19);
            this.lbnMony.TabIndex = 39;
            // 
            // lbnPLoc
            // 
            this.lbnPLoc.AutoSize = true;
            this.lbnPLoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnPLoc.Location = new System.Drawing.Point(987, 309);
            this.lbnPLoc.Name = "lbnPLoc";
            this.lbnPLoc.Size = new System.Drawing.Size(0, 19);
            this.lbnPLoc.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(919, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Money";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(919, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ploc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(919, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "Names";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1077, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "Scores";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 46;
            this.label12.Text = "Current Location:";
            // 
            // lbn2BlVaule
            // 
            this.lbn2BlVaule.AutoSize = true;
            this.lbn2BlVaule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn2BlVaule.Location = new System.Drawing.Point(182, 273);
            this.lbn2BlVaule.Name = "lbn2BlVaule";
            this.lbn2BlVaule.Size = new System.Drawing.Size(91, 24);
            this.lbn2BlVaule.TabIndex = 47;
            this.lbn2BlVaule.Text = "BL2Vaule";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(49, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 31);
            this.label6.TabIndex = 50;
            this.label6.Text = "Player Info";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1251, 810);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbn2BlVaule);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbnPLoc);
            this.Controls.Add(this.lbnMony);
            this.Controls.Add(this.lbnScores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OPVaule);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.WYLB);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpriteSimle);
            this.Controls.Add(this.SpriteLove);
            this.Controls.Add(this.SpriteCry);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.SpritSim);
            this.Controls.Add(this.TrVaule);
            this.Controls.Add(this.DCVaule);
            this.Controls.Add(this.NEVaule);
            this.Controls.Add(this.BLVaule);
            this.Controls.Add(this.PLVaule);
            this.Controls.Add(this.SNVaule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiceValue);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.MVaule);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblMainName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDice);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpritSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteCry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteSimle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label SNVaule;
        private System.Windows.Forms.Label PLVaule;
        private System.Windows.Forms.Label BLVaule;
        private System.Windows.Forms.Label NEVaule;
        private System.Windows.Forms.Label DCVaule;
        private System.Windows.Forms.Label TrVaule;
        private System.Windows.Forms.PictureBox SpritSim;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox SpriteCry;
        private System.Windows.Forms.PictureBox SpriteLove;
        private System.Windows.Forms.PictureBox SpriteSimle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WYLB;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label OPVaule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbnScores;
        private System.Windows.Forms.Label lbnMony;
        private System.Windows.Forms.Label lbnPLoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbn2BlVaule;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
    }
}