namespace ImageCompare
{
    public partial class Form1 : Form
    {
        ImageItem[] imageItems;
        int page = 1;
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
                int id = 0;
                imageItems = new ImageItem[openFileDialog.FileNames.Count()];
                progressBarLoadImages.Maximum = openFileDialog.FileNames.Count();
                progressBarLoadImages.Value = 0;
                progressBarLoadImages.Visible = true;
                foreach (string file in openFileDialog.FileNames)
                {
                    imageItems[id] = new ImageItem();
                    imageItems[id].ImageIndex = id + 1;
                    imageItems[id].ImageName = openFileDialog.SafeFileNames[id];
                    imageItems[id].ImagePath = file;
                    imageItems[id].Image = new Bitmap(file);
                    id++;
                    progressBarLoadImages.Value++;
                }
                label1.Text = "Image count: " + id;
                LoadImagesToPanel();
                panelPageOptions.Visible = true;
                progressBarLoadImages.Visible = false;
            }
        }

        private void pageOptionButton1_Click(object sender, EventArgs e)
        {
            if (!(page - 1 > 0)) return;
            page--;
            LoadImagesToPanel();
        }

        private void pageOptionButton2_Click(object sender, EventArgs e)
        {
            if (!(imageItems.Count() > page * 20)) return;
            page++;
            LoadImagesToPanel();
        }

        void LoadImagesToPanel()
        {
            pageOptionLabel.Text = "Page: " + page;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(imageItems[(page == 1 ? 0 : page * 20 - 20)..(page * 20 > imageItems.Count() ? imageItems.Count() : page * 20)]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Convert all images to bit
            // 2. Compare all images
            // 3. Select only ones that have >50% of similarity
            // 4. Show the simillar one
        }
    }
}