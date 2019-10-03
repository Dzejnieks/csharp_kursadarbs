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
    public partial class AddWagonForm : Form
    {
        public AddWagonForm()
        {
            InitializeComponent();
            DB_conn database = new DB_conn();
            fill_lb_addWagon_train_number_with(0, "trains", database);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_wagon_Click(object sender, EventArgs e)
        {
            DB_conn database = new DB_conn();
            if (database.insert_wagon(tb_wagon_number.Text, tb_krava.Text, tb_svars.Text, lb_addWagon_train_number.SelectedItem.ToString()))
            {
                this.Close();
            }
        }
        //fill addWagonForm lb_train_number with train_numbers from 'trains' table. Jaizpildas, kad atver atveras addWagonForm
        private void fill_lb_addWagon_train_number_with(int sort_by_column, string sort_by_table, DB_conn db)
        {
            db.open_connection();
            lb_addWagon_train_number.Items.Clear();
            string[] listArray = new string[db.get_table(sort_by_table).Rows.Count];

            foreach (DataRow row in db.get_table(sort_by_table).Rows)
            {
                string value = row[sort_by_column].ToString();
                if (!lb_addWagon_train_number.Items.Contains(value))
                {
                    lb_addWagon_train_number.Items.Add(value);
                }
            }
            db.close_connection();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Tb_svars_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Tb_krava_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb_addWagon_train_number_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
