namespace SnakeForm
{
    partial class SnakeForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PlayerScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.FirstPlayerScoreLabel = new System.Windows.Forms.Label();
            this.SecondPlayerScoreLabel = new System.Windows.Forms.Label();
            this.ThirdPlayerScoreLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.PlayerScore});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Score :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // PlayerScore
            // 
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(13, 17);
            this.PlayerScore.Text = "0";
            // 
            // FirstPlayerScoreLabel
            // 
            this.FirstPlayerScoreLabel.AutoSize = true;
            this.FirstPlayerScoreLabel.Location = new System.Drawing.Point(288, 109);
            this.FirstPlayerScoreLabel.Name = "FirstPlayerScoreLabel";
            this.FirstPlayerScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.FirstPlayerScoreLabel.TabIndex = 1;
            // 
            // SecondPlayerScoreLabel
            // 
            this.SecondPlayerScoreLabel.AutoSize = true;
            this.SecondPlayerScoreLabel.Location = new System.Drawing.Point(288, 144);
            this.SecondPlayerScoreLabel.Name = "SecondPlayerScoreLabel";
            this.SecondPlayerScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.SecondPlayerScoreLabel.TabIndex = 2;
            // 
            // ThirdPlayerScoreLabel
            // 
            this.ThirdPlayerScoreLabel.AutoSize = true;
            this.ThirdPlayerScoreLabel.Location = new System.Drawing.Point(288, 197);
            this.ThirdPlayerScoreLabel.Name = "ThirdPlayerScoreLabel";
            this.ThirdPlayerScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.ThirdPlayerScoreLabel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "High Scores";
            this.label4.Visible = false;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(255, 9);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(99, 13);
            this.StartLabel.TabIndex = 5;
            this.StartLabel.Text = "Press Enter to start!";
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 569);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThirdPlayerScoreLabel);
            this.Controls.Add(this.SecondPlayerScoreLabel);
            this.Controls.Add(this.FirstPlayerScoreLabel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SnakeForm";
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SnakeForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel PlayerScore;
        private System.Windows.Forms.Label FirstPlayerScoreLabel;
        private System.Windows.Forms.Label SecondPlayerScoreLabel;
        private System.Windows.Forms.Label ThirdPlayerScoreLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StartLabel;
    }
}

