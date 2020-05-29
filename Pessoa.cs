namespace Aula06Heranca
{
    public class Pessoa
    {
        public string nome;
        /// <summary>
        /// Sauda o usuário ao programa
        /// </summary>
        /// <returns>Mensagem de saudação</returns>
        public string Saudar(){
            return "Seja bem vindo "+nome;
        }
    }
}