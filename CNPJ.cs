namespace Aula06Heranca
{
    public class CNPJ : Pessoa
    {
        public string cnpj;
        /// <summary>
        /// Valida o CNPJ do usuário
        /// </summary>
        /// <returns>Validação True or False</returns>
        public bool ValidarCNPJ(){
            if(cnpj != ""){
                return true;
            }
            return false;
        }
    }
}