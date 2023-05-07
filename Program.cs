using System.Reflection.Emit;
using System.Data;
using Internal;
using System;

namespace obj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HHH");
           
            // CMD();
        }
        // static void CMD(string[] args){
        //      int[,] A={
        //         {4,1},
        //         {1,3},
        //     };
        //     int[,] B=new int[2,2];
        //     B=A;
        //     foreach (var b in B)
        //     {
        //         Console.Write("{0}\t",b);
        //     }
        //     A[1,1]=5;
        //     foreach (var b in B)
        //     {
        //         Console.Write("{0}\t",b);
        //     }
        //     // nA=A.GetLength(0);
        //     // mA=A.GetLength(1);
        //     //  int[,] b={
        //     //     {1},
        //     //     {2},
        //     // };
        //     //  int[,] x0={
        //     //     {2},
        //     //     {1},
        //     // };
        //     // int[,] al,Be,r0,p0,k,rk
        //     // r0=SubMatrix(b,MulMatrix(A,x0));
        //     // p0=r0;
        //     // k=0;
        //     // while(){
        //     //     al=MulMatrix(Trans(r0),r0);
        //     // }
        // }
        static int MulMatrix(int[,] A,int[,] B){
            int nA,nB,mA,mB,i,k,j;
            nA=A.GetLength(0);
            mA=A.GetLength(1);
            nB=B.GetLength(0);
            mB=B.GetLength(1);
            int[,] C= new int[nA,mB];
            if(mA == nB){
                for(i=0;i<nA;i++){
                    for(k=0;k<mB;k++){
                        int s=0;
                        for(j=0;j<nA;j++){
                            s=s+A[i,j]*B[j,k];
                        }
                        C[i,k]=s;
                    }
                }
                foreach (var c in C)
                {
                    Console.Write("{0} \t",c);
                }
                Console.ReadKey();
                return 1;
            }
            else
            {
                Console.Write("Kich thuoc 2 ma tran khong dung.");
            return 0;
            }
        }
        static int TransMatrix(int[,] A){
            int nA,mA,i,j;
            nA=A.GetLength(0);
            mA=A.GetLength(1);
            int[,] B=new int[mA,nA];
            for (int i = 0; i < nA; i++)
            {
                for (int j = 0; j < mA; j++)
                {
                    B[j,i]=A[i,j];
                }
            }
            return B;
        }
        static int SubMatrix(int[,] A,int[,] B){
            int nA,nB,mA,mB,i,k,j;
            nA=A.GetLength(0);
            mA=A.GetLength(1);
            nB=B.GetLength(0);
            mB=B.GetLength(1);
            if (nA==nB && mA==mB)
            {    
                int[,] C=new int[nA,nB];
                for (int i = 0; i < nA; i++)
                {
                    for (int j = 0; j < mA; j++)
                    {
                        C[i,j]=A[i,j]-B[i,j];
                    }
                }
                return C;
            }
            else{
                Console.Write("Khong th tru 2 ma tran khac kich thuoc\n");
                return 0;
            }
        }
        static int AddMatrix(int[,] A,int[,] B){
            int nA,nB,mA,mB,i,k,j;
            nA=A.GetLength(0);
            mA=A.GetLength(1);
            nB=B.GetLength(0);
            mB=B.GetLength(1);
            if (nA==nB && mA==mB)
            {    
                int[,] C=new int[nA,nB];
                for (int i = 0; i < nA; i++)
                {
                    for (int j = 0; j < mA; j++)
                    {
                        C[i,j]=A[i,j]+B[i,j];
                    }
                }
                return C;
            }
            else{
                Console.Write("Khong the cong 2 ma tran khac kich thuoc\n");
                return 0;
            }
        }
    }
}
