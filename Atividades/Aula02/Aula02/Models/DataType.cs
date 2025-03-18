﻿using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace Aula02.Models
{
	public class DataType
	{
		public char myVar = 'a';
		public char myConst = 'b';

		public char myChar1 = 'f';
		public char myChar2 = ':';
		public char myChar3 = 'x';

		//Podemos também atribuir referência de caracteres Unicode
		public char myChar4 = '\u2726';

		//Podemos ainda mesclar caracteres especiais como,
		//nova linha, tabulação e etc..
		public string textLine = "Esta é uma linha de texto.\n\n\nE está é outra linha";

		/*
		\e - Caracter de escape
		\n - Nova linha
		\t - Tabulação horizontal
		\" - Aspas duplas, usadas para exibir aspas dentro de string
		\' - Aspas simples, usados para exibir aspas simples na string		 
		*/

		private int count = 10;
		public string message;

		public DataType()
		{
			//Interpolação de Strings
			//Combinando Strings de diferentes maneiras no C#
			message = $"O contador está em {count}";

			string username = "Pedro";
			int inboxCount = 10;
			int maxCount = 100;

			message += $"\nO usuário {username} tem {inboxCount} mensagens.";
			message += $"\nEspaço restante em sua caixa {maxCount - inboxCount}.";
		}

	}
}
