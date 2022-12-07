
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMaxInd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endIndex = new System.Windows.Forms.TextBox();
            this.Conclusion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMax.Location = new System.Drawing.Point(12, 275);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(319, 94);
            this.buttonMax.TabIndex = 1;
            this.buttonMax.Text = "Вычислить максимальное значение из элемента класса ";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMaxInd
            // 
            this.buttonMaxInd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMaxInd.Location = new System.Drawing.Point(12, 175);
            this.buttonMaxInd.Name = "buttonMaxInd";
            this.buttonMaxInd.Size = new System.Drawing.Size(319, 94);
            this.buttonMaxInd.TabIndex = 2;
            this.buttonMaxInd.Text = "Вычислить максимальное значение из элемента класса ограничено начальным и конечны" +
    "м индексом";
            this.buttonMaxInd.UseVisualStyleBackColor = true;
            this.buttonMaxInd.Click += new System.EventHandler(this.buttonMaxInd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите массив (целыми числами через пробел)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "введите начальный индекс";
            // 
            // startIndex
            // 
            this.startIndex.Location = new System.Drawing.Point(12, 83);
            this.startIndex.Name = "startIndex";
            this.startIndex.Size = new System.Drawing.Size(204, 23);
            this.startIndex.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "введите конечный индекс";
            // 
            // endIndex
            // 
            this.endIndex.Location = new System.Drawing.Point(12, 133);
            this.endIndex.Name = "endIndex";
            this.endIndex.Size = new System.Drawing.Size(204, 23);
            this.endIndex.TabIndex = 8;
            // 
            // Conclusion
            // 
            this.Conclusion.Location = new System.Drawing.Point(337, 175);
            this.Conclusion.Multiline = true;
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(445, 263);
            this.Conclusion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(337, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вывод решения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Conclusion);
            this.Controls.Add(this.endIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonMaxInd);
            this.Controls.Add(this.buttonMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMaxInd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endIndex;
        private System.Windows.Forms.TextBox Conclusion;
        private System.Windows.Forms.Label label4;
    }
}

