using ProjetoPortifolio.Data;
using ProjetoPortifolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.RepositoryContext
{
    public class LoginLogoutRepository
    {
        ApplicationDBcontext contexto;

        public LoginLogoutRepository()
        {
            contexto = new ApplicationDBcontext();
        }


        public bool verificaUser(ValidaUser dadosUser)
        {
            bool verificaUser;
            try
            {
                var testeUser = contexto.usuarios.Where(r => r.username.Trim() == dadosUser.usuario.Trim() && r.senha == dadosUser.senha.Trim()).FirstOrDefault();
                if(testeUser != null)
                {
                    verificaUser = true;
                }
                else
                {
                    verificaUser = false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return verificaUser;
        }




    }
}
