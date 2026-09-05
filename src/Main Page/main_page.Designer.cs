namespace wordz.src.Main_Page
{
    partial class main_page
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Image = Properties.Resources.l_quiz_75px;
            button1.Location = new Point(195, 103);
            button1.Name = "button1";
            button1.Size = new Size(226, 216);
            button1.TabIndex = 1;
            button1.Text = "Take a Quiz";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Image = Properties.Resources.l_add_translation_75px;
            button2.Location = new Point(554, 103);
            button2.Name = "button2";
            button2.Size = new Size(226, 216);
            button2.TabIndex = 2;
            button2.Text = "Add a Word";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F);
            button3.Image = Properties.Resources.l_settings_75px;
            button3.Location = new Point(554, 360);
            button3.Name = "button3";
            button3.Size = new Size(226, 216);
            button3.TabIndex = 4;
            button3.Text = "Settings";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F);
            button4.Image = Properties.Resources.l_words_list_75px;
            button4.Location = new Point(195, 360);
            button4.Name = "button4";
            button4.Size = new Size(226, 216);
            button4.TabIndex = 3;
            button4.Text = "Words List";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "&#128276;";
            // 
            // main_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "main_page";
            Size = new Size(980, 681);
            Click += main_page_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}
