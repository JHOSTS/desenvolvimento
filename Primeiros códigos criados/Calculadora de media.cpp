#include <stdio.h>
#include <stdlib.h>

int main()
{
	
	float nota1, nota2, media;
	
	printf("Insira a nota da prova 1: ");
	scanf("%f", &nota1);

	
	printf("Insira a nota da prova 2: ");
	scanf("%f", &nota2);
	
	media = (nota1 + nota2) / 2;
	
	printf("Media: = %.1f\n", media);
	
	system("pause");
	return 0;

}

