namespace ImageCompare
{
    partial class ImageItem
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageItem));
            pictureBox = new PictureBox();
            labelIndex = new Label();
            labelPath = new Label();
            labelSize = new Label();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(144, 144);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.BackColor = Color.FromArgb(224, 224, 224);
            labelIndex.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelIndex.ForeColor = SystemColors.ControlDarkDark;
            labelIndex.Location = new Point(5, 5);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(21, 24);
            labelIndex.TabIndex = 1;
            labelIndex.Text = "0";
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.BackColor = Color.Transparent;
            labelPath.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPath.Location = new Point(153, 129);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(73, 18);
            labelPath.TabIndex = 2;
            labelPath.Text = "Image Path";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.BackColor = Color.Transparent;
            labelSize.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSize.Location = new Point(153, 29);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(75, 22);
            labelSize.TabIndex = 3;
            labelSize.Text = "Size: 0x0";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(153, 7);
            labelName.Name = "labelName";
            labelName.Size = new Size(103, 22);
            labelName.TabIndex = 4;
            labelName.Text = "Image Name";
            // 
            // ImageItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(labelName);
            Controls.Add(labelSize);
            Controls.Add(labelPath);
            Controls.Add(labelIndex);
            Controls.Add(pictureBox);
            Name = "ImageItem";
            Padding = new Padding(2);
            Size = new Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label labelIndex;
        private Label labelPath;
        private Label labelSize;
        private Label labelName;
    }
}
