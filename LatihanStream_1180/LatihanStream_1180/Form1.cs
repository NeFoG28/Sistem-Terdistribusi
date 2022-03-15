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

namespace LatihanStream_1180
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            aktikanTextbox(false);
            totalRecord();

        }

        const int kapasitasAwal = 50;
        string[] arrCustomer = new string[kapasitasAwal];
        int jmlMax = kapasitasAwal;
        int idx = -1;
        int jmlCustomer = 0;
        char pemisah = ',';

        private void pisahDataCustomer(string customer)
        {
            char[] pisah = { pemisah };
            string[] dataCustomer = customer.Split(pisah);
            txtId.Text = dataCustomer[0];
            txtNama.Text = dataCustomer[1];
            txtAlamat.Text = dataCustomer[2];

        }

        private void aktikanTextbox(bool sifatKeaktifan)
        {
            txtId.Enabled = sifatKeaktifan;
            txtNama.Enabled = sifatKeaktifan;
            txtAlamat.Enabled = sifatKeaktifan;
        }

        private void bersih()
        {
            txtId.Clear();
            txtNama.Clear();
            txtAlamat.Clear();

        }

        private void totalRecord()
        {
            lblTotal.Text = "Total Record = " + jmlCustomer.ToString();
        }

        private void updateDataArray()
        {
            if (jmlCustomer > 0)
            {
                //masing-masing field dipisahkan dengan tanda pemisah koma
                string customer = "";
                customer = customer + txtId.Text + pemisah;
                customer = customer + txtNama.Text + pemisah;
                customer = customer + txtAlamat.Text + pemisah;

                //simpan string ke array
                arrCustomer[idx] = customer;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult pilih = dlgOpen.ShowDialog();
            if(pilih == DialogResult.OK)
            {
                arrCustomer = File.ReadAllLines(dlgOpen.FileName);
                jmlCustomer = arrCustomer.Length;
                idx = 0;

                //perbesar ukuran array agar dapat ditambah record
                jmlMax = jmlCustomer * 2;
                Array.Resize(ref arrCustomer, jmlMax);

                //tampilkan data ke textbox
                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                aktikanTextbox(true);
                totalRecord();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateDataArray();
            DialogResult pilih = dlgSave.ShowDialog();
            if (pilih == DialogResult.OK)
            {
                //simpan data sebanyak jml data yang ada dlm array
                //dengan cara copy data array lama ke array baru
                string[] arrBantuan = new string[jmlCustomer];
                Array.Copy(arrCustomer, arrBantuan, jmlCustomer);
                File.WriteAllLines(dlgSave.FileName, arrBantuan);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if(jmlCustomer>0)
            {
                idx = 0;
                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();

            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                idx = jmlCustomer - 1;
                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                idx --;
                if (idx < 0)
                    idx = 0;

                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                idx++;
                if (idx >= jmlCustomer)
                    idx = jmlCustomer - 1;

                string customer = arrCustomer[idx];
                pisahDataCustomer(customer);
                totalRecord();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            aktikanTextbox(true);
            updateDataArray();
            if (jmlCustomer == jmlMax)
            {
                jmlMax *= 2;
                Array.Resize(ref arrCustomer, jmlMax);
            }

            bersih();
            txtId.Focus();
            idx = jmlCustomer;
            jmlCustomer++;
            totalRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                if (idx == jmlCustomer - 1)
                    idx--;
                else
                    for (int i = idx; i < jmlCustomer; i++)
                        arrCustomer[i] = arrCustomer[i + 1];

                jmlCustomer--;

                if(jmlCustomer>0)
                {
                    string customer = arrCustomer[idx];
                    pisahDataCustomer(customer);
                }
                else
                {
                    bersih();
                    aktikanTextbox(false);
                }

                totalRecord();
            }
        }
    }

}
