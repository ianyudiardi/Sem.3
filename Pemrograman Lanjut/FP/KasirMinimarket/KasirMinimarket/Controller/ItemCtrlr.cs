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
    public class ItemController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private ItemRestApiRepo _repository;
        public List<Item> ReadByID(string id)
        {
            // membuat objek collection
            List<Item> list = new List<Item>();

            //membuat objek dari class ItemRestApiRepository
            var repo = new ItemRestApiRepo();
            list = repo.ReadByID(id);
            return list;
        }
        public List<Item> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Item> list = new List<Item>();

            //membuat objek dari class ItemRestApiRepository
            var repo = new ItemRestApiRepo();
            list = repo.ReadByNama(nama);
            return list;
        }
        public List<Item> ReadAll()
        {
            // membuat objek collection
            List<Item> list = new List<Item>();

            //membuat objek dari class ItemRestApiRepository
            var repo = new ItemRestApiRepo();
            list = repo.ReadAll();
            return list;
        }

        public int Create(Item itm)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(itm.id_item))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(itm.nama_item))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new ItemRestApiRepo();
            result = repo.Create(itm);

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

        public int Update(Item itm)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(itm.id_item))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(itm.nama_item))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new ItemRestApiRepo();
            result = repo.Update(itm);

            if (result > 0)
            {
                MessageBox.Show("Data itmomer berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data itmomer gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Item itm)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(itm.id_item))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new ItemRestApiRepo();
            result = repo.Delete(itm);

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
