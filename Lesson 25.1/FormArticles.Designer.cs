namespace Lesson_17
{
    partial class FormArticles
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
            listBoxArticles = new ListBox();
            buttonAdd = new Button();
            buttonDel = new Button();
            buttonEdit = new Button();
            linkLabelExit = new LinkLabel();
            SuspendLayout();
            // 
            // listBoxArticles
            // 
            listBoxArticles.FormattingEnabled = true;
            listBoxArticles.ItemHeight = 15;
            listBoxArticles.Location = new Point(21, 20);
            listBoxArticles.Name = "listBoxArticles";
            listBoxArticles.Size = new Size(436, 394);
            listBoxArticles.TabIndex = 0;
            listBoxArticles.DoubleClick += listBoxArticles_DoubleClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(59, 428);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(308, 429);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 23);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(164, 428);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(121, 23);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // linkLabelExit
            // 
            linkLabelExit.AutoSize = true;
            linkLabelExit.Location = new Point(390, 2);
            linkLabelExit.Name = "linkLabelExit";
            linkLabelExit.Size = new Size(42, 15);
            linkLabelExit.TabIndex = 4;
            linkLabelExit.TabStop = true;
            linkLabelExit.Text = "Выход";
            linkLabelExit.LinkClicked += linkLabelExit_LinkClicked;
            // 
            // FormArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 463);
            Controls.Add(linkLabelExit);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDel);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxArticles);
            Name = "FormArticles";
            Text = "Статьи ";
            FormClosed += FormArticles_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxArticles;
        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonEdit;
        private LinkLabel linkLabelExit;
    }
}