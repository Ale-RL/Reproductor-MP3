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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            btnPlay = new Button();
            btnStop = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lbArchivo = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Green;
            btnPlay.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = SystemColors.ButtonHighlight;
            btnPlay.Location = new Point(139, 331);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(120, 48);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(192, 0, 0);
            btnStop.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.ForeColor = SystemColors.ButtonHighlight;
            btnStop.Location = new Point(508, 331);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(120, 48);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 52);
            label1.Name = "label1";
            label1.Size = new Size(158, 19);
            label1.TabIndex = 2;
            label1.Text = "Archivo seleccionado:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbArchivo);
            panel1.Location = new Point(45, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 46);
            panel1.TabIndex = 3;
            // 
            // lbArchivo
            // 
            lbArchivo.AutoSize = true;
            lbArchivo.Location = new Point(14, 14);
            lbArchivo.Name = "lbArchivo";
            lbArchivo.Size = new Size(200, 15);
            lbArchivo.TabIndex = 0;
            lbArchivo.Text = "No hay ningun archivo seleccionado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Programa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Programa";
            Text = "Reproductor MP3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private Button btnStop;
        private Label label1;
        private Panel panel1;
        private Label lbArchivo;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}
