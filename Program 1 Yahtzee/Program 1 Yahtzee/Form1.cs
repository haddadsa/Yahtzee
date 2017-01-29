using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1_Yahtzee
{
    public partial class Form1 : Form
     
    {
        private Label[] diceval = new Label[6];
        private CheckBox[] dice = new CheckBox[6];
        private Label[] value = new Label[6];
        private CheckBox[] scoretype = new CheckBox[6];

        public Form1()
        {
            InitializeComponent();
            diceval[0] = dice1val;
            diceval[1] = dice2val;
            diceval[2] = dice3val;
            diceval[3] = dice4val;
            diceval[4] = dice5val;
            diceval[5] = dice6val;
            dice[0] = dice1;
            dice[1] = dice2;
            dice[2] = dice3;
            dice[3] = dice4;
            dice[4] = dice5;
            dice[5] = dice6;
            value[0] = aceval;
            value[1] = twoval;
            value[2] = threeval;
            value[3] = fourval;
            value[4] = fiveval;
            value[5] = sixval;
            scoretype[0] = aces;
            scoretype[1] = twos;
            scoretype[2] = threes;
            scoretype[3] = fours;
            scoretype[4] = fives;
            scoretype[5] = sixes;
        }

    

        private void aces_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void twos_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void threes_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void fours_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void fives_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void sixes_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setdie();
            checkval();
        }

        public void setdie()
        {
            Random num = new Random();
            int die = num.Next(1, 7);
  
            for (int i = 0; i < 6; i++)
            {
                if (!dice[i].Checked)
                {
                    die = num.Next(1, 7);
                    diceval[i].Text = die.ToString();

                }

            }
            checkval();
        }
        public void reset()
        {
            for (int i = 0; i < 6; i++)
            {
                diceval[i].Text = " ";
                if (!scoretype[i].Checked) value[i].Text = " ";
                
            }
        }

        private void checkval()
        {
            int check;
            int[] nums = new int[] { 0,0,0,0,0,0};
       
            for (int i=0;i<6;i++)
            {
                check = Int32.Parse(diceval[i].Text);
        
                for(int j=0;j<6;j++)
                {
                    if (check==j+1)
                    {
                        nums[j]++;
                    }
                }
             
            }
            for (int i = 0; i < 6; i++)
            {
                if (!scoretype[i].Checked)
                {
                    value[i].Text = " ";
                }
            }
                    for (int i=0; i<6;i++)
            {
                if(nums[i]>0 && !scoretype[i].Checked)
                {
                    value[i].Text = nums[i].ToString();
                }
            }

 


        }
        public void setscore1()
        {
       
        }


        private void dice1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dice2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dice3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dice4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dice5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dice6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
