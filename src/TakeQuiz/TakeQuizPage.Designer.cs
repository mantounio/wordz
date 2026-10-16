namespace wordz.src
{
    partial class TakeQuizPage
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
            lbl_word = new Label();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            SuspendLayout();
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Location = new Point(465, 127);
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size(50, 20);
            lbl_word.TabIndex = 0;
            lbl_word.Text = "label1";
            // 
            // b1
            // 
            b1.Location = new Point(290, 196);
            b1.Name = "b1";
            b1.Size = new Size(165, 130);
            b1.TabIndex = 1;
            b1.Text = "button1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(526, 196);
            b2.Name = "b2";
            b2.Size = new Size(165, 130);
            b2.TabIndex = 2;
            b2.Text = "button2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(290, 386);
            b3.Name = "b3";
            b3.Size = new Size(165, 130);
            b3.TabIndex = 3;
            b3.Text = "button3";
            b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            b4.Location = new Point(526, 386);
            b4.Name = "b4";
            b4.Size = new Size(165, 130);
            b4.TabIndex = 4;
            b4.Text = "button4";
            b4.UseVisualStyleBackColor = true;
            // 
            // TakeQuizPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(lbl_word);
            Name = "TakeQuizPage";
            Size = new Size(980, 681);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_word;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
    }
}
