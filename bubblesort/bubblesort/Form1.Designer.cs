namespace bubblesort
{
    partial class Form1
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
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.listBoxColor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxList
            // 
            this.textBoxList.Location = new System.Drawing.Point(620, 58);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.Size = new System.Drawing.Size(168, 20);
            this.textBoxList.TabIndex = 0;
            this.textBoxList.TextChanged += new System.EventHandler(this.textBoxList_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Моля въведете размер на масива";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(695, 109);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(93, 37);
            this.buttonSort.TabIndex = 3;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // listBoxColor
            // 
            this.listBoxColor.FormattingEnabled = true;
            this.listBoxColor.Location = new System.Drawing.Point(36, 74);
            this.listBoxColor.Name = "listBoxColor";
            this.listBoxColor.Size = new System.Drawing.Size(223, 199);
            this.listBoxColor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Всеки цвят отговаря на число от масива,\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "както съответстват в списъка";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxSort
            // 
            this.textBoxSort.Enabled = false;
            this.textBoxSort.Location = new System.Drawing.Point(350, 146);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(150, 20);
            this.textBoxSort.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxColor);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListBox listBoxColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSort;
    }
}

