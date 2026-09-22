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
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 320);
            label1.Name = "label1";
            label1.Size = new Size(363, 41);
            label1.TabIndex = 0;
            label1.Text = "add a word window baby";
            // 
            // button2
            // 
            button2.Location = new Point(578, 117);
            button2.Name = "button2";
            button2.Size = new Size(147, 29);
            button2.TabIndex = 2;
            button2.Text = "create table";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // Add_word
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Add_word";
            Size = new Size(980, 681);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button3;
    }
}
