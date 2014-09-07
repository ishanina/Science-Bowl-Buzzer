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
    public partial class Choose_Key : Form
    {
        public Choose_Key()
        {
            InitializeComponent();
        }

        public Keys Key_Choice;

        public Keys Key_Chosen
        {
            get
            {
                return Key_Choice;
            }
        }

        private void Choose_Key_KeyDown(object sender, KeyEventArgs e)
        {
            Key_Choice = e.KeyCode;
            this.Close();
        }
    }
}
