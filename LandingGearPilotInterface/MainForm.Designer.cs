namespace LandingGearPilotInterface
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.handleScrollBar = new global::System.Windows.Forms.VScrollBar();
            this.handleLabelText = new global::System.Windows.Forms.Label();
            this.handleUpLabel = new global::System.Windows.Forms.Label();
            this.handleDownLabel = new global::System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // handleScrollBar
            // 
            this.handleScrollBar.LargeChange = 1;
            this.handleScrollBar.Location = new global::System.Drawing.Point((System.Int32)15, (System.Int32)22);
            this.handleScrollBar.Maximum = 1;
            this.handleScrollBar.Name = "handleScrollBar";
            this.handleScrollBar.Size = new global::System.Drawing.Size((System.Int32)17, (System.Int32)80);
            this.handleScrollBar.TabIndex = 0;
            this.handleScrollBar.Value = 1;
            // 
            // handleLabelText
            // 
            this.handleLabelText.AutoSize = true;
            this.handleLabelText.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)8.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Bold, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.handleLabelText.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)9);
            this.handleLabelText.Name = "handleLabelText";
            this.handleLabelText.Size = new global::System.Drawing.Size((System.Int32)81, (System.Int32)13);
            this.handleLabelText.TabIndex = 1;
            this.handleLabelText.Text = "Handle State";
            // 
            // handleUpLabel
            // 
            this.handleUpLabel.AutoSize = true;
            this.handleUpLabel.Location = new global::System.Drawing.Point((System.Int32)35, (System.Int32)34);
            this.handleUpLabel.Name = "handleUpLabel";
            this.handleUpLabel.Size = new global::System.Drawing.Size((System.Int32)21, (System.Int32)13);
            this.handleUpLabel.TabIndex = 2;
            this.handleUpLabel.Text = "Up";
            // 
            // handleDownLabel
            // 
            this.handleDownLabel.AutoSize = true;
            this.handleDownLabel.Location = new global::System.Drawing.Point((System.Int32)35, (System.Int32)71);
            this.handleDownLabel.Name = "handleDownLabel";
            this.handleDownLabel.Size = new global::System.Drawing.Size((System.Int32)35, (System.Int32)13);
            this.handleDownLabel.TabIndex = 3;
            this.handleDownLabel.Text = "Down";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)6F, (System.Single)13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)284, (System.Int32)262);
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

        private global::System.Windows.Forms.VScrollBar handleScrollBar;
        private global::System.Windows.Forms.Label handleLabelText;
        private global::System.Windows.Forms.Label handleUpLabel;
        private global::System.Windows.Forms.Label handleDownLabel;
    }
}

