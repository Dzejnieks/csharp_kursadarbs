namespace Vilcienu_uzskaites_aplikacija
{
    partial class AddTrainForm
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
            this.tb_add_train_model = new System.Windows.Forms.TextBox();
            this.tb_add_train_track = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTP_Arrival = new System.Windows.Forms.DateTimePicker();
            this.dTP_departure = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add_train = new System.Windows.Forms.Button();
            this.tb_add_train_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_add_train_model
            // 
            this.tb_add_train_model.Location = new System.Drawing.Point(91, 49);
            this.tb_add_train_model.Name = "tb_add_train_model";
            this.tb_add_train_model.Size = new System.Drawing.Size(100, 20);
            this.tb_add_train_model.TabIndex = 1;
            // 
            // tb_add_train_track
            // 
            this.tb_add_train_track.Location = new System.Drawing.Point(91, 75);
            this.tb_add_train_track.Name = "tb_add_train_track";
            this.tb_add_train_track.Size = new System.Drawing.Size(100, 20);
            this.tb_add_train_track.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Train number";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Train model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Train tack";
            // 
            // dTP_Arrival
            // 
            this.dTP_Arrival.Location = new System.Drawing.Point(91, 101);
            this.dTP_Arrival.Name = "dTP_Arrival";
            this.dTP_Arrival.Size = new System.Drawing.Size(200, 20);
            this.dTP_Arrival.TabIndex = 7;
            // 
            // dTP_departure
            // 
            this.dTP_departure.Location = new System.Drawing.Point(91, 127);
            this.dTP_departure.Name = "dTP_departure";
            this.dTP_departure.Size = new System.Drawing.Size(200, 20);
            this.dTP_departure.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Arrival time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departure time";
            // 
            // btn_add_train
            // 
            this.btn_add_train.Location = new System.Drawing.Point(207, 153);
            this.btn_add_train.Name = "btn_add_train";
            this.btn_add_train.Size = new System.Drawing.Size(75, 23);
            this.btn_add_train.TabIndex = 11;
            this.btn_add_train.Text = "Add";
            this.btn_add_train.UseVisualStyleBackColor = true;
            this.btn_add_train.Click += new System.EventHandler(this.Btn_add_train_Click);
            // 
            // tb_add_train_number
            // 
            this.tb_add_train_number.Location = new System.Drawing.Point(91, 23);
            this.tb_add_train_number.Name = "tb_add_train_number";
            this.tb_add_train_number.Size = new System.Drawing.Size(100, 20);
            this.tb_add_train_number.TabIndex = 0;
            // 
            // AddTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 204);
            this.Controls.Add(this.btn_add_train);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTP_departure);
            this.Controls.Add(this.dTP_Arrival);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_add_train_track);
            this.Controls.Add(this.tb_add_train_model);
            this.Controls.Add(this.tb_add_train_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTrainForm";
            this.Text = " Add_train";
            this.Load += new System.EventHandler(this.AddOrEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_add_train_model;
        private System.Windows.Forms.TextBox tb_add_train_track;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTP_Arrival;
        private System.Windows.Forms.DateTimePicker dTP_departure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add_train;
        private System.Windows.Forms.TextBox tb_add_train_number;
    }
}