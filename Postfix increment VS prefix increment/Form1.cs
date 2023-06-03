using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ref link:https://www.youtube.com/watch?v=YtAJuUV-U2Y&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=69


namespace Postfix_increment_VS_prefix_increment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int num = 9;
            this.Text = (++num).ToString(); // result 10
            //this.Text = (num++).ToString(); // reulst 9
        }
    }
}
