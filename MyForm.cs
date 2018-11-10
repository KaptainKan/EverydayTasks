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
    class MyForm : Form
    {
        // ----- Fields -----
        public PictureBox toilet;
        private Drawer drawer;
        private Panel myPanel;
        private Panel myPanel2;

        // ----- Properties -----

        public Panel MyPanel
        {
            get
            {
                return myPanel;
            }
            set
            {
                myPanel = value;
            }
        }
        
        // ----- Constructors -----
        public MyForm(Drawer drawer)
        {
            this.drawer = drawer;

            myPanel = new Panel();
            myPanel.Size = new Size(300, 300);

            PictureBox picture = new PictureBox();
            picture.ImageLocation = "https://www.dollargeneral.com/media/catalog/product/cache/image/700x700/e9c3970ab036de70892d86c6d221abfe/1/2/12174001_1.jpg";
            picture.Size = new Size(100, 100);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            picture.Click += AddToilet;

            myPanel.Controls.Add(picture);
            Controls.Add(myPanel);


            myPanel2 = new Panel();
            myPanel2.Size = new Size(300, 300);
            myPanel2.Visible = false;

            PictureBox eve = new PictureBox();
            eve.ImageLocation = "https://yt3.ggpht.com/a-/AN66SAymX_IIGS8yBflI2OLLYk8rxR5elQf2JfeW-w=s900-mo-c-c0xffffffff-rj-k-no";
            eve.Size = new Size(100, 100);
            eve.SizeMode = PictureBoxSizeMode.StretchImage;

            eve.Click += AddYorushika;


            myPanel2.Controls.Add(eve);
            Controls.Add(myPanel2);


        }

        // ----- Methods ----- 
        // test: puts in a toilet
        private void AddToilet(object sender, EventArgs e)
        {
            toilet = new PictureBox();
            toilet.ImageLocation = "https://mobileimages.lowes.com/product/converted/033056/033056831168.jpg";
            toilet.Size = new Size(100, 100);
            toilet.Location = new Point(150, 150);
            toilet.SizeMode = PictureBoxSizeMode.StretchImage;
            myPanel.Controls.Add(toilet);

            toilet.Click += drawer.ChangeFrame;

        }

        // test: puts in a toilet
        private void AddYorushika(object sender, EventArgs e)
        {
            PictureBox yorushika = new PictureBox();
            yorushika.ImageLocation = "https://i.ytimg.com/vi/LAVhnH0zR4Y/maxresdefault.jpg";
            yorushika.Size = new Size(200, 200);
            yorushika.SizeMode = PictureBoxSizeMode.StretchImage;
            myPanel2.Controls.Add(yorushika);

            yorushika.Click += drawer.ChangeFrame;
        }

        // changes the visiblilty on myPanel
        public void ChangeVisibility()
        {
            if (myPanel.Visible == true)
            {
                myPanel.Visible = false;
                myPanel2.Visible = true;
            }
            else
            {
                myPanel.Visible = true;
                myPanel2.Visible = false;
            }
        }
        
    }
}
