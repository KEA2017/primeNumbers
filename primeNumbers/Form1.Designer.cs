namespace primeNumbers
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
            this.entry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FuckDetHer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entry
            // 
            this.entry.Location = new System.Drawing.Point(482, 56);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(100, 26);
            this.entry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hvor mange primetal vil du have?";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(482, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 404);
            this.listBox1.TabIndex = 2;
            // 
            // FuckDetHer
            // 
            this.FuckDetHer.Location = new System.Drawing.Point(203, 159);
            this.FuckDetHer.Name = "FuckDetHer";
            this.FuckDetHer.Size = new System.Drawing.Size(116, 38);
            this.FuckDetHer.TabIndex = 3;
            this.FuckDetHer.Text = "button1";
            this.FuckDetHer.UseVisualStyleBackColor = true;
            this.FuckDetHer.Click += new System.EventHandler(this.FuckDetHer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 561);
            this.Controls.Add(this.FuckDetHer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button FuckDetHer;
    }
}

