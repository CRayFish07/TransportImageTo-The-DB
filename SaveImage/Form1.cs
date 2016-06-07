using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SaveImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Admin\\Desktop\\123.jpg";
            byte[] imgBytesIn = SaveImage(path);
            SaveImgImg("2012181003", imgBytesIn);
            //ShowImage(imgBytesIn);
          //ShowImage(Get_Photo("2012181002",pictureBox1));
            Get_Photo("2012181003");
        }
        //将图片转换为二进制流
        public byte[] SaveImage(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);
            return imgBytesIn;
        }
        //显示二进制流图片
        public void ShowImage(byte[] imgBytesIn)
        {
            MemoryStream ms = new MemoryStream(imgBytesIn);
            pictureBox1.Image = Image.FromStream(ms);
        }
        #region
        ////从数据库读取图片
        //public byte[] Get_Photo(string NO,PictureBox ph)
        //{
        //    byte[] imgbytes = null;
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "server=localhost;user id=sa;password=123456; database=Test";
        //    conn.Open();
        //    string sql = "select Img from Study where ID=" + NO;
        //    SqlCommand command = new SqlCommand(sql, conn);
        //    SqlDataReader dr = command.ExecuteReader();
        //    while (dr.Read())
        //    {

        //        imgbytes = dr.
        //    }
        //    return imgbytes;
        //    dr.Close();
        //    conn.Close();
        //    MemoryStream ms = new MemoryStream(imgbytes);
        //    Bitmap bmap = new Bitmap(ms);
        //    ph.Image = bmap;

        //}
        #endregion
        //从数据库读取图片
        public void Get_Photo(string NO)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=localhost;user id=sa;password=123456; database=Test";
            conn.Open();
            string sql = "select Img from Study where ID=" + NO;
            SqlCommand command = new SqlCommand(sql, conn);
            byte[] b = (byte[])command.ExecuteScalar();
            if (b.Length>0)
            {
                MemoryStream stream = new MemoryStream(b, true);
                stream.Write(b, 0, b.Length);
                pictureBox1.Image = new Bitmap(stream);
                stream.Close();
            }
            conn.Close();
        }
        //将二进制流存入数据库
        public void SaveImgImg(string num, byte[] imgBytesIn)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=localhost;user id=sa;password=123456; database=Test";
            conn.Open();
            string sql = "update Study Set Img=@Photo where ID=" + num;
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@Photo", SqlDbType.Binary).Value = imgBytesIn;
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
