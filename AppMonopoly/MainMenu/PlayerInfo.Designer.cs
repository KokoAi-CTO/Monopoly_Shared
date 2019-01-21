namespace MainMenu
{
    partial class PlayerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerInfo));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPly1 = new System.Windows.Forms.Label();
            this.lblPlyrnames = new System.Windows.Forms.Label();
            this.PlayerBox1 = new System.Windows.Forms.TextBox();
            this.lblsprite = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblWhatPlayer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RDSmile = new System.Windows.Forms.RadioButton();
            this.RdSim = new System.Windows.Forms.RadioButton();
            this.RDCry = new System.Windows.Forms.RadioButton();
            this.RDLove = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 535);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(819, 535);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 33);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
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
            // lblPly1
            // 
            this.lblPly1.AutoSize = true;
            this.lblPly1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPly1.Location = new System.Drawing.Point(384, 124);
            this.lblPly1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPly1.Name = "lblPly1";
            this.lblPly1.Size = new System.Drawing.Size(77, 24);
            this.lblPly1.TabIndex = 5;
            this.lblPly1.Text = "Player #";
            // 
            // lblPlyrnames
            // 
            this.lblPlyrnames.AutoSize = true;
            this.lblPlyrnames.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyrnames.Location = new System.Drawing.Point(341, 70);
            this.lblPlyrnames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlyrnames.Name = "lblPlyrnames";
            this.lblPlyrnames.Size = new System.Drawing.Size(202, 19);
            this.lblPlyrnames.TabIndex = 9;
            this.lblPlyrnames.Text = "ENTER PLAYER NAMES ";
            // 
            // PlayerBox1
            // 
            this.PlayerBox1.Location = new System.Drawing.Point(369, 176);
            this.PlayerBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerBox1.Name = "PlayerBox1";
            this.PlayerBox1.Size = new System.Drawing.Size(118, 20);
            this.PlayerBox1.TabIndex = 10;
            // 
            // lblsprite
            // 
            this.lblsprite.AutoSize = true;
            this.lblsprite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsprite.Location = new System.Drawing.Point(283, 226);
            this.lblsprite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsprite.Name = "lblsprite";
            this.lblsprite.Size = new System.Drawing.Size(335, 24);
            this.lblsprite.TabIndex = 14;
            this.lblsprite.Text = "SELECT SPRITE FOR EACH PLAYER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 324);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 324);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(476, 324);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(705, 324);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(183, 193);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // lblWhatPlayer
            // 
            this.lblWhatPlayer.AutoSize = true;
            this.lblWhatPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatPlayer.Location = new System.Drawing.Point(467, 124);
            this.lblWhatPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhatPlayer.Name = "lblWhatPlayer";
            this.lblWhatPlayer.Size = new System.Drawing.Size(20, 24);
            this.lblWhatPlayer.TabIndex = 23;
            this.lblWhatPlayer.Text = "1";
            // 
            // RDSmile
            // 
            this.RDSmile.AutoSize = true;
            this.RDSmile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDSmile.Location = new System.Drawing.Point(37, 285);
            this.RDSmile.Name = "RDSmile";
            this.RDSmile.Size = new System.Drawing.Size(68, 22);
            this.RDSmile.TabIndex = 24;
            this.RDSmile.TabStop = true;
            this.RDSmile.Text = "Simle";
            this.RDSmile.UseVisualStyleBackColor = true;
            // 
            // RdSim
            // 
            this.RdSim.AutoSize = true;
            this.RdSim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdSim.Location = new System.Drawing.Point(251, 285);
            this.RdSim.Name = "RdSim";
            this.RdSim.Size = new System.Drawing.Size(57, 23);
            this.RdSim.TabIndex = 25;
            this.RdSim.TabStop = true;
            this.RdSim.Text = "Sim";
            this.RdSim.UseVisualStyleBackColor = true;
            // 
            // RDCry
            // 
            this.RDCry.AutoSize = true;
            this.RDCry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDCry.Location = new System.Drawing.Point(476, 285);
            this.RDCry.Name = "RDCry";
            this.RDCry.Size = new System.Drawing.Size(54, 23);
            this.RDCry.TabIndex = 26;
            this.RDCry.TabStop = true;
            this.RDCry.Text = "Cry";
            this.RDCry.UseVisualStyleBackColor = true;
            // 
            // RDLove
            // 
            this.RDLove.AutoSize = true;
            this.RDLove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDLove.Location = new System.Drawing.Point(705, 285);
            this.RDLove.Name = "RDLove";
            this.RDLove.Size = new System.Drawing.Size(65, 23);
            this.RDLove.TabIndex = 27;
            this.RDLove.TabStop = true;
            this.RDLove.Text = "Love";
            this.RDLove.UseVisualStyleBackColor = true;
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 579);
            this.Controls.Add(this.RDLove);
            this.Controls.Add(this.RDCry);
            this.Controls.Add(this.RdSim);
            this.Controls.Add(this.RDSmile);
            this.Controls.Add(this.lblWhatPlayer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblsprite);
            this.Controls.Add(this.PlayerBox1);
            this.Controls.Add(this.lblPlyrnames);
            this.Controls.Add(this.lblPly1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerInfo";
            this.Text = "PlayerInfo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblPly1;
        private System.Windows.Forms.Label lblPlyrnames;
        private System.Windows.Forms.TextBox PlayerBox1;
        private System.Windows.Forms.Label lblsprite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblWhatPlayer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton RDSmile;
        private System.Windows.Forms.RadioButton RdSim;
        private System.Windows.Forms.RadioButton RDCry;
        private System.Windows.Forms.RadioButton RDLove;
    }
}