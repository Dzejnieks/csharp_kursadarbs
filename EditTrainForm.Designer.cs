namespace Vilcienu_uzskaites_aplikacija
{
    partial class EditTrainForm
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
            this.btn_edit_train = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTP_departure = new System.Windows.Forms.DateTimePicker();
            this.dTP_Arrival = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_train_track = new System.Windows.Forms.TextBox();
            this.tb_train_model = new System.Windows.Forms.TextBox();
            this.lb_train_number = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_edit_train
            // 
            this.btn_edit_train.Location = new System.Drawing.Point(205, 146);
            this.btn_edit_train.Name = "btn_edit_train";
            this.btn_edit_train.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_train.TabIndex = 22;
            this.btn_edit_train.Text = "Edit";
            this.btn_edit_train.UseVisualStyleBackColor = true;
            this.btn_edit_train.Click += new System.EventHandler(this.Btn_edit_train_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Departure time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Arrival time";
            // 
            // dTP_departure
            // 
            this.dTP_departure.Location = new System.Drawing.Point(89, 120);
            this.dTP_departure.Name = "dTP_departure";
            this.dTP_departure.Size = new System.Drawing.Size(191, 20);
            this.dTP_departure.TabIndex = 19;
            // 
            // dTP_Arrival
            // 
            this.dTP_Arrival.Location = new System.Drawing.Point(89, 94);
            this.dTP_Arrival.Name = "dTP_Arrival";
            this.dTP_Arrival.Size = new System.Drawing.Size(191, 20);
            this.dTP_Arrival.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Train tack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Train model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Train number";
            // 
            // tb_train_track
            // 
            this.tb_train_track.Location = new System.Drawing.Point(89, 68);
            this.tb_train_track.Name = "tb_train_track";
            this.tb_train_track.Size = new System.Drawing.Size(122, 20);
            this.tb_train_track.TabIndex = 14;
            // 
            // tb_train_model
            // 
            this.tb_train_model.Location = new System.Drawing.Point(89, 42);
            this.tb_train_model.Name = "tb_train_model";
            this.tb_train_model.Size = new System.Drawing.Size(122, 20);
            this.tb_train_model.TabIndex = 13;
            // 
            // lb_train_number
            // 
            this.lb_train_number.FormattingEnabled = true;
            this.lb_train_number.Location = new System.Drawing.Point(90, 19);
            this.lb_train_number.Name = "lb_train_number";
            this.lb_train_number.Size = new System.Drawing.Size(121, 21);
            this.lb_train_number.TabIndex = 23;
            // 
            // EditTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.lb_train_number);
            this.Controls.Add(this.btn_edit_train);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTP_departure);
            this.Controls.Add(this.dTP_Arrival);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_train_track);
            this.Controls.Add(this.tb_train_model);
            this.Name = "EditTrainForm";
            this.Text = "Edit train";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit_train;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTP_departure;
        private System.Windows.Forms.DateTimePicker dTP_Arrival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_train_track;
        private System.Windows.Forms.TextBox tb_train_model;
        private System.Windows.Forms.ComboBox lb_train_number;
    }
}