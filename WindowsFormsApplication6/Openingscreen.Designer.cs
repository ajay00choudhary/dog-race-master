﻿namespace WindowsFormsApplication6
{
    partial class Openingscreen
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
        //this is the main page and some main buttons on the front page to start the game.
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Openingscreen));
            this.OpenScreenPBox = new System.Windows.Forms.PictureBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.ThirdNameLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OpenScreenPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenScreenPBox
            // 
            this.OpenScreenPBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenScreenPBox.BackgroundImage")));
            this.OpenScreenPBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("OpenScreenPBox.InitialImage")));
            this.OpenScreenPBox.Location = new System.Drawing.Point(3, 0);
            this.OpenScreenPBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpenScreenPBox.Name = "OpenScreenPBox";
            this.OpenScreenPBox.Size = new System.Drawing.Size(1027, 457);
            this.OpenScreenPBox.TabIndex = 0;
            this.OpenScreenPBox.TabStop = false;
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(168, 476);
            this.text1.Margin = new System.Windows.Forms.Padding(4);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(219, 30);
            this.text1.TabIndex = 1;
            this.text1.Text = "Joe";
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(168, 516);
            this.text2.Margin = new System.Windows.Forms.Padding(4);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(219, 30);
            this.text2.TabIndex = 2;
            this.text2.Text = "Bob";
            // 
            // text3
            // 
            this.text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(168, 555);
            this.text3.Margin = new System.Windows.Forms.Padding(4);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(219, 30);
            this.text3.TabIndex = 3;
            this.text3.Text = "Al";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(9, 484);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNameLabel.Location = new System.Drawing.Point(9, 523);
            this.SecondNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(137, 25);
            this.SecondNameLabel.TabIndex = 5;
            this.SecondNameLabel.Text = "Second Name";
            // 
            // ThirdNameLabel
            // 
            this.ThirdNameLabel.AutoSize = true;
            this.ThirdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdNameLabel.Location = new System.Drawing.Point(9, 562);
            this.ThirdNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThirdNameLabel.Name = "ThirdNameLabel";
            this.ThirdNameLabel.Size = new System.Drawing.Size(114, 25);
            this.ThirdNameLabel.TabIndex = 6;
            this.ThirdNameLabel.Text = "Third Name";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(663, 471);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(213, 52);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(663, 530);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(213, 52);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Openingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 601);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ThirdNameLabel);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.OpenScreenPBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Openingscreen";
            this.Text = "Openingscreen";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenScreenPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OpenScreenPBox;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label ThirdNameLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
    }
}