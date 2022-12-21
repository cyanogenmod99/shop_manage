using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;

namespace test
{
    public partial class Form2 : Form
    {
        static SQLiteConnection con = new SQLiteConnection(@"data source = C:\Users\khm97\Desktop\test\data\test.db"); //db연결


        string today = DateTime.Now.ToString("yyyy-MM-dd");

        public static string tele_num = "";
        public static DataTable dt_picked = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }
        

        private void stack_cut(object sender, EventArgs e)
        {
            int temp = 0;
            int new_point = 0;
            bool paresd = Int32.TryParse(earings_textbox.Text, out temp);
            if (paresd)
            {
                new_point = (int)(Int32.Parse(earings_textbox.Text) * 0.05);
            }

            else
            {
                MessageBox.Show("숫자를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            int now_point = Convert.ToInt32(dt_picked.Rows[0][2]);
            //int new_point = (int)(Int32.Parse(earings_textbox.Text) * 0.05);

            //label3.Text = Convert.ToString(dt_picked.Rows[0][2]);

            int total_point = Convert.ToInt32(now_point + new_point);

            con.Open();
            string query = "UPDATE member set 포인트=:total_point, 최근커트=:today WHERE 전화번호=:tele_num";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.Add("total_point", DbType.Int32).Value = total_point;
            cmd.Parameters.Add("today", DbType.String).Value = today;
            cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
            cmd.ExecuteNonQuery();

            refresh_db();

            con.Close();

            earings_textbox.Text = "";

        }

        private void stack_perm_event(object sender, EventArgs e)
        {
            int temp = 0;
            int new_point = 0;
            bool paresd = Int32.TryParse(earings_textbox.Text, out temp);
            if (paresd)
            {
                new_point = (int)(Int32.Parse(earings_textbox.Text) * 0.05);
            }

            else
            {
                MessageBox.Show("숫자를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int now_point = Convert.ToInt32(dt_picked.Rows[0][2]);

            int total_point = now_point + new_point;


            con.Open();
            string query = "UPDATE member set 포인트=:total_point, 최근펌=:today WHERE 전화번호=:tele_num";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.Add("total_point", DbType.Int64).Value = total_point;
            cmd.Parameters.Add("today", DbType.String).Value = today;
            cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
            cmd.ExecuteNonQuery();

            refresh_db();

            con.Close();

            earings_textbox.Text = "";
        }

        private void stack_color_event(object sender, EventArgs e)
        {
            int temp = 0;
            int new_point = 0;
            bool paresd = Int32.TryParse(earings_textbox.Text, out temp);
            if (paresd)
            {
                new_point = (int)(Int32.Parse(earings_textbox.Text) * 0.05);
            }

            else
            {
                MessageBox.Show("숫자를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int now_point = Convert.ToInt32(dt_picked.Rows[0][2]);

            int total_point = now_point + new_point;


            con.Open();
            string query = "UPDATE member set 포인트=:total_point, 최근염색=:today WHERE 전화번호=:tele_num";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.Add("total_point", DbType.Int64).Value = total_point;
            cmd.Parameters.Add("today", DbType.String).Value = today;
            cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
            cmd.ExecuteNonQuery();

            refresh_db();

            con.Close();

            earings_textbox.Text = "";
        }

        private void use_cut_event(object sender, EventArgs e)
        {
            int temp = 0;
            int use_point = 0;
            bool paresd = Int32.TryParse(use_point_textbox.Text, out temp);
            if (paresd)
            {
                use_point = Int32.Parse(use_point_textbox.Text);
            }

            else
            {
                MessageBox.Show("숫자를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int now_point = Convert.ToInt32(dt_picked.Rows[0][2]);

            int total_point = now_point - use_point;
            
            if(total_point >= 0)
            {
                con.Open();
                string query = "UPDATE member SET 포인트=:total_point, 최근커트=:today WHERE 전화번호=:tele_num";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.Add("total_point", DbType.Int64).Value = total_point;
                cmd.Parameters.Add("today", DbType.String).Value = today;
                cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
                cmd.ExecuteNonQuery();


                refresh_db();

                con.Close();

            }
            else
            {
                MessageBox.Show("입력값이 너무큽니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            use_point_textbox.Text = "";
        }

        private void use_perm_event(object sender, EventArgs e)
        {
            int temp = 0;
            int use_point = 0;
            bool paresd = Int32.TryParse(use_point_textbox.Text, out temp);
            if (paresd)
            {
                use_point = Int32.Parse(use_point_textbox.Text);
            }

            else
            {
                MessageBox.Show("숫자를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int now_point = Convert.ToInt32(dt_picked.Rows[0][2]);

            int total_point = now_point - use_point;

            if(total_point >= 0)
            {
                con.Open();
                string query = "UPDATE member set 포인트=:total_point, 최근펌=:today WHERE 전화번호=:tele_num";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.Add("total_point", DbType.Int64).Value = total_point;
                cmd.Parameters.Add("today", DbType.String).Value = today;
                cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
                cmd.ExecuteNonQuery();

                refresh_db();

                con.Close();


            }
            else
            {
                MessageBox.Show("입력값이 너무큽니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            use_point_textbox.Text = "";
        }

        private void use_color_event(object sender, EventArgs e)
        {
            int temp = 0;
            int use_point = 0;
            bool paresd = Int32.TryParse(use_point_textbox.Text, out temp);
            if (paresd)
            {
                use_point = Int32.Parse(use_point_textbox.Text);
            }

            else
            {
                MessageBox.Show("숫자를 입력해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int now_point = Convert.ToInt32(dt_picked.Rows[0][2]);

            int total_point = now_point - use_point;

            if(total_point >= 0)
            {
                con.Open();
                string query = "UPDATE member set 포인트=:total_point, 최근염색=:today WHERE 전화번호=:tele_num";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.Add("total_point", DbType.Int64).Value = total_point;
                cmd.Parameters.Add("today", DbType.String).Value = today;
                cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
                cmd.ExecuteNonQuery();

                refresh_db();

                con.Close();
            }
            else
            {
                MessageBox.Show("입력값이 너무큽니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            use_point_textbox.Text = "";
        }

        private void db_refresh(object sender, EventArgs e)
        {

            //DB참조 WHILE로 조건문 제시
            string query = "SELECT* from member WHERE 전화번호=:tele_num";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;

            //데이터테이블 연동
            DataTable dt_picked = new DataTable();

            //어댑터생성 및 데이터테이블에 채우기
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt_picked);

            //DataGridView 데이터소스 연결
            member_view.DataSource = dt_picked;
        }


        private void Form2_Load(object sender, EventArgs e) //폼 로드시 이벤트 
        {
            refresh_db();
            /*
            DataTable temp = new DataTable();
            member_view.DataSource = temp;
            member_view.DataSource = dt_picked;
            */
        }

        public void refresh_db()
        {
            //DB참조 WHILE로 조건문 제시
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand();
            if(Convert.ToInt32(tele_num) == 100) // 귀찮아서 0100 에서 100으로 함 
            {
                query = "SELECT* FROM member";
                cmd = new SQLiteCommand(query, con);
            }
            else
            {
                query = "SELECT* from member WHERE 전화번호=:tele_num";
                cmd = new SQLiteCommand(query, con);
                cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
            }



            //데이터테이블 연동
            //DataTable dt_picked = new DataTable();
            dt_picked = new DataTable();

            //어댑터생성 및 데이터테이블에 채우기
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt_picked);

            //DataGridView 데이터소스 연결
            member_view.DataSource = dt_picked;
        }

        private void user_delete_event(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?",
                "지정한 데이터삭제",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //SQL DELETE문 
            }
        
        }

        private void edit_event(object sender, EventArgs e)
        {
            if (MessageBox.Show("수정하시겠습니까?",
                "데이터 수정",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("수정을 취소합니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                DataGridViewRow row = member_view.Rows[0];
                string name = row.Cells[0].Value.ToString();
                string number = row.Cells[1].Value.ToString();
                string cut_date = row.Cells[2].Value.ToString();
                string perm_date = row.Cells[3].Value.ToString();
                string color_date = row.Cells[4].Value.ToString();
                string point = row.Cells[5].Value.ToString();

                int temp = 0;

                bool paresd = Int32.TryParse(point, out temp);
                if (paresd)
                {
                    con.Open();
                    string query = "UPDATE member set 이름=:name, 최근커트=:last_cut, 최근펌=:last_perm, 최근염색=:last_color, 포인트=:total_point WHERE 전화번호=:tele_num";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.Add("name", DbType.String).Value = name;
                    cmd.Parameters.Add("total_point", DbType.Int32).Value = temp;
                    cmd.Parameters.Add("last_cut", DbType.String).Value = cut_date;
                    cmd.Parameters.Add("last_perm", DbType.String).Value = perm_date;
                    cmd.Parameters.Add("last_color", DbType.String).Value = color_date;
                    cmd.Parameters.Add("tele_num", DbType.String).Value = tele_num;
                    cmd.ExecuteNonQuery();

                    refresh_db();

                    con.Close();
                    MessageBox.Show("성공적으로 수정하였습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("형식이 올바르지 않습니다", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //여기서 부터 함수추가
    }
}
