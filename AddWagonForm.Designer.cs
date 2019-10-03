namespace Vilcienu_uzskaites_aplikacija
{
    partial class AddWagonForm
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
            this.tb_wagon_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_train = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_krava = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_svars = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_addWagon_train_number = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_wagon_number
            // 
            this.tb_wagon_number.Location = new System.Drawing.Point(125, 12);
            this.tb_wagon_number.Name = "tb_wagon_number";
            this.tb_wagon_number.Size = new System.Drawing.Size(100, 20);
            this.tb_wagon_number.TabIndex = 0;
            this.tb_wagon_number.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wagon number";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_add_train
            // 
            this.btn_add_train.Location = new System.Drawing.Point(150, 116);
            this.btn_add_train.Name = "btn_add_train";
            this.btn_add_train.Size = new System.Drawing.Size(75, 23);
            this.btn_add_train.TabIndex = 2;
            this.btn_add_train.Text = "Add";
            this.btn_add_train.UseVisualStyleBackColor = true;
            this.btn_add_train.Click += new System.EventHandler(this.Btn_add_wagon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Krava";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tb_krava
            // 
            this.tb_krava.Location = new System.Drawing.Point(125, 38);
            this.tb_krava.Name = "tb_krava";
            this.tb_krava.Size = new System.Drawing.Size(100, 20);
            this.tb_krava.TabIndex = 3;
            this.tb_krava.TextChanged += new System.EventHandler(this.Tb_krava_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "svars";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tb_svars
            // 
            this.tb_svars.Location = new System.Drawing.Point(125, 64);
            this.tb_svars.Name = "tb_svars";
            this.tb_svars.Size = new System.Drawing.Size(100, 20);
            this.tb_svars.TabIndex = 5;
            this.tb_svars.TextChanged += new System.EventHandler(this.Tb_svars_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Train number";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lb_addWagon_train_number
            // 
            this.lb_addWagon_train_number.FormattingEnabled = true;
            this.lb_addWagon_train_number.Location = new System.Drawing.Point(114, 89);
            this.lb_addWagon_train_number.Name = "lb_addWagon_train_number";
            this.lb_addWagon_train_number.Size = new System.Drawing.Size(121, 21);
            this.lb_addWagon_train_number.TabIndex = 9;
            this.lb_addWagon_train_number.SelectedIndexChanged += new System.EventHandler(this.Lb_addWagon_train_number_SelectedIndexChanged);
            // 
            // AddWagonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 160);
            this.Controls.Add(this.lb_addWagon_train_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_svars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_krava);
            this.Controls.Add(this.btn_add_train);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_wagon_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddWagonForm";
            this.Text = "Add wagon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_wagon_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_train;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_krava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_svars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lb_addWagon_train_number;
    }
}