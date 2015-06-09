namespace MemoTricks
{
    partial class SubmitLoci
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
            this.submitLabel1 = new System.Windows.Forms.Label();
            this.submitLabel2 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.retryButton = new System.Windows.Forms.Button();
            this.submitLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitLabel1
            // 
            this.submitLabel1.Location = new System.Drawing.Point(22, 24);
            this.submitLabel1.Name = "submitLabel1";
            this.submitLabel1.Size = new System.Drawing.Size(294, 37);
            this.submitLabel1.TabIndex = 0;
            this.submitLabel1.Text = "info1";
            // 
            // submitLabel2
            // 
            this.submitLabel2.Location = new System.Drawing.Point(22, 61);
            this.submitLabel2.Name = "submitLabel2";
            this.submitLabel2.Size = new System.Drawing.Size(166, 193);
            this.submitLabel2.TabIndex = 1;
            this.submitLabel2.Text = "info2";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(212, 283);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "Meniu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // retryButton
            // 
            this.retryButton.Location = new System.Drawing.Point(90, 283);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(75, 23);
            this.retryButton.TabIndex = 3;
            this.retryButton.Text = "Reincearca";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // submitLabel3
            // 
            this.submitLabel3.Location = new System.Drawing.Point(207, 61);
            this.submitLabel3.Name = "submitLabel3";
            this.submitLabel3.Size = new System.Drawing.Size(194, 193);
            this.submitLabel3.TabIndex = 4;
            this.submitLabel3.Text = "info3";
            // 
            // SubmitLoci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 365);
            this.Controls.Add(this.submitLabel3);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.submitLabel2);
            this.Controls.Add(this.submitLabel1);
            this.Name = "SubmitLoci";
            this.Text = "SubmitLoci";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label submitLabel1;
        private System.Windows.Forms.Label submitLabel2;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Label submitLabel3;
    }
}