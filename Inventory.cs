using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Media;
using System.Windows.Forms;
using System.Drawing;

namespace EverydayTasks
{
    class Inventory : Panel
    {
        public Inventory() : base()
        {
            this.Location = new Point(300, 0);

            PictureBox banana = new PictureBox();
            banana.ImageLocation = "https://images-na.ssl-images-amazon.com/images/I/71gI-IUNUkL._SY355_.jpg";
            banana.Size = new Size(200, 100);
            banana.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(banana);
        }
    }
}
