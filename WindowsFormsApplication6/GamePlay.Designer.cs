namespace WindowsFormsApplication6
{
    partial class GamePlay
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
        //add name of friends name,add button name, added pictures of dog to recognise individual.
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.RaceGroundPBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ThirdText = new System.Windows.Forms.TextBox();
            this.SecondText = new System.Windows.Forms.TextBox();
            this.FirstText = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.GetSetButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxBetAmtLabel = new System.Windows.Forms.Label();
            this.MaxBetLabel = new System.Windows.Forms.Label();
            this.AlRadio = new System.Windows.Forms.RadioButton();
            this.BobRadio = new System.Windows.Forms.RadioButton();
            this.JoeRadio1 = new System.Windows.Forms.RadioButton();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.FirstPBox = new System.Windows.Forms.PictureBox();
            this.SecondPBox = new System.Windows.Forms.PictureBox();
            this.ThirdPBox = new System.Windows.Forms.PictureBox();
            this.FourthPBox = new System.Windows.Forms.PictureBox();
            this.IL1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RaceGroundPBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceGroundPBox
            // 
            this.RaceGroundPBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RaceGroundPBox.BackgroundImage")));
            this.RaceGroundPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RaceGroundPBox.ErrorImage = null;
            this.RaceGroundPBox.ImageLocation = "";
            this.RaceGroundPBox.Location = new System.Drawing.Point(13, 14);
            this.RaceGroundPBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RaceGroundPBox.Name = "RaceGroundPBox";
            this.RaceGroundPBox.Size = new System.Drawing.Size(1015, 373);
            this.RaceGroundPBox.TabIndex = 0;
            this.RaceGroundPBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.ThirdText);
            this.panel1.Controls.Add(this.SecondText);
            this.panel1.Controls.Add(this.FirstText);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.GetSetButton);
            this.panel1.Controls.Add(this.RestartButton);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BetButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MaxBetAmtLabel);
            this.panel1.Controls.Add(this.MaxBetLabel);
            this.panel1.Controls.Add(this.AlRadio);
            this.panel1.Controls.Add(this.BobRadio);
            this.panel1.Controls.Add(this.JoeRadio1);
            this.panel1.Location = new System.Drawing.Point(13, 391);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 198);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "$";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(901, 137);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 48);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ThirdText
            // 
            this.ThirdText.Enabled = false;
            this.ThirdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThirdText.Location = new System.Drawing.Point(483, 90);
            this.ThirdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThirdText.Name = "ThirdText";
            this.ThirdText.Size = new System.Drawing.Size(337, 30);
            this.ThirdText.TabIndex = 11;
            // 
            // SecondText
            // 
            this.SecondText.Enabled = false;
            this.SecondText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SecondText.Location = new System.Drawing.Point(483, 46);
            this.SecondText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondText.Name = "SecondText";
            this.SecondText.Size = new System.Drawing.Size(337, 30);
            this.SecondText.TabIndex = 10;
            // 
            // FirstText
            // 
            this.FirstText.Enabled = false;
            this.FirstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstText.Location = new System.Drawing.Point(483, 10);
            this.FirstText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(337, 30);
            this.FirstText.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown2.Location = new System.Drawing.Point(332, 48);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GetSetButton
            // 
            this.GetSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GetSetButton.Location = new System.Drawing.Point(576, 137);
            this.GetSetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetSetButton.Name = "GetSetButton";
            this.GetSetButton.Size = new System.Drawing.Size(140, 48);
            this.GetSetButton.TabIndex = 3;
            this.GetSetButton.Text = "Get Set Go";
            this.GetSetButton.UseVisualStyleBackColor = true;
            this.GetSetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RestartButton.Location = new System.Drawing.Point(795, 137);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(99, 48);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(332, 11);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(167, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "on Dog No.   #";
            // 
            // BetButton
            // 
            this.BetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BetButton.Location = new System.Drawing.Point(252, 137);
            this.BetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(303, 48);
            this.BetButton.TabIndex = 2;
            this.BetButton.Text = "Put Bet on Dog";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(167, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bettor";
            // 
            // MaxBetAmtLabel
            // 
            this.MaxBetAmtLabel.AutoSize = true;
            this.MaxBetAmtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaxBetAmtLabel.Location = new System.Drawing.Point(16, 153);
            this.MaxBetAmtLabel.Name = "MaxBetAmtLabel";
            this.MaxBetAmtLabel.Size = new System.Drawing.Size(157, 25);
            this.MaxBetAmtLabel.TabIndex = 4;
            this.MaxBetAmtLabel.Text = "Max Bet Amount";
            // 
            // MaxBetLabel
            // 
            this.MaxBetLabel.AutoSize = true;
            this.MaxBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaxBetLabel.Location = new System.Drawing.Point(15, 113);
            this.MaxBetLabel.Name = "MaxBetLabel";
            this.MaxBetLabel.Size = new System.Drawing.Size(103, 25);
            this.MaxBetLabel.TabIndex = 3;
            this.MaxBetLabel.Text = "Max Bet is";
            // 
            // AlRadio
            // 
            this.AlRadio.AutoSize = true;
            this.AlRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AlRadio.Location = new System.Drawing.Point(20, 66);
            this.AlRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlRadio.Name = "AlRadio";
            this.AlRadio.Size = new System.Drawing.Size(51, 29);
            this.AlRadio.TabIndex = 2;
            this.AlRadio.TabStop = true;
            this.AlRadio.Text = "Al";
            this.AlRadio.UseVisualStyleBackColor = true;
            this.AlRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BobRadio
            // 
            this.BobRadio.AutoSize = true;
            this.BobRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BobRadio.Location = new System.Drawing.Point(20, 38);
            this.BobRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BobRadio.Name = "BobRadio";
            this.BobRadio.Size = new System.Drawing.Size(68, 29);
            this.BobRadio.TabIndex = 1;
            this.BobRadio.TabStop = true;
            this.BobRadio.Text = "Bob";
            this.BobRadio.UseVisualStyleBackColor = true;
            this.BobRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // JoeRadio1
            // 
            this.JoeRadio1.AutoSize = true;
            this.JoeRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.JoeRadio1.Location = new System.Drawing.Point(20, 10);
            this.JoeRadio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoeRadio1.Name = "JoeRadio1";
            this.JoeRadio1.Size = new System.Drawing.Size(66, 29);
            this.JoeRadio1.TabIndex = 0;
            this.JoeRadio1.TabStop = true;
            this.JoeRadio1.Text = "Joe";
            this.JoeRadio1.UseVisualStyleBackColor = true;
            this.JoeRadio1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // t1
            // 
            this.t1.Interval = 500;
            this.t1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t2
            // 
            this.t2.Interval = 1000;
            this.t2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FirstPBox
            // 
            this.FirstPBox.Image = ((System.Drawing.Image)(resources.GetObject("FirstPBox.Image")));
            this.FirstPBox.Location = new System.Drawing.Point(58, 41);
            this.FirstPBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstPBox.Name = "FirstPBox";
            this.FirstPBox.Size = new System.Drawing.Size(57, 33);
            this.FirstPBox.TabIndex = 9;
            this.FirstPBox.TabStop = false;
            // 
            // SecondPBox
            // 
            this.SecondPBox.Image = ((System.Drawing.Image)(resources.GetObject("SecondPBox.Image")));
            this.SecondPBox.Location = new System.Drawing.Point(58, 138);
            this.SecondPBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondPBox.Name = "SecondPBox";
            this.SecondPBox.Size = new System.Drawing.Size(57, 33);
            this.SecondPBox.TabIndex = 10;
            this.SecondPBox.TabStop = false;
            // 
            // ThirdPBox
            // 
            this.ThirdPBox.Image = ((System.Drawing.Image)(resources.GetObject("ThirdPBox.Image")));
            this.ThirdPBox.Location = new System.Drawing.Point(60, 243);
            this.ThirdPBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThirdPBox.Name = "ThirdPBox";
            this.ThirdPBox.Size = new System.Drawing.Size(55, 33);
            this.ThirdPBox.TabIndex = 11;
            this.ThirdPBox.TabStop = false;
            // 
            // FourthPBox
            // 
            this.FourthPBox.Image = ((System.Drawing.Image)(resources.GetObject("FourthPBox.Image")));
            this.FourthPBox.Location = new System.Drawing.Point(60, 323);
            this.FourthPBox.Margin = new System.Windows.Forms.Padding(4);
            this.FourthPBox.Name = "FourthPBox";
            this.FourthPBox.Size = new System.Drawing.Size(55, 32);
            this.FourthPBox.TabIndex = 12;
            this.FourthPBox.TabStop = false;
            // 
            // IL1
            // 
            this.IL1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IL1.ImageSize = new System.Drawing.Size(16, 16);
            this.IL1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 601);
            this.Controls.Add(this.FourthPBox);
            this.Controls.Add(this.ThirdPBox);
            this.Controls.Add(this.SecondPBox);
            this.Controls.Add(this.FirstPBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RaceGroundPBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GamePlay";
            this.Text = "Game Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaceGroundPBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RaceGroundPBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.Button GetSetButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MaxBetAmtLabel;
        private System.Windows.Forms.Label MaxBetLabel;
        private System.Windows.Forms.RadioButton AlRadio;
        private System.Windows.Forms.RadioButton BobRadio;
        private System.Windows.Forms.RadioButton JoeRadio1;
        private System.Windows.Forms.TextBox ThirdText;
        private System.Windows.Forms.TextBox SecondText;
        private System.Windows.Forms.TextBox FirstText;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.PictureBox FirstPBox;
        private System.Windows.Forms.PictureBox SecondPBox;
        private System.Windows.Forms.PictureBox ThirdPBox;
        private System.Windows.Forms.PictureBox FourthPBox;
        private System.Windows.Forms.ImageList IL1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}

