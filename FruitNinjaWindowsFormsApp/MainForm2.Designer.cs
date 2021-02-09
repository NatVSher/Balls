namespace FruitNinjaWindowsFormsApp
{
    partial class MainForm2
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
            this.caughtBallsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caughtBallsLabel
            // 
            this.caughtBallsLabel.AutoSize = true;
            this.caughtBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caughtBallsLabel.Location = new System.Drawing.Point(760, 9);
            this.caughtBallsLabel.Name = "caughtBallsLabel";
            this.caughtBallsLabel.Size = new System.Drawing.Size(19, 20);
            this.caughtBallsLabel.TabIndex = 0;
            this.caughtBallsLabel.Text = "0";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caughtBallsLabel);
            this.Name = "MainForm2";
            this.Text = "FruitNinja";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm2_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caughtBallsLabel;
    }
}

