namespace Aula01.Models
{
	public class Variaveis
	{
		//Tipo implicito	
		// var teste = 10;
			
		//Anotação de tipos
		public int userCount = 10;

		//Uma variavel pode ser declarada e não inicializada
		public int totalCount;

		//Constantes
		//Para declarar uma constante, utilizamos a palavra-chave CONST, no entanto, a CONST deve ser inicializada quando declarada
		public const int interestRate = 10;


		//O  método construtor é invocado na instanciação do objeto por meio da palavra reservad new
		//Por regra, o construtor sempre tem o mesmo nome da classe
		//Quando tem parenteses () é procedimento, colchetes [] é vetores.
		public Variaveis()
		{
			totalCount = 0;

			//Tipo implicito, a palavra chave Var, se encarrega de definir o tipo de variavel na instrução de atribuição (após sinal de =)
			var signalStrength = 22;
			var companyName = "ACME";


		}
		public byte Minbyte = 0;
		public byte Maxbyte = 255;

		public short Minshort = -32768;
		public short Maxshort = 32767;

		public int Minint = -2147483648;
		public int Maxint = 2147483647;

		public uint Minuint = 0;
		public uint Maxuint = 4294967295;

		public long Minlong  = -9223372036854775808;
		public long Maxlong  = 9223372036854775807;

	}
}
