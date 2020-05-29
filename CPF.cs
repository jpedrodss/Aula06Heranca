namespace Aula06Heranca
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;
        /// <summary>
        /// Valida o CPF do usuário
        /// </summary>
        /// <returns>Validação True or False</returns>
        public bool ValidarCPF(){
            if(cpf != ""){
                return true;
            }
            return false;
        }
    }
}