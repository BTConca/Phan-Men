﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shape.DAO
{
    public class XL_DULIEU
    {
        string duong_dan = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\VanKhai\Desktop\Collar\Phan-Men\QuickNote\Shape\Note.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable LayDuLieu(string sql)
        {
            try
            {
                SqlConnection ket_noi = new SqlConnection(duong_dan);

                SqlDataAdapter bo_thich_ung = new SqlDataAdapter(sql, ket_noi);

                DataTable bang = new DataTable();
                bo_thich_ung.Fill(bang);

                return bang;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
                throw ex;
            }
        }

        public int ThucThi(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            ket_noi.Open();

            int kq = lenh.ExecuteNonQuery();

            ket_noi.Close();

            return kq;
        }
    }
}