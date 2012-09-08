using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitanTioApp.Business
{
    public class Vineta
    {
        public Vineta()
        {
            this.interlocutor = new Interlocutor[2];
            this.interlocutor[0] = new Interlocutor();
            this.interlocutor[1] = new Interlocutor();
            this.bocadillo = string.Empty;
        }
        
        public Interlocutor[] interlocutor;
        public string bocadillo;
    }
}
