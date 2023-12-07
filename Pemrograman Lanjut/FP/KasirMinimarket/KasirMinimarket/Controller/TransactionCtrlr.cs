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
    public class TransactionController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private TransactionRestApiRepo _repository;
        public List<Transaction> ReadByID(string id)
        {
            // membuat objek collection
            List<Transaction> list = new List<Transaction>();

            //membuat objek dari class TransactionRestApiRepository
            var repo = new TransactionRestApiRepo();
            list = repo.ReadByID(id);
            return list;
        }

        public List<Transaction> ReadAll()
        {
            // membuat objek collection
            List<Transaction> list = new List<Transaction>();

            //membuat objek dari class TransactionRestApiRepository
            var repo = new TransactionRestApiRepo();
            list = repo.ReadAll();
            return list;
        }

        public int Create(Transaction trans)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trans.id_trans))
            {
                MessageBox.Show("NPM harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new TransactionRestApiRepo();
            result = repo.Create(trans);

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

        public int Update(Transaction trans)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trans.id_trans))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new TransactionRestApiRepo();
            result = repo.Update(trans);

            if (result > 0)
            {
                MessageBox.Show("Data transomer berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data transomer gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Transaction trans)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(trans.id_trans))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new TransactionRestApiRepo();
            result = repo.Delete(trans);

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
