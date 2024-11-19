namespace Lesson_17
{
    partial class FormArticle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTheme = new TextBox();
            textBoxArticle = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBoxAuthor = new TextBox();
            richTextBox1 = new RichTextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBoxTheme
            // 
            textBoxTheme.Location = new Point(26, 20);
            textBoxTheme.Name = "textBoxTheme";
            textBoxTheme.PlaceholderText = "Тема";
            textBoxTheme.Size = new Size(307, 23);
            textBoxTheme.TabIndex = 0;
            // 
            // textBoxArticle
            // 
            textBoxArticle.Location = new Point(27, 61);
            textBoxArticle.Name = "textBoxArticle";
            textBoxArticle.PlaceholderText = "Заголовок";
            textBoxArticle.Size = new Size(306, 23);
            textBoxArticle.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(29, 100);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(304, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(31, 141);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.ReadOnly = true;
            textBoxAuthor.Size = new Size(302, 23);
            textBoxAuthor.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(387, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(401, 415);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(32, 416);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(199, 415);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(richTextBox1);
            Controls.Add(textBoxAuthor);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxArticle);
            Controls.Add(textBoxTheme);
            Name = "FormArticle";
            Text = "Статья";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private Button buttonCancel;
        public TextBox textBoxTheme;
        public TextBox textBoxArticle;
        public NumericUpDown numericUpDown1;
        public TextBox textBoxAuthor;
        public RichTextBox richTextBox1;
    }
}