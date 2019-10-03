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
    public partial class DeleteForm : Form
    {
        string table;
        string column;
        public DeleteForm(string table_name, string column_name)
        {
            InitializeComponent();
            table = table_name;
            column = column_name;
            label_choose_toDelete.Text = "Choose to delete from '"+table+"'";
            Console.WriteLine("created delete form for " + table + " " + column);
            DB_conn database = new DB_conn();
            fill_comboBox_with_values(0, table, database,cb_deleteChoice);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DB_conn database = new DB_conn();
           if(database.delete_from_x_where_y_is_z(table, column, cb_deleteChoice.SelectedItem.ToString()))
            {
                this.Close();
            }
        }

        private void Lb_choose_toDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void fill_comboBox_with_values(int sort_by_column, string sort_by_table, DB_conn db, ComboBox comboBox)
        {
            db.open_connection();
            Console.WriteLine(comboBox.Text);
            comboBox.Items.Clear();
            string[] listArray = new string[db.get_table(sort_by_table).Rows.Count];

            foreach (DataRow row in db.get_table(sort_by_table).Rows)
            {
                string value = row[sort_by_column].ToString();
                if (!comboBox.Items.Contains(value))
                {
                    comboBox.Items.Add(value);
                }
            }
            db.close_connection();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void Cb_deleteChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cb_deleteChoice.SelectedItem.ToString() + "is selected to be deleted");
        }
    }
}
