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
    public class AdminController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private AdminRestApiRepo _repository;
        public List<Admin> ReadByID(string id)
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();

            //membuat objek dari class AdminRestApiRepository
            var repo = new AdminRestApiRepo();
            list = repo.ReadByID(id);
            return list;
        }
        public List<Admin> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();

            //membuat objek dari class AdminRestApiRepository
            var repo = new AdminRestApiRepo();
            list = repo.ReadByNama(nama);
            return list;
        }
        public List<Admin> ReadAll()
        {
            // membuat objek collection
            List<Admin> list = new List<Admin>();

            //membuat objek dari class AdminRestApiRepository
            var repo = new AdminRestApiRepo();
            list = repo.ReadAll();
            return list;
        }

        public int Create(Admin adm)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(adm.id_admin))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(adm.nama_admin))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new AdminRestApiRepo();
            result = repo.Create(adm);

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

        public int Update(Admin adm)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(adm.id_admin))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(adm.nama_admin))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new AdminRestApiRepo();
            result = repo.Update(adm);

            if (result > 0)
            {
                MessageBox.Show("Data admomer berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data admomer gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Admin adm)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(adm.id_admin))
            {
                MessageBox.Show("ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            var repo = new AdminRestApiRepo();
            result = repo.Delete(adm);

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
