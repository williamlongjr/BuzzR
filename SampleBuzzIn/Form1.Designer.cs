
namespace SampleBuzzIn
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
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTeam1 = new System.Windows.Forms.Button();
            this.btnTeam2 = new System.Windows.Forms.Button();
            this.btnTeam3 = new System.Windows.Forms.Button();
            this.btnTeam4 = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.lstDebug = new System.Windows.Forms.ListBox();
            this.btnClearDebug = new System.Windows.Forms.Button();
            this.btnAddPlayer1 = new System.Windows.Forms.Button();
            this.btnAddPlayer2 = new System.Windows.Forms.Button();
            this.btnAddPlayer3 = new System.Windows.Forms.Button();
            this.btnAddPlayer4 = new System.Windows.Forms.Button();
            this.lblPlayers1 = new System.Windows.Forms.Label();
            this.lblPlayers2 = new System.Windows.Forms.Label();
            this.lblPlayers3 = new System.Windows.Forms.Label();
            this.lblPlayers4 = new System.Windows.Forms.Label();
            this.btnAddTeam2 = new System.Windows.Forms.Button();
            this.btnAddTeam3 = new System.Windows.Forms.Button();
            this.btnAddTeam4 = new System.Windows.Forms.Button();
            this.lblPlace1 = new System.Windows.Forms.Label();
            this.lblPlace2 = new System.Windows.Forms.Label();
            this.lblPlace3 = new System.Windows.Forms.Label();
            this.lblPlace4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(12, 21);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(84, 27);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 415);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTeam1
            // 
            this.btnTeam1.Location = new System.Drawing.Point(111, 22);
            this.btnTeam1.Name = "btnTeam1";
            this.btnTeam1.Size = new System.Drawing.Size(116, 26);
            this.btnTeam1.TabIndex = 3;
            this.btnTeam1.Text = "button1";
            this.btnTeam1.UseVisualStyleBackColor = true;
            this.btnTeam1.Click += new System.EventHandler(this.btnTeam1_Click);
            // 
            // btnTeam2
            // 
            this.btnTeam2.Location = new System.Drawing.Point(111, 54);
            this.btnTeam2.Name = "btnTeam2";
            this.btnTeam2.Size = new System.Drawing.Size(116, 23);
            this.btnTeam2.TabIndex = 4;
            this.btnTeam2.Text = "button2";
            this.btnTeam2.UseVisualStyleBackColor = true;
            this.btnTeam2.Click += new System.EventHandler(this.btnTeam2_Click);
            // 
            // btnTeam3
            // 
            this.btnTeam3.Location = new System.Drawing.Point(111, 83);
            this.btnTeam3.Name = "btnTeam3";
            this.btnTeam3.Size = new System.Drawing.Size(116, 23);
            this.btnTeam3.TabIndex = 5;
            this.btnTeam3.Text = "button3";
            this.btnTeam3.UseVisualStyleBackColor = true;
            this.btnTeam3.Click += new System.EventHandler(this.btnTeam3_Click);
            // 
            // btnTeam4
            // 
            this.btnTeam4.Location = new System.Drawing.Point(111, 112);
            this.btnTeam4.Name = "btnTeam4";
            this.btnTeam4.Size = new System.Drawing.Size(116, 23);
            this.btnTeam4.TabIndex = 6;
            this.btnTeam4.Text = "button4";
            this.btnTeam4.UseVisualStyleBackColor = true;
            this.btnTeam4.Click += new System.EventHandler(this.btnTeam4_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebug.Location = new System.Drawing.Point(500, 14);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(192, 23);
            this.btnDebug.TabIndex = 7;
            this.btnDebug.Text = "Debug Dump";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // lstDebug
            // 
            this.lstDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDebug.FormattingEnabled = true;
            this.lstDebug.ItemHeight = 15;
            this.lstDebug.Location = new System.Drawing.Point(499, 72);
            this.lstDebug.Name = "lstDebug";
            this.lstDebug.Size = new System.Drawing.Size(191, 349);
            this.lstDebug.TabIndex = 8;
            // 
            // btnClearDebug
            // 
            this.btnClearDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDebug.Location = new System.Drawing.Point(499, 43);
            this.btnClearDebug.Name = "btnClearDebug";
            this.btnClearDebug.Size = new System.Drawing.Size(192, 23);
            this.btnClearDebug.TabIndex = 9;
            this.btnClearDebug.Text = "Clear";
            this.btnClearDebug.UseVisualStyleBackColor = true;
            this.btnClearDebug.Click += new System.EventHandler(this.btnClearDebug_Click);
            // 
            // btnAddPlayer1
            // 
            this.btnAddPlayer1.Location = new System.Drawing.Point(233, 22);
            this.btnAddPlayer1.Name = "btnAddPlayer1";
            this.btnAddPlayer1.Size = new System.Drawing.Size(26, 26);
            this.btnAddPlayer1.TabIndex = 10;
            this.btnAddPlayer1.Text = "+";
            this.btnAddPlayer1.UseVisualStyleBackColor = true;
            this.btnAddPlayer1.Click += new System.EventHandler(this.btnAddPlayer1_Click);
            // 
            // btnAddPlayer2
            // 
            this.btnAddPlayer2.Location = new System.Drawing.Point(233, 52);
            this.btnAddPlayer2.Name = "btnAddPlayer2";
            this.btnAddPlayer2.Size = new System.Drawing.Size(26, 26);
            this.btnAddPlayer2.TabIndex = 11;
            this.btnAddPlayer2.Text = "+";
            this.btnAddPlayer2.UseVisualStyleBackColor = true;
            this.btnAddPlayer2.Click += new System.EventHandler(this.btnAddPlayer2_Click);
            // 
            // btnAddPlayer3
            // 
            this.btnAddPlayer3.Location = new System.Drawing.Point(233, 83);
            this.btnAddPlayer3.Name = "btnAddPlayer3";
            this.btnAddPlayer3.Size = new System.Drawing.Size(26, 26);
            this.btnAddPlayer3.TabIndex = 12;
            this.btnAddPlayer3.Text = "+";
            this.btnAddPlayer3.UseVisualStyleBackColor = true;
            this.btnAddPlayer3.Click += new System.EventHandler(this.btnAddPlayer3_Click);
            // 
            // btnAddPlayer4
            // 
            this.btnAddPlayer4.Location = new System.Drawing.Point(233, 110);
            this.btnAddPlayer4.Name = "btnAddPlayer4";
            this.btnAddPlayer4.Size = new System.Drawing.Size(26, 26);
            this.btnAddPlayer4.TabIndex = 13;
            this.btnAddPlayer4.Text = "+";
            this.btnAddPlayer4.UseVisualStyleBackColor = true;
            this.btnAddPlayer4.Click += new System.EventHandler(this.btnAddPlayer4_Click);
            // 
            // lblPlayers1
            // 
            this.lblPlayers1.AutoSize = true;
            this.lblPlayers1.Location = new System.Drawing.Point(288, 31);
            this.lblPlayers1.Name = "lblPlayers1";
            this.lblPlayers1.Size = new System.Drawing.Size(76, 15);
            this.lblPlayers1.TabIndex = 14;
            this.lblPlayers1.Text = "dasdfasdfsad";
            // 
            // lblPlayers2
            // 
            this.lblPlayers2.AutoSize = true;
            this.lblPlayers2.Location = new System.Drawing.Point(288, 62);
            this.lblPlayers2.Name = "lblPlayers2";
            this.lblPlayers2.Size = new System.Drawing.Size(76, 15);
            this.lblPlayers2.TabIndex = 15;
            this.lblPlayers2.Text = "dasdfasdfsad";
            // 
            // lblPlayers3
            // 
            this.lblPlayers3.AutoSize = true;
            this.lblPlayers3.Location = new System.Drawing.Point(288, 93);
            this.lblPlayers3.Name = "lblPlayers3";
            this.lblPlayers3.Size = new System.Drawing.Size(76, 15);
            this.lblPlayers3.TabIndex = 16;
            this.lblPlayers3.Text = "dasdfasdfsad";
            // 
            // lblPlayers4
            // 
            this.lblPlayers4.AutoSize = true;
            this.lblPlayers4.Location = new System.Drawing.Point(288, 120);
            this.lblPlayers4.Name = "lblPlayers4";
            this.lblPlayers4.Size = new System.Drawing.Size(76, 15);
            this.lblPlayers4.TabIndex = 17;
            this.lblPlayers4.Text = "dasdfasdfsad";
            // 
            // btnAddTeam2
            // 
            this.btnAddTeam2.Location = new System.Drawing.Point(12, 54);
            this.btnAddTeam2.Name = "btnAddTeam2";
            this.btnAddTeam2.Size = new System.Drawing.Size(84, 27);
            this.btnAddTeam2.TabIndex = 18;
            this.btnAddTeam2.Text = "Add Team";
            this.btnAddTeam2.UseVisualStyleBackColor = true;
            this.btnAddTeam2.Click += new System.EventHandler(this.btnAddTeam2_Click);
            // 
            // btnAddTeam3
            // 
            this.btnAddTeam3.Location = new System.Drawing.Point(12, 87);
            this.btnAddTeam3.Name = "btnAddTeam3";
            this.btnAddTeam3.Size = new System.Drawing.Size(84, 27);
            this.btnAddTeam3.TabIndex = 19;
            this.btnAddTeam3.Text = "Add Team";
            this.btnAddTeam3.UseVisualStyleBackColor = true;
            this.btnAddTeam3.Click += new System.EventHandler(this.btnAddTeam3_Click);
            // 
            // btnAddTeam4
            // 
            this.btnAddTeam4.Location = new System.Drawing.Point(12, 120);
            this.btnAddTeam4.Name = "btnAddTeam4";
            this.btnAddTeam4.Size = new System.Drawing.Size(84, 27);
            this.btnAddTeam4.TabIndex = 20;
            this.btnAddTeam4.Text = "Add Team";
            this.btnAddTeam4.UseVisualStyleBackColor = true;
            this.btnAddTeam4.Click += new System.EventHandler(this.btnAddTeam4_Click);
            // 
            // lblPlace1
            // 
            this.lblPlace1.AutoSize = true;
            this.lblPlace1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlace1.Location = new System.Drawing.Point(267, 21);
            this.lblPlace1.Name = "lblPlace1";
            this.lblPlace1.Size = new System.Drawing.Size(21, 27);
            this.lblPlace1.TabIndex = 21;
            this.lblPlace1.Text = "1";
            this.lblPlace1.Visible = false;
            // 
            // lblPlace2
            // 
            this.lblPlace2.AutoSize = true;
            this.lblPlace2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlace2.Location = new System.Drawing.Point(267, 52);
            this.lblPlace2.Name = "lblPlace2";
            this.lblPlace2.Size = new System.Drawing.Size(22, 27);
            this.lblPlace2.TabIndex = 22;
            this.lblPlace2.Text = "2";
            this.lblPlace2.Visible = false;
            // 
            // lblPlace3
            // 
            this.lblPlace3.AutoSize = true;
            this.lblPlace3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlace3.Location = new System.Drawing.Point(267, 84);
            this.lblPlace3.Name = "lblPlace3";
            this.lblPlace3.Size = new System.Drawing.Size(22, 27);
            this.lblPlace3.TabIndex = 23;
            this.lblPlace3.Text = "3";
            this.lblPlace3.Visible = false;
            // 
            // lblPlace4
            // 
            this.lblPlace4.AutoSize = true;
            this.lblPlace4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlace4.Location = new System.Drawing.Point(267, 115);
            this.lblPlace4.Name = "lblPlace4";
            this.lblPlace4.Size = new System.Drawing.Size(24, 27);
            this.lblPlace4.TabIndex = 24;
            this.lblPlace4.Text = "4";
            this.lblPlace4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 445);
            this.Controls.Add(this.lblPlace4);
            this.Controls.Add(this.lblPlace3);
            this.Controls.Add(this.lblPlace2);
            this.Controls.Add(this.lblPlace1);
            this.Controls.Add(this.btnAddTeam4);
            this.Controls.Add(this.btnAddTeam3);
            this.Controls.Add(this.btnAddTeam2);
            this.Controls.Add(this.lblPlayers4);
            this.Controls.Add(this.lblPlayers3);
            this.Controls.Add(this.lblPlayers2);
            this.Controls.Add(this.lblPlayers1);
            this.Controls.Add(this.btnAddPlayer4);
            this.Controls.Add(this.btnAddPlayer3);
            this.Controls.Add(this.btnAddPlayer2);
            this.Controls.Add(this.btnAddPlayer1);
            this.Controls.Add(this.btnClearDebug);
            this.Controls.Add(this.lstDebug);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnTeam4);
            this.Controls.Add(this.btnTeam3);
            this.Controls.Add(this.btnTeam2);
            this.Controls.Add(this.btnTeam1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddTeam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTeam1;
        private System.Windows.Forms.Button btnTeam2;
        private System.Windows.Forms.Button btnTeam3;
        private System.Windows.Forms.Button btnTeam4;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.ListBox lstDebug;
        private System.Windows.Forms.Button btnClearDebug;
        private System.Windows.Forms.Button btnAddPlayer1;
        private System.Windows.Forms.Button btnAddPlayer2;
        private System.Windows.Forms.Button btnAddPlayer3;
        private System.Windows.Forms.Button btnAddPlayer4;
        private System.Windows.Forms.Label lblPlayers1;
        private System.Windows.Forms.Label lblPlayers2;
        private System.Windows.Forms.Label lblPlayers3;
        private System.Windows.Forms.Label lblPlayers4;
        private System.Windows.Forms.Button btnAddTeam2;
        private System.Windows.Forms.Button btnAddTeam3;
        private System.Windows.Forms.Button btnAddTeam4;
        private System.Windows.Forms.Label lblPlace1;
        private System.Windows.Forms.Label lblPlace2;
        private System.Windows.Forms.Label lblPlace3;
        private System.Windows.Forms.Label lblPlace4;
    }
}

