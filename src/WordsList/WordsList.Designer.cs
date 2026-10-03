namespace wordz.src.WordsList
{
    partial class WordsList
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
            dataGridView1 = new DataGridView();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 507);
            dataGridView1.TabIndex = 0;
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
            btn_back.Click += button3_Click;
            // 
            // WordsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_back);
            Controls.Add(dataGridView1);
            Name = "WordsList";
            Size = new Size(980, 681);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_back;
    }
}
