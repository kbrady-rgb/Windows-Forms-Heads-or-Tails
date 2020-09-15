using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Heads or Tails
* Author      : Kabrina Brady
* Created     : 8/30/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : When the user clicks "Show Heads", the heads side of a quarter appears. When "Show Tails" is
* clicked, the tails side of a quarter appears. When one appears, the other disappears.
*               Input:  The input is when the user clicks on a button or uses an access key
*               Output: The output is when the computer displays either the heads or tails side of the coin
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace HeadsOrTails
{
    public partial class headsOrTailsForm : Form
    {
        public headsOrTailsForm()
        {
            InitializeComponent();
        }

        //The form
        private void HeadsOrTailsForm_Load(object sender, EventArgs e)
        {
            imgHeads.Visible = false;
            imgTails.Visible = false;
        }

        //btnHeads - on click, shows heads side
        private void Button1_Click(object sender, EventArgs e)
        {
            imgHeads.Visible = true;
            imgTails.Visible = false;
        }

        //btnExit - on click, exits
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //imgTails
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        //imgHeads
        private void ImgHeads_Click(object sender, EventArgs e)
        {
            
        }

        //btnTails - on click, shows tails side
        private void BtnTails_Click(object sender, EventArgs e)
        {
            imgTails.Visible = true;
            imgHeads.Visible = false;
        }
    }
}
