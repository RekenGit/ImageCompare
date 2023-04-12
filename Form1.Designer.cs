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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            progressBarLoadImages = new ProgressBar();
            panelPageOptions = new Panel();
            pageOptionLabel = new Label();
            pageOptionButton2 = new Button();
            pageOptionButton1 = new Button();
            panelPageOptions.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(284, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(504, 461);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(6, 223);
            button2.Name = "button2";
            button2.Size = new Size(272, 38);
            button2.TabIndex = 0;
            button2.Text = "Find Differences";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Text = "Select Images";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // progressBarLoadImages
            // 
            progressBarLoadImages.Location = new Point(6, 118);
            progressBarLoadImages.Name = "progressBarLoadImages";
            progressBarLoadImages.Size = new Size(272, 14);
            progressBarLoadImages.TabIndex = 2;
            progressBarLoadImages.Visible = false;
            // 
            // panelPageOptions
            // 
            panelPageOptions.Controls.Add(pageOptionLabel);
            panelPageOptions.Controls.Add(pageOptionButton2);
            panelPageOptions.Controls.Add(pageOptionButton1);
            panelPageOptions.Dock = DockStyle.Bottom;
            panelPageOptions.Location = new Point(0, 361);
            panelPageOptions.Name = "panelPageOptions";
            panelPageOptions.Size = new Size(284, 100);
            panelPageOptions.TabIndex = 3;
            panelPageOptions.Visible = false;
            // 
            // pageOptionLabel
            // 
            pageOptionLabel.AutoSize = true;
            pageOptionLabel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pageOptionLabel.Location = new Point(94, 1);
            pageOptionLabel.Name = "pageOptionLabel";
            pageOptionLabel.Size = new Size(64, 24);
            pageOptionLabel.TabIndex = 4;
            pageOptionLabel.Text = "Page: ";
            // 
            // pageOptionButton2
            // 
            pageOptionButton2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            pageOptionButton2.Location = new Point(145, 35);
            pageOptionButton2.Name = "pageOptionButton2";
            pageOptionButton2.Size = new Size(124, 59);
            pageOptionButton2.TabIndex = 3;
            pageOptionButton2.Text = ">";
            pageOptionButton2.UseVisualStyleBackColor = true;
            pageOptionButton2.Click += pageOptionButton2_Click;
            // 
            // pageOptionButton1
            // 
            pageOptionButton1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            pageOptionButton1.Location = new Point(16, 35);
            pageOptionButton1.Name = "pageOptionButton1";
            pageOptionButton1.Size = new Size(124, 59);
            pageOptionButton1.TabIndex = 0;
            pageOptionButton1.Text = "<";
            pageOptionButton1.UseVisualStyleBackColor = true;
            pageOptionButton1.Click += pageOptionButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 461);
            Controls.Add(button2);
            Controls.Add(progressBarLoadImages);
            Controls.Add(panelPageOptions);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            MinimumSize = new Size(804, 500);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            panelPageOptions.ResumeLayout(false);
            panelPageOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button button1;
        private ProgressBar progressBarLoadImages;
        private Panel panelPageOptions;
        private Label pageOptionLabel;
        private Button pageOptionButton2;
        private Button pageOptionButton1;
        private Button button2;
    }
}