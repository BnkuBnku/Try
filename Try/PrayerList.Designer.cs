namespace Try
{
    partial class PrayerList_form
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prayergrid = new System.Windows.Forms.DataGridView();
            this.PrayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrayerWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_updateprayer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prayergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 220);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(480, 220);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Prayer";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prayergrid);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 201);
            this.panel1.TabIndex = 4;
            // 
            // prayergrid
            // 
            this.prayergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prayergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrayerID,
            this.PrayerWords});
            this.prayergrid.Location = new System.Drawing.Point(4, 4);
            this.prayergrid.Name = "prayergrid";
            this.prayergrid.Size = new System.Drawing.Size(536, 194);
            this.prayergrid.TabIndex = 0;
            // 
            // PrayerID
            // 
            this.PrayerID.HeaderText = "ID";
            this.PrayerID.Name = "PrayerID";
            // 
            // PrayerWords
            // 
            this.PrayerWords.HeaderText = "Prayer";
            this.PrayerWords.Name = "PrayerWords";
            this.PrayerWords.Width = 62;
            // 
            // btn_updateprayer
            // 
            this.btn_updateprayer.Location = new System.Drawing.Point(384, 220);
            this.btn_updateprayer.Name = "btn_updateprayer";
            this.btn_updateprayer.Size = new System.Drawing.Size(90, 23);
            this.btn_updateprayer.TabIndex = 5;
            this.btn_updateprayer.Text = "Update Prayer";
            this.btn_updateprayer.UseVisualStyleBackColor = true;
            this.btn_updateprayer.Click += new System.EventHandler(this.btn_updateprayer_Click);
            // 
            // PrayerList_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 255);
            this.Controls.Add(this.btn_updateprayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Name = "PrayerList_form";
            this.Text = "Prayer";
            this.Load += new System.EventHandler(this.PrayerList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prayergrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView prayergrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrayerWords;
        private System.Windows.Forms.Button btn_updateprayer;
    }
}

