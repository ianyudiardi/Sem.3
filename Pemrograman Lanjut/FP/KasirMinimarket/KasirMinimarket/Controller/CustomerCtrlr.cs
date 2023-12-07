using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using KasirMinimarket.Model.Context;
using KasirMinimarket.Model.Entity;
using KasirMinimarket.Model.Repository;

namespace KasirMinimarket.Controller
{
    public class CustomerController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private CustomerRestApiRepo _repository;
        public List<Customer> ReadByID(string id)
        {
            // membuat objek collection
            List<Customer> list = new List<Customer>();

            //membuat objek dari class CustomerRestApiRepository
            var repo = new CustomerRestApiRepo();
            list = repo.ReadByID(id);
            return list;
        }
        public List<Customer> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Customer> list = new List<Customer>();

            //membuat objek dari class CustomerRestApiRepository
            var repo = new CustomerRestApiRepo();
            list = repo.ReadByNama(nama);
            return list;
        }
        public List<Customer> ReadAll()
        {
            // membuat objek collection
            List<Customer> list = new List<Customer>();

            //membuat objek dari class CustomerRestApiRepository
            var repo = new CustomerRestApiRepo();
            list = repo.ReadAll();
            return list;
        }

        public int Create(Customer cust)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(cust.id_cust))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(cust.nama_cust))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new CustomerRestApiRepo();
            result = repo.Create(cust);

            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pelanggan gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Customer cust)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(cust.id_cust))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(cust.nama_cust))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            
            var repo = new CustomerRestApiRepo();
            result = repo.Update(cust);

            if (result > 0)
            {
                MessageBox.Show("Data customer berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data customer gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Customer cust)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(cust.id_cust))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new CustomerRestApiRepo();
            result = repo.Delete(cust);

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
