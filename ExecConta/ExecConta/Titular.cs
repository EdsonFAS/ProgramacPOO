



   internal class Titular
    {
       private string nome;
        private string cpf;
        private string email;

        public Titular(string nome , string cpf, string email)
        {
            setNome(nome);
            setCpf(cpf);
            setEmail(email);
        }

        public string getNome()
        {
            return this.nome;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;

        } 
        public void setEmail(string email)
        {
            this.email = email;
        }
    }


