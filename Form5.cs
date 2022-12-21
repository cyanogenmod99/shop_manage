using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class telenum_form : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"data source = C:\Users\khm97\Desktop\test\data\test.db"); //db연결

        public telenum_form()
        {
            InitializeComponent();
        }

        private void tele_num_entered(object sender, KeyEventArgs e)
        {
            //엔터키 이벤트 발생

            if (e.KeyCode == Keys.Enter)
            {
                Form2.tele_num = "010"+telenum_box.Text;

                if(Convert.ToInt32(telenum_box.Text) == 0) //수정해야함 -> 전체목록 나오도록(관리자모드)
                {
                    string query = "SELECT* FROM member";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);

                    DataTable dt = new DataTable();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(Form2.dt_picked);

                }
                else
                {
                    //전화번호
                    string column = "전화번호";

                    //DB참조
                    string query = "SELECT* from member";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);

                    //데이터테이블 연동
                    DataTable dt = new DataTable();

                    //어댑터생성 및 데이터테이블에 채우기 
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dt);

                    Form2.dt_picked = dt.Select("[" + column + "] = '" + Form2.tele_num + "'").CopyToDataTable();
                    //Form2.member_view.DataSource = Form2.dt_picked;

                    //Form2.member_view = 
                }


                this.Close();

                Form2 newform2 = new Form2();
                newform2.ShowDialog();

                
            }

        }
    }
}
