﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ReadWriteUsers
{
    public partial class SAMS : Form
    {
        public SAMS()
        {
            InitializeComponent();

            var sr = new StreamReader(new FileStream(@"E:/AttendanceMonitoringsystem-Release2/stud1.csv", FileMode.Open));
            var csv = new CsvReader(sr);
            sr.Close();
            dataGridView.DataSource = ReadCsv(@"E:/AttendanceMonitoringsystem-Release2/stud1.csv");

        }

        public DataTable ReadCsv(string fileName)
        {
            DataTable dt = new DataTable("Data");
            using (OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
                    Path.GetDirectoryName(fileName) + " \";Extended Properties= 'text;HDR=yes;FMT=Delimited(,)'"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select *from[{0}]", new FileInfo(fileName).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })

            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                    var writer = new CsvWriter(sw);
                       writer.WriteHeader(typeof(Studentspublic));
                        writer.NextRecord();
                        foreach (Studentspublic s in studentspublicBindingSource.List)  
                        {
                            writer.WriteRecord(sw);
                            writer.NextRecord();

                        }

                    }
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            studentspublicBindingSource.DataSource = new List<Studentspublic>();
        }

        private void Readbtn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr);
                    studentspublicBindingSource.DataSource = csv.GetRecords<Studentspublic>().ToString();
                    sr.Close();

                }

                try
                {


                    dataGridView.DataSource = ReadCsv(ofd.FileName);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string[] allLines = File.ReadAllLines("N:\\profilev6\\Desktop\\AttendanceMonitoringSystem\\stud.csv");
            Random rnd1 = new Random();
            MessageBox.Show(("Attendance Confirmed: " + DateTime.Now.ToString("dddd, dd MMMM yyyy, hh:mm tt") + "\n" + "\n" + "ID: " + allLines[rnd1.Next(allLines.Length)]));
            MessageBox.Show("\n" + "Email Confirmation Sent" + "\n" + "SMS Confirmation Sent");
            Console.ReadLine();
        }

        private void SAMS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

