namespace Try
{
    partial class DailyPrayer
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
            this.btn_prayer = new System.Windows.Forms.Button();
            this.btn_Verses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editprayer = new System.Windows.Forms.Button();
            this.btn_editverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_prayer
            // 
            this.btn_prayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prayer.Location = new System.Drawing.Point(318, 226);
            this.btn_prayer.Name = "btn_prayer";
            this.btn_prayer.Size = new System.Drawing.Size(149, 76);
            this.btn_prayer.TabIndex = 1;
            this.btn_prayer.Text = "Prayer";
            this.btn_prayer.UseVisualStyleBackColor = true;
            this.btn_prayer.Click += new System.EventHandler(this.btn_prayer_Click);
            // 
            // btn_Verses
            // 
            this.btn_Verses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verses.Location = new System.Drawing.Point(72, 226);
            this.btn_Verses.Name = "btn_Verses";
            this.btn_Verses.Size = new System.Drawing.Size(149, 76);
            this.btn_Verses.TabIndex = 2;
            this.btn_Verses.Text = "Verses";
            this.btn_Verses.UseVisualStyleBackColor = true;
            this.btn_Verses.Click += new System.EventHandler(this.btn_Verses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Daily Prayer";
            // 
            // btn_editprayer
            // 
            this.btn_editprayer.Location = new System.Drawing.Point(355, 325);
            this.btn_editprayer.Name = "btn_editprayer";
            this.btn_editprayer.Size = new System.Drawing.Size(75, 23);
            this.btn_editprayer.TabIndex = 4;
            this.btn_editprayer.Text = "edit prayer";
            this.btn_editprayer.UseVisualStyleBackColor = true;
            this.btn_editprayer.Click += new System.EventHandler(this.btn_editprayer_Click);
            // 
            // btn_editverse
            // 
            this.btn_editverse.Location = new System.Drawing.Point(108, 325);
            this.btn_editverse.Name = "btn_editverse";
            this.btn_editverse.Size = new System.Drawing.Size(75, 23);
            this.btn_editverse.TabIndex = 5;
            this.btn_editverse.Text = "edit verse";
            this.btn_editverse.UseVisualStyleBackColor = true;
            this.btn_editverse.Click += new System.EventHandler(this.btn_editverse_Click);
            // 
            // DailyPrayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.btn_editverse);
            this.Controls.Add(this.btn_editprayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Verses);
            this.Controls.Add(this.btn_prayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DailyPrayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Prayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prayer;
        private System.Windows.Forms.Button btn_Verses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editprayer;
        private System.Windows.Forms.Button btn_editverse;
    }
}