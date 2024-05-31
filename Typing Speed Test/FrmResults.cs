using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Speed_Test
{
    public partial class FrmResults : Form
    {
        public FrmResults(int words, int wl, int mistakes)
        {
            InitializeComponent();
            
            lblWPM.Text = words.ToString();
            lblMistakes.Text = mistakes.ToString();
            lblAcc.Text = (((double)mistakes / (double)wl) * 100.0).ToString();
            

        }

        
    }
}
