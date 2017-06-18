import serial
ser = serial.Serial('COM3', 9600)
while True:
    msg = ser.readline().strip() # read everything in the input buffer
    print ("Message from arduino: ")
    print (msg)
    if msg == b'a':
        print ("aw yeah")
        

