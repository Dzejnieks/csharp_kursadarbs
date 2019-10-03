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
    public partial class EditTrainForm : Form
    {
        public EditTrainForm()
        {
            InitializeComponent();
            DB_conn database = new DB_conn();
            fill_lb_train_number_with(0, "trains", database);
        }

        private void Btn_edit_train_Click(object sender, EventArgs e)
        {
            try
            {
                DB_conn database = new DB_conn();
                if (database.edit_train(lb_train_number.SelectedItem.ToString(), tb_train_model.Text, tb_train_track.Text, dTP_Arrival.Text, dTP_departure.Text))
                {
                    this.Close();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void fill_lb_train_number_with(int sort_by_column, string sort_by_table, DB_conn db)
        {
            db.open_connection();
            lb_train_number.Items.Clear();
            string[] listArray = new string[db.get_table(sort_by_table).Rows.Count];

            foreach (DataRow row in db.get_table(sort_by_table).Rows)
            {
                string value = row[sort_by_column].ToString();
                if (!lb_train_number.Items.Contains(value))
                {
                    lb_train_number.Items.Add(value);
                }
            }
            db.close_connection();
        }
    }
}
