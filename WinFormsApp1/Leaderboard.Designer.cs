
namespace QuizShowApplication
{
    partial class Leaderboard
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
            this.leaderList = new System.Windows.Forms.ListView();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leaderList
            // 
            this.leaderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader});
            this.leaderList.FullRowSelect = true;
            this.leaderList.GridLines = true;
            this.leaderList.HideSelection = false;
            this.leaderList.Location = new System.Drawing.Point(110, 72);
            this.leaderList.Name = "leaderList";
            this.leaderList.Size = new System.Drawing.Size(584, 295);
            this.leaderList.TabIndex = 0;
            this.leaderList.UseCompatibleStateImageBehavior = false;
            this.leaderList.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 200;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(593, 394);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 31);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.leaderList);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView leaderList;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.Button backBtn;
    }
}