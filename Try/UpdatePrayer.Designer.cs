namespace Try
{
    partial class UpdatePrayer
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rtb_prayerw = new System.Windows.Forms.RichTextBox();
            this.lbl_prayerw = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_prayerid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(504, 393);
            this.btn_update.Name = "btn_update";
            this.btn_update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_update.Size = new System.Drawing.Size(75, 43);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(99, 393);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 43);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rtb_prayerw
            // 
            this.rtb_prayerw.Location = new System.Drawing.Point(99, 61);
            this.rtb_prayerw.Name = "rtb_prayerw";
            this.rtb_prayerw.Size = new System.Drawing.Size(480, 311);
            this.rtb_prayerw.TabIndex = 7;
            this.rtb_prayerw.Text = "";
            // 
            // lbl_prayerw
            // 
            this.lbl_prayerw.AutoSize = true;
            this.lbl_prayerw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prayerw.Location = new System.Drawing.Point(24, 61);
            this.lbl_prayerw.Name = "lbl_prayerw";
            this.lbl_prayerw.Size = new System.Drawing.Size(69, 25);
            this.lbl_prayerw.TabIndex = 6;
            this.lbl_prayerw.Text = "Prayer";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(504, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "< Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_prayerid
            // 
            this.lbl_prayerid.AutoSize = true;
            this.lbl_prayerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prayerid.Location = new System.Drawing.Point(24, 9);
            this.lbl_prayerid.Name = "lbl_prayerid";
            this.lbl_prayerid.Size = new System.Drawing.Size(28, 25);
            this.lbl_prayerid.TabIndex = 20;
            this.lbl_prayerid.Text = "Id";
            this.lbl_prayerid.Visible = false;
            // 
            // UpdatePrayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.lbl_prayerid);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.rtb_prayerw);
            this.Controls.Add(this.lbl_prayerw);
            this.Name = "UpdatePrayer";
            this.Text = "updatePrayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RichTextBox rtb_prayerw;
        private System.Windows.Forms.Label lbl_prayerw;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_prayerid;
    }
}