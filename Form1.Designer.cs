namespace ImageCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            imageItem1 = new ImageItem();
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Controls.Add(imageItem1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(284, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(504, 461);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // imageItem1
            // 
            imageItem1.BackColor = Color.FromArgb(224, 224, 224);
            imageItem1.Image = (Image)resources.GetObject("imageItem1.Image");
            imageItem1.ImageIndex = 0;
            imageItem1.ImagePath = "tak";
            imageItem1.Location = new Point(2, 2);
            imageItem1.Margin = new Padding(2);
            imageItem1.Name = "imageItem1";
            imageItem1.Padding = new Padding(2);
            imageItem1.Size = new Size(500, 150);
            imageItem1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Image count: 0";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(6, 75);
            button1.Name = "button1";
            button1.Size = new Size(272, 57);
            button1.TabIndex = 0;
            button1.Text = "Add Images";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 461);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            MinimumSize = new Size(804, 500);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button button1;
        private ImageItem imageItem1;
    }
}