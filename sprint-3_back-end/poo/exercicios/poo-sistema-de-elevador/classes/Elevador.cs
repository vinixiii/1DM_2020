namespace ex_01.classes
{
    public class Elevador
    {
        private int andarAtual = 0;
        public int AndarAtual{
            get{return andarAtual;}
            set{andarAtual = value;}
        }
        private int totalDeAndares = 3;
        public int TotalDeAndares{
            get{return totalDeAndares;}
        }
        private int capacidade = 3;
        public int Capacidade{
            get{return capacidade;}
        }
        private int pessoasPresentes = 0;
        public int PessoasPresentes{
            get{return pessoasPresentes;}
            set{pessoasPresentes = value;}
        }

        public bool Inicializar(int capacidade, int totalDeAndares) {
            if(pessoasPresentes <= capacidade && totalDeAndares > 0) {
                return true;
            }
            return false;
        }

        public bool Entrar() {
            if(pessoasPresentes < capacidade) {
                return true;
            }
            return false;
        }

        public bool Sair() {
            if(pessoasPresentes > 0 && pessoasPresentes <= capacidade) {
                return true;
            }
            return false;
        }

        public bool Subir() {
            if(andarAtual < totalDeAndares) {
                return true;
            }
            return false;
        }

        public bool Descer() {
            if(andarAtual > 0) {
                return true;
            }
            return false;
        }

    }
}