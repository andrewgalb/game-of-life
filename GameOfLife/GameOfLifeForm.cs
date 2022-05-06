using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class GameOfLifeForm : Form
    {
        public GameOfLifeForm()
        {
            InitializeComponent();
            gameTimer.Interval = 1000;
            gameTimer.Start();
        }

        //Time code here..what should happen every time interval?
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Don't forget to call Invalidate() to update the display - so GameOfLifeForm_Paint is called...
            Invalidate();
        }

        //Painting code here...
        private void GameOfLifeForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.Green);   
        }

    }
}
