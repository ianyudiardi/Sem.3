﻿using KasirMinimarket.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirMinimarket.Model.Repository
{
    public class SupplierRestApiRepo
    {
        public int Create(Supplier sply)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.POST);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(sply);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Supplier sply)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/Supplier";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.PUT);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(sply);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Delete(Supplier sply)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/Supplier";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.DELETE);

            //tambahkan objek mahasiswa ke dalam body
            request.AddJsonBody(sply);

            //request ke server
            var response = client.Execute(request);

            //cek nilai content, jika 1 berhasil selain itu gagal
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public List<Supplier> ReadAll()
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Supplier>>(request);

            return response.Data;
        }

        public List<Supplier> ReadByNama(string nama_supplier)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?nama=" + nama_supplier;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Supplier>>(request);

            return response.Data;
        }

        public List<Supplier> ReadByID(string id_supplier)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa?nama=" + id_supplier;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            //membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            //kirim request ke server
            var response = client.Execute<List<Supplier>>(request);

            return response.Data;
        }
    }
}
