
#include <iostream>
#include <stdio.h>
#include <locale>
#include <cmath>
using namespace std;
int sum(int &A);
void primeFactors(int n, int *pF, int N,int &count);
int main()
{   int A, Numb;
    
    setlocale(LC_ALL, "RUS");
    scanf("%d",&Numb);
    switch (Numb)
    {
    case 1:{
        scanf("%d",&A);
    if(A<10&&A>=0)
        printf("%d",sum(A));
    else
        printf("%d",0);
    } 
        break;
    case 2:
    {   int Step=1;
        scanf("%d",&A);
        int score = 0;
        int res, pict;
        while(true){
        int*fP=new int[A];
        int count = 0;
        score =1;
        primeFactors(Step,fP,A,count);
        for(int i =0;i<A ;i++ )
            score*=fP[i];
        if(Step==score && *fP!=*(fP+A-1)){
            pict = *fP;
            for(int i = A-2;i>=0 ;i-- ){
                pict*=fP[i];
                if(score % pict == 0)
                    res++;
            }
               
            break;}
        Step++;
        }
        printf("%d\n", res);
    }
    default:
        break;
    }
    
    return 0;
}


int sum(int &A){
    char X;
    int Y;
    scanf("%c",&X);
    if(X=='+'){
        scanf("%d",&Y);
        if(Y<10 && Y>=0)
            return A + sum(Y);
        else
            return A;
    }else
        return A;
    
}


void primeFactors(int n, int *pF, int N, int& count) 
{   if(count==N)
        return;
    if(n % 2 == 0) 
    { 
        pF[count] =2; 
        n = n/2; 
        count++;
        return primeFactors(n,pF,N, count);
    } 
    for (int i = 3; i <= sqrt(n); i = i + 2)
    if (n % i == 0) 
    { 
            pF[count]=i;
            n = n/i;
            i+=2; 
            count++;
            return primeFactors(n,pF,N,count);
    } 
   
    if (n > 2){
        pF[count]=n;
        }
    
} 