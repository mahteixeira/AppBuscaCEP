﻿using System;
using AppBuscaCEP.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace AppBuscaCEP.Service
{
    public class DataService
    {
        public static async Task<Endereco> GetEnderecoByCep(string cep)
        {
            Endereco end;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/endereco/by-cep?cep=" + cep);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    end = JsonConvert.DeserializeObject<Endereco>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());

            }

            return end;
        }


        public static async Task<List<Bairro>> GetBairrosByIdCidade(int id_cidade)
        {
            List<Bairro> arr_bairros = new List<Bairro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/bairro/by-cidade?cidade=" + id_cidade);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_bairros = JsonConvert.DeserializeObject<List<Bairro>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }

            return arr_bairros;
        }

        public static async Task<List<Logradouro>> LogradouroByBairroAndIdCidade(int id_cidade, string desc_bairro)
        {
            List<Logradouro> arr_ruas = new List<Logradouro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/logradouro/by-bairro?id_cidade=" + id_cidade +"&bairro=" + desc_bairro);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_ruas = JsonConvert.DeserializeObject<List<Logradouro>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }

            return arr_ruas;
        }

        public static async Task<List<Cep>> GetCepBylogradouro(string logradouro)
        {

            List<Cep> arr_cep = new List<Cep>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/cep/by-logradouro?logradouro=" + logradouro);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_cep = JsonConvert.DeserializeObject<List<Cep>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }

            return arr_cep;
        }

        public static async Task<List<Cidade>> CidadeByUF(string uf)          
        {
            List<Cidade> arr_cidades = new List<Cidade>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/cidade/by-uf?uf=" + uf);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_cidades = JsonConvert.DeserializeObject<List<Cidade>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }

            return arr_cidades;
        }


    }
}