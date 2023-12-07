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
    public class SupplierController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private SupplierRestApiRepo _repository;
        public List<Supplier> ReadByID(string id)
        {
            // membuat objek collection
            List<Supplier> list = new List<Supplier>();

            //membuat objek dari class SupplierRestApiRepository
            var repo = new SupplierRestApiRepo();
            list = repo.ReadByID(id);
            return list;
        }
        public List<Supplier> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Supplier> list = new List<Supplier>();

            //membuat objek dari class SupplierRestApiRepository
            var repo = new SupplierRestApiRepo();
            list = repo.ReadByNama(nama);
            return list;
        }
        public List<Supplier> ReadAll()
        {
            // membuat objek collection
            List<Supplier> list = new List<Supplier>();

            //membuat objek dari class SupplierRestApiRepository
            var repo = new SupplierRestApiRepo();
            list = repo.ReadAll();
            return list;
        }

        public int Create(Supplier sply)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(sply.id_supplier))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(sply.nama_supplier))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new SupplierRestApiRepo();
            result = repo.Create(sply);

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

        public int Update(Supplier sply)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(sply.id_supplier))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(sply.nama_supplier))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new SupplierRestApiRepo();
            result = repo.Update(sply);

            if (result > 0)
            {
                MessageBox.Show("Data splyomer berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data splyomer gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Supplier sply)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(sply.id_supplier))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new SupplierRestApiRepo();
            result = repo.Delete(sply);

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
