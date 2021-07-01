
namespace WinFormsApp1
{
    partial class Quiz
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
            this.questionLBL = new System.Windows.Forms.Label();
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.answerBtn4 = new System.Windows.Forms.Button();
            this.jokerBtn = new System.Windows.Forms.Button();
            this.jokerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLBL
            // 
            this.questionLBL.AutoSize = true;
            this.questionLBL.Location = new System.Drawing.Point(303, 89);
            this.questionLBL.Name = "questionLBL";
            this.questionLBL.Size = new System.Drawing.Size(31, 15);
            this.questionLBL.TabIndex = 0;
            this.questionLBL.Text = "Soru";
            // 
            // answerBtn1
            // 
            this.answerBtn1.Location = new System.Drawing.Point(122, 148);
            this.answerBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(108, 39);
            this.answerBtn1.TabIndex = 1;
            this.answerBtn1.Tag = "1";
            this.answerBtn1.Text = "button1";
            this.answerBtn1.UseVisualStyleBackColor = true;
            this.answerBtn1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // answerBtn2
            // 
            this.answerBtn2.Location = new System.Drawing.Point(442, 149);
            this.answerBtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(119, 38);
            this.answerBtn2.TabIndex = 2;
            this.answerBtn2.Tag = "2";
            this.answerBtn2.Text = "button2";
            this.answerBtn2.UseVisualStyleBackColor = true;
            this.answerBtn2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // answerBtn3
            // 
            this.answerBtn3.Location = new System.Drawing.Point(122, 224);
            this.answerBtn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(108, 40);
            this.answerBtn3.TabIndex = 3;
            this.answerBtn3.Tag = "3";
            this.answerBtn3.Text = "button3";
            this.answerBtn3.UseVisualStyleBackColor = true;
            this.answerBtn3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // answerBtn4
            // 
            this.answerBtn4.Location = new System.Drawing.Point(442, 220);
            this.answerBtn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerBtn4.Name = "answerBtn4";
            this.answerBtn4.Size = new System.Drawing.Size(119, 44);
            this.answerBtn4.TabIndex = 4;
            this.answerBtn4.Tag = "4";
            this.answerBtn4.Text = "button4";
            this.answerBtn4.UseVisualStyleBackColor = true;
            this.answerBtn4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // jokerBtn
            // 
            this.jokerBtn.Location = new System.Drawing.Point(264, 190);
            this.jokerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jokerBtn.Name = "jokerBtn";
            this.jokerBtn.Size = new System.Drawing.Size(139, 22);
            this.jokerBtn.TabIndex = 5;
            this.jokerBtn.Tag = "5";
            this.jokerBtn.Text = "JOKER";
            this.jokerBtn.UseVisualStyleBackColor = true;
            this.jokerBtn.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // jokerLbl
            // 
            this.jokerLbl.AutoSize = true;
            this.jokerLbl.Location = new System.Drawing.Point(37, 27);
            this.jokerLbl.Name = "jokerLbl";
            this.jokerLbl.Size = new System.Drawing.Size(81, 15);
            this.jokerLbl.TabIndex = 6;
            this.jokerLbl.Text = "Joker Number";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.jokerLbl);
            this.Controls.Add(this.jokerBtn);
            this.Controls.Add(this.answerBtn4);
            this.Controls.Add(this.answerBtn3);
            this.Controls.Add(this.answerBtn2);
            this.Controls.Add(this.answerBtn1);
            this.Controls.Add(this.questionLBL);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLBL;
        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.Button answerBtn4;
        private System.Windows.Forms.Button jokerBtn;
        private System.Windows.Forms.Label jokerLbl;
    }
}