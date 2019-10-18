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
    public partial class auth_app : Form
    {
        //Database initialization
        DB_conn database = new DB_conn();
        public auth_app()
        {

                InitializeComponent();
                check_connection();

        }

        private void check_connection()
        {
            label_online.Text = "Conn...";
            label_online.Show();

            if (database.ping_db()) {
                btn_login.Enabled = true;
                label_online.Text = "Connection established";
                label_online.ForeColor = System.Drawing.Color.Green;
            }
            else{
                btn_login.Enabled = false;
                label_online.Text = "No connection to database";
                label_online.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (database.verify_user(tb_username.Text,tb_password.Text))
            {
                label_wrong_cred.Visible = false;
                vagon_app f = new vagon_app();
                Hide();
                f.ShowDialog();
                f = null;
                Show();
            }
            else
            {
                label_wrong_cred.Visible = true;
                label_wrong_cred.Text = "Wrong credentials, try again";
                label_wrong_cred.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
