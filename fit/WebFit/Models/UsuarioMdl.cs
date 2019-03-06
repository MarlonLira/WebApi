using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFit.Models {
    public class UsuarioMdl {

        private String nome;
        private String senha;
        private String matricula;
        private String cpf;

        public UsuarioMdl() {
        }

        public UsuarioMdl(string senha, string matricula) {
            this.senha = senha;
            this.matricula = matricula;
        }

        public UsuarioMdl(string nome, string senha, string matricula, string cpf) {
            this.nome = nome;
            this.senha = senha;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public String Nome {
            get {
                return nome;
            }
            set {
                this.nome = value;
            }
        }

        public String Senha {
            get {
                return senha;
            }
            set {
                this.senha = value;
            }
        }

        public String Matricula {
            get {
                return matricula;
            }
            set {
                this.matricula = value;
            }
        }

        public String Cpf {
            get {
                return cpf;
            }
            set {
                this.cpf = value;
            }
        }
    }
}