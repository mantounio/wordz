namespace wordz.src.Error_page
{
    partial class ErrorPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_msg = new Label();
            button1 = new Button();
            pnl_lbl_error = new Panel();
            link_lbl_redirect_add_word = new LinkLabel();
            pictureBox1 = new PictureBox();
            pnl_lbl_error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_msg
            // 
            lbl_msg.Dock = DockStyle.Fill;
            lbl_msg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_msg.Location = new Point(0, 0);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(453, 263);
            lbl_msg.TabIndex = 0;
            lbl_msg.Text = "msg";
            lbl_msg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(230, 0, 0);
            button1.Image = Properties.Resources.back_50px;
            button1.Location = new Point(25, 60);
            button1.Name = "button1";
            button1.Size = new Size(69, 52);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnl_lbl_error
            // 
            pnl_lbl_error.Controls.Add(link_lbl_redirect_add_word);
            pnl_lbl_error.Controls.Add(lbl_msg);
            pnl_lbl_error.Location = new Point(83, 197);
            pnl_lbl_error.Name = "pnl_lbl_error";
            pnl_lbl_error.Size = new Size(453, 263);
            pnl_lbl_error.TabIndex = 4;
            // 
            // link_lbl_redirect_add_word
            // 
            link_lbl_redirect_add_word.AutoSize = true;
            link_lbl_redirect_add_word.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_lbl_redirect_add_word.LinkBehavior = LinkBehavior.HoverUnderline;
            link_lbl_redirect_add_word.LinkColor = Color.FromArgb(255, 243, 176);
            link_lbl_redirect_add_word.Location = new Point(159, 225);
            link_lbl_redirect_add_word.Name = "link_lbl_redirect_add_word";
            link_lbl_redirect_add_word.Size = new Size(154, 28);
            link_lbl_redirect_add_word.TabIndex = 6;
            link_lbl_redirect_add_word.TabStop = true;
            link_lbl_redirect_add_word.Text = "Add a new word";
            link_lbl_redirect_add_word.LinkClicked += link_lbl_redirect_add_word_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3d_error100px;
            pictureBox1.Location = new Point(679, 567);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ErrorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 0, 0);
            Controls.Add(pictureBox1);
            Controls.Add(pnl_lbl_error);
            Controls.Add(button1);
            Name = "ErrorPage";
            Size = new Size(980, 681);
            pnl_lbl_error.ResumeLayout(false);
            pnl_lbl_error.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_msg;
        private Button button1;
        private Panel pnl_lbl_error;
        private PictureBox pictureBox1;
        private LinkLabel link_lbl_redirect_add_word;
    }
}
