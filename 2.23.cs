#include<stdlib.h>
#include<stdio.h>

int main()
{
    int a,b,c;
    int max,min;
    scanf("%d %d %d",&a,&b,&c);
    if (a>b){
        if(a>c){
            max=a;
            if(b>c){
                min=c;
            }else{
                min=b;
            }
        }else{
            max=c;
            min=b;
        }
    }else{
        if(b>c){
            max=b;
            if(a>c){
                min=c;
            }else{
                min=a;
            }
        }else{
            max=c;
            min=a;
        }
    }
    printf("%d %d",max,min);
return 0;
}