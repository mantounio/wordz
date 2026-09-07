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
            pnl_container = new Panel();
            pnl_mov_window = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            pnl_container.SuspendLayout();
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
            btn_minimize.BackColor = SystemColors.Control;
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
            // pnl_container
            // 
            pnl_container.BackColor = SystemColors.Control;
            pnl_container.Controls.Add(pnl_mov_window);
            pnl_container.Dock = DockStyle.Fill;
            pnl_container.Location = new Point(0, 0);
            pnl_container.Name = "pnl_container";
            pnl_container.Size = new Size(962, 634);
            pnl_container.TabIndex = 2;
            // 
            // pnl_mov_window
            // 
            pnl_mov_window.Dock = DockStyle.Top;
            pnl_mov_window.Location = new Point(0, 0);
            pnl_mov_window.Name = "pnl_mov_window";
            pnl_mov_window.Size = new Size(962, 49);
            pnl_mov_window.TabIndex = 0;
            pnl_mov_window.MouseDown += pnl_mov_window_MouseDown;
            pnl_mov_window.MouseMove += pnl_mov_window_MouseMove;
            pnl_mov_window.MouseUp += pnl_mov_window_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 634);
            Controls.Add(btn_minimize);
            Controls.Add(btn_close);
            Controls.Add(pnl_container);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            pnl_container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private PictureBox btn_minimize;
        public Panel pnl_container;
        private Panel pnl_mov_window;
    }
}
