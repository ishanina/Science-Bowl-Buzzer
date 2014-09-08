using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Science_Bowl_Buzzer_Windows
{
    public partial class Main : Form
    {
        public Keys[] People_Keys;
        

        public Main()
        {
            InitializeComponent();
            People_Keys = new Keys[13];
            for (int i = 0; i < 13; i++)
                People_Keys[i] = Keys.Escape;
        }

        private void Player_Key_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Console.WriteLine(button.Name.Substring(7, 2));
            try
            {
                Key_Change(Convert.ToInt32(button.Name.Substring(7, 2)));
            }
            catch (FormatException)
            {
                Key_Change(Convert.ToInt32(button.Name.Substring(7, 1)));
            }
        }

        private void Key_Change(int Person)
        {
            Choose_Key Get = new Choose_Key();
            Get.ShowDialog();
            People_Keys[Person] = Get.Key_Chosen;
            switch (Person)
            {
                case 1:
                    Player_1_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 2:
                    Player_2_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 3:
                    Player_3_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 4:
                    Player_4_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 5:
                    Player_5_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 6:
                    Player_6_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 7:
                    Player_7_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 8:
                    Player_8_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 9:
                    Player_9_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 10:
                    Player_10_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 11:
                    Player_11_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                case 12:
                    Player_12_Choose.Text = Convert.ToString(People_Keys[Person]);
                    break;
                default:
                    break;
            }
        }

        private void Reset_Buzzers_Click(object sender, EventArgs e)
        {
            Buzz_Person.Text = "";
            Buzz_Person.BackColor = Color.White;
        }

        private void Button_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "R" && e.Control)
                    Reset_Buzzers_Click(sender, e);
            else for (int i = 1; i < 13; i++)
            {
                if (e.KeyCode == People_Keys[i] && Buzz_Person.BackColor == Color.White)
                {
                    Buzz_Person.BackColor = Color.LightGreen;
                    Set_Buzzer(i);
                }
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "R")
                Reset_Buzzers_Click(sender, e);
        }

        async Task Set_Buzzer(int Person)
        {
            switch (Person)
            {
                case 1:
                    Buzz_Person.Text = Player_1_Name.Text;
                    break;
                case 2:
                    Buzz_Person.Text = Player_2_Name.Text;
                    break;
                case 3:
                    Buzz_Person.Text = Player_3_Name.Text;
                    break;
                case 4:
                    Buzz_Person.Text = Player_4_Name.Text;
                    break;
                case 5:
                    Buzz_Person.Text = Player_5_Name.Text;
                    break;
                case 6:
                    Buzz_Person.Text = Player_6_Name.Text;
                    break;
                case 7:
                    Buzz_Person.Text = Player_7_Name.Text;
                    break;
                case 8:
                    Buzz_Person.Text = Player_8_Name.Text;
                    break;
                case 9:
                    Buzz_Person.Text = Player_9_Name.Text;
                    break;
                case 10:
                    Buzz_Person.Text = Player_10_Name.Text;
                    break;
                case 11:
                    Buzz_Person.Text = Player_11_Name.Text;
                    break;
                case 12:
                    Buzz_Person.Text = Player_12_Name.Text;
                    break;
                default:
                    break;
            }
        }

        private void Team_1_Add_4_Click(object sender, EventArgs e)
        {
            try
            {
                Team_1_Score.Text = Convert.ToString(Convert.ToInt64(Team_1_Score.Text) + 4);
            }
            catch (Exception)
            { }
        }

        private void Team_1_Add_10_Click(object sender, EventArgs e)
        {
            try
            {
                Team_1_Score.Text = Convert.ToString(Convert.ToInt64(Team_1_Score.Text) + 10);
            }
            catch (Exception)
            { }
        }

        private void Team_2_Add_4_Click(object sender, EventArgs e)
        {
            try
            {
                Team_2_Score.Text = Convert.ToString(Convert.ToInt64(Team_2_Score.Text) + 4);
            }
            catch (Exception)
            { }
        }

        private void Team_2_Add_10_Click(object sender, EventArgs e)
        {
            try
            {
                Team_2_Score.Text = Convert.ToString(Convert.ToInt64(Team_2_Score.Text) + 10);
            }
            catch (Exception)
            { }
        }
    }
}
