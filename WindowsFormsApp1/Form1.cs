using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.NewFolder1;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Agent Enter_Agent;
        private void button1_Click(object sender, EventArgs e)
        {
            Enter_Agent = null;
            Model1 model1 = new Model1();
            Enter_Agent = model1.Agent.FirstOrDefault(x => x.Phone == textBox1.Text && x.Title == textBox2.Text);
            if (Enter_Agent != null) 
            { 
             switch (Enter_Agent.ID) 
                {
                    case 1: 
                        {
                            Form2 form2 = new Form2();
                            form2.ShowDialog();
                            break;
                        }
                    
                }
            }

        }
    }
}
