namespace NameSearch
{
    partial class NameSearch
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
            this.nameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameDesc = new System.Windows.Forms.Label();
            this.girlPopularLabel = new System.Windows.Forms.Label();
            this.boyPopularLabel = new System.Windows.Forms.Label();
            this.girlBox = new System.Windows.Forms.TextBox();
            this.boyBox = new System.Windows.Forms.TextBox();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.yesOrNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(71, 327);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(207, 48);
            this.nameButton.TabIndex = 0;
            this.nameButton.Text = "Are these names popular?";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(379, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 48);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(159, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(230, 25);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name Search Program";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameDesc
            // 
            this.nameDesc.AutoSize = true;
            this.nameDesc.Location = new System.Drawing.Point(27, 79);
            this.nameDesc.Name = "nameDesc";
            this.nameDesc.Size = new System.Drawing.Size(553, 17);
            this.nameDesc.TabIndex = 3;
            this.nameDesc.Text = "Enter a boy and a girl name, and find out if either of them are among the most po" +
    "pular!";
            // 
            // girlPopularLabel
            // 
            this.girlPopularLabel.AutoSize = true;
            this.girlPopularLabel.Location = new System.Drawing.Point(124, 136);
            this.girlPopularLabel.Name = "girlPopularLabel";
            this.girlPopularLabel.Size = new System.Drawing.Size(128, 17);
            this.girlPopularLabel.TabIndex = 4;
            this.girlPopularLabel.Text = "Popular Girl Name:";
            // 
            // boyPopularLabel
            // 
            this.boyPopularLabel.AutoSize = true;
            this.boyPopularLabel.Location = new System.Drawing.Point(124, 218);
            this.boyPopularLabel.Name = "boyPopularLabel";
            this.boyPopularLabel.Size = new System.Drawing.Size(130, 17);
            this.boyPopularLabel.TabIndex = 5;
            this.boyPopularLabel.Text = "Popular Boy Name:";
            // 
            // girlBox
            // 
            this.girlBox.Location = new System.Drawing.Point(274, 136);
            this.girlBox.Name = "girlBox";
            this.girlBox.Size = new System.Drawing.Size(100, 22);
            this.girlBox.TabIndex = 7;
            // 
            // boyBox
            // 
            this.boyBox.Location = new System.Drawing.Point(274, 213);
            this.boyBox.Name = "boyBox";
            this.boyBox.Size = new System.Drawing.Size(100, 22);
            this.boyBox.TabIndex = 8;
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 16;
            this.nameListBox.Location = new System.Drawing.Point(419, 127);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(143, 132);
            this.nameListBox.TabIndex = 9;
            // 
            // yesOrNo
            // 
            this.yesOrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yesOrNo.Location = new System.Drawing.Point(116, 285);
            this.yesOrNo.Name = "yesOrNo";
            this.yesOrNo.Size = new System.Drawing.Size(100, 23);
            this.yesOrNo.TabIndex = 10;
            this.yesOrNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 425);
            this.Controls.Add(this.yesOrNo);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.boyBox);
            this.Controls.Add(this.girlBox);
            this.Controls.Add(this.boyPopularLabel);
            this.Controls.Add(this.girlPopularLabel);
            this.Controls.Add(this.nameDesc);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameButton);
            this.Name = "NameSearch";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameDesc;
        private System.Windows.Forms.Label girlPopularLabel;
        private System.Windows.Forms.Label boyPopularLabel;
        private System.Windows.Forms.TextBox girlBox;
        private System.Windows.Forms.TextBox boyBox;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label yesOrNo;
    }
}

