using System;

namespace Program1 {
    class test1 {
        Public static void Main() {
 int i,j;
        	int[,] arr = new int[3,3];
            int determinant=0;
  
  
       Console.Write("\n\ndeterminant of a 3 x 3 matrix :\n");
       Console.Write("_________________________\n");  

       for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
			   arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }  
	 Console.Write("The matrix is :\n");
	 for(i=0;i<3;i++)
	 {
	   for(j=0;j<3 ;j++)
	     Console.Write("{0}  ",arr[i,j]);
	    Console.Write("\n");
	 }

  for(i=0;i<3;i++){
      determinant = determinant + (arr[0,i]*(arr[1,(i+1)%3]*arr[2,(i+2)%3] - arr[1,(i+2)%3]*arr[2,(i+1)%3]));
  }

  Console.Write("\n determinant is: {0}\n\n",determinant);
        }
    }
}
