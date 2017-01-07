#include <stdio.h>

int max(int arr[], int length)
{
	if (length > 1)
		return arr[length] > max(arr, length - 1) ? arr[length] : max(arr, length - 1);
	else return arr[length];
}

main()
{
	int arr[] = { 2, 5, 3, 1 };

	printf("%d\n", max(arr, 4));
}