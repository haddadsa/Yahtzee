namespace Program_1_Yahtzee
{
    partial class Form1
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
            this.aces = new System.Windows.Forms.CheckBox();
            this.aceval = new System.Windows.Forms.Label();
            this.dices = new System.Windows.Forms.Button();
            this.twos = new System.Windows.Forms.CheckBox();
            this.threes = new System.Windows.Forms.CheckBox();
            this.fours = new System.Windows.Forms.CheckBox();
            this.fives = new System.Windows.Forms.CheckBox();
            this.sixes = new System.Windows.Forms.CheckBox();
            this.dice2 = new System.Windows.Forms.CheckBox();
            this.dice3 = new System.Windows.Forms.CheckBox();
            this.dice4 = new System.Windows.Forms.CheckBox();
            this.dice5 = new System.Windows.Forms.CheckBox();
            this.dice6 = new System.Windows.Forms.CheckBox();
            this.dice1 = new System.Windows.Forms.CheckBox();
            this.threeval = new System.Windows.Forms.Label();
            this.fourval = new System.Windows.Forms.Label();
            this.fiveval = new System.Windows.Forms.Label();
            this.sixval = new System.Windows.Forms.Label();
            this.dice1val = new System.Windows.Forms.Label();
            this.dice2val = new System.Windows.Forms.Label();
            this.dice3val = new System.Windows.Forms.Label();
            this.dice4val = new System.Windows.Forms.Label();
            this.dice6val = new System.Windows.Forms.Label();
            this.dice5val = new System.Windows.Forms.Label();
            this.twoval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aces
            // 
            this.aces.AutoSize = true;
            this.aces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aces.Location = new System.Drawing.Point(10, 18);
            this.aces.Name = "aces";
            this.aces.Size = new System.Drawing.Size(72, 28);
            this.aces.TabIndex = 0;
            this.aces.Text = "Aces";
            this.aces.UseVisualStyleBackColor = true;
            this.aces.CheckedChanged += new System.EventHandler(this.aces_CheckedChanged);
            // 
            // aceval
            // 
            this.aceval.AutoSize = true;
            this.aceval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceval.Location = new System.Drawing.Point(120, 16);
            this.aceval.Name = "aceval";
            this.aceval.Size = new System.Drawing.Size(0, 24);
            this.aceval.TabIndex = 1;
            // 
            // dices
            // 
            this.dices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dices.Location = new System.Drawing.Point(12, 472);
            this.dices.Name = "dices";
            this.dices.Size = new System.Drawing.Size(87, 46);
            this.dices.TabIndex = 2;
            this.dices.Text = "Dice ";
            this.dices.UseVisualStyleBackColor = false;
            this.dices.Click += new System.EventHandler(this.button1_Click);
            // 
            // twos
            // 
            this.twos.AutoSize = true;
            this.twos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twos.Location = new System.Drawing.Point(10, 66);
            this.twos.Name = "twos";
            this.twos.Size = new System.Drawing.Size(75, 28);
            this.twos.TabIndex = 3;
            this.twos.Text = "Twos";
            this.twos.UseVisualStyleBackColor = true;
            this.twos.CheckedChanged += new System.EventHandler(this.twos_CheckedChanged);
            // 
            // threes
            // 
            this.threes.AutoSize = true;
            this.threes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threes.Location = new System.Drawing.Point(10, 118);
            this.threes.Name = "threes";
            this.threes.Size = new System.Drawing.Size(89, 28);
            this.threes.TabIndex = 4;
            this.threes.Text = "Threes";
            this.threes.UseVisualStyleBackColor = true;
            this.threes.CheckedChanged += new System.EventHandler(this.threes_CheckedChanged);
            // 
            // fours
            // 
            this.fours.AutoSize = true;
            this.fours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fours.Location = new System.Drawing.Point(10, 174);
            this.fours.Name = "fours";
            this.fours.Size = new System.Drawing.Size(78, 28);
            this.fours.TabIndex = 5;
            this.fours.Text = "Fours";
            this.fours.UseVisualStyleBackColor = true;
            this.fours.CheckedChanged += new System.EventHandler(this.fours_CheckedChanged);
            // 
            // fives
            // 
            this.fives.AutoSize = true;
            this.fives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fives.Location = new System.Drawing.Point(10, 223);
            this.fives.Name = "fives";
            this.fives.Size = new System.Drawing.Size(74, 28);
            this.fives.TabIndex = 6;
            this.fives.Text = "Fives";
            this.fives.UseVisualStyleBackColor = true;
            this.fives.CheckedChanged += new System.EventHandler(this.fives_CheckedChanged);
            // 
            // sixes
            // 
            this.sixes.AutoSize = true;
            this.sixes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixes.Location = new System.Drawing.Point(10, 276);
            this.sixes.Name = "sixes";
            this.sixes.Size = new System.Drawing.Size(75, 28);
            this.sixes.TabIndex = 7;
            this.sixes.Text = "Sixes";
            this.sixes.UseVisualStyleBackColor = true;
            this.sixes.CheckedChanged += new System.EventHandler(this.sixes_CheckedChanged);
            // 
            // dice2
            // 
            this.dice2.AutoSize = true;
            this.dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2.Location = new System.Drawing.Point(222, 417);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(82, 28);
            this.dice2.TabIndex = 9;
            this.dice2.Text = "Dice 2";
            this.dice2.UseVisualStyleBackColor = true;
            this.dice2.CheckedChanged += new System.EventHandler(this.dice2_CheckedChanged);
            // 
            // dice3
            // 
            this.dice3.AutoSize = true;
            this.dice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice3.Location = new System.Drawing.Point(314, 417);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(77, 28);
            this.dice3.TabIndex = 10;
            this.dice3.Text = "Dice3";
            this.dice3.UseVisualStyleBackColor = true;
            this.dice3.CheckedChanged += new System.EventHandler(this.dice3_CheckedChanged);
            // 
            // dice4
            // 
            this.dice4.AutoSize = true;
            this.dice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice4.Location = new System.Drawing.Point(134, 547);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(82, 28);
            this.dice4.TabIndex = 11;
            this.dice4.Text = "Dice 4";
            this.dice4.UseVisualStyleBackColor = true;
            this.dice4.CheckedChanged += new System.EventHandler(this.dice4_CheckedChanged);
            // 
            // dice5
            // 
            this.dice5.AutoSize = true;
            this.dice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice5.Location = new System.Drawing.Point(222, 547);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(82, 28);
            this.dice5.TabIndex = 12;
            this.dice5.Text = "Dice 5";
            this.dice5.UseVisualStyleBackColor = true;
            this.dice5.CheckedChanged += new System.EventHandler(this.dice5_CheckedChanged);
            // 
            // dice6
            // 
            this.dice6.AutoSize = true;
            this.dice6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice6.Location = new System.Drawing.Point(314, 547);
            this.dice6.Name = "dice6";
            this.dice6.Size = new System.Drawing.Size(82, 28);
            this.dice6.TabIndex = 13;
            this.dice6.Text = "Dice 6";
            this.dice6.UseVisualStyleBackColor = true;
            this.dice6.CheckedChanged += new System.EventHandler(this.dice6_CheckedChanged);
            // 
            // dice1
            // 
            this.dice1.AutoSize = true;
            this.dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1.Location = new System.Drawing.Point(134, 417);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(82, 28);
            this.dice1.TabIndex = 14;
            this.dice1.Text = "Dice 1";
            this.dice1.UseVisualStyleBackColor = true;
            this.dice1.CheckedChanged += new System.EventHandler(this.dice1_CheckedChanged);
            // 
            // threeval
            // 
            this.threeval.AutoSize = true;
            this.threeval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeval.Location = new System.Drawing.Point(120, 122);
            this.threeval.Name = "threeval";
            this.threeval.Size = new System.Drawing.Size(0, 24);
            this.threeval.TabIndex = 16;
            // 
            // fourval
            // 
            this.fourval.AutoSize = true;
            this.fourval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourval.Location = new System.Drawing.Point(120, 174);
            this.fourval.Name = "fourval";
            this.fourval.Size = new System.Drawing.Size(0, 24);
            this.fourval.TabIndex = 17;
            // 
            // fiveval
            // 
            this.fiveval.AutoSize = true;
            this.fiveval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveval.Location = new System.Drawing.Point(120, 224);
            this.fiveval.Name = "fiveval";
            this.fiveval.Size = new System.Drawing.Size(0, 24);
            this.fiveval.TabIndex = 18;
            // 
            // sixval
            // 
            this.sixval.AutoSize = true;
            this.sixval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixval.Location = new System.Drawing.Point(120, 280);
            this.sixval.Name = "sixval";
            this.sixval.Size = new System.Drawing.Size(0, 24);
            this.sixval.TabIndex = 19;
            // 
            // dice1val
            // 
            this.dice1val.AutoSize = true;
            this.dice1val.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1val.Location = new System.Drawing.Point(130, 370);
            this.dice1val.Name = "dice1val";
            this.dice1val.Size = new System.Drawing.Size(0, 24);
            this.dice1val.TabIndex = 20;
            // 
            // dice2val
            // 
            this.dice2val.AutoSize = true;
            this.dice2val.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2val.Location = new System.Drawing.Point(218, 370);
            this.dice2val.Name = "dice2val";
            this.dice2val.Size = new System.Drawing.Size(0, 24);
            this.dice2val.TabIndex = 21;
            // 
            // dice3val
            // 
            this.dice3val.AutoSize = true;
            this.dice3val.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice3val.Location = new System.Drawing.Point(310, 370);
            this.dice3val.Name = "dice3val";
            this.dice3val.Size = new System.Drawing.Size(0, 24);
            this.dice3val.TabIndex = 22;
            // 
            // dice4val
            // 
            this.dice4val.AutoSize = true;
            this.dice4val.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice4val.Location = new System.Drawing.Point(130, 494);
            this.dice4val.Name = "dice4val";
            this.dice4val.Size = new System.Drawing.Size(0, 24);
            this.dice4val.TabIndex = 23;
            // 
            // dice6val
            // 
            this.dice6val.AutoSize = true;
            this.dice6val.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice6val.Location = new System.Drawing.Point(326, 494);
            this.dice6val.Name = "dice6val";
            this.dice6val.Size = new System.Drawing.Size(0, 24);
            this.dice6val.TabIndex = 25;
            // 
            // dice5val
            // 
            this.dice5val.AutoSize = true;
            this.dice5val.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice5val.Location = new System.Drawing.Point(218, 494);
            this.dice5val.Name = "dice5val";
            this.dice5val.Size = new System.Drawing.Size(0, 24);
            this.dice5val.TabIndex = 26;
            // 
            // twoval
            // 
            this.twoval.AutoSize = true;
            this.twoval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoval.Location = new System.Drawing.Point(121, 66);
            this.twoval.Name = "twoval";
            this.twoval.Size = new System.Drawing.Size(0, 24);
            this.twoval.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 638);
            this.Controls.Add(this.twoval);
            this.Controls.Add(this.dice5val);
            this.Controls.Add(this.dice6val);
            this.Controls.Add(this.dice4val);
            this.Controls.Add(this.dice3val);
            this.Controls.Add(this.dice2val);
            this.Controls.Add(this.dice1val);
            this.Controls.Add(this.sixval);
            this.Controls.Add(this.fiveval);
            this.Controls.Add(this.fourval);
            this.Controls.Add(this.threeval);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.dice6);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.sixes);
            this.Controls.Add(this.fives);
            this.Controls.Add(this.fours);
            this.Controls.Add(this.threes);
            this.Controls.Add(this.twos);
            this.Controls.Add(this.dices);
            this.Controls.Add(this.aceval);
            this.Controls.Add(this.aces);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox aces;
        private System.Windows.Forms.Label aceval;
        private System.Windows.Forms.Button dices;
        private System.Windows.Forms.CheckBox twos;
        private System.Windows.Forms.CheckBox threes;
        private System.Windows.Forms.CheckBox fours;
        private System.Windows.Forms.CheckBox fives;
        private System.Windows.Forms.CheckBox sixes;
        private System.Windows.Forms.CheckBox dice2;
        private System.Windows.Forms.CheckBox dice3;
        private System.Windows.Forms.CheckBox dice4;
        private System.Windows.Forms.CheckBox dice5;
        private System.Windows.Forms.CheckBox dice6;
        private System.Windows.Forms.CheckBox dice1;
        private System.Windows.Forms.Label threeval;
        private System.Windows.Forms.Label fourval;
        private System.Windows.Forms.Label fiveval;
        private System.Windows.Forms.Label sixval;
        private System.Windows.Forms.Label dice1val;
        private System.Windows.Forms.Label dice2val;
        private System.Windows.Forms.Label dice3val;
        private System.Windows.Forms.Label dice4val;
        private System.Windows.Forms.Label dice6val;
        private System.Windows.Forms.Label dice5val;
        private System.Windows.Forms.Label twoval;
    }
}

