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
            button2 = new Button();
            SuspendLayout();
            // 
            // lbl_msg
            // 
            lbl_msg.Dock = DockStyle.Fill;
            lbl_msg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_msg.Location = new Point(0, 0);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(980, 681);
            lbl_msg.TabIndex = 0;
            lbl_msg.Text = "This is an error message sad!!!! :(";
            lbl_msg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(443, 435);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(443, 391);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ErrorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 0, 0);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_msg);
            Name = "ErrorPage";
            Size = new Size(980, 681);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_msg;
        private Button button1;
        private Button button2;
    }
}
