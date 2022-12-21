using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_member(object sender, EventArgs e)
        {
            int temp = 0;
            bool paresd = Int32.TryParse(new_point.Text, out temp);
            if (paresd && new_number.Text.Length == 8) // 
            {

                // DB연결
                SQLiteConnection con = new SQLiteConnection(@"data source = C:\Users\khm97\Desktop\test\data\test.db");
                con.Open();
                string query = "INSERT INTO member(이름, 전화번호, 포인트) VALUES('" + new_name.Text + "', '" + "010" + new_number.Text + "', " + Convert.ToInt32(new_point.Text) + ")"; //
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                //cmd.Parameters.Add("name", DbType.String).Value = new_name.Text;
                //cmd.Parameters.Add("tele_num", DbType.String).Value = new_number.Text;
                //cmd.Parameters.Add("first_point", DbType.Int32).Value = Convert.ToInt32(new_point.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();

                string new_member_message = string.Empty;

                new_member_message = string.Format("정상 등록되었습니다");
                MessageBox.Show(new_member_message);

            }

            else
            {
                MessageBox.Show("올바른 길이의 숫자를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

    }
}
