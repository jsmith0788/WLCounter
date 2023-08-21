
namespace LocalStreamTools
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
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblFileSource = new System.Windows.Forms.Label();
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLoss = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnClearRank = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(12, 60);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(100, 20);
            this.txtPrefix.TabIndex = 3;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PrefixText";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(12, 21);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(270, 20);
            this.txtSource.TabIndex = 1;
            // 
            // lblFileSource
            // 
            this.lblFileSource.AutoSize = true;
            this.lblFileSource.Location = new System.Drawing.Point(9, 5);
            this.lblFileSource.Name = "lblFileSource";
            this.lblFileSource.Size = new System.Drawing.Size(60, 13);
            this.lblFileSource.TabIndex = 0;
            this.lblFileSource.Text = "File Source";
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(111, 60);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(60, 20);
            this.btnWin.TabIndex = 4;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLoss
            // 
            this.btnLoss.Location = new System.Drawing.Point(170, 60);
            this.btnLoss.Name = "btnLoss";
            this.btnLoss.Size = new System.Drawing.Size(60, 20);
            this.btnLoss.TabIndex = 5;
            this.btnLoss.Text = "Loss";
            this.btnLoss.UseVisualStyleBackColor = true;
            this.btnLoss.Click += new System.EventHandler(this.btnLoss_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(288, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 20);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(288, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(60, 20);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(229, 60);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(60, 20);
            this.btnDraw.TabIndex = 9;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Top 500",
            "Grandmaster",
            "Master",
            "Diamond",
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.comboBox1.Location = new System.Drawing.Point(12, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(9, 83);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 13);
            this.lblRank.TabIndex = 11;
            this.lblRank.Text = "Rank";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(175, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnClearRank
            // 
            this.btnClearRank.Location = new System.Drawing.Point(288, 99);
            this.btnClearRank.Name = "btnClearRank";
            this.btnClearRank.Size = new System.Drawing.Size(60, 20);
            this.btnClearRank.TabIndex = 13;
            this.btnClearRank.Text = "Clear";
            this.btnClearRank.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(111, 44);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 135);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnClearRank);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoss);
            this.Controls.Add(this.btnWin);
            this.Controls.Add(this.lblFileSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblRank);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Win/Loss Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblFileSource;
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLoss;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnClearRank;
        private System.Windows.Forms.Label lblDisplay;
    }
}

