using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompare
{
    public partial class ImageItem : UserControl
    {
        public ImageItem()
        {
            InitializeComponent();
        }
        private string _imagePath;
        private string _imageName;
        private int _imageIndex;
        private Image _image;
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = textBoxPath.Text = value; }
        }
        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = labelName.Text = value; }
        }
        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; labelIndex.Text = value.ToString(); }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox.Image = new Bitmap(value, new Size(144, 144)); labelSize.Text = value.Size.Width + " x " + value.Size.Height; }
        }
    }
}
