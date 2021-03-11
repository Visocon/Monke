
namespace Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Location = new System.Drawing.Point(670, 449);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(112, 40);
            this.Next.TabIndex = 0;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(211, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 153);
            this.label1.TabIndex = 2;
            this.label1.Text = "FUCK YOU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // monke
            // 
            this.monke.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monke.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.monke.FlatAppearance.BorderSize = 0;
            this.monke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monke.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monke.Location = new System.Drawing.Point(396, 449);
            this.monke.Name = "monke";
            this.monke.Size = new System.Drawing.Size(112, 40);
            this.monke.TabIndex = 3;
            this.monke.Text = "Monke";
            this.monke.UseVisualStyleBackColor = false;
            this.monke.Click += new System.EventHandler(this.monke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monke);
            this.Controls.Add(this.Next);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Loser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button monke;
    }
}

