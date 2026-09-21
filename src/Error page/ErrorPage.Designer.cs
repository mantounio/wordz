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
            linkLabel1 = new LinkLabel();
            pnl_lbl_error = new Panel();
            pnl_lbl_error.SuspendLayout();
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
            lbl_msg.Text = "This is an error message sad!!!! :(";
            lbl_msg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(226, 480);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(348, 489);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "go to add a word";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pnl_lbl_error
            // 
            pnl_lbl_error.Controls.Add(lbl_msg);
            pnl_lbl_error.Location = new Point(83, 197);
            pnl_lbl_error.Name = "pnl_lbl_error";
            pnl_lbl_error.Size = new Size(453, 263);
            pnl_lbl_error.TabIndex = 4;
            // 
            // ErrorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 0, 0);
            Controls.Add(pnl_lbl_error);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Name = "ErrorPage";
            Size = new Size(980, 681);
            pnl_lbl_error.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_msg;
        private Button button1;
        private LinkLabel linkLabel1;
        private Panel pnl_lbl_error;
    }
}
