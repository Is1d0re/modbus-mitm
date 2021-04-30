# MODBUS MitM

Setup files used in the demonstration outlined at [my blog post](https://blog.is1d0re.com/blog/modbus-mitm)



## Setup Fake Server

On a linux attacker workstation:

``` bash
$ sudo java -jar ModbusPal.jar
```
1. This will start the fake server app. 
2. Add a slave. 
3. Assign it a slave ID of 1. 
4. Click the eyeball.
5. Add the default amount of holding registers.
6. Add the default amount of coils
7. Populate coils one and two with "1"s and holding register two with "7500".
8. Close this submenu.
9. Click on "Run" in the main menu.

## Setup the Simulated Centrifuge Server

On a Linux workstation:

``` bash
$ sudo java -jar ModbusPal.jar
```
1. Click the "Load" button.
2. Select the `real_server.xmpp` file.
3. Add a slave with ID 1.
4. Click the eyeball.
5. Add the default amount of holding registers.
6. Add the default amount of coils.
7. Click the first holding register to highlight it, and click "Bind".
8. Select "Voltage" from the left column and "Binding_SINT16" from the right column. Then press "OK".
9. Click the third holding register to highlight it, and click "Bind".
10. Select "run time" from the left column and "Binding_SINT16" from the right column. Then press "OK".
11. Back on the main menu click "Start All" in the Automations area.
12. Click the "Run" button at the top of the screen.


## Connect Fake Server to Real Server
1. Open the `fake_server_data.py` file
2. Make sure the IP's are set correctly

``` python
ATTACKER_IP = '' #change me
REAL_SERVER_IP = '' #IP for the centrifuge host
```

3. Save and close the file
4. Start the script: 

``` bash
$ python3 fake_server_data.py
```

5. Start the `centrifuge_monitor.py` script:

```bash
$ sudo python3 centrifuge_monitor.py
```

## Start the Spoof Attack
1. Open the `arp_spoof.py` file
2. Make sure the IP's and MAC are correct
``` python
ATTACKER_MAC = "" #change me
REAL_SERVER_IP = '' #centrifuge workstation IP
REAL_SERVER_MAC = '' #centrifuge workstation MAC
HMI_IP = '' #change me
```
3. Save and close the file
4. Add our iptables rule to forward all intercepted traffic to our fake modbus server.
``` bash
$ sudo iptables -t nat -A PREROUTING -p tcp --destination-port 502 -j REDIRECT --to-port 502
```
5. Start the script
``` bash
$ python3 arp_spoof.py
```
6. To stop the spoof, just press `Ctrl+C` and it will automatically undo the spoofed MAC.

## Setup the HMI
1. Download and install Visual Studio.
2. Download AdvancedHMI.
3. Replace the copy the files from the AdvancedHMI folder from this repository into your local ~\AdvancedHMIv399xR1\AdvancedHMI\ folder (replace the ones already in there).
4. Open the AdvancedHMI project file in Visual Studio.
5. Click on the ModbusTCPConnection object (at the bottom of the main design window).
6. In the properties section change the IP to the IP of your centrifuge workstation. 
7. Click the green play button at the top to run it. 

## Setup Malicious Commands
1. Update the IP for the workstation hosting your centrifuge server.
``` python
REAL_SERVER_IP = '' #centrifuge workstation IP
```
