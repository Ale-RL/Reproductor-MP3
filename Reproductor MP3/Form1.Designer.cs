namespace Reproductor_MP3
{
    partial class Programa
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            btnStop = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lbArchivo = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnAbrir = new Button();
            btnPlayPause = new Button();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.White;
            btnStop.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.ForeColor = SystemColors.ButtonHighlight;
            btnStop.ImageKey = "IconRebobinar.png";
            btnStop.ImageList = imageList1;
            btnStop.Location = new Point(600, 425);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.RightToLeft = RightToLeft.No;
            btnStop.Size = new Size(80, 80);
            btnStop.TabIndex = 1;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 69);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 2;
            label1.Text = "Archivo seleccionado:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbArchivo);
            panel1.Location = new Point(51, 107);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 61);
            panel1.TabIndex = 3;
            // 
            // lbArchivo
            // 
            lbArchivo.AutoSize = true;
            lbArchivo.Location = new Point(16, 19);
            lbArchivo.Name = "lbArchivo";
            lbArchivo.Size = new Size(248, 20);
            lbArchivo.TabIndex = 0;
            lbArchivo.Text = "No hay ningun archivo seleccionado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(353, 217);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = SystemColors.ControlLight;
            btnAbrir.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(743, 188);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(98, 31);
            btnAbrir.TabIndex = 5;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnPlayPause
            // 
            btnPlayPause.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPlayPause.Location = new Point(215, 425);
            btnPlayPause.MaximumSize = new Size(80, 80);
            btnPlayPause.Name = "btnPlayPause";
            btnPlayPause.Size = new Size(80, 80);
            btnPlayPause.TabIndex = 6;
            btnPlayPause.UseMnemonic = false;
            btnPlayPause.UseVisualStyleBackColor = true;
            btnPlayPause.Click += btnPlayPause_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "IconRebobinar.png");
            // 
            // Programa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnPlayPause);
            Controls.Add(btnAbrir);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Programa";
            Text = "Reproductor MP3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStop;
        private Label label1;
        private Panel panel1;
        private Label lbArchivo;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnAbrir;
        private Button btnPlayPause;
        private ImageList imageList1;
    }
}
