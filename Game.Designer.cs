namespace Typist.App
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.lblMinute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSecound = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(29, 33);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(24, 17);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lblSecound
            // 
            this.lblSecound.AutoSize = true;
            this.lblSecound.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecound.Location = new System.Drawing.Point(78, 33);
            this.lblSecound.Name = "lblSecound";
            this.lblSecound.Size = new System.Drawing.Size(24, 17);
            this.lblSecound.TabIndex = 1;
            this.lblSecound.Text = "00";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(192, 33);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(24, 17);
            this.lblScoreValue.TabIndex = 1;
            this.lblScoreValue.Text = "00";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(222, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 17);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "امتیاز :";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(29, 71);
            this.txtTest.Name = "txtTest";
            this.txtTest.ReadOnly = true;
            this.txtTest.Size = new System.Drawing.Size(236, 23);
            this.txtTest.TabIndex = 2;
            this.txtTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(29, 100);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(236, 23);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(29, 129);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "بعدی";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 173);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSecound);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMinute);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecound;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
    }
}