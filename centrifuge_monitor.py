from pymodbus.constants import Endian
from pymodbus.payload import BinaryPayloadDecoder
from pymodbus.client.sync import ModbusTcpClient
import os, signal
import time

REAL_SERVER_IP = '127.0.0.1'

client_real_server = ModbusTcpClient(REAL_SERVER_IP, port=502)  # real server.

connection = client_real_server.connect()

countdown = 30

def kill_process():
    target_process = "ModbusPal.jar"
    try:
        # iterating through each instance of the proess
        for line in os.popen("ps ax | grep " + target_process + " | grep -v grep"): 
            fields = line.split()
            
            # extracting Process ID from the output
            pid = fields[0] 
              
            # terminating process 
            client_real_server.close()
            os.kill(int(pid), signal.SIGKILL) 
        print('Centrifuge successfully destroyed!')
        exit()     
    except:
        print("Error Encountered while killing process")



if connection:
    print('safety controls engaged: RPM capped at 7500')
    while 1==1:
        #read the real coils
        real_coils = client_real_server.read_coils(address=0x00, count=0x05, unit=0x01).bits
        #check if safety is turned on
        while real_coils[1] == True:
            #check if safety control is still True
            real_coils = client_real_server.read_coils(address=0x00, count=0x05, unit=0x01).bits
            RPM_register = client_real_server.read_holding_registers(address=0x01, count=1,unit=0x01).registers
            if RPM_register[0] > 7500:
                client_real_server.write_registers(1, 7500, unit=1)
                print('safety control triggered!')
            else:
                continue
        print('safety controls are NOT engaged!')
        while real_coils[1] == False:
            #check the RPMs
            RPM_register = client_real_server.read_holding_registers(address=0x01, count=1,unit=0x01).registers[0]
            #check if safety control is still False
            real_coils = client_real_server.read_coils(address=0x00, count=0x05, unit=0x01).bits
            if real_coils[1] == True:
                print('safety controls have been RE-engaged! RPM capped at 7500')
                time.sleep(1)
                break
            #check if it's above 7500
            if RPM_register > 7500:
                print('catastrophic failure in ' + str(countdown) + ' seconds!')
                countdown = countdown - 1
                time.sleep(1)
                RPM_register = client_real_server.read_holding_registers(address=0x01, count=1,unit=0x01).registers[0]
                if countdown == 0:
                    kill_process()
            else:
                if countdown < 30:
                    print('RPMs returned to safe threshold. Countdown aborted!')
                    countdown = 30
                    continue
        
    client_real_server.close()

else:
    print('Connection lost, Try again')