using ApiGit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ApiGit.Service
{
    public class GitHubApi : IApi
    {
        public string BaseUrl
        {
            get
            {
                return "https://api.github.com/";
            }
        }

        public List<Repositorio> GetOwner()
        {
            string action = "https://api.github.com/users/Luizsobrinho/repos";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;


            JArray rep = JArray.Parse(response.Content.ReadAsStringAsync().Result);
            List<Repositorio> repositorios = new List<Repositorio>();

            foreach (var item in rep)
            {
                repositorios.Add(new Repositorio
                {
                    Nome = item["name"].ToString(),
                    Descricao = item["description"].ToString(),
                    Linguagem = item["language"].ToString(),
                    Data = item["updated_at"].ToString(),
                    Url = item["url"].ToString()
                }); ;
            }

            return repositorios;
        }

        public Favorito GetRepositorio(string url)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            JObject obj = JObject.Parse(response.Content.ReadAsStringAsync().Result);

            string nome = obj["name"].ToString();
            string descricao = obj["description"].ToString();
            string linguagem = obj["language"].ToString();
            string data = obj["updated_at"].ToString();
            string html_url = obj["html_url"].ToString();

            Favorito favorito = new Favorito() { Nome = nome, Descricao = descricao, Linguagem = linguagem, DataUltimoUpdate = data, UrlHtml = html_url };
            return favorito;
        }
        public List<Repositorio> GetRepositorios(string url)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            List<Repositorio> repositorios = new List<Repositorio>();

            JArray rep = JArray.Parse(response.Content.ReadAsStringAsync().Result);


            foreach (var item in rep)
            {
                repositorios.Add(new Repositorio
                {
                    Nome = item["name"].ToString(),
                    Descricao = item["description"].ToString(),
                    Linguagem = item["language"].ToString(),
                    Data = item["updated_at"].ToString(),
                    Url = item["url"].ToString()
                });
            }

            return repositorios;
        }

        public List<Usuario> GetUsuarios(string nomeUsuario)
        {
            //string action = string.Format("users/{0}/repos", nomeUsuario);
            string action = string.Format("search/users?q={0}", nomeUsuario, 10);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, BaseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            List<Usuario> listaUsuario = new List<Usuario>();

            JArray usuarios = (JArray)JObject.Parse(response.Content.ReadAsStringAsync().Result)["items"];

            foreach (var item in usuarios)
            {
                listaUsuario.Add(new Usuario
                {
                    Login = item["login"].ToString(),
                    Url = item["url"].ToString(),
                    RepositorioUrl = item["repos_url"].ToString()
                });
            }

            return listaUsuario;
        }
    }
}
