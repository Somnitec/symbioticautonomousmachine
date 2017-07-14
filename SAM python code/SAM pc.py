import serial
import time
import win32ui
import random
import datetime

ser = serial.Serial('COM4', 9600)
while True:
    msg = ser.readline().strip() # read everything in the input buffer
    print ("Message from arduino: ")
    print (msg)
    if msg == b'a':
        userinput = float(input("The cents will be: "))
        total = round(1+userinput/100,2)
        price = round(total/1.06,2)
        btw = round(total-price,2)
        print( "the price is "+str(total))
        input("izettle transaction completed?")
        print ("transaction succeeded, can pump ")
        ser.write(b'3')
        
        time.sleep(.1)
        ser.flush()
        ser.flushInput()
        ser.flushOutput()
        time.sleep(.1)
        print ("flushing")
        
    if msg == b'b':
        print ("printing now: ")

        mylist = []
        today = datetime.date.today()
        mylist.append(today)

        file = open('receiptno.txt', 'r') 
        receiptno = int(file.readline())
        receiptno+=1
        file = open('receiptno.txt', 'w')
        file.write(str(receiptno))
        file.close()

        hDC = win32ui.CreateDC ()
        hDC.CreatePrinterDC ("POS-58")
        hDC.StartDoc ("receipt"+str(receiptno).zfill(3))
        hDC.StartPage ()


        pagewidth =390

        fontsize = 32
        linedistance = int(1.2*fontsize)

        fontnormal = win32ui.CreateFont({
            "name": "Roboto",
            "height": fontsize,
            "weight": 500,
        })
        fontitalic = win32ui.CreateFont({
            "name": "Roboto",
            "height": int(fontsize*0.6),
            "weight": 400,
            "italic": True,
        })
        fontbig = win32ui.CreateFont({
            "name": "Roboto",
            "height": int(fontsize*1.1),
            "weight": 700,
        })

        hDC.SelectObject(fontnormal)
        hDC.TextOut(170,0*linedistance,"SAM")
        hDC.TextOut(2,1*linedistance,"Symbiotic Autonomous Machine")

        hDC.SelectObject(fontitalic)
        hDC.TextOut(0,6*linedistance,"R n."+str(receiptno).zfill(3) )
        hDC.TextOut(230,6*linedistance,time.strftime("%H:%M:%S")+"  "+str(mylist[0]))

        hDC.SelectObject(fontnormal)
        hDC.TextOut(0,8*linedistance,"1 cup kefir soda")
        hDC.TextOut(315,8*linedistance,u"\u20ac"+"%0.2f" %price)
        hDC.TextOut(0,9*linedistance,"BTW 6%")
        hDC.TextOut(315,9*linedistance,u"\u20ac"+"%0.2f" %btw)
        hDC.TextOut(0,11*linedistance,"Total")
        hDC.TextOut(315,11*linedistance,u"\u20ac"+"%0.2f" %total)

        hDC.TextOut(50,15*linedistance,"Rate your soda out of 5")
        hDC.TextOut(25,16*linedistance,"on twitter @nonhumanSAM")

        hDC.SelectObject(fontbig)
        hDC.TextOut(0,18*linedistance,"Thanks for keeping me alive")
        hDC.TextOut(80,19*linedistance,"and functioning!")

        hDC.SelectObject(fontitalic)
        hDC.TextOut(90,22*linedistance,"email: sam@nonhuman.club")
        hDC.TextOut(100,int(22.5*linedistance),"web: sam.nonhuman.club")

        
        
        hDC.TextOut(90,int(23.5*linedistance),"towards a collaborative future")
        hDC.TextOut(100,int(24*linedistance),"for man and machine")


        pen = win32ui.CreatePen(0,5, 0)
        hDC.SelectObject(pen)
        hDC.MoveTo(pagewidth,0)#margin line, remove later
        hDC.LineTo(pagewidth,1000)#margin line, remove later

        hDC.MoveTo(0,int(3.5*linedistance))
        hDC.LineTo(pagewidth,int(3.5*linedistance))

        hDC.MoveTo(0,int(14.5*linedistance))
        hDC.LineTo(pagewidth,int(14.5*linedistance))

        hDC.MoveTo(0,int(20.5*linedistance))
        hDC.LineTo(pagewidth,int(20.5*linedistance))


        hDC.EndPage ()
        hDC.EndDoc ()

        ser.write(b'0')#let the arduino know we're done
        print ("printing done: ")
        
        time.sleep(.1)
        ser.flush()
        ser.flushInput()
        ser.flushOutput()
        time.sleep(.1)
        print ("flushing")
        

