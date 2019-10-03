namespace Vilcienu_uzskaites_aplikacija
{
    partial class DeleteForm
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.label_choose_toDelete = new System.Windows.Forms.Label();
            this.cb_deleteChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(85, 64);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // label_choose_toDelete
            // 
            this.label_choose_toDelete.AutoSize = true;
            this.label_choose_toDelete.Location = new System.Drawing.Point(36, 9);
            this.label_choose_toDelete.Name = "label_choose_toDelete";
            this.label_choose_toDelete.Size = new System.Drawing.Size(43, 13);
            this.label_choose_toDelete.TabIndex = 2;
            this.label_choose_toDelete.Text = "Choose";
            // 
            // cb_deleteChoice
            // 
            this.cb_deleteChoice.FormattingEnabled = true;
            this.cb_deleteChoice.Location = new System.Drawing.Point(39, 37);
            this.cb_deleteChoice.Name = "cb_deleteChoice";
            this.cb_deleteChoice.Size = new System.Drawing.Size(121, 21);
            this.cb_deleteChoice.TabIndex = 24;
            this.cb_deleteChoice.Text = "Choose value..";
            this.cb_deleteChoice.SelectedIndexChanged += new System.EventHandler(this.Cb_deleteChoice_SelectedIndexChanged);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 114);
            this.Controls.Add(this.cb_deleteChoice);
            this.Controls.Add(this.label_choose_toDelete);
            this.Controls.Add(this.btn_delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteForm";
            this.Text = "Delete form";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label_choose_toDelete;
        private System.Windows.Forms.ComboBox cb_deleteChoice;
    }
}