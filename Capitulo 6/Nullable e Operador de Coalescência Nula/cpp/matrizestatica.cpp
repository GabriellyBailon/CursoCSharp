#include <iostream>
#include <iomanip>			//Biblioteca necessária para a leitura
#include <fstream>			//Biblioteca necessária para a leitura
using namespace std;

int main()
{
							//LEITURA DE ARQUIVO .TXT COM MATRIZ ESTÁTICA
				  
	//Matriz de 3x3 declarada (tamanho da matriz do arquivo)
	int matriz[3][3];
					  
	//Variáveis que irão receber linha e coluna
	int l;
	int c;
	  
	//Declara fluxo de entrada
	ifstream learquivo;
	
	//Abre o arquivo
	learquivo.open("matriz_teste.txt");
	
	//Lê as informações (coluna e linha e salva cada uma em uma variável)
	learquivo >> l >> c; 				// >> entra valores
	
	
	for (int i= 0; i < l; i++)		//For que lê a matriz do arquivo .txt
	{
		for(int j = 0; j < c; j++)
		{
		//Lê os arquivos do txt e passa para a matriz
		learquivo >> matriz[i][j];
		}
	}
	
	for (int i= 0; i < l; i++)		//For que imprime a matriz do arquivo .txt
	{
		for(int j = 0; j < c; j++)
		{
		//Imprime a matriz lida e armazenada acima
		cout << matriz[i][j] << " ";
		}
		cout << endl;
	}
		
	return 0;
}
