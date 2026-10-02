namespace wordz.src.add_word
{
    partial class Add_word
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
            button3 = new Button();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lbl_title = new Label();
            pictureBox1 = new PictureBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txt_meaning = new MaterialSkin.Controls.MaterialTextBox();
            txt_word = new MaterialSkin.Controls.MaterialTextBox();
            combo_lang = new MaterialSkin.Controls.MaterialComboBox();
            lbl_language = new Label();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.Control;
            button3.Image = Properties.Resources.back_50px;
            button3.Location = new Point(25, 60);
            button3.Name = "button3";
            button3.Size = new Size(69, 52);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lbl_title);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(materialButton2);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(txt_meaning);
            materialCard1.Controls.Add(txt_word);
            materialCard1.Controls.Add(combo_lang);
            materialCard1.Controls.Add(lbl_language);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(171, 113);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(638, 403);
            materialCard1.TabIndex = 4;
            materialCard1.Click += materialCard1_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(212, 28);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(214, 38);
            lbl_title.TabIndex = 6;
            lbl_title.Text = "add a new word";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.word_to_word_50px;
            pictureBox1.Location = new Point(294, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(484, 356);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "add";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(556, 356);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "add";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txt_meaning
            // 
            txt_meaning.AnimateReadOnly = false;
            txt_meaning.BorderStyle = BorderStyle.None;
            txt_meaning.Depth = 0;
            txt_meaning.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_meaning.Hint = "Meaning";
            txt_meaning.LeadingIcon = null;
            txt_meaning.Location = new Point(381, 115);
            txt_meaning.MaxLength = 50;
            txt_meaning.MouseState = MaterialSkin.MouseState.OUT;
            txt_meaning.Multiline = false;
            txt_meaning.Name = "txt_meaning";
            txt_meaning.Size = new Size(204, 50);
            txt_meaning.TabIndex = 4;
            txt_meaning.Tag = "meaning";
            txt_meaning.Text = "";
            txt_meaning.TrailingIcon = null;
            txt_meaning.UseAccent = false;
            // 
            // txt_word
            // 
            txt_word.AnimateReadOnly = false;
            txt_word.BorderStyle = BorderStyle.None;
            txt_word.Depth = 0;
            txt_word.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_word.Hint = "Word";
            txt_word.LeadingIcon = null;
            txt_word.Location = new Point(51, 115);
            txt_word.MaxLength = 50;
            txt_word.MouseState = MaterialSkin.MouseState.OUT;
            txt_word.Multiline = false;
            txt_word.Name = "txt_word";
            txt_word.Size = new Size(204, 50);
            txt_word.TabIndex = 3;
            txt_word.Tag = "word";
            txt_word.Text = "";
            txt_word.TrailingIcon = null;
            txt_word.UseAccent = false;
            // 
            // combo_lang
            // 
            combo_lang.AutoResize = false;
            combo_lang.BackColor = Color.FromArgb(255, 255, 255);
            combo_lang.Depth = 0;
            combo_lang.DrawMode = DrawMode.OwnerDrawVariable;
            combo_lang.DropDownHeight = 174;
            combo_lang.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_lang.DropDownWidth = 121;
            combo_lang.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            combo_lang.ForeColor = Color.FromArgb(222, 0, 0, 0);
            combo_lang.FormattingEnabled = true;
            combo_lang.Hint = "Language";
            combo_lang.IntegralHeight = false;
            combo_lang.ItemHeight = 43;
            combo_lang.Location = new Point(165, 219);
            combo_lang.MaxDropDownItems = 4;
            combo_lang.MouseState = MaterialSkin.MouseState.OUT;
            combo_lang.Name = "combo_lang";
            combo_lang.Size = new Size(182, 49);
            combo_lang.StartIndex = 0;
            combo_lang.TabIndex = 2;
            combo_lang.Tag = "language";
            combo_lang.UseAccent = false;
            // 
            // lbl_language
            // 
            lbl_language.AutoSize = true;
            lbl_language.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_language.Location = new Point(43, 234);
            lbl_language.Name = "lbl_language";
            lbl_language.Size = new Size(116, 24);
            lbl_language.TabIndex = 0;
            lbl_language.Text = "Language : ";
            // 
            // Add_word
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(materialCard1);
            Controls.Add(button3);
            Name = "Add_word";
            Size = new Size(980, 681);
            Click += Add_word_Click;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox combo_lang;
        private Label lbl_language;
        private MaterialSkin.Controls.MaterialTextBox txt_meaning;
        private MaterialSkin.Controls.MaterialTextBox txt_word;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox pictureBox1;
        private Label lbl_title;
    }
}
