
namespace Paranormal_Footage_Credibility_System
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
            this.checkListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.longRating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_showRating = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quickRating = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_tips = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // checkListBox1
            // 
            this.checkListBox1.CheckOnClick = true;
            this.checkListBox1.FormattingEnabled = true;
            this.checkListBox1.Items.AddRange(new object[] {
            "No clear reason OR flimsy reason(s) for camera operator to be recording?",
            "Footage is shot in portrait mode?",
            "Trail Camera Footage?",
            "CCTV Footage?",
            "Footage takes place at night, or with limited visibility?",
            "Footage uses Infra Red or similar night camera technology?",
            "Footage ends abruptly without explanation?",
            "Footage is cropped, has deliberate edits or lacks context?",
            "Footage comes with elaborate backstory?",
            "\"There was no one else present at the time\"?",
            "Footage is from CCTV that has no clear reason to exist- e.g. CCTV in a residentia" +
                "l home looking at nothing in particular?",
            "Camera operator makes no attempt to approach subject where reasonably applicable?" +
                "",
            "Footage is unreasonably shakey and / or contains unnecessary zooms OR camera oper" +
                "ator looks away from the subject?",
            "Footage is from Middle East, Mexico or Brazil?",
            "Footage resolution is lower than 720p?",
            "Footage depicts known graphical errors / technical glitches?",
            "Frames Per Second of Footage is less than 10fps?",
            "Footage has large amount of digital compression?",
            "Subject of footage is indistinct and / or some distance away?",
            "Footage is CCTV footage recorded off a screen with a phone?",
            "Footage is from a Redditor?",
            "Footage is from a TikToker?",
            "Footage is from a Youtuber?",
            "Footage is from \"Paranormal Investigator\" Youtuber or similar?",
            "Footage only contains \"mysterious sounds\", no visual phenomenon?"});
            this.checkListBox1.Location = new System.Drawing.Point(46, 32);
            this.checkListBox1.Name = "checkListBox1";
            this.checkListBox1.Size = new System.Drawing.Size(682, 148);
            this.checkListBox1.TabIndex = 0;
            this.checkListBox1.SelectedIndexChanged += new System.EventHandler(this.checkListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select all check boxes applicable to footage being tested. Leave unchecked if uns" +
    "ure of that option:";
            // 
            // longRating
            // 
            this.longRating.Location = new System.Drawing.Point(46, 260);
            this.longRating.Multiline = true;
            this.longRating.Name = "longRating";
            this.longRating.ReadOnly = true;
            this.longRating.Size = new System.Drawing.Size(681, 70);
            this.longRating.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Credibility Rating Output:";
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(182, 195);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(130, 34);
            this.btn_clr.TabIndex = 4;
            this.btn_clr.Text = "Clear All";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_showRating
            // 
            this.btn_showRating.Location = new System.Drawing.Point(46, 195);
            this.btn_showRating.Name = "btn_showRating";
            this.btn_showRating.Size = new System.Drawing.Size(130, 34);
            this.btn_showRating.TabIndex = 5;
            this.btn_showRating.Text = "Calculate Rating!";
            this.btn_showRating.UseVisualStyleBackColor = true;
            this.btn_showRating.Click += new System.EventHandler(this.btn_showRating_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(318, 195);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(130, 34);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset System";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Overall Rating:";
            // 
            // quickRating
            // 
            this.quickRating.AutoSize = true;
            this.quickRating.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.quickRating.Location = new System.Drawing.Point(46, 360);
            this.quickRating.Name = "quickRating";
            this.quickRating.Size = new System.Drawing.Size(0, 32);
            this.quickRating.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score:";
            // 
            // scoreValue
            // 
            this.scoreValue.AutoSize = true;
            this.scoreValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreValue.Location = new System.Drawing.Point(568, 360);
            this.scoreValue.Name = "scoreValue";
            this.scoreValue.Size = new System.Drawing.Size(74, 45);
            this.scoreValue.TabIndex = 10;
            this.scoreValue.Text = "100";
            this.scoreValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(646, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "/ 100";
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(454, 195);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(130, 34);
            this.btn_about.TabIndex = 12;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(585, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "PFC Rating System and application created by DDD Wares, November 2021 - Contact o" +
    "n twitter: @depdrawers";
            // 
            // btn_tips
            // 
            this.btn_tips.Location = new System.Drawing.Point(590, 195);
            this.btn_tips.Name = "btn_tips";
            this.btn_tips.Size = new System.Drawing.Size(137, 34);
            this.btn_tips.TabIndex = 14;
            this.btn_tips.Text = "Tips!";
            this.btn_tips.UseVisualStyleBackColor = true;
            this.btn_tips.Click += new System.EventHandler(this.btn_tips_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 454);
            this.Controls.Add(this.btn_tips);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scoreValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quickRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_showRating);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.longRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkListBox1);
            this.Name = "Form1";
            this.Text = "Paranormal Footage Credibility Rating System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox longRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_showRating;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label quickRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scoreValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tips;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

