using KasirMinimarket.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirMinimarket.Model.Repository
{
    public class AdminRestApiRepo
    {
        public int Create(Admin adm)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.POST);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(adm);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Admin adm)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/admin";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.PUT);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(adm);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Admin adm)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/admomer";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.DELETE);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(adm);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public List<Admin> ReadAll()
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Admin>>(request);

            return response.Data;
        }

        public List<Admin> ReadByNama(string nama_admin)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?nama=" + nama_admin;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Admin>>(request);

            return response.Data;
        }

        public List<Admin> ReadByID(string id_admin)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?nama=" + id_admin;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Admin>>(request);

            return response.Data;
        }
    }
}
