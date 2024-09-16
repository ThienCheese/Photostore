namespace Photostore
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            OpenBtt = new Button();
            PrevBtt = new Button();
            counter_rotate = new Button();
            clk_rotate = new Button();
            NextBtt = new Button();
            CloseBtt = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.PeachPuff;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 603);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1082, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.PeachPuff;
            flowLayoutPanel2.Controls.Add(OpenBtt);
            flowLayoutPanel2.Controls.Add(PrevBtt);
            flowLayoutPanel2.Controls.Add(counter_rotate);
            flowLayoutPanel2.Controls.Add(clk_rotate);
            flowLayoutPanel2.Controls.Add(NextBtt);
            flowLayoutPanel2.Controls.Add(CloseBtt);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1082, 37);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // OpenBtt
            // 
            OpenBtt.BackColor = Color.Salmon;
            OpenBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            OpenBtt.Location = new Point(3, 3);
            OpenBtt.Name = "OpenBtt";
            OpenBtt.Size = new Size(101, 33);
            OpenBtt.TabIndex = 0;
            OpenBtt.Text = "Open";
            OpenBtt.UseVisualStyleBackColor = false;
            OpenBtt.Click += OpenBtt_Click;
            // 
            // PrevBtt
            // 
            PrevBtt.BackColor = Color.Salmon;
            PrevBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            PrevBtt.Location = new Point(110, 3);
            PrevBtt.Name = "PrevBtt";
            PrevBtt.Size = new Size(108, 34);
            PrevBtt.TabIndex = 2;
            PrevBtt.Text = "Prev";
            PrevBtt.UseVisualStyleBackColor = false;
            PrevBtt.Click += PrevBtt_Click;
            // 
            // counter_rotate
            // 
            counter_rotate.BackColor = Color.Salmon;
            counter_rotate.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            counter_rotate.Location = new Point(224, 3);
            counter_rotate.Name = "counter_rotate";
            counter_rotate.Size = new Size(113, 34);
            counter_rotate.TabIndex = 5;
            counter_rotate.Text = "Rotate";
            counter_rotate.UseVisualStyleBackColor = false;
            counter_rotate.Click += button2_Click;
            // 
            // clk_rotate
            // 
            clk_rotate.BackColor = Color.Salmon;
            clk_rotate.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            clk_rotate.Location = new Point(343, 3);
            clk_rotate.Name = "clk_rotate";
            clk_rotate.Size = new Size(104, 34);
            clk_rotate.TabIndex = 4;
            clk_rotate.Text = "Flip ";
            clk_rotate.UseVisualStyleBackColor = false;
            clk_rotate.Click += clk_rotate_Click;
            // 
            // NextBtt
            // 
            NextBtt.BackColor = Color.Salmon;
            NextBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            NextBtt.Location = new Point(453, 3);
            NextBtt.Name = "NextBtt";
            NextBtt.Size = new Size(104, 34);
            NextBtt.TabIndex = 3;
            NextBtt.Text = "Next";
            NextBtt.UseVisualStyleBackColor = false;
            NextBtt.Click += NextBtt_Click;
            // 
            // CloseBtt
            // 
            CloseBtt.BackColor = Color.Salmon;
            CloseBtt.Font = new Font("Papyrus", 10.8F, FontStyle.Italic);
            CloseBtt.Location = new Point(563, 3);
            CloseBtt.Name = "CloseBtt";
            CloseBtt.Size = new Size(106, 33);
            CloseBtt.TabIndex = 1;
            CloseBtt.Text = "Close";
            CloseBtt.UseVisualStyleBackColor = false;
            CloseBtt.Click += CloseBtt_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1082, 566);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1082, 703);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Photostop";
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button OpenBtt;
        private Button CloseBtt;
        private Button PrevBtt;
        private Button NextBtt;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button counter_rotate;
        private Button clk_rotate;
    }
}
