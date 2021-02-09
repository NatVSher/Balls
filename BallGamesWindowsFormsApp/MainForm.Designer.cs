namespace BallGamesWindowsFormsApp
{
    partial class MainForm
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
            this.catchBallButton = new System.Windows.Forms.Button();
            this.startBallButton = new System.Windows.Forms.Button();
            this.caughtBallsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // catchBallButton
            // 
            this.catchBallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catchBallButton.Location = new System.Drawing.Point(414, 12);
            this.catchBallButton.Name = "catchBallButton";
            this.catchBallButton.Size = new System.Drawing.Size(147, 37);
            this.catchBallButton.TabIndex = 0;
            this.catchBallButton.Text = "Поймать мячики";
            this.catchBallButton.UseVisualStyleBackColor = true;
            this.catchBallButton.Click += new System.EventHandler(this.catchBallButton_Click);
            // 
            // startBallButton
            // 
            this.startBallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBallButton.Location = new System.Drawing.Point(225, 12);
            this.startBallButton.Name = "startBallButton";
            this.startBallButton.Size = new System.Drawing.Size(161, 37);
            this.startBallButton.TabIndex = 1;
            this.startBallButton.Text = "Запустить мячики";
            this.startBallButton.UseVisualStyleBackColor = true;
            this.startBallButton.Click += new System.EventHandler(this.startBallButton_Click);
            // 
            // caughtBallsLabel
            // 
            this.caughtBallsLabel.AutoSize = true;
            this.caughtBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caughtBallsLabel.Location = new System.Drawing.Point(393, 53);
            this.caughtBallsLabel.Name = "caughtBallsLabel";
            this.caughtBallsLabel.Size = new System.Drawing.Size(18, 20);
            this.caughtBallsLabel.TabIndex = 2;
            this.caughtBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caughtBallsLabel);
            this.Controls.Add(this.startBallButton);
            this.Controls.Add(this.catchBallButton);
            this.Name = "MainForm";
            this.Text = "Поймай меня";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button catchBallButton;
        private System.Windows.Forms.Button startBallButton;
        private System.Windows.Forms.Label caughtBallsLabel;
    }
}

