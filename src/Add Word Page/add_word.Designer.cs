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
            lbl_word = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
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
            materialCard1.Controls.Add(lbl_word);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(171, 139);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(638, 403);
            materialCard1.TabIndex = 4;
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Depth = 0;
            lbl_word.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_word.Location = new Point(76, 103);
            lbl_word.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size(40, 19);
            lbl_word.TabIndex = 1;
            lbl_word.Text = "word:";
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
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lbl_word;
    }
}
