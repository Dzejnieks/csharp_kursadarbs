using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vilcienu_uzskaites_aplikacija
{
    public partial class vagon_app : Form
    {
        public vagon_app()
        {
            DB_conn database = new DB_conn();
            InitializeComponent();
            listboxFilter.Text = "Select Column..";
            listboxSortBy.Text = "Select value..";
            listboxSortBy.Enabled = false;
            dgv_main.DataSource = database.get_table("full_view");
            fill_listboxFilter_with_column_values_from_table("full_view",database);
        }

        private void Vagon_app_Load(object sender, EventArgs e)
        {

        }

        
        private void fill_listboxFilter_with_values(object sender, EventArgs e)
        {
               
        }
        //datatable atlasa vertibas. jaizpildas on select sortby box
        private void fill_datatable_with_SortBy_value(DB_conn db, string sortBy_value)
        {
            dgv_main.DataSource = db.get_table_from_x_where_y_is_z("full_view", listboxFilter.SelectedItem.ToString(), listboxSortBy.SelectedItem.ToString());
        }

        //listboxSortBy tiek pievienotas jaunas vertibas. Japadod table un kollona. jaizpildas listboxFilter on click
        private void fill_Sort_By_with(int sort_by_column, string sort_by_table,DB_conn db)
        {
            db.open_connection();
            listboxSortBy.Items.Clear();
          //  string[] listArray = new string[db.get_table(sort_by_table).Rows.Count];

            foreach (DataRow row in db.get_table(sort_by_table).Rows)
            {
                string value = row[sort_by_column].ToString();
                if (!listboxSortBy.Items.Contains(value))
                {
                    listboxSortBy.Items.Add(value);
                }
            }
            db.close_connection();
        }

        //pievieno katru kollonas vertibu šajā listā. jaizpildas kad izvelas table
        public void fill_listboxFilter_with_column_values_from_table(string table, DB_conn db) {
            foreach (DataColumn column in db.get_table(table).Columns)
            {
                listboxFilter.Items.Add(column.ToString());
            }
        }

        //events
        private void listboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB_conn database = new DB_conn();
            fill_Sort_By_with(listboxFilter.SelectedIndex, "full_view", database);
            listboxSortBy.Enabled = true;
        }
        private void listboxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB_conn database = new DB_conn();
            fill_datatable_with_SortBy_value(database, listboxSortBy.SelectedIndex.ToString());
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        //reset button
        private void Button1_Click(object sender, EventArgs e)
        {
            DB_conn database = new DB_conn();
            dgv_main.DataSource = database.get_table("full_view");
            listboxFilter.Text = "Select Column..";
            listboxSortBy.Text = "Select value..";
            listboxSortBy.Enabled = false;
        }
        public void insert2() { }

        private void Dgv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_add_train_Click(object sender, EventArgs e)
        {
            AddTrainForm f = new AddTrainForm();
            f.ShowDialog();
            f = null;
        }

        private void Btn_add_wagon_Click(object sender, EventArgs e)
        {
            AddWagonForm f = new AddWagonForm();
            f.ShowDialog();
            f = null;
        }

        private void Btn_edit_wagon_Click(object sender, EventArgs e)
        {
            EditWagonForm f = new EditWagonForm();
            f.ShowDialog();
            f = null;
        }

        private void Btn_edit_train_Click(object sender, EventArgs e)
        {
            EditTrainForm f = new EditTrainForm();
            f.ShowDialog();
            f = null;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_conn database = new DB_conn();
            dgv_main.DataSource = database.get_table("full_view");
            listboxFilter.Text = "Select Column..";
            listboxSortBy.Text = "Select value..";
            listboxSortBy.Enabled = false;
        }

        private void AddTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWagonForm f = new AddWagonForm();
            f.ShowDialog();
            f = null;
        }

        private void AddWagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWagonForm f = new AddWagonForm();
            f.ShowDialog();
            f = null;
        }

        private void EditTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTrainForm f = new EditTrainForm();
            f.ShowDialog();
            f = null;
        }

        private void WagonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditWagonForm f = new EditWagonForm();
            f.ShowDialog();
            f = null;
        }

        private void DeleteTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm f = new DeleteForm("trains","train_number");
            f.ShowDialog();
            f = null;
        }

        private void DeleteWagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm f = new DeleteForm("wagons", "wagon_number");
            f.ShowDialog();
            f = null;
        }
    }
}
