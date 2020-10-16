using System;


namespace shell
{
    class shell
    {
        int[] arreglo = { 1, 8, 23, 6, 1, 6 };
        public shell(){
            Console.WriteLine("Arreglo antes de ordenar");
            imprimir(arreglo);
            sort(arreglo);
            Console.WriteLine();
            Console.WriteLine("Arreglo despues de ordenar");
            imprimir(arreglo);

            Console.ReadKey();
        }


        private void sort(int[] arr){
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2){
                
                for (int i = gap; i < n; i ++){
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap) {
                        arr[j] = arr[j - gap];
                    }
                        
                    arr[j] = temp;
                }
            }
        }

        private void imprimir(int [] arreglin){
            for (int i = 0; i < arreglin.Length; i++){
                Console.Write(arreglin[i]+" ");
            }
        }

    }
}
