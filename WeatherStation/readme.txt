WeatherStation Project
(c) 2013-2015 by Emchenko Boris
http://astromania.info/

WeatherStation Monitor is a part of DIY Weather Station Project (more details can be found at http://www.astronomy.ru/forum/index.php/topic,118732.0.html [russian] or at mother site http://astromania.info [russian]).
In brief it consists of three parts:

1. Arduino based hardware part.
- Based on Arduino Uno R3 
- Cloud sensor MLX90614
- Humidity sensors DHT22 (two)
- Pressure sensors BMP085
- Illuminance sensor BH1750
- DS18B20 one wire temperature sensors
- heating relay
- Ethernet Shield (optional)

2. Windows application "WeatherStation Monitor" (you see it)
- used to read data from hardware
- Emulate Boltwood Cloud Sensor for astronomy purposes
- Store data locally
- Send data to internet services, including custom site

3. Web part using mysql and PHP
This is PHP scritps which are used to plot graphics. 
Credits to pChart library by Jean-Damien POGOLOTTI

******************************
WeatherStation Monitor usage
******************************
WeatherStation Monitor were built using ClickOnce deployment tool which seems to be a bit uncommon in usage.
It hides .exe somewhere in its cache (in some ugly place like "c:\Users\*your profile*\AppData\Local\Apps\2.0\92A91HHM.J8K\A984LVC1.0Q1\weat..tion_60e97b25c1e8d913_0001.0006_aebf584aae92df7f") and automatically creates .appref-ms shortcut on Desktop and StartMenu for program run.

Also after first use, program creates "WeatherStation Monitor autostart.lnk" file on desktop to run program with command line parameters.

It should be somethink like:
"C:\Users\*your profile*\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Astromania.info\WeatherStation Monitor.appref-ms" "start com3"

- [start] optional parameter is used to automatically run sensor measuring after program start.
- [com3] optional parameter can be used to override serial port name specified in program settings.

*****************************
Remote controlling
*****************************
WeatherStation Monitor can communicate with other programs using TCP sockets. It has built it socket server for client connecting.

Communications protocol.
Client (C)
WeatherStation Monitor server (S)

(S) on connecting (C) will send message "Connected to WeatherStation Monitor"

(C) commands:
HELP
GET_SENSOR_VALUES
VERSION


