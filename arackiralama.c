#include  <stdio.h>
int main(void)
{
    double tkm = 0.0;
    do
    {
        printf("Toplam km: "); scanf("%lf", &tkm);
        if (tkm < 500) printf("Toplam %.2lfTL odenmesi gerekmektedir.\n\n", tkm * 2.3);
        else if (tkm >= 500) printf("Toplam %.2lfTL odenmesi gerekmektedir.\n\n", ((tkm - 500) * 1.6 + (500 * 2)));
    } while (tkm > 0);
}
