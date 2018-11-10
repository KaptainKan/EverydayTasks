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
    class Drawer
    {

        public int currentFrame = 0;
        public MyForm myForm1;
        public MyForm2 myForm2;

        public Drawer()
        {
            // make it look new and run the form
            Application.EnableVisualStyles();
            myForm1 = new MyForm(this);
            myForm2 = new MyForm2(this);
            RunFirst();

            
        }


        public void RunFirst()
        {
            Application.Run(myForm1);
        }

        // changes the frame
        public void ChangeFrame(object sender, EventArgs e)
        {
            if (currentFrame == 0)
            {
                myForm1.ChangeVisibility();
                currentFrame = 1;
            }
            else if (currentFrame == 1)
            {

                myForm1.ChangeVisibility();

                currentFrame = 0;
            }
        }
    }
}
