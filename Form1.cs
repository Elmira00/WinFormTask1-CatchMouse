using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
            this.Cursor = CreateCursor(Properties.Resources._97538a647f5cf3b58c988d9f58d4c442);
           
        }

        private Cursor CreateCursor(Bitmap bm)
        {
            bm.MakeTransparent();
            return new Cursor(bm.GetHicon());
        }

    

        private void label1_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label lb)
            {
                lb.Dispose();
                Label label = new Label();
                Random random = new Random();
                int x = random.Next(0, 1000);
                int y = random.Next(0, 500);
                label.Location = new Point(x, y);
                label.Size = new Size(800, 450);
                label.Image = Properties.Resources._1674316098_grizly_club_p_klipart_mishka_34;
                label.BackColor = Color.Transparent;
                label.MouseHover += label1_MouseHover;
                this.Controls.Add(label);

            }
        }

    }
}
