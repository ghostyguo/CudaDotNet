#include <iostream>
#include <stdlib.h>

#include <cuda_runtime.h>
#include <vector_types.h>
//#include <helper_cuda.h>

#define DLLEXPORT __declspec(dllexport)  

extern "C" DLLEXPORT cudaError_t addWithCuda(int *c, const int *a, const int *b, unsigned int size);

extern "C" DLLEXPORT bool AddVec(int* c, int* a, int* b, int size)
{
	cudaError_t cudaStatus = addWithCuda(c, a, b, size);
	return (cudaStatus == cudaSuccess);
}