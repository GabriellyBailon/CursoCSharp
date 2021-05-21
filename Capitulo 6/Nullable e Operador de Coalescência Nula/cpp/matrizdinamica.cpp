#include <iostream>
#include <iomanip>			//Biblioteca necessária para a leitura
#include <fstream>			//Biblioteca necessária para a leitura
#include <stdlib.h>
using namespace std;

int main()
{
							//LEITURA DE ARQUIVO .TXT COM MATRIZ ESTÁTICA
				  
	//Ponteiro da matriz (já que não saberemos o seu tamanho)
	int **matriz;
				
	//Declara fluxo de entrada
	ifstream learquivo;
		  
	//Variáveis que irão receber linha e coluna
	int l;
	int c;
	
	//Abre o arquivo
	learquivo.open("matriz_teste.txt");
	
	//Lê as informações (coluna e linha e salva cada uma em uma variável)
	learquivo >> l >> c; 				// >> entra valores
	
	//Aloca memória para a matriz dinâmica
	matriz = (int**)malloc( l * sizeof(int*));		//A matriz (ponteiro) m recebe o endereço
													// de memória, alocando o número de 
													//LINHAS (malloc) multiplicado pelo tamanho 
													//de um ponteiro para int, ou seja,
													//aloca o valor para um vetor
												
												
	for(int numerodelinhas = 0; numerodelinhas< l; numerodelinhas++)
	{
		//A cada linha, a matriz aloca dinamicamente o espaço necessário 
		//para os inteiros de acordo com o número passado pela coluna,
		//ou seja, aloca para os vetores e colunas
		matriz[numerodelinhas] = (int *) malloc(c * sizeof(int));
			              //ponteiro			
	}	
					
					//IMPORTANTE: Repare que a matriz e o espaço são **, ou seja, 
					//ponteiro para ponteiro, ambos tem de ser do mesmo tipo para funcionarem
	
	
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
