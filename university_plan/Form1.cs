using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// 単位の出力が必要
// page管理が必要

namespace university_plan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readKyoka();
            readSelectKyoka();
        }

        // 入力された内容を取得後、 test_selectファイルに書き込む(25個分)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox1.Text;
            writer(selectCombo);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox2.Text;
            writer(selectCombo);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox3.Text;
            writer(selectCombo);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox4.Text;
            writer(selectCombo);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox5.Text;
            writer(selectCombo);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox6.Text;
            writer(selectCombo);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox7.Text;
            writer(selectCombo);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox8.Text;
            writer(selectCombo);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox9.Text;
            writer(selectCombo);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox10.Text;
            writer(selectCombo);
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox11.Text;
            writer(selectCombo);
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox12.Text;
            writer(selectCombo);
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox13.Text;
            writer(selectCombo);
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox14.Text;
            writer(selectCombo);
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox15.Text;
            writer(selectCombo);
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox16.Text;
            writer(selectCombo);
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox17.Text;
            writer(selectCombo);
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox18.Text;
            writer(selectCombo);
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox19.Text;
            writer(selectCombo);
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox20.Text;
            writer(selectCombo);
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox21.Text;
            writer(selectCombo);
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox22.Text;
            writer(selectCombo);
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox23.Text;
            writer(selectCombo);
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox24.Text;
            writer(selectCombo);
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCombo = comboBox25.Text;
            writer(selectCombo);
        }

        // 選択されたものの情報をtest_selectに書き込む
        private void writer(string select)
        {
            string path = "test_kyoka.txt";
            List<string> selectKyoka = new List<string>();
            using (var sr = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    // [,]で切り、リストに代入
                    string[] items = line.Split(',');
                    List<string> list = new List<string>();
                    list.AddRange(items);

                    string kyokaId = list[0];
                    string kyoka = list[1];
                    string jigen = list[2];
                    string youbi = list[3];
                    string year = list[4];
                    string tani = list[5];

                    //switch (year)
                    //{
                    //    case 0:
                    //        page = 0;
                    //        break;
                    //    case 1:
                    //        page = 1;
                    //        break;
                    //    case 2:
                    //        page = 2;
                    //        break;
                    //    case 3:
                    //        page = 3;
                    //        break;
                    //    case 4:
                    //        page = 4;
                    //        break;
                    //    case 5:
                    //        page = 5;
                    //        break;
                    //    case 6:
                    //        page = 6;
                    //        break;
                    //    case 7:
                    //        page = 7;
                    //        break;

                    //}

                    // 指定した教科と一致する行を抜き出し、test_selectファイルに書き込む準備をする
                    // test_select内を検索する
                    if (kyoka == select)
                    {
                        selectKyoka = list;

                        // 同じ曜日、同じ時限で被るものを検索して単位数に影響が出ないようにしたかったが時間がなかったため割愛

                        //using (var sr_sl = new System.IO.StreamReader("test_select.txt"))
                        //{
                        //    string line_sl = null;
                        //    List<int> k_id = new List<int>();
                        //    while ((line_sl = sr.ReadLine()) != null)
                        //    {
                        //        // [,]で切り、リストに代入
                        //        string[] items_sl = line_sl.Split(',');
                        //        List<string> list_sl = new List<string>();
                        //        list_sl.AddRange(items_sl);

                        //        // それぞれの変数に代入
                        //        string kyokaId_sl = list_sl[0];
                        //        string kyoka_sl = list_sl[1];
                        //        string jigen_sl = list_sl[2];
                        //        string youbi_sl = list_sl[3];
                        //        string year_sl = list_sl[4];
                        //        string tani_sl = list_sl[5];
                        //if (jigen == jigen_sl)
                        //{

                        //}
                        //else
                        //{
                        //    //var item = new MyComboBoxItem(kyokaId, kyoka, jigen, youbi, year, tani);
                        //    selectKyoka = list;
                        //}

                        //}

                        //}

                    }
                    
                }

            }
            // test_selectファイルに書き込む
            using (StreamWriter sw = new System.IO.StreamWriter("test_select.txt", true, Encoding.UTF8))
            {
                //list型のselectKyokaを[,]を間に入れてtxtファイルに出力
                sw.WriteLine(string.Join(",", selectKyoka));
            }
        }

        // test_kyokaファイルを読み込み、comboBoxに登録する
        private void readKyoka()
        {
            string path = "test_kyoka.txt";
            using (var sr = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(',');
                    List<string> list = new List<string>();
                    list.AddRange(items);
                    string kyoka = list[1];
                    string jigen = list[2];
                    string youbi = list[3];
                    string year = list[4];
                    string tani = list[5];
                    //int page = 0;


                    if (youbi == "月")
                    {
                        switch (jigen)
                        {
                            case "1":
                                comboBox1.Items.Add(kyoka);
                                break;
                            case "2":
                                comboBox2.Items.Add(kyoka);
                                break;
                            case "3":
                                comboBox3.Items.Add(kyoka);
                                break;
                            case "4":
                                comboBox4.Items.Add(kyoka);
                                break;
                            case "5":
                                comboBox5.Items.Add(kyoka);
                                break;
                        }
                    }
                    if (youbi == "火")
                    {
                        switch (jigen)
                        {
                            case "1":
                                comboBox6.Items.Add(kyoka);
                                break;
                            case "2":
                                comboBox7.Items.Add(kyoka);
                                break;
                            case "3":
                                comboBox8.Items.Add(kyoka);
                                break;
                            case "4":
                                comboBox9.Items.Add(kyoka);
                                break;
                            case "5":
                                comboBox10.Items.Add(kyoka);
                                break;
                        }
                    }
                    if (youbi == "水")
                    {
                        switch (jigen)
                        {
                            case "1":
                                comboBox11.Items.Add(kyoka);
                                break;
                            case "2":
                                comboBox12.Items.Add(kyoka);
                                break;
                            case "3":
                                comboBox13.Items.Add(kyoka);
                                break;
                            case "4":
                                comboBox14.Items.Add(kyoka);
                                break;
                            case "5":
                                comboBox15.Items.Add(kyoka);
                                break;
                        }
                    }
                    if (youbi == "木")
                    {
                        switch (jigen)
                        {
                            case "1":
                                comboBox16.Items.Add(kyoka);
                                break;
                            case "2":
                                comboBox17.Items.Add(kyoka);
                                break;
                            case "3":
                                comboBox18.Items.Add(kyoka);
                                break;
                            case "4":
                                comboBox19.Items.Add(kyoka);
                                break;
                            case "5":
                                comboBox20.Items.Add(kyoka);
                                break;
                        }
                    }
                    if (youbi == "金")
                    {
                        switch (jigen)
                        {
                            case "1":
                                comboBox21.Items.Add(kyoka);
                                break;
                            case "2":
                                comboBox22.Items.Add(kyoka);
                                break;
                            case "3":
                                comboBox23.Items.Add(kyoka);
                                break;
                            case "4":
                                comboBox24.Items.Add(kyoka);
                                break;
                            case "5":
                                comboBox25.Items.Add(kyoka);
                                break;
                        }
                    }
                }
            }
        }

        // test_selectを読み込みラベルに出力する
        private void readSelectKyoka()
        {
            string path = "test_select.txt";
            using (var sr = new System.IO.StreamReader(path))
            {
                string line = null;
                int count_tani = 0;
                
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(',');
                    List<string> list = new List<string>();
                    list.AddRange(items);
                    string kyokaId = list[0];
                    string kyoka = list[1];
                    string jigen = list[2];
                    string youbi = list[3];
                    string year = list[4];
                    string tani = list[5];

                    if (youbi == "月")
                    {
                        switch (jigen)
                        {
                            case "1":
                                label1.Text = kyoka;
                                break;
                            case "2":
                                label2.Text = kyoka;
                                break;
                            case "3":
                                label3.Text = kyoka;
                                break;
                            case "4":
                                label4.Text = kyoka;
                                break;
                            case "5":
                                label5.Text = kyoka;
                                break;
                        }
                    }
                    if (youbi == "火")
                    {
                        switch (jigen)
                        {
                            case "1":
                                label6.Text = kyoka;
                                break;
                            case "2":
                                label7.Text = kyoka;
                                break;
                            case "3":
                                label8.Text = kyoka;
                                break;
                            case "4":
                                label9.Text = kyoka;
                                break;
                            case "5":
                                label10.Text = kyoka;
                                break;
                        }
                    }
                    if (youbi == "水")
                    {
                        switch (jigen)
                        {
                            case "1":
                                label11.Text = kyoka;
                                break;
                            case "2":
                                label12.Text = kyoka;
                                break;
                            case "3":
                                label13.Text = kyoka;
                                break;
                            case "4":
                                label14.Text = kyoka;
                                break;
                            case "5":
                                label15.Text = kyoka;
                                break;
                        }
                    }
                    if (youbi == "木")
                    {
                        switch (jigen)
                        {
                            case "1":
                                label16.Text = kyoka;
                                break;
                            case "2":
                                label17.Text = kyoka;
                                break;
                            case "3":
                                label18.Text = kyoka;
                                break;
                            case "4":
                                label19.Text = kyoka;
                                break;
                            case "5":
                                label20.Text = kyoka;
                                break;
                        }
                    }
                    if (youbi == "金")
                    {
                        switch (jigen)
                        {
                            case "1":
                                label21.Text = kyoka;
                                break;
                            case "2":
                                label22.Text = kyoka;
                                break;
                            case "3":
                                label23.Text = kyoka;
                                break;
                            case "4":
                                label24.Text = kyoka;
                                break;
                            case "5":
                                label25.Text = kyoka;
                                break;
                        }
                    }
                    int tani_int = int.Parse(tani);
                    count_tani += tani_int;
                }
                label26.Text = "取得予定単位数：" + count_tani.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readSelectKyoka();
        }
    }

    //    public class MyComboBoxItem
    //    {
    //        private int m_kyokaId;
    //        private string m_kyoka = "";
    //        private int m_jigen;
    //        private string m_youbi = "";
    //        private int m_year;
    //        private int m_tani;

    //        //コンストラクタ
    //        public MyComboBoxItem(int kyokaId, string kyoka, int jigen, string youbi, int year, int tani)
    //        {
    //            m_kyokaId = kyokaId;
    //            m_kyoka = kyoka;
    //            m_jigen= jigen;
    //            m_youbi = youbi;
    //            m_year = year;
    //            m_tani = tani;
    //        }

    //        //実際の値
    //        public int Id
    //        {
    //            get{return m_kyokaId;}
    //        }

    //        //表示名称
    //        //(このプロパティはこのサンプルでは使わないのでなくても良い)
    //        public string Kyoka
    //        {
    //            get{return m_kyoka;}
    //        }

    //        public int Jigen
    //        {
    //            get { return m_jigen;}
    //        }

    //        public string Youbi
    //        {
    //            get { return m_youbi;}
    //        }

    //        public int Year
    //        {
    //            get { return m_year;}
    //        }

    //        public int Tani
    //        {
    //            get { return m_tani;}
    //        }

    //        //オーバーライドしたメソッド
    //        //これがコンボボックスに表示される
    //        public override string ToString()
    //        {
    //            return m_kyoka;
    //        }
    //    }
}
