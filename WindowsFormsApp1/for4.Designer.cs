
namespace WindowsFormsApp1
{
    partial class for4
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.labelS = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "рахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(63, 109);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(33, 17);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B = ";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(63, 41);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(33, 17);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A = ";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(163, 36);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(110, 22);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(150, 276);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(110, 22);
            this.textBoxS.TabIndex = 4;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(63, 281);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(33, 17);
            this.labelS.TabIndex = 5;
            this.labelS.Text = "S = ";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(182, 95);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(91, 22);
            this.textBoxB.TabIndex = 6;
            // 
            // for4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.button1);
            this.Name = "for4";
            this.Text = "For3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox textBoxB;
    }
}