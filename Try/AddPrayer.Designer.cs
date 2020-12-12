namespace Try
{
    partial class AddPrayer
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
            this.lbl_prayerw = new System.Windows.Forms.Label();
            this.rtb_prayerw = new System.Windows.Forms.RichTextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_prayerid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_prayerw
            // 
            this.lbl_prayerw.AutoSize = true;
            this.lbl_prayerw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prayerw.Location = new System.Drawing.Point(33, 56);
            this.lbl_prayerw.Name = "lbl_prayerw";
            this.lbl_prayerw.Size = new System.Drawing.Size(69, 25);
            this.lbl_prayerw.TabIndex = 0;
            this.lbl_prayerw.Text = "Prayer";
            // 
            // rtb_prayerw
            // 
            this.rtb_prayerw.Location = new System.Drawing.Point(108, 56);
            this.rtb_prayerw.Name = "rtb_prayerw";
            this.rtb_prayerw.Size = new System.Drawing.Size(480, 318);
            this.rtb_prayerw.TabIndex = 1;
            this.rtb_prayerw.Text = "";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(108, 395);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 43);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(513, 395);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add.Size = new System.Drawing.Size(75, 43);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(513, 9);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "< Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_prayerid
            // 
            this.lbl_prayerid.AutoSize = true;
            this.lbl_prayerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prayerid.Location = new System.Drawing.Point(33, 15);
            this.lbl_prayerid.Name = "lbl_prayerid";
            this.lbl_prayerid.Size = new System.Drawing.Size(31, 25);
            this.lbl_prayerid.TabIndex = 4;
            this.lbl_prayerid.Text = "ID";
            this.lbl_prayerid.Visible = false;
            // 
            // AddPrayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_prayerid);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.rtb_prayerw);
            this.Controls.Add(this.lbl_prayerw);
            this.Name = "AddPrayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Prayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prayerw;
        private System.Windows.Forms.RichTextBox rtb_prayerw;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_prayerid;
    }
}