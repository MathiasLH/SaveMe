namespace GUItest
{
    partial class mainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu1_button = new System.Windows.Forms.Button();
            this.menu2_button = new System.Windows.Forms.Button();
            this.menu3_button = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu1_button
            // 
            this.menu1_button.Location = new System.Drawing.Point(3, 3);
            this.menu1_button.Name = "menu1_button";
            this.menu1_button.Size = new System.Drawing.Size(150, 50);
            this.menu1_button.TabIndex = 0;
            this.menu1_button.Text = "Play game!";
            this.menu1_button.UseVisualStyleBackColor = true;
            this.menu1_button.Click += new System.EventHandler(this.menu1_button_Click);
            // 
            // menu2_button
            // 
            this.menu2_button.Location = new System.Drawing.Point(3, 59);
            this.menu2_button.Name = "menu2_button";
            this.menu2_button.Size = new System.Drawing.Size(150, 50);
            this.menu2_button.TabIndex = 1;
            this.menu2_button.Text = "Choose a dude";
            this.menu2_button.UseVisualStyleBackColor = true;
            this.menu2_button.Click += new System.EventHandler(this.menu2_button_Click);
            // 
            // menu3_button
            // 
            this.menu3_button.Location = new System.Drawing.Point(3, 115);
            this.menu3_button.Name = "menu3_button";
            this.menu3_button.Size = new System.Drawing.Size(150, 50);
            this.menu3_button.TabIndex = 2;
            this.menu3_button.Text = "Settings";
            this.menu3_button.UseVisualStyleBackColor = true;
            this.menu3_button.Click += new System.EventHandler(this.menu3_button_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(3, 171);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(150, 50);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUItest.Properties.Resources.stickman;
            this.pictureBox1.Location = new System.Drawing.Point(415, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 138);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu3_button);
            this.Controls.Add(this.menu2_button);
            this.Controls.Add(this.menu1_button);
            this.Name = "mainMenu";
            this.Size = new System.Drawing.Size(775, 425);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu1_button;
        private System.Windows.Forms.Button menu2_button;
        private System.Windows.Forms.Button menu3_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quitButton;
    }
}
