namespace Try
{
    partial class VerseList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.versegrid = new System.Windows.Forms.DataGridView();
            this.VerseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verses_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_addverse = new System.Windows.Forms.Button();
            this.btn_updateverse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.versegrid);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 382);
            this.panel1.TabIndex = 0;
            // 
            // versegrid
            // 
            this.versegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VerseID,
            this.Verses_col});
            this.versegrid.Location = new System.Drawing.Point(85, 47);
            this.versegrid.Name = "versegrid";
            this.versegrid.Size = new System.Drawing.Size(608, 291);
            this.versegrid.TabIndex = 0;
            // 
            // VerseID
            // 
            this.VerseID.HeaderText = "VerseID";
            this.VerseID.Name = "VerseID";
            // 
            // Verses_col
            // 
            this.Verses_col.HeaderText = "Verses";
            this.Verses_col.Name = "Verses_col";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(13, 415);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_addverse
            // 
            this.btn_addverse.Location = new System.Drawing.Point(712, 415);
            this.btn_addverse.Name = "btn_addverse";
            this.btn_addverse.Size = new System.Drawing.Size(75, 23);
            this.btn_addverse.TabIndex = 2;
            this.btn_addverse.Text = "Add Verse";
            this.btn_addverse.UseVisualStyleBackColor = true;
            this.btn_addverse.Click += new System.EventHandler(this.btn_addverse_Click);
            // 
            // btn_updateverse
            // 
            this.btn_updateverse.Location = new System.Drawing.Point(620, 415);
            this.btn_updateverse.Name = "btn_updateverse";
            this.btn_updateverse.Size = new System.Drawing.Size(86, 23);
            this.btn_updateverse.TabIndex = 3;
            this.btn_updateverse.Text = "Update Verse";
            this.btn_updateverse.UseVisualStyleBackColor = true;
            this.btn_updateverse.Click += new System.EventHandler(this.btn_updateverse_Click);
            // 
            // VerseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_updateverse);
            this.Controls.Add(this.btn_addverse);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Name = "VerseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verse List";
            this.Load += new System.EventHandler(this.VerseList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.versegrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView versegrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verses_col;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_addverse;
        private System.Windows.Forms.Button btn_updateverse;
    }
}