# Запуск БКО в Linux #

Используем wine.


# Пошаговая инструкция #

Первоночально имеем линукс, установленный wine и установленную БКО:
  * скачиваем winetrick
```
wget http://www.kegel.com/wine/winetricks
chmod +x winetricks
./winetricks 
```
  * далее нужно поставить .NET Framework.
```
winetricks dotnet11
winetricks dotnet20
winetricks dotnet30


```

  * Еще нужно поставить MDAC 2.8 и jet4


  * Для отчетов нужно установить офисный пакет.

[Обсуждение на форуме ](http://bko.shatki.info/forum/index.php/topic,838.msg3194.html#msg3194)


