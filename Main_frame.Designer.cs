namespace Vilcienu_uzskaites_aplikacija
{
    partial class vagon_app
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
            this.btn_full_view = new System.Windows.Forms.Button();
            this.listboxSortBy = new System.Windows.Forms.ComboBox();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listboxFilter = new System.Windows.Forms.ComboBox();
            this.lb_sortBy = new System.Windows.Forms.Label();
            this.lb_sortByThe = new System.Windows.Forms.Label();
            this.btn_add_train = new System.Windows.Forms.Button();
            this.btn_add_wagon = new System.Windows.Forms.Button();
            this.btn_edit_wagon = new System.Windows.Forms.Button();
            this.btn_edit_train = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wagonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_full_view
            // 
            this.btn_full_view.Location = new System.Drawing.Point(84, 134);
            this.btn_full_view.Name = "btn_full_view";
            this.btn_full_view.Size = new System.Drawing.Size(75, 23);
            this.btn_full_view.TabIndex = 2;
            this.btn_full_view.Text = "Reset";
            this.btn_full_view.UseVisualStyleBackColor = true;
            this.btn_full_view.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listboxSortBy
            // 
            this.listboxSortBy.FormattingEnabled = true;
            this.listboxSortBy.Location = new System.Drawing.Point(12, 91);
            this.listboxSortBy.Name = "listboxSortBy";
            this.listboxSortBy.Size = new System.Drawing.Size(121, 21);
            this.listboxSortBy.TabIndex = 4;
            this.listboxSortBy.SelectedIndexChanged += new System.EventHandler(this.listboxSortBy_SelectedIndexChanged);
            // 
            // dgv_main
            // 
            this.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(0, 0);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.Size = new System.Drawing.Size(635, 420);
            this.dgv_main.TabIndex = 5;
            this.dgv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_main_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_main);
            this.panel1.Location = new System.Drawing.Point(165, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 420);
            this.panel1.TabIndex = 9;
            // 
            // listboxFilter
            // 
            this.listboxFilter.FormattingEnabled = true;
            this.listboxFilter.Location = new System.Drawing.Point(12, 47);
            this.listboxFilter.Name = "listboxFilter";
            this.listboxFilter.Size = new System.Drawing.Size(121, 21);
            this.listboxFilter.TabIndex = 10;
            this.listboxFilter.SelectedIndexChanged += new System.EventHandler(this.listboxFilter_SelectedIndexChanged);
            // 
            // lb_sortBy
            // 
            this.lb_sortBy.AutoSize = true;
            this.lb_sortBy.Location = new System.Drawing.Point(9, 31);
            this.lb_sortBy.Name = "lb_sortBy";
            this.lb_sortBy.Size = new System.Drawing.Size(74, 13);
            this.lb_sortBy.TabIndex = 11;
            this.lb_sortBy.Text = "Column name:";
            this.lb_sortBy.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lb_sortByThe
            // 
            this.lb_sortByThe.AutoSize = true;
            this.lb_sortByThe.Location = new System.Drawing.Point(9, 75);
            this.lb_sortByThe.Name = "lb_sortByThe";
            this.lb_sortByThe.Size = new System.Drawing.Size(74, 13);
            this.lb_sortByThe.TabIndex = 12;
            this.lb_sortByThe.Text = "Filter this entry";
            this.lb_sortByThe.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // btn_add_train
            // 
            this.btn_add_train.Location = new System.Drawing.Point(84, 163);
            this.btn_add_train.Name = "btn_add_train";
            this.btn_add_train.Size = new System.Drawing.Size(75, 23);
            this.btn_add_train.TabIndex = 13;
            this.btn_add_train.Text = "Add train";
            this.btn_add_train.UseVisualStyleBackColor = true;
            this.btn_add_train.Click += new System.EventHandler(this.Btn_add_train_Click);
            // 
            // btn_add_wagon
            // 
            this.btn_add_wagon.Location = new System.Drawing.Point(3, 163);
            this.btn_add_wagon.Name = "btn_add_wagon";
            this.btn_add_wagon.Size = new System.Drawing.Size(75, 23);
            this.btn_add_wagon.TabIndex = 14;
            this.btn_add_wagon.Text = "Add wagon";
            this.btn_add_wagon.UseVisualStyleBackColor = true;
            this.btn_add_wagon.Click += new System.EventHandler(this.Btn_add_wagon_Click);
            // 
            // btn_edit_wagon
            // 
            this.btn_edit_wagon.Location = new System.Drawing.Point(3, 192);
            this.btn_edit_wagon.Name = "btn_edit_wagon";
            this.btn_edit_wagon.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_wagon.TabIndex = 15;
            this.btn_edit_wagon.Text = "Edit wagon";
            this.btn_edit_wagon.UseVisualStyleBackColor = true;
            this.btn_edit_wagon.Click += new System.EventHandler(this.Btn_edit_wagon_Click);
            // 
            // btn_edit_train
            // 
            this.btn_edit_train.Location = new System.Drawing.Point(84, 192);
            this.btn_edit_train.Name = "btn_edit_train";
            this.btn_edit_train.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_train.TabIndex = 16;
            this.btn_edit_train.Text = "Edit train";
            this.btn_edit_train.UseVisualStyleBackColor = true;
            this.btn_edit_train.Click += new System.EventHandler(this.Btn_edit_train_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Reset datatable";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainToolStripMenuItem,
            this.addWagonToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addTrainToolStripMenuItem
            // 
            this.addTrainToolStripMenuItem.Name = "addTrainToolStripMenuItem";
            this.addTrainToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTrainToolStripMenuItem.Text = "Add train";
            this.addTrainToolStripMenuItem.Click += new System.EventHandler(this.AddTrainToolStripMenuItem_Click);
            // 
            // addWagonToolStripMenuItem
            // 
            this.addWagonToolStripMenuItem.Name = "addWagonToolStripMenuItem";
            this.addWagonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addWagonToolStripMenuItem.Text = "Add wagon";
            this.addWagonToolStripMenuItem.Click += new System.EventHandler(this.AddWagonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTrainToolStripMenuItem,
            this.wagonsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editTrainToolStripMenuItem
            // 
            this.editTrainToolStripMenuItem.Name = "editTrainToolStripMenuItem";
            this.editTrainToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTrainToolStripMenuItem.Text = "Edit train";
            this.editTrainToolStripMenuItem.Click += new System.EventHandler(this.EditTrainToolStripMenuItem_Click);
            // 
            // wagonsToolStripMenuItem
            // 
            this.wagonsToolStripMenuItem.Name = "wagonsToolStripMenuItem";
            this.wagonsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wagonsToolStripMenuItem.Text = "Edit wagon";
            this.wagonsToolStripMenuItem.Click += new System.EventHandler(this.WagonsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTrainToolStripMenuItem,
            this.deleteWagonToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteTrainToolStripMenuItem
            // 
            this.deleteTrainToolStripMenuItem.Name = "deleteTrainToolStripMenuItem";
            this.deleteTrainToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteTrainToolStripMenuItem.Text = "Delete train";
            this.deleteTrainToolStripMenuItem.Click += new System.EventHandler(this.DeleteTrainToolStripMenuItem_Click);
            // 
            // deleteWagonToolStripMenuItem
            // 
            this.deleteWagonToolStripMenuItem.Name = "deleteWagonToolStripMenuItem";
            this.deleteWagonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteWagonToolStripMenuItem.Text = "Delete wagon";
            this.deleteWagonToolStripMenuItem.Click += new System.EventHandler(this.DeleteWagonToolStripMenuItem_Click);
            // 
            // vagon_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_edit_train);
            this.Controls.Add(this.btn_edit_wagon);
            this.Controls.Add(this.btn_add_wagon);
            this.Controls.Add(this.btn_add_train);
            this.Controls.Add(this.btn_full_view);
            this.Controls.Add(this.lb_sortByThe);
            this.Controls.Add(this.lb_sortBy);
            this.Controls.Add(this.listboxFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listboxSortBy);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "vagon_app";
            this.Text = "Vilcienu uzskaites sistema";
            this.Load += new System.EventHandler(this.Vagon_app_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_full_view;
        private System.Windows.Forms.ComboBox listboxSortBy;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox listboxFilter;
        private System.Windows.Forms.Label lb_sortBy;
        private System.Windows.Forms.Label lb_sortByThe;
        private System.Windows.Forms.Button btn_add_train;
        private System.Windows.Forms.Button btn_add_wagon;
        private System.Windows.Forms.Button btn_edit_wagon;
        private System.Windows.Forms.Button btn_edit_train;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wagonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}