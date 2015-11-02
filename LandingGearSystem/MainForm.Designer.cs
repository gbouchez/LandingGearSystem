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
            this.SuspendLayout();
            // 
            // handleScrollBar
            // 
            this.handleScrollBar.LargeChange = 1;
            this.handleScrollBar.Location = new System.Drawing.Point(15, 22);
            this.handleScrollBar.Maximum = 1;
            this.handleScrollBar.Name = "handleScrollBar";
            this.handleScrollBar.Size = new System.Drawing.Size(17, 80);
            this.handleScrollBar.TabIndex = 0;
            this.handleScrollBar.Value = 1;
            this.handleScrollBar.ValueChanged += new System.EventHandler(this.handleScrollBar_ValueChanged);
            // 
            // handleLabelText
            // 
            this.handleLabelText.AutoSize = true;
            this.handleLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleLabelText.Location = new System.Drawing.Point(12, 9);
            this.handleLabelText.Name = "handleLabelText";
            this.handleLabelText.Size = new System.Drawing.Size(81, 13);
            this.handleLabelText.TabIndex = 1;
            this.handleLabelText.Text = "Handle State";
            // 
            // handleUpLabel
            // 
            this.handleUpLabel.AutoSize = true;
            this.handleUpLabel.Location = new System.Drawing.Point(35, 34);
            this.handleUpLabel.Name = "handleUpLabel";
            this.handleUpLabel.Size = new System.Drawing.Size(21, 13);
            this.handleUpLabel.TabIndex = 2;
            this.handleUpLabel.Text = "Up";
            // 
            // handleDownLabel
            // 
            this.handleDownLabel.AutoSize = true;
            this.handleDownLabel.Location = new System.Drawing.Point(35, 71);
            this.handleDownLabel.Name = "handleDownLabel";
            this.handleDownLabel.Size = new System.Drawing.Size(35, 13);
            this.handleDownLabel.TabIndex = 3;
            this.handleDownLabel.Text = "Down";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.handleDownLabel);
            this.Controls.Add(this.handleUpLabel);
            this.Controls.Add(this.handleLabelText);
            this.Controls.Add(this.handleScrollBar);
            this.Name = "MainForm";
            this.Text = "Landing Gear System Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar handleScrollBar;
        private System.Windows.Forms.Label handleLabelText;
        private System.Windows.Forms.Label handleUpLabel;
        private System.Windows.Forms.Label handleDownLabel;
    }
}

