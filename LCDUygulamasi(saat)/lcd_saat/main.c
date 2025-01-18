#include"inc/tm4c123gh6pm.h"
#include <stdint.h>
#include <stdbool.h>
#include "inc/hw_memmap.h"
#include "inc/hw_types.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/pin_map.h"
#include "driverlib/interrupt.h"
#include "inc/hw_gpio.h"
#include "inc/hw_ints.h"
#include "inc/hw_sysctl.h"
#include "lcd_saat.h"
#include "driverlib/interrupt.h"
#include "driverlib/sysctl.c"
#include "driverlib/systick.h"
#include "driverlib/systick.c"
#include "driverlib/timer.h"
#include "driverlib/timer.c"


    void timer0IntHandler(void);
    int sn_birler=0;
    int sn_onlar=0;
    int dk_birler=0;
    int dk_onlar=0;
    int saat_birler=0;
    int saat_onlar=0;

    int main(void)
    {
        baslangic();

        SysCtlClockSet(SYSCTL_SYSDIV_20|SYSCTL_USE_PLL|SYSCTL_XTAL_16MHZ|SYSCTL_OSC_MAIN);  //40mhz  400/2/5=40

        SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);    // cevre birimi aktif // SYSCTL_RCGCGPIO_R|=0x20; // portf saat aktif
        // SYSCTL_RCGCTIMER_R|=0x01; // (1<<0)
        GPIOPinTypeGPIOOutput(GPIO_PORTF_BASE, GPIO_PIN_1|GPIO_PIN_2|GPIO_PIN_3);   // pin 123 output
        // timer ayarları
        SysCtlPeripheralEnable(SYSCTL_PERIPH_TIMER0);

        IntMasterEnable();

        IntEnable(INT_TIMER0A);
        TimerConfigure(TIMER0_BASE, TIMER_CFG_PERIODIC);    // down sayıcı // split pair =16 bitlik demek
        //    TIMER0_TAMR_R|=0x02;    //  0000 0010   (1<<1) // periyodik mod
        TimerIntEnable(TIMER0_BASE, TIMER_TIMA_TIMEOUT);    // interrupt ne zaman oluşacak

        TimerLoadSet(TIMER0_BASE, TIMER_A, SysCtlClockGet()-1); // 40000000-1 = 1 saniye için 40 milyon kare dalga sayacak
        // timer ilk değer yükleniyor
        //    TIMER0_TAILR_R= 49999;  // 16 000 000 1 saniye istedim // ilk değer // taştığında otomatik geri yüklüyor
        TimerIntRegister(TIMER0_BASE, TIMER_A, timer0IntHandler);
        TimerEnable(TIMER0_BASE, TIMER_A);  // setb TR0 diyerek başlatılıyor

        while(1)
        {
        }


    }

    void timer0IntHandler(void)
    {
        TimerIntClear(TIMER0_BASE, TIMER_TIMA_MATCH);   // bayrak temizlendi
        if(sn_birler>=0)
        {
            satir_sutun(2,16);
            veri(48+sn_birler);

            satir_sutun(2,15);
            veri(48+sn_onlar);

            satir_sutun(2,14);
            veri(58);           // 58 ascı kodunda :

            satir_sutun(2,13);
            veri(48+dk_birler);

            satir_sutun(2,12);
            veri(48+dk_onlar);

            satir_sutun(2,11);
            veri(58);

            satir_sutun(2,10);
            veri(48+saat_birler);

            satir_sutun(2,9);
            veri(48+saat_onlar);

            sn_birler++;

            if(sn_birler>9)
            {
                sn_birler=0;
                sn_onlar++;
            }
            if(sn_onlar>5)
            {
                sn_onlar=0;
                dk_birler++;
            }
            if(dk_birler>9)
            {
                dk_birler=0;
                dk_onlar++;
            }
            if(dk_onlar>5)
            {
                dk_onlar=0;
                saat_birler++;
            }
            if(saat_birler>9)
            {
                saat_birler=0;
                saat_onlar++;
            }
            if(saat_onlar==2 & saat_birler==4)
            {
                saat_onlar=0;
                saat_birler=0;
            }

        }

    }


