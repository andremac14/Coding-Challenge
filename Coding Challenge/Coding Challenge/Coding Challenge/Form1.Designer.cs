namespace Coding_Challenge
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
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.btnRead = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.btnExit = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.btnEnter = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtNumTimesWordIsUsed = new System.Windows.Forms.TextBox();
         this.txtNumWordsInFIle = new System.Windows.Forms.TextBox();
         this.percentageWordSelected = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // btnRead
         // 
         this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRead.Location = new System.Drawing.Point(517, 36);
         this.btnRead.Margin = new System.Windows.Forms.Padding(4);
         this.btnRead.Name = "btnRead";
         this.btnRead.Size = new System.Drawing.Size(856, 94);
         this.btnRead.TabIndex = 0;
         this.btnRead.Text = "Read Input File";
         this.btnRead.UseVisualStyleBackColor = true;
         this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(126, 218);
         this.textBox1.Margin = new System.Windows.Forms.Padding(4);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(608, 29);
         this.textBox1.TabIndex = 1;
         // 
         // btnExit
         // 
         this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnExit.Location = new System.Drawing.Point(1744, 1095);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(178, 91);
         this.btnExit.TabIndex = 2;
         this.btnExit.Text = "Exit";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(121, 173);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(204, 25);
         this.label1.TabIndex = 3;
         this.label1.Text = "Please enter in a word";
         // 
         // btnEnter
         // 
         this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEnter.Location = new System.Drawing.Point(794, 210);
         this.btnEnter.Name = "btnEnter";
         this.btnEnter.Size = new System.Drawing.Size(104, 47);
         this.btnEnter.TabIndex = 4;
         this.btnEnter.Text = "Enter";
         this.btnEnter.UseVisualStyleBackColor = true;
         this.btnEnter.Click += new System.EventHandler(this.button1_Click);
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(1024, 173);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 31;
         this.dataGridView1.Size = new System.Drawing.Size(818, 856);
         this.dataGridView1.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(354, 449);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(380, 25);
         this.label2.TabIndex = 6;
         this.label2.Text = "Number of times the word is used in the file";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(446, 635);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(288, 25);
         this.label3.TabIndex = 7;
         this.label3.Text = "Number of words used in the file";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(225, 796);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(509, 25);
         this.label4.TabIndex = 8;
         this.label4.Text = "Percentage of the word selected vs the overall word count";
         // 
         // txtNumTimesWordIsUsed
         // 
         this.txtNumTimesWordIsUsed.Location = new System.Drawing.Point(798, 449);
         this.txtNumTimesWordIsUsed.Name = "txtNumTimesWordIsUsed";
         this.txtNumTimesWordIsUsed.ReadOnly = true;
         this.txtNumTimesWordIsUsed.Size = new System.Drawing.Size(100, 29);
         this.txtNumTimesWordIsUsed.TabIndex = 9;
         // 
         // txtNumWordsInFIle
         // 
         this.txtNumWordsInFIle.Location = new System.Drawing.Point(798, 632);
         this.txtNumWordsInFIle.Name = "txtNumWordsInFIle";
         this.txtNumWordsInFIle.ReadOnly = true;
         this.txtNumWordsInFIle.Size = new System.Drawing.Size(100, 29);
         this.txtNumWordsInFIle.TabIndex = 10;
         // 
         // percentageWordSelected
         // 
         this.percentageWordSelected.Location = new System.Drawing.Point(794, 793);
         this.percentageWordSelected.Name = "percentageWordSelected";
         this.percentageWordSelected.ReadOnly = true;
         this.percentageWordSelected.Size = new System.Drawing.Size(100, 29);
         this.percentageWordSelected.TabIndex = 11;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1934, 1198);
         this.Controls.Add(this.percentageWordSelected);
         this.Controls.Add(this.txtNumWordsInFIle);
         this.Controls.Add(this.txtNumTimesWordIsUsed);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.btnEnter);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.btnRead);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Form1";
         this.Text = "Andre Sandoval Coding Challenge";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Button btnRead;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnEnter;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtNumTimesWordIsUsed;
      private System.Windows.Forms.TextBox txtNumWordsInFIle;
      private System.Windows.Forms.TextBox percentageWordSelected;
   }
}

