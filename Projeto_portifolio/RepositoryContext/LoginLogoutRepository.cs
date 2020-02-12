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


        internal bool verificaUser(ValidaUser dadosUser)
        {
            bool verificaUser = false;
            try
            {
                var testeUser = contexto.usuarios.Where(r => r.username.Trim() == dadosUser.usuario.Trim() && r.senha == dadosUser.senha.Trim()).First();
            }
            catch (Exception)
            {
                return verificaUser;
            }

            verificaUser = true;
            return verificaUser;
        }




    }
}
