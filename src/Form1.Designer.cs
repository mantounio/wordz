namespace wordz.src
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
            btn_close = new PictureBox();
            btn_minimize = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = SystemColors.Control;
            btn_close.Image = Properties.Resources.red_24;
            btn_close.Location = new Point(914, 25);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(24, 24);
            btn_close.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_close.TabIndex = 0;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            btn_close.MouseEnter += btn_close_MouseEnter;
            btn_close.MouseLeave += btn_close_MouseLeave;
            // 
            // btn_minimize
            // 
            btn_minimize.Image = Properties.Resources.yellow_24;
            btn_minimize.Location = new Point(884, 25);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(24, 24);
            btn_minimize.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_minimize.TabIndex = 1;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            btn_minimize.MouseEnter += btn_minimize_MouseEnter;
            btn_minimize.MouseLeave += btn_minimize_MouseLeave;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 634);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 634);
            Controls.Add(btn_minimize);
            Controls.Add(btn_close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private PictureBox btn_minimize;
        private Panel panel1;
    }
}
