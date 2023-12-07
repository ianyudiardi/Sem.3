using KasirMinimarket.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirMinimarket.Model.Repository
{
    public class CustomerRestApiRepo
    {
        public int Create(Customer cust)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.POST);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(cust);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Customer cust)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/customer";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.PUT);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(cust);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Customer cust)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/customer";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.DELETE);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(cust);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public List<Customer> ReadAll()
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Customer>>(request);

            return response.Data;
        }

        public List<Customer> ReadByNama(string nama_cust)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?nama=" + nama_cust;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Customer>>(request);

            return response.Data;
        }

        public List<Customer> ReadByID(string id_cust)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?ID=" + id_cust;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Customer>>(request);

            return response.Data;
        }
    }


}
