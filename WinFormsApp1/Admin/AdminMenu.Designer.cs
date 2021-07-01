
namespace WinFormsApp1.Admin
{
    partial class AdminMenu
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
            this.leaderBoardBtn = new System.Windows.Forms.Button();
            this.addQuestionsBtn = new System.Windows.Forms.Button();
            this.deleteQuestionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leaderBoardBtn
            // 
            this.leaderBoardBtn.Location = new System.Drawing.Point(255, 78);
            this.leaderBoardBtn.Name = "leaderBoardBtn";
            this.leaderBoardBtn.Size = new System.Drawing.Size(259, 70);
            this.leaderBoardBtn.TabIndex = 0;
            this.leaderBoardBtn.Text = "Leaderboard";
            this.leaderBoardBtn.UseVisualStyleBackColor = true;
            this.leaderBoardBtn.Click += new System.EventHandler(this.leaderBoardBtn_Click);
            // 
            // addQuestionsBtn
            // 
            this.addQuestionsBtn.Location = new System.Drawing.Point(255, 185);
            this.addQuestionsBtn.Name = "addQuestionsBtn";
            this.addQuestionsBtn.Size = new System.Drawing.Size(259, 70);
            this.addQuestionsBtn.TabIndex = 1;
            this.addQuestionsBtn.Text = "Add Questions";
            this.addQuestionsBtn.UseVisualStyleBackColor = true;
            // 
            // deleteQuestionsBtn
            // 
            this.deleteQuestionsBtn.Location = new System.Drawing.Point(255, 295);
            this.deleteQuestionsBtn.Name = "deleteQuestionsBtn";
            this.deleteQuestionsBtn.Size = new System.Drawing.Size(259, 70);
            this.deleteQuestionsBtn.TabIndex = 2;
            this.deleteQuestionsBtn.Text = "Delete Questions";
            this.deleteQuestionsBtn.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteQuestionsBtn);
            this.Controls.Add(this.addQuestionsBtn);
            this.Controls.Add(this.leaderBoardBtn);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leaderBoardBtn;
        private System.Windows.Forms.Button addQuestionsBtn;
        private System.Windows.Forms.Button deleteQuestionsBtn;
    }
}