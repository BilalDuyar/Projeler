#include <stdint.h>
#include <stdbool.h>
#include "inc/tm4c123gh6pm.h"
#include "driverlib/sysctl.h"
#include "driverlib/fpu.h"

int main(void) {
    // Floating-Point Unit'u etkinleþtir
    FPUEnable();
    FPUStackingEnable();

    // Sistem saatini ayarla (örneðin, 50 MHz)
    SysCtlClockSet(SYSCTL_SYSDIV_4 | SYSCTL_USE_PLL | SYSCTL_OSC_MAIN | SYSCTL_XTAL_16MHZ);

    // Floating-point deðiþkenler
    float number1 = 12.5f;
    float number2 = 3.4f;
    float result_add, result_sub, result_mul, result_div;

    // Floating-point iþlemleri
    result_add = number1 + number2; // Toplama
    result_sub = number1 - number2; // Çýkarma
    result_mul = number1 * number2; // Çarpma
    result_div = number1 / number2; // Bölme

    // Sonsuz döngü (sonuçlarý burada bir debugger ile gözlemleyebilirsiniz)
    while (1) {
    }
}

