#include <stdio.h>
#define max 10000
int main()
{
	int k;
	int n;
	int i;
	int aux = 0;
	printf("Digite a quantidade de numeros : ");
	scanf ("%d" , &n);
	int vet[max];
	for (i = 0; i < n; ++i)
	{
		printf("Digite o numero para o vetor : ");
		scanf ("%d" , &vet[i]);
	}
	for (k = 0; k < n; ++k)
	{
		for (i = 0; i <n-1; ++i)
		{
			if (vet[i] > vet[i+1])
			{
				aux = vet[i];
				vet[i] = vet[i+1];
				vet[i+1] = aux;
			}
		}
	}
	for (i = 0; i < n; ++i)
	{
		printf("%d\n", vet[i]);
	}
	return 0;
}
