using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vilcienu_uzskaites_aplikacija
{
    public partial class AddTrainForm : Form
    {
        public AddTrainForm()
        {
            DB_conn database = new DB_conn();
            InitializeComponent();
            if (database.ping_db())
            {
                btn_add_train.Enabled = true;
            }
            else
            {
                btn_add_train.Enabled = false;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_add_train_Click(object sender, EventArgs e)
        {
            DB_conn database = new DB_conn();
            if(database.insert_train(tb_add_train_number.Text, tb_add_train_model.Text, tb_add_train_track.Text, dTP_Arrival.Text, dTP_departure.Text))
            {
                this.Close();
            }
        }

        private void AddOrEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
