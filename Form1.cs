namespace ImageCompare
{
    public partial class Form1 : Form
    {
        ImageItem[] imageItems;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control appWindow = (Control)sender;
            double x = appWindow.Size.Width - 300;
            int size = Convert.ToInt32(Math.Round(x));
            flowLayoutPanel1.Size = new Size(size, appWindow.Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tiff;*.tif;*.jpe;*.jfif;*.bmp;*.dib;*.rle;*.gif;";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                flowLayoutPanel1.Controls.Clear();
                int id = 0;
                imageItems = new ImageItem[openFileDialog.FileNames.Count()];
                foreach (string file in openFileDialog.FileNames)
                {
                    imageItems[id] = new ImageItem();
                    imageItems[id].ImageIndex = id+1;
                    imageItems[id].ImageName = openFileDialog.SafeFileNames[id];
                    imageItems[id].ImagePath = file;
                    imageItems[id].Image = new Bitmap(file);
                    flowLayoutPanel1.Controls.Add(imageItems[id]);
                    id++;
                }
                label1.Text = "Image count: " + id;
            }
        }
    }
}