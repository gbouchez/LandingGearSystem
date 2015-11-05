namespace LandingGearSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.handleScrollBar = new System.Windows.Forms.VScrollBar();
            this.handleLabelText = new System.Windows.Forms.Label();
            this.handleUpLabel = new System.Windows.Forms.Label();
            this.handleDownLabel = new System.Windows.Forms.Label();
            this.pictureLight = new System.Windows.Forms.PictureBox();
            this.pbLeftGear = new System.Windows.Forms.PictureBox();
            this.pbFrontGear = new System.Windows.Forms.PictureBox();
            this.pbRightGear = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightGear)).BeginInit();
            this.SuspendLayout();
            // 
            // handleScrollBar
            // 
            this.handleScrollBar.LargeChange = 1;
            this.handleScrollBar.Location = new System.Drawing.Point(176, 22);
            this.handleScrollBar.Maximum = 1;
            this.handleScrollBar.Name = "handleScrollBar";
            this.handleScrollBar.Size = new System.Drawing.Size(17, 80);
            this.handleScrollBar.TabIndex = 0;
            this.handleScrollBar.ValueChanged += new System.EventHandler(this.handleScrollBar_ValueChanged);
            // 
            // handleLabelText
            // 
            this.handleLabelText.AutoSize = true;
            this.handleLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleLabelText.Location = new System.Drawing.Point(157, 9);
            this.handleLabelText.Name = "handleLabelText";
            this.handleLabelText.Size = new System.Drawing.Size(81, 13);
            this.handleLabelText.TabIndex = 1;
            this.handleLabelText.Text = "Handle State";
            // 
            // handleUpLabel
            // 
            this.handleUpLabel.AutoSize = true;
            this.handleUpLabel.Location = new System.Drawing.Point(196, 34);
            this.handleUpLabel.Name = "handleUpLabel";
            this.handleUpLabel.Size = new System.Drawing.Size(21, 13);
            this.handleUpLabel.TabIndex = 2;
            this.handleUpLabel.Text = "Up";
            // 
            // handleDownLabel
            // 
            this.handleDownLabel.AutoSize = true;
            this.handleDownLabel.Location = new System.Drawing.Point(196, 71);
            this.handleDownLabel.Name = "handleDownLabel";
            this.handleDownLabel.Size = new System.Drawing.Size(35, 13);
            this.handleDownLabel.TabIndex = 3;
            this.handleDownLabel.Text = "Down";
            // 
            // pictureLight
            // 
            this.pictureLight.Image = global::LandingGearSystem.Properties.Resources.feu_vide;
            this.pictureLight.Location = new System.Drawing.Point(15, 105);
            this.pictureLight.Name = "pictureLight";
            this.pictureLight.Size = new System.Drawing.Size(352, 97);
            this.pictureLight.TabIndex = 4;
            this.pictureLight.TabStop = false;
            // 
            // pbLeftGear
            // 
            this.pbLeftGear.Image = global::LandingGearSystem.Properties.Resources.gear2_retracted;
            this.pbLeftGear.Location = new System.Drawing.Point(12, 215);
            this.pbLeftGear.Name = "pbLeftGear";
            this.pbLeftGear.Size = new System.Drawing.Size(116, 112);
            this.pbLeftGear.TabIndex = 5;
            this.pbLeftGear.TabStop = false;
            // 
            // pbFrontGear
            // 
            this.pbFrontGear.Image = global::LandingGearSystem.Properties.Resources.gear2_retracted;
            this.pbFrontGear.Location = new System.Drawing.Point(134, 215);
            this.pbFrontGear.Name = "pbFrontGear";
            this.pbFrontGear.Size = new System.Drawing.Size(116, 112);
            this.pbFrontGear.TabIndex = 6;
            this.pbFrontGear.TabStop = false;
            // 
            // pbRightGear
            // 
            this.pbRightGear.Image = global::LandingGearSystem.Properties.Resources.gear2_retracted;
            this.pbRightGear.Location = new System.Drawing.Point(256, 215);
            this.pbRightGear.Name = "pbRightGear";
            this.pbRightGear.Size = new System.Drawing.Size(116, 112);
            this.pbRightGear.TabIndex = 7;
            this.pbRightGear.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 339);
            this.Controls.Add(this.pbRightGear);
            this.Controls.Add(this.pbFrontGear);
            this.Controls.Add(this.pbLeftGear);
            this.Controls.Add(this.pictureLight);
            this.Controls.Add(this.handleDownLabel);
            this.Controls.Add(this.handleUpLabel);
            this.Controls.Add(this.handleLabelText);
            this.Controls.Add(this.handleScrollBar);
            this.Name = "MainForm";
            this.Text = "Landing Gear System Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightGear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar handleScrollBar;
        private System.Windows.Forms.Label handleLabelText;
        private System.Windows.Forms.Label handleUpLabel;
        private System.Windows.Forms.Label handleDownLabel;
        private System.Windows.Forms.PictureBox pictureLight;
        private System.Windows.Forms.PictureBox pbLeftGear;
        private System.Windows.Forms.PictureBox pbFrontGear;
        private System.Windows.Forms.PictureBox pbRightGear;
    }
}

