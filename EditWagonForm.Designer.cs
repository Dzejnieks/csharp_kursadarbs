namespace Vilcienu_uzskaites_aplikacija
{
    partial class EditWagonForm
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
            this.lb_wagon_number = new System.Windows.Forms.ComboBox();
            this.lb_addWagon_train_number = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_svars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_krava = new System.Windows.Forms.TextBox();
            this.btn_edit_train = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_wagon_number
            // 
            this.lb_wagon_number.FormattingEnabled = true;
            this.lb_wagon_number.Location = new System.Drawing.Point(98, 39);
            this.lb_wagon_number.Name = "lb_wagon_number";
            this.lb_wagon_number.Size = new System.Drawing.Size(121, 21);
            this.lb_wagon_number.TabIndex = 0;
            // 
            // lb_addWagon_train_number
            // 
            this.lb_addWagon_train_number.FormattingEnabled = true;
            this.lb_addWagon_train_number.Location = new System.Drawing.Point(98, 117);
            this.lb_addWagon_train_number.Name = "lb_addWagon_train_number";
            this.lb_addWagon_train_number.Size = new System.Drawing.Size(121, 21);
            this.lb_addWagon_train_number.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Train number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "svars";
            // 
            // tb_svars
            // 
            this.tb_svars.Location = new System.Drawing.Point(98, 92);
            this.tb_svars.Name = "tb_svars";
            this.tb_svars.Size = new System.Drawing.Size(121, 20);
            this.tb_svars.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Krava";
            // 
            // tb_krava
            // 
            this.tb_krava.Location = new System.Drawing.Point(98, 66);
            this.tb_krava.Name = "tb_krava";
            this.tb_krava.Size = new System.Drawing.Size(121, 20);
            this.tb_krava.TabIndex = 13;
            // 
            // btn_edit_train
            // 
            this.btn_edit_train.Location = new System.Drawing.Point(123, 144);
            this.btn_edit_train.Name = "btn_edit_train";
            this.btn_edit_train.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_train.TabIndex = 12;
            this.btn_edit_train.Text = "Edit";
            this.btn_edit_train.UseVisualStyleBackColor = true;
            this.btn_edit_train.Click += new System.EventHandler(this.Btn_edit_wagon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wagon number";
            // 
            // EditWagonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 206);
            this.Controls.Add(this.lb_addWagon_train_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_svars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_krava);
            this.Controls.Add(this.btn_edit_train);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_wagon_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditWagonForm";
            this.Text = "Edit train";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lb_wagon_number;
        private System.Windows.Forms.ComboBox lb_addWagon_train_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_svars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_krava;
        private System.Windows.Forms.Button btn_edit_train;
        private System.Windows.Forms.Label label1;
    }
}