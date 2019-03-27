using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho.UserControls
{
    public partial class CustomButton : PictureBox
    {
        public CustomButton()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image hoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }
        public Image ImageHover
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }

        private void CustomButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = hoverImage;
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
