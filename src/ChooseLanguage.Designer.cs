namespace wordz.src
{
    partial class ChooseLanguage
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
            lbl_choose_lang = new Label();
            combo_choose_lang = new MaterialSkin.Controls.MaterialComboBox();
            lbl_title = new Label();
            btn_start = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // lbl_choose_lang
            // 
            lbl_choose_lang.AutoSize = true;
            lbl_choose_lang.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_choose_lang.Location = new Point(141, 313);
            lbl_choose_lang.Name = "lbl_choose_lang";
            lbl_choose_lang.Size = new Size(179, 28);
            lbl_choose_lang.TabIndex = 0;
            lbl_choose_lang.Text = "Your Language :";
            // 
            // combo_choose_lang
            // 
            combo_choose_lang.AutoResize = false;
            combo_choose_lang.BackColor = Color.FromArgb(255, 255, 255);
            combo_choose_lang.Depth = 0;
            combo_choose_lang.DrawMode = DrawMode.OwnerDrawVariable;
            combo_choose_lang.DropDownHeight = 174;
            combo_choose_lang.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_choose_lang.DropDownWidth = 121;
            combo_choose_lang.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            combo_choose_lang.ForeColor = Color.FromArgb(222, 0, 0, 0);
            combo_choose_lang.FormattingEnabled = true;
            combo_choose_lang.IntegralHeight = false;
            combo_choose_lang.ItemHeight = 43;
            combo_choose_lang.Location = new Point(343, 301);
            combo_choose_lang.MaxDropDownItems = 4;
            combo_choose_lang.MouseState = MaterialSkin.MouseState.OUT;
            combo_choose_lang.Name = "combo_choose_lang";
            combo_choose_lang.Size = new Size(381, 49);
            combo_choose_lang.StartIndex = 0;
            combo_choose_lang.TabIndex = 1;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(168, 128);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(645, 41);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "Please select a language to take the quiz.";
            // 
            // btn_start
            // 
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_start.Location = new Point(334, 439);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(313, 72);
            btn_start.TabIndex = 3;
            btn_start.Text = "Start Quiz";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_back
            // 
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Image = Properties.Resources.back_50px;
            btn_back.Location = new Point(25, 60);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(69, 52);
            btn_back.TabIndex = 4;
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ChooseLanguage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_back);
            Controls.Add(btn_start);
            Controls.Add(lbl_title);
            Controls.Add(combo_choose_lang);
            Controls.Add(lbl_choose_lang);
            Name = "ChooseLanguage";
            Size = new Size(980, 681);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_choose_lang;
        private MaterialSkin.Controls.MaterialComboBox combo_choose_lang;
        private Label lbl_title;
        private Button btn_start;
        private Button btn_back;
    }
}
