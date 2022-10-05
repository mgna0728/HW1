#include <stdlib.h>
#include <stdio.h>
int main()
{
    float w,h,bmi;
    scanf("%f %f",&w,&h);
    bmi=(w/h*100/h*100);
    if(bmi>=30)
        printf("Obese,%f",bmi);
    if(bmi<30&&bmi>=25)
        printf("Overweight,%f" ,bmi);
    if(bmi<25&&bmi>=18.5)
        printf("Normal,%f" ,bmi);
    if(bmi<18.5)
        printf("Linderweight,%f" ,bmi);
    return 0;
}