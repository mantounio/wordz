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
            btn_takequiz = new Button();
            btn_addword = new Button();
            btn_setting = new Button();
            btn_wordslist = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_takequiz
            // 
            btn_takequiz.BackColor = SystemColors.Control;
            btn_takequiz.FlatStyle = FlatStyle.Flat;
            btn_takequiz.Font = new Font("Segoe UI", 15F);
            btn_takequiz.Image = Properties.Resources.l_quiz_75px;
            btn_takequiz.Location = new Point(195, 103);
            btn_takequiz.Name = "btn_takequiz";
            btn_takequiz.Size = new Size(226, 216);
            btn_takequiz.TabIndex = 1;
            btn_takequiz.Text = "Take a Quiz";
            btn_takequiz.TextAlign = ContentAlignment.BottomCenter;
            btn_takequiz.UseVisualStyleBackColor = false;
            // 
            // btn_addword
            // 
            btn_addword.FlatStyle = FlatStyle.Flat;
            btn_addword.Font = new Font("Segoe UI", 15F);
            btn_addword.Image = Properties.Resources.l_add_translation_75px;
            btn_addword.Location = new Point(554, 103);
            btn_addword.Name = "btn_addword";
            btn_addword.Size = new Size(226, 216);
            btn_addword.TabIndex = 2;
            btn_addword.Text = "Add a Word";
            btn_addword.TextAlign = ContentAlignment.BottomCenter;
            btn_addword.UseVisualStyleBackColor = true;
            btn_addword.Click += btn_addword_Click;
            // 
            // btn_setting
            // 
            btn_setting.FlatStyle = FlatStyle.Flat;
            btn_setting.Font = new Font("Segoe UI", 15F);
            btn_setting.Image = Properties.Resources.l_settings_75px;
            btn_setting.Location = new Point(554, 360);
            btn_setting.Name = "btn_setting";
            btn_setting.Size = new Size(226, 216);
            btn_setting.TabIndex = 4;
            btn_setting.Text = "Settings";
            btn_setting.TextAlign = ContentAlignment.BottomCenter;
            btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_wordslist
            // 
            btn_wordslist.FlatStyle = FlatStyle.Flat;
            btn_wordslist.Font = new Font("Segoe UI", 15F);
            btn_wordslist.Image = Properties.Resources.l_words_list_75px;
            btn_wordslist.Location = new Point(195, 360);
            btn_wordslist.Name = "btn_wordslist";
            btn_wordslist.Size = new Size(226, 216);
            btn_wordslist.TabIndex = 3;
            btn_wordslist.Text = "Words List";
            btn_wordslist.TextAlign = ContentAlignment.BottomCenter;
            btn_wordslist.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 49);
            label1.Name = "label1";
            label1.Size = new Size(163, 53);
            label1.TabIndex = 5;
            label1.Text = "•Wordz";
            // 
            // main_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label1);
            Controls.Add(btn_setting);
            Controls.Add(btn_wordslist);
            Controls.Add(btn_addword);
            Controls.Add(btn_takequiz);
            Name = "main_page";
            Size = new Size(980, 681);
            Click += main_page_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_takequiz;
        private Button btn_addword;
        private Button btn_setting;
        private Button btn_wordslist;
        private Label label1;
    }
}
