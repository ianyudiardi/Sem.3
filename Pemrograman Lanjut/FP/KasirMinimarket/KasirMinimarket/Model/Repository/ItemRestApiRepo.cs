using KasirMinimarket.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirMinimarket.Model.Repository
{
    public class ItemRestApiRepo
    {
        public int Create(Item itm)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.POST);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(itm);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Item itm)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/item";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.PUT);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(itm);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Item itm)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/item";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.DELETE);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(itm);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public List<Item> ReadAll()
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Item>>(request);

            return response.Data;
        }

        public List<Item> ReadByNama(string nama_item)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?nama=" + nama_item;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Item>>(request);

            return response.Data;
        }

        public List<Item> ReadByID(string id_item)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?nama=" + id_item;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Item>>(request);

            return response.Data;
        }
    }
}
