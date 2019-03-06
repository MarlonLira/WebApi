using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebFit.Models;

namespace WebFit.Controllers
{
    [RoutePrefix("api")]
    public class UsuarioController : ApiController
    {
        private static List<UsuarioMdl> listaUsuarios = new List<UsuarioMdl>();

        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("usuario")]
        public string CadastrarUsuario(UsuarioMdl usuario) {

            listaUsuarios.Add(usuario);

            return "Usuário cadastrado com sucesso!";
        }

        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("usuario")]
        public string AlterarUsuario(UsuarioMdl usuario) {

            listaUsuarios.Where(n => n.Matricula == usuario.Matricula)
                         .Select(s => {
                             s.Matricula = usuario.Matricula;
                             s.Nome = usuario.Nome;
                             s.Senha = usuario.Senha;
                             s.Cpf = usuario.Cpf;

                             return s;

                         }).ToList();



            return "Usuário alterado com sucesso!";
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("usuario/{Matricula}")]
        public string ExcluirUsuario(String Matricula) {

            UsuarioMdl usuario = listaUsuarios.Where(n => n.Matricula == Matricula)
                                              .Select(n => n)
                                              .First();

            listaUsuarios.Remove(usuario);

            return "Registro excluido com sucesso!";
        }

        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("usuario/{Matricula}")]
        public UsuarioMdl ConsultarUsuarioPorMatricula(String Matricula) {

            UsuarioMdl usuario = listaUsuarios.Where(n => n.Matricula == Matricula)
                                              .Select(n => n)
                                              .FirstOrDefault();

            return usuario;
        }

        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("usuario")]
        public List<UsuarioMdl> ConsultarUsuarios() {

            return listaUsuarios;
        }
    }
}
