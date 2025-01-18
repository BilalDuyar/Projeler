Texas Instruments TM4C123GH6PM mikrodenetleyicisi üzerinde hibernation (derin uyku) modunun nasıl yapılandırılacağını ve bu moddan çıkış için harici kesmelerin nasıl kullanılacağını gösteren bir örnek kod içermektedir.

Kod, mikrodenetleyicinin enerji tasarrufu sağlamak amacıyla derin uyku moduna geçirilmesini ve bu moddan çıkmak için GPIO kesmelerinin kullanımını içerir. Ayrıca, LED'lerin kesmelere bağlı olarak kontrol edilmesi örneklenmiştir.

Özellikler

1) Mikrodenetleyicinin minimum güç tüketimi için yapılandırılması.
2) Hibernation moduna geçiş ve çevre birimlerinin kapatılması.
3) Derin uyku modundan çıkış için GPIO kesmelerinin kullanımı.
4) PF0 ve PF4 pinleri düşen kenar kesmeleri için yapılandırılır.
5) Kesme gerçekleştiğinde derin uykudan çıkış sağlanır ve LED'ler kontrol edilir.

Kodun Öne Çıkanları

1) SysCtlDeepSleep() fonksiyonu ile mikrodenetleyiciyi hibernation moduna geçirir.
2) SysCtlDeepSleepClockConfigSet() ile çevre birimleri için saat yapılandırması yapılabilir.
3) Enerji tasarrufu için SRAM ve flash güç yönetimi.

Nasıl Çalışır ?

1) Sistem saati ve GPIO yapılandırması yapılır.
2) PF0 ve PF4 pinleri için düşen kenar kesmeleri tanımlanır.
3) SysCtlDeepSleep() ile mikrodenetleyici derin uyku moduna geçirilir.
4) Harici bir kesme tetiklendiğinde mikrodenetleyici uyanır ve ilgili işlem yapılır.
