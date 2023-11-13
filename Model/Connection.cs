﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan14.View
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection Conn;
        
        public MySqlConnection GetConn()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;user=root;database=kuis14";
            try
            {
                Conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi Gagal " + ex.Message);
            }
            return Conn;
        }
    }
}
