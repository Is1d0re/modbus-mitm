from pymodbus.constants import Endian
from pymodbus.payload import BinaryPayloadDecoder
from pymodbus.client.sync import ModbusTcpClient
import time

REAL_SERVER_IP = '' #centrifuge workstation IP

client_real_server = ModbusTcpClient(REAL_SERVER_IP, port=502)  # real server.
connection = client_real_server.connect()


if connection:
    print('disabling safety controls...')
    client_real_server.write_coils(1, [False], unit=1)
    time.sleep(2)
    print('increasing RPMs to 14000')
    client_real_server.write_registers(1, 14000, unit=1)
    time.sleep(2)
    current_RPM = client_real_server.read_holding_registers(address=0x01, count=1,unit=0x01).registers
    print('centrifuge RPMs are now set to: ' + str(current_RPM[0]))
    client_real_server.close()
    
   

else:
    print('Connection lost, Try again')
