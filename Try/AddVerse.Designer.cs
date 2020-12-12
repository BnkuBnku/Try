namespace Try
{
    partial class addverse_form
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
            this.lbl_verseid = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rtb_versesw = new System.Windows.Forms.RichTextBox();
            this.lbl_versew = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_verseid
            // 
            this.lbl_verseid.AutoSize = true;
            this.lbl_verseid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verseid.Location = new System.Drawing.Point(23, 12);
            this.lbl_verseid.Name = "lbl_verseid";
            this.lbl_verseid.Size = new System.Drawing.Size(31, 25);
            this.lbl_verseid.TabIndex = 10;
            this.lbl_verseid.Text = "ID";
            this.lbl_verseid.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(503, 392);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_add.Size = new System.Drawing.Size(75, 43);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(98, 392);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 43);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rtb_versesw
            // 
            this.rtb_versesw.Location = new System.Drawing.Point(98, 48);
            this.rtb_versesw.Name = "rtb_versesw";
            this.rtb_versesw.Size = new System.Drawing.Size(480, 323);
            this.rtb_versesw.TabIndex = 7;
            this.rtb_versesw.Text = "";
            // 
            // lbl_versew
            // 
            this.lbl_versew.AutoSize = true;
            this.lbl_versew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versew.Location = new System.Drawing.Point(23, 48);
            this.lbl_versew.Name = "lbl_versew";
            this.lbl_versew.Size = new System.Drawing.Size(64, 25);
            this.lbl_versew.TabIndex = 6;
            this.lbl_versew.Text = "Verse";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(503, 11);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "< Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // addverse_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_verseid);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.rtb_versesw);
            this.Controls.Add(this.lbl_versew);
            this.Name = "addverse_form";
            this.Text = "Add Verse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_verseid;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RichTextBox rtb_versesw;
        private System.Windows.Forms.Label lbl_versew;
        private System.Windows.Forms.Button btn_cancel;
    }
}