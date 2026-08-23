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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl_mouseUP_info = new Label();
            lbl_mouseDOWN_info = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(176, 175);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 0;
            button1.Text = "mouse position";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(176, 222);
            button2.Name = "button2";
            button2.Size = new Size(165, 29);
            button2.TabIndex = 1;
            button2.Text = "e.x & e.y pos";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 237);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 162);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 3;
            label2.Text = "size of window : 962, 634";
            // 
            // lbl_mouseUP_info
            // 
            lbl_mouseUP_info.AutoSize = true;
            lbl_mouseUP_info.Location = new Point(447, 353);
            lbl_mouseUP_info.Name = "lbl_mouseUP_info";
            lbl_mouseUP_info.Size = new Size(87, 20);
            lbl_mouseUP_info.TabIndex = 4;
            lbl_mouseUP_info.Text = "information";
            // 
            // lbl_mouseDOWN_info
            // 
            lbl_mouseDOWN_info.AutoSize = true;
            lbl_mouseDOWN_info.Location = new Point(447, 409);
            lbl_mouseDOWN_info.Name = "lbl_mouseDOWN_info";
            lbl_mouseDOWN_info.Size = new Size(87, 20);
            lbl_mouseDOWN_info.TabIndex = 5;
            lbl_mouseDOWN_info.Text = "information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 634);
            Controls.Add(lbl_mouseDOWN_info);
            Controls.Add(lbl_mouseUP_info);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lbl_mouseUP_info;
        private Label lbl_mouseDOWN_info;
    }
}
