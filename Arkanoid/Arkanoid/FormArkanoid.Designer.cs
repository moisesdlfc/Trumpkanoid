namespace Arkanoid
{
    partial class FormArkanoid
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArkanoid));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPelota = new System.Windows.Forms.PictureBox();
            this.pictureBoxBarra = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.textoVida = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidas1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidas2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidas3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.espacioSeparador = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBossLife = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidaBoss1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidaBoss2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidaBoss3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidaBoss4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vidaBoss5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxGameOver = new System.Windows.Forms.PictureBox();
            this.labelPress = new System.Windows.Forms.Label();
            this.pictureSpace = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlock = new System.Windows.Forms.PictureBox();
            this.pictureBoxFinalBoss = new System.Windows.Forms.PictureBox();
            this.pictureBoxBossSano = new System.Windows.Forms.PictureBox();
            this.pictureBoxVictory = new System.Windows.Forms.PictureBox();
            this.pictureBoxBossHerido1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBossHerido2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxInitialImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarra)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinalBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossSano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVictory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossHerido1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossHerido2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInitialImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBoxPelota
            // 
            this.pictureBoxPelota.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxPelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPelota.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPelota.Image")));
            this.pictureBoxPelota.Location = new System.Drawing.Point(416, 440);
            this.pictureBoxPelota.Name = "pictureBoxPelota";
            this.pictureBoxPelota.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPelota.TabIndex = 0;
            this.pictureBoxPelota.TabStop = false;
            // 
            // pictureBoxBarra
            // 
            this.pictureBoxBarra.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBarra.Image")));
            this.pictureBoxBarra.Location = new System.Drawing.Point(342, 486);
            this.pictureBoxBarra.Name = "pictureBoxBarra";
            this.pictureBoxBarra.Size = new System.Drawing.Size(180, 35);
            this.pictureBoxBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarra.TabIndex = 1;
            this.pictureBoxBarra.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoVida,
            this.vidas1,
            this.vidas2,
            this.vidas3,
            this.espacioSeparador,
            this.textBossLife,
            this.vidaBoss1,
            this.vidaBoss2,
            this.vidaBoss3,
            this.vidaBoss4,
            this.vidaBoss5});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // textoVida
            // 
            this.textoVida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textoVida.ForeColor = System.Drawing.Color.Red;
            this.textoVida.Name = "textoVida";
            this.textoVida.Size = new System.Drawing.Size(39, 17);
            this.textoVida.Text = "VIDAS";
            // 
            // vidas1
            // 
            this.vidas1.Image = ((System.Drawing.Image)(resources.GetObject("vidas1.Image")));
            this.vidas1.Name = "vidas1";
            this.vidas1.Size = new System.Drawing.Size(16, 17);
            // 
            // vidas2
            // 
            this.vidas2.Image = ((System.Drawing.Image)(resources.GetObject("vidas2.Image")));
            this.vidas2.Name = "vidas2";
            this.vidas2.Size = new System.Drawing.Size(16, 17);
            // 
            // vidas3
            // 
            this.vidas3.Image = ((System.Drawing.Image)(resources.GetObject("vidas3.Image")));
            this.vidas3.Name = "vidas3";
            this.vidas3.Size = new System.Drawing.Size(16, 17);
            // 
            // espacioSeparador
            // 
            this.espacioSeparador.Name = "espacioSeparador";
            this.espacioSeparador.Size = new System.Drawing.Size(583, 17);
            this.espacioSeparador.Text = "                                                                                 " +
    "                                                                                " +
    "                               ";
            // 
            // textBossLife
            // 
            this.textBossLife.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBossLife.Name = "textBossLife";
            this.textBossLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBossLife.Size = new System.Drawing.Size(47, 17);
            this.textBossLife.Text = "TRUMP";
            // 
            // vidaBoss1
            // 
            this.vidaBoss1.Image = ((System.Drawing.Image)(resources.GetObject("vidaBoss1.Image")));
            this.vidaBoss1.Name = "vidaBoss1";
            this.vidaBoss1.Size = new System.Drawing.Size(16, 17);
            // 
            // vidaBoss2
            // 
            this.vidaBoss2.Image = ((System.Drawing.Image)(resources.GetObject("vidaBoss2.Image")));
            this.vidaBoss2.Name = "vidaBoss2";
            this.vidaBoss2.Size = new System.Drawing.Size(16, 17);
            // 
            // vidaBoss3
            // 
            this.vidaBoss3.Image = ((System.Drawing.Image)(resources.GetObject("vidaBoss3.Image")));
            this.vidaBoss3.Name = "vidaBoss3";
            this.vidaBoss3.Size = new System.Drawing.Size(16, 17);
            // 
            // vidaBoss4
            // 
            this.vidaBoss4.Image = ((System.Drawing.Image)(resources.GetObject("vidaBoss4.Image")));
            this.vidaBoss4.Name = "vidaBoss4";
            this.vidaBoss4.Size = new System.Drawing.Size(16, 17);
            // 
            // vidaBoss5
            // 
            this.vidaBoss5.Image = ((System.Drawing.Image)(resources.GetObject("vidaBoss5.Image")));
            this.vidaBoss5.Name = "vidaBoss5";
            this.vidaBoss5.Size = new System.Drawing.Size(16, 17);
            // 
            // pictureBoxGameOver
            // 
            this.pictureBoxGameOver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGameOver.Image")));
            this.pictureBoxGameOver.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGameOver.Name = "pictureBoxGameOver";
            this.pictureBoxGameOver.Size = new System.Drawing.Size(872, 537);
            this.pictureBoxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGameOver.TabIndex = 3;
            this.pictureBoxGameOver.TabStop = false;
            this.pictureBoxGameOver.Visible = false;
            // 
            // pictureBoxInitialImage
            // 
            this.pictureBoxInitialImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInitialImage.Image")));
            this.pictureBoxInitialImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInitialImage.Name = "pictureBoxInitialImage";
            this.pictureBoxInitialImage.Size = new System.Drawing.Size(884, 550);
            this.pictureBoxInitialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInitialImage.TabIndex = 12;
            this.pictureBoxInitialImage.TabStop = false;
            this.pictureBoxInitialImage.Visible = false;
            // 
            // labelPress
            // 
            this.labelPress.AutoSize = true;
            this.labelPress.BackColor = System.Drawing.Color.Transparent;
            this.labelPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPress.Location = new System.Drawing.Point(386, 330);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(89, 31);
            this.labelPress.TabIndex = 4;
            this.labelPress.Text = "Press";
            this.labelPress.Visible = false;
            // 
            // pictureSpace
            // 
            this.pictureSpace.BackColor = System.Drawing.Color.Transparent;
            this.pictureSpace.Image = ((System.Drawing.Image)(resources.GetObject("pictureSpace.Image")));
            this.pictureSpace.Location = new System.Drawing.Point(355, 400);
            this.pictureSpace.Name = "pictureSpace";
            this.pictureSpace.Size = new System.Drawing.Size(149, 127);
            this.pictureSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSpace.TabIndex = 5;
            this.pictureSpace.TabStop = false;
            this.pictureSpace.Visible = false;
            // 
            // pictureBoxBlock
            // 
            this.pictureBoxBlock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlock.Image")));
            this.pictureBoxBlock.Location = new System.Drawing.Point(25, 25);
            this.pictureBoxBlock.Name = "pictureBoxBlock";
            this.pictureBoxBlock.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlock.TabIndex = 6;
            this.pictureBoxBlock.TabStop = false;
            this.pictureBoxBlock.Visible = false;
            // 
            // pictureBoxBossSano
            // 
            this.pictureBoxBossSano.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBossSano.Image")));
            this.pictureBoxBossSano.Location = new System.Drawing.Point(25, 440);
            this.pictureBoxBossSano.Name = "pictureBoxBossSano";
            this.pictureBoxBossSano.Size = new System.Drawing.Size(65, 76);
            this.pictureBoxBossSano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBossSano.TabIndex = 11;
            this.pictureBoxBossSano.TabStop = false;
            this.pictureBoxBossSano.Visible = false;
            // 
            // pictureBoxVictory
            // 
            this.pictureBoxVictory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVictory.Image")));
            this.pictureBoxVictory.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVictory.Name = "pictureBoxVictory";
            this.pictureBoxVictory.Size = new System.Drawing.Size(884, 537);
            this.pictureBoxVictory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVictory.TabIndex = 8;
            this.pictureBoxVictory.TabStop = false;
            this.pictureBoxVictory.Visible = false;
            // 
            // pictureBoxBossHerido1
            // 
            this.pictureBoxBossHerido1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBossHerido1.Image")));
            this.pictureBoxBossHerido1.Location = new System.Drawing.Point(96, 440);
            this.pictureBoxBossHerido1.Name = "pictureBoxBossHerido1";
            this.pictureBoxBossHerido1.Size = new System.Drawing.Size(67, 83);
            this.pictureBoxBossHerido1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBossHerido1.TabIndex = 9;
            this.pictureBoxBossHerido1.TabStop = false;
            this.pictureBoxBossHerido1.Visible = false;
            // 
            // pictureBoxBossHerido2
            // 
            this.pictureBoxBossHerido2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBossHerido2.Image")));
            this.pictureBoxBossHerido2.Location = new System.Drawing.Point(169, 437);
            this.pictureBoxBossHerido2.Name = "pictureBoxBossHerido2";
            this.pictureBoxBossHerido2.Size = new System.Drawing.Size(77, 84);
            this.pictureBoxBossHerido2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBossHerido2.TabIndex = 10;
            this.pictureBoxBossHerido2.TabStop = false;
            this.pictureBoxBossHerido2.Visible = false;
            //
            // pictureBoxFinalBoss
            // 
            this.pictureBoxFinalBoss.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFinalBoss.Image = this.pictureBoxBossSano.Image;
            this.pictureBoxFinalBoss.Location = new System.Drawing.Point(402, 12);
            this.pictureBoxFinalBoss.Name = "pictureBoxFinalBoss";
            this.pictureBoxFinalBoss.Size = new System.Drawing.Size(64, 80);
            this.pictureBoxFinalBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFinalBoss.TabIndex = 7;
            this.pictureBoxFinalBoss.TabStop = false;
            // 
            // FormArkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.pictureBoxInitialImage);
            this.Controls.Add(this.pictureBoxVictory);
            this.Controls.Add(this.pictureBoxGameOver);
            this.Controls.Add(this.pictureBoxBossSano);
            this.Controls.Add(this.pictureBoxBossHerido2);
            this.Controls.Add(this.pictureBoxBossHerido1);
            this.Controls.Add(this.pictureBoxFinalBoss);
            this.Controls.Add(this.pictureBoxBlock);
            this.Controls.Add(this.pictureSpace);
            this.Controls.Add(this.labelPress);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBoxBarra);
            this.Controls.Add(this.pictureBoxPelota);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormArkanoid";
            this.Text = "Arkanoid";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArkanoid_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empezarJuego);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormArkanoid_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarra)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinalBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossSano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVictory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossHerido1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBossHerido2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInitialImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxPelota;
        private System.Windows.Forms.PictureBox pictureBoxBarra;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel textoVida;
        private System.Windows.Forms.ToolStripStatusLabel vidas1;
        private System.Windows.Forms.ToolStripStatusLabel vidas2;
        private System.Windows.Forms.ToolStripStatusLabel vidas3;
        private System.Windows.Forms.PictureBox pictureBoxGameOver;
        private System.Windows.Forms.Label labelPress;
        private System.Windows.Forms.PictureBox pictureSpace;
        private System.Windows.Forms.PictureBox pictureBoxBlock;
        private System.Windows.Forms.PictureBox pictureBoxFinalBoss;
        private System.Windows.Forms.ToolStripStatusLabel espacioSeparador;
        private System.Windows.Forms.ToolStripStatusLabel textBossLife;
        private System.Windows.Forms.ToolStripStatusLabel vidaBoss1;
        private System.Windows.Forms.ToolStripStatusLabel vidaBoss2;
        private System.Windows.Forms.ToolStripStatusLabel vidaBoss3;
        private System.Windows.Forms.ToolStripStatusLabel vidaBoss4;
        private System.Windows.Forms.ToolStripStatusLabel vidaBoss5;
        private System.Windows.Forms.PictureBox pictureBoxVictory;
        private System.Windows.Forms.PictureBox pictureBoxBossHerido1;
        private System.Windows.Forms.PictureBox pictureBoxBossHerido2;
        private System.Windows.Forms.PictureBox pictureBoxBossSano;
        private System.Windows.Forms.PictureBox pictureBoxInitialImage;
    }
}

