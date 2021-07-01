
namespace WinFormsApp1
{
    partial class MainMenu
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
            this.quizBtn = new System.Windows.Forms.Button();
            this.leaderbBtn = new System.Windows.Forms.Button();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quizBtn
            // 
            this.quizBtn.Location = new System.Drawing.Point(245, 41);
            this.quizBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quizBtn.Name = "quizBtn";
            this.quizBtn.Size = new System.Drawing.Size(272, 71);
            this.quizBtn.TabIndex = 0;
            this.quizBtn.Text = "Start Quiz";
            this.quizBtn.UseVisualStyleBackColor = true;
            this.quizBtn.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // leaderbBtn
            // 
            this.leaderbBtn.Location = new System.Drawing.Point(245, 155);
            this.leaderbBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leaderbBtn.Name = "leaderbBtn";
            this.leaderbBtn.Size = new System.Drawing.Size(272, 71);
            this.leaderbBtn.TabIndex = 1;
            this.leaderbBtn.Text = "Leader Board";
            this.leaderbBtn.UseVisualStyleBackColor = true;
            this.leaderbBtn.Click += new System.EventHandler(this.leaderbBtn_Click);
            // 
            // scoreBtn
            // 
            this.scoreBtn.Location = new System.Drawing.Point(245, 275);
            this.scoreBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(272, 71);
            this.scoreBtn.TabIndex = 2;
            this.scoreBtn.Text = "Show My Score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.leaderbBtn);
            this.Controls.Add(this.quizBtn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quizBtn;
        private System.Windows.Forms.Button leaderbBtn;
        private System.Windows.Forms.Button scoreBtn;
    }
}

