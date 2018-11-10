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
        //private Inventory inventory;

        // holds the PictureBox that is currently being moved by MoveMe
        private PictureBox beingMoved;

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
            // allows for ChangeFrame to be subscribed to in Drawer
            this.drawer = drawer;
            this.Size = new Size(300, 500);

            // make the first panel and it is initially visible
            myPanel = new Panel();
            myPanel.Size = new Size(300, 300);

            // add a picture of an alarm clock to myPanel
            PictureBox picture = new PictureBox();
            picture.ImageLocation = "https://www.dollargeneral.com/media/catalog/product/cache/image/700x700/e9c3970ab036de70892d86c6d221abfe/1/2/12174001_1.jpg";
            picture.Size = new Size(100, 100);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            /// when picture is clicked on, it adds a toilet to myPanel and allows itself to be moved
            picture.Click += AddToilet;
            picture.Click += MoveMe;

            // put the picture in the panel and add the panel to the form
            myPanel.Controls.Add(picture);
            Controls.Add(myPanel);


            // make a second panel and make it initially invisible
            myPanel2 = new Panel();
            myPanel2.Size = new Size(300, 300);
            myPanel2.Visible = false;

            // add a picture of E ve
            PictureBox eve = new PictureBox();
            eve.ImageLocation = "https://yt3.ggpht.com/a-/AN66SAymX_IIGS8yBflI2OLLYk8rxR5elQf2JfeW-w=s900-mo-c-c0xffffffff-rj-k-no";
            eve.Size = new Size(100, 100);
            eve.SizeMode = PictureBoxSizeMode.StretchImage;

            /// when picture is clicked on, it adds a picture of yorushika to myPanel
            eve.Click += AddYorushika;

            // put the picture in the panel and add the panel to the form
            myPanel2.Controls.Add(eve);
            Controls.Add(myPanel2);

            /*
            // add inventory (doesn't work)
            inventory = new Inventory();
            inventory.Location = new Point(300, 100);
            Controls.Add(inventory);
            */

            // makes myPanel be able to call MoveMe when it is clicked on so that the moving of pictures works
            myPanel.Click += MoveMe;

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

        // test: puts in a picture of yorushika
        private void AddYorushika(object sender, EventArgs e)
        {
            PictureBox yorushika = new PictureBox();
            yorushika.ImageLocation = "https://i.ytimg.com/vi/LAVhnH0zR4Y/maxresdefault.jpg";
            yorushika.Size = new Size(200, 200);
            yorushika.SizeMode = PictureBoxSizeMode.StretchImage;
            myPanel2.Controls.Add(yorushika);

            yorushika.Click += drawer.ChangeFrame;
        }

        // moves the image
        // first click on an image saving it in beingMoved
        // second click moves the image that is saved to the current mouse position
        private void MoveMe(object sender, EventArgs e)
        {
            if (beingMoved != null)
            {
                beingMoved.Location = this.PointToClient(Cursor.Position);
                beingMoved = null;
            }
            else
            {
                if(sender is PictureBox)
                {

                    beingMoved = ((PictureBox)sender);
                }
            }
        }

        // changes the visiblilty on myPanel and myPanel 2 to be opposite
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
