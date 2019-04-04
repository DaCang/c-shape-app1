using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class main_from : Form
    {
        public main_from()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(on_closing);

        }
        private void on_closing(object sender, FormClosingEventArgs e)
        {
            string message = "确认关闭窗口?";
            string title = "确认";

            if (MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // Closes the parent form.
                //this.Close();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void test_mysql_db_btn_Click(object sender, EventArgs e)
        {
            MYSQL_DB.MysqlDataBase db = new MYSQL_DB.MysqlDataBase();
            if (db.tetst_db())
            {
                string message = "连接失败！";
                string title = "连接失败";
                DialogResult re = MessageBox.Show(message, title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (re == DialogResult.Retry)
                {
                    if (db.tetst_db())
                    {
                        MessageBox.Show("连接失败，请查看数据库连接配置");

                    }
                }
            }
            else {
                MessageBox.Show("连接成功！");
            }

        }
    }
}
