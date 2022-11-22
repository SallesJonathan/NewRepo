using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Infra.Services;
using System;

namespace AppModelo.Controller.Seguranca
{
    public class UsuarioController
    {
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.Obter(usuario,senha);

            if (usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RecuperarSenha(string email)
        {
            //1 PASSO VERIFICAR SE EMAIL É DE UM USUARIO
            var repository = new UsuarioRepository();
            var usuario = repository.ObterPorEmail(email);
            if(usuario is null)
            {
                return "Usuário não foi encontrado";
            }

            //2 PASSO GERAR UMA SENHA NOVA E GRAVA NO BANCO
            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repository.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Programador errou sql e vc nao pode recuperar sua senha";
            }
            
            //3 PASSO MANDAR A NOVA SENHA PARA E-MAIL
            var emailService = new EmailService();
            var mensagemHtml = @"<p><b>Criamos um nova senha para você</b></p>
                                  <p>Sua nova senha é: <b>" + novaSenha + "</b></p>";
            var emailEnviado = 
                emailService.EnviarEmail(usuario.Nome, usuario.Email, "Recuperação de Senha", mensagemHtml);
            return "";
        }
    }
}